using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random integerRnd = new Random();

        private void tabPage_Statement_Click(object sender, EventArgs e)
        {
            //integerRnd.Next(10, 15);
        }

        private void button_RandomGeneration_Click(object sender, EventArgs e)
        {
            int intRow = integerRnd.Next(10, 20), intColumn = integerRnd.Next(10,20);
            //foreach ()
            //{
            //    //this.dataGridView_Statement.Rows() = r
            //    foreach ()
            //    {

            //    }
            //}
            //Сделать в типе string (студет 1, 1 - intRow)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView_Statement.RowCount = 1;
            this.dataGridView_Statement.ColumnCount = 1;
        }

        private void numericUpDown_CountStud_ValueChanged(object sender, EventArgs e)
        {
            //int numUpDownStud = Convert.ToInt32(numericUpDown_CountStud.Value);
            //this.dataGridView_Statement.RowCount = numUpDownStud > 0 ? numUpDownStud : 1;
            this.dataGridView_Statement.RowCount = Convert.ToInt32(numericUpDown_CountStud.Value);
        }

        private void numericUpDown_CountSubject_ValueChanged(object sender, EventArgs e)
        {
            this.dataGridView_Statement.ColumnCount = Convert.ToInt32(numericUpDown_CountSubject.Value);
        }
    }
}
