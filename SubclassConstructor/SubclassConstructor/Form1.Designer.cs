namespace SubclassConstructor
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
            this.baseClassButton = new System.Windows.Forms.Button();
            this.subclassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // baseClassButton
            // 
            this.baseClassButton.Location = new System.Drawing.Point(39, 34);
            this.baseClassButton.Name = "baseClassButton";
            this.baseClassButton.Size = new System.Drawing.Size(199, 57);
            this.baseClassButton.TabIndex = 0;
            this.baseClassButton.Text = "Base Class";
            this.baseClassButton.UseVisualStyleBackColor = true;
            this.baseClassButton.Click += new System.EventHandler(this.baseClassButton_Click);
            // 
            // subclassButton
            // 
            this.subclassButton.Location = new System.Drawing.Point(41, 126);
            this.subclassButton.Name = "subclassButton";
            this.subclassButton.Size = new System.Drawing.Size(196, 58);
            this.subclassButton.TabIndex = 1;
            this.subclassButton.Text = "Subclass";
            this.subclassButton.UseVisualStyleBackColor = true;
            this.subclassButton.Click += new System.EventHandler(this.subclassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Controls.Add(this.subclassButton);
            this.Controls.Add(this.baseClassButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baseClassButton;
        private System.Windows.Forms.Button subclassButton;
    }
}

