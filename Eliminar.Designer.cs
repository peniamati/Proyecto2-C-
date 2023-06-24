namespace Proyecto2
{
    partial class Eliminar
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar));
            eliminar_vehiculo = new Label();
            selector_tipo = new ComboBox();
            boton_eliminar = new Button();
            tabla = new ListView();
            duenio = new ColumnHeader();
            modelo = new ColumnHeader();
            kilometraje = new ColumnHeader();
            boton_seleccionar = new Button();
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
            selector_tipo.SelectedIndexChanged += selector_tipo_SelectedIndexChanged;
            // 
            // boton_eliminar
            // 
            boton_eliminar.Location = new Point(294, 472);
            boton_eliminar.Margin = new Padding(4, 5, 4, 5);
            boton_eliminar.Name = "boton_eliminar";
            boton_eliminar.Size = new Size(107, 38);
            boton_eliminar.TabIndex = 4;
            boton_eliminar.Text = "Eliminar";
            boton_eliminar.UseVisualStyleBackColor = true;
            boton_eliminar.Click += boton_eliminar_Click;
            // 
            // tabla
            // 
            tabla.Columns.AddRange(new ColumnHeader[] { duenio, modelo, kilometraje });
            tabla.Location = new Point(147, 263);
            tabla.Margin = new Padding(4, 5, 4, 5);
            tabla.Name = "tabla";
            tabla.Size = new Size(433, 159);
            tabla.TabIndex = 5;
            tabla.UseCompatibleStateImageBehavior = false;
            tabla.View = View.Details;
            // 
            // duenio
            // 
            duenio.Text = "Dueño";
            duenio.Width = 100;
            // 
            // modelo
            // 
            modelo.Text = "Modelo";
            modelo.Width = 100;
            // 
            // kilometraje
            // 
            kilometraje.Text = "Kilometraje";
            kilometraje.Width = 100;
            // 
            // boton_seleccionar
            // 
            boton_seleccionar.Location = new Point(294, 173);
            boton_seleccionar.Margin = new Padding(4, 5, 4, 5);
            boton_seleccionar.Name = "boton_seleccionar";
            boton_seleccionar.Size = new Size(116, 38);
            boton_seleccionar.TabIndex = 6;
            boton_seleccionar.Text = "Seleccionar";
            boton_seleccionar.UseVisualStyleBackColor = true;
            boton_seleccionar.Click += boton_seleccionar_Click;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 562);
            Controls.Add(boton_seleccionar);
            Controls.Add(tabla);
            Controls.Add(boton_eliminar);
            Controls.Add(selector_tipo);
            Controls.Add(eliminar_vehiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Eliminar";
            Text = "Eliminar";
            Load += Eliminar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // componentes de la ventana eliminar
        private Label eliminar_vehiculo;
        private ComboBox selector_tipo;
        private Button boton_eliminar;
        private ListView tabla;
        private ColumnHeader duenio;
        private ColumnHeader modelo;
        private ColumnHeader kilometraje;
        private Button boton_seleccionar;
    }
}