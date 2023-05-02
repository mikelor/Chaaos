using Android.App;
using AndroidX.Car.App;
using AndroidX.Car.App.Validation;
using Chaaos.Platforms.Android.Auto.Sessions;

namespace Chaaos.Platforms.Android.Auto.Services
{
    [Service(Exported = true)]
    [IntentFilter(new string[] { "androidx.car.app.CarAppService" }, Categories = new[] { "androidx.car.app.category.POI" })]

    public class CarService : CarAppService
    {
        public override HostValidator CreateHostValidator()
        {
            return HostValidator.AllowAllHostsValidator;
        }

        public override Session OnCreateSession()
        {
            return new CarSession();
        }
    }
}