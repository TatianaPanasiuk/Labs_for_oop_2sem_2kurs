
namespace SEm2_LABA_2oop
{
    partial class AddForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Telefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxAders = new System.Windows.Forms.TextBox();
            this.textBoxOrg = new System.Windows.Forms.TextBox();
            this.textBoxStrana = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(365, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 26);
            this.label14.TabIndex = 44;
            this.label14.Text = "Телефон";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(365, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 26);
            this.label13.TabIndex = 43;
            this.label13.Text = "Адрес";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 26);
            this.label12.TabIndex = 42;
            this.label12.Text = "Организация";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(43, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 26);
            this.label11.TabIndex = 41;
            this.label11.Text = "Страна";
            // 
            // Telefon
            // 
            this.Telefon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Telefon.Location = new System.Drawing.Point(365, 180);
            this.Telefon.Mask = "(999) 000-0000";
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(284, 34);
            this.Telefon.TabIndex = 40;
            // 
            // textBoxAders
            // 
            this.textBoxAders.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAders.Location = new System.Drawing.Point(365, 89);
            this.textBoxAders.Name = "textBoxAders";
            this.textBoxAders.Size = new System.Drawing.Size(284, 34);
            this.textBoxAders.TabIndex = 39;
            // 
            // textBoxOrg
            // 
            this.textBoxOrg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOrg.Location = new System.Drawing.Point(43, 180);
            this.textBoxOrg.Name = "textBoxOrg";
            this.textBoxOrg.Size = new System.Drawing.Size(284, 34);
            this.textBoxOrg.TabIndex = 38;
            // 
            // textBoxStrana
            // 
            this.textBoxStrana.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStrana.Location = new System.Drawing.Point(43, 89);
            this.textBoxStrana.Name = "textBoxStrana";
            this.textBoxStrana.Size = new System.Drawing.Size(284, 34);
            this.textBoxStrana.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(270, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 65);
            this.button2.TabIndex = 45;
            this.button2.Text = "добавить в список";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.textBoxAders);
            this.Controls.Add(this.textBoxOrg);
            this.Controls.Add(this.textBoxStrana);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox Telefon;
        private System.Windows.Forms.TextBox textBoxAders;
        private System.Windows.Forms.TextBox textBoxOrg;
        private System.Windows.Forms.TextBox textBoxStrana;
        private System.Windows.Forms.Button button2;
    }
}
