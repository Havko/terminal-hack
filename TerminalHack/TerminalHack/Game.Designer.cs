namespace TerminalHack
{
    partial class GameForm
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
            this.btnBegin2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBegin2
            // 
            this.btnBegin2.BackColor = System.Drawing.Color.Black;
            this.btnBegin2.Location = new System.Drawing.Point(283, 40);
            this.btnBegin2.Name = "btnBegin2";
            this.btnBegin2.Size = new System.Drawing.Size(138, 23);
            this.btnBegin2.TabIndex = 0;
            this.btnBegin2.Text = "Begin Game";
            this.btnBegin2.UseVisualStyleBackColor = false;
            this.btnBegin2.Click += new System.EventHandler(this.btnBegin2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(782, 424);
            this.Controls.Add(this.btnBegin2);
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBegin2;
    }
}