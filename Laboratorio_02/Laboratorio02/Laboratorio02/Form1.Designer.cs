namespace Laboratorio02
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
            this.buttonEliminarElectrodomestico = new System.Windows.Forms.Button();
            this.buttonAgregarElectrodomestico = new System.Windows.Forms.Button();
            this.listBoxElectrodomesticos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminarVenta = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRealizarVenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxPrecioElectrodomestico = new System.Windows.Forms.TextBox();
            this.textBoxNombreElectrodomestico = new System.Windows.Forms.TextBox();
            this.listBoxVentas = new System.Windows.Forms.ListBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonEliminarElectrodomestico
            // 
            this.buttonEliminarElectrodomestico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminarElectrodomestico.Location = new System.Drawing.Point(-192, 352);
            this.buttonEliminarElectrodomestico.Name = "buttonEliminarElectrodomestico";
            this.buttonEliminarElectrodomestico.Size = new System.Drawing.Size(202, 67);
            this.buttonEliminarElectrodomestico.TabIndex = 31;
            this.buttonEliminarElectrodomestico.Text = "Eliminar Electrodomestico";
            this.buttonEliminarElectrodomestico.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarElectrodomestico
            // 
            this.buttonAgregarElectrodomestico.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregarElectrodomestico.Location = new System.Drawing.Point(-192, 31);
            this.buttonAgregarElectrodomestico.Name = "buttonAgregarElectrodomestico";
            this.buttonAgregarElectrodomestico.Size = new System.Drawing.Size(187, 96);
            this.buttonAgregarElectrodomestico.TabIndex = 29;
            this.buttonAgregarElectrodomestico.Text = "Agregar Electrodomestico";
            this.buttonAgregarElectrodomestico.UseVisualStyleBackColor = true;
            // 
            // listBoxElectrodomesticos
            // 
            this.listBoxElectrodomesticos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxElectrodomesticos.FormattingEnabled = true;
            this.listBoxElectrodomesticos.ItemHeight = 28;
            this.listBoxElectrodomesticos.Items.AddRange(new object[] {
            "Cafetera",
            "Tostador",
            "Plancha",
            "Licuadora"});
            this.listBoxElectrodomesticos.Location = new System.Drawing.Point(-192, 150);
            this.listBoxElectrodomesticos.Name = "listBoxElectrodomesticos";
            this.listBoxElectrodomesticos.Size = new System.Drawing.Size(148, 200);
            this.listBoxElectrodomesticos.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(193, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 28);
            this.label5.TabIndex = 50;
            this.label5.Text = "Precio de Electrodomestico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(657, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nombre Clientes\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1097, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1059, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 28);
            this.label2.TabIndex = 47;
            this.label2.Text = "Precio de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre Electrodomestico";
            // 
            // buttonEliminarVenta
            // 
            this.buttonEliminarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminarVenta.Location = new System.Drawing.Point(881, 227);
            this.buttonEliminarVenta.Name = "buttonEliminarVenta";
            this.buttonEliminarVenta.Size = new System.Drawing.Size(167, 47);
            this.buttonEliminarVenta.TabIndex = 45;
            this.buttonEliminarVenta.Text = "Eliminar Venta";
            this.buttonEliminarVenta.UseVisualStyleBackColor = true;
            this.buttonEliminarVenta.Click += new System.EventHandler(this.buttonEliminarVenta_Click);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminarCliente.Location = new System.Drawing.Point(458, 218);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(194, 44);
            this.buttonEliminarCliente.TabIndex = 44;
            this.buttonEliminarCliente.Text = "Eliminar Cliente";
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(39, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 67);
            this.button1.TabIndex = 43;
            this.button1.Text = "Eliminar Electrodomestico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonEliminarElectrodomestico_Click);
            // 
            // buttonRealizarVenta
            // 
            this.buttonRealizarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRealizarVenta.Location = new System.Drawing.Point(1059, 252);
            this.buttonRealizarVenta.Name = "buttonRealizarVenta";
            this.buttonRealizarVenta.Size = new System.Drawing.Size(164, 54);
            this.buttonRealizarVenta.TabIndex = 42;
            this.buttonRealizarVenta.Text = "Realizar Venta";
            this.buttonRealizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRealizarVenta.UseVisualStyleBackColor = true;
            this.buttonRealizarVenta.Click += new System.EventHandler(this.buttonRealizarVenta_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(39, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 96);
            this.button2.TabIndex = 41;
            this.button2.Text = "Agregar Electrodomestico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonAgregarElectrodomestico_Click);
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregarCliente.Location = new System.Drawing.Point(668, 150);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(102, 52);
            this.buttonAgregarCliente.TabIndex = 40;
            this.buttonAgregarCliente.Text = "Cliente";
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.buttonAgregarCliente_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(1088, 217);
            this.textBoxCantidad.Multiline = true;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(125, 27);
            this.textBoxCantidad.TabIndex = 39;
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(1088, 100);
            this.textBoxPrecioVenta.Multiline = true;
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(125, 27);
            this.textBoxPrecioVenta.TabIndex = 38;
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(668, 100);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(125, 27);
            this.textBoxNombreCliente.TabIndex = 37;
            // 
            // textBoxPrecioElectrodomestico
            // 
            this.textBoxPrecioElectrodomestico.Location = new System.Drawing.Point(219, 319);
            this.textBoxPrecioElectrodomestico.Name = "textBoxPrecioElectrodomestico";
            this.textBoxPrecioElectrodomestico.Size = new System.Drawing.Size(125, 27);
            this.textBoxPrecioElectrodomestico.TabIndex = 36;
            // 
            // textBoxNombreElectrodomestico
            // 
            this.textBoxNombreElectrodomestico.Location = new System.Drawing.Point(233, 217);
            this.textBoxNombreElectrodomestico.Name = "textBoxNombreElectrodomestico";
            this.textBoxNombreElectrodomestico.Size = new System.Drawing.Size(125, 27);
            this.textBoxNombreElectrodomestico.TabIndex = 35;
            // 
            // listBoxVentas
            // 
            this.listBoxVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxVentas.FormattingEnabled = true;
            this.listBoxVentas.ItemHeight = 28;
            this.listBoxVentas.Items.AddRange(new object[] {
            "$15.99",
            "$17.99",
            "$19.99",
            "$24.99"});
            this.listBoxVentas.Location = new System.Drawing.Point(881, 58);
            this.listBoxVentas.Name = "listBoxVentas";
            this.listBoxVentas.Size = new System.Drawing.Size(145, 144);
            this.listBoxVentas.TabIndex = 34;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 28;
            this.listBoxClientes.Items.AddRange(new object[] {
            "Juan Perez",
            "Vanessa Ramos",
            "Lucia Guevara",
            "Veronica Fuentes"});
            this.listBoxClientes.Location = new System.Drawing.Point(467, 53);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(172, 144);
            this.listBoxClientes.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Items.AddRange(new object[] {
            "Cafetera",
            "Tostador",
            "Plancha",
            "Licuadora"});
            this.listBox1.Location = new System.Drawing.Point(39, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 200);
            this.listBox1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminarVenta);
            this.Controls.Add(this.buttonEliminarCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRealizarVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAgregarCliente);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecioVenta);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.textBoxPrecioElectrodomestico);
            this.Controls.Add(this.textBoxNombreElectrodomestico);
            this.Controls.Add(this.listBoxVentas);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonEliminarElectrodomestico);
            this.Controls.Add(this.buttonAgregarElectrodomestico);
            this.Controls.Add(this.listBoxElectrodomesticos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonEliminarElectrodomestico;
        private Button buttonAgregarElectrodomestico;
        private ListBox listBoxElectrodomesticos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonEliminarVenta;
        private Button buttonEliminarCliente;
        private Button button1;
        private Button buttonRealizarVenta;
        private Button button2;
        private Button buttonAgregarCliente;
        private TextBox textBoxCantidad;
        private TextBox textBoxPrecioVenta;
        private TextBox textBoxNombreCliente;
        private TextBox textBoxPrecioElectrodomestico;
        private TextBox textBoxNombreElectrodomestico;
        private ListBox listBoxVentas;
        private ListBox listBoxClientes;
        private ListBox listBox1;
    }
}