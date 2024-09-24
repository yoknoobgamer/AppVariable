using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVariable
{
    public partial class FormRegister : Form
    {
        string name;
        string surname;
        string email;
        string phone;
        byte age;
        DateTime dob;
        string level;
        enum blood { A, B, O, AB };
        blood MyBlood;


        public FormRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void b_regis_Click(object sender, EventArgs e)
        {
            name = txt_name.Text;
            surname = txt_surname.Text;
            email = txt_email.Text;
            phone = txt_phone.Text;
            age = Convert.ToByte(nu_age.Value);
            dob = Convert.ToDateTime(pk_dob.Value);
            level = Convert.ToString(com_level.SelectedItem);

            la_name.Text = name;
            la_surname.Text = surname;
            la_email.Text = email;
            la_phone.Text = phone;
            la_age.Text = age.ToString();
            la_dob.Text = dob.ToShortDateString();
            la_level.Text = level;
            la_blood.Text = MyBlood.ToString();
            
        }

        private void ra_A_CheckedChanged(object sender, EventArgs e)
        {
            MyBlood = blood.A;
        }

        private void ra_B_CheckedChanged(object sender, EventArgs e)
        {
            MyBlood = blood.B;
        }

        private void ra_O_CheckedChanged(object sender, EventArgs e)
        {
            MyBlood = blood.O;
        }

        private void ra_AB_CheckedChanged(object sender, EventArgs e)
        {
            MyBlood = blood.AB;
        }

        private void nu_age_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
