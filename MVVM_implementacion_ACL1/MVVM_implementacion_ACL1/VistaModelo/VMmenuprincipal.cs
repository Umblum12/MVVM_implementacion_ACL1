using MVVM_implementacion_ACL1.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_ACL1.Vista;
using MVVM_implementacion_ACL1.VistaModelo;
using MvvmGuia.VistaModelo;

namespace MVVM_implementacion_ACL1.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _N1;
        string _N2;
        string _R;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion

        #region OBJETOS
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion

        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string Pagina;
            Pagina = parametros.Pagina;
            if (Pagina.Contains("Entry, DatePicker, label, navegacion"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (Pagina.Contains("CollectionView sin enlace a base de datos"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (Pagina.Contains("Crud Pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
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
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina="Entry, DatePicker, label, navegacion",
                    Icono="https://i.ibb.co/JcJ6kNm/programacion.png"
                },
                new Mmenuprincipal
                {
                    Pagina="CollectionView sin enlace a base de datos",
                    Icono="https://i.ibb.co/M9Jk0Ky/sin-bateria.png"
                },
                new Mmenuprincipal
                {
                    Pagina="Crud Pokemon",
                    Icono="https://i.ibb.co/grJV1pg/baloncesto.png"
                }
            };
        }
        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        // public ICommand Suymarcommand => new Command(Sumar);
        #endregion
    }
}
