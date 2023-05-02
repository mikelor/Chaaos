using Location = Android.Locations.Location;
using AndroidX.Car.App.Model;

namespace Chaaos.Platforms.Android.Auto.Models;

public class PlaceInfo
{
    public string Title { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string PhoneNumber { get; set; }
    public Location Location { get; set; }
    public  PlaceMarker Marker { get; set; }

    public static Location CreateLocation(double latitude, double longitude)
    {
       return new("PlaceInfo")
        {
            Latitude = latitude,
            Longitude = longitude
        };
    }
}
