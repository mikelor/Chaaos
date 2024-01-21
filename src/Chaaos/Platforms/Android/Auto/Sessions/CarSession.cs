using Android.Content;
using AndroidX.Car.App;
using Chaaos.Platforms.Android.Auto.Screens;

namespace Chaaos.Platforms.Android.Auto.Sessions
{
    public class CarSession : Session
    {
        public override Screen OnCreateScreen(Intent intent)
        {
            // TODO: Reroute to request for permissions here
            
            return new MainScreen(CarContext);
        }
    }
}
