using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;

using Action = AndroidX.Car.App.Model.Action;
using AndroidLocation = Android.Locations.Location;

using Chaaos.Platforms.Android.Auto.Data;
using Chaaos.Platforms.Android.Auto.Models;
using Chaaos.Platforms.Android.Auto.OnClickListeners;
using Chaaos.Platforms.Android.Auto.OnContentRefreshListeners;

namespace Chaaos.Platforms.Android.Auto.Screens;

internal class PlaceListMapScreen : Screen
{

    public PlaceListMapScreen(CarContext carContext) : base(carContext)
    {

    }

    public override ITemplate OnGetTemplate()
    {
        // Create Icon
        var dotnetBotIconCompat = IconCompat.CreateWithResource(CarContext, Resource.Drawable.dotnet_bot);
        var dotnetBotCarIcon = new CarIcon.Builder(dotnetBotIconCompat).Build();

        // Get current location
        //Location location = Geolocation.GetLocationAsync().GetAwaiter().GetResult();
        //var currentLocation = PlaceInfo.CreateLocation(location.Latitude, location.Longitude);
        var currentLocation = PlaceInfo.CreateLocation(47.6204588, -122.1918818);

        // Action Strip
        var actionOne = new Action.Builder()
            .SetIcon(dotnetBotCarIcon)
            .SetOnClickListener(new ActionOnClickListener(CarContext, "Action Strip Item 1 was Tapped"))
            .Build();

        var actionTwo = new Action.Builder()
            .SetIcon(dotnetBotCarIcon)
            .SetOnClickListener(new ActionOnClickListener(CarContext, "Action Strip Item 2 was Tapped"))
            .Build();

        var actionStrip = new ActionStrip.Builder()
            .AddAction(actionOne)
            .AddAction(actionTwo)
            .Build();

        var itemList = SamplePlaces.Create(this).GetPlaceList(); ;

        return new PlaceListMapTemplate.Builder()
            .SetTitle("Markers")
            .SetHeaderAction(Action.Back)
            // Doesn't seem to work on PlaceListMapTemplate https://github.com/android/car-samples/issues/34
            .SetOnContentRefreshListener(new PlaceListMapOnContentRefreshListener(CarContext, this))
            .SetActionStrip(actionStrip)
            .SetCurrentLocationEnabled(true)
            .SetItemList(itemList)
            .Build();
    }

}
