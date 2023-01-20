namespace Shaper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRec = new System.Windows.Forms.Button();
            this.btnTrg = new System.Windows.Forms.Button();
            this.btnCrc = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRec
            // 
            this.btnRec.Location = new System.Drawing.Point(12, 12);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(94, 29);
            this.btnRec.TabIndex = 0;
            this.btnRec.Text = "Rectangle";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnTrg
            // 
            this.btnTrg.Location = new System.Drawing.Point(123, 12);
            this.btnTrg.Name = "btnTrg";
            this.btnTrg.Size = new System.Drawing.Size(94, 29);
            this.btnTrg.TabIndex = 1;
            this.btnTrg.Text = "Triangle";
            this.btnTrg.UseVisualStyleBackColor = true;
            this.btnTrg.Click += new System.EventHandler(this.btnTrg_Click);
            // 
            // btnCrc
            // 
            this.btnCrc.Location = new System.Drawing.Point(234, 12);
            this.btnCrc.Name = "btnCrc";
            this.btnCrc.Size = new System.Drawing.Size(94, 29);
            this.btnCrc.TabIndex = 2;
            this.btnCrc.Text = "Circle";
            this.btnCrc.UseVisualStyleBackColor = true;
            this.btnCrc.Click += new System.EventHandler(this.btnCrc_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStop.Location = new System.Drawing.Point(694, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 39);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(745, 393);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 45);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCrc);
            this.Controls.Add(this.btnTrg);
            this.Controls.Add(this.btnRec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRec;
        private Button btnTrg;
        private Button btnCrc;
        private Button btnStop;
        private Button btnHelp;
    }
}
