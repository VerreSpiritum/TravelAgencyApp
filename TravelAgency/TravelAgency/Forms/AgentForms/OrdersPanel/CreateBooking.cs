using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency
{
    public partial class CreateBooking : Form, IViewCreateBooking
    {
        private bool bookT = false;
        private bool bookAT = false;

        public CreateBooking()
        {
            InitializeComponent();
            createNewBookB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");

        }

        #region --- Interface ---

        public int ID { get; set; }
        public int IDAT { get; set; }
        public int IDclient { get; set; }
        public int IDTransport { get; set; }
        public DataTable Transport { get; set; }
        public List<int> HotelInTour { get; set; }

        public DataTable client { get; set; }
        public DataTable infoTour { get; set; }
        public DataTable infoAddTour { get; set; }
        public DataTable infoCitiesAndHotels { get; set; }
        public string Error { get; set; }
        public void ShowForm()
        {
            CTour.OnSelectedIndexChanged += CTour_SelectedIndexChanged;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            AddToTour();
            //pAddTour.Visible = false;
            this.Show();
        }

 

        public void CloseForm()
        {
            this.Close();
        }

        public event EventHandler GetTransport; 
        public event EventHandler GetAddTour;
        public event EventHandler GetCitiesFromTour;
        public event EventHandler GetCitiesFromAddTour;
        public event EventHandler CreateBook;

        #endregion

        private void AddToTour()
        {
            foreach (DataRow row in infoTour.Rows)
            {
                string temp = row[0] + " - " + row[1];
                CTour.Items.Add(temp);
            }

            foreach (DataRow row in client.Rows)
            {
                CClient.Items.Add(row[1]);
            }
        }

        private void CTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(CTour.Texts))
            {
                if (bookT)
                {
                    foreach (DataGridViewRow r in contractInfoTable.Rows)
                    {
                        if (r.Cells[2].Value.Equals("Тур"))
                            contractInfoTable.Rows.Remove(r);
                    } 
                }
                bookT = true;
                string input = CTour.Texts;
                string[] parts = input.Split(new string[] { " - " }, StringSplitOptions.None);
                ID = int.Parse(parts[0]);
                foreach (string part in parts)
                GetAddTour?.Invoke(this, EventArgs.Empty);
                GetTransport?.Invoke(this, EventArgs.Empty);
                pAddTour.Visible = true;
                transferA.Items.Clear();
                addTour.Items.Clear();
                
                foreach (DataRow row in Transport.Rows)
                {
                    string temp = row[0] + " - " + row[1];
                    transferA.Items.Add(temp);
                    
                }
                foreach (DataRow row in infoAddTour.Rows)
                {
                    string temp = row[0] + " - " + row[1];
                    addTour.Items.Add(temp);
                }
                contractInfoTable.Rows.Clear();
                foreach (DataRow row in infoCitiesAndHotels.Rows)
                {
                    int rowNum = 0;
                    string text = row[0] + " " + row[1] + " " + row[2];

                    foreach (DataGridViewRow r in contractInfoTable.Rows)
                    {
                        if (r.Cells[0].Value.Equals(row[3]) && r.Cells[2].Value.Equals("Тур"))
                            rowNum = r.Index;
                    }

                    if (rowNum > 0)
                    {

                        DataGridViewComboBoxCell checkBoxCell =
                            contractInfoTable.Rows[rowNum].Cells[1] as DataGridViewComboBoxCell;
                        checkBoxCell.Items.Add(text);
                        var hotels = new List<object> { text };
                        var cell = new DataGridViewComboBoxCell();
                        cell.Items.AddRange(hotels.ToArray());
                        contractInfoTable[1, rowNum] = cell;
                    }
                    else
                    {
                        var hotels = new List<object> { text };
                        var cell = new DataGridViewComboBoxCell();
                        cell.Items.AddRange(hotels.ToArray());
                        contractInfoTable.Rows.Add(row[3]);
                        int lastRowIndex = contractInfoTable.Rows.Count - 1;
                        contractInfoTable[1, lastRowIndex] = cell;
                        contractInfoTable[2, lastRowIndex].Value = "Тур";
                    }
                }
            }
                
        }
        

        private void addTour_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void createNewBookB_Click(object sender, EventArgs e)
        {
            if (CClient.Texts != String.Empty && CTour.Texts != String.Empty)
            {
                string input;
                string[] parts;

                if (addTour.Texts != String.Empty)
                {
                    input = addTour.Texts;

                    parts = input.Split(new string[] { " - " }, StringSplitOptions.None);
                    IDAT = int.Parse(parts[0]);
                }
                else
                {
                    IDAT = 0;
                }

                if (String.IsNullOrEmpty(transferA.Texts))
                {
                    IDTransport = 0;
                }
                else
                {
                    input = transferA.Texts;
                    parts = input.Split(new string[] { " - " }, StringSplitOptions.None);
                    IDTransport = int.Parse(parts[0]);
                }

                input = CTour.Texts;
                parts = input.Split(new string[] { " - " }, StringSplitOptions.None);
                ID = int.Parse(parts[0]);
                HotelInTour = new List<int>();
                foreach (DataGridViewRow r in contractInfoTable.Rows)
                {
                    string[] temp;
                    if (r.Cells[1].Value != null)
                    {
                        temp = r.Cells[1].Value.ToString()
                            .Split(new string[] { " " }, StringSplitOptions.None);
                        HotelInTour.Add(Convert.ToInt32(temp[0]));

                    }

                }



                foreach (DataRow row in client.Rows)
                {
                    if (row[1].ToString().Equals(CClient.Texts))
                        IDclient = (int)row[0];
                }

                CreateBook?.Invoke(this, EventArgs.Empty);
                if (!String.IsNullOrEmpty(Error))
                {
                    MessageBox.Show(Error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Error = String.Empty;
                }
                else
                {
                    MessageBox.Show("Бронювання успішно створено!", "Успіх", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CClient.Items.Clear();
                    CTour.Items.Clear();
                    addTour.Items.Clear();
                    transferA.Items.Clear();
                    HotelInTour.Clear();
                    IDTransport = IDclient = ID = IDAT = 0;
                    contractInfoTable.Rows.Clear();
                    to_where.Text = from_where.Text =
                        CTour.Texts = addTour.Texts = CClient.Texts = transferA.Texts = String.Empty;
                    infoCitiesAndHotels.Rows.Clear();
                    infoTour.Rows.Clear();
                    infoAddTour.Rows.Clear();
                    Transport.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Заповніть важливі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

        }

        private void transferA_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(transferA.Texts))
            {
                foreach (DataRow row in Transport.Rows)
                {
                    string temp = row[0] + " - " + row[1];
                    if (transferA.Texts.Equals(temp))
                    {
                        from_where.Text = row[2].ToString();
                        to_where.Text = row[3].ToString();
                    }
                    
                } 
            }
        }
    }
}