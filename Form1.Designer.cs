namespace Roblox_Place_Downloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            singleVersion = new TabPage();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            multiVersion = new TabPage();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            credits = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            saveSingleFile = new SaveFileDialog();
            saveMultipleFiles = new FolderBrowserDialog();
            label6 = new Label();
            tabControl1.SuspendLayout();
            singleVersion.SuspendLayout();
            multiVersion.SuspendLayout();
            credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(singleVersion);
            tabControl1.Controls.Add(multiVersion);
            tabControl1.Controls.Add(credits);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(365, 199);
            tabControl1.TabIndex = 0;
            // 
            // singleVersion
            // 
            singleVersion.Controls.Add(textBox2);
            singleVersion.Controls.Add(label2);
            singleVersion.Controls.Add(textBox1);
            singleVersion.Controls.Add(label1);
            singleVersion.Controls.Add(button1);
            singleVersion.Location = new Point(4, 24);
            singleVersion.Name = "singleVersion";
            singleVersion.Padding = new Padding(3);
            singleVersion.Size = new Size(357, 171);
            singleVersion.TabIndex = 0;
            singleVersion.Text = "Single Version";
            singleVersion.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(216, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 33);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Version ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Place ID";
            // 
            // button1
            // 
            button1.Location = new Point(140, 114);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Download!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // multiVersion
            // 
            multiVersion.Controls.Add(textBox3);
            multiVersion.Controls.Add(label3);
            multiVersion.Controls.Add(textBox4);
            multiVersion.Controls.Add(label4);
            multiVersion.Controls.Add(button2);
            multiVersion.Location = new Point(4, 24);
            multiVersion.Name = "multiVersion";
            multiVersion.Padding = new Padding(3);
            multiVersion.Size = new Size(357, 171);
            multiVersion.TabIndex = 1;
            multiVersion.Text = "Multiple Versions";
            multiVersion.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(216, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 33);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 8;
            label3.Text = "Version ID range (e.x 1,36)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(40, 51);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 33);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Place ID";
            // 
            // button2
            // 
            button2.Location = new Point(140, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Download!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // credits
            // 
            credits.Controls.Add(label6);
            credits.Controls.Add(pictureBox2);
            credits.Controls.Add(pictureBox1);
            credits.Controls.Add(label5);
            credits.Location = new Point(4, 24);
            credits.Name = "credits";
            credits.Padding = new Padding(3);
            credits.Size = new Size(357, 171);
            credits.TabIndex = 2;
            credits.Text = "Credits";
            credits.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lockpickblack;
            pictureBox2.InitialImage = Properties.Resources.loading;
            pictureBox2.Location = new Point(72, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://github.com/qfoxb.png";
            pictureBox1.InitialImage = Properties.Resources.loading;
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(62, 6);
            label5.Name = "label5";
            label5.Size = new Size(286, 28);
            label5.TabIndex = 0;
            label5.Text = "Program written by qfoxb 2024";
            // 
            // saveSingleFile
            // 
            saveSingleFile.Title = "Save Roblox Place File";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 34);
            label6.Name = "label6";
            label6.Size = new Size(280, 60);
            label6.TabIndex = 3;
            label6.Text = "Roblox Place Downloader is a C# Program designed\r\nto download a specific version of an uncopylocked\r\nplace with ease.\r\nNot affiliated with Roblox.\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 200);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Roblox Place Downloader";
            tabControl1.ResumeLayout(false);
            singleVersion.ResumeLayout(false);
            singleVersion.PerformLayout();
            multiVersion.ResumeLayout(false);
            multiVersion.PerformLayout();
            credits.ResumeLayout(false);
            credits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage singleVersion;
        private TabPage multiVersion;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TabPage credits;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private SaveFileDialog saveSingleFile;
        private FolderBrowserDialog saveMultipleFiles;
        private Label label6;
    }
}
