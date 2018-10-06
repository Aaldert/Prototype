using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Prototype.Logic;
using Prototype.Properties;

namespace Prototype
{
    public partial class Screen : Form
    {
        private User _user;
        private Dictionary<string, Panel> panels;

        private List<TabControl> _groupMenu;

        public Screen()
        {
            _user = new User();
            _groupMenu = new List<TabControl>();
            InitializeComponent();
            CreatePanels();
        }

        private void CreatePanels()
        {
            //Panel 1
            mainLabel.Text = @"Welkom " + _user.GetUserName();
            mainPic.Image = _user.GetProfilePhoto();
            mainText.Text = _user.GetUserDescription();

            panels = new Dictionary<string, Panel>();
            foreach (Group group in _user.GetGroup().GetGroups())
            {
                Groups.Controls.Add(CreateGroupPanel(group));
                //panel3
                panels.Add(group.GetName(), CreatePanel3(group));
            }

            foreach (Panel panel in panels.Values)
            {
                Controls.Add(panel);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void groepenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGroups();
        }

        private void profielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOwnProfile();
        }

        private void groupInfoLabel_Click(object sender, EventArgs e)
        {
            Label label = (Label) sender;

            ShowGroup(label.Name);
        }
        private void testOtherProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOtherProfile();
        }

        //Panel 1
        private void ShowOwnProfile()
        {           
            panel1.Visible = true;
            panel2.Visible = false;

            foreach (Panel panel in panels.Values)
            {
                panel.Visible = false;
            }
        }

        //Panel 2
        private void ShowOtherProfile()
        {
            panel1.Visible = false;
            panel2.Visible = true;

            foreach (Panel panel in panels.Values)
            {
                panel.Visible = false;
            }
        }

