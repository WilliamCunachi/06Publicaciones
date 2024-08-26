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

namespace _06Publicaciones.Views.Trabajos
{
    public partial class frm_trabajo : Form
    {
        public frm_trabajo()
        {
            InitializeComponent();
        }
        private void frm_trabajo_Load(object sender, EventArgs e)
        {
            CargaTrabajos();

        }
        public void CargaTrabajos()
        {
            var listaTrabajos = Trabajo.ObtenerTodos();
            lst_Trabajos.DataSource = null;
            lst_Trabajos.DataSource = listaTrabajos;
            lst_Trabajos.DisplayMember = "DescripcionTrabajo";
            lst_Trabajos.ValueMember = "IdTrabajo";
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

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarcampos(textBoxIdTrabajo, textBoxDescripcion, textBoxNMinimo, textBoxNMaximo))
                {

                    return;
                }
                var trabajo = new Trabajo
                {
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            textBoxIdTrabajo.Clear();
            textBoxDescripcion.Clear();
            textBoxNMinimo.Clear();
            textBoxNMaximo.Clear();
        }

        private void lst_Trabajos_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Trabajos.SelectedValue != null)
            {
                var trabajo = Trabajo.ObtenerPorId(lst_Trabajos.SelectedValue.ToString());

                textBoxIdTrabajo.Text = trabajo.IdTrabajo;
                textBoxDescripcion.Text = trabajo.Descripcion;
                textBoxNMaximo.Text = trabajo.NivelMaximo;
                textBoxNMinimo.Text = trabajo.NivelMinimo;
            }
            else
            {
                ErrorHandler.ManejarErrorGeneral(null, "Seleccione un item de la lista");
            }
        }
    }
}
    