using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Views.DirectorViews.Booker_panel;

namespace TravelAgency
{ 
    public partial class PopularityOfAgency : Form, IViewPopularityOfAgency
    {
        public PopularityOfAgency()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            if(ListOfStaff.Rows.Count != 0)
                AddToTable();
            
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public DataTable ListOfStaff { get; set; }

        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in ListOfStaff.Rows) 
            {
                staffInfoTable.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        
        
    }
}
