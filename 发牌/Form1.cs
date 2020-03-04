using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 发牌
{
    public partial class Form1 : Form
    {
        int num;
        int[] a = new int[60];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                a[i] = 0;
            }
            int sump = 0, j = 0, k = 0;
            for (int i = 1; ; i++)
            {
                Random rd = new Random();
                num = rd.Next(1, 53);
                if (a[num] == 0)
                {
                    a[num] = 1;
                    sump++;
                    PictureBox p = new PictureBox();
                    p.Name = "pictureBox" + i.ToString();
                    p.Size = new System.Drawing.Size(85, 125);

                    p.Top = 10 + k * 120;
                    p.Left = 10 + j * 40;
                    j++; if (j % 13 == 0) { j = 0; k++; }

                    p.Load("..\\..\\..\\Poker_Card\\" + num + ".png");
                    Controls.Add(p);
                    p.BringToFront();
                }
                if (sump == 52)
                    break;
            }
        }
    }
}
