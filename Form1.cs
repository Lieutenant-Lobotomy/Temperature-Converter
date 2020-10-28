using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }
        private void convertFromKelvin()
        {
            
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers");
            }

            float f = (k + 273.15f) * 9 / 5 + 32;
            float c = k + 273;

            txt_celsius.Text = c.ToString();
            txt_fahrenheit.Text = f.ToString();
  
        }
        private void convertFromFahrenheit()
        {

            float f = 0;

            try
            {
                f = float.Parse(txt_fahrenheit.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers");
            }

            float c = 5f / 9 * (f - 32);
            float k = c - 273;

            txt_kelvin.Text = k.ToString();
            txt_celsius.Text = c.ToString();
        }
        private void convertFromCelsius()
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers");
            }
            
            float f = (c * 9 / 5) + 32;
            float k = c - 273.15f;

            txt_kelvin.Text = k.ToString();
            txt_fahrenheit.Text = f.ToString();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }
        private void clearButton(object sender, EventArgs e)
        {
            txt_kelvin.Clear();
            txt_celsius.Clear();
            txt_fahrenheit.Clear();
        }
    }
}