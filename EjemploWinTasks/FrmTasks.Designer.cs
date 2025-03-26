namespace EjemploWinTasks
{
    partial class FrmTasks
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
            btnIniciar = new Button();
            pb1 = new ProgressBar();
            pb2 = new ProgressBar();
            pb3 = new ProgressBar();
            pb4 = new ProgressBar();
            txtConteo1 = new TextBox();
            txtConteo2 = new TextBox();
            txtConteo3 = new TextBox();
            txtConteo4 = new TextBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(38, 31);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(99, 36);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pb1
            // 
            pb1.Location = new Point(38, 98);
            pb1.Name = "pb1";
            pb1.Size = new Size(100, 23);
            pb1.TabIndex = 1;
            // 
            // pb2
            // 
            pb2.Location = new Point(163, 98);
            pb2.Name = "pb2";
            pb2.Size = new Size(100, 23);
            pb2.TabIndex = 2;
            // 
            // pb3
            // 
            pb3.Location = new Point(284, 98);
            pb3.Name = "pb3";
            pb3.Size = new Size(100, 23);
            pb3.TabIndex = 3;
            // 
            // pb4
            // 
            pb4.Location = new Point(413, 98);
            pb4.Name = "pb4";
            pb4.Size = new Size(100, 23);
            pb4.TabIndex = 4;
            // 
            // txtConteo1
            // 
            txtConteo1.Location = new Point(37, 138);
            txtConteo1.Multiline = true;
            txtConteo1.Name = "txtConteo1";
            txtConteo1.Size = new Size(100, 250);
            txtConteo1.TabIndex = 5;
            // 
            // txtConteo2
            // 
            txtConteo2.Location = new Point(163, 138);
            txtConteo2.Multiline = true;
            txtConteo2.Name = "txtConteo2";
            txtConteo2.Size = new Size(100, 250);
            txtConteo2.TabIndex = 6;
            // 
            // txtConteo3
            // 
            txtConteo3.Location = new Point(284, 138);
            txtConteo3.Multiline = true;
            txtConteo3.Name = "txtConteo3";
            txtConteo3.Size = new Size(100, 250);
            txtConteo3.TabIndex = 7;
            // 
            // txtConteo4
            // 
            txtConteo4.Location = new Point(413, 138);
            txtConteo4.Multiline = true;
            txtConteo4.Name = "txtConteo4";
            txtConteo4.Size = new Size(100, 250);
            txtConteo4.TabIndex = 8;
            // 
            // FrmTasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 440);
            Controls.Add(txtConteo4);
            Controls.Add(txtConteo3);
            Controls.Add(txtConteo2);
            Controls.Add(txtConteo1);
            Controls.Add(pb4);
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(btnIniciar);
            Name = "FrmTasks";
            Text = "FrmTasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private ProgressBar pb1;
        private ProgressBar pb2;
        private ProgressBar pb3;
        private ProgressBar pb4;
        private TextBox txtConteo1;
        private TextBox txtConteo2;
        private TextBox txtConteo3;
        private TextBox txtConteo4;
    }
}