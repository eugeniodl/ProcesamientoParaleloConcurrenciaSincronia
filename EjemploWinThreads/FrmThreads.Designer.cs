namespace EjemploWinThreads
{
    partial class FrmThreads
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
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 103);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(115, 64);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(160, 43);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(347, 43);
            this.pb1.TabIndex = 1;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(160, 114);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(347, 43);
            this.pb2.TabIndex = 2;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(160, 185);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(347, 43);
            this.pb3.TabIndex = 3;
            // 
            // FrmThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 260);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "FrmThreads";
            this.Text = "FrmThreads";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIniciar;
        private ProgressBar pb1;
        private ProgressBar pb2;
        private ProgressBar pb3;
    }
}