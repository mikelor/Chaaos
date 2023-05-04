using Android.Security.Keystore;
using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using Chaaos.Platforms.Android.Auto.Enums;
using Chaaos.Platforms.Android.Auto.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaaos.Platforms.Android.Auto.OnContentRefreshListeners;

public class PlaceListMapOnContentRefreshListener : Java.Lang.Object, IOnContentRefreshListener
{
    private readonly CarContext mCarContext;
    private readonly Screen mScreen;

    public PlaceListMapOnContentRefreshListener(CarContext carContext, Screen screen)
    {
        mCarContext = carContext;
        mScreen = screen;
    }

    public void OnContentRefreshRequested()
    {
        mScreen.Invalidate();  
    }
}