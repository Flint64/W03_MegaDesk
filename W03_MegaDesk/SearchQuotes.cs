using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace W03_MegaDesk {
    public partial class SearchQuotes : Form {

        private Form _mainMenu;

        public SearchQuotes(Form mainMenu) {
            InitializeComponent();

            _mainMenu = mainMenu;

            //This will populate the combobox with the surface materials list
            List<SurfaceMaterial> materials = Enum.GetValues(typeof(SurfaceMaterial))
                .Cast<SurfaceMaterial>()
                .ToList();
            comboBoxMaterials.DataSource = materials;
            comboBoxMaterials.SelectedIndex = -1;

        }

        private void loadGrid()
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                //This loads in the existing quotes
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
                    DeliveryType = d.desk.RushOption,
                    QuoteAmount = d.price.ToString("c")
                }).ToList();
            }
        }

        private void loadGrid(SurfaceMaterial desktopMaterial)
        {
            var quotesFile = @"quotes.json";

            using (StreamReader reader = new StreamReader(quotesFile))
            {
                //This loads in the existing quotes
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
                    DeliveryType = d.desk.RushOption,
                    QuoteAmount = d.price.ToString("c")
                }).Where(q => q.SurfaceMaterial == desktopMaterial)
                .ToList();
            }
        }
        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e) {
            _mainMenu.Show();
        }

        private void comboBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if(combo.SelectedIndex < 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid((SurfaceMaterial)combo.SelectedValue);
            }
        }
    }
}
