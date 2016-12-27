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
    public partial class Доставки : Form
    {
        public Доставки()
        {
            InitializeComponent();
        }

        private void доставкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.доставкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void Доставки_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Заявки' table. You can move, or remove it, as needed.
            this.заявкиTableAdapter.Fill(this.златнаПанегаDataSet.Заявки);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ТърговскиОтдел' table. You can move, or remove it, as needed.
            this.търговскиОтделTableAdapter.Fill(this.златнаПанегаDataSet.ТърговскиОтдел);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Доставчик' table. You can move, or remove it, as needed.
            this.доставчикTableAdapter.Fill(this.златнаПанегаDataSet.Доставчик);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Доставки' table. You can move, or remove it, as needed.
            this.доставкиTableAdapter.Fill(this.златнаПанегаDataSet.Доставки);

        }
    }
}
