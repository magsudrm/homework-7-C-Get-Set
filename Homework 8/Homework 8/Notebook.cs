using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8
{
    internal class Notebook
    {
        public Notebook()
        {
        }

        public string Name
        {
            get => _name;
            set
            {
                if(IsNameTrue(value))
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if(IsPriceTrue(value))
                _price = value;
            }
        }

        private string _name;
        private int _price;

        public bool IsNameTrue(string name)
        {
            if (name != null)
            {
                return true;
            }
            else return false;
        }
        public bool IsPriceTrue(int price)
        {
            if (price !=0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
