using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Service.Models;
using Service.Services;

namespace Desktop.Views
{
    public partial class TipoInscripcionView : Form
    {
        GenericServices<TipoInscripcion> _tipoInscripcionService = new();
        TipoInscripcion _currentTipoInscripcion;
        List<TipoInscripcion>? _tiposInscripciones;

        public TipoInscripcionView()
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
                _tiposInscripciones = await _tipoInscripcionService.GetAllDeletedsAsync("");
            }
            else
            {
                _tiposInscripciones = await _tipoInscripcionService.GetAllAsync();
            }
            GridCapacitaciones.DataSource = _tiposInscripciones;
            GridCapacitaciones.Columns["id"].Visible = false;
            GridCapacitaciones.Columns["IsDeleted"].Visible = false;

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
                TipoInscripcion entitySelected = (TipoInscripcion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el tipo de inscripcion {entitySelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _tipoInscripcionService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Tipo inscripción {entitySelected.Nombre} eliminada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el tipo de inscripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de inscripcion para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPageLista;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            TipoInscripcion entidadAGuardar = new TipoInscripcion
            {
                Id = _currentTipoInscripcion?.Id ?? 0,
                Nombre = TxtNombre.Text
            };

            bool response = false;
            if (_currentTipoInscripcion != null)
            {
                 response = await _tipoInscripcionService.UpdateAsync(entidadAGuardar);
            }
            else
            {
                var nuevaEntidad = await _tipoInscripcionService.AddAsync(entidadAGuardar);
                response = nuevaEntidad != null;
            }
            if (response)
            {
                _currentTipoInscripcion = null;// Reset the modified movie after saving
                LabelStatusMessage.Text = $"Tipo de inscripcion {entidadAGuardar.Nombre} guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar el tipo de inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya una capacitacion seleccionadas
            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                _currentTipoInscripcion= (TipoInscripcion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentTipoInscripcion.Nombre;
                TabControl.SelectedTab = TabPageAgregarEditar;
            }
            else
            {
              MessageBox.Show("Debe seleccionar un tipo de inscripcion para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridCapacitaciones.DataSource = await _tipoInscripcionService.GetAllAsync(TxtBuscar.Text);
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

        { if (!checkVerEliminados.Checked)return;

            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                TipoInscripcion entitySelected = (TipoInscripcion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea restaurar el tipo de inscripcion {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _tipoInscripcionService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Tipo inscripcion {entitySelected.Nombre} restaurada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el tipo de inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de inscripcion para restaurar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
    }
}
