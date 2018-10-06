using System.ComponentModel;
using System.Windows.Forms;

namespace Prototype
{
    partial class Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen));
            this.Username = new System.Windows.Forms.MenuStrip();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groepenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testOtherProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Groups = new System.Windows.Forms.FlowLayoutPanel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainText = new System.Windows.Forms.TextBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.otherUserProfileReacties = new System.Windows.Forms.FlowLayoutPanel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.otherUserProfileReactiesLabel = new System.Windows.Forms.Label();
            this.otherUserProfileDicussiesLabel = new System.Windows.Forms.Label();
            this.otherUserProfileNameLabel1 = new System.Windows.Forms.Label();
            this.otherUserProfileNameLabel3 = new System.Windows.Forms.Label();
            this.otherUserProfileNameLabel2 = new System.Windows.Forms.Label();
            this.otherUserProfileSpullen = new System.Windows.Forms.FlowLayoutPanel();
            this.spul1 = new System.Windows.Forms.PictureBox();
            this.otherUserProfilePhoto = new System.Windows.Forms.PictureBox();
            this.otherUserProfileDiscussies = new System.Windows.Forms.FlowLayoutPanel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.upperBorderMenu = new System.Windows.Forms.PictureBox();
            this.upperBorder = new System.Windows.Forms.PictureBox();
            this.Username.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.otherUserProfileReacties.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.otherUserProfileSpullen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spul1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherUserProfilePhoto)).BeginInit();
            this.otherUserProfileDiscussies.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBorderMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Dock = System.Windows.Forms.DockStyle.None;
            this.Username.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.userMenu});
            this.Username.Location = new System.Drawing.Point(953, 20);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(80, 24);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // userMenu
            // 
            this.userMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groepenToolStripMenuItem,
            this.profielToolStripMenuItem,
            this.testOtherProfileToolStripMenuItem});
            this.userMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.userMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(159)))), ((int)(((byte)(207)))));
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(72, 20);
            this.userMenu.Text = "Username";
            // 
            // groepenToolStripMenuItem
            // 
            this.groepenToolStripMenuItem.Name = "groepenToolStripMenuItem";
            this.groepenToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.groepenToolStripMenuItem.Text = "Groepen";
            this.groepenToolStripMenuItem.Click += new System.EventHandler(this.groepenToolStripMenuItem_Click);
            // 
            // profielToolStripMenuItem
            // 
            this.profielToolStripMenuItem.Name = "profielToolStripMenuItem";
            this.profielToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.profielToolStripMenuItem.Text = "Profiel";
            this.profielToolStripMenuItem.Click += new System.EventHandler(this.profielToolStripMenuItem_Click);
            // 
            // testOtherProfileToolStripMenuItem
            // 
            this.testOtherProfileToolStripMenuItem.Name = "testOtherProfileToolStripMenuItem";
            this.testOtherProfileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.testOtherProfileToolStripMenuItem.Text = "[Test]OtherProfile";
            this.testOtherProfileToolStripMenuItem.Click += new System.EventHandler(this.testOtherProfileToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.Groups);
            this.panel1.Controls.Add(this.mainLabel);
            this.panel1.Controls.Add(this.mainText);
            this.panel1.Controls.Add(this.mainPic);
            this.panel1.Location = new System.Drawing.Point(235, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 844);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // Groups
            // 
            this.Groups.Location = new System.Drawing.Point(28, 158);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(895, 510);
            this.Groups.TabIndex = 4;
            // 
            // mainLabel
            // 
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            this.mainLabel.Location = new System.Drawing.Point(173, 22);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(183, 23);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Welcome Default";
            // 
            // mainText
            // 
            this.mainText.Enabled = false;
            this.mainText.Location = new System.Drawing.Point(173, 48);
            this.mainText.Multiline = true;
            this.mainText.Name = "mainText";
            this.mainText.ReadOnly = true;
            this.mainText.Size = new System.Drawing.Size(247, 94);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "> Default\r\n";
            // 
            // mainPic
            // 
            this.mainPic.Image = ((System.Drawing.Image)(resources.GetObject("mainPic.Image")));
            this.mainPic.Location = new System.Drawing.Point(28, 22);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(120, 120);
            this.mainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.otherUserProfileReacties);
            this.panel2.Controls.Add(this.otherUserProfileReactiesLabel);
            this.panel2.Controls.Add(this.otherUserProfileDicussiesLabel);
            this.panel2.Controls.Add(this.otherUserProfileNameLabel1);
            this.panel2.Controls.Add(this.otherUserProfileNameLabel3);
            this.panel2.Controls.Add(this.otherUserProfileNameLabel2);
            this.panel2.Controls.Add(this.otherUserProfileSpullen);
            this.panel2.Controls.Add(this.otherUserProfilePhoto);
            this.panel2.Controls.Add(this.otherUserProfileDiscussies);
            this.panel2.Location = new System.Drawing.Point(235, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 844);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // otherUserProfileReacties
            // 
            this.otherUserProfileReacties.Controls.Add(this.panel28);
            this.otherUserProfileReacties.Location = new System.Drawing.Point(31, 607);
            this.otherUserProfileReacties.Name = "otherUserProfileReacties";
            this.otherUserProfileReacties.Size = new System.Drawing.Size(429, 114);
            this.otherUserProfileReacties.TabIndex = 11;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.textBox8);
            this.panel28.Controls.Add(this.pictureBox8);
            this.panel28.Location = new System.Drawing.Point(3, 3);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(200, 50);
            this.panel28.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(50, 0);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(150, 50);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = ">Vandaag zijn er 18 nieuwe producten geplaatst.\r\n>U heeft 3 nieuwe biedingen ontv" +
    "angen.\r\n";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(50, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 10;
            this.pictureBox8.TabStop = false;
            // 
            // otherUserProfileReactiesLabel
            // 
            this.otherUserProfileReactiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUserProfileReactiesLabel.ForeColor = System.Drawing.Color.Black;
            this.otherUserProfileReactiesLabel.Location = new System.Drawing.Point(28, 581);
            this.otherUserProfileReactiesLabel.Name = "otherUserProfileReactiesLabel";
            this.otherUserProfileReactiesLabel.Size = new System.Drawing.Size(213, 23);
            this.otherUserProfileReactiesLabel.TabIndex = 10;
            this.otherUserProfileReactiesLabel.Text = "Reacties";
            // 
            // otherUserProfileDicussiesLabel
            // 
            this.otherUserProfileDicussiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUserProfileDicussiesLabel.ForeColor = System.Drawing.Color.Black;
            this.otherUserProfileDicussiesLabel.Location = new System.Drawing.Point(25, 427);
            this.otherUserProfileDicussiesLabel.Name = "otherUserProfileDicussiesLabel";
            this.otherUserProfileDicussiesLabel.Size = new System.Drawing.Size(213, 23);
            this.otherUserProfileDicussiesLabel.TabIndex = 9;
            this.otherUserProfileDicussiesLabel.Text = "Discussies";
            // 
            // otherUserProfileNameLabel1
            // 
            this.otherUserProfileNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUserProfileNameLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            this.otherUserProfileNameLabel1.Location = new System.Drawing.Point(0, 0);
            this.otherUserProfileNameLabel1.Name = "otherUserProfileNameLabel1";
            this.otherUserProfileNameLabel1.Size = new System.Drawing.Size(183, 23);
            this.otherUserProfileNameLabel1.TabIndex = 2;
            this.otherUserProfileNameLabel1.Text = "Username profiel";
            // 
            // otherUserProfileNameLabel3
            // 
            this.otherUserProfileNameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUserProfileNameLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            this.otherUserProfileNameLabel3.Location = new System.Drawing.Point(24, 401);
            this.otherUserProfileNameLabel3.Name = "otherUserProfileNameLabel3";
            this.otherUserProfileNameLabel3.Size = new System.Drawing.Size(213, 23);
            this.otherUserProfileNameLabel3.TabIndex = 5;
            this.otherUserProfileNameLabel3.Text = "Username\'s activiteiten";
            // 
            // otherUserProfileNameLabel2
            // 
            this.otherUserProfileNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUserProfileNameLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(199)))));
            this.otherUserProfileNameLabel2.Location = new System.Drawing.Point(24, 117);
            this.otherUserProfileNameLabel2.Name = "otherUserProfileNameLabel2";
            this.otherUserProfileNameLabel2.Size = new System.Drawing.Size(183, 23);
            this.otherUserProfileNameLabel2.TabIndex = 4;
            this.otherUserProfileNameLabel2.Text = "Username\'s spullen";
            // 
            // otherUserProfileSpullen
            // 
            this.otherUserProfileSpullen.Controls.Add(this.spul1);
            this.otherUserProfileSpullen.Location = new System.Drawing.Point(28, 143);
            this.otherUserProfileSpullen.Name = "otherUserProfileSpullen";
            this.otherUserProfileSpullen.Size = new System.Drawing.Size(429, 216);
            this.otherUserProfileSpullen.TabIndex = 3;
            // 
            // spul1
            // 
            this.spul1.Image = global::Prototype.Properties.Resources.item1;
            this.spul1.Location = new System.Drawing.Point(3, 3);
            this.spul1.Name = "spul1";
            this.spul1.Size = new System.Drawing.Size(100, 100);
            this.spul1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spul1.TabIndex = 0;
            this.spul1.TabStop = false;
            // 
            // otherUserProfilePhoto
            // 
            this.otherUserProfilePhoto.Image = ((System.Drawing.Image)(resources.GetObject("otherUserProfilePhoto.Image")));
            this.otherUserProfilePhoto.Location = new System.Drawing.Point(28, 22);
            this.otherUserProfilePhoto.Name = "otherUserProfilePhoto";
            this.otherUserProfilePhoto.Size = new System.Drawing.Size(57, 57);
            this.otherUserProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otherUserProfilePhoto.TabIndex = 0;
            this.otherUserProfilePhoto.TabStop = false;
            // 
            // otherUserProfileDiscussies
            // 
            this.otherUserProfileDiscussies.Controls.Add(this.panel24);
            this.otherUserProfileDiscussies.Location = new System.Drawing.Point(28, 453);
            this.otherUserProfileDiscussies.Name = "otherUserProfileDiscussies";
            this.otherUserProfileDiscussies.Size = new System.Drawing.Size(429, 114);
            this.otherUserProfileDiscussies.TabIndex = 8;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.textBox3);
            this.panel24.Controls.Add(this.pictureBox3);
            this.panel24.Location = new System.Drawing.Point(3, 3);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(200, 50);
            this.panel24.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(50, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 50);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "10 hobbies die je waarschijnelijk nog nooit geprobeerd hebt!\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Prototype.Properties.Resources.item1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // upperBorderMenu
            // 
            this.upperBorderMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.upperBorderMenu.BackColor = System.Drawing.Color.White;
            this.upperBorderMenu.Image = ((System.Drawing.Image)(resources.GetObject("upperBorderMenu.Image")));
            this.upperBorderMenu.Location = new System.Drawing.Point(235, 0);
            this.upperBorderMenu.Name = "upperBorderMenu";
            this.upperBorderMenu.Size = new System.Drawing.Size(994, 131);
            this.upperBorderMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upperBorderMenu.TabIndex = 1;
            this.upperBorderMenu.TabStop = false;
            // 
            // upperBorder
            // 
            this.upperBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperBorder.Image = ((System.Drawing.Image)(resources.GetObject("upperBorder.Image")));
            this.upperBorder.Location = new System.Drawing.Point(0, 0);
            this.upperBorder.Name = "upperBorder";
            this.upperBorder.Size = new System.Drawing.Size(1271, 131);
            this.upperBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperBorder.TabIndex = 0;
            this.upperBorder.TabStop = false;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1271, 1220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.upperBorderMenu);
            this.Controls.Add(this.upperBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen";
            this.Text = "Prototype 1.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Screen_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Username.ResumeLayout(false);
            this.Username.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.otherUserProfileReacties.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.otherUserProfileSpullen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spul1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherUserProfilePhoto)).EndInit();
            this.otherUserProfileDiscussies.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBorderMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox upperBorder;
        private PictureBox upperBorderMenu;
        private MenuStrip Username;
        private ToolStripMenuItem userMenu;
        private ToolStripMenuItem groepenToolStripMenuItem;
        private ToolStripMenuItem profielToolStripMenuItem;
        private ToolStripMenuItem testOtherProfileToolStripMenuItem;
        private Panel panel1;
        private PictureBox mainPic;
        private Label mainLabel;
        private TextBox mainText;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel2;
        private Label otherUserProfileNameLabel1;
        private PictureBox otherUserProfilePhoto;
        private Label otherUserProfileNameLabel2;
        private FlowLayoutPanel otherUserProfileSpullen;
        private PictureBox spul1;
        private FlowLayoutPanel otherUserProfileReacties;
        private Panel panel28;
        private TextBox textBox8;
        private PictureBox pictureBox8;
        private Label otherUserProfileReactiesLabel;
        private Label otherUserProfileDicussiesLabel;
        private Label otherUserProfileNameLabel3;
        private FlowLayoutPanel otherUserProfileDiscussies;
        private Panel panel24;
        private TextBox textBox3;
        private PictureBox pictureBox3;
        private FlowLayoutPanel Groups;
    }
}

