﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Perf_View_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {

        public MenuPage()
        {
            InitializeComponent();
            // NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void GoToBenchListAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView_Bench());
        }

        private async void AgendaPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calendar());
        }

        private async void CompassPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Compass());
        }

        private async void AccelerometrePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Accelerometre());
        }

        private async void AddPerfPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddBench());
        }
    }
}