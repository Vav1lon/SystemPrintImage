using System.Data;
namespace SPImg
{
    partial class fMain
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
            System.Windows.Forms.ColumnHeader formPage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tbPages = new System.Windows.Forms.TabControl();
            this.tbPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bAddToList = new System.Windows.Forms.ToolStripButton();
            this.bFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.filterMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.forArchiveProgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SPimg.DataSet1();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ctMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChekTree = new System.Windows.Forms.ToolStripMenuItem();
            this.notChekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delItemLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.editSettingPrinters = new System.Windows.Forms.ToolStripButton();
            this.tPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cleaList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyImagesToDestinationForlder = new System.Windows.Forms.ToolStripButton();
            this.tbPage4 = new System.Windows.Forms.TabPage();
            this.NotFindList = new System.Windows.Forms.ListBox();
            this.forArchiveProgsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbText = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.forArchiveProgsTableAdapter = new SPimg.DataSet1TableAdapters.forArchiveProgsTableAdapter();
            formPage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPages.SuspendLayout();
            this.tbPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forArchiveProgsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.ctMenu.SuspendLayout();
            this.tbPage2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tbPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forArchiveProgsBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formPage
            // 
            formPage.Text = "Формат листа";
            formPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            formPage.Width = 100;
            // 
            // tbPages
            // 
            this.tbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPages.Controls.Add(this.tbPage1);
            this.tbPages.Controls.Add(this.tbPage2);
            this.tbPages.Controls.Add(this.tbPage4);
            this.tbPages.Location = new System.Drawing.Point(0, 12);
            this.tbPages.Name = "tbPages";
            this.tbPages.SelectedIndex = 0;
            this.tbPages.Size = new System.Drawing.Size(859, 540);
            this.tbPages.TabIndex = 0;
            // 
            // tbPage1
            // 
            this.tbPage1.Controls.Add(this.toolStrip1);
            this.tbPage1.Controls.Add(this.splitContainer1);
            this.tbPage1.Location = new System.Drawing.Point(4, 22);
            this.tbPage1.Name = "tbPage1";
            this.tbPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage1.Size = new System.Drawing.Size(851, 514);
            this.tbPage1.TabIndex = 0;
            this.tbPage1.Text = "Разузловка изделий из списка";
            this.tbPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAddToList,
            this.bFind,
            this.toolStripSeparator1,
            this.filterMenu});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bAddToList
            // 
            this.bAddToList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bAddToList.Image = ((System.Drawing.Image)(resources.GetObject("bAddToList.Image")));
            this.bAddToList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bAddToList.Name = "bAddToList";
            this.bAddToList.Size = new System.Drawing.Size(98, 22);
            this.bAddToList.Text = "Добавить запись";
            this.bAddToList.Click += new System.EventHandler(this.bAddToList_Click);
            // 
            // bFind
            // 
            this.bFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bFind.Image = ((System.Drawing.Image)(resources.GetObject("bFind.Image")));
            this.bFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(100, 22);
            this.bFind.Text = "Поиск на сервере";
            this.bFind.Click += new System.EventHandler(this.bFind_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // filterMenu
            // 
            this.filterMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterMenu.Image = ((System.Drawing.Image)(resources.GetObject("filterMenu.Image")));
            this.filterMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filterMenu.Name = "filterMenu";
            this.filterMenu.Size = new System.Drawing.Size(58, 22);
            this.filterMenu.Text = "Фильтр";
            this.filterMenu.Click += new System.EventHandler(this.filterMenu_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(837, 480);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.forArchiveProgsBindingSource;
            this.listBox1.DisplayMember = "DESIGNATIO";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 480);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "ART_ID";
            // 
            // forArchiveProgsBindingSource
            // 
            this.forArchiveProgsBindingSource.DataMember = "forArchiveProgs";
            this.forArchiveProgsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ContextMenuStrip = this.ctMenu;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(554, 480);
            this.treeView1.TabIndex = 0;
            // 
            // ctMenu
            // 
            this.ctMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChekTree,
            this.notChekToolStripMenuItem,
            this.delItemLineToolStripMenuItem});
            this.ctMenu.Name = "ctMenu";
            this.ctMenu.Size = new System.Drawing.Size(236, 70);
            // 
            // ChekTree
            // 
            this.ChekTree.Name = "ChekTree";
            this.ChekTree.Size = new System.Drawing.Size(235, 22);
            this.ChekTree.Text = "Пометить все дерево";
            this.ChekTree.Click += new System.EventHandler(this.ChekTree_Click);
            // 
            // notChekToolStripMenuItem
            // 
            this.notChekToolStripMenuItem.Name = "notChekToolStripMenuItem";
            this.notChekToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.notChekToolStripMenuItem.Text = "Снять отметки со всего дерева";
            this.notChekToolStripMenuItem.Click += new System.EventHandler(this.notChekToolStripMenuItem_Click);
            // 
            // delItemLineToolStripMenuItem
            // 
            this.delItemLineToolStripMenuItem.Name = "delItemLineToolStripMenuItem";
            this.delItemLineToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.delItemLineToolStripMenuItem.Text = "Удалить ветку";
            this.delItemLineToolStripMenuItem.Click += new System.EventHandler(this.delItemLineToolStripMenuItem_Click);
            // 
            // tbPage2
            // 
            this.tbPage2.Controls.Add(this.listView1);
            this.tbPage2.Controls.Add(this.toolStrip3);
            this.tbPage2.Location = new System.Drawing.Point(4, 22);
            this.tbPage2.Name = "tbPage2";
            this.tbPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage2.Size = new System.Drawing.Size(851, 514);
            this.tbPage2.TabIndex = 1;
            this.tbPage2.Text = "Результат поиска чертежей";
            this.tbPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.picture,
            formPage});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(845, 483);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // picture
            // 
            this.picture.Text = "Чертеж";
            this.picture.Width = 653;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSettingPrinters,
            this.tPrint,
            this.toolStripSeparator6,
            this.cleaList,
            this.toolStripSeparator2,
            this.CopyImagesToDestinationForlder});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(845, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // editSettingPrinters
            // 
            this.editSettingPrinters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editSettingPrinters.Image = ((System.Drawing.Image)(resources.GetObject("editSettingPrinters.Image")));
            this.editSettingPrinters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSettingPrinters.Name = "editSettingPrinters";
            this.editSettingPrinters.Size = new System.Drawing.Size(116, 22);
            this.editSettingPrinters.Text = "Настройки принтера";
            this.editSettingPrinters.Click += new System.EventHandler(this.editSettingPrinters_Click);
            // 
            // tPrint
            // 
            this.tPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tPrint.Image = ((System.Drawing.Image)(resources.GetObject("tPrint.Image")));
            this.tPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tPrint.Name = "tPrint";
            this.tPrint.Size = new System.Drawing.Size(48, 22);
            this.tPrint.Text = "Печать";
            this.tPrint.Click += new System.EventHandler(this.tPrint_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cleaList
            // 
            this.cleaList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cleaList.Image = ((System.Drawing.Image)(resources.GetObject("cleaList.Image")));
            this.cleaList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cleaList.Name = "cleaList";
            this.cleaList.Size = new System.Drawing.Size(103, 22);
            this.cleaList.Text = "Отчистить список";
            this.cleaList.Click += new System.EventHandler(this.cleaList_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // CopyImagesToDestinationForlder
            // 
            this.CopyImagesToDestinationForlder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CopyImagesToDestinationForlder.Image = ((System.Drawing.Image)(resources.GetObject("CopyImagesToDestinationForlder.Image")));
            this.CopyImagesToDestinationForlder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyImagesToDestinationForlder.Name = "CopyImagesToDestinationForlder";
            this.CopyImagesToDestinationForlder.Size = new System.Drawing.Size(109, 22);
            this.CopyImagesToDestinationForlder.Text = "Копировать файлы";
            this.CopyImagesToDestinationForlder.Click += new System.EventHandler(this.CopyImagesToDestinationForlder_Click);
            // 
            // tbPage4
            // 
            this.tbPage4.Controls.Add(this.NotFindList);
            this.tbPage4.Location = new System.Drawing.Point(4, 22);
            this.tbPage4.Name = "tbPage4";
            this.tbPage4.Size = new System.Drawing.Size(851, 514);
            this.tbPage4.TabIndex = 3;
            this.tbPage4.Text = "Не найденные чертежи";
            this.tbPage4.UseVisualStyleBackColor = true;
            // 
            // NotFindList
            // 
            this.NotFindList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotFindList.FormattingEnabled = true;
            this.NotFindList.Location = new System.Drawing.Point(0, 0);
            this.NotFindList.Name = "NotFindList";
            this.NotFindList.Size = new System.Drawing.Size(851, 514);
            this.NotFindList.TabIndex = 0;
            // 
            // forArchiveProgsBindingSource1
            // 
            this.forArchiveProgsBindingSource1.DataMember = "forArchiveProgs";
            this.forArchiveProgsBindingSource1.DataSource = this.dataSet1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbText,
            this.sbProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbText
            // 
            this.sbText.AutoSize = false;
            this.sbText.Name = "sbText";
            this.sbText.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.sbText.Size = new System.Drawing.Size(250, 17);
            this.sbText.Text = "Разузловка еще не проводилась";
            // 
            // sbProgressBar
            // 
            this.sbProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sbProgressBar.Name = "sbProgressBar";
            this.sbProgressBar.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.sbProgressBar.Size = new System.Drawing.Size(500, 16);
            // 
            // forArchiveProgsTableAdapter
            // 
            this.forArchiveProgsTableAdapter.ClearBeforeFill = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 564);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbPages);
            this.Name = "fMain";
            this.Text = "Посик - печать чертежей \"codeName Cy27\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            this.tbPages.ResumeLayout(false);
            this.tbPage1.ResumeLayout(false);
            this.tbPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forArchiveProgsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ctMenu.ResumeLayout(false);
            this.tbPage2.ResumeLayout(false);
            this.tbPage2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tbPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forArchiveProgsBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbPages;
        private System.Windows.Forms.TabPage tbPage1;
        private System.Windows.Forms.TabPage tbPage2;
        private SPimg.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource forArchiveProgsBindingSource;
        private SPimg.DataSet1TableAdapters.forArchiveProgsTableAdapter forArchiveProgsTableAdapter;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbText;
        private System.Windows.Forms.ToolStripProgressBar sbProgressBar;
        private System.Windows.Forms.ContextMenuStrip ctMenu;
        private System.Windows.Forms.ToolStripMenuItem ChekTree;
        private System.Windows.Forms.ToolStripMenuItem notChekToolStripMenuItem;
        private System.Windows.Forms.BindingSource forArchiveProgsBindingSource1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bAddToList;
        private System.Windows.Forms.ToolStripButton bFind;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton filterMenu;
        private System.Windows.Forms.ToolStripMenuItem delItemLineToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cleaList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader picture;
        private System.Windows.Forms.ToolStripButton editSettingPrinters;
        private System.Windows.Forms.TabPage tbPage4;
        private System.Windows.Forms.ListBox NotFindList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CopyImagesToDestinationForlder;
   }
}

