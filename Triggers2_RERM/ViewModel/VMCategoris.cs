using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Triggers2_RERM.Model;
using Triggers2_RERM.ViewModel;
using Xamarin.Forms;

namespace Triggers2_RERM.ViewModel
{
    public class VMCategoris:ViewModelBase
    {
        #region Variables
        string _Texto;
        ObservableCollection<ModelCategoris> _ListaCategorias;
        #endregion
        #region Constructor
        public VMCategoris(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region Objetos
        public ObservableCollection<ModelCategoris> ListaCategorias
        {
            get { return _ListaCategorias; }
            set { SetValue(ref _ListaCategorias, value); }
        }
        #endregion
        #region Procesos
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<ModelCategoris>(Data.CategorisData.ShowCategoris());
        }
        #endregion
        #region Comandos
        public ICommand ProcesoAsynCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimoleCommand => new Command(MostrarCategorias);
        #endregion
    }
}
