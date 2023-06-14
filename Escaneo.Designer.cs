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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escaneo));
            tipo = new Label();
            selector_tipo = new ComboBox();
            boton_seleccionar = new Button();
            boton_a_escanear = new Button();
            a_escanear = new Label();
            tabla = new ListView();
            duenio = new ColumnHeader();
            modelo = new ColumnHeader();
            kilometraje = new ColumnHeader();
            SuspendLayout();
            // 
            // tipo
            // 
            tipo.AutoSize = true;
            tipo.Location = new Point(327, 15);
            tipo.Margin = new Padding(4, 0, 4, 0);
            tipo.Name = "tipo";
            tipo.Size = new Size(192, 25);
            tipo.TabIndex = 0;
            tipo.Text = "Elija el tipo de vehiculo";
            // 
            // selector_tipo
            // 
            selector_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(327, 60);
            selector_tipo.Margin = new Padding(4, 5, 4, 5);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(171, 33);
            selector_tipo.TabIndex = 7;
            selector_tipo.SelectedIndexChanged += selector_tipo_SelectedIndexChanged;
            // 
            // boton_seleccionar
            // 
            boton_seleccionar.Location = new Point(359, 108);
            boton_seleccionar.Margin = new Padding(4, 5, 4, 5);
            boton_seleccionar.Name = "boton_seleccionar";
            boton_seleccionar.Size = new Size(107, 38);
            boton_seleccionar.TabIndex = 8;
            boton_seleccionar.Text = "Seleccionar";
            boton_seleccionar.UseVisualStyleBackColor = true;
            boton_seleccionar.Click += boton_seleccionar_Click;
            // 
            // boton_a_escanear
            // 
            boton_a_escanear.Location = new Point(359, 463);
            boton_a_escanear.Margin = new Padding(4, 5, 4, 5);
            boton_a_escanear.Name = "boton_a_escanear";
            boton_a_escanear.Size = new Size(107, 38);
            boton_a_escanear.TabIndex = 10;
            boton_a_escanear.Text = "Escanear";
            boton_a_escanear.UseVisualStyleBackColor = true;
            boton_a_escanear.Click += boton_a_escanear_Click;
            // 
            // a_escanear
            // 
            a_escanear.AutoSize = true;
            a_escanear.Location = new Point(301, 192);
            a_escanear.Margin = new Padding(4, 0, 4, 0);
            a_escanear.Name = "a_escanear";
            a_escanear.Size = new Size(217, 25);
            a_escanear.TabIndex = 11;
            a_escanear.Text = "Elija el vehiculo a escanear";
            // 
            // tabla
            // 
            tabla.Columns.AddRange(new ColumnHeader[] { duenio, modelo, kilometraje });
            tabla.Location = new Point(256, 249);
            tabla.Margin = new Padding(4, 5, 4, 5);
            tabla.Name = "tabla";
            tabla.Size = new Size(326, 159);
            tabla.TabIndex = 12;
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
            // Escaneo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 573);
            Controls.Add(tabla);
            Controls.Add(a_escanear);
            Controls.Add(boton_a_escanear);
            Controls.Add(boton_seleccionar);
            Controls.Add(selector_tipo);
            Controls.Add(tipo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Escaneo";
            Text = "Escaneo";
            Load += Escaneo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tipo;
        private ComboBox selector_tipo;
        private Button boton_seleccionar;
        private Button boton_a_escanear;
        private Label a_escanear;
        private ListView tabla;
        private ColumnHeader modelo;
        private ColumnHeader kilometraje;
        private ColumnHeader duenio;
    }
}