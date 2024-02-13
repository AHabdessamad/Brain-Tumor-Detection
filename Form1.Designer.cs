namespace BrainTumor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            listBox1 = new ListBox();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(123, 185, 45);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(271, 79);
            button1.Name = "button1";
            button1.Size = new Size(171, 35);
            button1.TabIndex = 0;
            button1.Text = "UPLOAD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(123, 185, 45);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(519, 79);
            button3.Name = "button3";
            button3.Size = new Size(171, 35);
            button3.TabIndex = 2;
            button3.Text = "CLASSIFY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(271, 152);
            pictureBox1.MaximumSize = new Size(171, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Model 1: ML.net", "Model 2: Tensorflow " });
            comboBox1.Location = new Point(12, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Tag = "";
            comboBox1.Text = "Model 1: ML.net";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 216);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 6;
            label1.Text = "Choose a Model:";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(519, 152);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 191);
            listBox1.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(244, 51, 67);
            button4.Cursor = Cursors.Hand;
            button4.ForeColor = Color.White;
            button4.Location = new Point(672, 369);
            button4.Name = "button4";
            button4.Size = new Size(99, 32);
            button4.TabIndex = 8;
            button4.Text = "RESET";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.logo;
            pictureBox3.Location = new Point(0, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(172, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(35, 27, 105);
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.info_icon;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(27, 355);
            button5.Name = "button5";
            button5.Padding = new Padding(6, 0, 6, 0);
            button5.Size = new Size(108, 35);
            button5.TabIndex = 10;
            button5.Text = "ABOUT US";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 20, 48);
            label2.Location = new Point(243, 15);
            label2.Name = "label2";
            label2.Size = new Size(497, 50);
            label2.TabIndex = 11;
            label2.Text = "BRAIN TUMOR DETECTOR";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.copyright_icon;
            pictureBox4.Location = new Point(313, 418);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 22);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(30, 41, 49);
            label3.Location = new Point(335, 418);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 14;
            label3.Text = "ALL RIGHTS RESERVED";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(799, 449);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BrainTech";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private ListBox listBox1;
        private Button button4;
        private PictureBox pictureBox3;
        private Button button5;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label3;
    }
}