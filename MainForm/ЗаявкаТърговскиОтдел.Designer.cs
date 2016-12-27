namespace MainForm
{
    partial class ЗаявкаТърговскиОтдел
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
            System.Windows.Forms.Label кодЗаявкаLabel;
            System.Windows.Forms.Label кодСпециалистЛогистикаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ЗаявкаТърговскиОтдел));
            System.Windows.Forms.Label статсLabel;
            System.Windows.Forms.Label датаЗаявкаLabel;
            System.Windows.Forms.Label кодДоставчикLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ЗаявкиTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.детайлиЗаявкиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ДетайлиЗаявкиTableAdapter();
            this.търговскиОбектTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ТърговскиОбектTableAdapter();
            this.търговскиОтделTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter();
            this.заявкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заявкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодЗаявкаTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.търговскиОтделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.търговскиОбектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.детайлиЗаявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статсTextBox = new System.Windows.Forms.TextBox();
            this.датаЗаявкаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.доставчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставчикTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ДоставчикTableAdapter();
            this.заявкиDataGridView = new System.Windows.Forms.DataGridView();
            this.артикулиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.артикулиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.АртикулиTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодЗаявкаLabel = new System.Windows.Forms.Label();
            кодСпециалистЛогистикаLabel = new System.Windows.Forms.Label();
            статсLabel = new System.Windows.Forms.Label();
            датаЗаявкаLabel = new System.Windows.Forms.Label();
            кодДоставчикLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingNavigator)).BeginInit();
            this.заявкиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детайлиЗаявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // кодЗаявкаLabel
            // 
            кодЗаявкаLabel.AutoSize = true;
            кодЗаявкаLabel.Location = new System.Drawing.Point(12, 39);
            кодЗаявкаLabel.Name = "кодЗаявкаLabel";
            кодЗаявкаLabel.Size = new System.Drawing.Size(94, 13);
            кодЗаявкаLabel.TabIndex = 1;
            кодЗаявкаLabel.Text = "Код на заявката:";
            // 
            // кодСпециалистЛогистикаLabel
            // 
            кодСпециалистЛогистикаLabel.AutoSize = true;
            кодСпециалистЛогистикаLabel.Location = new System.Drawing.Point(12, 68);
            кодСпециалистЛогистикаLabel.Name = "кодСпециалистЛогистикаLabel";
            кодСпециалистЛогистикаLabel.Size = new System.Drawing.Size(127, 13);
            кодСпециалистЛогистикаLabel.TabIndex = 7;
            кодСпециалистЛогистикаLabel.Text = "Специалист Логистика:";
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АртикулиTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = null;
            this.tableAdapterManager.ДетайлиЗаявкиTableAdapter = this.детайлиЗаявкиTableAdapter;
            this.tableAdapterManager.ДоставкиTableAdapter = null;
            this.tableAdapterManager.ДоставчикTableAdapter = null;
            this.tableAdapterManager.ЗаявкаТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = this.заявкиTableAdapter;
            this.tableAdapterManager.МОЛTableAdapter = null;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = this.търговскиОбектTableAdapter;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = this.търговскиОтделTableAdapter;
            // 
            // детайлиЗаявкиTableAdapter
            // 
            this.детайлиЗаявкиTableAdapter.ClearBeforeFill = true;
            // 
            // търговскиОбектTableAdapter
            // 
            this.търговскиОбектTableAdapter.ClearBeforeFill = true;
            // 
            // търговскиОтделTableAdapter
            // 
            this.търговскиОтделTableAdapter.ClearBeforeFill = true;
            // 
            // заявкиBindingNavigator
            // 
            this.заявкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявкиBindingNavigator.BindingSource = this.заявкиBindingSource;
            this.заявкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заявкиBindingNavigatorSaveItem});
            this.заявкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заявкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявкиBindingNavigator.Name = "заявкиBindingNavigator";
            this.заявкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявкиBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.заявкиBindingNavigator.TabIndex = 0;
            this.заявкиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заявкиBindingNavigatorSaveItem
            // 
            this.заявкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкиBindingNavigatorSaveItem.Image")));
            this.заявкиBindingNavigatorSaveItem.Name = "заявкиBindingNavigatorSaveItem";
            this.заявкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заявкиBindingNavigatorSaveItem.Text = "Save Data";
            this.заявкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявкиBindingNavigatorSaveItem_Click_1);
            // 
            // кодЗаявкаTextBox
            // 
            this.кодЗаявкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкиBindingSource, "КодЗаявка", true));
            this.кодЗаявкаTextBox.Location = new System.Drawing.Point(143, 36);
            this.кодЗаявкаTextBox.Name = "кодЗаявкаTextBox";
            this.кодЗаявкаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодЗаявкаTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заявкиBindingSource, "КодСпециалистЛогистика", true));
            this.comboBox1.DataSource = this.търговскиОтделBindingSource;
            this.comboBox1.DisplayMember = "ИмеСпециалистЛогистика";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "КодСпециалистЛогистика";
            // 
            // търговскиОтделBindingSource
            // 
            this.търговскиОтделBindingSource.DataMember = "ТърговскиОтдел";
            this.търговскиОтделBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // търговскиОбектBindingSource
            // 
            this.търговскиОбектBindingSource.DataMember = "ТърговскиОбект";
            this.търговскиОбектBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // детайлиЗаявкиBindingSource
            // 
            this.детайлиЗаявкиBindingSource.DataMember = "FK__ДетайлиЗа__КодЗа__37A5467C";
            this.детайлиЗаявкиBindingSource.DataSource = this.заявкиBindingSource;
            // 
            // статсTextBox
            // 
            this.статсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.детайлиЗаявкиBindingSource, "Статс", true));
            this.статсTextBox.Location = new System.Drawing.Point(143, 149);
            this.статсTextBox.Name = "статсTextBox";
            this.статсTextBox.Size = new System.Drawing.Size(200, 20);
            this.статсTextBox.TabIndex = 15;
            // 
            // статсLabel
            // 
            статсLabel.AutoSize = true;
            статсLabel.Location = new System.Drawing.Point(12, 148);
            статсLabel.Name = "статсLabel";
            статсLabel.Size = new System.Drawing.Size(39, 13);
            статсLabel.TabIndex = 14;
            статсLabel.Text = "Статс:";
            // 
            // датаЗаявкаDateTimePicker
            // 
            this.датаЗаявкаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.детайлиЗаявкиBindingSource, "ДатаЗаявка", true));
            this.датаЗаявкаDateTimePicker.Location = new System.Drawing.Point(143, 123);
            this.датаЗаявкаDateTimePicker.Name = "датаЗаявкаDateTimePicker";
            this.датаЗаявкаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаЗаявкаDateTimePicker.TabIndex = 13;
            // 
            // датаЗаявкаLabel
            // 
            датаЗаявкаLabel.AutoSize = true;
            датаЗаявкаLabel.Location = new System.Drawing.Point(12, 123);
            датаЗаявкаLabel.Name = "датаЗаявкаLabel";
            датаЗаявкаLabel.Size = new System.Drawing.Size(36, 13);
            датаЗаявкаLabel.TabIndex = 12;
            датаЗаявкаLabel.Text = "Дата:";
            // 
            // кодДоставчикLabel
            // 
            кодДоставчикLabel.AutoSize = true;
            кодДоставчикLabel.Location = new System.Drawing.Point(12, 96);
            кодДоставчикLabel.Name = "кодДоставчикLabel";
            кодДоставчикLabel.Size = new System.Drawing.Size(65, 13);
            кодДоставчикLabel.TabIndex = 10;
            кодДоставчикLabel.Text = "Доставчик:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.детайлиЗаявкиBindingSource, "КодДоставчик", true));
            this.comboBox2.DataSource = this.доставчикBindingSource;
            this.comboBox2.DisplayMember = "Име";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "КодДоставчик";
            // 
            // доставчикBindingSource
            // 
            this.доставчикBindingSource.DataMember = "Доставчик";
            this.доставчикBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // доставчикTableAdapter
            // 
            this.доставчикTableAdapter.ClearBeforeFill = true;
            // 
            // заявкиDataGridView
            // 
            this.заявкиDataGridView.AutoGenerateColumns = false;
            this.заявкиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.заявкиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.заявкиDataGridView.DataSource = this.заявкиBindingSource;
            this.заявкиDataGridView.Location = new System.Drawing.Point(358, 28);
            this.заявкиDataGridView.Name = "заявкиDataGridView";
            this.заявкиDataGridView.Size = new System.Drawing.Size(260, 291);
            this.заявкиDataGridView.TabIndex = 16;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "КодАртикул";
            this.dataGridViewTextBoxColumn2.DataSource = this.артикулиBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "КодАртикул";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ЗаявкаТърговскиОтдел
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 328);
            this.Controls.Add(this.заявкиDataGridView);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(кодДоставчикLabel);
            this.Controls.Add(датаЗаявкаLabel);
            this.Controls.Add(this.датаЗаявкаDateTimePicker);
            this.Controls.Add(статсLabel);
            this.Controls.Add(this.статсTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(кодЗаявкаLabel);
            this.Controls.Add(this.кодЗаявкаTextBox);
            this.Controls.Add(кодСпециалистЛогистикаLabel);
            this.Controls.Add(this.заявкиBindingNavigator);
            this.Name = "ЗаявкаТърговскиОтдел";
            this.Text = "Обобщена заявка от ТърговскиОтдел";
            this.Load += new System.EventHandler(this.ЗаявкаТърговскиОтдел_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingNavigator)).EndInit();
            this.заявкиBindingNavigator.ResumeLayout(false);
            this.заявкиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОбектBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детайлиЗаявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.артикулиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заявкиBindingNavigatorSaveItem;
        private ЗлатнаПанегаDataSetTableAdapters.ТърговскиОбектTableAdapter търговскиОбектTableAdapter;
        private System.Windows.Forms.TextBox кодЗаявкаTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource търговскиОбектBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter търговскиОтделTableAdapter;
        private System.Windows.Forms.BindingSource търговскиОтделBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ДетайлиЗаявкиTableAdapter детайлиЗаявкиTableAdapter;
        private System.Windows.Forms.BindingSource детайлиЗаявкиBindingSource;
        private System.Windows.Forms.TextBox статсTextBox;
        private System.Windows.Forms.DateTimePicker датаЗаявкаDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource доставчикBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ДоставчикTableAdapter доставчикTableAdapter;
        private System.Windows.Forms.DataGridView заявкиDataGridView;
        private System.Windows.Forms.BindingSource артикулиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.АртикулиTableAdapter артикулиTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}