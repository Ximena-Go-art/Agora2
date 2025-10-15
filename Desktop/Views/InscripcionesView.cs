using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class InscripcionesView : Form
    {
        GenericServices<Capacitacion> _capacitacionservice = new();
        InscipcionService _inscripcionService = new();
        public InscripcionesView()
        {
            InitializeComponent();
            _ = GetAlldata();
        }

        private async Task GetAlldata()
        {
            //cargamos lac capacitaciones en el combo
            var capacitacion = await _capacitacionservice.GetAllAsync();
            CmbCapacitaciones.DataSource = capacitacion.Where(c => c.InscripcionAbierta).ToList();
            CmbCapacitaciones.DisplayMember = "Nombre";
            CmbCapacitaciones.ValueMember = "Id";

            //cargamos las inscripciones de la capacitacion seleccionada

        }

        private async void CmbCapacitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Controlamos que no sea nulo y haya una capacitacion seleccionada
            if (CmbCapacitaciones.SelectedItem is Capacitacion selectedCapacitacion)
            {
                GridInscripciones.DataSource = await _inscripcionService.GetInscriptosAsync(selectedCapacitacion.Id);
            }
        }
    }
}
