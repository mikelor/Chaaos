using AndroidX.Car.App;
using Location = Android.Locations.Location;

using Chaaos.Platforms.Android.Auto.Models;

using AndroidX.Car.App.Model;
using Android.Text;

namespace Chaaos.Platforms.Android.Auto.Data;

public class SamplePlaces
{
    private Location _location;
    private Screen _screen;
    private List<PlaceInfo> _places;

    public SamplePlaces(Screen screen)
    {
        _screen = screen;

        _location = new Location("ShowcaseDemo");
        _location.Latitude = 47.6204588;
        _location.Longitude = -122.1918818;
        _places = GetPlaces();
    }

    public static SamplePlaces Create(Screen demoScreen)
    {
        return new SamplePlaces(demoScreen);
    }

    private Location CreateLocation(double latitude, double longitude)
    {
        Location location = new Location(this.GetType().ToString());
        location.Latitude = latitude;
        location.Longitude = longitude;
        
        return location;
    }
    private List<PlaceInfo> GetPlaces()
    {
        var places = new List<PlaceInfo>
        {
            new PlaceInfo()
            {
                Title = "Einstein's Bagel",
                Address = "9041 W Sahara Ave Ste 300, Las Vegas, NV 89117",
                Description = "A Bagel Place",
                PhoneNumber = "+17022540919",
                Location = CreateLocation(36.143834278485855, -115.2943067729537),
                Marker = new PlaceMarker.Builder().Build()
            },

            new PlaceInfo()
            {
                Title = "Amore Taste of Chicago",
                Address = "3945 S Durango Dr, Las Vegas, NV 89147",
                Description = "Pizzeria",
                PhoneNumber = "+17025629000",
                Location = CreateLocation(36.11975203512992, -115.27967267109382),
                Marker = new PlaceMarker.Builder().Build()
            }
        };

        return places;

    }


    public ItemList GetPlaceList()
    {
        ItemList.Builder itemListBuilder = new ItemList.Builder().SetNoItemsMessage("No Places");

        foreach (var place in _places)
        {

            // Build a description string that includes the required distance span.
            int distance = 10;
            SpannableString description = new SpannableString($"   \u00b7 {place.Description}");
            description.SetSpan(
                DistanceSpan.Create(Distance.Create(distance, Distance.UnitMiles)),
                    0,
                    1,
                    SpanTypes.ExclusiveExclusive);

            description.SetSpan(
                    ForegroundCarColorSpan.Create(CarColor.Blue),
                    0,
                    1,
                    SpanTypes.ExclusiveExclusive);

            // Add the row for this place to the list.
            itemListBuilder.AddItem(
                    new Row.Builder()
                            .SetTitle(place.Title)
                            .AddText(description)
                            .SetBrowsable(false)
                            .SetMetadata(
                                    new Metadata.Builder()
                                            .SetPlace(new Place.Builder(CarLocation.Create(place.Location))
                                                        .SetMarker(new PlaceMarker.Builder().Build())
                                                        .Build())
                                            .Build())
                            .Build());
        }


        return itemListBuilder.Build();
    }
}
