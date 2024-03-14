namespace Hajozas
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
            dataGridView1 = new DataGridView();
            válaszGomb1 = new VálaszGomb();
            válaszGomb2 = new VálaszGomb();
            válaszGomb3 = new VálaszGomb();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Következő = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 269);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(804, 186);
            dataGridView1.TabIndex = 0;
            // 
            // válaszGomb1
            // 
            válaszGomb1.BackColor = Color.Gray;
            válaszGomb1.BorderStyle = BorderStyle.None;
            válaszGomb1.Location = new Point(12, 127);
            válaszGomb1.Multiline = true;
            válaszGomb1.Name = "válaszGomb1";
            válaszGomb1.ReadOnly = true;
            válaszGomb1.Size = new Size(318, 62);
            válaszGomb1.TabIndex = 1;
            // 
            // válaszGomb2
            // 
            válaszGomb2.BackColor = Color.Gray;
            válaszGomb2.BorderStyle = BorderStyle.None;
            válaszGomb2.Location = new Point(12, 195);
            válaszGomb2.Multiline = true;
            válaszGomb2.Name = "válaszGomb2";
            válaszGomb2.ReadOnly = true;
            válaszGomb2.Size = new Size(318, 62);
            válaszGomb2.TabIndex = 2;
            // 
            // válaszGomb3
            // 
            válaszGomb3.BackColor = Color.Gray;
            válaszGomb3.BorderStyle = BorderStyle.None;
            válaszGomb3.Location = new Point(12, 59);
            válaszGomb3.Multiline = true;
            válaszGomb3.Name = "válaszGomb3";
            válaszGomb3.ReadOnly = true;
            válaszGomb3.Size = new Size(318, 62);
            válaszGomb3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(455, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 231);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Következő
            // 
            Következő.Location = new Point(233, 17);
            Következő.Name = "Következő";
            Következő.Size = new Size(120, 33);
            Következő.TabIndex = 6;
            Következő.Text = "button1";
            Következő.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Következő);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(válaszGomb3);
            Controls.Add(válaszGomb2);
            Controls.Add(válaszGomb1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private VálaszGomb válaszGomb1;
        private VálaszGomb válaszGomb2;
        private VálaszGomb válaszGomb3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Következő;
    }
}