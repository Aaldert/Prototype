using System.Collections.Generic;
using System.Drawing;

namespace Prototype.Logic
{
    public class Group
    {
        private string _name;
        private string _groupInfo;
        private int _nrUsers;
        private Image _groupImage;
        private List<Item> _veilingItems;
        private List<string> _discussies;
        private List<string> _reactions;
        private List<Image> _gallerij;

        public Group(string name, string groupInfo, int nrUsers, Image groupImage, List<Item> veilingItems, List<string> discussies, List<string> reactions, List<Image> gallerij)
        {
            _name = name;
            _groupInfo = groupInfo;
            _nrUsers = nrUsers;
            _groupImage = groupImage;
            _veilingItems = veilingItems;
            _discussies = discussies;
            _reactions = reactions;
            _gallerij = gallerij;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetGroupInfo()
        {
            return _groupInfo;
        }

        public int GetNrUsers()
        {
            return _nrUsers;
        }

        public Image GetGroupImage()
        {
            return _groupImage;
        }

        public List<Item> GetVeilingItems()
        {
            return _veilingItems;
        }

        public List<string> GetDiscussies()
        {
            return _discussies;
        }

        public List<string> GetReactions()
        {
            return _reactions;
        }

        public List<Image> GetGallerij()
        {
            return _gallerij;
        }

    }
}
