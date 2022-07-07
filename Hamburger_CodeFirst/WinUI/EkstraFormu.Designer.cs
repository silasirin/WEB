namespace WinUI
{
    partial class EkstraFormu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.nudEkstraFiyat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtEkstraID = new System.Windows.Forms.TextBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.txtMenuID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMenuID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEkstraID);
            this.groupBox1.Controls.Add(this.txtEkstra);
            this.groupBox1.Controls.Add(this.nudEkstraFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Location = new System.Drawing.Point(17, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 292);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstra Olustur";
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(103, 153);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(156, 22);
            this.txtEkstra.TabIndex = 3;
            // 
            // nudEkstraFiyat
            // 
            this.nudEkstraFiyat.Location = new System.Drawing.Point(103, 206);
            this.nudEkstraFiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEkstraFiyat.Name = "nudEkstraFiyat";
            this.nudEkstraFiyat.Size = new System.Drawing.Size(156, 22);
            this.nudEkstraFiyat.TabIndex = 2;
            this.nudEkstraFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ekstra Adi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ekstra ID:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(22, 251);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(103, 251);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(184, 251);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(340, 71);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(515, 292);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ekstra";
            this.columnHeader3.Width = 81;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ekstra Fiyat";
            this.columnHeader4.Width = 114;
            // 
            // txtEkstraID
            // 
            this.txtEkstraID.Location = new System.Drawing.Point(103, 45);
            this.txtEkstraID.Name = "txtEkstraID";
            this.txtEkstraID.Size = new System.Drawing.Size(156, 22);
            this.txtEkstraID.TabIndex = 3;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(17, 12);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 5;
            this.btnGeriDon.Text = "Geri Don";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // txtMenuID
            // 
            this.txtMenuID.Location = new System.Drawing.Point(103, 102);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.Size = new System.Drawing.Size(156, 22);
            this.txtMenuID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Menu ID:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MenuID";
            // 
            // EkstraFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 403);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView2);
            this.Name = "EkstraFormu";
            this.Text = "EkstraFormu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstraFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.NumericUpDown nudEkstraFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtEkstraID;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.TextBox txtMenuID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}