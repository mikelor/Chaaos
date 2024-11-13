using Location = Android.Locations.Location;
using AndroidX.Car.App.Model;

namespace Chaaos.Platforms.Android.Auto.Models;

public class PlaceInfo
{
    public required string Title { get; set; }
    public required string Address { get; set; }
    public required string Description { get; set; }
    public required string PhoneNumber { get; set; }
    public required Location Location { get; set; }
    public required PlaceMarker Marker { get; set; }

    public static Location CreateLocation(double latitude, double longitude)
    {
       return new("PlaceInfo")
        {
            Latitude = latitude,
            Longitude = longitude
        };
    }
}
