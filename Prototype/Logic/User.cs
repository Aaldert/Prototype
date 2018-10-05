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
            _profilePhoto = Properties.Resources.UserIcon;
            _userDescription = $"> 18 Nieuwe aanbiedingen vandaag!\n> 5 Nieuwe vrienden";

            Image userItem11 = global::Prototype.Properties.Resources.OverwatchItem1;
            Item userItem1 = new Item(userItem11, 10, userItem11.ToString());
            Image userItem21 = global::Prototype.Properties.Resources.OverwatchItem2;
            Item userItem2 = new Item(userItem21, 10, userItem11.ToString());
            Image userItem31 = global::Prototype.Properties.Resources.OverwatchItem3;
            Item userItem3 = new Item(userItem31, 10, userItem11.ToString());
            Image userItem41 = global::Prototype.Properties.Resources.OverwatchItem4;
            Item userItem4 = new Item(userItem41, 10, userItem11.ToString());

            _items = new List<Item>() { userItem1, userItem2, userItem3, userItem4 };
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
