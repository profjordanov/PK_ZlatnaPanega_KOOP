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
    public partial class Търговски_Oтдел : Form
    {
        public Търговски_Oтдел()
        {
            InitializeComponent();
        }

        private void търговскиОтделBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.търговскиОтделBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void Търговски_Oтдел_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.ТърговскиОтдел' table. You can move, or remove it, as needed.
            this.търговскиОтделTableAdapter.Fill(this.златнаПанегаDataSet.ТърговскиОтдел);

        }
    }
}
