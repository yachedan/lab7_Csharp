using System;

namespace task1
{
    class Region : Place
    {
        public string Name { get; set;}
        public uint Pop { get; set; } //Population
        public int Lcl { get; set; } //Localities
        public string Centre {get; set;} //Regional Centre


        public Region()
        {
            Lat = 0;
            Lng = 0;
            Alt = 0;
            Area = 0;
            Name = "";
            Pop = 0;
            Lcl = 0;
            Centre = "";
        }
        public Region(double lat, double lng, double alt)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = 0;
            Name = "";
            Pop = 0;
            Lcl = 0;
            Centre = "";
        }
        public Region(double lat, double lng, double alt, double area, string name,uint pop,int lcl,string centre)
        {
            Lat = lat;
            Lng = lng;
            Alt = alt;
            Area = area;
            Name = name;
            Pop = pop;
            Lcl = lcl;
            Centre = centre;
        }
        ~Region() => Console.WriteLine("Destructor is executing");

        public override string ToString()
        {
            string result = "";
            result += $"Place:\nLatitude: {Lat}\nLongitude: {Lng}\nAltitude: {Alt}\nArea: {Area}"+
            $"\nName: {Name}\nPop: {Pop}\nLcl: {Lcl}\nCentre: {Centre}";
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
