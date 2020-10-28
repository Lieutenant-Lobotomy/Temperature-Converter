namespace TempConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fahrenheit = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.btn_fahrenheit = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fahrenheit";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(667, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matt\'s Awesome Temperature Converter";
            // 
            // txt_fahrenheit
            // 
            this.txt_fahrenheit.Location = new System.Drawing.Point(310, 138);
            this.txt_fahrenheit.Name = "txt_fahrenheit";
            this.txt_fahrenheit.Size = new System.Drawing.Size(230, 26);
            this.txt_fahrenheit.TabIndex = 4;
            // 
            // txt_celsius
            // 
            this.txt_celsius.Location = new System.Drawing.Point(310, 235);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(230, 26);
            this.txt_celsius.TabIndex = 5;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Location = new System.Drawing.Point(310, 325);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(230, 26);
            this.txt_kelvin.TabIndex = 6;
            // 
            // btn_celsius
            // 
            this.btn_celsius.Location = new System.Drawing.Point(585, 234);
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.Size = new System.Drawing.Size(102, 38);
            this.btn_celsius.TabIndex = 8;
            this.btn_celsius.Text = "Convert";
            this.btn_celsius.UseVisualStyleBackColor = true;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click);
            // 
            // btn_fahrenheit
            // 
            this.btn_fahrenheit.Location = new System.Drawing.Point(585, 138);
            this.btn_fahrenheit.Name = "btn_fahrenheit";
            this.btn_fahrenheit.Size = new System.Drawing.Size(102, 38);
            this.btn_fahrenheit.TabIndex = 9;
            this.btn_fahrenheit.Text = "Convert";
            this.btn_fahrenheit.UseVisualStyleBackColor = true;
            this.btn_fahrenheit.Click += new System.EventHandler(this.btn_fahrenheit_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Location = new System.Drawing.Point(585, 325);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(102, 38);
            this.btn_kelvin.TabIndex = 10;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clearButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_fahrenheit);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_fahrenheit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_fahrenheit;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_celsius;
        private System.Windows.Forms.Button btn_fahrenheit;
        private System.Windows.Forms.Button btn_kelvin;
        private System.Windows.Forms.Button button1;
    }
}

