namespace RandomTextAndImages
{
    partial class cthuForm
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
            this.cthuText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cthuText
            // 
            this.cthuText.BackColor = System.Drawing.Color.Black;
            this.cthuText.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cthuText.ForeColor = System.Drawing.Color.ForestGreen;
            this.cthuText.Location = new System.Drawing.Point(-3, 0);
            this.cthuText.Multiline = true;
            this.cthuText.Name = "cthuText";
            this.cthuText.Size = new System.Drawing.Size(251, 840);
            this.cthuText.TabIndex = 0;
            // 
            // cthuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(246, 830);
            this.Controls.Add(this.cthuText);
            this.Name = "cthuForm";
            this.Text = "Translation...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cthuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cthuText;
    }
}