using Android.Content;
using AndroidX.Car.App;
using Chaaos.Platforms.Android.AndroidAuto.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaaos.Platforms.Android.AndroidAuto.Sessions
{
    public class AutoSession : Session
    {
        public override Screen OnCreateScreen(Intent intent)
        {
            // TODO: Reroute to request for permissions here
            return new AutoMenuScreen(CarContext);
        }
    }
}
