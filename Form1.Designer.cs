namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flight Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(346, 274);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 9;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(294, 98);
            button2.Name = "button2";
            button2.Size = new Size(63, 26);
            button2.TabIndex = 8;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(10, 227);
            label4.Name = "label4";
            label4.Size = new Size(72, 32);
            label4.TabIndex = 6;
            label4.Text = "Time:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(81, 230);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(303, 31);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 158);
            label3.Name = "label3";
            label3.Size = new Size(69, 32);
            label3.TabIndex = 5;
            label3.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Samsun", "Ankara", "Adana ", "Bursa", "Elazığ" });
            comboBox2.Location = new Point(56, 96);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Samsun", "Ankara", "Adana ", "Bursa", "Elazığ" });
            comboBox1.Location = new Point(81, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(44, 32);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(440, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 235);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passenger Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(133, 119);
            maskedTextBox4.Mask = "(999) 000-0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(150, 31);
            maskedTextBox4.TabIndex = 5;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(47, 73);
            maskedTextBox3.Mask = "00000000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(150, 31);
            maskedTextBox3.TabIndex = 4;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 122);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 2;
            label7.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 73);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 1;
            label6.Text = "TC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 27);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 0;
            label5.Text = "Name and Surname:";
            // 
            // button1
            // 
            button1.Location = new Point(478, 311);
            button1.Name = "button1";
            button1.Size = new Size(267, 54);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(7, 371);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(789, 79);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(255, 224, 192);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Location = new Point(7, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(630, 75);
            flowLayoutPanel1.TabIndex = 7;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(528, 76);
            label8.TabIndex = 0;
            label8.Text = "JUPİTER AİRLİNES";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(643, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button2;
        private Label label9;
    }
}
