namespace Morse_Code_Converter
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
            this.Input = new System.Windows.Forms.TextBox();
            this.CovertBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.OutputLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a string:";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(61, 81);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(354, 160);
            this.Input.TabIndex = 1;
            // 
            // CovertBTN
            // 
            this.CovertBTN.Location = new System.Drawing.Point(320, 440);
            this.CovertBTN.Name = "CovertBTN";
            this.CovertBTN.Size = new System.Drawing.Size(95, 29);
            this.CovertBTN.TabIndex = 3;
            this.CovertBTN.Text = "Convert";
            this.CovertBTN.UseVisualStyleBackColor = true;
            this.CovertBTN.Click += new System.EventHandler(this.CovertBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Location = new System.Drawing.Point(192, 440);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(95, 29);
            this.ExitBTN.TabIndex = 4;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // OutputLB
            // 
            this.OutputLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLB.Location = new System.Drawing.Point(61, 267);
            this.OutputLB.Name = "OutputLB";
            this.OutputLB.Size = new System.Drawing.Size(354, 115);
            this.OutputLB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 494);
            this.Controls.Add(this.OutputLB);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.CovertBTN);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button CovertBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label OutputLB;
    }
}

