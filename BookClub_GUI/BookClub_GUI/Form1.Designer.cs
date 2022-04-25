
namespace BookClub_GUI
{
    partial class Form1
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
            this.comboBox_nev = new System.Windows.Forms.ComboBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.dateTimePicker_datum = new System.Windows.Forms.DateTimePicker();
            this.label_osszeg = new System.Windows.Forms.Label();
            this.numericUpDown_osszeg = new System.Windows.Forms.NumericUpDown();
            this.button_rogzit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_osszeg)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_nev
            // 
            this.comboBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_nev.FormattingEnabled = true;
            this.comboBox_nev.Location = new System.Drawing.Point(302, 61);
            this.comboBox_nev.Name = "comboBox_nev";
            this.comboBox_nev.Size = new System.Drawing.Size(256, 30);
            this.comboBox_nev.TabIndex = 0;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(151, 61);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(44, 24);
            this.label_nev.TabIndex = 1;
            this.label_nev.Text = "Név";
            // 
            // dateTimePicker_datum
            // 
            this.dateTimePicker_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_datum.Location = new System.Drawing.Point(302, 145);
            this.dateTimePicker_datum.Name = "dateTimePicker_datum";
            this.dateTimePicker_datum.Size = new System.Drawing.Size(256, 28);
            this.dateTimePicker_datum.TabIndex = 2;
            // 
            // label_osszeg
            // 
            this.label_osszeg.AutoSize = true;
            this.label_osszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_osszeg.Location = new System.Drawing.Point(151, 224);
            this.label_osszeg.Name = "label_osszeg";
            this.label_osszeg.Size = new System.Drawing.Size(74, 24);
            this.label_osszeg.TabIndex = 3;
            this.label_osszeg.Text = "Összeg";
            // 
            // numericUpDown_osszeg
            // 
            this.numericUpDown_osszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_osszeg.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_osszeg.Location = new System.Drawing.Point(302, 224);
            this.numericUpDown_osszeg.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_osszeg.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_osszeg.Name = "numericUpDown_osszeg";
            this.numericUpDown_osszeg.Size = new System.Drawing.Size(256, 28);
            this.numericUpDown_osszeg.TabIndex = 4;
            this.numericUpDown_osszeg.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // button_rogzit
            // 
            this.button_rogzit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_rogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rogzit.ForeColor = System.Drawing.Color.White;
            this.button_rogzit.Location = new System.Drawing.Point(155, 311);
            this.button_rogzit.Name = "button_rogzit";
            this.button_rogzit.Size = new System.Drawing.Size(403, 40);
            this.button_rogzit.TabIndex = 5;
            this.button_rogzit.Text = "Rögzít";
            this.button_rogzit.UseVisualStyleBackColor = false;
            this.button_rogzit.Click += new System.EventHandler(this.button_rogzit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_rogzit);
            this.Controls.Add(this.numericUpDown_osszeg);
            this.Controls.Add(this.label_osszeg);
            this.Controls.Add(this.dateTimePicker_datum);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.comboBox_nev);
            this.Name = "Form1";
            this.Text = "Befizetés";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_osszeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
        private System.Windows.Forms.Label label_osszeg;
        private System.Windows.Forms.NumericUpDown numericUpDown_osszeg;
        private System.Windows.Forms.Button button_rogzit;
    }
}

