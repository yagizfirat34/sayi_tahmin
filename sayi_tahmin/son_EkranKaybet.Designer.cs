namespace sayi_tahmin
{
    partial class son_EkranKaybet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(son_EkranKaybet));
            this.btnTkr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTkr
            // 
            this.btnTkr.BackColor = System.Drawing.Color.White;
            this.btnTkr.Location = new System.Drawing.Point(3, 379);
            this.btnTkr.Name = "btnTkr";
            this.btnTkr.Size = new System.Drawing.Size(232, 56);
            this.btnTkr.TabIndex = 3;
            this.btnTkr.Text = "Tekrar Oyna";
            this.btnTkr.UseVisualStyleBackColor = false;
            this.btnTkr.Click += new System.EventHandler(this.btnTkr_Click);
            this.btnTkr.MouseEnter += new System.EventHandler(this.btnTkr_MouseEnter);
            this.btnTkr.MouseLeave += new System.EventHandler(this.btnTkr_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 2;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(494, 379);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(232, 56);
            this.btnAnaMenu.TabIndex = 5;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            this.btnAnaMenu.MouseEnter += new System.EventHandler(this.btnAnaMenu_MouseEnter);
            this.btnAnaMenu.MouseLeave += new System.EventHandler(this.btnAnaMenu_MouseLeave);
            // 
            // son_EkranKaybet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 505);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnTkr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "son_EkranKaybet";
            this.Text = "son_EkranKaybet";
            this.Load += new System.EventHandler(this.son_EkranKaybet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTkr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}