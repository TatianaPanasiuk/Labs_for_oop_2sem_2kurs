
namespace SEm2_LABA_2oop
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
            this.textBoxNazvanie = new System.Windows.Forms.TextBox();
            this.textBoxInventNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveInFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.trackBarColichestvo = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonIzFile = new System.Windows.Forms.Button();
            this.radioSred = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.radioBig = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Org = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColichestvo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNazvanie
            // 
            this.textBoxNazvanie.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNazvanie.Location = new System.Drawing.Point(76, 64);
            this.textBoxNazvanie.MaxLength = 36;
            this.textBoxNazvanie.Name = "textBoxNazvanie";
            this.textBoxNazvanie.Size = new System.Drawing.Size(381, 34);
            this.textBoxNazvanie.TabIndex = 0;
            // 
            // textBoxInventNumber
            // 
            this.textBoxInventNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInventNumber.Location = new System.Drawing.Point(76, 137);
            this.textBoxInventNumber.Name = "textBoxInventNumber";
            this.textBoxInventNumber.Size = new System.Drawing.Size(381, 34);
            this.textBoxInventNumber.TabIndex = 1;
            this.textBoxInventNumber.TextChanged += new System.EventHandler(this.textBoxInventNumber_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(344, 750);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSaveInFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveInFile.Location = new System.Drawing.Point(691, 35);
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(255, 37);
            this.buttonSaveInFile.TabIndex = 3;
            this.buttonSaveInFile.Text = "Сохранить в файл";
            this.buttonSaveInFile.UseVisualStyleBackColor = false;
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Размер";
            // 
            // textBoxVes
            // 
            this.textBoxVes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVes.Location = new System.Drawing.Point(82, 331);
            this.textBoxVes.Name = "textBoxVes";
            this.textBoxVes.Size = new System.Drawing.Size(135, 34);
            this.textBoxVes.TabIndex = 12;
            this.textBoxVes.TextChanged += new System.EventHandler(this.textBoxVes_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(82, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(344, 714);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата поступления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Тип";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(75, 714);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(250, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(76, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Производитель:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(76, 396);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 30);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "семена";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(183, 396);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 30);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "саженец";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCena.Location = new System.Drawing.Point(258, 331);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(173, 34);
            this.textBoxCena.TabIndex = 23;
            this.textBoxCena.TextChanged += new System.EventHandler(this.textBoxCena_TextChanged);
            // 
            // trackBarColichestvo
            // 
            this.trackBarColichestvo.LargeChange = 100;
            this.trackBarColichestvo.Location = new System.Drawing.Point(75, 767);
            this.trackBarColichestvo.Maximum = 1000;
            this.trackBarColichestvo.Name = "trackBarColichestvo";
            this.trackBarColichestvo.Size = new System.Drawing.Size(240, 56);
            this.trackBarColichestvo.SmallChange = 100;
            this.trackBarColichestvo.TabIndex = 24;
            this.trackBarColichestvo.Scroll += new System.EventHandler(this.trackBarColichestvo_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(82, 739);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(691, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(528, 522);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // buttonIzFile
            // 
            this.buttonIzFile.BackColor = System.Drawing.Color.Honeydew;
            this.buttonIzFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIzFile.Location = new System.Drawing.Point(952, 35);
            this.buttonIzFile.Name = "buttonIzFile";
            this.buttonIzFile.Size = new System.Drawing.Size(255, 37);
            this.buttonIzFile.TabIndex = 37;
            this.buttonIzFile.Text = "Прочитать из файла";
            this.buttonIzFile.UseVisualStyleBackColor = false;
            this.buttonIzFile.Click += new System.EventHandler(this.buttonIzFile_Click);
            // 
            // radioSred
            // 
            this.radioSred.AutoSize = true;
            this.radioSred.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioSred.Location = new System.Drawing.Point(165, 28);
            this.radioSred.Name = "radioSred";
            this.radioSred.Size = new System.Drawing.Size(118, 30);
            this.radioSred.TabIndex = 10;
            this.radioSred.TabStop = true;
            this.radioSred.Text = "Средний";
            this.radioSred.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioSmall.Location = new System.Drawing.Point(319, 26);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(140, 30);
            this.radioSmall.TabIndex = 11;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Маленький";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // radioBig
            // 
            this.radioBig.AutoSize = true;
            this.radioBig.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBig.Location = new System.Drawing.Point(6, 28);
            this.radioBig.Name = "radioBig";
            this.radioBig.Size = new System.Drawing.Size(121, 30);
            this.radioBig.TabIndex = 9;
            this.radioBig.TabStop = true;
            this.radioBig.Text = "Большой";
            this.radioBig.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBig);
            this.groupBox1.Controls.Add(this.radioSmall);
            this.groupBox1.Controls.Add(this.radioSred);
            this.groupBox1.Location = new System.Drawing.Point(76, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 76);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(691, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Honeydew;
            this.add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(72, 573);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(234, 46);
            this.add.TabIndex = 46;
            this.add.Text = "добавить в список";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Org
            // 
            this.Org.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Org.FormattingEnabled = true;
            this.Org.Location = new System.Drawing.Point(75, 515);
            this.Org.Name = "Org";
            this.Org.Size = new System.Drawing.Size(221, 34);
            this.Org.TabIndex = 48;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Honeydew;
            this.update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(307, 515);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 34);
            this.update.TabIndex = 49;
            this.update.Text = "обновить";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1260, 859);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Org);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIzFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBarColichestvo);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveInFile);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxInventNumber);
            this.Controls.Add(this.textBoxNazvanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColichestvo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazvanie;
        private System.Windows.Forms.TextBox textBoxInventNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSaveInFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TrackBar trackBarColichestvo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonIzFile;
        private System.Windows.Forms.RadioButton radioSred;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioBig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox Org;
        private System.Windows.Forms.Button update;
    }
}

