namespace Proyecto2
{
    partial class Escaneo
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
            escaneando = new Label();
            vehiculo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // escaneando
            // 
            escaneando.AutoSize = true;
            escaneando.Location = new Point(208, 22);
            escaneando.Name = "escaneando";
            escaneando.Size = new Size(118, 15);
            escaneando.TabIndex = 0;
            escaneando.Text = "Escaneando vehiculo";
            // 
            // vehiculo
            // 
            vehiculo.AutoSize = true;
            vehiculo.Location = new Point(356, 22);
            vehiculo.Name = "vehiculo";
            vehiculo.Size = new Size(38, 15);
            vehiculo.TabIndex = 1;
            vehiculo.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 62);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Se le realizaron";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 62);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "services";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 110);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 5;
            label4.Text = "Services realizados:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 110);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // Escaneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 179);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vehiculo);
            Controls.Add(escaneando);
            Name = "Escaneo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label escaneando;
        private Label vehiculo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}