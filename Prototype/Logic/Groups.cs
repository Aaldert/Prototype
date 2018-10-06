using System.Collections.Generic;
using System.Drawing;
using Prototype.Properties;

namespace Prototype.Logic
{
    class Groups
    {
        private List<Group> _groups;
        public Groups()
        {
            _groups = new List<Group> { CreateOverwatch(), CreateHarryPotter() }; 
        }

        private Group CreateOverwatch()
        {
            string name = "Overwatch Fan Club";
            string groupInfo = "Dit is de officele Overwatch Fan Winkel";
            int nrUser = 75;

            Image overwatchIcon = Resources.icon1;

            Image overwatchItem11 = Resources.item11;
            Item overwatchItem1 = new Item(overwatchItem11, 10, "Kussen");
            Image overwatchItem21 = Resources.item21;
            Item overwatchItem2 = new Item(overwatchItem21, 10, "Klok");
            Image overwatchItem31 = Resources.item31;
            Item overwatchItem3 = new Item(overwatchItem31, 10, "Poppetje");
            Image overwatchItem41 = Resources.item41;
            Item overwatchItem4 = new Item(overwatchItem41, 10, "Poppetje");
            Image overwatchItem51 = Resources.item51;
            Item overwatchItem5 = new Item(overwatchItem51, 10, "Poppetje");
            Image overwatchItem61 = Resources.item61;
            Item overwatchItem6 = new Item(overwatchItem61, 10, "Poppetje");
            Image overwatchItem71 = Resources.item71;
            Item overwatchItem7 = new Item(overwatchItem71, 10, "Poppetje");
            Image overwatchItem81 = Resources.item81;
            Item overwatchItem8 = new Item(overwatchItem81, 10, "Lego");

            List<Item> items = new List<Item>
            { overwatchItem1, overwatchItem2, overwatchItem3, overwatchItem4, overwatchItem5, overwatchItem6,
                overwatchItem7, overwatchItem8 };

            List<string> discussies = new List<string> { "Nieuwkomers >", "FAQ >", "Tutorials >", "Gameplay >", "Team's >" };

            List<string> reacties = new List<string> { "Hoe is het", "Reactie 2", "Trolololo" };


            Image overwatchPic1 = Resources.pic1;
            Image overwatchPic2 = Resources.pic2;
            Image overwatchPic3 = Resources.pic3;
            Image overwatchPic4 = Resources.pic4;
            Image overwatchPic5 = Resources.pic5;
            Image overwatchPic6 = Resources.pic6;
            Image overwatchPic7 = Resources.pic7;
            Image overwatchPic8 = Resources.pic8;
            Image overwatchPic9 = Resources.pic9;

            List<Image> gallerij = new List<Image>
            { overwatchPic1, overwatchPic2, overwatchPic3, overwatchPic4, overwatchPic5, overwatchPic6,
                overwatchPic7, overwatchPic8, overwatchPic9 };
            

            Group overwatch = new Group(name, groupInfo, nrUser, overwatchIcon, items, discussies, reacties, gallerij);
            return overwatch;
        }

        private Group CreateHarryPotter()
        {
            string name = "Harry Potter";
            string groupInfo = "Dit is de Harry Potter Fan Pagina iedereen is welkom!";
            int nrUser = 103;

            Image harrypotterIcon = Resources.icon2;

            Image harrypotterItem11 = Resources.item12;
            Item harrypotterItem1 = new Item(harrypotterItem11, 10, "Poppetje");
            Image harrypotterItem21 = Resources.item22;
            Item harrypottertem2 = new Item(harrypotterItem21, 10, "Poppetje");
            Image harrypotterItem31 = Resources.item32;
            Item harrypotterItem3 = new Item(harrypotterItem31, 10, "Poppetje");
            Image harrypotterItem41 = Resources.item42;
            Item harrypotterItem4 = new Item(harrypotterItem41, 10, "Poppetje");
            Image harrypotterItem51 = Resources.item52;
            Item harrypotterItem5 = new Item(harrypotterItem51, 10, "Lego");
            Image harrypotterItem61 = Resources.item62;
            Item harrypotterItem6 = new Item(harrypotterItem61, 10, "Poppetje");
            Image harrypotterItem71 = Resources.item72;
            Item harrypotterItem7 = new Item(harrypotterItem71, 10, "Knuffel");
            Image harrypotterItem81 = Resources.item82;
            Item harrypotterItem8 = new Item(harrypotterItem81, 10, "Lego");

            List<Item> items = new List<Item>
            { harrypotterItem1, harrypottertem2, harrypotterItem3, harrypotterItem4, harrypotterItem5, harrypotterItem6,
                harrypotterItem7, harrypotterItem8 };

            List<string> discussies = new List<string> { "Nieuwkomers >", "FAQ >", "Tutorials >", "Wands >", "Lore >" };

            List<string> reacties = new List<string> { "Hoe is het", "Reactie 2" };


            Image harrypotterPic1 = Resources.pic11;
            Image harrypotterPic2 = Resources.pic21;
            Image harrypotterPic3 = Resources.pic31;
            Image harrypotterPic4 = Resources.pic41;
            Image harrypotterPic5 = Resources.pic51;
            Image harrypotterPic6 = Resources.pic61;
            Image harrypotterPic7 = Resources.pic71;
            Image harrypotterPic8 = Resources.pic81;
            Image harrypotterPic9 = Resources.pic91;

            List<Image> gallerij = new List<Image>
            { harrypotterPic1, harrypotterPic2, harrypotterPic3, harrypotterPic4, harrypotterPic5, harrypotterPic6,
                harrypotterPic7, harrypotterPic8, harrypotterPic9 };


            Group harrypotter = new Group(name, groupInfo, nrUser, harrypotterIcon, items, discussies, reacties, gallerij);
            return harrypotter;
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
