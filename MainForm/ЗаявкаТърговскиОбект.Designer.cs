namespace MainForm
{
    partial class ЗаявкаТърговскиОбект
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ЗаявкаТърговскиОбект));
            System.Windows.Forms.Label кодЗаявкаТърговскиОбектLabel;
            System.Windows.Forms.Label кодСпециалистЛогистикаLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.заявкаТърговскиОбектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкаТърговскиОбектTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ЗаявкаТърговскиОбектTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.заявкаТърговскиОбектBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.заявкаТърговскиОбектBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодЗаявкаТърговскиОбектTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.заявкаТърговскиОбектBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.търговскиОтделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.търговскиОтделTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter();
            кодЗаявкаТърговскиОбектLabel = new System.Windows.Forms.Label();
            кодСпециалистЛогистикаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаТърговскиОбектBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаТърговскиОбектBindingNavigator)).BeginInit();
            this.заявкаТърговскиОбектBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаТърговскиОбектBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкаТърговскиОбектBindingSource
            // 
            this.заявкаТърговскиОбектBindingSource.DataMember = "ЗаявкаТърговскиОбект";
            this.заявкаТърговскиОбектBindingSource.DataSource = this.златнаПанегаDataSet;
            // 
            // заявкаТърговскиОбектTableAdapter
            // 
            this.заявкаТърговскиОбектTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ЗаявкаТърговскиОбектTableAdapter = this.заявкаТърговскиОбектTableAdapter;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.МОЛTableAdapter = null;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = this.търговскиОтделTableAdapter;
            // 
            // заявкаТърговскиОбектBindingNavigator
            // 
            this.заявкаТърговскиОбектBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заявкаТърговскиОбектBindingNavigator.BindingSource = this.заявкаТърговскиОбектBindingSource;
            this.заявкаТърговскиОбектBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заявкаТърговскиОбектBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заявкаТърговскиОбектBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заявкаТърговскиОбектBindingNavigatorSaveItem});
            this.заявкаТърговскиОбектBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заявкаТърговскиОбектBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заявкаТърговскиОбектBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заявкаТърговскиОбектBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заявкаТърговскиОбектBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заявкаТърговскиОбектBindingNavigator.Name = "заявкаТърговскиОбектBindingNavigator";
            this.заявкаТърговскиОбектBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заявкаТърговскиОбектBindingNavigator.Size = new System.Drawing.Size(627, 25);
            this.заявкаТърговскиОбектBindingNavigator.TabIndex = 0;
            this.заявкаТърговскиОбектBindingNavigator.Text = "bindingNavigator1";
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
            // заявкаТърговскиОбектBindingNavigatorSaveItem
            // 
            this.заявкаТърговскиОбектBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заявкаТърговскиОбектBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заявкаТърговскиОбектBindingNavigatorSaveItem.Image")));
            this.заявкаТърговскиОбектBindingNavigatorSaveItem.Name = "заявкаТърговскиОбектBindingNavigatorSaveItem";
            this.заявкаТърговскиОбектBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.заявкаТърговскиОбектBindingNavigatorSaveItem.Text = "Save Data";
            this.заявкаТърговскиОбектBindingNavigatorSaveItem.Click += new System.EventHandler(this.заявкаТърговскиОбектBindingNavigatorSaveItem_Click);
            // 
            // кодЗаявкаТърговскиОбектLabel
            // 
            кодЗаявкаТърговскиОбектLabel.AutoSize = true;
            кодЗаявкаТърговскиОбектLabel.Location = new System.Drawing.Point(6, 70);
            кодЗаявкаТърговскиОбектLabel.Name = "кодЗаявкаТърговскиОбектLabel";
            кодЗаявкаТърговскиОбектLabel.Size = new System.Drawing.Size(193, 13);
            кодЗаявкаТърговскиОбектLabel.TabIndex = 1;
            кодЗаявкаТърговскиОбектLabel.Text = "Код  на Заявка от Търговски Обект:";
            // 
            // кодЗаявкаТърговскиОбектTextBox
            // 
            this.кодЗаявкаТърговскиОбектTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заявкаТърговскиОбектBindingSource, "КодЗаявкаТърговскиОбект", true));
            this.кодЗаявкаТърговскиОбектTextBox.Location = new System.Drawing.Point(205, 70);
            this.кодЗаявкаТърговскиОбектTextBox.Name = "кодЗаявкаТърговскиОбектTextBox";
            this.кодЗаявкаТърговскиОбектTextBox.Size = new System.Drawing.Size(134, 20);
            this.кодЗаявкаТърговскиОбектTextBox.TabIndex = 2;
            // 
            // кодСпециалистЛогистикаLabel
            // 
            кодСпециалистЛогистикаLabel.AutoSize = true;
            кодСпециалистЛогистикаLabel.Location = new System.Drawing.Point(6, 38);
            кодСпециалистЛогистикаLabel.Name = "кодСпециалистЛогистикаLabel";
            кодСпециалистЛогистикаLabel.Size = new System.Drawing.Size(127, 13);
            кодСпециалистЛогистикаLabel.TabIndex = 7;
            кодСпециалистЛогистикаLabel.Text = "Специалист Логистика:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.заявкаТърговскиОбектBindingSource, "КодСпециалистЛогистика", true));
            this.comboBox1.DataSource = this.търговскиОтделBindingSource;
            this.comboBox1.DisplayMember = "ИмеСпециалистЛогистика";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "КодСпециалистЛогистика";
            // 
            // заявкаТърговскиОбектBindingSource1
            // 
            this.заявкаТърговскиОбектBindingSource1.DataMember = "ЗаявкаТърговскиОбект";
            this.заявкаТърговскиОбектBindingSource1.DataSource = this.златнаПанегаDataSet;
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
            // ЗаявкаТърговскиОбект
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 316);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(кодЗаявкаТърговскиОбектLabel);
            this.Controls.Add(this.кодЗаявкаТърговскиОбектTextBox);
            this.Controls.Add(кодСпециалистЛогистикаLabel);
            this.Controls.Add(this.заявкаТърговскиОбектBindingNavigator);
            this.Name = "ЗаявкаТърговскиОбект";
            this.Text = "Приемане на заявка от ТърговскиОбект";
            this.Load += new System.EventHandler(this.ЗаявкаТърговскиОбект_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаТърговскиОбектBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаТърговскиОбектBindingNavigator)).EndInit();
            this.заявкаТърговскиОбектBindingNavigator.ResumeLayout(false);
            this.заявкаТърговскиОбектBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.заявкаТърговскиОбектBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource заявкаТърговскиОбектBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ЗаявкаТърговскиОбектTableAdapter заявкаТърговскиОбектTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заявкаТърговскиОбектBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заявкаТърговскиОбектBindingNavigatorSaveItem;
        private ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter търговскиОтделTableAdapter;
        private System.Windows.Forms.TextBox кодЗаявкаТърговскиОбектTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource заявкаТърговскиОбектBindingSource1;
        private System.Windows.Forms.BindingSource търговскиОтделBindingSource;
    }
}