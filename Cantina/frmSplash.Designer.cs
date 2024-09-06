
namespace Cantina
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctSplash = new System.Windows.Forms.PictureBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pgbSplah = new System.Windows.Forms.ProgressBar();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSplash
            // 
            this.pctSplash.Image = ((System.Drawing.Image)(resources.GetObject("pctSplash.Image")));
            this.pctSplash.Location = new System.Drawing.Point(255, 58);
            this.pctSplash.Name = "pctSplash";
            this.pctSplash.Size = new System.Drawing.Size(253, 210);
            this.pctSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSplash.TabIndex = 0;
            this.pctSplash.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(363, 300);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(18, 20);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "0";
            // 
            // pgbSplah
            // 
            this.pgbSplah.Location = new System.Drawing.Point(256, 337);
            this.pgbSplah.Name = "pgbSplah";
            this.pgbSplah.Size = new System.Drawing.Size(251, 22);
            this.pgbSplah.TabIndex = 2;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(383, 300);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(23, 20);
            this.lblPorcentagem.TabIndex = 3;
            this.lblPorcentagem.Text = "%";
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 2000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.pgbSplah);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pctSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantina - Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSplash;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ProgressBar pgbSplah;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Timer tmrSplash;
    }
}