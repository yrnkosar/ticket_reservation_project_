namespace Prolab2
{
    partial class Firmaekleme
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
            button1 = new Button();
            buttonTamam = new Button();
            textBoxSifre = new TextBox();
            textBoxkullanici = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxfname = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(137, 171);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "iptal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonTamam
            // 
            buttonTamam.DialogResult = DialogResult.OK;
            buttonTamam.Location = new Point(308, 171);
            buttonTamam.Name = "buttonTamam";
            buttonTamam.Size = new Size(94, 29);
            buttonTamam.TabIndex = 1;
            buttonTamam.Text = "tamam";
            buttonTamam.UseVisualStyleBackColor = true;
            buttonTamam.Click += buttonTamam_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(137, 121);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(265, 27);
            textBoxSifre.TabIndex = 3;
            // 
            // textBoxkullanici
            // 
            textBoxkullanici.Location = new Point(137, 81);
            textBoxkullanici.Name = "textBoxkullanici";
            textBoxkullanici.Size = new Size(265, 27);
            textBoxkullanici.TabIndex = 4;
            textBoxkullanici.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 84);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 124);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 40);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Firma Adı:";
            // 
            // textBoxfname
            // 
            textBoxfname.Location = new Point(137, 37);
            textBoxfname.Name = "textBoxfname";
            textBoxfname.Size = new Size(265, 27);
            textBoxfname.TabIndex = 9;
            textBoxfname.TextChanged += textBox1_TextChanged_1;
            // 
            // Firmaekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(492, 278);
            Controls.Add(textBoxfname);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxkullanici);
            Controls.Add(textBoxSifre);
            Controls.Add(buttonTamam);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Firmaekleme";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Firma Ekleme";
            Load += Firmaekleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonTamam;
        private TextBox textBoxAracBilgisi;
        private TextBox textBoxSifre;
        private TextBox textBoxkullanici;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxfname;
    }
}