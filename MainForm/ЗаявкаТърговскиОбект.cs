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
    public partial class ЗаявкаТърговскиОбект : Form
    {
        public ЗаявкаТърговскиОбект()
        {
            InitializeComponent();
        }

        private void заявкаТърговскиОбектBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заявкаТърговскиОбектBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void ЗаявкаТърговскиОбект_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ТърговскиОтдел' table. You can move, or remove it, as needed.
            this.търговскиОтделTableAdapter.Fill(this.златнаПанегаDataSet.ТърговскиОтдел);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ЗаявкаТърговскиОбект' table. You can move, or remove it, as needed.
            this.заявкаТърговскиОбектTableAdapter.Fill(this.златнаПанегаDataSet.ЗаявкаТърговскиОбект);

        }
    }
}
