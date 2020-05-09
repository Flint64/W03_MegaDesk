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
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_newQuote_Click(object sender, EventArgs e) {
            var frmAddQuote = new AddQuote(this);
            frmAddQuote.Show();

            Hide();
        }

        private void btn_viewQuotes_Click(object sender, EventArgs e) {
            var frmViewAllQuotes = new ViewAllQuotes(this);
            frmViewAllQuotes.Show();

            Hide();
        }

        private void btn_searchQuotes_Click(object sender, EventArgs e) {
            var frmSearchQuotes = new SearchQuotes(this);
            frmSearchQuotes.Show();

            Hide();
        }
    }
}
