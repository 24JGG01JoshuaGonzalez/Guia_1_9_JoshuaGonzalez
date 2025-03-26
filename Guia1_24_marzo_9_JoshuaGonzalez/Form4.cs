using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_9_JoshuaGonzalez
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] Matriz1 =
            {
                {1, 2, 3, 4 },
                {3,5,8,1 }
            };
            int[,] Matriz2 =
            {
                {5,6, 7,8},
                {2,4,8,3 }
            };

            for (int co = 0; co < 4; co++)
            {
                for (int fi = 0; fi < 2; fi++)
                {
                    int mul = Matriz1[fi, co] + Matriz2[fi, co];
                    dataGridView1.Rows.Add(Matriz1[fi, co], Matriz2[fi, co], mul);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();  
        }
    }
}
