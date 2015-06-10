namespace sql
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ksiazkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testowaDataSet = new sql.testowaDataSet();
            this.czytelnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gatunkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorzyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.ksiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.czytelnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorzyTableAdapter = new sql.testowaDataSetTableAdapters.autorzyTableAdapter();
            this.czytelnikTableAdapter = new sql.testowaDataSetTableAdapters.czytelnikTableAdapter();
            this.ksiazkiTableAdapter = new sql.testowaDataSetTableAdapters.ksiazkiTableAdapter();
            this.wypozyczeniaTableAdapter = new sql.testowaDataSetTableAdapters.wypozyczeniaTableAdapter();
            this.gatunkiTableAdapter = new sql.testowaDataSetTableAdapters.gatunkiTableAdapter();
            this.autorzyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testowaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AccessibleName = "button2";
            this.button2.Location = new System.Drawing.Point(478, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 284);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Książki";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Czytelnicy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(462, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wypożyczenia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(462, 258);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gatunki";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(462, 258);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Autorzy";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ksiazkiBindingSource1
            // 
            this.ksiazkiBindingSource1.DataMember = "ksiazki";
            this.ksiazkiBindingSource1.DataSource = this.testowaDataSet;
            // 
            // testowaDataSet
            // 
            this.testowaDataSet.DataSetName = "testowaDataSet";
            this.testowaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // czytelnikBindingSource1
            // 
            this.czytelnikBindingSource1.DataMember = "czytelnik";
            this.czytelnikBindingSource1.DataSource = this.testowaDataSet;
            // 
            // wypozyczeniaBindingSource
            // 
            this.wypozyczeniaBindingSource.DataMember = "wypozyczenia";
            this.wypozyczeniaBindingSource.DataSource = this.testowaDataSet;
            // 
            // gatunkiBindingSource
            // 
            this.gatunkiBindingSource.DataMember = "gatunki";
            this.gatunkiBindingSource.DataSource = this.testowaDataSet;
            // 
            // autorzyBindingSource2
            // 
            this.autorzyBindingSource2.DataMember = "autorzy";
            this.autorzyBindingSource2.DataSource = this.testowaDataSet;
            // 
            // button3
            // 
            this.button3.AccessibleName = "button3";
            this.button3.Location = new System.Drawing.Point(566, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ksiazkiBindingSource
            // 
            this.ksiazkiBindingSource.DataMember = "ksiazki";
            this.ksiazkiBindingSource.DataSource = this.testowaDataSet;
            // 
            // czytelnikBindingSource
            // 
            this.czytelnikBindingSource.DataMember = "czytelnik";
            this.czytelnikBindingSource.DataSource = this.testowaDataSet;
            // 
            // autorzyBindingSource
            // 
            this.autorzyBindingSource.DataMember = "autorzy";
            this.autorzyBindingSource.DataSource = this.testowaDataSet;
            // 
            // autorzyTableAdapter
            // 
            this.autorzyTableAdapter.ClearBeforeFill = true;
            // 
            // czytelnikTableAdapter
            // 
            this.czytelnikTableAdapter.ClearBeforeFill = true;
            // 
            // ksiazkiTableAdapter
            // 
            this.ksiazkiTableAdapter.ClearBeforeFill = true;
            // 
            // wypozyczeniaTableAdapter
            // 
            this.wypozyczeniaTableAdapter.ClearBeforeFill = true;
            // 
            // gatunkiTableAdapter
            // 
            this.gatunkiTableAdapter.ClearBeforeFill = true;
            // 
            // autorzyBindingSource1
            // 
            this.autorzyBindingSource1.DataMember = "autorzy";
            this.autorzyBindingSource1.DataSource = this.testowaDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ustawienia";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 284);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testowaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatunkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.czytelnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorzyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button3;
        private testowaDataSet testowaDataSet;
        private System.Windows.Forms.BindingSource autorzyBindingSource;
        private testowaDataSetTableAdapters.autorzyTableAdapter autorzyTableAdapter;
        private System.Windows.Forms.BindingSource ksiazkiBindingSource;
        private System.Windows.Forms.BindingSource czytelnikBindingSource;
        private testowaDataSetTableAdapters.czytelnikTableAdapter czytelnikTableAdapter;
        private System.Windows.Forms.BindingSource ksiazkiBindingSource1;
        private testowaDataSetTableAdapters.ksiazkiTableAdapter ksiazkiTableAdapter;
        private System.Windows.Forms.BindingSource czytelnikBindingSource1;
        private System.Windows.Forms.BindingSource wypozyczeniaBindingSource;
        private testowaDataSetTableAdapters.wypozyczeniaTableAdapter wypozyczeniaTableAdapter;
        private System.Windows.Forms.BindingSource gatunkiBindingSource;
        private testowaDataSetTableAdapters.gatunkiTableAdapter gatunkiTableAdapter;
        private System.Windows.Forms.BindingSource autorzyBindingSource1;
        private System.Windows.Forms.BindingSource autorzyBindingSource2;
        private System.Windows.Forms.Button button4;
    }
}

