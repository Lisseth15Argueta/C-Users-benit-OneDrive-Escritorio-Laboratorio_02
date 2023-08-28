using Laboratorio02.ProgramacionOrientadaEventos.Laboratorio2.Tarea2;

namespace Laboratorio02
{
    public partial class Form1 : Form
    {
        private List<Electrodomestico> electrodomesticos;
        private List<Cliente> clientes;
        private List<Venta> ventas;
        public Form1()
        {
            InitializeComponent();
            electrodomesticos = new List<Electrodomestico>();
            clientes = new List<Cliente>();
            ventas = new List<Venta>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarElectrodomesticos();
            CargarClientes();
            CargarVentas();
        }
        private void CargarElectrodomesticos()
        {
            listBoxElectrodomesticos.Items.Clear();

            foreach (Electrodomestico electrodomestico in electrodomesticos)
            {
                listBoxElectrodomesticos.Items.Add(electrodomestico.ToString());
            }

        }
        private void CargarClientes()
        {
            listBoxClientes.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                listBoxClientes.Items.Add(cliente.ToString());
            }
        }
        private void CargarVentas()
        {
            listBoxVentas.Items.Clear();

            foreach (Venta venta in ventas)
            {
                listBoxVentas.Items.Add(venta.ToString());
            }

        }
        private void buttonAgregarElectrodomestico_Click(object sender, EventArgs e)
        {

            Electrodomestico electrodomestico = new Electrodomestico(textBoxNombreElectrodomestico.Text, int.Parse(textBoxPrecioElectrodomestico.Text));

            electrodomesticos.Add(electrodomestico);
            CargarElectrodomesticos();
            textBoxNombreElectrodomestico.Text = string.Empty;
            textBoxPrecioElectrodomestico.Text = string.Empty;

        }
        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente(textBoxNombreCliente.Text);
            clientes.Add(cliente);
            CargarClientes();
            textBoxNombreCliente.Text = string.Empty;
        }

        private void buttonRealizarVenta_Click(object sender, EventArgs e)
        {
            Electrodomestico electrodomestico = electrodomesticos[listBoxElectrodomesticos.SelectedIndex];
            Cliente cliente = clientes[listBoxClientes.SelectedIndex];

            int precioVenta = int.Parse(textBoxPrecioVenta.Text);

            int cantidad = int.Parse(textBoxCantidad.Text);

            Venta venta = new Venta(electrodomestico, precioVenta, cantidad, cliente);

            ventas.Add(venta);

            CargarVentas();

            textBoxPrecioVenta.Text = string.Empty;
            textBoxCantidad.Text = string.Empty;
        }

        private void buttonEliminarElectrodomestico_Click(object sender, EventArgs e)
        {
            Electrodomestico electrodomestico = electrodomesticos[listBoxElectrodomesticos.SelectedIndex];

            electrodomesticos.Remove(electrodomestico);

            CargarElectrodomesticos();
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = clientes[listBoxClientes.SelectedIndex];

            clientes.Remove(cliente);

            CargarClientes();
        }

        private void buttonEliminarVenta_Click(object sender, EventArgs e)
        {
            Venta venta = ventas[listBoxVentas.SelectedIndex];

            ventas.Remove(venta);

            CargarVentas();
        }
    }
}