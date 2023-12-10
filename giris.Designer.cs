namespace Prolab2
{
    partial class giris
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxka = new TextBox();
            textBoxSifre = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(126, 335);
            button1.Name = "button1";
            button1.Size = new Size(98, 40);
            button1.TabIndex = 0;
            button1.Text = "iptal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(224, 224, 224);
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(270, 335);
            button2.Name = "button2";
            button2.Size = new Size(92, 40);
            button2.TabIndex = 1;
            button2.Text = "tamam";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 169);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 232);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // textBoxka
            // 
            textBoxka.BackColor = Color.FromArgb(224, 224, 224);
            textBoxka.Location = new Point(199, 166);
            textBoxka.Name = "textBoxka";
            textBoxka.Size = new Size(163, 27);
            textBoxka.TabIndex = 4;
            textBoxka.TextChanged += textBoxkullaniciadi_TextChanged;
            // 
            // textBoxSifre
            // 
            textBoxSifre.BackColor = Color.FromArgb(224, 224, 224);
            textBoxSifre.Location = new Point(199, 232);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(163, 27);
            textBoxSifre.TabIndex = 5;
            textBoxSifre.UseSystemPasswordChar = true;
            textBoxSifre.TextChanged += textBoxSifre_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(73, 29);
            button3.Name = "button3";
            button3.Size = new Size(289, 82);
            button3.TabIndex = 7;
            button3.Text = "Bilet Satın Al";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(509, 451);
            Controls.Add(button3);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "giris";
            Text = "giris";
            Load += giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBoxka;
        private TextBox textBoxSifre;
        private Button button3;
    }
}