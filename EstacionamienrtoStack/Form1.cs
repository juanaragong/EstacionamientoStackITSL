namespace EstacionamienrtoStack
{
    public partial class Form1 : Form
    {

        Stack<Automovil> automoviles = new Stack<Automovil>();
        
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvEstacionamiento.ColumnCount = 3;
            dgvEstacionamiento.Columns[0].Name = "Placas";
            dgvEstacionamiento.Columns[1].Name = "Propietario";
            dgvEstacionamiento.Columns[2].Name = "Color";

        }

        private void ActualizarGrid()
        {
            dgvEstacionamiento.Rows.Clear();
            foreach (var pila in automoviles)
            { 
              dgvEstacionamiento.Rows.Add(pila.Placas,pila.Propietario,pila.Color);
            }
        }


        private void LimpiarText()
        { 
           txtPlacas.Clear();
           txtPropietario.Clear();
           txtColor.Clear();
        }
        private void btnPush_Click(object sender, EventArgs e)
        {
            Automovil auto = new Automovil();
            auto.Placas = txtPlacas.Text;
            auto.Propietario = txtPropietario.Text;
            auto.Color = txtColor.Text;

            automoviles.Push(auto);
            MessageBox.Show("Auto insertado con exito");
            txtCount.Text=automoviles.Count().ToString();
            ActualizarGrid();
            LimpiarText();
          
        }

        private void btbPOP_Click(object sender, EventArgs e)
        {
            if (automoviles.Count > 0)
            {
                automoviles.Pop();
                MessageBox.Show("Auto retirado con exito");
                txtCount.Text = automoviles.Count().ToString();
                ActualizarGrid();
            }
            else
            {
                MessageBox.Show("!! Estacionamiento vacio !!", "ITSL - Practicas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (automoviles.Count == 0)
            {
                MessageBox.Show("No hay autos en el estacionamiento");
            }
            else
            {
                Automovil automovil = automoviles.Peek();
                MessageBox.Show("El último auto  apilado es: " + automovil.Placas + "\r\nPropietario: " + automovil.Placas + "\r\nY de color " + automovil.Color, "USO PILAS C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
