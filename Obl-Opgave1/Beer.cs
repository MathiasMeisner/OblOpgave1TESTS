using System;

namespace Obl_Opgave1
{
    public class Beer
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value == null) { throw new ArgumentNullException(); }
                if (value.Length < 4) { throw new ArgumentException(); }
                else
                    _name = value;
            }
        }

        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        private int _price;

        public int Price
        {
            get => _price;
            set
            {
                if (value < 1) { throw new ArgumentOutOfRangeException(); }
                _price = value;
            }
        }

        private double _abv;

        public double Abv
        {
            get => _abv;
            set
            {
                if (value < 0 || value > 100) { throw new ArgumentOutOfRangeException(); }
                _abv = value;
            }
        }

        public Beer(string name, int id, int price, double abv)
        {
            Name = name;
            Id = id;
            Price = price;
            Abv = abv;
        }

        public Beer()
        {

        }

    }
}
