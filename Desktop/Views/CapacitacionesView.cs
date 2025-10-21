using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Serialization;
using Desktop.ExtensionMethod;
using Service.Models;
using Service.Services;

namespace Desktop.Views
{
    public partial class CapacitacionesView : Form
    {
        GenericServices<Capacitacion> _capacitacionService = new();
        GenericServices<TipoInscripcion> _tipoInscripcionService = new();
        Capacitacion _currentCapacitacion;
        List<Capacitacion>? _capacitaciones;

        public CapacitacionesView()
        {
            InitializeComponent();
            _ = GetAllData();
            checkVerEliminados.CheckedChanged += DisplayHideControslRestoreButton;
        }

        private void DisplayHideControslRestoreButton(object? sender, EventArgs e)
        {
            BtnRestaurar.Visible = checkVerEliminados.Checked;
            TxtBuscar.Enabled = !checkVerEliminados.Checked;//!Marca la inversa de los datos eliminados
            BtnBuscar.Enabled = !checkVerEliminados.Checked;
            BtnModificar.Enabled = !checkVerEliminados.Checked;
            BtnAgregar.Enabled = !checkVerEliminados.Checked;
            BtnEliminar.Enabled = !checkVerEliminados.Checked;
        }

        private async Task GetAllData()
        {
            if (checkVerEliminados.Checked)
            {
                _capacitaciones = await _capacitacionService.GetAllDeletedsAsync("");
            }
            else
            {
                _capacitaciones = await _capacitacionService.GetAllAsync();
            }
            GridCapacitaciones.DataSource = _capacitaciones;
            GridCapacitaciones.Columns["id"].Visible = false;
            GridCapacitaciones.Columns["IsDeleted"].Visible = false;
            await GetComboTiposdeInscripciones();

        }

        private async Task GetComboTiposdeInscripciones()
        {
            CmbTiposInscripciones.DataSource = await _tipoInscripcionService.GetAllAsync();
            CmbTiposInscripciones.DisplayMember = "Nombre";
            CmbTiposInscripciones.ValueMember = "Id";
        }

        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                //Capacitacion capacitacionSeleccionada = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar la capacitacion {entitySelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _capacitacionService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} eliminada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la capcitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para eliminarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectedTab = TabPageAgregarEditar;
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtNombre.Clear();
            TxtDetalle.Clear();
            NumericCupo.Value = 0;
            TxtPonente.Clear();
            DateTimeFechaHora.Value = DateTime.Now;
            CheckInscripcionAbierta.Checked = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPageLista;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Capacitacion CapacitacionAGuardar = new Capacitacion
            {
                Id = _currentCapacitacion?.Id ?? 0,
                Nombre = TxtNombre.Text,
                Detalle = TxtDetalle.Text,
                Ponente = TxtPonente.Text,
                FechaHora = DateTimeFechaHora.Value,
                Cupo = (int)NumericCupo.Value,//El int estaria realizando una "conversión de tipo".
                InscripcionAbierta = CheckInscripcionAbierta.Checked
            };

            bool response = false;
            if (_currentCapacitacion != null)
            {
                response = await _capacitacionService.UpdateAsync(CapacitacionAGuardar);
            }
            else
            {
                var nuevacapacitacion = await _capacitacionService.AddAsync(CapacitacionAGuardar);
                response = nuevacapacitacion != null;
            }
            if (response)
            {
                _currentCapacitacion = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Capacitación {CapacitacionAGuardar.Nombre} guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar la capacitacón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya una capacitacion seleccionadas
            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                _currentCapacitacion = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentCapacitacion.Nombre;
                NumericCupo.Value = _currentCapacitacion.Cupo;
                TxtDetalle.Text = _currentCapacitacion.Detalle;
                TxtPonente.Text = _currentCapacitacion.Ponente;
                DateTimeFechaHora.Value = _currentCapacitacion.FechaHora;
                CheckInscripcionAbierta.Checked = _currentCapacitacion.InscripcionAbierta;
                GridTiposdeInscripciones.DataSource = null;
                TabControl.SelectedTab = TabPageAgregarEditar;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridCapacitaciones.DataSource = await _capacitacionService.GetAllAsync(TxtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // BtnBuscar.PerformClick();// Llamar al evento de búsqueda al cambiar el texto
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }

        private async void checkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)

        {
            if (!checkVerEliminados.Checked) return;

            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea restaurar la capacitacion {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _capacitacionService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} restaurada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la capcitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para restaurarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            var tipoIncsripcionCapacitacion = new TipoInscripcionCapacitacion
            {
                TipoInscripcionId = (int)CmbTiposInscripciones.SelectedValue,
                TipoInscripcion = (TipoInscripcion)CmbTiposInscripciones.SelectedItem,
                CapacitacionId = _currentCapacitacion?.Id ?? 0,
                Capacitacion = _currentCapacitacion,
                Costo = NumCosto.Value
            };
            _currentCapacitacion?.TiposDeInscripciones.Add(tipoIncsripcionCapacitacion);
            GridTiposdeInscripciones.DataSource = null;
            GridTiposdeInscripciones.HideColumns("Id", "CapacitacionId", "Capacitacion", "TipoInscripcionId", "IsDeleted");
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            var tipoIncsripcionCapacitacion = (TipoInscripcionCapacitacion)GridTiposdeInscripciones.SelectedRows[0].DataBoundItem;
            _currentCapacitacion?.TiposDeInscripciones.Remove(tipoIncsripcionCapacitacion);
            GridTiposdeInscripciones.DataSource = _currentCapacitacion?.TiposDeInscripciones.ToList();
        }
    }
}
