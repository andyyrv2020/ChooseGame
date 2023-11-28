using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseGame
{
    public partial class FirstDoorView : Form
    {
        public FirstDoorView()
        {
            InitializeComponent();
        }

        private void parushButton_Click(object sender, EventArgs e)
        {
            ParushFoundYouView f = new ParushFoundYouView();
            f.Show();
            Hide();
        }
    }
}
