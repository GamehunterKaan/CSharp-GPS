using System;
using System.Device.Location;


namespace LongLat
{
    static class Program
    {
        static void Main()
        {
            GeoCoordinate geoCoordinate = new GeoCoordinate();
            if (geoCoordinate.IsUnknown)
            {
                Console.WriteLine("[-] GeoCoordinate info is not available!");
            }
            else
            {
                Console.WriteLine("[+] {0}", geoCoordinate.Latitude);
                Console.WriteLine("[+] {0}", geoCoordinate.Longitude);
            }
        }
    }
}