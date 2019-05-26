namespace Hello_World
{
    partial class HelloWorldForm
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
            this.displayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.displayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayButton.Location = new System.Drawing.Point(127, 62);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(117, 37);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "Display Message";
            this.displayButton.UseVisualStyleBackColor = false;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.displayButton);
            this.Name = "HelloWorldForm";
            this.Text = "Hello World";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayButton;
    }
}

