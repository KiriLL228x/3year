namespace RJD
{
    partial class PoezdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoezdForm));
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.MestoPanel = new System.Windows.Forms.Panel();
            this.SV = new System.Windows.Forms.PictureBox();
            this.Kupe = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.MestoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Location = new System.Drawing.Point(41, 13);
            this.InfoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(447, 302);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoPictureBox.TabIndex = 0;
            this.InfoPictureBox.TabStop = false;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.InfoPictureBox);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1177, 339);
            this.InfoPanel.TabIndex = 1;
            // 
            // MestoPanel
            // 
            this.MestoPanel.Controls.Add(this.SV);
            this.MestoPanel.Controls.Add(this.Kupe);
            this.MestoPanel.Controls.Add(this.pictureBox1);
            this.MestoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MestoPanel.Location = new System.Drawing.Point(0, 339);
            this.MestoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MestoPanel.Name = "MestoPanel";
            this.MestoPanel.Size = new System.Drawing.Size(1177, 306);
            this.MestoPanel.TabIndex = 2;
            // 
            // SV
            // 
            this.SV.Image = ((System.Drawing.Image)(resources.GetObject("SV.Image")));
            this.SV.Location = new System.Drawing.Point(801, 7);
            this.SV.Name = "SV";
            this.SV.Size = new System.Drawing.Size(346, 240);
            this.SV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SV.TabIndex = 2;
            this.SV.TabStop = false;
            this.SV.Tag = "SV";
            this.SV.Click += new System.EventHandler(this.Room_Click);
            // 
            // Kupe
            // 
            this.Kupe.Image = ((System.Drawing.Image)(resources.GetObject("Kupe.Image")));
            this.Kupe.Location = new System.Drawing.Point(405, 7);
            this.Kupe.Name = "Kupe";
            this.Kupe.Size = new System.Drawing.Size(346, 240);
            this.Kupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kupe.TabIndex = 1;
            this.Kupe.TabStop = false;
            this.Kupe.Tag = "Kupe";
            this.Kupe.Click += new System.EventHandler(this.Room_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Plackart";
            this.pictureBox1.Click += new System.EventHandler(this.Room_Click);
            // 
            // PoezdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 645);
            this.Controls.Add(this.MestoPanel);
            this.Controls.Add(this.InfoPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PoezdForm";
            this.Text = "PoezdForm";
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.MestoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox InfoPictureBox;
        private Panel InfoPanel;
        private Panel MestoPanel;
        private PictureBox SV;
        private PictureBox Kupe;
        private PictureBox pictureBox1;
    }
}