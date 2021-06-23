
namespace ImagenTexto
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
            this.txtMuestra = new System.Windows.Forms.TextBox();
            this.pcTarget = new System.Windows.Forms.PictureBox();
            this.btnLeer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMuestra
            // 
            this.txtMuestra.Location = new System.Drawing.Point(354, 47);
            this.txtMuestra.Multiline = true;
            this.txtMuestra.Name = "txtMuestra";
            this.txtMuestra.Size = new System.Drawing.Size(300, 438);
            this.txtMuestra.TabIndex = 1;
            // 
            // pcTarget
            // 
            this.pcTarget.Location = new System.Drawing.Point(12, 47);
            this.pcTarget.Name = "pcTarget";
            this.pcTarget.Size = new System.Drawing.Size(323, 438);
            this.pcTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcTarget.TabIndex = 2;
            this.pcTarget.TabStop = false;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(443, 491);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(117, 31);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 542);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.pcTarget);
            this.Controls.Add(this.txtMuestra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMuestra;
        private System.Windows.Forms.PictureBox pcTarget;
        private System.Windows.Forms.Button btnLeer;
    }
}

