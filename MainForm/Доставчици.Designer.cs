namespace MainForm
{
    partial class Доставчици
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Доставчици));
            System.Windows.Forms.Label кодДоставчикLabel;
            System.Windows.Forms.Label булстатLabel;
            System.Windows.Forms.Label имеLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label градLabel;
            System.Windows.Forms.Label управителLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label телефонLabel;
            this.златнаПанегаDataSet = new MainForm.ЗлатнаПанегаDataSet();
            this.доставчикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доставчикTableAdapter = new MainForm.ЗлатнаПанегаDataSetTableAdapters.ДоставчикTableAdapter();
            this.tableAdapterManager = new MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager();
            this.доставчикBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.доставчикBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кодДоставчикTextBox = new System.Windows.Forms.TextBox();
            this.булстатTextBox = new System.Windows.Forms.TextBox();
            this.имеTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.градTextBox = new System.Windows.Forms.TextBox();
            this.управителTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.доставчикDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодДоставчикLabel = new System.Windows.Forms.Label();
            булстатLabel = new System.Windows.Forms.Label();
            имеLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            градLabel = new System.Windows.Forms.Label();
            управителLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingNavigator)).BeginInit();
            this.доставчикBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // златнаПанегаDataSet
            // 
            this.златнаПанегаDataSet.DataSetName = "ЗлатнаПанегаDataSet";
            this.златнаПанегаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MainForm.ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АртикулиTableAdapter = null;
            this.tableAdapterManager.ГрупиTableAdapter = null;
            this.tableAdapterManager.ДетайлиЗаявкиTableAdapter = null;
            this.tableAdapterManager.ДоставкиTableAdapter = null;
            this.tableAdapterManager.ДоставчикTableAdapter = this.доставчикTableAdapter;
            this.tableAdapterManager.ЗаявкаТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ЗаявкиTableAdapter = null;
            this.tableAdapterManager.МОЛTableAdapter = null;
            this.tableAdapterManager.ПодгрупиTableAdapter = null;
            this.tableAdapterManager.ТърговскиОбектTableAdapter = null;
            this.tableAdapterManager.ТърговскиОтделTableAdapter = null;
            // 
            // доставчикBindingNavigator
            // 
            this.доставчикBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.доставчикBindingNavigator.BindingSource = this.доставчикBindingSource;
            this.доставчикBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.доставчикBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.доставчикBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.доставчикBindingNavigatorSaveItem});
            this.доставчикBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.доставчикBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.доставчикBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.доставчикBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.доставчикBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.доставчикBindingNavigator.Name = "доставчикBindingNavigator";
            this.доставчикBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.доставчикBindingNavigator.Size = new System.Drawing.Size(850, 25);
            this.доставчикBindingNavigator.TabIndex = 0;
            this.доставчикBindingNavigator.Text = "bindingNavigator1";
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
            // доставчикBindingNavigatorSaveItem
            // 
            this.доставчикBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.доставчикBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("доставчикBindingNavigatorSaveItem.Image")));
            this.доставчикBindingNavigatorSaveItem.Name = "доставчикBindingNavigatorSaveItem";
            this.доставчикBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.доставчикBindingNavigatorSaveItem.Text = "Save Data";
            this.доставчикBindingNavigatorSaveItem.Click += new System.EventHandler(this.доставчикBindingNavigatorSaveItem_Click);
            // 
            // кодДоставчикLabel
            // 
            кодДоставчикLabel.AutoSize = true;
            кодДоставчикLabel.Location = new System.Drawing.Point(12, 35);
            кодДоставчикLabel.Name = "кодДоставчикLabel";
            кодДоставчикLabel.Size = new System.Drawing.Size(87, 13);
            кодДоставчикLabel.TabIndex = 1;
            кодДоставчикLabel.Text = "Код Доставчик:";
            // 
            // кодДоставчикTextBox
            // 
            this.кодДоставчикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "КодДоставчик", true));
            this.кодДоставчикTextBox.Location = new System.Drawing.Point(105, 32);
            this.кодДоставчикTextBox.Name = "кодДоставчикTextBox";
            this.кодДоставчикTextBox.Size = new System.Drawing.Size(129, 20);
            this.кодДоставчикTextBox.TabIndex = 2;
            // 
            // булстатLabel
            // 
            булстатLabel.AutoSize = true;
            булстатLabel.Location = new System.Drawing.Point(12, 61);
            булстатLabel.Name = "булстатLabel";
            булстатLabel.Size = new System.Drawing.Size(50, 13);
            булстатLabel.TabIndex = 3;
            булстатLabel.Text = "Булстат:";
            // 
            // булстатTextBox
            // 
            this.булстатTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Булстат", true));
            this.булстатTextBox.Location = new System.Drawing.Point(105, 58);
            this.булстатTextBox.Name = "булстатTextBox";
            this.булстатTextBox.Size = new System.Drawing.Size(129, 20);
            this.булстатTextBox.TabIndex = 4;
            // 
            // имеLabel
            // 
            имеLabel.AutoSize = true;
            имеLabel.Location = new System.Drawing.Point(12, 87);
            имеLabel.Name = "имеLabel";
            имеLabel.Size = new System.Drawing.Size(32, 13);
            имеLabel.TabIndex = 5;
            имеLabel.Text = "Име:";
            // 
            // имеTextBox
            // 
            this.имеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Име", true));
            this.имеTextBox.Location = new System.Drawing.Point(105, 84);
            this.имеTextBox.Name = "имеTextBox";
            this.имеTextBox.Size = new System.Drawing.Size(129, 20);
            this.имеTextBox.TabIndex = 6;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(12, 113);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 7;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(105, 110);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(129, 20);
            this.адресTextBox.TabIndex = 8;
            // 
            // градLabel
            // 
            градLabel.AutoSize = true;
            градLabel.Location = new System.Drawing.Point(12, 139);
            градLabel.Name = "градLabel";
            градLabel.Size = new System.Drawing.Size(34, 13);
            градLabel.TabIndex = 9;
            градLabel.Text = "Град:";
            // 
            // градTextBox
            // 
            this.градTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Град", true));
            this.градTextBox.Location = new System.Drawing.Point(105, 136);
            this.градTextBox.Name = "градTextBox";
            this.градTextBox.Size = new System.Drawing.Size(129, 20);
            this.градTextBox.TabIndex = 10;
            // 
            // управителLabel
            // 
            управителLabel.AutoSize = true;
            управителLabel.Location = new System.Drawing.Point(12, 165);
            управителLabel.Name = "управителLabel";
            управителLabel.Size = new System.Drawing.Size(65, 13);
            управителLabel.TabIndex = 11;
            управителLabel.Text = "Управител:";
            // 
            // управителTextBox
            // 
            this.управителTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Управител", true));
            this.управителTextBox.Location = new System.Drawing.Point(105, 162);
            this.управителTextBox.Name = "управителTextBox";
            this.управителTextBox.Size = new System.Drawing.Size(129, 20);
            this.управителTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 191);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(105, 188);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(129, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(12, 217);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 15;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.доставчикBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(105, 214);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(129, 20);
            this.телефонTextBox.TabIndex = 16;
            // 
            // доставчикDataGridView
            // 
            this.доставчикDataGridView.AllowUserToAddRows = false;
            this.доставчикDataGridView.AutoGenerateColumns = false;
            this.доставчикDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.доставчикDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.доставчикDataGridView.DataSource = this.доставчикBindingSource;
            this.доставчикDataGridView.Location = new System.Drawing.Point(0, 247);
            this.доставчикDataGridView.Name = "доставчикDataGridView";
            this.доставчикDataGridView.Size = new System.Drawing.Size(838, 220);
            this.доставчикDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодДоставчик";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодДоставчик";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Булстат";
            this.dataGridViewTextBoxColumn2.HeaderText = "Булстат";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Име";
            this.dataGridViewTextBoxColumn3.HeaderText = "Име";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Град";
            this.dataGridViewTextBoxColumn5.HeaderText = "Град";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Управител";
            this.dataGridViewTextBoxColumn6.HeaderText = "Управител";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn8.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Доставчици
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 479);
            this.Controls.Add(this.доставчикDataGridView);
            this.Controls.Add(кодДоставчикLabel);
            this.Controls.Add(this.кодДоставчикTextBox);
            this.Controls.Add(булстатLabel);
            this.Controls.Add(this.булстатTextBox);
            this.Controls.Add(имеLabel);
            this.Controls.Add(this.имеTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(градLabel);
            this.Controls.Add(this.градTextBox);
            this.Controls.Add(управителLabel);
            this.Controls.Add(this.управителTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(this.доставчикBindingNavigator);
            this.Name = "Доставчици";
            this.Text = "Добавяне на доставчик";
            this.Load += new System.EventHandler(this.Доставчици_Load);
            ((System.ComponentModel.ISupportInitialize)(this.златнаПанегаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикBindingNavigator)).EndInit();
            this.доставчикBindingNavigator.ResumeLayout(false);
            this.доставчикBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.доставчикDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЗлатнаПанегаDataSet златнаПанегаDataSet;
        private System.Windows.Forms.BindingSource доставчикBindingSource;
        private ЗлатнаПанегаDataSetTableAdapters.ДоставчикTableAdapter доставчикTableAdapter;
        private ЗлатнаПанегаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator доставчикBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton доставчикBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кодДоставчикTextBox;
        private System.Windows.Forms.TextBox булстатTextBox;
        private System.Windows.Forms.TextBox имеTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox градTextBox;
        private System.Windows.Forms.TextBox управителTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DataGridView доставчикDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}