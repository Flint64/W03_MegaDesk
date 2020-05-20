using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace W03_MegaDesk {
    public partial class AddQuote : Form {

        private Form _mainMenu;

        private const decimal MinWidth = 24;
        private const decimal MaxWidth = 96;

        private const decimal MinDepth = 12;
        private const decimal MaxDepth = 48;

        private List<DeskQuote> _deskQuotes;
        private DeskQuote _deskQuote;

        public AddQuote(Form mainMenu) {
            InitializeComponent();

            _mainMenu = mainMenu;
            List<SurfaceMaterial> materials = Enum.GetValues(typeof(SurfaceMaterial)).Cast<SurfaceMaterial>().ToList();
            cmbo_surfaceMaterial.DataSource = materials;
            cmbo_surfaceMaterial.SelectedIndex = -1;

            List<RushOption> rush = Enum.GetValues(typeof(RushOption)).Cast<RushOption>().ToList();
            cmbo_rushOptions.DataSource = rush;
            cmbo_rushOptions.SelectedIndex = -1;

            List<NumDrawers> drawers = Enum.GetValues(typeof(NumDrawers)).Cast<NumDrawers>().ToList();
            cmbo_drawers.DataSource = drawers;
            cmbo_drawers.SelectedIndex = -1;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e) {
            _mainMenu.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void num_width_ValueChanged(object sender, EventArgs e) {
            if (num_width.Value < MinWidth) {
                num_width.Value = MinWidth;
            } else if (num_width.Value > MaxWidth) {
                num_width.Value = MaxWidth;
            }
        }

        private void num_depth_ValueChanged(object sender, EventArgs e) {
            if (num_depth.Value < MinDepth) {
                num_depth.Value = MinDepth;
            } else if (num_depth.Value > MaxDepth) {
                num_depth.Value = MaxDepth;
            }
        }

        private void btn_getQuote_Click(object sender, EventArgs e) {

            _deskQuote = new DeskQuote();

            lbl_deskQuote.Text = null;

            Desk desk = new Desk();

            _deskQuote.customerName = txt_name.Text;
            
            DateTime today = DateTime.Today;
            _deskQuote.currentDate = today;

            desk.SurfaceMaterial = (SurfaceMaterial)cmbo_surfaceMaterial.SelectedValue;

            desk.Depth = num_depth.Value;
            desk.Width = num_width.Value;
            desk.SurfaceArea = (num_width.Value * num_depth.Value);

            desk.NumberOfDrawers = (NumDrawers)cmbo_drawers.SelectedValue;

            desk.RushOption = (RushOption)cmbo_rushOptions.SelectedValue;

            _deskQuote.desk = desk;
            decimal quote = _deskQuote.getQuote();
            
            lbl_deskQuote.Text = quote.ToString();
        }

        private void btn_saveQuote_Click(object sender, EventArgs e) {
            //Save the new quote to the file
            populateList();
            SaveQuotes();
        }

        /*Deserialization and Serialization of JSON file. Reads to and from quotes.json*/
        //Deserializing JSON file.
        private void populateList() {

            _deskQuotes = new List<DeskQuote>();

            var quotesFile = @"quotes.json";
            //List<DeskQuote> deskQuotes = new List<DeskQuote>();

            if (File.Exists(quotesFile)) {

                using (StreamReader reader = new StreamReader(quotesFile)) {

                    string quotes = reader.ReadToEnd();
                    if(quotes.Length > 0) {
                        _deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                }
            }
        }

        //This serializes the new quote to the file
        private void SaveQuotes(){

            if (_deskQuote == null) {
                return;
            }

            //This adds a new quote
            _deskQuotes.Add(_deskQuote);

            var quotesFile = @"quotes.json";

            var serializedQuotes = JsonConvert.SerializeObject(_deskQuotes);
            
            //Write the quotes to the Json file
            File.WriteAllText(quotesFile, serializedQuotes);
        }
    }


}
