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
    public partial class Артикули : Form
    {
        public Артикули()
        {
            InitializeComponent();
        }

        private void артикулиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.артикулиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void артикулиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.артикулиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void Артикули_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Подгрупи' table. You can move, or remove it, as needed.
            this.подгрупиTableAdapter.Fill(this.златнаПанегаDataSet.Подгрупи);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Групи' table. You can move, or remove it, as needed.
            this.групиTableAdapter.Fill(this.златнаПанегаDataSet.Групи);
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Артикули' table. You can move, or remove it, as needed.
            this.артикулиTableAdapter.Fill(this.златнаПанегаDataSet.Артикули);

        }
    }
}
