using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.ViewModels.Admin
{
    partial class AdminCapacitacionesViewModel : ObservableObject
    {
        GenericServices<Capacitacion> _capacitacionService = new();

        [ObservableProperty]
        private ObservableCollection<Capacitacion> capacitaciones;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(DeleteCommand))]
        private Capacitacion capacitacionCurrent;

        [ObservableProperty]
        private string filterText;

        [ObservableProperty]
        private bool isRefreshing;


        public IRelayCommand AddCommand { get; }
        public IRelayCommand EditCommand { get; }
        public IRelayCommand DeleteCommand { get; }
        public IRelayCommand RefreshCommand { get; }

        public AdminCapacitacionesViewModel()
        {
            _=LoadCapacitaciones();
            AddCommand = new AsyncRelayCommand(AddCapacitacion);
            EditCommand = new AsyncRelayCommand(EditCapacitacion, CanEditCapacitacion);
            DeleteCommand = new AsyncRelayCommand(DeleteCapacitacion, CanDeleteCapacitacion);
            RefreshCommand = new AsyncRelayCommand(LoadCapacitaciones);
        }

        private async Task AddCapacitacion()
        {
            throw new NotImplementedException();
        }

        private async Task EditCapacitacion()
        {
            throw new NotImplementedException();
        }

        private bool CanEditCapacitacion()
        {
            throw new NotImplementedException();
        }

        private async Task DeleteCapacitacion()
        {
            throw new NotImplementedException();
        }

        private bool CanDeleteCapacitacion()
        {
            throw new NotImplementedException();
        }

        private async Task LoadCapacitaciones()
        {
            var capacitaciones = await _capacitacionService.GetAllAsync();
            Capacitaciones = capacitaciones != null ? new ObservableCollection<Capacitacion>(capacitaciones) : new ObservableCollection<Capacitacion>();

        }
    }
}
