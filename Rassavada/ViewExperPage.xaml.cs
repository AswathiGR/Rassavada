﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rassavada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewExperPage : ContentPage
    {
        public ViewExperPage()
        {
            InitializeComponent();
        }

        private void Swiped(object sender, SwipedEventArgs e)
        {

            Pictures.Source = "Mockpic.png";
        }
    }
}