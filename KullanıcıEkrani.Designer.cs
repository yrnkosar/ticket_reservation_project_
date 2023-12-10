namespace Prolab2
{
    partial class KullanıcıEkrani
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
            comboBoxkalkis = new ComboBox();
            comboBoxvaris = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            listViewseferler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            numericUpDown2 = new NumericUpDown();
            labelkisi = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxkalkis
            // 
            comboBoxkalkis.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxkalkis.FormattingEnabled = true;
            comboBoxkalkis.Location = new Point(119, 22);
            comboBoxkalkis.Name = "comboBoxkalkis";
            comboBoxkalkis.Size = new Size(151, 28);
            comboBoxkalkis.TabIndex = 1;
            comboBoxkalkis.SelectedIndexChanged += comboBoxkalkis_SelectedIndexChanged;
            // 
            // comboBoxvaris
            // 
            comboBoxvaris.BackColor = Color.FromArgb(224, 224, 224);
            comboBoxvaris.FormattingEnabled = true;
            comboBoxvaris.Location = new Point(119, 94);
            comboBoxvaris.Name = "comboBoxvaris";
            comboBoxvaris.Size = new Size(151, 28);
            comboBoxvaris.TabIndex = 2;
            comboBoxvaris.SelectedIndexChanged += comboBoxvaris_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(119, 168);
            dateTimePicker1.MaxDate = new DateTime(2023, 12, 10, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2023, 12, 4, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "Kalkış Noktası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 6;
            label2.Text = "Varış Noktası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 173);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 11;
            label5.Text = "Tarih";
            // 
            // listViewseferler
            // 
            listViewseferler.BackColor = Color.FromArgb(224, 224, 224);
            listViewseferler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewseferler.Dock = DockStyle.Right;
            listViewseferler.FullRowSelect = true;
            listViewseferler.GridLines = true;
            listViewseferler.Location = new Point(357, 0);
            listViewseferler.Name = "listViewseferler";
            listViewseferler.Size = new Size(397, 351);
            listViewseferler.TabIndex = 15;
            listViewseferler.UseCompatibleStateImageBehavior = false;
            listViewseferler.View = View.Details;
            listViewseferler.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Firma Adı";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Araç Türü";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Sefer No";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            columnHeader4.Width = 100;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(224, 224, 224);
            numericUpDown2.Location = new Point(119, 240);
            numericUpDown2.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(151, 27);
            numericUpDown2.TabIndex = 16;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // labelkisi
            // 
            labelkisi.AutoSize = true;
            labelkisi.Location = new Point(12, 242);
            labelkisi.Name = "labelkisi";
            labelkisi.Size = new Size(73, 20);
            labelkisi.TabIndex = 17;
            labelkisi.Text = "Kişi Sayısı";
            // 
            // KullanıcıEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(754, 351);
            Controls.Add(labelkisi);
            Controls.Add(numericUpDown2);
            Controls.Add(listViewseferler);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBoxvaris);
            Controls.Add(comboBoxkalkis);
            Name = "KullanıcıEkrani";
            Text = "Kullanıcı Ekrani";
            Load += KullanıcıEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxkalkis;
        private ComboBox comboBoxvaris;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private ListView listViewseferler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private NumericUpDown numericUpDown2;
        private Label labelkisi;
    }
}