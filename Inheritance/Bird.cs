using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            LegCount = 2;
            Eyes = 2;
            Habitat = "Sky";
            SkinType = "Feathers";
        }
        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public double BeakLength { get; set; }
        public bool DoMigrate { get; set; }
    }
}
