namespace MainForm
{
    partial class Добавяе_на_продавач_консултанти
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавяе_на_продавач_консултанти));
            System.Windows.Forms.Label кодМОЛLabel;
            System.Windows.Forms.Label имеМОЛLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label градLabel;
            System.Windows.Forms.Label телефонLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.мОЛBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мОЛTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.МОЛTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.мОЛBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.мОЛBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодМОЛTextBox = new System.Windows.Forms.TextBox();
            this.имеМОЛTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.градTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.мОЛDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодМОЛLabel = new System.Windows.Forms.Label();
            имеМОЛLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            градLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛBindingNavigator)).BeginInit();
            this.мОЛBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // мОЛBindingSource
            // 
            this.мОЛBindingSource.DataMember = "МОЛ";
            this.мОЛBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // мОЛTableAdapter
            // 
            this.мОЛTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.МОЛTableAdapter = this.мОЛTableAdapter;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = null;
            // 
            // мОЛBindingNavigator
            // 
            this.мОЛBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.мОЛBindingNavigator.BindingSource = this.мОЛBindingSource;
            this.мОЛBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.мОЛBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.мОЛBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.мОЛBindingNavigatorSaveItem});
            this.мОЛBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.мОЛBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.мОЛBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.мОЛBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.мОЛBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.мОЛBindingNavigator.Name = "мОЛBindingNavigator";
            this.мОЛBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.мОЛBindingNavigator.Size = new System.Drawing.Size(623, 25);
            this.мОЛBindingNavigator.TabIndex = 0;
            this.мОЛBindingNavigator.Text = "bindingNavigator1";
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
            // мОЛBindingNavigatorSaveItem
            // 
            this.мОЛBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.мОЛBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("мОЛBindingNavigatorSaveItem.Image")));
            this.мОЛBindingNavigatorSaveItem.Name = "мОЛBindingNavigatorSaveItem";
            this.мОЛBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.мОЛBindingNavigatorSaveItem.Text = "Save Data";
            this.мОЛBindingNavigatorSaveItem.Click += new System.EventHandler(this.мОЛBindingNavigatorSaveItem_Click);
            // 
            // кодМОЛLabel
            // 
            кодМОЛLabel.AutoSize = true;
            кодМОЛLabel.Location = new System.Drawing.Point(5, 31);
            кодМОЛLabel.Name = "кодМОЛLabel";
            кодМОЛLabel.Size = new System.Drawing.Size(154, 13);
            кодМОЛLabel.TabIndex = 1;
            кодМОЛLabel.Text = "Код на продавач-консултант:";
            // 
            // кодМОЛTextBox
            // 
            this.кодМОЛTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мОЛBindingSource, "КодМОЛ", true));
            this.кодМОЛTextBox.Location = new System.Drawing.Point(171, 31);
            this.кодМОЛTextBox.Name = "кодМОЛTextBox";
            this.кодМОЛTextBox.Size = new System.Drawing.Size(156, 20);
            this.кодМОЛTextBox.TabIndex = 2;
            // 
            // имеМОЛLabel
            // 
            имеМОЛLabel.AutoSize = true;
            имеМОЛLabel.Location = new System.Drawing.Point(5, 57);
            имеМОЛLabel.Name = "имеМОЛLabel";
            имеМОЛLabel.Size = new System.Drawing.Size(157, 13);
            имеМОЛLabel.TabIndex = 3;
            имеМОЛLabel.Text = "Име на продавач-консултант:";
            // 
            // имеМОЛTextBox
            // 
            this.имеМОЛTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мОЛBindingSource, "ИмеМОЛ", true));
            this.имеМОЛTextBox.Location = new System.Drawing.Point(171, 57);
            this.имеМОЛTextBox.Name = "имеМОЛTextBox";
            this.имеМОЛTextBox.Size = new System.Drawing.Size(156, 20);
            this.имеМОЛTextBox.TabIndex = 4;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(5, 83);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 5;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мОЛBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(171, 83);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(156, 20);
            this.адресTextBox.TabIndex = 6;
            // 
            // градLabel
            // 
            градLabel.AutoSize = true;
            градLabel.Location = new System.Drawing.Point(5, 109);
            градLabel.Name = "градLabel";
            градLabel.Size = new System.Drawing.Size(34, 13);
            градLabel.TabIndex = 7;
            градLabel.Text = "Град:";
            // 
            // градTextBox
            // 
            this.градTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мОЛBindingSource, "Град", true));
            this.градTextBox.Location = new System.Drawing.Point(171, 109);
            this.градTextBox.Name = "градTextBox";
            this.градTextBox.Size = new System.Drawing.Size(156, 20);
            this.градTextBox.TabIndex = 8;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(5, 135);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 9;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.мОЛBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(171, 135);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(156, 20);
            this.телефонTextBox.TabIndex = 10;
            // 
            // мОЛDataGridView
            // 
            this.мОЛDataGridView.AllowUserToAddRows = false;
            this.мОЛDataGridView.AllowUserToOrderColumns = true;
            this.мОЛDataGridView.AutoGenerateColumns = false;
            this.мОЛDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.мОЛDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.мОЛDataGridView.DataSource = this.мОЛBindingSource;
            this.мОЛDataGridView.Location = new System.Drawing.Point(0, 161);
            this.мОЛDataGridView.Name = "мОЛDataGridView";
            this.мОЛDataGridView.Size = new System.Drawing.Size(611, 220);
            this.мОЛDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодМОЛ";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код на продавач-консултант:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИмеМОЛ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име на продавач-консултант:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Град";
            this.dataGridViewTextBoxColumn4.HeaderText = "Град";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Добавяе_на_продавач_консултанти
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 453);
            this.Controls.Add(this.мОЛDataGridView);
            this.Controls.Add(кодМОЛLabel);
            this.Controls.Add(this.кодМОЛTextBox);
            this.Controls.Add(имеМОЛLabel);
            this.Controls.Add(this.имеМОЛTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(градLabel);
            this.Controls.Add(this.градTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.мОЛBindingNavigator);
            this.Name = "Добавяе_на_продавач_консултанти";
            this.Text = "Добавяе на продавач-консултанти";
            this.Load += new System.EventHandler(this.Добавяе_на_продавач_консултанти_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛBindingNavigator)).EndInit();
            this.мОЛBindingNavigator.ResumeLayout(false);
            this.мОЛBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource мОЛBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.МОЛTableAdapter мОЛTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator мОЛBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton мОЛBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодМОЛTextBox;
        private System.Windows.Forms.TextBox имеМОЛTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox градTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DataGridView мОЛDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}