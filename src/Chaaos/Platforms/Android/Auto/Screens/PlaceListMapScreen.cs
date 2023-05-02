using AndroidX.Car.App;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;

using Action = AndroidX.Car.App.Model.Action;
using AndroidLocation = Android.Locations.Location;

using Chaaos.Platforms.Android.Auto.Data;
using Chaaos.Platforms.Android.Auto.Models;
using Chaaos.Platforms.Android.Auto.OnClickListeners;

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
        //var currentLocation = PlaceInfo.CreateLocation(47.6204588, -122.1918818);


        var itemListBuilder = new ItemList.Builder().SetNoItemsMessage("Our Maui App Running on Android Auto");
        
        var samplePlaces = SamplePlaces.Create(this);

        //var place = samplePlaces.Places.First();
        /*
        // Add the row for this place to the list.
        itemListBuilder.AddItem(
                new Row.Builder()
                        .SetTitle("MyTitle")
                        .AddText("MyDescription")
                        //.SetOnClickListener(()->onClickPlace(place))
                        .SetBrowsable(false)
                        .SetMetadata(
                                new Metadata.Builder()
                                        .SetPlace(new Place.Builder(CarLocation.Create(PlaceInfo.CreateLocation(47.6204588, -122.1918818)))
                                                    .SetMarker(new PlaceMarker.Builder().SetLabel("L").Build())
                                                    .Build())
                                        .Build())
                        .Build());
        */

        var itemList = itemListBuilder.Build();

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


        return new PlaceListMapTemplate.Builder()
            .SetTitle("Maui Android Auto - Place List Map Template")
            .SetHeaderAction(Action.Back)
            .SetActionStrip(actionStrip)
            .SetCurrentLocationEnabled(true)
            .SetItemList(itemList)
            .Build();
    }

}
