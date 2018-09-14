namespace Formative_LOGO
{
    partial class PG
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
            this.kkk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kkk
            // 
            this.kkk.BackColor = System.Drawing.Color.Yellow;
            this.kkk.Font = new System.Drawing.Font("OCR A Std", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kkk.Location = new System.Drawing.Point(313, 157);
            this.kkk.Name = "kkk";
            this.kkk.Size = new System.Drawing.Size(194, 73);
            this.kkk.TabIndex = 0;
            this.kkk.Text = "PLAY GAME";
            this.kkk.UseVisualStyleBackColor = false;
            this.kkk.Click += new System.EventHandler(this.Form1_Click);
            // 
            // PG
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(832, 382);
            this.Controls.Add(this.kkk);
            this.Name = "PG";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button kkk;
    }
}

