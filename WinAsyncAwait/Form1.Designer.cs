namespace WinAsyncAwait
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
            btnIniciar = new Button();
            loadingGIF = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loadingGIF).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(70, 80);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(188, 50);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar proceso";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += IniciarAsync;
            // 
            // loadingGIF
            // 
            loadingGIF.Image = Properties.Resources.Loading_2;
            loadingGIF.Location = new Point(350, 138);
            loadingGIF.Name = "loadingGIF";
            loadingGIF.Size = new Size(194, 192);
            loadingGIF.TabIndex = 1;
            loadingGIF.TabStop = false;
            loadingGIF.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadingGIF);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)loadingGIF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private PictureBox loadingGIF;
    }
}
