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

            Image overwatchIcon = global::Prototype.Properties.Resources.OverwatchIcon;

            Image overwatchItem11 = global::Prototype.Properties.Resources.OverwatchItem1;
            Item overwatchItem1 = new Item(overwatchItem11, 10, "Klok");
            Image overwatchItem21 = global::Prototype.Properties.Resources.OverwatchItem2;
            Item overwatchItem2 = new Item(overwatchItem21, 10, "Figure");
            Image overwatchItem31 = global::Prototype.Properties.Resources.OverwatchItem3;
            Item overwatchItem3 = new Item(overwatchItem31, 10, "Poppetje");
            Image overwatchItem41 = global::Prototype.Properties.Resources.OverwatchItem4;
            Item overwatchItem4 = new Item(overwatchItem41, 10, "Kussen");

            List<Item> items = new List<Item>(){ overwatchItem1, overwatchItem2, overwatchItem3, overwatchItem4 };

            List<string> discussies = new List<string>(){ "Vind jij dit echt een goed spel?", "Test 2" };

            List<string> reacties = new List<string>() { "Hoe is het", "Reactie 2" };


            Image overwatchIPic1 = global::Prototype.Properties.Resources.OverwatchIPic1;
            Image overwatchPic2 = global::Prototype.Properties.Resources.OverwatchPic2;

            List<Image> gallerij = new List<Image>(){ overwatchIPic1, overwatchPic2 };
            

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
