namespace MainForm
{
    partial class Търговски_обект
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Търговски_обект));
            System.Windows.Forms.Label кодТърговскиОбектLabel;
            System.Windows.Forms.Label кодМОЛLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label местоположениеLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.търговскиОбектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.търговскиОбектTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ТърговскиОбектTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.търговскиОбектBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.търговскиОбектBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодТърговскиОбектTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.местоположениеTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ЗаявкиTableAdapter();
            this.мОЛBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.мОЛTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.МОЛTableAdapter();
            this.търговскиОбектDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодТърговскиОбектLabel = new System.Windows.Forms.Label();
            кодМОЛLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            местоположениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектBindingNavigator)).BeginInit();
            this.търговскиОбектBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // търговскиОбектBindingSource
            // 
            this.търговскиОбектBindingSource.DataMember = "ТърговскиОбект";
            this.търговскиОбектBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // търговскиОбектTableAdapter
            // 
            this.търговскиОбектTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ЗаявкиTableAdapter = this.заявкиTableAdapter;
            this.tableAdapterManager.МОЛTableAdapter = this.мОЛTableAdapter;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = this.търговскиОбектTableAdapter;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = null;
            // 
            // търговскиОбектBindingNavigator
            // 
            this.търговскиОбектBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.търговскиОбектBindingNavigator.BindingSource = this.търговскиОбектBindingSource;
            this.търговскиОбектBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.търговскиОбектBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.търговскиОбектBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.търговскиОбектBindingNavigatorSaveItem});
            this.търговскиОбектBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.търговскиОбектBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.търговскиОбектBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.търговскиОбектBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.търговскиОбектBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.търговскиОбектBindingNavigator.Name = "търговскиОбектBindingNavigator";
            this.търговскиОбектBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.търговскиОбектBindingNavigator.Size = new System.Drawing.Size(610, 25);
            this.търговскиОбектBindingNavigator.TabIndex = 0;
            this.търговскиОбектBindingNavigator.Text = "bindingNavigator1";
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
            // търговскиОбектBindingNavigatorSaveItem
            // 
            this.търговскиОбектBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.търговскиОбектBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("търговскиОбектBindingNavigatorSaveItem.Image")));
            this.търговскиОбектBindingNavigatorSaveItem.Name = "търговскиОбектBindingNavigatorSaveItem";
            this.търговскиОбектBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.търговскиОбектBindingNavigatorSaveItem.Text = "Save Data";
            this.търговскиОбектBindingNavigatorSaveItem.Click += new System.EventHandler(this.търговскиОбектBindingNavigatorSaveItem_Click);
            // 
            // кодТърговскиОбектLabel
            // 
            кодТърговскиОбектLabel.AutoSize = true;
            кодТърговскиОбектLabel.Location = new System.Drawing.Point(12, 34);
            кодТърговскиОбектLabel.Name = "кодТърговскиОбектLabel";
            кодТърговскиОбектLabel.Size = new System.Drawing.Size(132, 13);
            кодТърговскиОбектLabel.TabIndex = 1;
            кодТърговскиОбектLabel.Text = "Код на търговски обект:";
            // 
            // кодТърговскиОбектTextBox
            // 
            this.кодТърговскиОбектTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.търговскиОбектBindingSource, "КодТърговскиОбект", true));
            this.кодТърговскиОбектTextBox.Location = new System.Drawing.Point(150, 31);
            this.кодТърговскиОбектTextBox.Name = "кодТърговскиОбектTextBox";
            this.кодТърговскиОбектTextBox.Size = new System.Drawing.Size(121, 20);
            this.кодТърговскиОбектTextBox.TabIndex = 2;
            // 
            // кодМОЛLabel
            // 
            кодМОЛLabel.AutoSize = true;
            кодМОЛLabel.Location = new System.Drawing.Point(12, 109);
            кодМОЛLabel.Name = "кодМОЛLabel";
            кодМОЛLabel.Size = new System.Drawing.Size(119, 13);
            кодМОЛLabel.TabIndex = 3;
            кодМОЛLabel.Text = "Продавач-консултант:";
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(12, 57);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 5;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.търговскиОбектBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(150, 57);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(121, 20);
            this.наименованиеTextBox.TabIndex = 6;
            // 
            // местоположениеLabel
            // 
            местоположениеLabel.AutoSize = true;
            местоположениеLabel.Location = new System.Drawing.Point(12, 83);
            местоположениеLabel.Name = "местоположениеLabel";
            местоположениеLabel.Size = new System.Drawing.Size(98, 13);
            местоположениеLabel.TabIndex = 7;
            местоположениеLabel.Text = "Местоположение:";
            // 
            // местоположениеTextBox
            // 
            this.местоположениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.търговскиОбектBindingSource, "Местоположение", true));
            this.местоположениеTextBox.Location = new System.Drawing.Point(150, 80);
            this.местоположениеTextBox.Name = "местоположениеTextBox";
            this.местоположениеTextBox.Size = new System.Drawing.Size(121, 20);
            this.местоположениеTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.търговскиОбектBindingSource, "КодМОЛ", true));
            this.comboBox1.DataSource = this.мОЛBindingSource;
            this.comboBox1.DisplayMember = "ИмеМОЛ";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "КодМОЛ";
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
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
            // търговскиОбектDataGridView
            // 
            this.търговскиОбектDataGridView.AllowUserToAddRows = false;
            this.търговскиОбектDataGridView.AllowUserToOrderColumns = true;
            this.търговскиОбектDataGridView.AutoGenerateColumns = false;
            this.търговскиОбектDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.търговскиОбектDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.търговскиОбектDataGridView.DataSource = this.търговскиОбектBindingSource;
            this.търговскиОбектDataGridView.Location = new System.Drawing.Point(15, 142);
            this.търговскиОбектDataGridView.Name = "търговскиОбектDataGridView";
            this.търговскиОбектDataGridView.Size = new System.Drawing.Size(455, 220);
            this.търговскиОбектDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодТърговскиОбект";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодТърговскиОбект";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Местоположение";
            this.dataGridViewTextBoxColumn4.HeaderText = "Местоположение";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Търговски_обект
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 425);
            this.Controls.Add(this.търговскиОбектDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(кодТърговскиОбектLabel);
            this.Controls.Add(this.кодТърговскиОбектTextBox);
            this.Controls.Add(кодМОЛLabel);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(местоположениеLabel);
            this.Controls.Add(this.местоположениеTextBox);
            this.Controls.Add(this.търговскиОбектBindingNavigator);
            this.Name = "Търговски_обект";
            this.Text = "Добавяне на търговски обект";
            this.Load += new System.EventHandler(this.Търговски_обект_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектBindingNavigator)).EndInit();
            this.търговскиОбектBindingNavigator.ResumeLayout(false);
            this.търговскиОбектBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мОЛBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource търговскиОбектBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ТърговскиОбектTableAdapter търговскиОбектTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator търговскиОбектBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton търговскиОбектBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодТърговскиОбектTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox местоположениеTextBox;
        private ЗлатнаПанегаDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.МОЛTableAdapter мОЛTableAdapter;
        private System.Windows.Forms.BindingSource мОЛBindingSource;
        private System.Windows.Forms.DataGridView търговскиОбектDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}