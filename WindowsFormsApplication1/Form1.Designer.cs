namespace WindowsFormsApplication1
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
            this.num1txt = new System.Windows.Forms.TextBox();
            this.num2txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ansTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num1txt
            // 
            this.num1txt.Location = new System.Drawing.Point(123, 61);
            this.num1txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num1txt.Name = "num1txt";
            this.num1txt.Size = new System.Drawing.Size(101, 20);
            this.num1txt.TabIndex = 0;
            // 
            // num2txt
            // 
            this.num2txt.Location = new System.Drawing.Point(343, 61);
            this.num2txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num2txt.Name = "num2txt";
            this.num2txt.Size = new System.Drawing.Size(101, 20);
            this.num2txt.TabIndex = 1;
            this.num2txt.TextChanged += new System.EventHandler(this.num2txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MultiplyButton);
            this.groupBox1.Controls.Add(this.DivideButton);
            this.groupBox1.Controls.Add(this.SubtractButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(123, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(320, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(33, 92);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(107, 35);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(182, 92);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(105, 35);
            this.DivideButton.TabIndex = 2;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(182, 39);
            this.SubtractButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(105, 37);
            this.SubtractButton.TabIndex = 1;
            this.SubtractButton.Text = "Subtract";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(33, 39);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(107, 37);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ansTxt
            // 
            this.ansTxt.Location = new System.Drawing.Point(123, 290);
            this.ansTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ansTxt.Name = "ansTxt";
            this.ansTxt.Size = new System.Drawing.Size(101, 20);
            this.ansTxt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 358);
            this.Controls.Add(this.ansTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num2txt);
            this.Controls.Add(this.num1txt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1txt;
        private System.Windows.Forms.TextBox num2txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ansTxt;
    }
}

