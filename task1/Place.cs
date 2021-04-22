using System;

namespace task1
{
    class Place
    {
        public double Lat { get; set; }
        public double Lng {get; set;}
        public double Alt{get; set;}
        public double Area {get; set;}

        public Place()
        {
            Lat = 0;
            Lng = 0;
            Alt = 0;
            Area = 0;

        }
        public Place(double lat, double lng)
        {
            Lat = lat;
            Lng = lng;
            Alt = 0;
            Area = 0;
        }
        public Place(double lat, double lng, double alt)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = 0;
        }
        public Place(double lat, double lng, double alt, double area)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = area;
        }
        ~Place() => Console.WriteLine("Destructor is executing");

        public override string ToString()
        {
            string result = "";
            result += $"Place:\nLatitude: {Lat}\nLongitude: {Lng}\nAltitude: {Alt}\nArea: {Area}";
            return result;
        }
        public virtual void Show()
        {
            Console.WriteLine(this);
        }
        public virtual double Density()
        {
            return 0;
        }
    }
}
