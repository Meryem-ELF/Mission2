using ScilyLinesMission2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sycilines.Vue
{
    public partial class confirmLiaison : Form
    {
        private string confirmation;
        private Liaison liaison;

        public confirmLiaison()
        {
            InitializeComponent();
        }

        public confirmLiaison(string confirmation, Liaison liaison)
        {
            InitializeComponent();
            this.confirmation = confirmation;
            this.liaison = liaison;
        }
        public confirmLiaison(string confirmation)
        {
            InitializeComponent();
            this.confirmation = confirmation;
        }

        private void confirmLiaison_Load(object sender, EventArgs e, string confirmation)
        {
            confirm.Text = this.confirmation;
            info.Text = this.liaison.ToString();
        }

        private void retourAccueil_Click(object sender, EventArgs e)
        {
            PageAccueil accueil = new PageAccueil();
            accueil.ShowDialog();
            this.Close();

        }
    }
}