using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudRegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 31; i++) { comboDay.Items.Add(i.ToString()); }
            for(int k = 1900; k <= 2024; k++) { comboYear.Items.Add(k.ToString()); }

            String[] month = {"January", "February", "March", "April", "May", "June", 
                "July", "August", "September", "October", "November", "December"};

            foreach(String mont in month)
            {
                comboMonth.Items.Add(mont.ToString());
            }

            ArrayList prog = new ArrayList()
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

            foreach(String program in prog)
            {
                comboProgram.Items.Add(program.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string day = comboDay.SelectedItem.ToString();
            string month = comboMonth.SelectedItem.ToString();
            string year = comboYear.SelectedItem.ToString();
            string course = comboProgram.SelectedItem.ToString();

            string gender = radioMale.Checked ? "Male" : "Female";

            MessageBox.Show("Student Name: " + textFirst.Text + " " + textMiddle.Text + " " + textLast.Text + 
                "\nGender: " + gender + "\nDate of birth: " + comboMonth.Text + "/" + comboDay.Text + "/"
                + comboYear.Text + "\nProgram: " + course);
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
