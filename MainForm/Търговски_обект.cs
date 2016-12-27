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
    public partial class Търговски_обект : Form
    {
        public Търговски_обект()
        {
            InitializeComponent();
        }

        private void търговскиОбектBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.търговскиОбектBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void Търговски_обект_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.МОЛ' table. You can move, or remove it, as needed.
            this.мОЛTableAdapter.Fill(this.златнаПанегаDataSet.МОЛ);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Заявки' table. You can move, or remove it, as needed.
            this.заявкиTableAdapter.Fill(this.златнаПанегаDataSet.Заявки);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ТърговскиОбект' table. You can move, or remove it, as needed.
            this.търговскиОбектTableAdapter.Fill(this.златнаПанегаDataSet.ТърговскиОбект);

        }
    }
}
