using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            int c = random.Next(0, 10);
            int d = random.Next(0, 10);

            output.Text = "" + a + "" + b + "" + c + "" + d + "";
            copied.Visible = false;
            panel.Visible = false;

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if(output.Text!="")
            {
                Clipboard.SetText(output.Text.ToString());
                copied.Visible = true;
                panel.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Click The Generate Button To Generate A Pin",
                    "No Pin Generated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }
    }
}
