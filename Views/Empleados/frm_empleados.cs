using _06Publicaciones.config;
using _06Publicaciones.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Publicaciones.Views.Empleados
{
    public partial class frm_empleados : Form
    {
        public frm_empleados()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frm_empleados_Load(object sender, EventArgs e)
        {
            CargaEmpleados();
        }
        public void CargaEmpleados()
        {
            var listaEmpleados = Empleados.();
            lst_Empleado .DataSource = null;
            lst_Empleado.DataSource = listaEmpleados;
            lst_Empleado.DisplayMember = "DescripcionTrabajo";
            lst_Empleado.ValueMember = "IdTrabajo";
        }

        private bool validarcampos(params TextBox[] cajadetexto)
        {
            foreach (var caja in cajadetexto)
            {
                if (string.IsNullOrWhiteSpace(caja.Text))
                {
                    ErrorHandler.ManejarErrorGeneral(null, "Complete la informacion");
                    return false;
                }
            }
            return true;
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarcampos( textBoxIdentificacion,textBoxNombre, textBoxMinto,textBoxApellido,textBoxIdTrabajo,textBoxNTrabajo,textBoxIdPublica,textBoxFecha))
                {

                    return;
                }
                var trabajo = new Empleados
                {
                     = textBoxIdentificacion.Text,



                    IdTrabajo = textBoxIdTrabajo.Text,
                    Descripcion = textBoxDescripcion.Text,
                    NivelMinimo = textBoxNMinimo.Text,
                    NivelMaximo = textBoxNMaximo.Text
                };
                var insertado = Trabajo.Insertar(trabajo);
                if (insertado != null)
                {
                    CargaTrabajos();
                    ErrorHandler.ManejarInsertar();

                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ManejarErrorGeneral(ex, "");


            }

        }
    }
    }

