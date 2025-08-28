using System.ComponentModel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System;
using System.IO;

namespace UI.NumerosAleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        class Empleado
        {
            public long Numero { get; set; }
            public string Nombre { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public int Sexo { get; set; }
            public long Sueldo { get; set; }
            public bool Seguro { get; set; }
            public int Grupo { get; set; }
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            //leer nombres y apellidos de archivos txt
            string nombresH = @"C:\Proyectos\EDAT\EDAT_JD25_P01\UI.NumerosAleatorios\NombresH.txt";
            string nombresM = @"C:\Proyectos\EDAT\EDAT_JD25_P01\UI.NumerosAleatorios\NombresM.txt";
            string apellidos = @"C:\Proyectos\EDAT\EDAT_JD25_P01\UI.NumerosAleatorios\Apellidos.txt";

            string[] Hombres = File.ReadAllLines(nombresH);
            string[] Mujeres = File.ReadAllLines(nombresM);
            string[] Apellidos = File.ReadAllLines(apellidos);


            //el random
            Random random = new Random();

       
            //numero aleatorio
            long Numero = random.NextInt64(1000000000, 9999999999);
         
            //fecha aleatoria
            DateTime fechaInicio = new DateTime(1945, 1, 1);
            DateTime fechaFin = new DateTime(2007, 8, 26);

            TimeSpan diferencia = fechaFin - fechaInicio;
            int diasTotales = (int)diferencia.TotalDays;

            int diasAleatorios = random.Next(diasTotales); 

            DateTime fecha = fechaInicio.AddDays(diasAleatorios);



            //sexo aleatorio
            RadioButton[] radioButtons = { radioButton1, radioButton2};


            int randomsex = random.Next(0, 2);

            //Nombre aleatorio(usando sexo ejeje )
            int tamañoH = Hombres.Length;
            int tamañoM = Mujeres.Length;
            int tamañoA = Apellidos.Length;
            string nombreemp;

            if (randomsex == 0)
            {
                int randomnombre = random.Next(0, Hombres.Length);
                int randomapellido1 = random.Next(0, Apellidos.Length);
                int randomapellido2 = random.Next(0, Apellidos.Length);
                nombreemp= Hombres[randomnombre] + " " + Apellidos[randomapellido1] + " " + Apellidos[randomapellido2];
                 
            }
            else
            {
                int randomnombre = random.Next(0, Mujeres.Length);
                int randomapellido1 = random.Next(0, Apellidos.Length);
                int randomapellido2 = random.Next(0, Apellidos.Length);
                nombreemp = Mujeres[randomnombre] + " " + Apellidos[randomapellido1] + " " + Apellidos[randomapellido2];
            }


            //sueldo aleatorio
            long sueldo = random.NextInt64(0, 99999);



            //seguro si no
            bool seguro = random.Next(2) == 0;

            //grupo aleatorio
            int randomgroup = random.Next(0, comboBox1.Items.Count);


            //relleanar empleado
            empleado.Numero = Numero;
            empleado.FechaNacimiento = fecha;
            empleado.Nombre = nombreemp;
            empleado.Sueldo = sueldo;
            empleado.Seguro = seguro;
            empleado.Sexo = randomsex;
            empleado.Grupo = randomgroup;



            //imprimir datos
            textBox1.Text = empleado.Numero.ToString();
            dateTimePicker1.Value = empleado.FechaNacimiento;
            textBox2.Text = empleado.Nombre;
            textBox3.Text = empleado.Sueldo.ToString();
            checkBox1.Checked = empleado.Seguro;
            radioButtons[empleado.Sexo].Checked = true;
            comboBox1.SelectedIndex = empleado.Grupo;
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
