using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Models;
using Service.Services;

namespace Desktop.Views
{
    public partial class CapacitacionesView : Form
    {
        GenericServices<Capacitacion> _capacitacionService = new GenericServices<Capacitacion>();
        Capacitacion _currentCapacitacion;
        List<Capacitacion>? _capacitaciones;

        public CapacitacionesView()
        {
            InitializeComponent();
            _ = GetAllData();
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
            TabControl.SelectTab("TabPageAgregarEditar");
        }

        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
            NumericDuracion.Value = 0;
            TxtPortada.Clear();
            NumericCalificacion.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Pelicula peliculaAGuardar = new Pelicula
            //{
            //    id = peliculaModificada?.id??null, 
            //    titulo = TxtTitulo.Text,
            //    duracion = (int)NumericDuracion.Value,
            //    portada = TxtPortada.Text,
            //    calificacion = (double)NumericCalificacion.Value,
            //    PaisId = (int)ComboPaises.SelectedIndex,
            //};

            //bool response;
            //if (peliculaModificada != null)
            //{
            //    response=await peliculaService.UpdateAsync(peliculaAGuardar);
            //}
            //else
            //{
            //    response = await peliculaService.AddAsync(peliculaAGuardar);
            //}
            //if (response)
            //{
            //    peliculaModificada = null; // Reset the modified movie after saving
            //    LabelStatusMessage.Text = "Pelicula guardada correctamente";
            //    TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
            //    ObtenemosPeliculas();
            //    LimpiarControlesAgregarEditar();
            //    TabControl.SelectTab("TabPageLista");
            //}
            //else
            //{
            //    MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            //if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            //{
            //    peliculaModificada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
            //    TxtTitulo.Text = peliculaModificada.titulo;
            //    NumericDuracion.Value = peliculaModificada.duracion;
            //    TxtPortada.Text = peliculaModificada.portada;
            //    NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
            //    if(peliculaModificada.PaisId != null)  
            //    {
            //        ComboPaises.SelectedValue = peliculaModificada.PaisId;
            //    }
            //    else 
            //    {
            //        ComboPaises.SelectedIndex = -1;
            //    }

            //        TabControl.SelectTab("TabPageAgregarEditar");
            //}
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //GridPeliculas.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper()))
            //    .ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();// Llamar al evento de búsqueda al cambiar el texto
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
    }
}
