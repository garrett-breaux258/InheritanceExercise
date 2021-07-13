using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            LegCount = 4;
            Eyes = 2;
            Habitat = "Pond";
            SkinType = "Scale-Like";
        }
        public string SkinColor { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public bool RegenerativeScale { get; set; }

    }
}
