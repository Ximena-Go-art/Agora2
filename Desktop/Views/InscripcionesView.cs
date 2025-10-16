using Desktop.ExtensionMethod;
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
        GenericServices<Usuario> _usuarioservice = new();
        InscipcionService _inscripcionService = new();
        List<Inscripcion>? _inscripciones = new();
        List<Usuario>? _usuarios = new();

        public InscripcionesView()
        {
            InitializeComponent();
            _ = GetAlldata();
        }

        private async Task GetAlldata()
        {
            await GetComboCapacitaciones();
            await GetGrillaUsuarios();

        }

        private async Task GetGrillaUsuarios()
        {
            _usuarios = (await _usuarioservice.GetAllAsync());
            _usuarios = _usuarios?.Where(u => _inscripciones != null && !_inscripciones.Any(i => i.UsuarioId == u.Id)).ToList();
            GridUsuarios.DataSource = _usuarios;
            GridUsuarios.HideColumns("Id", "DeleteDate", "IsDeleted");


        }

        private async Task GetComboCapacitaciones()
        {
            //cargamos lac capacitaciones en el combo
            var capacitacion = await _capacitacionservice.GetAllAsync();
            CmbCapacitaciones.DataSource = capacitacion.Where(c => c.InscripcionAbierta).ToList();
            CmbCapacitaciones.DisplayMember = "Nombre";
            CmbCapacitaciones.ValueMember = "Id";
        }

        private async void CmbCapacitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Controlamos que no sea nulo y haya una capacitacion seleccionada
            if (CmbCapacitaciones.SelectedItem is Capacitacion selectedCapacitacion)
            {
                _inscripciones = await _inscripcionService.GetInscriptosAsync(selectedCapacitacion.Id);
                GridInscripciones.DataSource = _inscripciones;
                GridInscripciones.HideColumns("Id", "UsuarioId", "TipoInscripcionId", "CapacitacionId", "Capacitacion", "UsuarioCobroId", "");
                await GetGrillaUsuarios();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            _usuarios = _usuarios?.Where(u => u.Nombre.Contains(TxtBuscarUsuarios.Text, StringComparison.OrdinalIgnoreCase) || u.Apellido.Contains(TxtBuscarUsuarios.Text, StringComparison.OrdinalIgnoreCase)).ToList(); GridUsuarios.DataSource = _usuarios;
        }

        private async void TxtBuscarUsuarios_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBuscarUsuarios.Text))
            {
                await GetGrillaUsuarios();
            }
        }

        private void TxtBuscarUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnBuscar.PerformClick();
                e.Handled = true;// Evita el sonido de "ding"
            }
        }
    }
}
