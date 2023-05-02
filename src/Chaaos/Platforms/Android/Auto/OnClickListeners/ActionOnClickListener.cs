using AndroidX.Car.App;
using AndroidX.Car.App.Model;

namespace Chaaos.Platforms.Android.Auto.OnClickListeners;

public class ActionOnClickListener : Java.Lang.Object, IOnClickListener
{
    private readonly CarContext _carContext;
    private readonly string _message;

    public ActionOnClickListener(CarContext carContext, string message)
    {
        _carContext = carContext;
        _message = message; 
    }
    public void OnClick()
    {
        // TODO: A more generic method using pub/sub could be used here https://youtu.be/nNkVxegb2oU?t=2598
        CarToast.MakeText(_carContext, _message, CarToast.LengthLong).Show();
    }
}
