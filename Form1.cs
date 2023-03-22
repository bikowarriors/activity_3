using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activity_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            otherslabel.Visible = false;
            othersTB.Visible = false;
            othersTB.Multiline = true;
        }

        private void submitB_Click(object sender, EventArgs e)
        {
            string str="";

            //jpCB=Japan
            if (jpCB.Checked == true) {
                str = str + jpCB.Text;
                str += " ";
            }
            //phCB=Philippines
            if (phCB.Checked == true)
            {
                str = str + phCB.Text;
                str += " ";
            }
            //thaiCB=Thailand
            if (thaiCB.Checked == true)
            {
                str = str + thaiCB.Text;
                str += " ";
            }
            //ausCB=Japan
            if (ausCB.Checked == true)
            {
                str = str + ausCB.Text;
                str += " ";
            }
            //othersCB=others
            if (othersCB.Checked == true)
            {
                str = str + othersTB.Text;
                str += " ";
            }
            if (str != null) {
                MessageBox.Show("You Selected: \n" + str + "\nThank you!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void jpCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void phCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void thaiCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ausCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void othersTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void othersCB_CheckedChanged(object sender, EventArgs e)
        {
            if (othersCB.Checked)
            {
                otherslabel.Visible = true;
                othersTB.Visible = true;
            }
            else {
                otherslabel.Visible = false;
                othersTB.Visible = false;
            }
        }

        private void otherslabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void survey_Click(object sender, EventArgs e)
        {

        }
    }
}
