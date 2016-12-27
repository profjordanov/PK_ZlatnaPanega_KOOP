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
    public partial class Подрупи_артикули : Form
    {
        public Подрупи_артикули()
        {
            InitializeComponent();
        }

        private void подгрупиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.подгрупиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void Подрупи_артикули_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Подгрупи' table. You can move, or remove it, as needed.
            this.подгрупиTableAdapter.Fill(this.златнаПанегаDataSet.Подгрупи);

        }
    }
}
