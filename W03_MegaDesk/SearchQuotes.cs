using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_MegaDesk {
    public partial class SearchQuotes : Form {

        private Form _mainMenu;

        public SearchQuotes(Form mainMenu) {
            InitializeComponent();

            _mainMenu = mainMenu;

        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e) {
            _mainMenu.Show();
        }
    }
}
