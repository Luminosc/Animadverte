using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animadverte
{
    public partial class Inventory : Form
    {
        NewDevice newDevice = new NewDevice();

        New_Complements new_Complements = new New_Complements();
        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newDevice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new_Complements.Show();
        }
    }
}
