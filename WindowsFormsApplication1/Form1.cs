using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
           
            listBox1.DataSource=CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TxtBox = Convert.ToInt32(textBox1.Text);
            String intToText = TxtBox.ToWords(new CultureInfo(listBox1.GetItemText(listBox1.SelectedItem)));

            if (intToText.Contains(textBox1.Text)) MessageBox.Show("Language not supported yet!");
            else
            MessageBox.Show(intToText);
            

        }

        
    }
}
