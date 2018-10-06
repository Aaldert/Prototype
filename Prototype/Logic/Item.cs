using System.Drawing;

namespace Prototype.Logic
{
    public class Item
    {
        private Image _photo;
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
