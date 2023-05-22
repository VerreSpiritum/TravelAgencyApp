using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Aspose.Pdf;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.AgentViews.Booking;
//using Document = Aspose.Pdf.Document;

namespace TravelAgency
{
    public partial class CreateContract : Form, IViewCreateContract
    {
        private string resultOfAdding;
        private bool CheckSetInEmail;
        private bool CheckSetInBooking;


        public CreateContract()
        {
            InitializeComponent();
            
            
            generateContract.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
            //startDateDT.MinDate = DateTime.Now;
        }
        #region --- Interface ---
        
        public string ResultOfAdding { get => resultOfAdding; set => resultOfAdding = value; }
        public DataTable DataTableInfoAboutBooking { get; set; }
        public event EventHandler sendInfo;
        public event EventHandler GetInfoAboutAboutPrice;
        public List<double> costChanging { get; set; }
        public string TextOfContract { get; set; }
        public int Book { get; set; }
        public string Client { get; set; }
        public void CloseForm()
        {
            this.Close();
        }
        
        public void ShowForm()
        {
            foreach (DataRow row in DataTableInfoAboutBooking.Rows)
            {
                if (!emailCB.Items.Contains(row[2]) && row[7].Equals("Немає"))
                {
                    emailCB.Items.Add(row[2]);
                }
            }
            this.Show();
        }
        #endregion

        private bool CheckAndInsert()
        {
            if (!String.IsNullOrEmpty(emailCB.Texts) && !String.IsNullOrEmpty(bookingCB.Texts))
            {
                foreach (DataRow row in DataTableInfoAboutBooking.Rows)
                {
                    if (emailCB.Texts.Equals(row[2]) && bookingCB.Texts.Equals(row[0].ToString()))
                    {
                        tourNameTB.Texts = row[3].ToString();
                        addTourTB.Texts = row[4].ToString();
                        HotelTB.Texts = row[5].ToString();
                        TransferNameTB.Texts = row[8].ToString();
                        Book = Convert.ToInt32(row[0]);
                        Client = emailCB.Texts;
                        GetInfoAboutAboutPrice?.Invoke(this, EventArgs.Empty);
                        Cost.Texts = costChanging[0].ToString();
                        DiscountTB.Texts = costChanging[1].ToString();
                        FinalCostTB.Texts = costChanging[2].ToString();
                        generateContract.Visible = true;
                        saveBtn.Visible = true;
                    }
                }
            }
            return true;
        }


        private void emailCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            bookingCB.Items.Clear();
            bookingCB.Texts = tourNameTB.Texts = addTourTB.Texts = HotelTB.Texts = TransferNameTB.Texts = 
                Cost.Texts = DiscountTB.Texts = FinalCostTB.Texts = string.Empty;
            generateContract.Visible = false;
            saveBtn.Visible = false;
            textOfContract.Text = string.Empty;
            
            
            foreach (DataRow row in DataTableInfoAboutBooking.Rows)
            {
                if (emailCB.Texts.Equals(row[2]) && row[7].Equals("Немає"))
                {
                    
                    bookingCB.Items.Add(row[0]);
                }
            }
            CheckAndInsert();
        }

        private void bookingCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndInsert();
        }


        private void generateContract_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in DataTableInfoAboutBooking.Rows)
            {
                if (emailCB.Texts.Equals(row[2]) && row[7].Equals("Немає"))
                {

                    Book = (int)row[0];
                }
            }
            sendInfo?.Invoke(this, EventArgs.Empty);
            textOfContract.Text = TextOfContract;
            emailCB.Items.Clear();
            foreach (DataRow row in DataTableInfoAboutBooking.Rows)
            {
                if (!emailCB.Items.Contains(row[2]) && row[7].Equals("Немає"))
                {
                    emailCB.Items.Add(row[2]);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Create a Document object
            SaveFileDialog saveDialog = new SaveFileDialog();
    
            // Set the default file extension and filter
            saveDialog.DefaultExt = "pdf";
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
    
            // Display the SaveFileDialog
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a Document object
                Document doc = new Document();
                    
                    
                Document document = new Document();
                Page page = document.Pages.Add();

// Добавить текст на новую страницу
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(TextOfContract));

// Сохранить PDF 
                document.Save(saveDialog.FileName);
            } 
        }
    }
}
