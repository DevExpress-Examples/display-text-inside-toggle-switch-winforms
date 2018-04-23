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
            this.customToggle1 = new WindowsFormsApplication1.CustomToggle();
            ((System.ComponentModel.ISupportInitialize)(this.customToggle1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customToggle1
            // 
            this.customToggle1.Location = new System.Drawing.Point(149, 136);
            this.customToggle1.Name = "customToggle1";
            this.customToggle1.Properties.AllowThumbAnimation = false;
            this.customToggle1.Properties.OffText = "Off";
            this.customToggle1.Properties.OnText = "On";
            this.customToggle1.Size = new System.Drawing.Size(91, 24);
            this.customToggle1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 534);
            this.Controls.Add(this.customToggle1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.customToggle1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomToggle customToggle1;


    }
}

