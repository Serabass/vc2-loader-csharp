namespace vc2_loader_csharp
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lnkSettings = new System.Windows.Forms.LinkLabel();
            this.lnkContacts = new System.Windows.Forms.LinkLabel();
            this.lnkDownloads = new System.Windows.Forms.LinkLabel();
            this.lnkNews = new System.Windows.Forms.LinkLabel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.lnkMusic = new System.Windows.Forms.LinkLabel();
            this.lnkGuns = new System.Windows.Forms.LinkLabel();
            this.lnkTextures = new System.Windows.Forms.LinkLabel();
            this.lnkMaps = new System.Windows.Forms.LinkLabel();
            this.lnkCars = new System.Windows.Forms.LinkLabel();
            this.lnkMostPopular = new System.Windows.Forms.LinkLabel();
            this.lnkInProgress = new System.Windows.Forms.LinkLabel();
            this.lnkNewReleases = new System.Windows.Forms.LinkLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pctWhiteBG = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pctSocialFB = new System.Windows.Forms.PictureBox();
            this.pctSocialIG = new System.Windows.Forms.PictureBox();
            this.pctSocialYT = new System.Windows.Forms.PictureBox();
            this.pctSocialVK = new System.Windows.Forms.PictureBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblNewVer = new System.Windows.Forms.Label();
            this.lblCurrentVer = new System.Windows.Forms.Label();
            this.lnlRevTeam = new System.Windows.Forms.Label();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWhiteBG)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialIG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialYT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialVK)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHead.Controls.Add(this.pctMenu);
            this.pnlHead.Controls.Add(this.pctLogo);
            this.pnlHead.Controls.Add(this.lnkSettings);
            this.pnlHead.Controls.Add(this.lnkContacts);
            this.pnlHead.Controls.Add(this.lnkDownloads);
            this.pnlHead.Controls.Add(this.lnkNews);
            this.pnlHead.Controls.Add(this.lblBrand);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1280, 85);
            this.pnlHead.TabIndex = 5;
            // 
            // pctMenu
            // 
            this.pctMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctMenu.BackgroundImage")));
            this.pctMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMenu.Location = new System.Drawing.Point(1198, 3);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(79, 79);
            this.pctMenu.TabIndex = 15;
            this.pctMenu.TabStop = false;
            this.pctMenu.Click += new System.EventHandler(this.pctMenu_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(114, 85);
            this.pctLogo.TabIndex = 14;
            this.pctLogo.TabStop = false;
            this.pctLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctLogo_MouseDown);
            // 
            // lnkSettings
            // 
            this.lnkSettings.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkSettings.AutoSize = true;
            this.lnkSettings.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkSettings.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkSettings.ForeColor = System.Drawing.Color.Black;
            this.lnkSettings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSettings.LinkColor = System.Drawing.Color.Black;
            this.lnkSettings.Location = new System.Drawing.Point(717, 33);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Size = new System.Drawing.Size(68, 19);
            this.lnkSettings.TabIndex = 13;
            this.lnkSettings.TabStop = true;
            this.lnkSettings.Text = "Settings";
            // 
            // lnkContacts
            // 
            this.lnkContacts.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkContacts.AutoSize = true;
            this.lnkContacts.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkContacts.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkContacts.ForeColor = System.Drawing.Color.Black;
            this.lnkContacts.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkContacts.LinkColor = System.Drawing.Color.Black;
            this.lnkContacts.Location = new System.Drawing.Point(636, 33);
            this.lnkContacts.Name = "lnkContacts";
            this.lnkContacts.Size = new System.Drawing.Size(75, 19);
            this.lnkContacts.TabIndex = 12;
            this.lnkContacts.TabStop = true;
            this.lnkContacts.Text = "Contacts";
            // 
            // lnkDownloads
            // 
            this.lnkDownloads.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkDownloads.AutoSize = true;
            this.lnkDownloads.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkDownloads.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkDownloads.ForeColor = System.Drawing.Color.Black;
            this.lnkDownloads.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDownloads.LinkColor = System.Drawing.Color.Black;
            this.lnkDownloads.Location = new System.Drawing.Point(539, 33);
            this.lnkDownloads.Name = "lnkDownloads";
            this.lnkDownloads.Size = new System.Drawing.Size(91, 19);
            this.lnkDownloads.TabIndex = 11;
            this.lnkDownloads.TabStop = true;
            this.lnkDownloads.Text = "Downloads";
            // 
            // lnkNews
            // 
            this.lnkNews.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkNews.AutoSize = true;
            this.lnkNews.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkNews.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkNews.ForeColor = System.Drawing.Color.Black;
            this.lnkNews.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNews.LinkColor = System.Drawing.Color.Black;
            this.lnkNews.Location = new System.Drawing.Point(482, 33);
            this.lnkNews.Name = "lnkNews";
            this.lnkNews.Size = new System.Drawing.Size(51, 19);
            this.lnkNews.TabIndex = 10;
            this.lnkNews.TabStop = true;
            this.lnkNews.Text = "News";
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("HelveticaNeueCyr", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBrand.Location = new System.Drawing.Point(110, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(237, 85);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Vice City 2";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Brand_MouseDown);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSide.Controls.Add(this.lblCategories);
            this.pnlSide.Controls.Add(this.lblGeneral);
            this.pnlSide.Controls.Add(this.lnkMusic);
            this.pnlSide.Controls.Add(this.lnkGuns);
            this.pnlSide.Controls.Add(this.lnkTextures);
            this.pnlSide.Controls.Add(this.lnkMaps);
            this.pnlSide.Controls.Add(this.lnkCars);
            this.pnlSide.Controls.Add(this.lnkMostPopular);
            this.pnlSide.Controls.Add(this.lnkInProgress);
            this.pnlSide.Controls.Add(this.lnkNewReleases);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlSide.Location = new System.Drawing.Point(0, 85);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(206, 428);
            this.pnlSide.TabIndex = 10;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(15, 160);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(112, 19);
            this.lblCategories.TabIndex = 26;
            this.lblCategories.Text = "CATEGORIES";
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Location = new System.Drawing.Point(15, 24);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(85, 19);
            this.lblGeneral.TabIndex = 25;
            this.lblGeneral.Text = "GENERAL";
            // 
            // lnkMusic
            // 
            this.lnkMusic.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkMusic.AutoSize = true;
            this.lnkMusic.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkMusic.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkMusic.ForeColor = System.Drawing.Color.Black;
            this.lnkMusic.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMusic.LinkColor = System.Drawing.Color.Black;
            this.lnkMusic.Location = new System.Drawing.Point(32, 312);
            this.lnkMusic.Name = "lnkMusic";
            this.lnkMusic.Size = new System.Drawing.Size(52, 19);
            this.lnkMusic.TabIndex = 24;
            this.lnkMusic.TabStop = true;
            this.lnkMusic.Text = "Music";
            // 
            // lnkGuns
            // 
            this.lnkGuns.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkGuns.AutoSize = true;
            this.lnkGuns.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkGuns.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkGuns.ForeColor = System.Drawing.Color.Black;
            this.lnkGuns.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkGuns.LinkColor = System.Drawing.Color.Black;
            this.lnkGuns.Location = new System.Drawing.Point(32, 282);
            this.lnkGuns.Name = "lnkGuns";
            this.lnkGuns.Size = new System.Drawing.Size(48, 19);
            this.lnkGuns.TabIndex = 23;
            this.lnkGuns.TabStop = true;
            this.lnkGuns.Text = "Guns";
            // 
            // lnkTextures
            // 
            this.lnkTextures.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkTextures.AutoSize = true;
            this.lnkTextures.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkTextures.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkTextures.ForeColor = System.Drawing.Color.Black;
            this.lnkTextures.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTextures.LinkColor = System.Drawing.Color.Black;
            this.lnkTextures.Location = new System.Drawing.Point(31, 252);
            this.lnkTextures.Name = "lnkTextures";
            this.lnkTextures.Size = new System.Drawing.Size(69, 19);
            this.lnkTextures.TabIndex = 22;
            this.lnkTextures.TabStop = true;
            this.lnkTextures.Text = "Textures";
            // 
            // lnkMaps
            // 
            this.lnkMaps.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkMaps.AutoSize = true;
            this.lnkMaps.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkMaps.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkMaps.ForeColor = System.Drawing.Color.Black;
            this.lnkMaps.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMaps.LinkColor = System.Drawing.Color.Black;
            this.lnkMaps.Location = new System.Drawing.Point(31, 222);
            this.lnkMaps.Name = "lnkMaps";
            this.lnkMaps.Size = new System.Drawing.Size(50, 19);
            this.lnkMaps.TabIndex = 21;
            this.lnkMaps.TabStop = true;
            this.lnkMaps.Text = "Maps";
            // 
            // lnkCars
            // 
            this.lnkCars.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkCars.AutoSize = true;
            this.lnkCars.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkCars.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkCars.ForeColor = System.Drawing.Color.Black;
            this.lnkCars.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCars.LinkColor = System.Drawing.Color.Black;
            this.lnkCars.Location = new System.Drawing.Point(31, 192);
            this.lnkCars.Name = "lnkCars";
            this.lnkCars.Size = new System.Drawing.Size(43, 19);
            this.lnkCars.TabIndex = 20;
            this.lnkCars.TabStop = true;
            this.lnkCars.Text = "Cars";
            // 
            // lnkMostPopular
            // 
            this.lnkMostPopular.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkMostPopular.AutoSize = true;
            this.lnkMostPopular.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkMostPopular.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkMostPopular.ForeColor = System.Drawing.Color.Black;
            this.lnkMostPopular.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostPopular.LinkColor = System.Drawing.Color.Black;
            this.lnkMostPopular.Location = new System.Drawing.Point(34, 115);
            this.lnkMostPopular.Name = "lnkMostPopular";
            this.lnkMostPopular.Size = new System.Drawing.Size(106, 19);
            this.lnkMostPopular.TabIndex = 19;
            this.lnkMostPopular.TabStop = true;
            this.lnkMostPopular.Text = "Most Popular";
            // 
            // lnkInProgress
            // 
            this.lnkInProgress.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkInProgress.AutoSize = true;
            this.lnkInProgress.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkInProgress.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkInProgress.ForeColor = System.Drawing.Color.Black;
            this.lnkInProgress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkInProgress.LinkColor = System.Drawing.Color.Black;
            this.lnkInProgress.Location = new System.Drawing.Point(34, 85);
            this.lnkInProgress.Name = "lnkInProgress";
            this.lnkInProgress.Size = new System.Drawing.Size(91, 19);
            this.lnkInProgress.TabIndex = 18;
            this.lnkInProgress.TabStop = true;
            this.lnkInProgress.Text = "In Progress";
            // 
            // lnkNewReleases
            // 
            this.lnkNewReleases.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkNewReleases.AutoSize = true;
            this.lnkNewReleases.DisabledLinkColor = System.Drawing.Color.Silver;
            this.lnkNewReleases.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkNewReleases.ForeColor = System.Drawing.Color.Black;
            this.lnkNewReleases.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNewReleases.LinkColor = System.Drawing.Color.Black;
            this.lnkNewReleases.Location = new System.Drawing.Point(34, 55);
            this.lnkNewReleases.Name = "lnkNewReleases";
            this.lnkNewReleases.Size = new System.Drawing.Size(114, 19);
            this.lnkNewReleases.TabIndex = 17;
            this.lnkNewReleases.TabStop = true;
            this.lnkNewReleases.Text = "New Releases";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Controls.Add(this.pctWhiteBG);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlMain.Location = new System.Drawing.Point(206, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1074, 428);
            this.pnlMain.TabIndex = 11;
            // 
            // pctWhiteBG
            // 
            this.pctWhiteBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctWhiteBG.BackgroundImage")));
            this.pctWhiteBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctWhiteBG.Location = new System.Drawing.Point(0, 0);
            this.pctWhiteBG.Name = "pctWhiteBG";
            this.pctWhiteBG.Size = new System.Drawing.Size(1074, 428);
            this.pctWhiteBG.TabIndex = 0;
            this.pctWhiteBG.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.Controls.Add(this.pctSocialFB);
            this.pnlFooter.Controls.Add(this.pctSocialIG);
            this.pnlFooter.Controls.Add(this.pctSocialYT);
            this.pnlFooter.Controls.Add(this.pctSocialVK);
            this.pnlFooter.Controls.Add(this.lblUpdate);
            this.pnlFooter.Controls.Add(this.lblNewVer);
            this.pnlFooter.Controls.Add(this.lblCurrentVer);
            this.pnlFooter.Controls.Add(this.lnlRevTeam);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlFooter.Location = new System.Drawing.Point(0, 513);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1280, 86);
            this.pnlFooter.TabIndex = 12;
            // 
            // pctSocialFB
            // 
            this.pctSocialFB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSocialFB.BackgroundImage")));
            this.pctSocialFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctSocialFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSocialFB.Location = new System.Drawing.Point(143, 41);
            this.pctSocialFB.Name = "pctSocialFB";
            this.pctSocialFB.Size = new System.Drawing.Size(35, 35);
            this.pctSocialFB.TabIndex = 7;
            this.pctSocialFB.TabStop = false;
            this.pctSocialFB.Click += new System.EventHandler(this.pctSocialFB_Click);
            // 
            // pctSocialIG
            // 
            this.pctSocialIG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSocialIG.BackgroundImage")));
            this.pctSocialIG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctSocialIG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSocialIG.Location = new System.Drawing.Point(107, 41);
            this.pctSocialIG.Name = "pctSocialIG";
            this.pctSocialIG.Size = new System.Drawing.Size(35, 35);
            this.pctSocialIG.TabIndex = 6;
            this.pctSocialIG.TabStop = false;
            this.pctSocialIG.Click += new System.EventHandler(this.pctSocialIG_Click);
            // 
            // pctSocialYT
            // 
            this.pctSocialYT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSocialYT.BackgroundImage")));
            this.pctSocialYT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctSocialYT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSocialYT.Location = new System.Drawing.Point(71, 41);
            this.pctSocialYT.Name = "pctSocialYT";
            this.pctSocialYT.Size = new System.Drawing.Size(35, 35);
            this.pctSocialYT.TabIndex = 5;
            this.pctSocialYT.TabStop = false;
            this.pctSocialYT.Click += new System.EventHandler(this.pctSocialYT_Click);
            // 
            // pctSocialVK
            // 
            this.pctSocialVK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSocialVK.BackgroundImage")));
            this.pctSocialVK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctSocialVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctSocialVK.Location = new System.Drawing.Point(35, 41);
            this.pctSocialVK.Name = "pctSocialVK";
            this.pctSocialVK.Size = new System.Drawing.Size(35, 35);
            this.pctSocialVK.TabIndex = 4;
            this.pctSocialVK.TabStop = false;
            this.pctSocialVK.Click += new System.EventHandler(this.pctSocialVK_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblUpdate.Location = new System.Drawing.Point(1140, 21);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(128, 41);
            this.lblUpdate.TabIndex = 3;
            this.lblUpdate.Text = "UPDATE";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewVer
            // 
            this.lblNewVer.AutoSize = true;
            this.lblNewVer.Font = new System.Drawing.Font("HelveticaNeueCyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewVer.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNewVer.Location = new System.Drawing.Point(965, 39);
            this.lblNewVer.Name = "lblNewVer";
            this.lblNewVer.Size = new System.Drawing.Size(120, 23);
            this.lblNewVer.TabIndex = 2;
            this.lblNewVer.Text = "New is 0.02";
            // 
            // lblCurrentVer
            // 
            this.lblCurrentVer.AutoSize = true;
            this.lblCurrentVer.Font = new System.Drawing.Font("HelveticaNeueCyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentVer.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentVer.Location = new System.Drawing.Point(925, 15);
            this.lblCurrentVer.Name = "lblCurrentVer";
            this.lblCurrentVer.Size = new System.Drawing.Size(191, 23);
            this.lblCurrentVer.TabIndex = 1;
            this.lblCurrentVer.Text = "Your Version is 0.01";
            // 
            // lnlRevTeam
            // 
            this.lnlRevTeam.AutoSize = true;
            this.lnlRevTeam.Font = new System.Drawing.Font("HelveticaNeueCyr", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnlRevTeam.Location = new System.Drawing.Point(31, 17);
            this.lnlRevTeam.Name = "lnlRevTeam";
            this.lnlRevTeam.Size = new System.Drawing.Size(148, 21);
            this.lnlRevTeam.TabIndex = 0;
            this.lnlRevTeam.Text = "Revolution Team";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 599);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlFooter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctWhiteBG)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialIG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialYT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSocialVK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.LinkLabel lnkNews;
        private System.Windows.Forms.LinkLabel lnkContacts;
        private System.Windows.Forms.LinkLabel lnkDownloads;
        private System.Windows.Forms.LinkLabel lnkSettings;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lnlRevTeam;
        private System.Windows.Forms.Label lblNewVer;
        private System.Windows.Forms.Label lblCurrentVer;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.PictureBox pctSocialVK;
        private System.Windows.Forms.PictureBox pctSocialFB;
        private System.Windows.Forms.PictureBox pctSocialIG;
        private System.Windows.Forms.PictureBox pctSocialYT;
        private System.Windows.Forms.PictureBox pctWhiteBG;
        private System.Windows.Forms.LinkLabel lnkMusic;
        private System.Windows.Forms.LinkLabel lnkGuns;
        private System.Windows.Forms.LinkLabel lnkTextures;
        private System.Windows.Forms.LinkLabel lnkMaps;
        private System.Windows.Forms.LinkLabel lnkCars;
        private System.Windows.Forms.LinkLabel lnkMostPopular;
        private System.Windows.Forms.LinkLabel lnkInProgress;
        private System.Windows.Forms.LinkLabel lnkNewReleases;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblGeneral;
        public System.Windows.Forms.PictureBox pctMenu;
    }
}

