using AndroidX.Car.App;
using Location = Android.Locations.Location;
using MauiLocation = Microsoft.Maui.Devices.Sensors.Location;

using Chaaos.Platforms.Android.Auto.Models;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using AndroidX.Car.App.Model;
using AndroidX.Core.Graphics.Drawable;

namespace Chaaos.Platforms.Android.Auto.Data;

public class SamplePlaces
{
    private Location _location;
    private Screen _screen;
    public List<PlaceInfo> Places { get; set; }

    public SamplePlaces(Screen screen)
    {
        _screen = screen;

        _location = new Location("ShowcaseDemo");
        _location.Latitude = 47.6204588;
        _location.Longitude = -122.1918818;
        Places = GetPlaces();
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
        // Get current location
        MauiLocation location = Geolocation.GetLocationAsync().GetAwaiter().GetResult();
        Location currentLocation = CreateLocation(location.Latitude, location.Longitude);

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

    private float GetDistance(Location currentLocation, Location destinationLocation)
    {
        return currentLocation.DistanceTo(destinationLocation);
    }
}
