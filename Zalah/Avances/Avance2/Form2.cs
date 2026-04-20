using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Zalah
{
    public partial class Form2 : Form
    {
        static string conexionstring = "server=(localdb)\\ProjectModels; Database=ZalahDataB; integrated security=true";
        private SqlConnection conexion = new SqlConnection(conexionstring);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void CodAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexión a la base de datos: " + conexion.Database + " ha sido exitosa");
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("Se ha desconectado correctamente de la base de datos: " + conexion.Database);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "")
            {
                string consultacompleta = "SELECT * FROM Clientes";
                SqlCommand comando = new SqlCommand(consultacompleta, conexion);
                SqlDataAdapter datos = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dvgconsulta.DataSource = tabla;
            }
            else
            {
                string consultacompleta = "SELECT * FROM Clientes WHERE membresia = '" + txtConsulta.Text + "'";
                SqlCommand comando = new SqlCommand(consultacompleta, conexion);
                SqlDataAdapter datos = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dvgconsulta.DataSource = tabla;
            }
        }

        public void consulta()
        {
            string consultacompleta = "SELECT * FROM Clientes";
            SqlCommand comando = new SqlCommand(consultacompleta, conexion);
            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            dvgconsulta.DataSource = tabla;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cadena = "INSERT INTO Clientes (id, nombre, membresia, telefono, direccion, id_compra) " +
                "VALUES ('" + txtId.Text + "','" + txtNombre.Text + "','" + txtMembresia.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','" + txtCompra.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("El cliente: " + txtNombre.Text + " ha sido agregado a la base de datos");

            consulta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string cadena = "DELETE FROM Clientes WHERE nombre = '" + txtNombre.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se ha eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error al eliminarlo");
            }

            consulta();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string cadena = "UPDATE Clientes SET id = '" + txtId.Text + "', nombre = '" + txtNombre.Text + "', membresia = '" + txtMembresia.Text + "', telefono = '" + txtTelefono.Text + "', direccion = '" + txtDireccion.Text + "', id_compra = '" + txtCompra.Text + "' WHERE nombre = '" + txtNombre.Text + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();

            if (flag == 1)
            {
                MessageBox.Show("Se ha actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }

            consulta();
        }
    }
}