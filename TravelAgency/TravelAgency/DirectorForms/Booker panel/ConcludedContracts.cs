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
    public partial class ConcludedContracts : Form, IViewConcludedContract
    {
        public ConcludedContracts()
        {
            InitializeComponent();
            SearchBtn.BackColor = ColorTranslator.FromHtml("#5AACB8");
        }

        #region --- Реализация интерфейса ---
        public void ShowForm()
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;

            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }

        public DataTable ListOfStaff { get; set; }
        public string StartD { get; set; }
        public string EndD { get; set; }

        public event EventHandler SearchInfo;
        #endregion

        private void AddToTable()
        {
            foreach (DataRow row in ListOfStaff.Rows)
            {
                DateTime date = Convert.ToDateTime(row[4]);
                DateTime dateEnd = Convert.ToDateTime(row[5]);

                staffInfoTable.Rows.Add(row[0], row[1], row[2], row[3], $"{date.Day}/{date.Month}/{date.Year}", $"{dateEnd.Day}/{dateEnd.Month}/{dateEnd.Year}");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        { 
            if (start.Value.DayOfYear > end.Value.DayOfYear)
            {
                MessageBox.Show("Перевірте правильність дат!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime value = start.Value;
                StartD = $"{value.Day}.{value.Month}.{value.Year}";
                value = end.Value;
                EndD = $"{value.Day}.{value.Month}.{value.Year}";
                SearchInfo?.Invoke(this, EventArgs.Empty);
                staffInfoTable.Rows.Clear();
                if (ListOfStaff.Rows.Count != 0)
                {
                    AddToTable();
                    staffInfoTable.Visible = true;
                }
            }
        }
    }
}
