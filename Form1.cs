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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstDoorView f = new FirstDoorView();
            f.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondDoorView f = new SecondDoorView();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThirdDoorView f = new ThirdDoorView();
            f.Show();
            Hide();
        }
    }
}
