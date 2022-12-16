using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_ACL1.Vista;

namespace MVVM_implementacion_ACL1.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;

        #endregion

        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        } public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        } public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        } public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value); }
        }public string SeleccionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetProperty(ref _TipoUsuario, value);
                TipoUsuario = _TipoUsuario;
            }
        }
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Page2());
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(R);

            r = n1 + n2;
            R = r.ToString();
        }
        #endregion

        #region COMANDOS
        public ICommand Navegarpagina2command => new Command(async () => await Navegarpagina2());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion
    }
}
