using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNameInArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] name = new string[5];
           int index = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (index<5)
            {
                name[index] = nameTextBox.Text;
                index++;
                nameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("you can only assign five name ;");
            }



        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (string myname in name)
            {
                nameListBox.Items.Add(myname);
                count++;

            }
            totalTextBox.Text = count.ToString();

        }
    }
}
