namespace MainForm
{
    partial class Подрупи_артикули
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Подрупи_артикули));
            System.Windows.Forms.Label кодПодгрупаLabel;
            System.Windows.Forms.Label имеПодгрупаLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.подгрупиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подгрупиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ПодгрупиTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.подгрупиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.подгрупиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодПодгрупаTextBox = new System.Windows.Forms.TextBox();
            this.имеПодгрупаTextBox = new System.Windows.Forms.TextBox();
            this.подгрупиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодПодгрупаLabel = new System.Windows.Forms.Label();
            имеПодгрупаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingNavigator)).BeginInit();
            this.подгрупиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // подгрупиBindingSource
            // 
            this.подгрупиBindingSource.DataMember = "Подгрупи";
            this.подгрупиBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // подгрупиTableAdapter
            // 
            this.подгрупиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АртикулиTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = null;
            this.tableAdapterManager.ДетайлиЗаявкиTableAdapter = null;
            this.tableAdapterManager.ДоставкиTableAdapter = null;
            this.tableAdapterManager.ДоставчикTableAdapter = null;
            this.tableAdapterManager.ЗаявкаТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.МОЛTableAdapter = null;
            this.tableAdapterManager.ПодгрупиTableAdapter = this.подгрупиTableAdapter;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = null;
            // 
            // подгрупиBindingNavigator
            // 
            this.подгрупиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.подгрупиBindingNavigator.BindingSource = this.подгрупиBindingSource;
            this.подгрупиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.подгрупиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.подгрупиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.подгрупиBindingNavigatorSaveItem});
            this.подгрупиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.подгрупиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.подгрупиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.подгрупиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.подгрупиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.подгрупиBindingNavigator.Name = "подгрупиBindingNavigator";
            this.подгрупиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.подгрупиBindingNavigator.Size = new System.Drawing.Size(365, 25);
            this.подгрупиBindingNavigator.TabIndex = 0;
            this.подгрупиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // подгрупиBindingNavigatorSaveItem
            // 
            this.подгрупиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.подгрупиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("подгрупиBindingNavigatorSaveItem.Image")));
            this.подгрупиBindingNavigatorSaveItem.Name = "подгрупиBindingNavigatorSaveItem";
            this.подгрупиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.подгрупиBindingNavigatorSaveItem.Text = "Save Data";
            this.подгрупиBindingNavigatorSaveItem.Click += new System.EventHandler(this.подгрупиBindingNavigatorSaveItem_Click);
            // 
            // кодПодгрупаLabel
            // 
            кодПодгрупаLabel.AutoSize = true;
            кодПодгрупаLabel.Location = new System.Drawing.Point(12, 36);
            кодПодгрупаLabel.Name = "кодПодгрупаLabel";
            кодПодгрупаLabel.Size = new System.Drawing.Size(95, 13);
            кодПодгрупаLabel.TabIndex = 1;
            кодПодгрупаLabel.Text = "Код на Подгрупа:";
            // 
            // кодПодгрупаTextBox
            // 
            this.кодПодгрупаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подгрупиBindingSource, "КодПодгрупа", true));
            this.кодПодгрупаTextBox.Location = new System.Drawing.Point(113, 33);
            this.кодПодгрупаTextBox.Name = "кодПодгрупаTextBox";
            this.кодПодгрупаTextBox.Size = new System.Drawing.Size(142, 20);
            this.кодПодгрупаTextBox.TabIndex = 2;
            // 
            // имеПодгрупаLabel
            // 
            имеПодгрупаLabel.AutoSize = true;
            имеПодгрупаLabel.Location = new System.Drawing.Point(12, 62);
            имеПодгрупаLabel.Name = "имеПодгрупаLabel";
            имеПодгрупаLabel.Size = new System.Drawing.Size(98, 13);
            имеПодгрупаLabel.TabIndex = 3;
            имеПодгрупаLabel.Text = "Име на Подгрупа:";
            // 
            // имеПодгрупаTextBox
            // 
            this.имеПодгрупаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подгрупиBindingSource, "ИмеПодгрупа", true));
            this.имеПодгрупаTextBox.Location = new System.Drawing.Point(113, 59);
            this.имеПодгрупаTextBox.Name = "имеПодгрупаTextBox";
            this.имеПодгрупаTextBox.Size = new System.Drawing.Size(142, 20);
            this.имеПодгрупаTextBox.TabIndex = 4;
            // 
            // подгрупиDataGridView
            // 
            this.подгрупиDataGridView.AutoGenerateColumns = false;
            this.подгрупиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.подгрупиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.подгрупиDataGridView.DataSource = this.подгрупиBindingSource;
            this.подгрупиDataGridView.Location = new System.Drawing.Point(12, 94);
            this.подгрупиDataGridView.Name = "подгрупиDataGridView";
            this.подгрупиDataGridView.Size = new System.Drawing.Size(300, 220);
            this.подгрупиDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодПодгрупа";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодПодгрупа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИмеПодгрупа";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИмеПодгрупа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Подрупи_артикули
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 324);
            this.Controls.Add(this.подгрупиDataGridView);
            this.Controls.Add(кодПодгрупаLabel);
            this.Controls.Add(this.кодПодгрупаTextBox);
            this.Controls.Add(имеПодгрупаLabel);
            this.Controls.Add(this.имеПодгрупаTextBox);
            this.Controls.Add(this.подгрупиBindingNavigator);
            this.Name = "Подрупи_артикули";
            this.Text = "Подрупи артикули";
            this.Load += new System.EventHandler(this.Подрупи_артикули_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingNavigator)).EndInit();
            this.подгрупиBindingNavigator.ResumeLayout(false);
            this.подгрупиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource подгрупиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ПодгрупиTableAdapter подгрупиTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator подгрупиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton подгрупиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодПодгрупаTextBox;
        private System.Windows.Forms.TextBox имеПодгрупаTextBox;
        private System.Windows.Forms.DataGridView подгрупиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}