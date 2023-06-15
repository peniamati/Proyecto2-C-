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
            tipo.Location = new Point(229, 9);
            tipo.Name = "tipo";
            tipo.Size = new Size(128, 15);
            tipo.TabIndex = 0;
            tipo.Text = "Elija el tipo de vehiculo";
            // 
            // selector_tipo
            // 
            selector_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            selector_tipo.FormattingEnabled = true;
            selector_tipo.Location = new Point(229, 36);
            selector_tipo.Name = "selector_tipo";
            selector_tipo.Size = new Size(121, 23);
            selector_tipo.TabIndex = 7;
            selector_tipo.SelectedIndexChanged += selector_tipo_SelectedIndexChanged;
            // 
            // boton_seleccionar
            // 
            boton_seleccionar.Location = new Point(251, 65);
            boton_seleccionar.Name = "boton_seleccionar";
            boton_seleccionar.Size = new Size(75, 23);
            boton_seleccionar.TabIndex = 8;
            boton_seleccionar.Text = "Seleccionar";
            boton_seleccionar.UseVisualStyleBackColor = true;
            boton_seleccionar.Click += boton_seleccionar_Click;
            // 
            // boton_a_escanear
            // 
            boton_a_escanear.Location = new Point(251, 278);
            boton_a_escanear.Name = "boton_a_escanear";
            boton_a_escanear.Size = new Size(75, 23);
            boton_a_escanear.TabIndex = 10;
            boton_a_escanear.Text = "Escanear";
            boton_a_escanear.UseVisualStyleBackColor = true;
            boton_a_escanear.Click += boton_a_escanear_Click;
            // 
            // a_escanear
            // 
            a_escanear.AutoSize = true;
            a_escanear.Location = new Point(211, 115);
            a_escanear.Name = "a_escanear";
            a_escanear.Size = new Size(146, 15);
            a_escanear.TabIndex = 11;
            a_escanear.Text = "Elija el vehiculo a escanear";
            // 
            // tabla
            // 
            tabla.Columns.AddRange(new ColumnHeader[] { duenio, modelo, kilometraje });
            tabla.Location = new Point(138, 152);
            tabla.Name = "tabla";
            tabla.Size = new Size(307, 97);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 344);
            Controls.Add(tabla);
            Controls.Add(a_escanear);
            Controls.Add(boton_a_escanear);
            Controls.Add(boton_seleccionar);
            Controls.Add(selector_tipo);
            Controls.Add(tipo);
            Icon = (Icon)resources.GetObject("$this.Icon");
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