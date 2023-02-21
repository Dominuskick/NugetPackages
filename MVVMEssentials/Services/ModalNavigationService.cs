using MVVMEssentials.Stores;
using MVVMEssentials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMEssentials.Services
{
    public class ModalNavigationService<TViewModal> : INavigationService where TViewModal : ViewModelBase
    {
        private readonly ModalNavigationStore _navigationStore;
        private readonly CreateViewModel<TViewModal> _createViewModal;

        public ModalNavigationService(ModalNavigationStore navigationStore, CreateViewModel<TViewModal> createViewModal)
        {
            _navigationStore = navigationStore;
            _createViewModal = createViewModal;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModal(); 
        }
    }
}
