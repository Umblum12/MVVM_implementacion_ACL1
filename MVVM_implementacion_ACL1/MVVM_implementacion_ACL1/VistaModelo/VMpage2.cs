using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_ACL1.Vista;
using MVVM_implementacion_ACL1.Modelo;

namespace MVVM_implementacion_ACL1.VistaModelo
{
    public class VMpage2 : BaseViewModel
    {
        #region VARIABLES
        string _Mensaje;
        string _N1;
        string _N2;
        string _R;
        public List<Musuarios> listausuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
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
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Okey");
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
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="Abelardo Cruz Leos",
                    Imagen="https://i.ibb.co/JcJ6kNm/programacion.png"
                },
                new Musuarios
                {
                    Nombre="Eduardo Franco",
                    Imagen="https://i.ibb.co/M9Jk0Ky/sin-bateria.png"
                },
                new Musuarios
                {
                    Nombre="Javier",
                    Imagen="https://i.ibb.co/grJV1pg/baloncesto.png"
                }
            };
        }
        #endregion

        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
       // public ICommand Suymarcommand => new Command(Sumar);
        #endregion
    }
}
