using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Tiroirs
{
    public partial class Form1 : Form
    {
        int[] num = {3, 1, 2, 6, 3, 9, 20};
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultats() 
        {
            int Counter = 0;
            foreach (int i in num) 
            {
                //Counter++;
                //list.Add($"Tiroir{Counter}: {i} ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Resultats();
            //label1.Text = string.Join(",  ", list);
            int counter = 0;
            label1.Text = string.Empty;
            foreach (int i in num) 
            {
                counter++;
                label1.Text += ($"Tiroir{counter} : {i} boules,  ");
                if (counter % 5 == 0)
                    label1.Text += Environment.NewLine;
            }
        }
    }
}
