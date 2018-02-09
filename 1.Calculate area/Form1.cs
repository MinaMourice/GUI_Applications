using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hello_World_GUI
{
    public partial class Form_Mina : Form
    {
        public Form_Mina()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

        private void button_Area_Click(object sender, EventArgs e)
        {
            //Calculate The area
            int width, length, area;
            if (Width_textBox.Text == "")
                Error_Message.Text = "No Width";
            else if (Length_textBox.Text == "")
                Error_Message.Text = "No Length";
            else
            {
                Error_Message.Text = "";

                width = Convert.ToInt32(Width_textBox.Text);
                length = Convert.ToInt32(Length_textBox.Text);
                area = length * width;


                Room_Area_Result.Text = area.ToString("n"); //numbers
            }
        }

        private void Room_Area_Result_Click(object sender, EventArgs e)
        {

        }

        private void Width_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Length_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width, length;
            double price, roomCost;
            if (Width_textBox.Text == "")
                Error_Message.Text = "No Width";
            else if (Length_textBox.Text == "")
                Error_Message.Text = "No Length";
            else if (Price_textBox.Text == "")
                Error_Message.Text = "No Price";
            else
            {
                Error_Message.Text = "";
                width = Convert.ToInt32(Width_textBox.Text);
                length = Convert.ToInt32(Length_textBox.Text);
                price = Convert.ToDouble(Price_textBox.Text);

                roomCost = length * width * price;

                Cost_Result.Text = roomCost.ToString("n");
            }
        }

        private void Cost_Result_Click(object sender, EventArgs e)
        {

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Cost_Result.Text = "";
            Room_Area_Result.Text = "";
            Width_textBox.Text = "";
            Length_textBox.Text = "";
            Price_textBox.Text = "";
            Error_Message.Text = "";

        }

        private void Price_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
