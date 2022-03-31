using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace armenyanin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(kazakh.Text);

            int[,] mas = new int[n, n];

            Random ran = new Random();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    mas[i, j] = ran.Next(100);
                    da.Text += mas[i, j] + " ";
                }
                da.Text += "\n";
            }

            for (int i = 0; i < n; i++)
            {
                papich.Text += mas[i, n-i-1] + " ";
            }
        }
    }
}
