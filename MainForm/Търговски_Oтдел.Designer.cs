namespace MainForm
{
    partial class Търговски_Oтдел
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Търговски_Oтдел));
            System.Windows.Forms.Label кодСпециалистЛогистикаLabel;
            System.Windows.Forms.Label имеСпециалистЛогистикаLabel;
            System.Windows.Forms.Label телефонLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.търговскиОтделBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.търговскиОтделTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.търговскиОтделBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.търговскиОтделBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодСпециалистЛогистикаTextBox = new System.Windows.Forms.TextBox();
            this.имеСпециалистЛогистикаTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.търговскиОтделDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодСпециалистЛогистикаLabel = new System.Windows.Forms.Label();
            имеСпециалистЛогистикаLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingNavigator)).BeginInit();
            this.търговскиОтделBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = this.търговскиОтделTableAdapter;
            // 
            // търговскиОтделBindingNavigator
            // 
            this.търговскиОтделBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.търговскиОтделBindingNavigator.BindingSource = this.търговскиОтделBindingSource;
            this.търговскиОтделBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.търговскиОтделBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.търговскиОтделBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.търговскиОтделBindingNavigatorSaveItem});
            this.търговскиОтделBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.търговскиОтделBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.търговскиОтделBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.търговскиОтделBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.търговскиОтделBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.търговскиОтделBindingNavigator.Name = "търговскиОтделBindingNavigator";
            this.търговскиОтделBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.търговскиОтделBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.търговскиОтделBindingNavigator.TabIndex = 0;
            this.търговскиОтделBindingNavigator.Text = "bindingNavigator1";
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
            // търговскиОтделBindingNavigatorSaveItem
            // 
            this.търговскиОтделBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.търговскиОтделBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("търговскиОтделBindingNavigatorSaveItem.Image")));
            this.търговскиОтделBindingNavigatorSaveItem.Name = "търговскиОтделBindingNavigatorSaveItem";
            this.търговскиОтделBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.търговскиОтделBindingNavigatorSaveItem.Text = "Save Data";
            this.търговскиОтделBindingNavigatorSaveItem.Click += new System.EventHandler(this.търговскиОтделBindingNavigatorSaveItem_Click);
            // 
            // кодСпециалистЛогистикаLabel
            // 
            кодСпециалистЛогистикаLabel.AutoSize = true;
            кодСпециалистЛогистикаLabel.Location = new System.Drawing.Point(12, 38);
            кодСпециалистЛогистикаLabel.Name = "кодСпециалистЛогистикаLabel";
            кодСпециалистЛогистикаLabel.Size = new System.Drawing.Size(164, 13);
            кодСпециалистЛогистикаLabel.TabIndex = 1;
            кодСпециалистЛогистикаLabel.Text = "Код на Специалист Логистика:";
            // 
            // кодСпециалистЛогистикаTextBox
            // 
            this.кодСпециалистЛогистикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.търговскиОтделBindingSource, "КодСпециалистЛогистика", true));
            this.кодСпециалистЛогистикаTextBox.Location = new System.Drawing.Point(182, 35);
            this.кодСпециалистЛогистикаTextBox.Name = "кодСпециалистЛогистикаTextBox";
            this.кодСпециалистЛогистикаTextBox.Size = new System.Drawing.Size(218, 20);
            this.кодСпециалистЛогистикаTextBox.TabIndex = 2;
            // 
            // имеСпециалистЛогистикаLabel
            // 
            имеСпециалистЛогистикаLabel.AutoSize = true;
            имеСпециалистЛогистикаLabel.Location = new System.Drawing.Point(12, 64);
            имеСпециалистЛогистикаLabel.Name = "имеСпециалистЛогистикаLabel";
            имеСпециалистЛогистикаLabel.Size = new System.Drawing.Size(167, 13);
            имеСпециалистЛогистикаLabel.TabIndex = 3;
            имеСпециалистЛогистикаLabel.Text = "Име на Специалист Логистика:";
            // 
            // имеСпециалистЛогистикаTextBox
            // 
            this.имеСпециалистЛогистикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.търговскиОтделBindingSource, "ИмеСпециалистЛогистика", true));
            this.имеСпециалистЛогистикаTextBox.Location = new System.Drawing.Point(182, 61);
            this.имеСпециалистЛогистикаTextBox.Name = "имеСпециалистЛогистикаTextBox";
            this.имеСпециалистЛогистикаTextBox.Size = new System.Drawing.Size(218, 20);
            this.имеСпециалистЛогистикаTextBox.TabIndex = 4;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 90);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.търговскиОтделBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(182, 87);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(218, 20);
            this.телефонTextBox.TabIndex = 6;
            // 
            // търговскиОтделDataGridView
            // 
            this.търговскиОтделDataGridView.AllowUserToAddRows = false;
            this.търговскиОтделDataGridView.AllowUserToOrderColumns = true;
            this.търговскиОтделDataGridView.AutoGenerateColumns = false;
            this.търговскиОтделDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.търговскиОтделDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.търговскиОтделDataGridView.DataSource = this.търговскиОтделBindingSource;
            this.търговскиОтделDataGridView.Location = new System.Drawing.Point(12, 126);
            this.търговскиОтделDataGridView.Name = "търговскиОтделDataGridView";
            this.търговскиОтделDataGridView.Size = new System.Drawing.Size(546, 220);
            this.търговскиОтделDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодСпециалистЛогистика";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код на Специалист Логистика";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИмеСпециалистЛогистика";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име на СпециалистЛогистика";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Търговски_Oтдел
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 350);
            this.Controls.Add(this.търговскиОтделDataGridView);
            this.Controls.Add(кодСпециалистЛогистикаLabel);
            this.Controls.Add(this.кодСпециалистЛогистикаTextBox);
            this.Controls.Add(имеСпециалистЛогистикаLabel);
            this.Controls.Add(this.имеСпециалистЛогистикаTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.търговскиОтделBindingNavigator);
            this.Name = "Търговски_Oтдел";
            this.Text = "Специалисти Логистика от Търговски отдел";
            this.Load += new System.EventHandler(this.Търговски_Oтдел_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделBindingNavigator)).EndInit();
            this.търговскиОтделBindingNavigator.ResumeLayout(false);
            this.търговскиОтделBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.търговскиОтделDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource търговскиОтделBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ТърговскиОтделTableAdapter търговскиОтделTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator търговскиОтделBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton търговскиОтделBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодСпециалистЛогистикаTextBox;
        private System.Windows.Forms.TextBox имеСпециалистЛогистикаTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DataGridView търговскиОтделDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}