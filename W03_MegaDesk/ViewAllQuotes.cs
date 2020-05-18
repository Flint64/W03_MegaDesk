using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace W03_MegaDesk {
    public partial class ViewAllQuotes : Form {

        private Form _mainMenu;

        public ViewAllQuotes(Form mainMenu) {
            InitializeComponent();

            _mainMenu = mainMenu;

            //Loads grid
            loadGrid();

        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e) {
            _mainMenu.Show();
        }

        //Convert/read Json into dataGridView1
        private void loadGrid()
        {

            var quotesFile = @"quotes.json";
            using (StreamReader reader = new StreamReader(quotesFile))
            {
                string quotes = reader.ReadToEnd();
                List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                dataGridView1.DataSource = deskQuotes.Select(d => new
                {
                    Date = d.currentDate,
                    Customer = d.customerName,
                    Depth = d.desk.Depth,
                    Width = d.desk.Width,
                    Drawers = d.desk.NumberOfDrawers,
                    SurfaceMaterial = d.desk.SurfaceMaterial,
                    DeliveryType = d.DeliveryType,
                    QuoteAmount = d.price.ToString("c")
                }).ToList();
            }
        }
    }
}
