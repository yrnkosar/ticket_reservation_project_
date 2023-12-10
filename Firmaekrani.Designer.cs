namespace Prolab2
{
    partial class Firmaekrani
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
            button5 = new Button();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            sssa = new DataGridViewTextBoxColumn();
            Arac = new DataGridViewTextBoxColumn();
            Sefer = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 104);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button5
            // 
            button5.Location = new Point(336, 3);
            button5.Name = "button5";
            button5.Size = new Size(103, 48);
            button5.TabIndex = 5;
            button5.Text = "Günlük Kar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 54);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 4;
            label1.Text = "___";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(253, 3);
            button4.Name = "button4";
            button4.Size = new Size(77, 99);
            button4.TabIndex = 3;
            button4.Text = "Anasayfa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(84, 3);
            button3.Name = "button3";
            button3.Size = new Size(74, 99);
            button3.TabIndex = 2;
            button3.Text = "Düzenle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(164, 3);
            button2.Name = "button2";
            button2.Size = new Size(83, 99);
            button2.TabIndex = 1;
            button2.Text = "Araç Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(5, 3);
            button1.Name = "button1";
            button1.Size = new Size(73, 99);
            button1.TabIndex = 0;
            button1.Text = "Araç Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Teal;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sssa, Arac, Sefer });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(565, 346);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // sssa
            // 
            sssa.HeaderText = "sa";
            sssa.MinimumWidth = 6;
            sssa.Name = "sssa";
            sssa.Visible = false;
            sssa.Width = 125;
            // 
            // Arac
            // 
            Arac.HeaderText = "Araç";
            Arac.MinimumWidth = 6;
            Arac.Name = "Arac";
            Arac.Width = 125;
            // 
            // Sefer
            // 
            Sefer.HeaderText = "Sefer";
            Sefer.MinimumWidth = 6;
            Sefer.Name = "Sefer";
            Sefer.Width = 125;
            // 
            // Firmaekrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Firmaekrani";
            Text = "Firma Ekranı";
            Load += Firmaekrani_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Label label1;
        private DataGridViewTextBoxColumn sssa;
        private DataGridViewTextBoxColumn Arac;
        private DataGridViewTextBoxColumn Sefer;
    }
}