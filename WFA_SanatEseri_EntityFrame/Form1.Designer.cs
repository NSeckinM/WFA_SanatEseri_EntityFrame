
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
            this.cmbSanatci = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mtxtYil = new System.Windows.Forms.MaskedTextBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pboplus = new System.Windows.Forms.PictureBox();
            this.grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboplus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sanatcısı";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yapıldığı Yılı";
            // 
            // cmbSanatci
            // 
            this.cmbSanatci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSanatci.FormattingEnabled = true;
            this.cmbSanatci.Location = new System.Drawing.Point(16, 163);
            this.cmbSanatci.Name = "cmbSanatci";
            this.cmbSanatci.Size = new System.Drawing.Size(240, 26);
            this.cmbSanatci.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAd.Location = new System.Drawing.Point(16, 83);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(240, 24);
            this.txtAd.TabIndex = 2;
            // 
            // mtxtYil
            // 
            this.mtxtYil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtYil.HidePromptOnLeave = true;
            this.mtxtYil.Location = new System.Drawing.Point(16, 250);
            this.mtxtYil.Mask = "####";
            this.mtxtYil.Name = "mtxtYil";
            this.mtxtYil.Size = new System.Drawing.Size(240, 24);
            this.mtxtYil.TabIndex = 3;
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox1.Controls.Add(this.pboplus);
            this.grpBox1.Controls.Add(this.btnEkle);
            this.grpBox1.Controls.Add(this.txtAd);
            this.grpBox1.Controls.Add(this.mtxtYil);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.cmbSanatci);
            this.grpBox1.Controls.Add(this.label4);
            this.grpBox1.Location = new System.Drawing.Point(11, 12);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(342, 569);
            this.grpBox1.TabIndex = 4;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Sanat Eseri";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(163, 307);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 43);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(362, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(524, 558);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // pboplus
            // 
            this.pboplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboplus.Image = global::WFA_SanatEseri_EntityFrame.Properties.Resources.plus;
            this.pboplus.Location = new System.Drawing.Point(262, 163);
            this.pboplus.Name = "pboplus";
            this.pboplus.Size = new System.Drawing.Size(34, 26);
            this.pboplus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboplus.TabIndex = 5;
            this.pboplus.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 613);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.grpBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboplus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSanatci;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mtxtYil;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pboplus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

