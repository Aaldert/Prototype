using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Prototype.Properties;

namespace Prototype.Logic
{
    class Groups
    {
        private List<Group> _groups;
        public Groups()
        {
            _groups = new List<Group>(){ CreateOverwatch() }; 
        }

        private Group CreateOverwatch()
        {
            string name = "Overwatch Fan Club";
            int nrUser = 75;

            Image overwatchIcon = global::Prototype.Properties.Resources.icon1;

            Image overwatchItem11 = global::Prototype.Properties.Resources.item11;
            Item overwatchItem1 = new Item(overwatchItem11, 10, "Klok");
            Image overwatchItem21 = global::Prototype.Properties.Resources.item21;
            Item overwatchItem2 = new Item(overwatchItem21, 10, "Figure");
            Image overwatchItem31 = global::Prototype.Properties.Resources.item31;
            Item overwatchItem3 = new Item(overwatchItem31, 10, "Poppetje");
            Image overwatchItem41 = global::Prototype.Properties.Resources.item41;
            Item overwatchItem4 = new Item(overwatchItem41, 10, "Kussen");
            Image overwatchItem51 = global::Prototype.Properties.Resources.item51;
            Item overwatchItem5 = new Item(overwatchItem51, 10, "Kussen");
            Image overwatchItem61 = global::Prototype.Properties.Resources.item61;
            Item overwatchItem6 = new Item(overwatchItem61, 10, "Kussen");
            Image overwatchItem71 = global::Prototype.Properties.Resources.item71;
            Item overwatchItem7 = new Item(overwatchItem71, 10, "Kussen");
            Image overwatchItem81 = global::Prototype.Properties.Resources.item81;
            Item overwatchItem8 = new Item(overwatchItem81, 10, "Kussen");

            List<Item> items = new List<Item>(){ overwatchItem1, overwatchItem2, overwatchItem3, overwatchItem4, overwatchItem5, overwatchItem6, overwatchItem7, overwatchItem8 };

            List<string> discussies = new List<string>(){ "Nieuwkomers >", "FAQ >", "Tutorials >", "Gameplay >", "Team's >" };

            List<string> reacties = new List<string>() { "Hoe is het", "Reactie 2", "Trolololo" };


            Image overwatchIPic1 = global::Prototype.Properties.Resources.pic1;
            Image overwatchPic2 = global::Prototype.Properties.Resources.pic2;
            Image overwatchPic3 = global::Prototype.Properties.Resources.pic3;
            Image overwatchPic4 = global::Prototype.Properties.Resources.pic4;
            Image overwatchPic5 = global::Prototype.Properties.Resources.pic5;
            Image overwatchPic6 = global::Prototype.Properties.Resources.pic6;
            Image overwatchPic7 = global::Prototype.Properties.Resources.pic7;
            Image overwatchPic8 = global::Prototype.Properties.Resources.pic8;
            Image overwatchPic9 = global::Prototype.Properties.Resources.pic9;

            List<Image> gallerij = new List<Image>(){ overwatchIPic1, overwatchPic2, overwatchPic3, overwatchPic4, overwatchPic5, overwatchPic6, overwatchPic7, overwatchPic8, overwatchPic9 };
            

            Group overwatch = new Group(name, nrUser, overwatchIcon, items, discussies, reacties, gallerij);
            return overwatch;
        }

        private Group CreateHarryPotter()
        {
            string name = "Harry Potter";
            int nrUser = 103;

            Image overwatchIcon = global::Prototype.Properties.Resources.icon2;

            Image overwatchItem11 = global::Prototype.Properties.Resources.item12;
            Item overwatchItem1 = new Item(overwatchItem11, 10, "Klok");
            Image overwatchItem21 = global::Prototype.Properties.Resources.item22;
            Item overwatchItem2 = new Item(overwatchItem21, 10, "Figure");
            Image overwatchItem31 = global::Prototype.Properties.Resources.item32;
            Item overwatchItem3 = new Item(overwatchItem31, 10, "Poppetje");
            Image overwatchItem41 = global::Prototype.Properties.Resources.item42;
            Item overwatchItem4 = new Item(overwatchItem41, 10, "Kussen");

            List<Item> items = new List<Item>() { overwatchItem1, overwatchItem2, overwatchItem3, overwatchItem4 };

            List<string> discussies = new List<string>() { "Nieuwkomers >", "FAQ >", "Tutorials >", "Gameplay >", "Team's >" };

            List<string> reacties = new List<string>() { "Hoe is het", "Reactie 2" };


            Image overwatchIPic1 = global::Prototype.Properties.Resources.pic11;
            Image overwatchPic2 = global::Prototype.Properties.Resources.pic21;

            List<Image> gallerij = new List<Image>() { overwatchIPic1, overwatchPic2 };


            Group overwatch = new Group(name, nrUser, overwatchIcon, items, discussies, reacties, gallerij);
            return overwatch;
        }


        public List<Group> GetGroups()
        {
            return _groups;
        }

        public Group GetGroupByName(string name)
        {
            foreach (Group group in _groups)
            {
                if (group.GetName().Equals(name))
                {
                    return group;
                }
            }
            return null;
        }
    }
}
