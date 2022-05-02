
namespace SEm2_LABA_5oop
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
            this.components = new System.ComponentModel.Container();
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
            this.buttonIzFile = new System.Windows.Forms.Button();
            this.radioSred = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.radioBig = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lABA5maybeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Prototype = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbOrg = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColichestvo)).BeginInit();
            this.gb1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazvanie
            // 
            this.textBoxNazvanie.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNazvanie.Location = new System.Drawing.Point(79, 104);
            this.textBoxNazvanie.MaxLength = 36;
            this.textBoxNazvanie.Name = "textBoxNazvanie";
            this.textBoxNazvanie.Size = new System.Drawing.Size(381, 34);
            this.textBoxNazvanie.TabIndex = 0;
            this.textBoxNazvanie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNazvanie_KeyPress);
            // 
            // textBoxInventNumber
            // 
            this.textBoxInventNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInventNumber.Location = new System.Drawing.Point(79, 177);
            this.textBoxInventNumber.Name = "textBoxInventNumber";
            this.textBoxInventNumber.Size = new System.Drawing.Size(381, 34);
            this.textBoxInventNumber.TabIndex = 1;
            this.textBoxInventNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInventNumber_KeyPress_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(868, 328);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSaveInFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveInFile.Location = new System.Drawing.Point(76, 477);
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
            this.label1.Location = new System.Drawing.Point(79, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Инвентарный номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Размер";
            // 
            // textBoxVes
            // 
            this.textBoxVes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVes.Location = new System.Drawing.Point(85, 371);
            this.textBoxVes.Name = "textBoxVes";
            this.textBoxVes.Size = new System.Drawing.Size(135, 34);
            this.textBoxVes.TabIndex = 12;
            this.textBoxVes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVes_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(85, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(868, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата поступления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(79, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Тип";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(601, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(253, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(601, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Производитель:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(79, 436);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 30);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "семена";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(186, 436);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 30);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "саженец";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCena.Location = new System.Drawing.Point(261, 371);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(173, 34);
            this.textBoxCena.TabIndex = 23;
            this.textBoxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCena_KeyPress);
            // 
            // trackBarColichestvo
            // 
            this.trackBarColichestvo.LargeChange = 100;
            this.trackBarColichestvo.Location = new System.Drawing.Point(595, 359);
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
            this.label10.Location = new System.Drawing.Point(603, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "0";
            // 
            // buttonIzFile
            // 
            this.buttonIzFile.BackColor = System.Drawing.Color.Honeydew;
            this.buttonIzFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIzFile.Location = new System.Drawing.Point(352, 477);
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
            // gb1
            // 
            this.gb1.Controls.Add(this.radioBig);
            this.gb1.Controls.Add(this.radioSmall);
            this.gb1.Controls.Add(this.radioSred);
            this.gb1.Location = new System.Drawing.Point(79, 253);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(465, 76);
            this.gb1.TabIndex = 27;
            this.gb1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(638, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 41);
            this.button1.TabIndex = 38;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(69, 520);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1463, 304);
            this.listBox1.TabIndex = 55;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.oProgrammeToolStripMenuItem,
            this.lABA5maybeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1561, 28);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiskToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // poiskToolStripMenuItem
            // 
            this.poiskToolStripMenuItem.Name = "poiskToolStripMenuItem";
            this.poiskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.poiskToolStripMenuItem.Text = "Poisk";
            this.poiskToolStripMenuItem.Click += new System.EventHandler(this.poiskToolStripMenuItem_Click);
            // 
            // oProgrammeToolStripMenuItem
            // 
            this.oProgrammeToolStripMenuItem.Name = "oProgrammeToolStripMenuItem";
            this.oProgrammeToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.oProgrammeToolStripMenuItem.Text = "O programme";
            this.oProgrammeToolStripMenuItem.Click += new System.EventHandler(this.oProgrammeToolStripMenuItem_Click);
            // 
            // lABA5maybeToolStripMenuItem
            // 
            this.lABA5maybeToolStripMenuItem.Name = "lABA5maybeToolStripMenuItem";
            this.lABA5maybeToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.lABA5maybeToolStripMenuItem.Text = "LABA_5 (maybe)";
            this.lABA5maybeToolStripMenuItem.Click += new System.EventHandler(this.lABA5maybeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 833);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1561, 26);
            this.statusStrip1.TabIndex = 58;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 20);
            this.toolStripStatusLabel1.Text = "Дата и время";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(152, 20);
            this.toolStripStatusLabel2.Text = "Последнее действие";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(135, 20);
            this.toolStripStatusLabel3.Text = "Товаров в памяти";
            // 
            // Prototype
            // 
            this.Prototype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prototype.Location = new System.Drawing.Point(1145, 75);
            this.Prototype.Name = "Prototype";
            this.Prototype.Size = new System.Drawing.Size(166, 41);
            this.Prototype.TabIndex = 59;
            this.Prototype.Text = "clone";
            this.Prototype.UseVisualStyleBackColor = true;
            this.Prototype.Click += new System.EventHandler(this.Prototype_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(612, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 52;
            this.label12.Text = "Организация";
            // 
            // cbOrg
            // 
            this.cbOrg.FormattingEnabled = true;
            this.cbOrg.Location = new System.Drawing.Point(612, 146);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Size = new System.Drawing.Size(258, 28);
            this.cbOrg.TabIndex = 60;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(615, 180);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(166, 41);
            this.add.TabIndex = 61;
            this.add.Text = "добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.update.Location = new System.Drawing.Point(887, 142);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(157, 32);
            this.update.TabIndex = 62;
            this.update.Text = "обновить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1145, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 41);
            this.button2.TabIndex = 63;
            this.button2.Text = "свойства формы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1561, 859);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.Prototype);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIzFile);
            this.Controls.Add(this.gb1);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColichestvo)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button buttonIzFile;
        private System.Windows.Forms.RadioButton radioSred;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioBig;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poiskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgrammeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button Prototype;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbOrg;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem lABA5maybeToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

