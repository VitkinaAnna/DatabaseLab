namespace Database5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows


        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            tableToolStripMenuItem = new ToolStripMenuItem();
            addTableToolStripMenuItem = new ToolStripMenuItem();
            deleteTableToolStripMenuItem = new ToolStripMenuItem();
            columnToolStripMenuItem = new ToolStripMenuItem();
            addColumnToolStripMenuItem = new ToolStripMenuItem();
            deleteColumnToolStripMenuItem = new ToolStripMenuItem();
            renameColumnToolStripMenuItem = new ToolStripMenuItem();
            rowToolStripMenuItem = new ToolStripMenuItem();
            addRowToolStripMenuItem = new ToolStripMenuItem();
            deleteRowToolStripMenuItem = new ToolStripMenuItem();
            tabControl = new TabControl();
            ofdChooseFilePath = new OpenFileDialog();
            sfdSaveDB = new SaveFileDialog();
            ofdOpenDB = new OpenFileDialog();
            dataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, tableToolStripMenuItem, columnToolStripMenuItem, rowToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(1140, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, saveToolStripMenuItem, openToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(51, 29);
            toolStripMenuItem1.Text = "Операції з базами даних";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "newToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(270, 34);
            createToolStripMenuItem.Text = "Створити нову базу даних";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(270, 34);
            saveToolStripMenuItem.Text = "Зберегти базу даних";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(270, 34);
            openToolStripMenuItem.Text = "Відкрити існуючу базу даних";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // tableToolStripMenuItem
            // 
            tableToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTableToolStripMenuItem, deleteTableToolStripMenuItem });
            tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            tableToolStripMenuItem.Size = new Size(68, 29);
            tableToolStripMenuItem.Text = "Операції з таблицями";
            // 
            // addTableToolStripMenuItem
            // 
            addTableToolStripMenuItem.Name = "addTableToolStripMenuItem";
            addTableToolStripMenuItem.Size = new Size(209, 34);
            addTableToolStripMenuItem.Text = "Додати таблицю";
            addTableToolStripMenuItem.Click += addTableToolStripMenuItem_Click;
            // 
            // deleteTableToolStripMenuItem
            // 
            deleteTableToolStripMenuItem.Name = "deleteTableToolStripMenuItem";
            deleteTableToolStripMenuItem.Size = new Size(209, 34);
            deleteTableToolStripMenuItem.Text = "Видалити таблицю";
            deleteTableToolStripMenuItem.Click += deleteTableToolStripMenuItem_Click;
            // 
            // columnToolStripMenuItem
            // 
            columnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addColumnToolStripMenuItem, deleteColumnToolStripMenuItem, renameColumnToolStripMenuItem });
            columnToolStripMenuItem.Name = "columnToolStripMenuItem";
            columnToolStripMenuItem.Size = new Size(90, 29);
            columnToolStripMenuItem.Text = "Операції з колонками";
            // 
            // addColumnToolStripMenuItem
            // 
            addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            addColumnToolStripMenuItem.Size = new Size(270, 34);
            addColumnToolStripMenuItem.Text = "Додати нову колонку";
            addColumnToolStripMenuItem.Click += addColumnToolStripMenuItem_Click;
            // 
            // deleteColumnToolStripMenuItem
            // 
            deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            deleteColumnToolStripMenuItem.Size = new Size(270, 34);
            deleteColumnToolStripMenuItem.Text = "Видалити колонку";
            deleteColumnToolStripMenuItem.Click += deleteColumnToolStripMenuItem_Click;
            // 
            // renameColumnToolStripMenuItem
            // 
            renameColumnToolStripMenuItem.Name = "renameColumnToolStripMenuItem";
            renameColumnToolStripMenuItem.Size = new Size(270, 34);
            renameColumnToolStripMenuItem.Text = "Перейменувати колонку";
            renameColumnToolStripMenuItem.Click += renameColumnToolStripMenuItem_Click;
            // 
            // rowToolStripMenuItem
            // 
            rowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRowToolStripMenuItem, deleteRowToolStripMenuItem });
            rowToolStripMenuItem.Name = "rowToolStripMenuItem";
            rowToolStripMenuItem.Size = new Size(62, 29);
            rowToolStripMenuItem.Text = "Операції з рядками";
            // 
            // addRowToolStripMenuItem
            // 
            addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            addRowToolStripMenuItem.Size = new Size(203, 34);
            addRowToolStripMenuItem.Text = "Додати рядок";
            addRowToolStripMenuItem.Click += addRowToolStripMenuItem_Click;
            // 
            // deleteRowToolStripMenuItem
            // 
            deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            deleteRowToolStripMenuItem.Size = new Size(203, 34);
            deleteRowToolStripMenuItem.Text = "Видалити рядок";
            deleteRowToolStripMenuItem.Click += deleteRowToolStripMenuItem_Click;
            // 
            // tabControl
            // 
            tabControl.Location = new Point(20, 56);
            tabControl.Margin = new Padding(5, 6, 5, 6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1100, 48);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // ofdChooseFilePath
            // 
            ofdChooseFilePath.FileName = "openFileDialog1";
            // 
            // ofdOpenDB
            // 
            ofdOpenDB.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(20, 116);
            dataGridView.Margin = new Padding(5, 6, 5, 6);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1095, 558);
            dataGridView.TabIndex = 24;
            dataGridView.CellBeginEdit += dataGridView_CellBeginEdit;
            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 729);
            Controls.Add(dataGridView);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Форма";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem tableToolStripMenuItem;
        private ToolStripMenuItem addTableToolStripMenuItem;
        private ToolStripMenuItem deleteTableToolStripMenuItem;
        private ToolStripMenuItem columnToolStripMenuItem;
        private ToolStripMenuItem addColumnToolStripMenuItem;
        private ToolStripMenuItem deleteColumnToolStripMenuItem;
        private ToolStripMenuItem rowToolStripMenuItem;
        private ToolStripMenuItem addRowToolStripMenuItem;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private TabControl tabControl;
        private OpenFileDialog ofdChooseFilePath;
        private SaveFileDialog sfdSaveDB;
        private OpenFileDialog ofdOpenDB;
        private DataGridView dataGridView;
        private ToolStripMenuItem renameColumnToolStripMenuItem;
    }
}