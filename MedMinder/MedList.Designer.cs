namespace MedMinder
{
    partial class MedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedList));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(29, 83);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(734, 64);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(29, 164);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(734, 64);
            listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(29, 246);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(734, 64);
            listBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(288, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 34);
            textBox1.TabIndex = 4;
            textBox1.Text = "List of The Medicine ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(680, 343);
            button1.Name = "button1";
            button1.Size = new Size(108, 104);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MedList
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            ClientSize = new Size(800, 459);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "MedList";
            Text = "MedList";
            Load += MedList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private TextBox textBox1;
        private Button button1;
    }
}