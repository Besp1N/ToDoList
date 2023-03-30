using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;
        List<string> list = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void check()
        {
            if (counter == 4)
            {
                MessageBox.Show("Full items, delete old to add new", "Full items", MessageBoxButtons.OK);
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (lbl1.Text == string.Empty && tbToDo.Text != string.Empty)
            {
                check();
                counter++;
                lbl1.Text = tbToDo.Text;
                list.Add(lbl1.Text);

                tbToDo.Text = string.Empty;
            }
            else if (lbl2.Text == string.Empty && tbToDo.Text != string.Empty)
            {
                check();
                counter++;
                lbl2.Text = tbToDo.Text;
                list.Add(lbl2.Text);
                tbToDo.Text = string.Empty;

            }
            else if (lbl3.Text == string.Empty && tbToDo.Text != string.Empty)
            {
                check();
                counter++;
                lbl3.Text = tbToDo.Text;
                list.Add(lbl3.Text);

                tbToDo.Text = string.Empty;

            }
            else if (lbl4.Text == string.Empty && tbToDo.Text != string.Empty)
            {
                check();
                counter++;
                lbl4.Text = tbToDo.Text;
                list.Add(lbl4.Text);
              
                tbToDo.Text = string.Empty;

            }


        }

        private void btnDelete4_Click(object sender, EventArgs e)
        {
            counter--;
            lbl4.Text = string.Empty;
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            counter--;
            lbl3.Text = string.Empty;
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            counter--;
            lbl2.Text = string.Empty;
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            counter--;
            lbl1.Text = string.Empty;
        }
    }
}
