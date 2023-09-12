namespace RJD
{
    partial class MainForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            Login = new Label();
            vhod = new Button();
            password = new Label();
            Filter = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(password);
            panel1.Controls.Add(vhod);
            panel1.Controls.Add(Login);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 33);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Filter);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 107);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 304);
            panel3.TabIndex = 2;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(12, 9);
            Login.Name = "Login";
            Login.Size = new Size(41, 15);
            Login.TabIndex = 0;
            Login.Text = "Логин";
            // 
            // vhod
            // 
            vhod.Location = new Point(713, 5);
            vhod.Name = "vhod";
            vhod.Size = new Size(75, 23);
            vhod.TabIndex = 1;
            vhod.Text = "Войти";
            vhod.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(192, 9);
            password.Name = "password";
            password.Size = new Size(50, 15);
            password.TabIndex = 2;
            password.Text = "Пороль";
            // 
            // Filter
            // 
            Filter.Location = new Point(0, 37);
            Filter.Name = "Filter";
            Filter.Size = new Size(128, 36);
            Filter.TabIndex = 0;
            Filter.Text = "Фильтр";
            Filter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 48);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Откуда ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 48);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Куда ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(430, 48);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Туда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(603, 48);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Обратно";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(467, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(664, 42);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(130, 23);
            dateTimePicker2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(96, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(59, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(96, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(248, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(96, 23);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(684, 71);
            button1.Name = "button1";
            button1.Size = new Size(93, 33);
            button1.TabIndex = 9;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button vhod;
        private Label Login;
        private Panel panel2;
        private Panel panel3;
        private Label password;
        private Button Filter;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}