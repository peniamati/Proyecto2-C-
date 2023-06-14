namespace Proyecto2
{
    partial class EscaneoResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscaneoResultado));
            escaneando = new Label();
            realizados = new Label();
            test_realizados = new Label();
            SuspendLayout();
            // 
            // escaneando
            // 
            escaneando.AutoSize = true;
            escaneando.Location = new Point(293, 50);
            escaneando.Margin = new Padding(4, 0, 4, 0);
            escaneando.Name = "escaneando";
            escaneando.Size = new Size(59, 25);
            escaneando.TabIndex = 0;
            escaneando.Text = "label1";
            // 
            // realizados
            // 
            realizados.AutoSize = true;
            realizados.Location = new Point(173, 127);
            realizados.Margin = new Padding(4, 0, 4, 0);
            realizados.Name = "realizados";
            realizados.Size = new Size(59, 25);
            realizados.TabIndex = 1;
            realizados.Text = "label1";
            // 
            // test_realizados
            // 
            test_realizados.AutoSize = true;
            test_realizados.Location = new Point(173, 212);
            test_realizados.Margin = new Padding(4, 0, 4, 0);
            test_realizados.Name = "test_realizados";
            test_realizados.Size = new Size(59, 25);
            test_realizados.TabIndex = 2;
            test_realizados.Text = "label1";
            // 
            // EscaneoResultado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 422);
            Controls.Add(test_realizados);
            Controls.Add(realizados);
            Controls.Add(escaneando);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "EscaneoResultado";
            Text = "Resultado";
            Load += EscaneoResultado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label escaneando;
        private Label realizados;
        private Label test_realizados;
    }
}