        //Panel 3
        private void ShowGroup(string groupName)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            foreach (Panel panel in panels.Values)
            {
                if (panel.Name.Equals(groupName))
                {
                    panel.Visible = true;
                }
                else
                {
                    panel.Visible = false;
                }                
            }         
        }

        //Panel 4
        private void ShowGroups()
        {

        }














        //Profile Group Panel
        public Panel CreateGroupPanel(Group group)
        {
            //1.1 galleryLabel
            Label galleryLabel = new Label();
            galleryLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            galleryLabel.ForeColor = Color.Black;
            galleryLabel.Location = new Point(591, 41);
            galleryLabel.Name = "galleryLabel";
            galleryLabel.Size = new Size(176, 23);
            galleryLabel.TabIndex = 10;
            galleryLabel.Text = "Gallerij";
            
            //1.2 reactionLabel
            Label reactionLabel = new Label();
            reactionLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reactionLabel.ForeColor = Color.Black;
            reactionLabel.Location = new Point(297, 41);
            reactionLabel.Name = "reactionLabel";
            reactionLabel.Size = new Size(176, 23);
            reactionLabel.TabIndex = 9;
            reactionLabel.Text = "Nieuwe Reacties";

            //1.3 itemsLabel
            Label itemsLabel = new Label();
            itemsLabel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemsLabel.ForeColor = Color.Black;
            itemsLabel.Location = new Point(3, 41);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(176, 23);
            itemsLabel.TabIndex = 8;
            itemsLabel.Text = "Nieuwe Spullen";

            //1.4.1 itemsFlow
            FlowLayoutPanel itemsFlow = new FlowLayoutPanel();
            foreach (Item item in group.GetVeilingItems())
            {
                //1.4.1.1.1 itemPic
                PictureBox itemPic = new PictureBox();
                itemPic.Image = item.GetPhoto();
                itemPic.Location = new Point(22, 6);
                itemPic.Name = "itemPic";
                itemPic.Size = new Size(50, 50);
                itemPic.SizeMode = PictureBoxSizeMode.StretchImage;
                itemPic.TabIndex = 11;
                itemPic.TabStop = false;

                //1.4.1.1.2 itemInfo
                Label itemInfo = new Label();
                itemInfo.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
                itemInfo.ForeColor = Color.Black;
                itemInfo.Name = "itemInfo";
                itemInfo.Size = new Size(50, 13);
                itemInfo.TabIndex = 9;
                itemInfo.Location = new Point(22, 59);
                itemInfo.TextAlign = ContentAlignment.MiddleCenter;
                itemInfo.Text = item.GetName();

                //1.4.1.1 items
                Panel items = new Panel();
                items.Controls.Add(itemPic);
                items.Controls.Add(itemInfo);
                items.Location = new Point(3, 3);
                items.Name = "Items";
                items.Size = new Size(70, 75);
                items.TabIndex = 12;

                itemsFlow.Controls.Add(items);
            }
            itemsFlow.Location = new Point(3, 3);
            itemsFlow.Name = "ItemsFlow";
            itemsFlow.Size = new Size(250, 167);
            itemsFlow.TabIndex = 0;
            itemsFlow.AutoScroll = true;


            //1.4.2 reactionFlow
            FlowLayoutPanel reactionsFlow = new FlowLayoutPanel();
            foreach (string str in group.GetReactions())
            {
                //1.4.2.1.1 text
                TextBox text = new TextBox();
                text.Enabled = false;
                text.Location = new Point(38, 3);
                text.Multiline = true;
                text.Name = "text";
                text.ReadOnly = true;
                text.Size = new Size(240, 69);
                text.TabIndex = 4;
                text.Text = str;

                //1.4.2.1.2 userPic
                PictureBox userPic = new PictureBox();
                userPic.Image = Resources.UserIcon;
                userPic.Location = new Point(3, 2);
                userPic.Name = "userPic";
                userPic.SizeMode = PictureBoxSizeMode.StretchImage;
                userPic.Size = new Size(30, 30);
                userPic.TabIndex = 11;
                userPic.TabStop = false;

                //1.4.2.1 reaction
                Panel reaction = new Panel();
                reaction.Controls.Add(text);
                reaction.Controls.Add(userPic);
                reaction.Location = new Point(3, 3);
                reaction.Name = "Reaction";
                reaction.Size = new Size(280, 75);
                reaction.TabIndex = 7;

                reactionsFlow.Controls.Add(reaction);
            }
            reactionsFlow.Location = new Point(297, 3);
            reactionsFlow.Name = "ReactionsFlow";
            reactionsFlow.Size = new Size(308, 167);
            reactionsFlow.TabIndex = 1;
            reactionsFlow.AutoScroll = true;

            //1.4.3 GallaryFlow
            FlowLayoutPanel gallaryFlow = new FlowLayoutPanel();
            foreach (Image image in group.GetGallerij())
            {
                //1.4.3.1 Photo
                PictureBox photo = new PictureBox();
                photo.Image = image;
                photo.Location = new Point(3, 3);
                photo.Name = "Photo";
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
                photo.Size = new Size(90, 80);
                photo.TabIndex = 8;

                gallaryFlow.Controls.Add(photo);
            }
            gallaryFlow.Location = new Point(591, 3);
            gallaryFlow.Name = "GallaryFlow";
            gallaryFlow.Size = new Size(310, 167);
            gallaryFlow.TabIndex = 1;
            gallaryFlow.AutoScroll = true;

            //1.4 groupFlow
            FlowLayoutPanel groupFlow = new FlowLayoutPanel();
            groupFlow.Controls.Add(itemsFlow);
            groupFlow.Controls.Add(reactionsFlow);
            groupFlow.Controls.Add(gallaryFlow);
            groupFlow.Location = new Point(3, 67);
            groupFlow.Name = "GroupFlow";
            groupFlow.Size = new Size(898, 170);
            groupFlow.TabIndex = 7;

            //1.5 groupPhoto
            PictureBox groupPhoto = new PictureBox();
            groupPhoto.Image = group.GetGroupImage();
            groupPhoto.Location = new Point(7, 9);
            groupPhoto.Name = "groupPhoto";
            groupPhoto.Size = new Size(20, 20);
            groupPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            groupPhoto.TabIndex = 6;
            groupPhoto.TabStop = false;

            //1.6 groupInfoLabel
            Label groupInfoLabel = new Label();
            groupInfoLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupInfoLabel.ForeColor = Color.FromArgb(7, 147, 199);
            groupInfoLabel.Location = new Point(34, 9);
            groupInfoLabel.Name = group.GetName();
            groupInfoLabel.Size = new Size(200, 23);
            groupInfoLabel.TabIndex = 5;
            groupInfoLabel.Text = group.GetName();
            groupInfoLabel.Click += groupInfoLabel_Click;

            //1.7 nrUserIcon
            PictureBox nrUserIcon = new PictureBox();
            nrUserIcon.Image = Resources.UserIcon;
            nrUserIcon.Location = new Point(265, 11);
            nrUserIcon.Name = "nrUserIcon";
            nrUserIcon.Size = new Size(20, 20);
            nrUserIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            nrUserIcon.TabIndex = 6;
            nrUserIcon.TabStop = false;

            //1.8 groupNrLabel
            Label groupNrLabel = new Label();
            groupNrLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupNrLabel.ForeColor = Color.FromArgb(0, 0, 0);
            groupNrLabel.Location = new Point(228, 9);
            groupNrLabel.Name = group.GetName();
            groupNrLabel.Size = new Size(40, 23);
            groupNrLabel.TabIndex = 5;
            groupNrLabel.Text = group.GetNrUsers().ToString();
            
            //1
            Panel groupPanel = new Panel();

            groupPanel.Controls.Add(galleryLabel);
            groupPanel.Controls.Add(reactionLabel);
            groupPanel.Controls.Add(itemsLabel);
            groupPanel.Controls.Add(groupFlow);
            groupPanel.Controls.Add(groupPhoto);
            groupPanel.Controls.Add(groupInfoLabel);
            groupPanel.Controls.Add(nrUserIcon);
            groupPanel.Controls.Add(groupNrLabel);
            groupPanel.Location = new Point(3, 3);
            groupPanel.Name = group.GetName();
            groupPanel.Size = new Size(890, 240);
            groupPanel.TabIndex = 3;
            groupPanel.BorderStyle = BorderStyle.FixedSingle;
            return groupPanel;
        }

        //Panel 3
        public Panel CreatePanel3(Group group)
        {
            //3.1 menu
            TabControl groupMenu = new TabControl();
            groupMenu.Controls.Add(CreateHomeTabPage(group));
            groupMenu.Controls.Add(CreateVeilingenTabPage(group));
            groupMenu.Controls.Add(CreateDiscussiesTabPage(group));
            groupMenu.Controls.Add(CreateGallerijTabPage(group));
            groupMenu.Location = new Point(28, 158);
            groupMenu.Name = "menu";
            groupMenu.Size = new Size(963, 683);
            //_groupMenu.TabIndex = 0;
            groupMenu.SelectedIndex = 0;
            groupMenu.TabStop = false;
            groupMenu.KeyDown += Form1_KeyDown;
            _groupMenu.Add(groupMenu);

            //3.2 groupName
            Label groupName = new Label();
            Font font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupName.Font = font;
            groupName.ForeColor = Color.FromArgb(7, 147, 199);
            groupName.Location = new Point(173, 22);
            groupName.Name = "GroupName";
            groupName.TabIndex = 2;
            groupName.Text = group.GetName();
            Size textSize = TextRenderer.MeasureText(groupName.Text, font);
            groupName.Size = new Size(textSize.Width, textSize.Height);

            //3.3 memberNr
            Label memberNr = new Label();
            memberNr.Font = font;
            memberNr.ForeColor = Color.Black;
            memberNr.Location = new Point(173 + 10 + groupName.Size.Width, 22);
            memberNr.Name = "memberNr";
            memberNr.TabIndex = 3;
            memberNr.Text = group.GetNrUsers().ToString();
            Size numberSize = TextRenderer.MeasureText(memberNr.Text, font);
            memberNr.Size = new Size(numberSize.Width, numberSize.Height);

            //3.4 nrUserIcon
            PictureBox nrUserIcon = new PictureBox();
            nrUserIcon.Image = Resources.UserIcon;
            nrUserIcon.Location = new Point(173 + 10 + groupName.Size.Width + memberNr.Size.Width, 22);
            nrUserIcon.Name = "nrUserIcon";
            nrUserIcon.Size = new Size(20, 20);
            nrUserIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            nrUserIcon.TabIndex = 6;
            nrUserIcon.TabStop = false;

            //3.5 groupInfo
            TextBox groupInfo = new TextBox();
            groupInfo.Enabled = false;
            groupInfo.Location = new Point(173, 48);
            groupInfo.Multiline = true;
            groupInfo.Name = "GroupInfo";
            groupInfo.ReadOnly = true;
            groupInfo.Size = new Size(247, 94);
            groupInfo.TabIndex = 1;
            groupInfo.Text = group.GetGroupInfo();

            //3.6 groupPic
            PictureBox groupPic = new PictureBox();
            groupPic.Image = group.GetGroupImage();
            groupPic.Location = new Point(28, 22);
            groupPic.Name = "GroupPic";
            groupPic.Size = new Size(120, 120);
            groupPic.SizeMode = PictureBoxSizeMode.StretchImage;
            groupPic.TabIndex = 0;
            groupPic.TabStop = false;

            
            //3
            Panel panel3 = new Panel();
            panel3.SuspendLayout();
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(groupMenu);
            panel3.Controls.Add(groupName);
            panel3.Controls.Add(memberNr);
            panel3.Controls.Add(nrUserIcon);
            panel3.Controls.Add(groupInfo);
            panel3.Controls.Add(groupPic);
            panel3.Location = new Point(235, 149);
            panel3.Name = group.GetName();
            panel3.Size = new Size(994, 844);
            panel3.TabIndex = 5;
            panel3.Visible = false;
            return panel3;
        }

        //Home Tab 
        public TabPage CreateHomeTabPage(Group group)
        {
            //3.1.1 galleryFlow CHECK
            FlowLayoutPanel galleryFlow = new FlowLayoutPanel();
            foreach (Image photo in group.GetGallerij())
            {
                //3.1.1.1 gallaryPhoto CHECK
                PictureBox gallaryPhoto = new PictureBox();
                gallaryPhoto.Image = photo;
                gallaryPhoto.Location = new Point(3, 3);
                gallaryPhoto.Name = "galleryPhoto";
                gallaryPhoto.Size = new Size(60, 60);
                gallaryPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                gallaryPhoto.TabIndex = 1;
                gallaryPhoto.TabStop = false;
                gallaryPhoto.BorderStyle = BorderStyle.FixedSingle;

                galleryFlow.Controls.Add(gallaryPhoto);
            }
            galleryFlow.Location = new Point(10, 466);
            galleryFlow.Name = "galleryFlow";
            galleryFlow.Size = new Size(900, 171);
            galleryFlow.TabIndex = 7;
            galleryFlow.BorderStyle = BorderStyle.FixedSingle;

            //3.1.2 galleryLabel CHECK
            Label galleryLabel = new Label();
            galleryLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            galleryLabel.ForeColor = Color.Black;
            galleryLabel.Location = new Point(8, 440);
            galleryLabel.Name = "galleryLabel";
            galleryLabel.Size = new Size(128, 23);
            galleryLabel.TabIndex = 7;
            galleryLabel.Text = "Gallerij";
            galleryLabel.Click += ClickTab;

            //3.1.3 discussionsTable CHECK
            TableLayoutPanel discussionsTable = new TableLayoutPanel();
            discussionsTable.ColumnCount = 5;
            discussionsTable.RowCount = 4;

            discussionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            discussionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            discussionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            discussionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            discussionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));

            discussionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            discussionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            discussionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            discussionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            discussionsTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            //discussionsTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            int count = 0;
            foreach (string discussion in group.GetDiscussies())
            {
                //3.1.3.1 discussionBox Check
                Label discussionBox = new Label();
                discussionBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                discussionBox.ForeColor = Color.Black;
                discussionBox.Location = new Point(0, 0);
                discussionBox.Name = "discussionBox";
                discussionBox.Size = new Size(300, 200);
                discussionBox.TabIndex = 8;
                discussionBox.Text = discussion;
                discussionBox.BorderStyle = BorderStyle.FixedSingle;

                if (count <= 3)
                {
                    discussionsTable.Controls.Add(discussionBox, 0, count);
                }
                else
                {
                    discussionsTable.Controls.Add(discussionBox, 2, (count - 4));
                }
                
                count++;
            }
            discussionsTable.Location = new Point(10, 249);
            discussionsTable.Name = "discussionsTable";
            discussionsTable.Size = new Size(900, 171);
            discussionsTable.TabIndex = 6;
            discussionsTable.BorderStyle = BorderStyle.FixedSingle;

            //3.1.4 discussionsLabel CHECK
            Label discussionsLabel = new Label();
            discussionsLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discussionsLabel.ForeColor = Color.Black;
            discussionsLabel.Location = new Point(6, 223);
            discussionsLabel.Name = "discussionsLabel";
            discussionsLabel.Size = new Size(128, 23);
            discussionsLabel.TabIndex = 6;
            discussionsLabel.Text = "Discussies";
            discussionsLabel.Click += ClickTab;

            //3.1.5 veilingenFlow CHECK
            FlowLayoutPanel veilingenFlow = new FlowLayoutPanel();
            foreach (Item item in group.GetVeilingItems())
            {
                //3.1.5.1.1 itemName
                Label itemName = new Label();
                itemName.TextAlign = ContentAlignment.MiddleCenter;
                itemName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                itemName.ForeColor = Color.Black;
                itemName.Name = "itemName";
                itemName.TabIndex = 9;
                itemName.Text = item.GetName();
                itemName.Location = new Point(4, 4);
                itemName.Size = new Size(120, 30);
                itemName.BorderStyle = BorderStyle.FixedSingle;

                //3.1.5.1.2 itemPhoto
                PictureBox itemPhoto = new PictureBox();
                itemPhoto.Image = item.GetPhoto();
                itemPhoto.Location = new Point(4, 34);
                itemPhoto.Name = "itemPhoto";
                itemPhoto.Size = new Size(120, 120);
                itemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                itemPhoto.TabIndex = 5;
                itemPhoto.TabStop = false;
                itemPhoto.BorderStyle = BorderStyle.FixedSingle;


                //3.1.5.1 itemPanel
                Panel itemPanel = new Panel();
                itemPanel.Controls.Add(itemName);
                itemPanel.Controls.Add(itemPhoto);
                itemPanel.Location = new Point(3, 3);
                itemPanel.Name = "itemPanel";
                itemPanel.Size = new Size(130, 160);
                itemPanel.TabIndex = 0;
                //itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                veilingenFlow.Controls.Add(itemPanel);
            }
            veilingenFlow.Location = new Point(10, 34);
            veilingenFlow.Name = "VeilingenFlow";
            veilingenFlow.Size = new Size(900, 171);
            veilingenFlow.TabIndex = 5;
            veilingenFlow.BorderStyle = BorderStyle.FixedSingle;
            veilingenFlow.AutoScroll = true;

            //3.1.6 veilingenLabel CHECK
            Label veilingenLabel = new Label();
            veilingenLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            veilingenLabel.ForeColor = Color.Black;
            veilingenLabel.Location = new Point(6, 8);
            veilingenLabel.Name = "veilingenLabel";
            veilingenLabel.Size = new Size(128, 23);
            veilingenLabel.TabIndex = 4;
            veilingenLabel.Text = "Veilingen";
            veilingenLabel.Click += ClickTab;

            //3.1
            TabPage home = new TabPage();
            home.Controls.Add(galleryFlow);
            home.Controls.Add(galleryLabel);
            home.Controls.Add(discussionsTable);
            home.Controls.Add(discussionsLabel);
            home.Controls.Add(veilingenFlow);
            home.Controls.Add(veilingenLabel);
            home.Location = new Point(4, 22);
            home.Name = "Home";
            home.Padding = new Padding(3);
            home.Size = new Size(955, 657);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.TabStop = false;

            return home;
        }

        //Veilingen Tab
        public TabPage CreateVeilingenTabPage(Group group)
        {
            //3.2.1 veilingenFlow CHECK
            FlowLayoutPanel veilingenFlow = new FlowLayoutPanel();
            foreach (Item item in group.GetVeilingItems())
            {
                //3.2.1.1.1 itemName
                Label itemName = new Label();
                itemName.TextAlign = ContentAlignment.MiddleCenter;
                itemName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                itemName.ForeColor = Color.Black;
                itemName.Name = "itemName";
                itemName.TabIndex = 9;
                itemName.Text = item.GetName();
                itemName.Location = new Point(4, 4);
                itemName.Size = new Size(120, 30);
                itemName.BorderStyle = BorderStyle.FixedSingle;

                //3.2.1.1.1 itemPhoto
                PictureBox itemPhoto = new PictureBox();
                itemPhoto.Image = item.GetPhoto();
                itemPhoto.Location = new Point(4, 34);
                itemPhoto.Name = "itemPhoto";
                itemPhoto.Size = new Size(120, 120);
                itemPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                itemPhoto.TabIndex = 5;
                itemPhoto.TabStop = false;
                itemPhoto.BorderStyle = BorderStyle.FixedSingle;

                //3.2.1.1.1 itemPrice
                Label itemPrice = new Label();
                itemPrice.TextAlign = ContentAlignment.MiddleCenter;
                itemPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                itemPrice.ForeColor = Color.Black;
                itemPrice.Name = "itemPrice";
                itemPrice.TabIndex = 9;
                itemPrice.Text = item.GetPrice().ToString() + "$";
                itemPrice.Location = new Point(4, 150);
                itemPrice.Size = new Size(120, 30);
                itemPrice.BorderStyle = BorderStyle.FixedSingle;


                //3.2.1.1 itemPanel
                Panel itemPanel = new Panel();
                itemPanel.Controls.Add(itemName);
                itemPanel.Controls.Add(itemPhoto);
                itemPanel.Controls.Add(itemPrice);
                itemPanel.Location = new Point(3, 3);
                itemPanel.Name = "itemPanel";
                itemPanel.Size = new Size(130, 180);
                itemPanel.TabIndex = 0;
                //itemPanel.BorderStyle = BorderStyle.FixedSingle;

                veilingenFlow.Controls.Add(itemPanel);
            }
            veilingenFlow.Location = new Point(10, 34);
            veilingenFlow.Name = "VeilingenFlow";
            veilingenFlow.Size = new Size(900, 600);
            veilingenFlow.TabIndex = 5;
            veilingenFlow.BorderStyle = BorderStyle.FixedSingle;
            veilingenFlow.AutoScroll = true;

            //3.2.2 veilingenLabel CHECK
            Label veilingenLabel = new Label();
            veilingenLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            veilingenLabel.ForeColor = Color.Black;
            veilingenLabel.Location = new Point(6, 8);
            veilingenLabel.Name = "VeilingenLabel";
            veilingenLabel.Size = new Size(128, 23);
            veilingenLabel.TabIndex = 4;
            veilingenLabel.Text = "Veilingen";

            //3.2
            TabPage veilingen = new TabPage();
            veilingen.Controls.Add(veilingenFlow);
            veilingen.Controls.Add(veilingenLabel);
            veilingen.Location = new Point(4, 22);
            veilingen.Name = "Veilingen";
            veilingen.Padding = new Padding(3);
            veilingen.Size = new Size(955, 657);
            veilingen.Text = "Veilingen";
            veilingen.UseVisualStyleBackColor = true;

            return veilingen;
        }

        //Discusses Tab
        public TabPage CreateDiscussiesTabPage(Group group)
        {
            //3.3.1 discussiesFlow CHECK
            FlowLayoutPanel discussiesFlow = new FlowLayoutPanel();
            foreach (string discussion in group.GetDiscussies())
            {
                //3.3.1.1.1 discussion
                Label discussionName = new Label();
                discussionName.TextAlign = ContentAlignment.MiddleCenter;
                discussionName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                discussionName.ForeColor = Color.Black;
                discussionName.Name = "discussionName";
                discussionName.TabIndex = 9;
                discussionName.Text = discussion;
                discussionName.Location = new Point(4, 4);
                discussionName.Size = new Size(120, 30);
                discussionName.BorderStyle = BorderStyle.FixedSingle;



                //3.3.1.1
                Panel discussiePanel = new Panel();
                discussiePanel.Controls.Add(discussionName);
                discussiePanel.Location = new Point(3, 3);
                discussiePanel.Name = "itemPanel";
                discussiePanel.Size = new Size(860, 180);
                discussiePanel.TabIndex = 0;
                discussiePanel.BorderStyle = BorderStyle.FixedSingle;


                discussiesFlow.Controls.Add(discussiePanel);
            }
            discussiesFlow.Location = new Point(10, 34);
            discussiesFlow.Name = "discussiesFlow";
            discussiesFlow.Size = new Size(900, 600);
            discussiesFlow.TabIndex = 5;
            discussiesFlow.BorderStyle = BorderStyle.FixedSingle;
            discussiesFlow.AutoScroll = true;

            //3.3.2 discussiesLabel CHECK
            Label discussiesLabel = new Label();
            discussiesLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discussiesLabel.ForeColor = Color.Black;
            discussiesLabel.Location = new Point(6, 8);
            discussiesLabel.Name = "discussiesLabel";
            discussiesLabel.Size = new Size(128, 23);
            discussiesLabel.TabIndex = 4;
            discussiesLabel.Text = "Discussies";


            //3.3
            TabPage discussions = new TabPage();
            discussions.Controls.Add(discussiesFlow);
            discussions.Controls.Add(discussiesLabel);
            discussions.Location = new Point(4, 22);
            discussions.Name = "discussions";
            discussions.Padding = new Padding(3);
            discussions.Size = new Size(955, 657);
            discussions.Text = "Discussies";
            discussions.UseVisualStyleBackColor = true;

            return discussions;
        }

        //Gallerij Tab
        public TabPage CreateGallerijTabPage(Group group)
        {
            //3.2.1 gallerijFlow CHECK
            FlowLayoutPanel gallerijFlow = new FlowLayoutPanel();
            foreach (Image pic in group.GetGallerij())
            {
                //3.2.1.1.1 photo
                PictureBox photo = new PictureBox();
                photo.Image = pic;
                photo.Location = new Point(180, 0);
                photo.Name = "photo";
                photo.Size = new Size(550, 550);
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
                photo.TabIndex = 5;
                photo.TabStop = false;
                photo.BorderStyle = BorderStyle.FixedSingle;

                //3.1.5.1 photoPanel
                Panel photoPanel = new Panel();
                photoPanel.Controls.Add(photo);
                photoPanel.Location = new Point(3, 3);
                photoPanel.Name = "photoPanel";
                photoPanel.Size = new Size(860, 600);
                photoPanel.TabIndex = 0;

                gallerijFlow.Controls.Add(photoPanel);
            }
            gallerijFlow.Location = new Point(10, 34);
            gallerijFlow.Name = "gallerijFlow";
            gallerijFlow.Size = new Size(900, 600);
            gallerijFlow.TabIndex = 5;
            gallerijFlow.BorderStyle = BorderStyle.FixedSingle;
            gallerijFlow.AutoScroll = true;

            //3.3.2 gallerijLabel CHECK
            Label gallerijLabel = new Label();
            gallerijLabel.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gallerijLabel.ForeColor = Color.Black;
            gallerijLabel.Location = new Point(6, 8);
            gallerijLabel.Name = "gallerijLabel";
            gallerijLabel.Size = new Size(128, 23);
            gallerijLabel.TabIndex = 4;
            gallerijLabel.Text = "Gallerij";

            //3.3
            TabPage gallerij = new TabPage();
            gallerij.Controls.Add(gallerijFlow);
            gallerij.Controls.Add(gallerijLabel);
            gallerij.Location = new Point(4, 22);
            gallerij.Name = "gallerij";
            gallerij.Padding = new Padding(3);
            gallerij.Size = new Size(955, 657);
            gallerij.Text = "Gallerij";
            gallerij.UseVisualStyleBackColor = true;

            return gallerij;
        }

        private void Screen_Click(object sender, EventArgs e)
        {
            Debug.Print("HIT");

            if (ActiveControl != null)
            {
                Debug.Print(ActiveControl.Name + " " + this.Name);
            }
        }

        private void ClickTab(object sender, EventArgs e)
        {
            Label s = (Label) sender;
            int index = -1;
            for (int i = 0; i < _groupMenu.Count; i++)
            {
                if (_groupMenu[i].Parent.Name.Equals(s.Parent.Parent.Parent.Name))
                {
                    index = i;
                }
            }

            if (s.Name.Equals("veilingenLabel"))
            {
                _groupMenu[index].SelectedIndex = 1;  
            }
            else if (s.Name.Equals("discussionsLabel"))
            {
                _groupMenu[index].SelectedIndex = 2;
            }
            else if (s.Name.Equals("galleryLabel"))
            {
                _groupMenu[index].SelectedIndex = 3;
            }
        }
    }
}
