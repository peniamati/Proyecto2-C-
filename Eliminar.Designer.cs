namespace Proyecto2
{
    partial class Eliminar
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
            eliminar_vehiculo = new Label();
            selector_tipo = new ComboBox();
            dataGridView2 = new DataGridView();
            boton_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // eliminar_vehiculo
            // 
            eliminar_vehiculo.AutoSize = true;
            eliminar_vehiculo.Location = new Point(190, 27);
            eliminar_vehiculo.Name = "eliminar_vehiculo";
            eliminar_vehiculo.Size = new Size(115, 15);
            eliminar_vehiculo.TabIndex = 0;
            eliminar_vehiculo.Text = "Eliminar un vehiculo";
            // 
            // selector_tipo
            // 
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(190, 60);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(121, 23);
            selector_tipo.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(126, 136);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(240, 150);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // boton_eliminar
            // 
            boton_eliminar.Location = new Point(211, 331);
            boton_eliminar.Name = "boton_eliminar";
            boton_eliminar.Size = new Size(75, 23);
            boton_eliminar.TabIndex = 4;
            boton_eliminar.Text = "Eliminar";
            boton_eliminar.UseVisualStyleBackColor = true;
            boton_eliminar.Click += boton_eliminar_Click;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(boton_eliminar);
            Controls.Add(dataGridView2);
            Controls.Add(selector_tipo);
            Controls.Add(eliminar_vehiculo);
            Name = "Eliminar";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label eliminar_vehiculo;
        private ComboBox selector_tipo;
        private DataGridView dataGridView2;
        private Button boton_eliminar;
    }
}