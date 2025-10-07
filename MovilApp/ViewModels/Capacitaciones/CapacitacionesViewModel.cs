﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.ViewModels.Capacitaciones
{
    partial class CapacitacionesViewModel : ObservableObject
    {
        GenericServices<Capacitacion> _capacitacionService = new();

        [ObservableProperty]
        private string textobusqueda = string.Empty;

        [ObservableProperty]
        private bool estaDescargando;

        [ObservableProperty]
        private ObservableCollection<Capacitacion> capacitaciones = new();


        public IRelayCommand BuscarCommand { get; }
        public IRelayCommand LimpiarCommand { get; }

        public CapacitacionesViewModel()
        {
            BuscarCommand = new RelayCommand(OnBuscar);
            LimpiarCommand = new RelayCommand(OnLimpiar);
            _ = InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            OnBuscar();
        }

        private async void OnBuscar()
        {
            if (EstaDescargando) return;

            try
            {
                EstaDescargando = true;

                // Obtener todos los libros si no los tenemos
                var capacitaciones = await _capacitacionService.GetAllAsync(textobusqueda);

                Capacitaciones = capacitaciones != null ?
                        new ObservableCollection<Capacitacion>(capacitaciones)
                        : new ObservableCollection<Capacitacion>();
            }
            finally
            {
                EstaDescargando = false;
            }
        }
        private void OnLimpiar()
        {
            Textobusqueda = string.Empty;
            // Mantener los filtros pero ejecutar búsqueda limpia
            OnBuscar();
        }
    }
}

