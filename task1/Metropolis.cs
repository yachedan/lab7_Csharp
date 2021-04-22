using System;

namespace task1
{
    class Metropolis : Place
    {
        public string Name { get; set; } //Name
        public uint Pop { get; set; } //Population
        public int Num { get; set; } //Number of cities

        public Metropolis()
        {
            Lat = 0;
            Lng = 0;
            Alt = 0;
            Area = 0;
            Name = "";
            Pop = 0;
            Num = 0;
        }
        public Metropolis(double lat, double lng, double alt)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = 0;
            Name = "";
            Pop = 0;
            Num = 0;
        }
        public Metropolis(double lat, double lng, double alt, double area, string name, uint pop, int num)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = area;
            Name = name;
            Pop = pop;
            Num = num;
        }
        ~Metropolis() => Console.WriteLine("Destructor is executing");

        public override string ToString()
        {
            string result = "";
            result += $"Place:\nLatitude: {Lat}\nLongitude: {Lng}\nAltitude: {Alt}\nArea: {Area}" +
            $"\nName: {Name}\nPop: {Pop}\nPop: {Pop}\nNum: {Num}";
            return result;
        }
        public override void Show()
        {
            Console.WriteLine(this);
        }
        public override double Density()
        {
            return Area / Pop;
        }
    }
}
