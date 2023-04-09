using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Design;
using TravelAgency.Views;
using TravelAgency.Views.DirectorViews.Transports_Transfers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace TravelAgency
{
    public partial class EditTransfer : Form, IViewEditTransfer
    {
        private bool checkIfIDChanged;
        private Dictionary<string, object> data = new Dictionary<string, object>();

        public EditTransfer()
        {
            InitializeComponent();
            createTransportB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
            searchTransportB.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }

        #region --- Interface ---

        public int ID { get; set; }
        public string Error { get; set; }
        public int ResultOfSearching { get; set; }
        public List<object> InfoFromTable { get; set; }
        public Dictionary<string, object> dataToUpdate { get => data; }
        public bool IsFromTable { get; set; }
        
        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm(List<string> transport, List<string> depCity, List<string> cityToVisit)
        {
            if (transport.Count > 0)
            {
                availableTransportsTB.Items.AddRange(transport.Count > 0 ? transport.ToArray() : null);
            }
            fromWhereCB.Items.AddRange(depCity.Count > 0 ? depCity.ToArray() : null);
            toWhereCB.Items.AddRange(cityToVisit.Count > 0 ? cityToVisit.ToArray() : null);
            if (IsFromTable)
            {
                MakeVisibleOrInvisible(true, true);
                
            }
            else
            {
                MakeVisibleOrInvisible(false, true);
            }
            this.Show();
        }
        public void ShowInfoFromTable(List<object> info, int id)
        {
            TransferNumTB.Texts = id.ToString();
            availableTransportsTB.Texts = info[0].ToString();
            fromWhereCB.Texts = info[1].ToString();
            toWhereCB.Texts = info[2].ToString();
            CostTB.Texts = info[3].ToString();
            MakeVisibleOrInvisible(true, false);
            checkIfIDChanged = true;

        }
        public event EventHandler SearchInfo;
        public event EventHandler UpdateInfo;
        
        #endregion
        
        private void TransportNumTB__TextChanged(object sender, EventArgs e)
        {
            if (checkIfIDChanged)
            {
                DialogResult dres = MessageBox.Show("Якщо ви змінете номер, інформація, яку Ви змінили не буде збережена", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dres == DialogResult.OK)
                {
                    checkIfIDChanged = false;
                    data.Clear();
                    MakeVisibleOrInvisible(false, false);
                }
            }
            if (String.IsNullOrEmpty(TransferNumTB.Texts) || !int.TryParse(TransferNumTB.Texts, out int result))
            {
                TransferNumTB.BorderColor = Color.Red;
            }
            else
            {
                //ID = result;
                TransferNumTB.BorderColor = Color.Black;
            }
        }
        private void searchTransportB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TransferNumTB.Texts, out int res))
            {
                if (res != ID)
                {
                    ID = res;
                    SearchInfo?.Invoke(this, EventArgs.Empty);
                    if (ResultOfSearching == 0)
                    {
                        //temp.Clear();

                        MessageBox.Show("Транспорта з таким номером не має!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MakeVisibleOrInvisible(false, false);

                    }
                    else
                    {
                        //temp.Clear();
                        if (InfoFromTable.Count > 0)
                        {
                            availableTransportsTB.Texts = InfoFromTable[0].ToString();
                            fromWhereCB.Texts = InfoFromTable[1].ToString();
                            toWhereCB.Texts = InfoFromTable[2].ToString();
                            CostTB.Texts = InfoFromTable[3].ToString();
                            MakeVisibleOrInvisible(true, false);
                            checkIfIDChanged = true;
                        }
                        else
                            MessageBox.Show("Немає інформації про транспорт з таким номером", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ви вже переглядаєте цей трансфер", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Перевірте правильність вводу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MakeVisibleOrInvisible(bool check, bool isStart)
        {
            if (check)
            {
                createTransportB.Visible = true;

                label1.Visible = label4.Visible = label5.Visible = label2.Visible = true;
                availableTransportsTB.Visible = fromWhereCB.Visible = toWhereCB.Visible = CostTB.Visible = true;
                
                this.AcceptButton = createTransportB;
            }
            else
            {
                createTransportB.Visible = false;

                label1.Visible = label4.Visible = label5.Visible = label2.Visible = false;
                availableTransportsTB.Visible = fromWhereCB.Visible = toWhereCB.Visible = CostTB.Visible = false;

                this.AcceptButton = searchTransportB;
            }

        }

        private void createTransportB_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(availableTransportsTB.Texts) && !String.IsNullOrEmpty(toWhereCB.Texts) && !String.IsNullOrEmpty(fromWhereCB.Texts) && AddAndCheck())
            {
                data.Add("Name", availableTransportsTB.Texts);
                data.Add("toWhere", toWhereCB.Texts);
                data.Add("fromWhere", fromWhereCB.Texts);

                UpdateInfo?.Invoke(this, EventArgs.Empty);
                if (String.IsNullOrEmpty(Error) || Error == "")
                {
                    MessageBox.Show("Трансфер успішно створено", "Створено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Clear();
                }
                else
                {
                    MessageBox.Show(Error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool AddAndCheck()
        {
            if (String.IsNullOrEmpty(CostTB.Texts))
            {
                MessageBox.Show("Правильно введіть вартість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (CostTB.Texts.Trim() == ",")
                {
                    
                    MessageBox.Show("Правильно введіть вартість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                double a = Convert.ToDouble(CostTB.Texts);
                if (a <= 0)
                {
                    MessageBox.Show("Правильно введіть вартість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (data.ContainsKey("Cost"))
                    data["Cost"] = double.Parse(CostTB.Texts);
                else
                    data.Add("Cost", double.Parse(CostTB.Texts));
            }

            return true;
        }
    }
}
