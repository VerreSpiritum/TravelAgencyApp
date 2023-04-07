using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Design;
using TravelAgency.Views;
using TravelAgency.Views.DirectorViews.Transports_Transfers;

namespace TravelAgency
{
    public partial class CreateNewTransfer : Form, IViewCreateTransfer
    {
        private Dictionary<string, object> data = new Dictionary<string, object>();

        public CreateNewTransfer()
        {
            InitializeComponent();
            
            createTransportB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8"); 
        }
        #region --- Interface ---

        public Dictionary<string, object> dataToAdd { get => data; set => data = value; }
        public event EventHandler CreateTransfer;
        public event EventHandler ShowCountOfSeats;
        public string Name { get; set; }
        public string Error { get; set; }
        
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
            else
            {
                MessageBox.Show("Немає вільних транспортів", "Застереження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            fromWhereCB.Items.AddRange(depCity.Count > 0 ? depCity.ToArray() : null);
            toWhereCB.Items.AddRange(cityToVisit.Count > 0 ? cityToVisit.ToArray() : null);

            this.Show();
        }
        public void SetCount(int count)
        {
            CountOfSeatsTB.Texts = count.ToString();
        }
        #endregion

        private void createTransportB_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(availableTransportsTB.Texts) && !String.IsNullOrEmpty(toWhereCB.Texts) && !String.IsNullOrEmpty(fromWhereCB.Texts) && AddAndCheck())
            {
                CreateTransfer?.Invoke(this, EventArgs.Empty);
                if(String.IsNullOrEmpty(Error) || Error == "")
                {
                    MessageBox.Show("Трансфер успішно створено", "Створено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private bool AddAndCheck()
        {
            if (String.IsNullOrEmpty(CountOfSeatsTB.Texts) || int.Parse(CountOfSeatsTB.Texts) < 0)
            {
                MessageBox.Show("Правильно заповніть кількість місць", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if(data.ContainsKey("CountOfSeats"))
                    data["CountOfSeats"] = int.Parse(CountOfSeatsTB.Texts);
                else
                    data.Add("CountOfSeats", int.Parse(CountOfSeatsTB.Texts));
            }

            if (String.IsNullOrEmpty(CostTB.Texts) || double.Parse(CostTB.Texts) <= 0)
            {
                MessageBox.Show("Правильно введіть вартість", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (data.ContainsKey("Cost"))
                    data["Cost"] = double.Parse(CostTB.Texts);
                else
                    data.Add("Cost", double.Parse(CostTB.Texts));
            }

            return true;
        }
        private void availableTransportsTB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.ContainsKey("Name"))
            {
                data["Name"] = availableTransportsTB.Texts;
            }
            else
                data.Add("Name", availableTransportsTB.Texts);
            Name = availableTransportsTB.Text;
            ShowCountOfSeats?.Invoke(this, new EventArgs());
        }

        private void fromWhereCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.ContainsKey("fromWhere"))
                data["formWhere"] = fromWhereCB.Texts;
            else
                data.Add("fromWhere", fromWhereCB.Texts);


        }

        private void toWhereCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.ContainsKey("toWhere"))
                data["toWhere"] = toWhereCB.Texts;
            else
                data.Add("toWhere", toWhereCB.Texts);
        }

        private void CreateNewTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
