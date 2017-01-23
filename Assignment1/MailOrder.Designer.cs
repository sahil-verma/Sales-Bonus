namespace Assignment1
{
    partial class MailOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailOrder));
            this.Calculate = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameOfEmployee = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Sales = new System.Windows.Forms.Label();
            this.Bonus = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Languages = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Languages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.AutoSize = true;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(3, 290);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(85, 26);
            this.Calculate.TabIndex = 5;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Print
            // 
            this.Print.AutoSize = true;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(143, 290);
            this.Print.Margin = new System.Windows.Forms.Padding(4);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(69, 26);
            this.Print.TabIndex = 6;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.button7_Click);
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(270, 290);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(62, 26);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 9;
            // 
            // nameOfEmployee
            // 
            this.nameOfEmployee.AutoSize = true;
            this.nameOfEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameOfEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfEmployee.Location = new System.Drawing.Point(-1, 106);
            this.nameOfEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOfEmployee.Name = "nameOfEmployee";
            this.nameOfEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameOfEmployee.Size = new System.Drawing.Size(120, 16);
            this.nameOfEmployee.TabIndex = 10;
            this.nameOfEmployee.Text = "Employee\'s Name";
            this.nameOfEmployee.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(30, 138);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(89, 16);
            this.ID.TabIndex = 11;
            this.ID.Text = "Employee ID:";
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(21, 187);
            this.Hours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(98, 16);
            this.Hours.TabIndex = 12;
            this.Hours.Text = "Hours Worked:";
            this.Hours.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sales
            // 
            this.Sales.AutoSize = true;
            this.Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(39, 222);
            this.Sales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(80, 16);
            this.Sales.TabIndex = 13;
            this.Sales.Text = "Total Sales:";
            this.Sales.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bonus
            // 
            this.Bonus.AutoSize = true;
            this.Bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus.Location = new System.Drawing.Point(32, 253);
            this.Bonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bonus.Name = "Bonus";
            this.Bonus.Size = new System.Drawing.Size(87, 16);
            this.Bonus.TabIndex = 14;
            this.Bonus.Text = "Sales Bonus:";
            this.Bonus.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 184);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 22);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 219);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(150, 22);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(119, 250);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 22);
            this.textBox5.TabIndex = 17;
            // 
            // Languages
            // 
            this.Languages.Controls.Add(this.radioButton2);
            this.Languages.Controls.Add(this.radioButton1);
            this.Languages.Location = new System.Drawing.Point(156, 13);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(176, 68);
            this.Languages.TabIndex = 22;
            this.Languages.TabStop = false;
            this.Languages.Text = "Languages";
            this.Languages.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 20);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.Text = "Français";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 20);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(335, 319);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Bonus);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.nameOfEmployee);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Calculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Languages.ResumeLayout(false);
            this.Languages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nameOfEmployee;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Label Sales;
        private System.Windows.Forms.Label Bonus;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox Languages;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

