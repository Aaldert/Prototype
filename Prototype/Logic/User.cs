using System.Collections.Generic;
using System.Drawing;
using Prototype.Properties;

namespace Prototype.Logic
{
    class User
    {
        private string _userName;
        private Image _profilePhoto;
        private string _userDescription;
        private List<Item> _items;
        private Groups _groups;

        public User()
        {
            _userName = "Daniel Compagner";
            _profilePhoto = Resources.icon;
            _userDescription = "> 18 Nieuwe aanbiedingen vandaag!\r\n> 5 Nieuwe vrienden";

            Image userItem11 = Resources.item1;
            Item userItem1 = new Item(userItem11, 10, "Schoen");
            Image userItem21 = Resources.item2;
            Item userItem2 = new Item(userItem21, 10, "Duckie");
            Image userItem31 = Resources.item3;
            Item userItem3 = new Item(userItem31, 10, userItem11.ToString());
            Image userItem41 = Resources.item4;
            Item userItem4 = new Item(userItem41, 10, userItem11.ToString());
            Image userItem51 = Resources.item5;
            Item userItem5 = new Item(userItem51, 10, userItem11.ToString());
            Image userItem61 = Resources.item6;
            Item userItem6 = new Item(userItem61, 10, userItem11.ToString());
            Image userItem71 = Resources.item7;
            Item userItem7 = new Item(userItem71, 10, "Schaakbord");
            Image userItem81 = Resources.item8;
            Item userItem8 = new Item(userItem81, 10, "Schaakklok");


            _items = new List<Item> { userItem1, userItem2, userItem3, userItem4, userItem5, userItem6, userItem7, userItem8 };
            _groups = new Groups();
        }

        public string GetUserName()
        {
            return _userName;
        }

        public Image GetProfilePhoto()
        {
            return _profilePhoto;
        }

        public string GetUserDescription()
        {
            return _userDescription;
        }

        public List<Item> GetItems()
        {
            return _items;
        }

        public Groups GetGroup()
        {
            return _groups;
        }

    }
}
