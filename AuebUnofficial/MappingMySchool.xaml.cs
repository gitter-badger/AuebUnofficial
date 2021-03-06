﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AuebUnofficial
{
    public sealed partial class MappingMySchool : Page
    {
        public MappingMySchool()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Specify a known location.
            BasicGeoposition cityPosition = new BasicGeoposition() { Latitude = 37.994083, Longitude = 23.732421 };
            Geopoint cityCenter = new Geopoint(cityPosition);

            //// Set the map location.
            MapControl1.Center = cityCenter;
            MapControl1.ZoomLevel = 15.5;
            MapControl1.LandmarksVisible = true;
        }       
    }
}
