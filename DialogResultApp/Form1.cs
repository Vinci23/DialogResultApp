using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResultApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            string poruka = "Odaberite Da/ Ne / Odustani ";
            string naslov = "Odaberi nesto....";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon icon = MessageBoxIcon.Information;
            DialogResult rezultat = MessageBox.Show(poruka, naslov, buttons, icon);

            switch (rezultat)
            {
                case DialogResult.Yes:
                    txtMsgBox.Text = "Yeeeeeeesssss";
                    break;

                case DialogResult.No:
                    txtMsgBox.Text = "Nooooooo";
                    break;
                case DialogResult.Cancel:
                    txtMsgBox.Text = "Maybeee?";
                    break ;

            }
        }
    }
}
