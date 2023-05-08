namespace Buscador
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
            this.abrirArchivo = new System.Windows.Forms.Button();
            this.WindowLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.registroResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // abrirArchivo
            // 
            this.abrirArchivo.Location = new System.Drawing.Point(40, 31);
            this.abrirArchivo.Name = "abrirArchivo";
            this.abrirArchivo.Size = new System.Drawing.Size(132, 39);
            this.abrirArchivo.TabIndex = 0;
            this.abrirArchivo.Text = "Abrir Archivos";
            this.abrirArchivo.UseVisualStyleBackColor = true;
            this.abrirArchivo.Click += new System.EventHandler(this.abrirArchivo_Click);
            // 
            // WindowLoadFile
            // 
            this.WindowLoadFile.FileName = "WindowLoadFile";
            // 
            // registroResultados
            // 
            this.registroResultados.Location = new System.Drawing.Point(40, 94);
            this.registroResultados.Multiline = true;
            this.registroResultados.Name = "registroResultados";
            this.registroResultados.Size = new System.Drawing.Size(269, 217);
            this.registroResultados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registroResultados);
            this.Controls.Add(this.abrirArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button abrirArchivo;
        private OpenFileDialog WindowLoadFile;
        private TextBox registroResultados;
    }
}