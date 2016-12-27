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
    public partial class Групи_артикули : Form
    {
        public Групи_артикули()
        {
            InitializeComponent();
        }

        private void групиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.групиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.златнаПанегаDataSet);

        }

        private void Групи_артикули_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'златнаПанегаDataSet.Групи' table. You can move, or remove it, as needed.
            this.групиTableAdapter.Fill(this.златнаПанегаDataSet.Групи);

        }
    }
}
