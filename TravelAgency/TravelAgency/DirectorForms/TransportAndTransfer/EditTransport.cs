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
    public partial class EditTransport : Form, IViewEditTransport
    {
        private List<CheckBox> radioButtons = new List<CheckBox>();
        private Dictionary<string, object> infoToUpdate = new Dictionary<string, object>();
        private Dictionary<string, bool> addOrDeleteFacilities = new Dictionary<string, bool>();
        private Dictionary<string, bool> temp = new Dictionary<string, bool>();


        private bool checkIfIDChanged;

        public EditTransport()
        {
            InitializeComponent();
            createTransportB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
            searchTransportB.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }

        #region --- Interface ---

        public int ID { get; set; }
        public List<string> Facilities { get; set; }
        public bool IsFromTable { get; set; }

        public string ResultOfAdding { get; set; }
        public int ResultOfSearching { get; set; }
        public DataTable facilites { get; set; }

        public Dictionary<string, object> InfoToUpdate { get; set; }
        public Dictionary<string, bool> AddOrDeleteFacilities { get => addOrDeleteFacilities; set => addOrDeleteFacilities = value; }

        public event EventHandler sendInfo;
        public event EventHandler searchInfo;

        public void CloseForm()
        {
            this.Close();
        }
        public void ShowForm()
        {
            if (IsFromTable)
            {
                MakeVisibleOrInvisible(true, true);
                TransportNumTB.Texts = ID.ToString();
            }
            else
                MakeVisibleOrInvisible(false, true);

            this.AcceptButton = searchTransportB;
            this.Show();
        }

        public void AddInfo(List<object> info)
        {
            if (temp.Count > 0)
                temp = new Dictionary<string, bool>();

            nameTB.Texts = info[0].ToString();
            ShortInfoTB.Texts = info[1].ToString();
            ReleaseDateTB.Texts = info[2].ToString();
            CountOfSeatsTB.Texts = info[3].ToString();
            linkPhotoTB.Texts = info[4].ToString();
            if(Facilities != null)
            {
                for (int i = 0; i < Facilities.Count; i++)
                {
                    for (int j = 0; j < radioButtons.Count; j++)
                    {
                        if (Facilities[i].ToString() == radioButtons[j].Text)
                        {
                            radioButtons[j].Checked = true;
                        }
                    }
                }
            }
            
            for(int i = 0; i < radioButtons.Count; i++)
            {
                temp.Add(radioButtons[i].Text, radioButtons[i].Checked);
            }
        }
        public void AddFacilities()
        {
            CheckBox radioButton;

            foreach(DataRow row in facilites.Rows)
            {
                radioButton = new CheckBox();
                radioButton.Text = row[0].ToString();
                radioButtons.Add(radioButton);
            }
            for(int i =0; i < radioButtons.Count; i++)
            {
                if (i <= 8)
                {
                    if (i == 0)
                        radioButtons[i].Location = new Point(ShortInfoTB.Location.X + ShortInfoTB.Size.Width + 166, ShortInfoTB.Location.Y );
                    else
                    {
                        radioButtons[i].Location = new Point(ShortInfoTB.Location.X + ShortInfoTB.Size.Width + 166, ShortInfoTB.Location.Y + radioButtons[i - 1].Size.Height); 
                    }
                }
                else
                {
                    if (i > 8)
                        radioButtons[i].Location = new Point(radioButtons[0].Location.X + 166, ShortInfoTB.Location.Y);
                    else
                    {
                        radioButtons[i].Location = new Point(radioButtons[0].Location.X + 166, ShortInfoTB.Location.Y + radioButtons[i - 1].Size.Height); 
                    }
                }
                radioButtons[i].Font = new Font("Franklin Gothic Book", 20);
                radioButtons[i].ForeColor = Color.Black;
                radioButtons[i].Size = new Size(250, 35);
                radioButtons[i].FlatStyle = FlatStyle.Popup;
                radioButtons[i].Visible = false;
                this.Controls.Add(radioButtons[i]);
            }
        }
        #endregion

        private void TransportNumTB__TextChanged(object sender, EventArgs e)
        {
            if (checkIfIDChanged)
            {
                DialogResult dres = MessageBox.Show("Якщо ви змінете номер, інформація, яку Ви змінили не буде збережена", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dres == DialogResult.OK)
                {
                    checkIfIDChanged = false;
                    infoToUpdate.Clear();
                    MakeVisibleOrInvisible(false, false);
                }
            }
            if (String.IsNullOrEmpty(TransportNumTB.Texts) || !int.TryParse(TransportNumTB.Texts, out int result))
            {
                TransportNumTB.BorderColor = Color.Red;
            }
            else
            {
                ID = result;
                TransportNumTB.BorderColor = Color.Black;
            }
        }

        private void nameTB__TextChanged(object sender, EventArgs e)
        {
            if (nameTB.Texts == null)
                nameTB.BorderColor = Color.Red;
            else
            {
                nameTB.BorderColor = Color.Black;
                if (!infoToUpdate.ContainsKey("Name"))
                    infoToUpdate.Add("Name", nameTB.Texts);
                else
                    infoToUpdate["Name"] = nameTB.Texts;
            }
        }

        private void ShortInfoTB__TextChanged(object sender, EventArgs e)
        {
            //ShortInfo = ShortInfoTB.Texts;
            if (ShortInfoTB.Texts == null)
                ShortInfoTB.BorderColor = Color.Red;
            else
            {
                ShortInfoTB.BorderColor = Color.Black;
                if (!infoToUpdate.ContainsKey("ShortInfo"))
                    infoToUpdate.Add("ShortInfo", ShortInfoTB.Texts);
                else
                    infoToUpdate["ShortInfo"] = ShortInfoTB.Texts;
            }
        }

        private void linkPhotoTB__TextChanged(object sender, EventArgs e)
        {
            if (linkPhotoTB.Texts == null)
                linkPhotoTB.BorderColor = Color.Red;
            else
            { 
                linkPhotoTB.BorderColor = Color.Black;
                if (!infoToUpdate.ContainsKey("LinkPhoto"))
                    infoToUpdate.Add("LinkPhoto", linkPhotoTB.Texts);
                else
                    infoToUpdate["LinkPhoto"] = linkPhotoTB.Texts;
            }
        }

        private void editTransportB_Click(object sender, EventArgs e)
        {
            CheckChanged();
            if (infoToUpdate.Count > 0 || AddOrDeleteFacilities.Count > 0)
            {
                if (!String.IsNullOrEmpty(nameTB.Texts) && !String.IsNullOrEmpty(ReleaseDateTB.Texts) && !String.IsNullOrEmpty(ShortInfoTB.Texts) && !String.IsNullOrEmpty(linkPhotoTB.Texts) && int.Parse(CountOfSeatsTB.Texts) > 0)
                {
                    InfoToUpdate = infoToUpdate;
                    sendInfo?.Invoke(this, EventArgs.Empty);

                    if (ResultOfAdding != null)
                    {
                        addOrDeleteFacilities.Clear();
  
                        MessageBox.Show(ResultOfAdding, "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        temp.Clear();
                        addOrDeleteFacilities.Clear();
                        MessageBox.Show("Інформацію про транспорт оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MakeVisibleOrInvisible(false, false);
                    }
                }
                else
                {
                    MessageBox.Show("Перевірте чи усі поля заповнено!", "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не має даних для зміни!", "Дані відсутні", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CheckChanged()
        {
            if (CountOfSeatsTB.Texts != "")
            {
                if (infoToUpdate.ContainsKey("CountOfSeats"))
                {
                    infoToUpdate["CountOfSeats"] = CountOfSeatsTB.Texts;
                }
                else
                    infoToUpdate.Add("CountOfSeats", CountOfSeatsTB.Texts);
                
                CountOfSeatsTB.BorderColor = Color.Black;
            }
            else
            {
                CountOfSeatsTB.BorderColor = Color.Red;

            }
            if (ReleaseDateTB.Texts != "")
            {
                if (infoToUpdate.ContainsKey("ReleaseDate"))
                {
                    infoToUpdate["ReleaseDate"] = ReleaseDateTB.Texts;
                }
                else
                    infoToUpdate.Add("ReleaseDate", ReleaseDateTB.Texts);
                ReleaseDateTB.BorderColor = Color.Black;

            }
            else
            {
                ReleaseDateTB.BorderColor = Color.Red;
            }
            
            for (int j = 0; j < radioButtons.Count; j++)
            {
                if (temp[radioButtons[j].Text] != radioButtons[j].Checked)
                {
                    addOrDeleteFacilities.Add(radioButtons[j].Text, radioButtons[j].Checked);
                }

            }
            
        }
        private void searchTransportB_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TransportNumTB.Texts, out int res))
            {
                if (res != ID)
                {
                    searchInfo?.Invoke(this, EventArgs.Empty);
                    if (ResultOfSearching == 0)
                    {
                        temp.Clear();

                        MessageBox.Show("Транспорта з таким номером не має!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MakeVisibleOrInvisible(false, false);

                    }
                    else
                    {
                        temp.Clear();
                        MakeVisibleOrInvisible(true, false);
                        checkIfIDChanged = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Перевірте правильність вводу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeVisibleOrInvisible(bool check, bool isStart)
        {
            if(check)
            {
                createTransportB.Visible = true;
                label1.Visible = label3.Visible = label4.Visible = label5.Visible = label2.Visible = true;
                nameTB.Visible = ReleaseDateTB.Visible = CountOfSeatsTB.Visible = ShortInfoTB.Visible = linkPhotoTB.Visible = true;
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    radioButtons[i].Visible = true;
                }
                this.AcceptButton = createTransportB;
            }
            else
            {
                createTransportB.Visible = false;
                label1.Visible = label3.Visible = label4.Visible = label5.Visible = label2.Visible = false;
                nameTB.Texts = ReleaseDateTB.Texts = CountOfSeatsTB.Texts = ShortInfoTB.Texts = linkPhotoTB.Texts = "";
                nameTB.Visible = ReleaseDateTB.Visible = CountOfSeatsTB.Visible = ShortInfoTB.Visible = linkPhotoTB.Visible = false;
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    radioButtons[i].Visible = false;
                    if(isStart)
                        radioButtons[i].Checked = false;
                }
                this.AcceptButton = searchTransportB;
            }
            
        }

    }
}
