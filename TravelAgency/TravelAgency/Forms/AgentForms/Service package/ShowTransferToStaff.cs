using System;
using System.Data;
using System.Windows.Forms;
using TravelAgency.Views.AgentViews.Service_Panel;

namespace TravelAgency
{
    public partial class ShowTransferToStaff : Form, IViewShowTransferToStaff
    {
        private DataTable table;

        public ShowTransferToStaff()
        {
            InitializeComponent();
        }

        #region --- Реализация интерфейса ---
        public void ShowForm(DataTable dt)
        {
            table = dt;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            AddToTable(dt);
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        #endregion

        private void AddToTable(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                tour.Rows.Add(row[1], row[2], row[3], row[4], row[5], row[6]);
                if (!fromWhere.Items.Contains(row[2]))
                    fromWhere.Items.Add(row[2]);
                if (!toWhere.Items.Contains(row[3]))
                    toWhere.Items.Add(row[3]);

            }
            fromWhere.Items.Add("Усе");
            toWhere.Items.Add("Усе");
            fromWhere.Texts = toWhere.Texts = "Усе";
        }

        private void UpdateTable()
        {
            tour.Rows.Clear();

          
            if (toWhere.Texts != "Усе" || fromWhere.Texts != "Усе" )
            {
                
                if(toWhere.Texts != "Усе" && fromWhere.Texts == "Усе")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row[3].Equals(toWhere.Texts))
                            tour.Rows.Add(row.ItemArray);
                    }
                }
                else if(toWhere.Texts == "Усе" && fromWhere.Texts != "Усе")
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row[2].Equals(fromWhere.Texts))
                            tour.Rows.Add(row.ItemArray);
                    }
                }
                else
                {
                    foreach (DataRow row in table.Rows)
                    {
                        if (row[2].Equals(fromWhere.Texts) && row[3].Equals(toWhere.Texts))
                            tour.Rows.Add(row.ItemArray);
                    }
                }
                
            }
            else
            {
                foreach (DataRow row in table.Rows)
                {
                    tour.Rows.Add(row.ItemArray);
                }
            }
        }

        private void fromWhere_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toWhere_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
