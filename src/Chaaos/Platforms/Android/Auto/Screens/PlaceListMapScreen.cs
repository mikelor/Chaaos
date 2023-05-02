using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;

using Action = AndroidX.Car.App.Model.Action;
using AndroidLocation = Android.Locations.Location;

using Chaaos.Platforms.Android.Auto.Data;
using Chaaos.Platforms.Android.Auto.Models;

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
        Location location = Geolocation.GetLocationAsync().GetAwaiter().GetResult();
        var currentLocation = PlaceInfo.CreateLocation(location.Latitude, location.Longitude);

        var itemListBuilder = new ItemList.Builder().SetNoItemsMessage("Our Maui App Running on Android Auto");

        var samplePlaces = SamplePlaces.Create(this);

        foreach (var place in samplePlaces.Places)
        {
            double distance = place.Location.DistanceTo(currentLocation);


            // Add the row for this place to the list.
            itemListBuilder.AddItem(
                    new Row.Builder()
                            .SetTitle(place.Title)
                            .AddText(place.Description)
                            //.SetOnClickListener(()->onClickPlace(place))
                            .SetBrowsable(false)
                            .SetMetadata(
                                    new Metadata.Builder()
                                            .SetPlace(new Place.Builder(CarLocation.Create(place.Location))
                                                        .SetMarker(place.Marker)
                                                        .Build())
                                            .Build())
                            .Build());
        }

        var itemList = itemListBuilder.Build();
        /*
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
        */

        return new PlaceListMapTemplate.Builder()
            .SetTitle("Maui Android Auto - Place List Map Template")
            .SetHeaderAction(Action.Back)
            //.SetActionStrip(actionStrip)
            .SetCurrentLocationEnabled(true)
            .SetItemList(itemList)
            .Build();
    }

}
