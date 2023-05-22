using System;
using System.Data;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using Aspose.Pdf;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using TravelAgency.Views.AgentViews.Booking;

namespace TravelAgency
{
    public partial class ShowAllContract : Form, IViewShowAllContract
    {
        public ShowAllContract()
        {
            InitializeComponent();
        }
        #region --- Реализация интерфейса ---

        public DataTable info { get; set; }
        public string text { get; set; }
        public int ID { get; set; }
        public event EventHandler GetText; 
        public void ShowForm(DataTable info)
        {
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;
            AddToTable(info);
            this.Show();
        }
        public void CloseForm()
        {
            this.Close();
        }
        #endregion

        private void AddToTable(DataTable info)
        {
            foreach (DataRow row in info.Rows)
            {
                DateTime date = (DateTime)row[3];
                contractInfoTable.Rows.Add(row[0], row[1], row[2], date.ToShortDateString());
            }
        }
        private void contractInfoTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                ID = (Int32)contractInfoTable.Rows[e.RowIndex].Cells[0].Value;
                GetText?.Invoke(this, EventArgs.Empty);
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
                        page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(text));

// Сохранить PDF 
                        document.Save(saveDialog.FileName);
                }
            }
        }
    }
}