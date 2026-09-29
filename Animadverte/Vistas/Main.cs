using MindFusion.Graphs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Animadverte
{
    public partial class Main : Form
    {
        User user = new User();
        NewTable table = new NewTable();
        Inventory inventory = new Inventory();

        Configure configure = new Configure();

        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            configure.Show();
        }

        private void AddTableButton_Click(object sender, EventArgs e)
        {
            table.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            user.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            inventory.Show();
        }
    }
}
