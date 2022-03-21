using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRAKTIKUMWEEK5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Output_Click(object sender, EventArgs e)
        {
            Label2_Output.Text = ListBox.Text;
        }

        private void RadioButton_Merah_CheckedChanged(object sender, EventArgs e)
        {
            Label2_Output.ForeColor = Color.Red;
        }

        private void RadioButton_Biru_CheckedChanged(object sender, EventArgs e)
        {
            Label2_Output.ForeColor = Color.Blue;
        }

        private void CheckBox_Aktif_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            ListBox.Items.Add(TxtBox_Data.Text);
            TxtBox_Data.Clear();
            TxtBox_Data.Focus();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtBox_Data_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtBox_Data.Text = "";
        }
    }
}
