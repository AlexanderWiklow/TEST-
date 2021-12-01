
namespace Bolåneberäkning
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoan = new System.Windows.Forms.ComboBox();
            this.lstLoptid = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMonthTot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonthPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonthInterest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInterest = new System.Windows.Forms.ComboBox();
            this.cmbCalculate = new System.Windows.Forms.Button();
            this.cmbAvsluta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLoan);
            this.groupBox1.Controls.Add(this.lstLoptid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(78, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 733);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indata";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 678);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Välj lånebelopp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ange räntesats bolån";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbLoan
            // 
            this.cmbLoan.FormattingEnabled = true;
            this.cmbLoan.Location = new System.Drawing.Point(30, 612);
            this.cmbLoan.Name = "cmbLoan";
            this.cmbLoan.Size = new System.Drawing.Size(182, 33);
            this.cmbLoan.TabIndex = 3;
            // 
            // lstLoptid
            // 
            this.lstLoptid.FormattingEnabled = true;
            this.lstLoptid.ItemHeight = 25;
            this.lstLoptid.Location = new System.Drawing.Point(30, 89);
            this.lstLoptid.Name = "lstLoptid";
            this.lstLoptid.Size = new System.Drawing.Size(320, 329);
            this.lstLoptid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välj löptid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.txtMonthTot);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMonthPayment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMonthInterest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(504, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 733);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utdata";
            // 
            // txtMonthTot
            // 
            this.txtMonthTot.Location = new System.Drawing.Point(36, 365);
            this.txtMonthTot.Name = "txtMonthTot";
            this.txtMonthTot.Size = new System.Drawing.Size(305, 31);
            this.txtMonthTot.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total månadskostnad";
            // 
            // txtMonthPayment
            // 
            this.txtMonthPayment.Location = new System.Drawing.Point(37, 221);
            this.txtMonthPayment.Name = "txtMonthPayment";
            this.txtMonthPayment.Size = new System.Drawing.Size(305, 31);
            this.txtMonthPayment.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Månadsamortering";
            // 
            // txtMonthInterest
            // 
            this.txtMonthInterest.Location = new System.Drawing.Point(37, 88);
            this.txtMonthInterest.Name = "txtMonthInterest";
            this.txtMonthInterest.Size = new System.Drawing.Size(305, 31);
            this.txtMonthInterest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Månadsränta";
            // 
            // cmbInterest
            // 
            this.cmbInterest.FormattingEnabled = true;
            this.cmbInterest.Location = new System.Drawing.Point(108, 517);
            this.cmbInterest.Name = "cmbInterest";
            this.cmbInterest.Size = new System.Drawing.Size(182, 33);
            this.cmbInterest.TabIndex = 2;
            // 
            // cmbCalculate
            // 
            this.cmbCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCalculate.Location = new System.Drawing.Point(233, 833);
            this.cmbCalculate.Name = "cmbCalculate";
            this.cmbCalculate.Size = new System.Drawing.Size(221, 60);
            this.cmbCalculate.TabIndex = 3;
            this.cmbCalculate.Text = "Beräkna bolån";
            this.cmbCalculate.UseVisualStyleBackColor = false;
            this.cmbCalculate.Click += new System.EventHandler(this.cmbCalculate_Click);
            // 
            // cmbAvsluta
            // 
            this.cmbAvsluta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbAvsluta.Location = new System.Drawing.Point(504, 833);
            this.cmbAvsluta.Name = "cmbAvsluta";
            this.cmbAvsluta.Size = new System.Drawing.Size(221, 60);
            this.cmbAvsluta.TabIndex = 4;
            this.cmbAvsluta.Text = "Avsluta";
            this.cmbAvsluta.UseVisualStyleBackColor = false;
            this.cmbAvsluta.Click += new System.EventHandler(this.cmbAvsluta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1008, 956);
            this.Controls.Add(this.cmbAvsluta);
            this.Controls.Add(this.cmbCalculate);
            this.Controls.Add(this.cmbInterest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bolån";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoan;
        private System.Windows.Forms.ListBox lstLoptid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbInterest;
        private System.Windows.Forms.Button cmbCalculate;
        private System.Windows.Forms.Button cmbAvsluta;
        private System.Windows.Forms.TextBox txtMonthInterest;
        private System.Windows.Forms.TextBox txtMonthTot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthPayment;
        private System.Windows.Forms.Label label5;
    }
}

