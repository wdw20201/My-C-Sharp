namespace Tickets
{
    partial class FrmTickets
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
            this.BtnTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTickets
            // 
            this.BtnTickets.Location = new System.Drawing.Point(53, 95);
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.Size = new System.Drawing.Size(175, 23);
            this.BtnTickets.TabIndex = 0;
            this.BtnTickets.Text = "Determine Tickets Price";
            this.BtnTickets.UseVisualStyleBackColor = true;
            this.BtnTickets.Click += new System.EventHandler(this.BtnTickets_Click);
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnTickets);
            this.Name = "FrmTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTickets;
    }
}

