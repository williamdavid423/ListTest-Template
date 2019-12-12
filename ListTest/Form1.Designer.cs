namespace ListTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayButton = new System.Windows.Forms.Button();
            this.originalOutput = new System.Windows.Forms.Label();
            this.sortOutput = new System.Windows.Forms.Label();
            this.reverseOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(33, 80);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(339, 32);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // originalOutput
            // 
            this.originalOutput.BackColor = System.Drawing.Color.White;
            this.originalOutput.Location = new System.Drawing.Point(30, 124);
            this.originalOutput.Name = "originalOutput";
            this.originalOutput.Size = new System.Drawing.Size(91, 175);
            this.originalOutput.TabIndex = 1;
            // 
            // sortOutput
            // 
            this.sortOutput.BackColor = System.Drawing.Color.White;
            this.sortOutput.Location = new System.Drawing.Point(153, 124);
            this.sortOutput.Name = "sortOutput";
            this.sortOutput.Size = new System.Drawing.Size(91, 175);
            this.sortOutput.TabIndex = 2;
            // 
            // reverseOutput
            // 
            this.reverseOutput.BackColor = System.Drawing.Color.White;
            this.reverseOutput.Location = new System.Drawing.Point(281, 124);
            this.reverseOutput.Name = "reverseOutput";
            this.reverseOutput.Size = new System.Drawing.Size(91, 175);
            this.reverseOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a Name:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(115, 29);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(191, 20);
            this.inputBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(312, 23);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(58, 31);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(411, 323);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reverseOutput);
            this.Controls.Add(this.sortOutput);
            this.Controls.Add(this.originalOutput);
            this.Controls.Add(this.displayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "List Examples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label originalOutput;
        private System.Windows.Forms.Label sortOutput;
        private System.Windows.Forms.Label reverseOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button addButton;
    }
}

