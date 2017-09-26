using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        byte F = 1;

        public Form1()
        {

            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (F == 1)
            {
                label1.Top = 0;
                label1.Left += 10;

                if (label1.Left >= ClientRectangle.Width-label1.Width)
                {
                    F = 2;
                    label1.Left = ClientRectangle.Width - label1.Width;
                }

                label1.ForeColor = Color.FromArgb(0xFF, 255 - (label1.Left * 255 / (ClientRectangle.Width - label1.Width)), 0);
            }
            else if (F == 2)
            {
                label1.Left = ClientRectangle.Width-label1.Width;
                label1.Top += 10;

                if (label1.Top >= ClientRectangle.Height-label1.Height)
                {
                    F = 3;
                    label1.Top = ClientRectangle.Height - label1.Height;
                }

                label1.ForeColor = Color.FromArgb( 255 - (label1.Top * 255 / (ClientRectangle.Height - label1.Height)), label1.Top * 255 / (ClientRectangle.Height - label1.Height), label1.Top * 255 / (ClientRectangle.Height - label1.Height));
            }
            else if (F == 3)
            {
                if (label1.Left > ClientRectangle.Width-label1.Width)
                {
                    label1.Left = ClientRectangle.Width-label1.Width;
                }

                label1.Top = ClientRectangle.Height-label1.Height;
                label1.Left -= 10;

                if (label1.Left <= 0)
                {
                    F = 4;
                    label1.Left = 0;
                }

                label1.ForeColor = Color.FromArgb( 0x00, 0xFF, label1.Left * 255 / (ClientRectangle.Width - label1.Width));
            }
            else if (F == 4)
            {
                if (label1.Top > ClientRectangle.Height-label1.Height)
                {
                    label1.Top = ClientRectangle.Height-label1.Height;
                }

                label1.Left = 0;
                label1.Top -= 10;

                if (label1.Top <= 0)
                {
                    F = 1;
                    label1.Top = 0;
                }

                label1.ForeColor = Color.FromArgb(255 - label1.Top * 255 / (ClientRectangle.Height - label1.Height), 0xFF, label1.Top * 255 / (ClientRectangle.Height - label1.Height));
            }

        }
    }
}
