using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Models.DirectorModels.TransportsAndTransfersModels;
using TravelAgency.Views.AgentViews.Booking;

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
            
            
            createNewStaffB.BackgroundColor = ColorTranslator.FromHtml("#5AACB8");
            //startDateDT.MinDate = DateTime.Now;
        }
        #region --- Interface ---
        
        public string ResultOfAdding { get => resultOfAdding; set => resultOfAdding = value; }
        public DataTable DataTableInfoAboutBooking { get; set; }
        public event EventHandler sendInfo;
        public event EventHandler GetInfoAboutAboutPrice;
        public List<double> costChanging { get; set; }
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
                        GetInfoAboutAboutPrice?.Invoke(this, EventArgs.Empty);
                       /* Cost.Texts = costChanging[0].ToString();
                        DiscountTB.Texts = costChanging[1].ToString();
                        FinalCostTB.Texts = costChanging[2].ToString();*/
                    }
                }
            }
            return true;
        }


        private void emailCB_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            bookingCB.Items.Clear();
            bookingCB.Texts = tourNameTB.Texts = addTourTB.Texts = HotelTB.Texts = TransferNameTB.Texts = string.Empty;

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

        private void createNewContractB_Click(object sender, EventArgs e)
        {

        }
    }
}
