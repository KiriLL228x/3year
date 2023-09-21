namespace RJD
{
    partial class RoomForm
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
            this.InfoRoomPanel = new System.Windows.Forms.Panel();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InfoRoomPanel.SuspendLayout();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoRoomPanel
            // 
            this.InfoRoomPanel.Controls.Add(this.RoomTextBox);
            this.InfoRoomPanel.Controls.Add(this.RoomLabel);
            this.InfoRoomPanel.Controls.Add(this.RoomPictureBox);
            this.InfoRoomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoRoomPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoRoomPanel.Name = "InfoRoomPanel";
            this.InfoRoomPanel.Size = new System.Drawing.Size(800, 237);
            this.InfoRoomPanel.TabIndex = 0;
            this.InfoRoomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoRoomPanel_Paint);
            // 
            // RoomPanel
            // 
            this.RoomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RoomPanel.Controls.Add(this.label2);
            this.RoomPanel.Controls.Add(this.label1);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RoomPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomPanel.Location = new System.Drawing.Point(0, 243);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(800, 207);
            this.RoomPanel.TabIndex = 1;
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.Location = new System.Drawing.Point(15, 18);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(332, 198);
            this.RoomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RoomPictureBox.TabIndex = 0;
            this.RoomPictureBox.TabStop = false;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(371, 18);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(50, 20);
            this.RoomLabel.TabIndex = 1;
            this.RoomLabel.Text = "label1";
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Location = new System.Drawing.Point(360, 50);
            this.RoomTextBox.Multiline = true;
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(374, 167);
            this.RoomTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoomPanel);
            this.Controls.Add(this.InfoRoomPanel);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.InfoRoomPanel.ResumeLayout(false);
            this.InfoRoomPanel.PerformLayout();
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel InfoRoomPanel;
        private TextBox RoomTextBox;
        private Label RoomLabel;
        private PictureBox RoomPictureBox;
        private Panel RoomPanel;
        private Label label1;
        private Label label2;
    }
}