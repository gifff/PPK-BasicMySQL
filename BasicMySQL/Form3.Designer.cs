namespace BasicMySQL
{
    partial class Form3
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.lvPeminjaman = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIdBuku = new System.Windows.Forms.TextBox();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.label_judul = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(10, 129);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 20);
            this.button_add.TabIndex = 28;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(101, 129);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 20);
            this.button_delete.TabIndex = 27;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(471, 129);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(87, 20);
            this.button_refresh.TabIndex = 26;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // lvPeminjaman
            // 
            this.lvPeminjaman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPeminjaman.Location = new System.Drawing.Point(220, 11);
            this.lvPeminjaman.Margin = new System.Windows.Forms.Padding(2);
            this.lvPeminjaman.Name = "lvPeminjaman";
            this.lvPeminjaman.Size = new System.Drawing.Size(338, 106);
            this.lvPeminjaman.TabIndex = 25;
            this.lvPeminjaman.UseCompatibleStateImageBehavior = false;
            this.lvPeminjaman.View = System.Windows.Forms.View.Details;
            this.lvPeminjaman.SelectedIndexChanged += new System.EventHandler(this.lvPeminjaman_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NIM";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nama";
            this.columnHeader2.Width = 118;
            // 
            // txtIdBuku
            // 
            this.txtIdBuku.Location = new System.Drawing.Point(94, 38);
            this.txtIdBuku.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdBuku.Name = "txtIdBuku";
            this.txtIdBuku.Size = new System.Drawing.Size(94, 20);
            this.txtIdBuku.TabIndex = 24;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(94, 11);
            this.txtNim.Margin = new System.Windows.Forms.Padding(2);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(94, 20);
            this.txtNim.TabIndex = 23;
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(8, 38);
            this.label_judul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(46, 13);
            this.label_judul.TabIndex = 22;
            this.label_judul.Text = "ID Buku";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(8, 11);
            this.label_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(27, 13);
            this.label_id.TabIndex = 21;
            this.label_id.Text = "NIM";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID Buku";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Judul Buku";
            this.columnHeader4.Width = 89;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 173);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.lvPeminjaman);
            this.Controls.Add(this.txtIdBuku);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.label_id);
            this.Name = "Form3";
            this.Text = "Daftar Peminjaman";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListView lvPeminjaman;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtIdBuku;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}