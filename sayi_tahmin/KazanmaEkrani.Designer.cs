namespace sayi_tahmin
{
    partial class KazanmaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KazanmaEkrani));
            this.btnTekrar = new System.Windows.Forms.Button();
            this.btnAnaSayfaa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTekrar
            // 
            this.btnTekrar.Location = new System.Drawing.Point(12, 371);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(157, 40);
            this.btnTekrar.TabIndex = 0;
            this.btnTekrar.Text = "Tekrar Oyna";
            this.btnTekrar.UseVisualStyleBackColor = true;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            this.btnTekrar.MouseEnter += new System.EventHandler(this.btnTekrar_MouseEnter);
            this.btnTekrar.MouseLeave += new System.EventHandler(this.btnTekrar_MouseLeave);
            // 
            // btnAnaSayfaa
            // 
            this.btnAnaSayfaa.Location = new System.Drawing.Point(576, 371);
            this.btnAnaSayfaa.Name = "btnAnaSayfaa";
            this.btnAnaSayfaa.Size = new System.Drawing.Size(157, 40);
            this.btnAnaSayfaa.TabIndex = 1;
            this.btnAnaSayfaa.Text = "Ana Menü";
            this.btnAnaSayfaa.UseVisualStyleBackColor = true;
            this.btnAnaSayfaa.Click += new System.EventHandler(this.btnAnaSayfaa_Click);
            this.btnAnaSayfaa.MouseEnter += new System.EventHandler(this.btnAnaSayfaa_MouseEnter);
            this.btnAnaSayfaa.MouseLeave += new System.EventHandler(this.btnAnaSayfaa_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 2;
            // 
            // KazanmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnaSayfaa);
            this.Controls.Add(this.btnTekrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KazanmaEkrani";
            this.Text = "KazanmaEkrani";
            this.Load += new System.EventHandler(this.KazanmaEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTekrar;
        private System.Windows.Forms.Button btnAnaSayfaa;
        private System.Windows.Forms.Label label1;
    }
}