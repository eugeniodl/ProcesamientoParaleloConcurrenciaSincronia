namespace WinAsyncAwait
{
    partial class FrmAsyncAwait
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pbLoadingGIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIniciar.Location = new System.Drawing.Point(35, 61);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(200, 59);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar proceso";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.IniciarProcesoAsync);
            // 
            // pbLoadingGIF
            // 
            this.pbLoadingGIF.Image = global::WinAsyncAwait.Properties.Resources.loading_gif;
            this.pbLoadingGIF.Location = new System.Drawing.Point(35, 140);
            this.pbLoadingGIF.Name = "pbLoadingGIF";
            this.pbLoadingGIF.Size = new System.Drawing.Size(200, 196);
            this.pbLoadingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingGIF.TabIndex = 1;
            this.pbLoadingGIF.TabStop = false;
            this.pbLoadingGIF.Visible = false;
            // 
            // FrmAsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 395);
            this.Controls.Add(this.pbLoadingGIF);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FrmAsyncAwait";
            this.Text = "FrmAsyncAwait";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIniciar;
        private PictureBox pbLoadingGIF;
    }
}