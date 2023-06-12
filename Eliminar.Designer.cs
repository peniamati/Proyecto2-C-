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
            eliminar_vehiculo.Location = new Point(271, 45);
            eliminar_vehiculo.Margin = new Padding(4, 0, 4, 0);
            eliminar_vehiculo.Name = "eliminar_vehiculo";
            eliminar_vehiculo.Size = new Size(169, 25);
            eliminar_vehiculo.TabIndex = 0;
            eliminar_vehiculo.Text = "Eliminar un vehiculo";
            // 
            // selector_tipo
            // 
            selector_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(271, 100);
            selector_tipo.Margin = new Padding(4, 5, 4, 5);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(171, 33);
            selector_tipo.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(180, 227);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(343, 250);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // boton_eliminar
            // 
            boton_eliminar.Location = new Point(301, 552);
            boton_eliminar.Margin = new Padding(4, 5, 4, 5);
            boton_eliminar.Name = "boton_eliminar";
            boton_eliminar.Size = new Size(107, 38);
            boton_eliminar.TabIndex = 4;
            boton_eliminar.Text = "Eliminar";
            boton_eliminar.UseVisualStyleBackColor = true;
            boton_eliminar.Click += boton_eliminar_Click;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 750);
            Controls.Add(boton_eliminar);
            Controls.Add(dataGridView2);
            Controls.Add(selector_tipo);
            Controls.Add(eliminar_vehiculo);
            Margin = new Padding(4, 5, 4, 5);
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