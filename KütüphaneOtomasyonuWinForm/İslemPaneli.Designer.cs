﻿namespace KütüphaneOtomasyonuWinForm
{
    partial class İslemPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İslemPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.silKullanicibtn = new System.Windows.Forms.Button();
            this.guncelleKullanicibtn = new System.Windows.Forms.Button();
            this.ekleKullanicibtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.silKullanicibtn);
            this.panel1.Controls.Add(this.guncelleKullanicibtn);
            this.panel1.Controls.Add(this.ekleKullanicibtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 735);
            this.panel1.TabIndex = 0;
            // 
            // silKullanicibtn
            // 
            this.silKullanicibtn.BackColor = System.Drawing.Color.SeaGreen;
            this.silKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.silKullanicibtn.FlatAppearance.BorderSize = 0;
            this.silKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silKullanicibtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("silKullanicibtn.Image")));
            this.silKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.silKullanicibtn.Location = new System.Drawing.Point(0, 216);
            this.silKullanicibtn.Name = "silKullanicibtn";
            this.silKullanicibtn.Size = new System.Drawing.Size(268, 72);
            this.silKullanicibtn.TabIndex = 4;
            this.silKullanicibtn.Text = "Sil";
            this.silKullanicibtn.UseVisualStyleBackColor = false;
            // 
            // guncelleKullanicibtn
            // 
            this.guncelleKullanicibtn.BackColor = System.Drawing.Color.SeaGreen;
            this.guncelleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.guncelleKullanicibtn.FlatAppearance.BorderSize = 0;
            this.guncelleKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelleKullanicibtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncelleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("guncelleKullanicibtn.Image")));
            this.guncelleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleKullanicibtn.Location = new System.Drawing.Point(0, 144);
            this.guncelleKullanicibtn.Name = "guncelleKullanicibtn";
            this.guncelleKullanicibtn.Size = new System.Drawing.Size(268, 72);
            this.guncelleKullanicibtn.TabIndex = 3;
            this.guncelleKullanicibtn.Text = "Güncelle";
            this.guncelleKullanicibtn.UseVisualStyleBackColor = false;
            this.guncelleKullanicibtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // ekleKullanicibtn
            // 
            this.ekleKullanicibtn.BackColor = System.Drawing.Color.SeaGreen;
            this.ekleKullanicibtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ekleKullanicibtn.FlatAppearance.BorderSize = 0;
            this.ekleKullanicibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleKullanicibtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekleKullanicibtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleKullanicibtn.Image")));
            this.ekleKullanicibtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleKullanicibtn.Location = new System.Drawing.Point(0, 72);
            this.ekleKullanicibtn.Name = "ekleKullanicibtn";
            this.ekleKullanicibtn.Size = new System.Drawing.Size(268, 72);
            this.ekleKullanicibtn.TabIndex = 2;
            this.ekleKullanicibtn.Text = "Ekle";
            this.ekleKullanicibtn.UseVisualStyleBackColor = false;
            this.ekleKullanicibtn.Click += new System.EventHandler(this.ekleKullanicibtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kullanıcılar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(268, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(1074, 44);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(971, 492);
            this.dataGridView1.TabIndex = 2;
            // 
            // İslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1342, 735);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Name = "İslemPaneli";
            this.Text = "İslemPaneli";
            this.Load += new System.EventHandler(this.İslemPaneli_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
        private System.Windows.Forms.Button ekleKullanicibtn;
        private System.Windows.Forms.Button silKullanicibtn;
        private System.Windows.Forms.Button guncelleKullanicibtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}