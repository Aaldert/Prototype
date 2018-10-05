using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Logic
{
    public class Item
    {
        private System.Drawing.Image _photo;
        private int _price;
        private string _name;

        public Item(Image photo, int price, string name)
        {
            _photo = photo;
            _price = price;
            _name = name;
        }

        public Image GetPhoto()
        {
            return _photo;
        }

        public int GetPrice()
        {
            return _price;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
