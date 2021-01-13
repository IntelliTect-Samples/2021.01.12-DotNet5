using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsMigration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Inigo Montoya");
            listBox1.Items.Add("6-Fingered Man");
            listBox1.Items.Add("Fezzik");
            listBox1.Items.Add("Princess Buttercup");
            listBox1.Items.Add("Westley");
            listBox1.Items.Add("Miracle Max");
            listBox1.Items.Add("Vizzini");
            listBox1.Items.Add("Prince Humperdinck");
            listBox1.Items.Add("The Albino");
            listBox1.Items.Add("Kevin Arnold");

            listBox2.Items.Add("Fred Savage");
            listBox2.Items.Add("Mandy Patinkin");
            listBox2.Items.Add("Cary Elwes");
            listBox2.Items.Add("Billy Crystal");
            listBox2.Items.Add("Robin Wright");
            listBox2.Items.Add("Andre the Giant");
            listBox2.Items.Add("Wallace Shawn");
            listBox2.Items.Add("Chris Sarandon");
            listBox2.Items.Add("Christopher Guest");
            listBox2.Items.Add("Mel Smith");

            RegistryKey rk = Registry.Users;

            lblUserCount.Text = $"{rk.GetSubKeyNames().Count()} users";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }
    }
}
