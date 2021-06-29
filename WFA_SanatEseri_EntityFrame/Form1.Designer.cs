
namespace WFA_SanatEseri_EntityFrame
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
            if (disposing)
            {
                db.Dispose();
            }

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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSanatci = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mtbYil = new System.Windows.Forms.MaskedTextBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.pboYeniSanatci = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lvwEserler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiSanatcilar = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYeniSanatci)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sanatcısı";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yapıldığı Yılı";
            // 
            // cboSanatci
            // 
            this.cboSanatci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSanatci.FormattingEnabled = true;
            this.cboSanatci.Location = new System.Drawing.Point(16, 162);
            this.cboSanatci.Name = "cboSanatci";
            this.cboSanatci.Size = new System.Drawing.Size(240, 26);
            this.cboSanatci.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAd.Location = new System.Drawing.Point(16, 82);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(240, 24);
            this.txtAd.TabIndex = 2;
            // 
            // mtbYil
            // 
            this.mtbYil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbYil.HidePromptOnLeave = true;
            this.mtbYil.Location = new System.Drawing.Point(16, 249);
            this.mtbYil.Mask = "####";
            this.mtbYil.Name = "mtbYil";
            this.mtbYil.Size = new System.Drawing.Size(240, 24);
            this.mtbYil.TabIndex = 3;
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox1.Controls.Add(this.pboYeniSanatci);
            this.grpBox1.Controls.Add(this.btnEkle);
            this.grpBox1.Controls.Add(this.txtAd);
            this.grpBox1.Controls.Add(this.mtbYil);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.cboSanatci);
            this.grpBox1.Controls.Add(this.label4);
            this.grpBox1.Location = new System.Drawing.Point(12, 33);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(342, 568);
            this.grpBox1.TabIndex = 4;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Sanat Eseri";
            // 
            // pboYeniSanatci
            // 
            this.pboYeniSanatci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboYeniSanatci.Image = global::WFA_SanatEseri_EntityFrame.Properties.Resources.plus;
            this.pboYeniSanatci.Location = new System.Drawing.Point(262, 163);
            this.pboYeniSanatci.Name = "pboYeniSanatci";
            this.pboYeniSanatci.Size = new System.Drawing.Size(34, 26);
            this.pboYeniSanatci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboYeniSanatci.TabIndex = 5;
            this.pboYeniSanatci.TabStop = false;
            this.pboYeniSanatci.Click += new System.EventHandler(this.pboYeniSanatci_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(163, 306);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 43);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // lvwEserler
            // 
            this.lvwEserler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwEserler.HideSelection = false;
            this.lvwEserler.Location = new System.Drawing.Point(360, 35);
            this.lvwEserler.Name = "lvwEserler";
            this.lvwEserler.Size = new System.Drawing.Size(524, 566);
            this.lvwEserler.TabIndex = 5;
            this.lvwEserler.UseCompatibleStateImageBehavior = false;
            this.lvwEserler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sanatçı";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yıl";
            this.columnHeader3.Width = 156;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSanatcilar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "Sanatcılar";
            // 
            // TsmiSanatcilar
            // 
            this.TsmiSanatcilar.Name = "TsmiSanatcilar";
            this.TsmiSanatcilar.Size = new System.Drawing.Size(88, 24);
            this.TsmiSanatcilar.Text = "Sanatcılar";
            this.TsmiSanatcilar.Click += new System.EventHandler(this.TsmiSanatcilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 613);
            this.Controls.Add(this.lvwEserler);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboYeniSanatci)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSanatci;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mtbYil;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lvwEserler;
        private System.Windows.Forms.PictureBox pboYeniSanatci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiSanatcilar;
    }
}

