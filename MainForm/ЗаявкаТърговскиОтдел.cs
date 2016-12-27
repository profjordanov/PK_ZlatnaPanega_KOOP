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
    public partial class ЗаявкаТърговскиОтдел : Form
    {
        public ЗаявкаТърговскиОтдел()
        {
            InitializeComponent();
        }

        private void заявкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void заявкиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void ЗаявкаТърговскиОтдел_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Артикули' table. You can move, or remove it, as needed.
            this.артикулиTableAdapter.Fill(this.златнаПанегаDataSet.Артикули);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Доставчик' table. You can move, or remove it, as needed.
            this.доставчикTableAdapter.Fill(this.златнаПанегаDataSet.Доставчик);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ДетайлиЗаявки' table. You can move, or remove it, as needed.
            this.детайлиЗаявкиTableAdapter.Fill(this.златнаПанегаDataSet.ДетайлиЗаявки);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ТърговскиОтдел' table. You can move, or remove it, as needed.
            this.търговскиОтделTableAdapter.Fill(this.златнаПанегаDataSet.ТърговскиОтдел);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ТърговскиОбект' table. You can move, or remove it, as needed.
            this.търговскиОбектTableAdapter.Fill(this.златнаПанегаDataSet.ТърговскиОбект);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Заявки' table. You can move, or remove it, as needed.
            this.заявкиTableAdapter.Fill(this.златнаПанегаDataSet.Заявки);

        }
    }
}
