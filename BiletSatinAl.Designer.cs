namespace Prolab2
{
    partial class BiletSatinAl
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
            label1 = new Label();
            label2 = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            maskedTextBoxTel = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            buttonok = new Button();
            maskedTextBoxTC = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 75);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 115);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(175, 72);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(125, 27);
            textBoxAd.TabIndex = 2;
            textBoxAd.TextChanged += textBoxAd_TextChanged;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(175, 112);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(125, 27);
            textBoxSoyad.TabIndex = 3;
            textBoxSoyad.TextChanged += textBoxSoyad_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 159);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 210);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 5;
            label4.Text = "Telefon Numarası:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 37);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 6;
            label5.Text = "TC Kimlik No:";
            // 
            // maskedTextBoxTel
            // 
            maskedTextBoxTel.Location = new Point(175, 207);
            maskedTextBoxTel.Mask = "(999) 000-0000";
            maskedTextBoxTel.Name = "maskedTextBoxTel";
            maskedTextBoxTel.Size = new Size(125, 27);
            maskedTextBoxTel.TabIndex = 7;
            maskedTextBoxTel.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(175, 159);
            dateTimePicker1.MaxDate = new DateTime(2023, 12, 10, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(175, 269);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "İptal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonok
            // 
            buttonok.DialogResult = DialogResult.OK;
            buttonok.Location = new Point(301, 269);
            buttonok.Name = "buttonok";
            buttonok.Size = new Size(94, 29);
            buttonok.TabIndex = 14;
            buttonok.Text = "Ödeme Yap";
            buttonok.UseVisualStyleBackColor = true;
            buttonok.Click += button2_Click;
            // 
            // maskedTextBoxTC
            // 
            maskedTextBoxTC.Location = new Point(175, 34);
            maskedTextBoxTC.Mask = "00000000000";
            maskedTextBoxTC.Name = "maskedTextBoxTC";
            maskedTextBoxTC.Size = new Size(125, 27);
            maskedTextBoxTC.TabIndex = 15;
            maskedTextBoxTC.ValidatingType = typeof(int);
            // 
            // BiletSatinAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(523, 369);
            Controls.Add(maskedTextBoxTC);
            Controls.Add(buttonok);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBoxTel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BiletSatinAl";
            Text = "BiletSatinAl";
            Load += BiletSatinAl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBoxTel;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button buttonok;
        private MaskedTextBox maskedTextBoxTC;
    }
}