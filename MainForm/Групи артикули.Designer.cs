namespace MainForm
{
    partial class Групи_артикули
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Групи_артикули));
            System.Windows.Forms.Label кодГрупаLabel;
            System.Windows.Forms.Label имеГрупаLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.групиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.групиTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ГрупиTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.групиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.групиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодГрупаTextBox = new System.Windows.Forms.TextBox();
            this.имеГрупаTextBox = new System.Windows.Forms.TextBox();
            this.групиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодГрупаLabel = new System.Windows.Forms.Label();
            имеГрупаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingNavigator)).BeginInit();
            this.групиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.групиDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АртикулиTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = this.групиTableAdapter;
            this.tableAdapterManager.ДетайлиЗаявкиTableAdapter = null;
            this.tableAdapterManager.ДоставкиTableAdapter = null;
            this.tableAdapterManager.ДоставчикTableAdapter = null;
            this.tableAdapterManager.ЗаявкаТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.МОЛTableAdapter = null;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = null;
            // 
            // групиBindingNavigator
            // 
            this.групиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.групиBindingNavigator.BindingSource = this.групиBindingSource;
            this.групиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.групиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.групиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.групиBindingNavigatorSaveItem});
            this.групиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.групиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.групиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.групиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.групиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.групиBindingNavigator.Name = "групиBindingNavigator";
            this.групиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.групиBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.групиBindingNavigator.TabIndex = 0;
            this.групиBindingNavigator.Text = "bindingNavigator1";
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
            // групиBindingNavigatorSaveItem
            // 
            this.групиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.групиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("групиBindingNavigatorSaveItem.Image")));
            this.групиBindingNavigatorSaveItem.Name = "групиBindingNavigatorSaveItem";
            this.групиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.групиBindingNavigatorSaveItem.Text = "Save Data";
            this.групиBindingNavigatorSaveItem.Click += new System.EventHandler(this.групиBindingNavigatorSaveItem_Click);
            // 
            // кодГрупаLabel
            // 
            кодГрупаLabel.AutoSize = true;
            кодГрупаLabel.Location = new System.Drawing.Point(3, 31);
            кодГрупаLabel.Name = "кодГрупаLabel";
            кодГрупаLabel.Size = new System.Drawing.Size(76, 13);
            кодГрупаLabel.TabIndex = 1;
            кодГрупаLabel.Text = "Код на Група:";
            // 
            // кодГрупаTextBox
            // 
            this.кодГрупаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групиBindingSource, "КодГрупа", true));
            this.кодГрупаTextBox.Location = new System.Drawing.Point(85, 28);
            this.кодГрупаTextBox.Name = "кодГрупаTextBox";
            this.кодГрупаTextBox.Size = new System.Drawing.Size(175, 20);
            this.кодГрупаTextBox.TabIndex = 2;
            // 
            // имеГрупаLabel
            // 
            имеГрупаLabel.AutoSize = true;
            имеГрупаLabel.Location = new System.Drawing.Point(3, 57);
            имеГрупаLabel.Name = "имеГрупаLabel";
            имеГрупаLabel.Size = new System.Drawing.Size(79, 13);
            имеГрупаLabel.TabIndex = 3;
            имеГрупаLabel.Text = "Име на Група:";
            // 
            // имеГрупаTextBox
            // 
            this.имеГрупаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.групиBindingSource, "ИмеГрупа", true));
            this.имеГрупаTextBox.Location = new System.Drawing.Point(85, 54);
            this.имеГрупаTextBox.Name = "имеГрупаTextBox";
            this.имеГрупаTextBox.Size = new System.Drawing.Size(175, 20);
            this.имеГрупаTextBox.TabIndex = 4;
            // 
            // групиDataGridView
            // 
            this.групиDataGridView.AllowUserToAddRows = false;
            this.групиDataGridView.AllowUserToOrderColumns = true;
            this.групиDataGridView.AutoGenerateColumns = false;
            this.групиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.групиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.групиDataGridView.DataSource = this.групиBindingSource;
            this.групиDataGridView.Location = new System.Drawing.Point(0, 90);
            this.групиDataGridView.Name = "групиDataGridView";
            this.групиDataGridView.Size = new System.Drawing.Size(333, 220);
            this.групиDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодГрупа";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодГрупа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ИмеГрупа";
            this.dataGridViewTextBoxColumn2.HeaderText = "ИмеГрупа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Групи_артикули
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 369);
            this.Controls.Add(this.групиDataGridView);
            this.Controls.Add(кодГрупаLabel);
            this.Controls.Add(this.кодГрупаTextBox);
            this.Controls.Add(имеГрупаLabel);
            this.Controls.Add(this.имеГрупаTextBox);
            this.Controls.Add(this.групиBindingNavigator);
            this.Name = "Групи_артикули";
            this.Text = "Групи артикули";
            this.Load += new System.EventHandler(this.Групи_артикули_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.групиBindingNavigator)).EndInit();
            this.групиBindingNavigator.ResumeLayout(false);
            this.групиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.групиDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource групиBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ГрупиTableAdapter групиTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator групиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton групиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодГрупаTextBox;
        private System.Windows.Forms.TextBox имеГрупаTextBox;
        private System.Windows.Forms.DataGridView групиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}