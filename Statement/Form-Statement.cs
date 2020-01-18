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
            this.numericUpDown_CountStud.Value = this.dataGridView_Statement.RowCount;//Не работает
            this.numericUpDown_CountSubject.Value = this.dataGridView_Statement.ColumnCount;//Не работает
            //this.numericUpDown_CountStud.Value = Convert.ToUInt32(this.dataGridView_Statement.RowCount.ToString());//Не работает
            //this.numericUpDown_CountSubject.Value = Convert.ToUInt32(this.dataGridView_Statement.ColumnCount.ToString());//Не работает
        }

        private void button_RandomGeneration_Click(object sender, EventArgs e)
        {
            this.dataGridView_Statement.RowCount = integerRnd.Next(10, 15);
            this.dataGridView_Statement.ColumnCount = integerRnd.Next(10, 15);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
