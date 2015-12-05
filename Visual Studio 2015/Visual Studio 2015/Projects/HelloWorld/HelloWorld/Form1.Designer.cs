namespace HelloWorld
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
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "EnterFirstNumber";
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(623, 84);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(100, 31);
            this.Number1.TabIndex = 1;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(623, 280);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 31);
            this.Sum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(623, 173);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(100, 31);
            this.Number2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "EnterSecondNumber";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(860, 173);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 6;
            this.button.Text = "Sum";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 885);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button;
    }
}

