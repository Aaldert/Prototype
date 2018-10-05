using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _userName = "Test User";
            _profilePhoto = Properties.Resources.icon;
            _userDescription = $"> 18 Nieuwe aanbiedingen vandaag!\n> 5 Nieuwe vrienden";

            Image userItem11 = global::Prototype.Properties.Resources.item1;
            Item userItem1 = new Item(userItem11, 10, userItem11.ToString());
            Image userItem21 = global::Prototype.Properties.Resources.item2;
            Item userItem2 = new Item(userItem21, 10, userItem11.ToString());
            Image userItem31 = global::Prototype.Properties.Resources.item3;
            Item userItem3 = new Item(userItem31, 10, userItem11.ToString());
            Image userItem41 = global::Prototype.Properties.Resources.item4;
            Item userItem4 = new Item(userItem41, 10, userItem11.ToString());
            Image userItem51 = global::Prototype.Properties.Resources.item5;
            Item userItem5 = new Item(userItem51, 10, userItem11.ToString());
            Image userItem61 = global::Prototype.Properties.Resources.item6;
            Item userItem6 = new Item(userItem61, 10, userItem11.ToString());
            Image userItem71 = global::Prototype.Properties.Resources.item7;
            Item userItem7 = new Item(userItem71, 10, userItem11.ToString());
            Image userItem81 = global::Prototype.Properties.Resources.item8;
            Item userItem8 = new Item(userItem81, 10, userItem11.ToString());


            _items = new List<Item>() { userItem1, userItem2, userItem3, userItem4, userItem5, userItem6, userItem7, userItem8 };
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
