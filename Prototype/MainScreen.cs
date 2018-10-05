using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototype.Logic;

namespace Prototype
{
    public partial class Screen : Form
    {
        private User _user;
        private Dictionary<string, Panel> panels;

        public Screen()
        {
            _user = new User();
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
                this.Controls.Add(panel);
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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


        //Panel 1
        private void ShowOwnProfile()
        {         
            //Make right panel visible
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
            galleryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            galleryLabel.ForeColor = System.Drawing.Color.Black;
            galleryLabel.Location = new System.Drawing.Point(591, 41);
            galleryLabel.Name = "galleryLabel";
            galleryLabel.Size = new System.Drawing.Size(176, 23);
            galleryLabel.TabIndex = 10;
            galleryLabel.Text = "Gallerij";
            
            //1.2 reactionLabel
            Label reactionLabel = new Label();
            reactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reactionLabel.ForeColor = System.Drawing.Color.Black;
            reactionLabel.Location = new System.Drawing.Point(297, 41);
            reactionLabel.Name = "reactionLabel";
            reactionLabel.Size = new System.Drawing.Size(176, 23);
            reactionLabel.TabIndex = 9;
            reactionLabel.Text = "Nieuwe Reacties";

            //1.3 itemsLabel
            Label itemsLabel = new Label();
            itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemsLabel.ForeColor = System.Drawing.Color.Black;
            itemsLabel.Location = new System.Drawing.Point(3, 41);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new System.Drawing.Size(176, 23);
            itemsLabel.TabIndex = 8;
            itemsLabel.Text = "Nieuwe Spullen";

            //1.4.1 itemsFlow
            FlowLayoutPanel itemsFlow = new FlowLayoutPanel();
            foreach (Item item in group.GetVeilingItems())
            {
                //1.4.1.1.1 itemPic
                PictureBox itemPic = new PictureBox();
                itemPic.Image = item.GetPhoto();
                itemPic.Location = new System.Drawing.Point(22, 6);
                itemPic.Name = "itemPic";
                itemPic.Size = new System.Drawing.Size(50, 50);
                itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                itemPic.TabIndex = 11;
                itemPic.TabStop = false;

                //1.4.1.1.2 itemInfo
                Label itemInfo = new Label();
                itemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                itemInfo.ForeColor = System.Drawing.Color.Black;
                itemInfo.Name = "itemInfo";
                itemInfo.Size = new System.Drawing.Size(50, 13);
                itemInfo.TabIndex = 9;
                itemInfo.Location = new System.Drawing.Point(22, 59);
                itemInfo.TextAlign = ContentAlignment.MiddleCenter;
                itemInfo.Text = item.GetName();

                //1.4.1.1 items
                Panel items = new Panel();
                items.Controls.Add(itemPic);
                items.Controls.Add(itemInfo);
                items.Location = new System.Drawing.Point(3, 3);
                items.Name = "Items";
                items.Size = new System.Drawing.Size(70, 75);
                items.TabIndex = 12;

                itemsFlow.Controls.Add(items);
            }
            itemsFlow.Location = new System.Drawing.Point(3, 3);
            itemsFlow.Name = "ItemsFlow";
            itemsFlow.Size = new System.Drawing.Size(250, 167);
            itemsFlow.TabIndex = 0;
            itemsFlow.AutoScroll = true;


            //1.4.2 reactionFlow
            FlowLayoutPanel reactionsFlow = new FlowLayoutPanel();
            foreach (string str in group.GetReactions())
            {
                //1.4.2.1.1 text
                TextBox text = new TextBox();
                text.Enabled = false;
                text.Location = new System.Drawing.Point(38, 3);
                text.Multiline = true;
                text.Name = "text";
                text.ReadOnly = true;
                text.Size = new System.Drawing.Size(240, 69);
                text.TabIndex = 4;
                text.Text = str;

                //1.4.2.1.2 userPic
                PictureBox userPic = new PictureBox();
                userPic.Image = global::Prototype.Properties.Resources.UserIcon;
                userPic.Location = new System.Drawing.Point(3, 2);
                userPic.Name = "userPic";
                userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                userPic.Size = new System.Drawing.Size(30, 30);
                userPic.TabIndex = 11;
                userPic.TabStop = false;

                //1.4.2.1 reaction
                Panel reaction = new Panel();
                reaction.Controls.Add(text);
                reaction.Controls.Add(userPic);
                reaction.Location = new System.Drawing.Point(3, 3);
                reaction.Name = "Reaction";
                reaction.Size = new System.Drawing.Size(280, 75);
                reaction.TabIndex = 7;

                reactionsFlow.Controls.Add(reaction);
            }
            reactionsFlow.Location = new System.Drawing.Point(297, 3);
            reactionsFlow.Name = "ReactionsFlow";
            reactionsFlow.Size = new System.Drawing.Size(308, 167);
            reactionsFlow.TabIndex = 1;
            reactionsFlow.AutoScroll = true;

            //1.4.3 GallaryFlow
            FlowLayoutPanel gallaryFlow = new FlowLayoutPanel();
            foreach (Image image in group.GetGallerij())
            {
                //1.4.3.1 Photo
                PictureBox photo = new PictureBox();
                photo.Image = image;
                photo.Location = new System.Drawing.Point(3, 3);
                photo.Name = "Photo";
                photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                photo.Size = new System.Drawing.Size(90, 80);
                photo.TabIndex = 8;

                gallaryFlow.Controls.Add(photo);
            }
            gallaryFlow.Location = new System.Drawing.Point(591, 3);
            gallaryFlow.Name = "GallaryFlow";
            gallaryFlow.Size = new System.Drawing.Size(310, 167);
            gallaryFlow.TabIndex = 1;
            gallaryFlow.AutoScroll = true;

            //1.4 groupFlow
            FlowLayoutPanel groupFlow = new FlowLayoutPanel();
            groupFlow.Controls.Add(itemsFlow);
            groupFlow.Controls.Add(reactionsFlow);
            groupFlow.Controls.Add(gallaryFlow);
            groupFlow.Location = new System.Drawing.Point(3, 67);
            groupFlow.Name = "GroupFlow";
            groupFlow.Size = new System.Drawing.Size(898, 170);
            groupFlow.TabIndex = 7;

            //1.5 groupPhoto
            PictureBox groupPhoto = new PictureBox();
            groupPhoto.Image = group.GetGroupImage();
            groupPhoto.Location = new System.Drawing.Point(7, 9);
            groupPhoto.Name = "groupPhoto";
            groupPhoto.Size = new System.Drawing.Size(20, 20);
            groupPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            groupPhoto.TabIndex = 6;
            groupPhoto.TabStop = false;

            //1.6 groupInfoLabel
            Label groupInfoLabel = new Label();
            groupInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            groupInfoLabel.Location = new System.Drawing.Point(34, 9);
            groupInfoLabel.Name = group.GetName();
            groupInfoLabel.Size = new System.Drawing.Size(176, 23);
            groupInfoLabel.TabIndex = 5;
            groupInfoLabel.Text = group.GetName() + " " + group.GetNrUsers();
            groupInfoLabel.Click += new System.EventHandler(this.groupInfoLabel_Click);

            //1
            Panel groupPanel = new Panel();

            groupPanel.Controls.Add(galleryLabel);
            groupPanel.Controls.Add(reactionLabel);
            groupPanel.Controls.Add(itemsLabel);
            groupPanel.Controls.Add(groupFlow);
            groupPanel.Controls.Add(groupPhoto);
            groupPanel.Controls.Add(groupInfoLabel);
            groupPanel.Location = new System.Drawing.Point(3, 3);
            groupPanel.Name = group.GetName();
            groupPanel.Size = new System.Drawing.Size(890, 240);
            groupPanel.TabIndex = 3;
            groupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            return groupPanel;
        }

        //Panel 3
        public Panel CreatePanel3(Group group)
        {
            //3.1 menu
            TabControl menu = new TabControl();
            menu.Controls.Add(CreateHomeTabPage(group));
            menu.Location = new System.Drawing.Point(28, 158);
            menu.Name = "menu";
            menu.SelectedIndex = 0;
            menu.Size = new System.Drawing.Size(963, 683);
            menu.TabIndex = 4;

            //3.2 memberNr
            Label memberNr = new Label();
            memberNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            memberNr.ForeColor = System.Drawing.Color.Black;
            memberNr.Location = new System.Drawing.Point(307, 22);
            memberNr.Name = "memberNr";
            memberNr.Size = new System.Drawing.Size(128, 23);
            memberNr.TabIndex = 3;
            memberNr.Text = group.GetNrUsers().ToString();

            //3.3 groupName
            Label groupName = new Label();
            groupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            groupName.Location = new System.Drawing.Point(173, 22);
            groupName.Name = "GroupName";
            groupName.Size = new System.Drawing.Size(128, 23);
            groupName.TabIndex = 2;
            groupName.Text = "GroupName";

            //3.4 groupInfo
            TextBox groupInfo = new TextBox();
            groupInfo.Enabled = false;
            groupInfo.Location = new System.Drawing.Point(173, 48);
            groupInfo.Multiline = true;
            groupInfo.Name = "GroupInfo";
            groupInfo.ReadOnly = true;
            groupInfo.Size = new System.Drawing.Size(247, 94);
            groupInfo.TabIndex = 1;
            groupInfo.Text = "GroupInfo\r\n";

            //3.5 groupPic
            PictureBox groupPic = new PictureBox();
            groupPic.Image = group.GetGroupImage();
            groupPic.Location = new System.Drawing.Point(28, 22);
            groupPic.Name = "GroupPic";
            groupPic.Size = new System.Drawing.Size(120, 120);
            groupPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            groupPic.TabIndex = 0;
            groupPic.TabStop = false;

            //3
            Panel panel3 = new Panel();
            panel3.SuspendLayout();
            panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            panel3.Controls.Add(menu);
            panel3.Controls.Add(memberNr);
            panel3.Controls.Add(groupName);
            panel3.Controls.Add(groupInfo);
            panel3.Controls.Add(groupPic);
            panel3.Location = new System.Drawing.Point(235, 149);
            panel3.Name = group.GetName();
            panel3.Size = new System.Drawing.Size(994, 844);
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
                gallaryPhoto.Location = new System.Drawing.Point(3, 3);
                gallaryPhoto.Name = "galleryPhoto";
                gallaryPhoto.Size = new System.Drawing.Size(60, 60);
                gallaryPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                gallaryPhoto.TabIndex = 1;
                gallaryPhoto.TabStop = false;
                gallaryPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                galleryFlow.Controls.Add(gallaryPhoto);
            }
            galleryFlow.Location = new System.Drawing.Point(10, 466);
            galleryFlow.Name = "galleryFlow";
            galleryFlow.Size = new System.Drawing.Size(900, 171);
            galleryFlow.TabIndex = 7;
            galleryFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //3.1.2 galleryLabel CHECK
            Label galleryLabel = new Label();
            galleryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            galleryLabel.ForeColor = System.Drawing.Color.Black;
            galleryLabel.Location = new System.Drawing.Point(8, 440);
            galleryLabel.Name = "galleryLabel";
            galleryLabel.Size = new System.Drawing.Size(128, 23);
            galleryLabel.TabIndex = 7;
            galleryLabel.Text = "Gallerij";

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
                discussionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                discussionBox.ForeColor = System.Drawing.Color.Black;
                discussionBox.Location = new System.Drawing.Point(0, 0);
                discussionBox.Name = "discussionBox";
                discussionBox.Size = new System.Drawing.Size(300, 200);
                discussionBox.TabIndex = 8;
                discussionBox.Text = discussion;
                discussionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

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
            discussionsTable.Location = new System.Drawing.Point(10, 249);
            discussionsTable.Name = "discussionsTable";
            discussionsTable.Size = new System.Drawing.Size(900, 171);
            discussionsTable.TabIndex = 6;
            discussionsTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //3.1.4 discussionsLabel CHECK
            Label discussionsLabel = new Label();
            discussionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discussionsLabel.ForeColor = System.Drawing.Color.Black;
            discussionsLabel.Location = new System.Drawing.Point(6, 223);
            discussionsLabel.Name = "discussionsLabel";
            discussionsLabel.Size = new System.Drawing.Size(128, 23);
            discussionsLabel.TabIndex = 6;
            discussionsLabel.Text = "Discussies";

            //3.1.5 veilingenFlow CHECK
            FlowLayoutPanel veilingenFlow = new FlowLayoutPanel();
            foreach (Item item in group.GetVeilingItems())
            {
                //3.1.5.1.1 itemName
                Label itemName = new Label();
                itemName.TextAlign = ContentAlignment.MiddleCenter;
                itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                itemName.ForeColor = System.Drawing.Color.Black;
                itemName.Name = "itemName";
                itemName.TabIndex = 9;
                itemName.Text = item.GetName();
                itemName.Location = new System.Drawing.Point(4, 4);
                itemName.Size = new Size(120, 30);
                itemName.BorderStyle = BorderStyle.FixedSingle;

                //3.1.5.1.2 itemPhoto
                PictureBox itemPhoto = new PictureBox();
                itemPhoto.Image = item.GetPhoto();
                itemPhoto.Location = new System.Drawing.Point(4, 34);
                itemPhoto.Name = "itemPhoto";
                itemPhoto.Size = new System.Drawing.Size(120, 120);
                itemPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                itemPhoto.TabIndex = 5;
                itemPhoto.TabStop = false;
                itemPhoto.BorderStyle = BorderStyle.FixedSingle;


                //3.1.5.1 itemPanel
                Panel itemPanel = new Panel();
                itemPanel.Controls.Add(itemName);
                itemPanel.Controls.Add(itemPhoto);
                itemPanel.Location = new System.Drawing.Point(3, 3);
                itemPanel.Name = "itemPanel";
                itemPanel.Size = new System.Drawing.Size(130, 160);
                itemPanel.TabIndex = 0;
                //itemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                veilingenFlow.Controls.Add(itemPanel);
            }
            veilingenFlow.Location = new System.Drawing.Point(10, 34);
            veilingenFlow.Name = "VeilingenFlow";
            veilingenFlow.Size = new System.Drawing.Size(900, 171);
            veilingenFlow.TabIndex = 5;
            veilingenFlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //3.1.6 veilingenLabel CHECK
            Label veilingenLabel = new Label();
            veilingenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            veilingenLabel.ForeColor = System.Drawing.Color.Black;
            veilingenLabel.Location = new System.Drawing.Point(6, 8);
            veilingenLabel.Name = "VeilingenLabel";
            veilingenLabel.Size = new System.Drawing.Size(128, 23);
            veilingenLabel.TabIndex = 4;
            veilingenLabel.Text = "Veilingen";

            //3.1
            TabPage home = new TabPage();
            home.Controls.Add(galleryFlow);
            home.Controls.Add(galleryLabel);
            home.Controls.Add(discussionsTable);
            home.Controls.Add(discussionsLabel);
            home.Controls.Add(veilingenFlow);
            home.Controls.Add(veilingenLabel);
            home.Location = new System.Drawing.Point(4, 22);
            home.Name = "Home";
            home.Padding = new System.Windows.Forms.Padding(3);
            home.Size = new System.Drawing.Size(955, 657);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;

            return home;
        }
    }
}
