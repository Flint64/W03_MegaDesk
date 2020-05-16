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
    public partial class AddQuote : Form {

        private Form _mainMenu;

        private const decimal MinWidth = 24;
        private const decimal MaxWidth = 96;

        private const decimal MinDepth = 12;
        private const decimal MaxDepth = 48;

        private Desk desk;

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
            DeskQuote deskQuote = new DeskQuote();
        }
    }
}
