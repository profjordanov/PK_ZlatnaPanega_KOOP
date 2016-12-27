namespace MainForm
{
    partial class Доставки
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Доставки));
            System.Windows.Forms.Label кодДоставкаLabel;
            System.Windows.Forms.Label номерФакутраLabel;
            System.Windows.Forms.Label датаДоставкаLabel;
            System.Windows.Forms.Label кодДоставчикLabel;
            System.Windows.Forms.Label кодСпециалистЛогистикаLabel;
            System.Windows.Forms.Label кодЗаявкаLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.доставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставкиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ДоставкиTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.доставкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.доставкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодДоставкаTextBox = new System.Windows.Forms.TextBox();
            this.номерФакутраTextBox = new System.Windows.Forms.TextBox();
            this.датаДоставкаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.доставчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставчикTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ДоставчикTableAdapter();
            this.търговскиОтделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.търговскиОтделTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ЗаявкиTableAdapter();
            кодДоставкаLabel = new System.Windows.Forms.Label();
            номерФакутраLabel = new System.Windows.Forms.Label();
            датаДоставкаLabel = new System.Windows.Forms.Label();
            кодДоставчикLabel = new System.Windows.Forms.Label();
            кодСпециалистЛогистикаLabel = new System.Windows.Forms.Label();
            кодЗаявкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкиBindingNavigator)).BeginInit();
            this.доставкиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // доставкиBindingSource
            // 
            this.доставкиBindingSource.DataMember = "Доставки";
            this.доставкиBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // доставкиTableAdapter
            // 
            this.доставкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АртикулиTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = null;
            this.tableAdapterManager.ДетайлиЗаявкиTableAdapter = null;
            this.tableAdapterManager.ДоставкиTableAdapter = this.доставкиTableAdapter;
            this.tableAdapterManager.ДоставчикTableAdapter = this.доставчикTableAdapter;
            this.tableAdapterManager.ЗаявкаТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = this.заявкиTableAdapter;
            this.tableAdapterManager.МОЛTableAdapter = null;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = this.търговскиОтделTableAdapter;
            // 
            // доставкиBindingNavigator
            // 
            this.доставкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.доставкиBindingNavigator.BindingSource = this.доставкиBindingSource;
            this.доставкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.доставкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.доставкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.доставкиBindingNavigatorSaveItem});
            this.доставкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.доставкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.доставкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.доставкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.доставкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.доставкиBindingNavigator.Name = "доставкиBindingNavigator";
            this.доставкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.доставкиBindingNavigator.Size = new System.Drawing.Size(416, 25);
            this.доставкиBindingNavigator.TabIndex = 0;
            this.доставкиBindingNavigator.Text = "bindingNavigator1";
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
            // доставкиBindingNavigatorSaveItem
            // 
            this.доставкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.доставкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("доставкиBindingNavigatorSaveItem.Image")));
            this.доставкиBindingNavigatorSaveItem.Name = "доставкиBindingNavigatorSaveItem";
            this.доставкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.доставкиBindingNavigatorSaveItem.Text = "Save Data";
            this.доставкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.доставкиBindingNavigatorSaveItem_Click);
            // 
            // кодДоставкаLabel
            // 
            кодДоставкаLabel.AutoSize = true;
            кодДоставкаLabel.Location = new System.Drawing.Point(12, 34);
            кодДоставкаLabel.Name = "кодДоставкаLabel";
            кодДоставкаLabel.Size = new System.Drawing.Size(97, 13);
            кодДоставкаLabel.TabIndex = 1;
            кодДоставкаLabel.Text = "Код на Доставка:";
            // 
            // кодДоставкаTextBox
            // 
            this.кодДоставкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкиBindingSource, "КодДоставка", true));
            this.кодДоставкаTextBox.Location = new System.Drawing.Point(167, 31);
            this.кодДоставкаTextBox.Name = "кодДоставкаTextBox";
            this.кодДоставкаTextBox.Size = new System.Drawing.Size(200, 20);
            this.кодДоставкаTextBox.TabIndex = 2;
            // 
            // номерФакутраLabel
            // 
            номерФакутраLabel.AutoSize = true;
            номерФакутраLabel.Location = new System.Drawing.Point(12, 60);
            номерФакутраLabel.Name = "номерФакутраLabel";
            номерФакутраLabel.Size = new System.Drawing.Size(104, 13);
            номерФакутраLabel.TabIndex = 3;
            номерФакутраLabel.Text = "Номер нa факутра:";
            // 
            // номерФакутраTextBox
            // 
            this.номерФакутраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставкиBindingSource, "НомерФакутра", true));
            this.номерФакутраTextBox.Location = new System.Drawing.Point(167, 57);
            this.номерФакутраTextBox.Name = "номерФакутраTextBox";
            this.номерФакутраTextBox.Size = new System.Drawing.Size(200, 20);
            this.номерФакутраTextBox.TabIndex = 4;
            // 
            // датаДоставкаLabel
            // 
            датаДоставкаLabel.AutoSize = true;
            датаДоставкаLabel.Location = new System.Drawing.Point(12, 87);
            датаДоставкаLabel.Name = "датаДоставкаLabel";
            датаДоставкаLabel.Size = new System.Drawing.Size(36, 13);
            датаДоставкаLabel.TabIndex = 5;
            датаДоставкаLabel.Text = "Дата:";
            // 
            // датаДоставкаDateTimePicker
            // 
            this.датаДоставкаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.доставкиBindingSource, "ДатаДоставка", true));
            this.датаДоставкаDateTimePicker.Location = new System.Drawing.Point(167, 83);
            this.датаДоставкаDateTimePicker.Name = "датаДоставкаDateTimePicker";
            this.датаДоставкаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датаДоставкаDateTimePicker.TabIndex = 6;
            // 
            // кодДоставчикLabel
            // 
            кодДоставчикLabel.AutoSize = true;
            кодДоставчикLabel.Location = new System.Drawing.Point(12, 112);
            кодДоставчикLabel.Name = "кодДоставчикLabel";
            кодДоставчикLabel.Size = new System.Drawing.Size(65, 13);
            кодДоставчикLabel.TabIndex = 7;
            кодДоставчикLabel.Text = "Доставчик:";
            // 
            // кодСпециалистЛогистикаLabel
            // 
            кодСпециалистЛогистикаLabel.AutoSize = true;
            кодСпециалистЛогистикаLabel.Location = new System.Drawing.Point(12, 138);
            кодСпециалистЛогистикаLabel.Name = "кодСпециалистЛогистикаLabel";
            кодСпециалистЛогистикаLabel.Size = new System.Drawing.Size(127, 13);
            кодСпециалистЛогистикаLabel.TabIndex = 9;
            кодСпециалистЛогистикаLabel.Text = "Специалист Логистика:";
            // 
            // кодЗаявкаLabel
            // 
            кодЗаявкаLabel.AutoSize = true;
            кодЗаявкаLabel.Location = new System.Drawing.Point(12, 164);
            кодЗаявкаLabel.Name = "кодЗаявкаLabel";
            кодЗаявкаLabel.Size = new System.Drawing.Size(64, 13);
            кодЗаявкаLabel.TabIndex = 11;
            кодЗаявкаLabel.Text = "По Заявка:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.доставкиBindingSource, "КодДоставчик", true));
            this.comboBox1.DataSource = this.доставчикBindingSource;
            this.comboBox1.DisplayMember = "Име";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "КодДоставчик";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.доставкиBindingSource, "КодСпециалистЛогистика", true));
            this.comboBox2.DataSource = this.търговскиОтделBindingSource;
            this.comboBox2.DisplayMember = "ИмеСпециалистЛогистика";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "КодСпециалистЛогистика";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.доставкиBindingSource, "КодЗаявка", true));
            this.comboBox3.DataSource = this.заявкиBindingSource;
            this.comboBox3.DisplayMember = "КодЗаявка";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(167, 165);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "КодЗаявка";
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
            // търговскиОтделBindingSource
            // 
            this.търговскиОтделBindingSource.DataMember = "ТърговскиОтдел";
            this.търговскиОтделBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // търговскиОтделTableAdapter
            // 
            this.търговскиОтделTableAdapter.ClearBeforeFill = true;
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
            // Доставки
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 217);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(кодДоставкаLabel);
            this.Controls.Add(this.кодДоставкаTextBox);
            this.Controls.Add(номерФакутраLabel);
            this.Controls.Add(this.номерФакутраTextBox);
            this.Controls.Add(датаДоставкаLabel);
            this.Controls.Add(this.датаДоставкаDateTimePicker);
            this.Controls.Add(кодДоставчикLabel);
            this.Controls.Add(кодСпециалистЛогистикаLabel);
            this.Controls.Add(кодЗаявкаLabel);
            this.Controls.Add(this.доставкиBindingNavigator);
            this.Name = "Доставки";
            this.Text = "Доставки";
            this.Load += new System.EventHandler(this.Доставки_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставкиBindingNavigator)).EndInit();
            this.доставкиBindingNavigator.ResumeLayout(false);
            this.доставкиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource доставкиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ДоставкиTableAdapter доставкиTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator доставкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton доставкиBindingNavigatorSaveItem;
        private ЗлатнаПанегаDataSetTableAdapters.ДоставчикTableAdapter доставчикTableAdapter;
        private System.Windows.Forms.TextBox кодДоставкаTextBox;
        private System.Windows.Forms.TextBox номерФакутраTextBox;
        private System.Windows.Forms.DateTimePicker датаДоставкаDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource доставчикBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter търговскиОтделTableAdapter;
        private System.Windows.Forms.BindingSource търговскиОтделBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
    }
}