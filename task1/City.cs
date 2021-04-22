using System;

namespace task1
{
    class City : Place
    {
        public string Name {get; set;} //Name
        public uint Pop { get; set; } //Population
        public string Region { get; set; } //Region name

        public City()
        {
            Lat = 0;
            Lng = 0;
            Alt = 0;
            Area = 0;
            Name = "";
            Pop = 0;
            Region = "";
        }
        public City(double lat, double lng, double alt)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = 0;
            Name = "";
            Pop = 0;
            Region = "";
        }
        public City(double lat, double lng, double alt, double area,string name, uint pop, string region)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = area;
            Name = name;
            Pop = pop;
            Region = region;
        }
        ~City() => Console.WriteLine("Destructor is executing");

        public override string ToString()
        {
            string result = "";
            result += $"Place:\nLatitude: {Lat}\nLongitude: {Lng}\nAltitude: {Alt}\nArea: {Area}" +
            $"\nName: {Name}\nPop: {Pop}\nPop: {Pop}\nRegion: {Region}";
            return result;
        }
        public override void Show()
        {
            Console.WriteLine(this);
        }

        public override double Density()
        {
            return Area/Pop;
        }
    }
}
