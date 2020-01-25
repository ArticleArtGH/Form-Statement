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
            //int intRow = integerRnd.Next(10, 20), intColumn = integerRnd.Next(10,20);
            int intCell = 0, int_NA_Cell = 0,i = 0, j = 0, NA_Rows=0, NA_Columns=0; 
            int countRows = this.dataGridView_Statement.RowCount, countColumn = this.dataGridView_Statement.ColumnCount;
            //Заполнение Зголовков
            for (i=0; i < countRows; i++ )
            {
                this.dataGridView_Statement.Rows[i].HeaderCell.Value = "Студент"+(i+1);
            }
            for (j=0; j < countColumn; j++)
            {
                this.dataGridView_Statement.Columns[j].HeaderCell.Value = "Предмет" + (j+1);
            }
            //Заполнение Таблицы
            for (i = 0; i < countRows; i++)
            {
                for (j = 0; j < countColumn; j++)
                {
                    intCell = integerRnd.Next(2, 6);//Рандом делает максимальное значение на единицу ментше, т.е. для 5 от 2 до 6
                    //this.dataGridView_Statement.Rows[j].Cells[i].Value= intCell;
                    this.dataGridView_Statement[j, i].Value = Convert.ToString(intCell);
                }
                //Рандом для н/а
                NA_Rows = integerRnd.Next(0, countRows);
                NA_Columns = integerRnd.Next(0, countColumn);
                //if (countRows == 1 && countColumn == 1)
                //{
                //    switch (integerRnd.Next(0, 2))
                //    {
                //        case 0: break;
                //        case 1: this.dataGridView_Statement[NA_Columns, NA_Rows].Value = "н/а"; break;
                //    }
                //}
                //else
                //{
                //    switch (integerRnd.Next(0, 4))
                //    {
                //        case 0: break;
                //        case 1: this.dataGridView_Statement[--j, NA_Rows].Value = "н/а"; break;//Здесь j-1, т.к. j уже увеличился //инкремент сначало действие(+|-) потом инициализирует, а посткримент сначало инициализирует потом действие(+|-)
                //        case 2: this.dataGridView_Statement[NA_Columns, i].Value = "н/а"; break;//Здесь i не вычетали 1, т.к. i ещё не увеличивался
                //        case 3: this.dataGridView_Statement[NA_Columns, NA_Rows].Value = "н/а"; break;
                //    }
                //}
                //Вот это лучше Рандомит
                switch (integerRnd.Next(0, 2))
                {
                    case 0: break;
                    case 1:
                        switch (integerRnd.Next(1, 4))
                        {
                            case 1: this.dataGridView_Statement[--j, NA_Rows].Value = "н/а"; break;//Здесь j-1, т.к. j уже увеличился //инкремент сначало действие(+|-) потом инициализирует, а посткримент сначало инициализирует потом действие(+|-)
                            case 2: this.dataGridView_Statement[NA_Columns, i].Value = "н/а"; break;//Здесь i не вычетали 1, т.к. i ещё не увеличивался
                            case 3: this.dataGridView_Statement[NA_Columns, NA_Rows].Value = "н/а"; break;
                        }
                        break;
                }
            }
            //this.dataGridView_Statement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;

            //this.dataGridView_Statement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //this.dataGridView_Statement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Авторазмер заголовков Столбцов
            this.dataGridView_Statement.AutoResizeColumnHeadersHeight();

            //this.dataGridView_Statement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            //Авторазмер заголовков Строк
            this.dataGridView_Statement.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            //this.dataGridView_Statement.AutoResizeColumnHeadersHeight();
            //this.dataGridView_Statement.Cell 
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
            //Он добавляет строки не верно (они добаляются сверху, а не в конце строк) в отличии от столбцов !
            this.dataGridView_Statement.RowCount = Convert.ToInt32(numericUpDown_CountStud.Value);
        }

        private void numericUpDown_CountSubject_ValueChanged(object sender, EventArgs e)
        {
            this.dataGridView_Statement.ColumnCount = Convert.ToInt32(numericUpDown_CountSubject.Value);
        }

        private void button_AddByHand_Click(object sender, EventArgs e)
        {
            
        }
    }
}
