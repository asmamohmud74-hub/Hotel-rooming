namespace Hotel_Rooming
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdostandred = new System.Windows.Forms.RadioButton();
            this.rdonormal = new System.Windows.Forms.RadioButton();
            this.rdoHigh = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstBookDetails = new System.Windows.Forms.ListBox();
            this.chkBreakfast = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "GuestName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "GuestAge:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Nights";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of guests";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(217, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(217, 195);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(170, 26);
            this.txtnumber.TabIndex = 7;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(217, 144);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(170, 26);
            this.txtNights.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(217, 98);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(187, 26);
            this.txtAge.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Room Type";
            // 
            // rdostandred
            // 
            this.rdostandred.AutoSize = true;
            this.rdostandred.Location = new System.Drawing.Point(27, 288);
            this.rdostandred.Name = "rdostandred";
            this.rdostandred.Size = new System.Drawing.Size(100, 24);
            this.rdostandred.TabIndex = 11;
            this.rdostandred.TabStop = true;
            this.rdostandred.Text = "Standred";
            this.rdostandred.UseVisualStyleBackColor = true;
            // 
            // rdonormal
            // 
            this.rdonormal.AutoSize = true;
            this.rdonormal.Location = new System.Drawing.Point(156, 288);
            this.rdonormal.Name = "rdonormal";
            this.rdonormal.Size = new System.Drawing.Size(84, 24);
            this.rdonormal.TabIndex = 12;
            this.rdonormal.TabStop = true;
            this.rdonormal.Text = "Normal";
            this.rdonormal.UseVisualStyleBackColor = true;
            // 
            // rdoHigh
            // 
            this.rdoHigh.AutoSize = true;
            this.rdoHigh.Location = new System.Drawing.Point(320, 288);
            this.rdoHigh.Name = "rdoHigh";
            this.rdoHigh.Size = new System.Drawing.Size(67, 24);
            this.rdoHigh.TabIndex = 13;
            this.rdoHigh.TabStop = true;
            this.rdoHigh.Text = "High";
            this.rdoHigh.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Additional Option";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(27, 420);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(132, 45);
            this.btncalculate.TabIndex = 15;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(370, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 43);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(217, 428);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 37);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lstBookDetails
            // 
            this.lstBookDetails.FormattingEnabled = true;
            this.lstBookDetails.ItemHeight = 20;
            this.lstBookDetails.Location = new System.Drawing.Point(609, 67);
            this.lstBookDetails.Name = "lstBookDetails";
            this.lstBookDetails.Size = new System.Drawing.Size(209, 364);
            this.lstBookDetails.TabIndex = 18;
            // 
            // chkBreakfast
            // 
            this.chkBreakfast.AutoSize = true;
            this.chkBreakfast.Location = new System.Drawing.Point(16, 379);
            this.chkBreakfast.Name = "chkBreakfast";
            this.chkBreakfast.Size = new System.Drawing.Size(269, 24);
            this.chkBreakfast.TabIndex = 19;
            this.chkBreakfast.Text = "Breakfast(10 per guest per night)";
            this.chkBreakfast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 561);
            this.Controls.Add(this.chkBreakfast);
            this.Controls.Add(this.lstBookDetails);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdoHigh);
            this.Controls.Add(this.rdonormal);
            this.Controls.Add(this.rdostandred);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hotel Rooming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdostandred;
        private System.Windows.Forms.RadioButton rdonormal;
        private System.Windows.Forms.RadioButton rdoHigh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstBookDetails;
        private System.Windows.Forms.CheckBox chkBreakfast;
    }
}

