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
    public partial class CreateNewTransport : Form, IViewCreateNewTransport
    {
        private string name;
        private List<CheckBox> radioButtons = new List<CheckBox>();
        private List<string> facility = new List<string>();

        public CreateNewTransport()
        {
            InitializeComponent();
            
            //.ForeColor = surnameL.ForeColor = secondNameL.ForeColor = ColorTranslator.FromHtml("#7B7B7B");
            createTransportB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8"); 
        }
        #region --- Interface ---
        public string Name { get; set; }
        public int CountOfSeats { get; set; }
        public string ReleaseDate { get; set; }
        public string ShortInfo { get; set; }
        public string linkPhoto { get; set; }
        public List<string> Facilities { get => facility; set => facility = value; }

        public string ResultOfAdding { get; set; }
        public DataTable facilites { get; set; }
        //public string ResultOfAdding { get => resultOfAdding; set => resultOfAdding = value; }
        public event EventHandler sendInfo;

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowForm()
        {
            AddFacilities();
            this.Show();
        }
        #endregion
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
                        radioButtons[i].Location = new Point(ShortInfoTB.Location.X + ShortInfoTB.Size.Width + 166, ShortInfoTB.Location.Y);
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
                radioButtons[i].Visible = true;
                radioButtons[i].FlatStyle = FlatStyle.Popup;
                this.Controls.Add(radioButtons[i]);
            }
        }

        private void nameTB__TextChanged(object sender, EventArgs e)
        {
            Name = nameTB.Texts;
            if (nameTB.Texts == null)
                nameTB.BorderColor = Color.Red;
            else
                nameTB.BorderColor = Color.Black;
        }

        private void ReleaseDateTB__TextChanged(object sender, EventArgs e)
        {
            
            if (ReleaseDateTB.Texts == null)
                ReleaseDateTB.BorderColor = Color.Red;
            else
                ReleaseDateTB.BorderColor = Color.Black;
        }

        private void customMaskedTextBoxDate1__TextChanged(object sender, EventArgs e)
        {
            
            if (CountOfSeatsTB.Texts == null)
                CountOfSeatsTB.BorderColor = Color.Red;
            else
                CountOfSeatsTB.BorderColor = Color.Black;
        }

        private void ShortInfoTB__TextChanged(object sender, EventArgs e)
        {
            ShortInfo = ShortInfoTB.Texts;
            if (ShortInfoTB.Texts == null)
                ShortInfoTB.BorderColor = Color.Red;
            else
                ShortInfoTB.BorderColor = Color.Black;
        }

        private void linkPhotoTB__TextChanged(object sender, EventArgs e)
        {
            linkPhoto = linkPhotoTB.Texts;
            if (linkPhotoTB.Texts == null)
                linkPhotoTB.BorderColor = Color.Red;
            else
                linkPhotoTB.BorderColor = Color.Black;
        }

        private void createTransportB_Click(object sender, EventArgs e)
        {
            if(CountOfSeatsTB.Texts != "")
                CountOfSeats = Convert.ToInt32(CountOfSeatsTB.Texts);
            if (ReleaseDateTB.Texts != "")
                ReleaseDate = ReleaseDateTB.Texts;
            if (!String.IsNullOrEmpty(Name) && !String.IsNullOrEmpty(ReleaseDateTB.Texts) && !String.IsNullOrEmpty(ShortInfoTB.Texts) && !String.IsNullOrEmpty(linkPhotoTB.Texts) && CountOfSeats > 0) 
            {
                for(int i = 0; i < radioButtons.Count; i++)
                {
                    if (radioButtons[i].Checked)
                        facility.Add(radioButtons[i].Text);
                }
                sendInfo?.Invoke(this, EventArgs.Empty);

                if(ResultOfAdding != null)
                {
                    MessageBox.Show(ResultOfAdding, "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Додано новий транспорт", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameTB.Texts = linkPhotoTB.Texts = ShortInfoTB.Texts = CountOfSeatsTB.Texts = ReleaseDateTB.Texts = null;
                    for(int i = 0; i < radioButtons.Count; i++)
                    {
                        radioButtons[i].Checked = false;
                    }
                    facility.Clear();
                    Name = ReleaseDate = ShortInfo = linkPhoto = null;
                    CountOfSeats = 0;
                }
            }
            else
            {
                MessageBox.Show("Перевірте чи усі поля заповнено!", "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
