
namespace SchoolHRA_EMPLOY
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
            this.lab_Count = new System.Windows.Forms.Label();
            this.lab_Salary = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear_employe = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comb_Type = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.Add_employe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_count = new System.Windows.Forms.Label();
            this.Tot_sal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Count
            // 
            this.lab_Count.AutoSize = true;
            this.lab_Count.Location = new System.Drawing.Point(54, 412);
            this.lab_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Count.Name = "lab_Count";
            this.lab_Count.Size = new System.Drawing.Size(157, 20);
            this.lab_Count.TabIndex = 7;
            this.lab_Count.Text = "EMployee Count :";
            // 
            // lab_Salary
            // 
            this.lab_Salary.AutoSize = true;
            this.lab_Salary.Location = new System.Drawing.Point(54, 471);
            this.lab_Salary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Salary.Name = "lab_Salary";
            this.lab_Salary.Size = new System.Drawing.Size(138, 20);
            this.lab_Salary.TabIndex = 8;
            this.lab_Salary.Text = "Total Salaries :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear_employe);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comb_Type);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.Add_employe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1067, 287);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMployee Information";
            // 
            // Clear_employe
            // 
            this.Clear_employe.Location = new System.Drawing.Point(937, 206);
            this.Clear_employe.Margin = new System.Windows.Forms.Padding(4);
            this.Clear_employe.Name = "Clear_employe";
            this.Clear_employe.Size = new System.Drawing.Size(103, 52);
            this.Clear_employe.TabIndex = 22;
            this.Clear_employe.Text = "Clear";
            this.Clear_employe.UseVisualStyleBackColor = true;
            this.Clear_employe.Click += new System.EventHandler(this.Clear_employe_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(210, 105);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(430, 27);
            this.txt_name.TabIndex = 21;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(210, 177);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(4);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(212, 27);
            this.txt_salary.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "EMployee_salary :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "EMployee_Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "EMployee_name :";
            // 
            // comb_Type
            // 
            this.comb_Type.FormattingEnabled = true;
            this.comb_Type.Location = new System.Drawing.Point(210, 140);
            this.comb_Type.Margin = new System.Windows.Forms.Padding(4);
            this.comb_Type.Name = "comb_Type";
            this.comb_Type.Size = new System.Drawing.Size(333, 28);
            this.comb_Type.TabIndex = 16;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(210, 61);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(212, 27);
            this.txt_ID.TabIndex = 15;
            // 
            // Add_employe
            // 
            this.Add_employe.Location = new System.Drawing.Point(765, 207);
            this.Add_employe.Margin = new System.Windows.Forms.Padding(4);
            this.Add_employe.Name = "Add_employe";
            this.Add_employe.Size = new System.Drawing.Size(103, 49);
            this.Add_employe.TabIndex = 14;
            this.Add_employe.Text = "Add";
            this.Add_employe.UseVisualStyleBackColor = true;
            this.Add_employe.Click += new System.EventHandler(this.Add_employe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "EMployee_ID :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(17, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 82);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(406, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 38);
            this.label7.TabIndex = 13;
            this.label7.Text = "Add EMployee";
            // 
            // emp_count
            // 
            this.emp_count.AutoSize = true;
            this.emp_count.Location = new System.Drawing.Point(272, 414);
            this.emp_count.Name = "emp_count";
            this.emp_count.Size = new System.Drawing.Size(19, 20);
            this.emp_count.TabIndex = 13;
            this.emp_count.Text = "0";
            // 
            // Tot_sal
            // 
            this.Tot_sal.AutoSize = true;
            this.Tot_sal.Location = new System.Drawing.Point(266, 469);
            this.Tot_sal.Name = "Tot_sal";
            this.Tot_sal.Size = new System.Drawing.Size(29, 20);
            this.Tot_sal.TabIndex = 14;
            this.Tot_sal.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.Tot_sal);
            this.Controls.Add(this.emp_count);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_Salary);
            this.Controls.Add(this.lab_Count);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_Count;
        private System.Windows.Forms.Label lab_Salary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Clear_employe;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comb_Type;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button Add_employe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label emp_count;
        private System.Windows.Forms.Label Tot_sal;
    }
}

