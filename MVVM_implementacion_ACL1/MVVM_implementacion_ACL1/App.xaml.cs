﻿using MVVM_implementacion_ACL1.Vista;
using MVVM_implementacion_ACL1.Vista.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_ACL1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Listapokemon());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
