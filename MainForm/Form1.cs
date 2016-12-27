using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void доставчициToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Доставчици().Show();
        }

        private void продавачконсултантиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Добавяе_на_продавач_консултанти().Show();
        }

        private void търговскиОбектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Търговски_обект().Show();
        }

        private void групиАртикулиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Групи_артикули().Show();
        }

        private void артикулиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Подрупи_артикули().Show();
        }

        private void артикулиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Артикули().Show();
        }

        private void търговскиОтделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ЗаявкаТърговскиОтдел().Show();
        }
    }
}
