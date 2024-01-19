using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Triggers2_RERM.Model;
using Triggers2_RERM.ViewModel;
using Triggers2_RERM.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Triggers2_RERM.ViewModel
{
    public class VMCategoris:ViewModelBase
    {
        #region Variables
        string _Texto;
        bool _ActivitiAnimationImg;
        string _Image;
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
        public string Imagen
        { 
            get { return _Image; }
            set { SetValue(ref _Image, value); }
        }
        public bool ActivitiAnimationImg
        {
            get { return _ActivitiAnimationImg; }
            set { SetValue(ref _ActivitiAnimationImg, value); }
        }
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
        public void Selected(ModelCategoris model)
        {
            var index = ListaCategorias.ToList().FindIndex(p => p.description == model.description);
            Imagen = model.images;
            if(index>-1)
            {
                Deseleccionar();
                ActivitiAnimationImg = true;
                ListaCategorias[index].selected = true;
                ListaCategorias[index].textColor = "#FFFFFF";
                ListaCategorias[index].backgroundColor = "FF506B";
            }

        }
        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivitiAnimationImg = false;
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<ModelCategoris>(Data.CategorisData.ShowCategoris());
        }
        #endregion
        #region Comandos
        public ICommand ProcesoAsynCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimoleCommand => new Command(MostrarCategorias);
        public ICommand Seleccionarcomand => new Command<ModelCategoris>((p) => Selected(p));
        #endregion
    }
}
