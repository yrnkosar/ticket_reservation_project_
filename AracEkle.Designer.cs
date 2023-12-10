namespace Prolab2
{
    partial class AracEkle
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            textBoxKoltuk = new TextBox();
            button2 = new Button();
            fueltype = new ComboBox();
            companytype = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(119, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "Araç seçiniz";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(119, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 4;
            label2.Text = "Sefer seçiniz";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 123);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 5;
            label3.Text = "Koltuk adedi";
            // 
            // button1
            // 
            button1.Location = new Point(313, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(40, 247);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(342, 64);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // textBoxKoltuk
            // 
            textBoxKoltuk.Location = new Point(119, 116);
            textBoxKoltuk.Name = "textBoxKoltuk";
            textBoxKoltuk.Size = new Size(125, 27);
            textBoxKoltuk.TabIndex = 8;
            textBoxKoltuk.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(313, 340);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fueltype
            // 
            fueltype.FormattingEnabled = true;
            fueltype.Location = new Point(119, 154);
            fueltype.Name = "fueltype";
            fueltype.Size = new Size(151, 28);
            fueltype.TabIndex = 10;
            fueltype.SelectedIndexChanged += fueltype_SelectedIndexChanged;
            // 
            // companytype
            // 
            companytype.FormattingEnabled = true;
            companytype.Location = new Point(119, 196);
            companytype.Name = "companytype";
            companytype.Size = new Size(151, 28);
            companytype.TabIndex = 11;
            companytype.SelectedIndexChanged += fueltype_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 162);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Yakıt türü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 196);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 13;
            label5.Text = "Şirket adı";
            // 
            // AracEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(444, 398);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(companytype);
            Controls.Add(fueltype);
            Controls.Add(button2);
            Controls.Add(textBoxKoltuk);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "AracEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AracEkle";
            Load += AracEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBoxKoltuk;
        private Button button2;
        private ComboBox fueltype;
        private ComboBox companytype;
        private Label label4;
        private Label label5;
    }
}