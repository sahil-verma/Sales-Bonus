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
            this.empName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.nameOfEmployee = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.Label();
            this.Hours = new System.Windows.Forms.Label();
            this.Sales = new System.Windows.Forms.Label();
            this.Bonus = new System.Windows.Forms.Label();
            this.NumberOfHours = new System.Windows.Forms.TextBox();
            this.TotalSales = new System.Windows.Forms.TextBox();
            this.SalesBonus = new System.Windows.Forms.TextBox();
            this.Languages = new System.Windows.Forms.GroupBox();
            this.frenchRadioButton = new System.Windows.Forms.RadioButton();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
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
            this.Calculate.Click += new System.EventHandler(this._Button_click);
            // 
            // Print
            // 
            this.Print.AutoSize = true;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(163, 290);
            this.Print.Margin = new System.Windows.Forms.Padding(4);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(69, 26);
            this.Print.TabIndex = 6;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this._Button_click);
            // 
            // Next
            // 
            this.Next.AutoSize = true;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(292, 290);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(62, 26);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this._Button_click);
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(133, 103);
            this.empName.Margin = new System.Windows.Forms.Padding(4);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(221, 22);
            this.empName.TabIndex = 8;
            this.empName.Tag = "textSpace";
            this.empName.Click += new System.EventHandler(this._textFields);
            this.empName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(133, 135);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(158, 22);
            this.ID.TabIndex = 9;
            this.ID.Tag = "textSpace";
            this.ID.Click += new System.EventHandler(this._textFields);
            this.ID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // nameOfEmployee
            // 
            this.nameOfEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameOfEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfEmployee.Location = new System.Drawing.Point(3, 106);
            this.nameOfEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameOfEmployee.Name = "nameOfEmployee";
            this.nameOfEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameOfEmployee.Size = new System.Drawing.Size(129, 16);
            this.nameOfEmployee.TabIndex = 10;
            this.nameOfEmployee.Text = "Employee\'s Name";
            this.nameOfEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nameOfEmployee.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Employee
            // 
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(0, 138);
            this.Employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(132, 16);
            this.Employee.TabIndex = 11;
            this.Employee.Text = "Employee ID:";
            this.Employee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Hours
            // 
            this.Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hours.Location = new System.Drawing.Point(3, 187);
            this.Hours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(132, 16);
            this.Hours.TabIndex = 12;
            this.Hours.Text = "Hours Worked:";
            this.Hours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hours.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sales
            // 
            this.Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(3, 222);
            this.Sales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(132, 16);
            this.Sales.TabIndex = 13;
            this.Sales.Text = "Total Sales:";
            this.Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sales.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bonus
            // 
            this.Bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus.Location = new System.Drawing.Point(3, 253);
            this.Bonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bonus.Name = "Bonus";
            this.Bonus.Size = new System.Drawing.Size(133, 16);
            this.Bonus.TabIndex = 14;
            this.Bonus.Text = "Sales Bonus:";
            this.Bonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bonus.UseWaitCursor = true;
            this.Bonus.Click += new System.EventHandler(this.label5_Click);
            // 
            // NumberOfHours
            // 
            this.NumberOfHours.Location = new System.Drawing.Point(133, 184);
            this.NumberOfHours.Margin = new System.Windows.Forms.Padding(4);
            this.NumberOfHours.Name = "NumberOfHours";
            this.NumberOfHours.Size = new System.Drawing.Size(158, 22);
            this.NumberOfHours.TabIndex = 15;
            this.NumberOfHours.Tag = "textSpace";
            this.NumberOfHours.Click += new System.EventHandler(this._textFields);
            this.NumberOfHours.TextChanged += new System.EventHandler(this._textFields);
            // 
            // TotalSales
            // 
            this.TotalSales.Location = new System.Drawing.Point(133, 219);
            this.TotalSales.Margin = new System.Windows.Forms.Padding(4);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Size = new System.Drawing.Size(158, 22);
            this.TotalSales.TabIndex = 16;
            this.TotalSales.Tag = "textSpace";
            this.TotalSales.Click += new System.EventHandler(this._textFields);
            this.TotalSales.TextChanged += new System.EventHandler(this._textFields);
            // 
            // SalesBonus
            // 
            this.SalesBonus.Location = new System.Drawing.Point(133, 253);
            this.SalesBonus.Margin = new System.Windows.Forms.Padding(4);
            this.SalesBonus.Name = "SalesBonus";
            this.SalesBonus.ReadOnly = true;
            this.SalesBonus.Size = new System.Drawing.Size(158, 22);
            this.SalesBonus.TabIndex = 17;
            this.SalesBonus.Tag = "textSpace";
            this.SalesBonus.Click += new System.EventHandler(this._textFields);
            this.SalesBonus.TextChanged += new System.EventHandler(this.SalesBonus_TextChanged);
            // 
            // Languages
            // 
            this.Languages.Controls.Add(this.frenchRadioButton);
            this.Languages.Controls.Add(this.englishRadioButton);
            this.Languages.Location = new System.Drawing.Point(156, 13);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(176, 68);
            this.Languages.TabIndex = 22;
            this.Languages.TabStop = false;
            this.Languages.Text = "Languages";
            this.Languages.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frenchRadioButton
            // 
            this.frenchRadioButton.AutoSize = true;
            this.frenchRadioButton.Location = new System.Drawing.Point(6, 48);
            this.frenchRadioButton.Name = "frenchRadioButton";
            this.frenchRadioButton.Size = new System.Drawing.Size(78, 20);
            this.frenchRadioButton.TabIndex = 28;
            this.frenchRadioButton.Text = "Français";
            this.frenchRadioButton.UseVisualStyleBackColor = true;
            this.frenchRadioButton.CheckedChanged += new System.EventHandler(this.changeLanguage);
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.Location = new System.Drawing.Point(6, 22);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(70, 20);
            this.englishRadioButton.TabIndex = 27;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            this.englishRadioButton.CheckedChanged += new System.EventHandler(this.changeLanguage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(356, 319);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalesBonus);
            this.Controls.Add(this.TotalSales);
            this.Controls.Add(this.NumberOfHours);
            this.Controls.Add(this.Bonus);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.nameOfEmployee);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Calculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this._Button_click);
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
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label nameOfEmployee;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.Label Sales;
        private System.Windows.Forms.Label Bonus;
        private System.Windows.Forms.TextBox NumberOfHours;
        private System.Windows.Forms.TextBox TotalSales;
        private System.Windows.Forms.TextBox SalesBonus;
        private System.Windows.Forms.GroupBox Languages;
        private System.Windows.Forms.RadioButton frenchRadioButton;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

