namespace BasicMySQL
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_judul = new System.Windows.Forms.Label();
            this.label_pengarang = new System.Windows.Forms.Label();
            this.label_jumlah = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.text_pengarang = new System.Windows.Forms.TextBox();
            this.text_jumlah = new System.Windows.Forms.TextBox();
            this.listBuku = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(51, 64);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(82, 25);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Id buku";
            // 
            // label_judul
            // 
            this.label_judul.AutoSize = true;
            this.label_judul.Location = new System.Drawing.Point(51, 115);
            this.label_judul.Name = "label_judul";
            this.label_judul.Size = new System.Drawing.Size(117, 25);
            this.label_judul.TabIndex = 1;
            this.label_judul.Text = "Judul buku";
            // 
            // label_pengarang
            // 
            this.label_pengarang.AutoSize = true;
            this.label_pengarang.Location = new System.Drawing.Point(51, 175);
            this.label_pengarang.Name = "label_pengarang";
            this.label_pengarang.Size = new System.Drawing.Size(117, 25);
            this.label_pengarang.TabIndex = 2;
            this.label_pengarang.Text = "Pengarang";
            // 
            // label_jumlah
            // 
            this.label_jumlah.AutoSize = true;
            this.label_jumlah.Location = new System.Drawing.Point(51, 233);
            this.label_jumlah.Name = "label_jumlah";
            this.label_jumlah.Size = new System.Drawing.Size(81, 25);
            this.label_jumlah.TabIndex = 3;
            this.label_jumlah.Text = "Jumlah";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(223, 64);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(185, 31);
            this.text_id.TabIndex = 4;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(223, 115);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(185, 31);
            this.text_judul.TabIndex = 5;
            // 
            // text_pengarang
            // 
            this.text_pengarang.Location = new System.Drawing.Point(223, 175);
            this.text_pengarang.Name = "text_pengarang";
            this.text_pengarang.Size = new System.Drawing.Size(185, 31);
            this.text_pengarang.TabIndex = 6;
            // 
            // text_jumlah
            // 
            this.text_jumlah.Location = new System.Drawing.Point(223, 233);
            this.text_jumlah.Name = "text_jumlah";
            this.text_jumlah.Size = new System.Drawing.Size(185, 31);
            this.text_jumlah.TabIndex = 7;
            // 
            // listBuku
            // 
            this.listBuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listBuku.Location = new System.Drawing.Point(475, 64);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(628, 200);
            this.listBuku.TabIndex = 8;
            this.listBuku.UseCompatibleStateImageBehavior = false;
            this.listBuku.View = System.Windows.Forms.View.Details;
            this.listBuku.SelectedIndexChanged += new System.EventHandler(this.listBuku_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judul";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pengarang";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Jumlah";
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(928, 291);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(174, 39);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "Refresh Data";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(475, 291);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(174, 39);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(266, 291);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(174, 39);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(56, 291);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(174, 39);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(678, 291);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(174, 39);
            this.button_search.TabIndex = 13;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 428);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.text_jumlah);
            this.Controls.Add(this.text_pengarang);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label_jumlah);
            this.Controls.Add(this.label_pengarang);
            this.Controls.Add(this.label_judul);
            this.Controls.Add(this.label_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_judul;
        private System.Windows.Forms.Label label_pengarang;
        private System.Windows.Forms.Label label_jumlah;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.TextBox text_pengarang;
        private System.Windows.Forms.TextBox text_jumlah;
        private System.Windows.Forms.ListView listBuku;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_search;
    }
}

