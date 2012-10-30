namespace Client
{
    partial class BenchUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.RuntimeBox = new System.Windows.Forms.TextBox();
            this.CpuBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Cpus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cpus Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(214, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "not yet difined";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(214, 79);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(332, 31);
            this.nameBox.TabIndex = 3;
            // 
            // RuntimeBox
            // 
            this.RuntimeBox.Location = new System.Drawing.Point(214, 134);
            this.RuntimeBox.Name = "RuntimeBox";
            this.RuntimeBox.Size = new System.Drawing.Size(332, 31);
            this.RuntimeBox.TabIndex = 4;
            // 
            // CpuBox
            // 
            this.CpuBox.Location = new System.Drawing.Point(214, 193);
            this.CpuBox.Name = "CpuBox";
            this.CpuBox.Size = new System.Drawing.Size(332, 31);
            this.CpuBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Owner Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expected Runtime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPU\'S Needed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Job Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Submit Job";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 26);
            this.label7.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(48, 374);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(696, 354);
            this.listBox1.TabIndex = 12;
            
            // 
            // BenchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 746);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CpuBox);
            this.Controls.Add(this.RuntimeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "BenchUI";
            this.Text = "BenchUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox RuntimeBox;
        private System.Windows.Forms.TextBox CpuBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
    }
}