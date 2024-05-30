namespace Archivos
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textoAMostrar = new TextBox();
            subir = new Button();
            guardar = new Button();
            SuspendLayout();
            // 
            // textoAMostrar
            // 
            textoAMostrar.Location = new Point(181, 132);
            textoAMostrar.Multiline = true;
            textoAMostrar.Name = "textoAMostrar";
            textoAMostrar.Size = new Size(439, 201);
            textoAMostrar.TabIndex = 0;
            textoAMostrar.TextChanged += textBox1_TextChanged;
            // 
            // subir
            // 
            subir.BackColor = Color.DodgerBlue;
            subir.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            subir.ForeColor = SystemColors.Control;
            subir.Location = new Point(181, 62);
            subir.Name = "subir";
            subir.Size = new Size(202, 64);
            subir.TabIndex = 1;
            subir.Text = "Leer";
            subir.UseVisualStyleBackColor = false;
            subir.Click += button1_Click;
            // 
            // guardar
            // 
            guardar.BackColor = Color.DodgerBlue;
            guardar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            guardar.ForeColor = SystemColors.Control;
            guardar.Location = new Point(418, 62);
            guardar.Name = "guardar";
            guardar.Size = new Size(202, 64);
            guardar.TabIndex = 2;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = false;
            guardar.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(guardar);
            Controls.Add(subir);
            Controls.Add(textoAMostrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textoAMostrar;
        private Button subir;
        private Button guardar;
    }
}
