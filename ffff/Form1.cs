using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.Next(1, 3) == 1)
            {
                label1.Text = "ghbdtn";
            }
            else
            {
                label1.Text = "ghbdtn54364356784+45684+51+569+54891+5461561561461546" +
                    "136" +
                    "15040241+0546";
                await Task.Delay(2000);
                label1.Text = "Bye-bye";
                await Task.Delay(250);
                Application.Exit();
            }

        }
    }
}
