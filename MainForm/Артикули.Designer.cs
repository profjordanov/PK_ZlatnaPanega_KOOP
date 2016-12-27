namespace MainForm
{
    partial class Артикули
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Артикули));
            System.Windows.Forms.Label кодАртикулLabel;
            System.Windows.Forms.Label баркодLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label едЦенаLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label мяркаLabel;
            System.Windows.Forms.Label кодГрупаLabel;
            System.Windows.Forms.Label кодПодгрупаLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.артикулиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.артикулиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.АртикулиTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.артикулиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.артикулиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодАртикулTextBox = new System.Windows.Forms.TextBox();
            this.баркодTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.едЦенаTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.мяркаTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.групиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.групиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ГрупиTableAdapter();
            this.подгрупиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подгрупиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ПодгрупиTableAdapter();
            this.артикулиDataGridView = new System.Windows.Forms.DataGridView();
            this.групиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.подгрупиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            кодАртикулLabel = new System.Windows.Forms.Label();
            баркодLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            едЦенаLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            мяркаLabel = new System.Windows.Forms.Label();
            кодГрупаLabel = new System.Windows.Forms.Label();
            кодПодгрупаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиBindingNavigator)).BeginInit();
            this.артикулиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // артикулиBindingSource
            // 
            this.артикулиBindingSource.DataMember = "Артикули";
            this.артикулиBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // артикулиTableAdapter
            // 
            this.артикулиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АртикулиTableAdapter = this.артикулиTableAdapter;
            this.tableAdapterManager.ГрупиTableAdapter = this.групиTableAdapter;
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
            // артикулиBindingNavigator
            // 
            this.артикулиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.артикулиBindingNavigator.BindingSource = this.артикулиBindingSource;
            this.артикулиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.артикулиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.артикулиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.артикулиBindingNavigatorSaveItem});
            this.артикулиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.артикулиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.артикулиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.артикулиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.артикулиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.артикулиBindingNavigator.Name = "артикулиBindingNavigator";
            this.артикулиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.артикулиBindingNavigator.Size = new System.Drawing.Size(871, 25);
            this.артикулиBindingNavigator.TabIndex = 0;
            this.артикулиBindingNavigator.Text = "bindingNavigator1";
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
            // артикулиBindingNavigatorSaveItem
            // 
            this.артикулиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.артикулиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("артикулиBindingNavigatorSaveItem.Image")));
            this.артикулиBindingNavigatorSaveItem.Name = "артикулиBindingNavigatorSaveItem";
            this.артикулиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.артикулиBindingNavigatorSaveItem.Text = "Save Data";
            this.артикулиBindingNavigatorSaveItem.Click += new System.EventHandler(this.артикулиBindingNavigatorSaveItem_Click_1);
            // 
            // кодАртикулLabel
            // 
            кодАртикулLabel.AutoSize = true;
            кодАртикулLabel.Location = new System.Drawing.Point(4, 34);
            кодАртикулLabel.Name = "кодАртикулLabel";
            кодАртикулLabel.Size = new System.Drawing.Size(73, 13);
            кодАртикулLabel.TabIndex = 1;
            кодАртикулLabel.Text = "Код Артикул:";
            // 
            // кодАртикулTextBox
            // 
            this.кодАртикулTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.артикулиBindingSource, "КодАртикул", true));
            this.кодАртикулTextBox.Location = new System.Drawing.Point(96, 31);
            this.кодАртикулTextBox.Name = "кодАртикулTextBox";
            this.кодАртикулTextBox.Size = new System.Drawing.Size(124, 20);
            this.кодАртикулTextBox.TabIndex = 2;
            // 
            // баркодLabel
            // 
            баркодLabel.AutoSize = true;
            баркодLabel.Location = new System.Drawing.Point(4, 60);
            баркодLabel.Name = "баркодLabel";
            баркодLabel.Size = new System.Drawing.Size(47, 13);
            баркодLabel.TabIndex = 3;
            баркодLabel.Text = "Баркод:";
            // 
            // баркодTextBox
            // 
            this.баркодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.артикулиBindingSource, "Баркод", true));
            this.баркодTextBox.Location = new System.Drawing.Point(96, 57);
            this.баркодTextBox.Name = "баркодTextBox";
            this.баркодTextBox.Size = new System.Drawing.Size(124, 20);
            this.баркодTextBox.TabIndex = 4;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(4, 86);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 5;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.артикулиBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(96, 83);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(124, 20);
            this.наименованиеTextBox.TabIndex = 6;
            // 
            // едЦенаLabel
            // 
            едЦенаLabel.AutoSize = true;
            едЦенаLabel.Location = new System.Drawing.Point(4, 112);
            едЦенаLabel.Name = "едЦенаLabel";
            едЦенаLabel.Size = new System.Drawing.Size(52, 13);
            едЦенаLabel.TabIndex = 7;
            едЦенаLabel.Text = "Ед Цена:";
            // 
            // едЦенаTextBox
            // 
            this.едЦенаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.артикулиBindingSource, "ЕдЦена", true));
            this.едЦенаTextBox.Location = new System.Drawing.Point(96, 109);
            this.едЦенаTextBox.Name = "едЦенаTextBox";
            this.едЦенаTextBox.Size = new System.Drawing.Size(124, 20);
            this.едЦенаTextBox.TabIndex = 8;
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(310, 31);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 9;
            количествоLabel.Text = "Количество:";
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.артикулиBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(402, 28);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(124, 20);
            this.количествоTextBox.TabIndex = 10;
            // 
            // мяркаLabel
            // 
            мяркаLabel.AutoSize = true;
            мяркаLabel.Location = new System.Drawing.Point(310, 57);
            мяркаLabel.Name = "мяркаLabel";
            мяркаLabel.Size = new System.Drawing.Size(43, 13);
            мяркаLabel.TabIndex = 11;
            мяркаLabel.Text = "Мярка:";
            // 
            // мяркаTextBox
            // 
            this.мяркаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.артикулиBindingSource, "Мярка", true));
            this.мяркаTextBox.Location = new System.Drawing.Point(402, 54);
            this.мяркаTextBox.Name = "мяркаTextBox";
            this.мяркаTextBox.Size = new System.Drawing.Size(124, 20);
            this.мяркаTextBox.TabIndex = 12;
            // 
            // кодГрупаLabel
            // 
            кодГрупаLabel.AutoSize = true;
            кодГрупаLabel.Location = new System.Drawing.Point(310, 83);
            кодГрупаLabel.Name = "кодГрупаLabel";
            кодГрупаLabel.Size = new System.Drawing.Size(39, 13);
            кодГрупаLabel.TabIndex = 13;
            кодГрупаLabel.Text = "Група:";
            // 
            // кодПодгрупаLabel
            // 
            кодПодгрупаLabel.AutoSize = true;
            кодПодгрупаLabel.Location = new System.Drawing.Point(310, 109);
            кодПодгрупаLabel.Name = "кодПодгрупаLabel";
            кодПодгрупаLabel.Size = new System.Drawing.Size(58, 13);
            кодПодгрупаLabel.TabIndex = 15;
            кодПодгрупаLabel.Text = "Подгрупа:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.артикулиBindingSource, "КодПодгрупа", true));
            this.comboBox1.DataSource = this.подгрупиBindingSource;
            this.comboBox1.DisplayMember = "ИмеПодгрупа";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(402, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "КодПодгрупа";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.артикулиBindingSource, "КодГрупа", true));
            this.comboBox2.DataSource = this.групиBindingSource;
            this.comboBox2.DisplayMember = "ИмеГрупа";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(402, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "КодГрупа";
            // 
            // групиBindingSource
            // 
            this.групиBindingSource.DataMember = "Групи";
            this.групиBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // групиTableAdapter
            // 
            this.групиTableAdapter.ClearBeforeFill = true;
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
            // артикулиDataGridView
            // 
            this.артикулиDataGridView.AllowUserToAddRows = false;
            this.артикулиDataGridView.AutoGenerateColumns = false;
            this.артикулиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.артикулиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.артикулиDataGridView.DataSource = this.артикулиBindingSource;
            this.артикулиDataGridView.Location = new System.Drawing.Point(0, 169);
            this.артикулиDataGridView.Name = "артикулиDataGridView";
            this.артикулиDataGridView.Size = new System.Drawing.Size(835, 220);
            this.артикулиDataGridView.TabIndex = 17;
            // 
            // групиBindingSource1
            // 
            this.групиBindingSource1.DataMember = "Групи";
            this.групиBindingSource1.DataSource = this.златнаПанегаDataSet;
            // 
            // подгрупиBindingSource1
            // 
            this.подгрупиBindingSource1.DataMember = "Подгрупи";
            this.подгрупиBindingSource1.DataSource = this.златнаПанегаDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодАртикул";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодАртикул";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Баркод";
            this.dataGridViewTextBoxColumn2.HeaderText = "Баркод";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ЕдЦена";
            this.dataGridViewTextBoxColumn4.HeaderText = "ЕдЦена";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Мярка";
            this.dataGridViewTextBoxColumn6.HeaderText = "Мярка";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "КодГрупа";
            this.dataGridViewTextBoxColumn7.DataSource = this.групиBindingSource1;
            this.dataGridViewTextBoxColumn7.DisplayMember = "ИмеГрупа";
            this.dataGridViewTextBoxColumn7.HeaderText = "Група";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "КодГрупа";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "КодПодгрупа";
            this.dataGridViewTextBoxColumn8.DataSource = this.подгрупиBindingSource1;
            this.dataGridViewTextBoxColumn8.DisplayMember = "ИмеПодгрупа";
            this.dataGridViewTextBoxColumn8.HeaderText = "Подгрупа";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "КодПодгрупа";
            // 
            // Артикули
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.артикулиDataGridView);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(кодАртикулLabel);
            this.Controls.Add(this.кодАртикулTextBox);
            this.Controls.Add(баркодLabel);
            this.Controls.Add(this.баркодTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(едЦенаLabel);
            this.Controls.Add(this.едЦенаTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(мяркаLabel);
            this.Controls.Add(this.мяркаTextBox);
            this.Controls.Add(кодГрупаLabel);
            this.Controls.Add(кодПодгрупаLabel);
            this.Controls.Add(this.артикулиBindingNavigator);
            this.Name = "Артикули";
            this.Text = "Добавяне на артикули";
            this.Load += new System.EventHandler(this.Артикули_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиBindingNavigator)).EndInit();
            this.артикулиBindingNavigator.ResumeLayout(false);
            this.артикулиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подгрупиBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource артикулиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.АртикулиTableAdapter артикулиTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator артикулиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton артикулиBindingNavigatorSaveItem;
        private ЗлатнаПанегаDataSetTableAdapters.ГрупиTableAdapter групиTableAdapter;
        private System.Windows.Forms.TextBox кодАртикулTextBox;
        private System.Windows.Forms.TextBox баркодTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox едЦенаTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox мяркаTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource групиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ПодгрупиTableAdapter подгрупиTableAdapter;
        private System.Windows.Forms.BindingSource подгрупиBindingSource;
        private System.Windows.Forms.DataGridView артикулиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource групиBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource подгрупиBindingSource1;
    }
}