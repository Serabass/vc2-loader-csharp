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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.pnlHeadLinksContainer = new System.Windows.Forms.Panel();
            this.pnlTopLinks = new System.Windows.Forms.Panel();
            this.lnkSettings = new System.Windows.Forms.LinkLabel();
            this.lnkContacts = new System.Windows.Forms.LinkLabel();
            this.lnkDownloads = new System.Windows.Forms.LinkLabel();
            this.lnkNews = new System.Windows.Forms.LinkLabel();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.pnlLeftCategories = new System.Windows.Forms.Panel();
            this.pnlLeftCategoriesList = new System.Windows.Forms.Panel();
            this.lnkMusic = new System.Windows.Forms.LinkLabel();
            this.lnkGuns = new System.Windows.Forms.LinkLabel();
            this.lnkTextures = new System.Windows.Forms.LinkLabel();
            this.lnkMap = new System.Windows.Forms.LinkLabel();
            this.lnkCars = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLeftGeneral = new System.Windows.Forms.Panel();
            this.pnlLeftGeneralList = new System.Windows.Forms.Panel();
            this.lnkMostPopular = new System.Windows.Forms.LinkLabel();
            this.lnkInProgress = new System.Windows.Forms.LinkLabel();
            this.lnkNewReleases = new System.Windows.Forms.LinkLabel();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.wsNewReleases = new vc2_loader_csharp.Workspace();
            this.wsMap = new vc2_loader_csharp.Workspace();
            this.wsCars = new vc2_loader_csharp.Workspace();
            this.pctWhiteBG = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlFootAbout = new System.Windows.Forms.Panel();
            this.pnlSocialLinks = new System.Windows.Forms.Panel();
            this.socialIG = new vc2_loader_csharp.SocialLink();
            this.socialYT = new vc2_loader_csharp.SocialLink();
            this.socialFB = new vc2_loader_csharp.SocialLink();
            this.socialVK = new vc2_loader_csharp.SocialLink();
            this.lnlRevTeam = new System.Windows.Forms.Label();
            this.pnlVersion = new System.Windows.Forms.Panel();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.ctxSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            this.pnlHeadLinksContainer.SuspendLayout();
            this.pnlTopLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.pnlLeftCategories.SuspendLayout();
            this.pnlLeftCategoriesList.SuspendLayout();
            this.pnlLeftGeneral.SuspendLayout();
            this.pnlLeftGeneralList.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWhiteBG)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlFootAbout.SuspendLayout();
            this.pnlSocialLinks.SuspendLayout();
            this.pnlVersion.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.ctxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.White;
            this.pnlHead.Controls.Add(this.pctMenu);
            this.pnlHead.Controls.Add(this.pnlHeadLinksContainer);
            this.pnlHead.Controls.Add(this.lblBrand);
            this.pnlHead.Controls.Add(this.pctLogo);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1180, 85);
            this.pnlHead.TabIndex = 5;
            // 
            // pctMenu
            // 
            this.pctMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctMenu.BackgroundImage")));
            this.pctMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctMenu.Location = new System.Drawing.Point(1088, 0);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(92, 85);
            this.pctMenu.TabIndex = 17;
            this.pctMenu.TabStop = false;
            this.pctMenu.Click += new System.EventHandler(this.pctMenu_Click_1);
            // 
            // pnlHeadLinksContainer
            // 
            this.pnlHeadLinksContainer.Controls.Add(this.pnlTopLinks);
            this.pnlHeadLinksContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeadLinksContainer.Location = new System.Drawing.Point(271, 0);
            this.pnlHeadLinksContainer.Name = "pnlHeadLinksContainer";
            this.pnlHeadLinksContainer.Padding = new System.Windows.Forms.Padding(180, 0, 216, 0);
            this.pnlHeadLinksContainer.Size = new System.Drawing.Size(717, 85);
            this.pnlHeadLinksContainer.TabIndex = 16;
            // 
            // pnlTopLinks
            // 
            this.pnlTopLinks.Controls.Add(this.lnkSettings);
            this.pnlTopLinks.Controls.Add(this.lnkContacts);
            this.pnlTopLinks.Controls.Add(this.lnkDownloads);
            this.pnlTopLinks.Controls.Add(this.lnkNews);
            this.pnlTopLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLinks.Location = new System.Drawing.Point(180, 0);
            this.pnlTopLinks.Name = "pnlTopLinks";
            this.pnlTopLinks.Size = new System.Drawing.Size(321, 85);
            this.pnlTopLinks.TabIndex = 19;
            // 
            // lnkSettings
            // 
            this.lnkSettings.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkSettings.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkSettings.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkSettings.ForeColor = System.Drawing.Color.Black;
            this.lnkSettings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSettings.LinkColor = System.Drawing.Color.Black;
            this.lnkSettings.Location = new System.Drawing.Point(241, 0);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.lnkSettings.Size = new System.Drawing.Size(78, 85);
            this.lnkSettings.TabIndex = 21;
            this.lnkSettings.TabStop = true;
            this.lnkSettings.Text = "Settings";
            this.lnkSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkContacts
            // 
            this.lnkContacts.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkContacts.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkContacts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkContacts.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkContacts.ForeColor = System.Drawing.Color.Black;
            this.lnkContacts.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkContacts.LinkColor = System.Drawing.Color.Black;
            this.lnkContacts.Location = new System.Drawing.Point(156, 0);
            this.lnkContacts.Name = "lnkContacts";
            this.lnkContacts.Padding = new System.Windows.Forms.Padding(2, 30, 5, 5);
            this.lnkContacts.Size = new System.Drawing.Size(85, 85);
            this.lnkContacts.TabIndex = 20;
            this.lnkContacts.TabStop = true;
            this.lnkContacts.Text = "Contacts";
            this.lnkContacts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkDownloads
            // 
            this.lnkDownloads.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkDownloads.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkDownloads.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkDownloads.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkDownloads.ForeColor = System.Drawing.Color.Black;
            this.lnkDownloads.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkDownloads.LinkColor = System.Drawing.Color.Black;
            this.lnkDownloads.Location = new System.Drawing.Point(55, 0);
            this.lnkDownloads.Name = "lnkDownloads";
            this.lnkDownloads.Padding = new System.Windows.Forms.Padding(2, 30, 5, 5);
            this.lnkDownloads.Size = new System.Drawing.Size(101, 85);
            this.lnkDownloads.TabIndex = 19;
            this.lnkDownloads.TabStop = true;
            this.lnkDownloads.Text = "Downloads";
            this.lnkDownloads.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkNews
            // 
            this.lnkNews.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkNews.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkNews.Dock = System.Windows.Forms.DockStyle.Left;
            this.lnkNews.Font = new System.Drawing.Font("HelveticaNeueCyr", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkNews.ForeColor = System.Drawing.Color.Black;
            this.lnkNews.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNews.LinkColor = System.Drawing.Color.Black;
            this.lnkNews.Location = new System.Drawing.Point(0, 0);
            this.lnkNews.Name = "lnkNews";
            this.lnkNews.Padding = new System.Windows.Forms.Padding(5, 30, 2, 5);
            this.lnkNews.Size = new System.Drawing.Size(55, 85);
            this.lnkNews.TabIndex = 18;
            this.lnkNews.TabStop = true;
            this.lnkNews.Text = "News";
            this.lnkNews.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBrand.Font = new System.Drawing.Font("HelveticaNeueCyr", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.lblBrand.Location = new System.Drawing.Point(102, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(169, 85);
            this.lblBrand.TabIndex = 9;
            this.lblBrand.Text = "Vice City 2";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBrand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Brand_MouseDown);
            // 
            // pctLogo
            // 
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(102, 85);
            this.pctLogo.TabIndex = 14;
            this.pctLogo.TabStop = false;
            this.pctLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctLogo_MouseDown);
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSide.Controls.Add(this.pnlLeftCategories);
            this.pnlSide.Controls.Add(this.pnlLeftGeneral);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlSide.Location = new System.Drawing.Point(0, 85);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Padding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.pnlSide.Size = new System.Drawing.Size(191, 589);
            this.pnlSide.TabIndex = 10;
            // 
            // pnlLeftCategories
            // 
            this.pnlLeftCategories.Controls.Add(this.pnlLeftCategoriesList);
            this.pnlLeftCategories.Controls.Add(this.label3);
            this.pnlLeftCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftCategories.Location = new System.Drawing.Point(15, 267);
            this.pnlLeftCategories.Name = "pnlLeftCategories";
            this.pnlLeftCategories.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.pnlLeftCategories.Size = new System.Drawing.Size(176, 323);
            this.pnlLeftCategories.TabIndex = 29;
            // 
            // pnlLeftCategoriesList
            // 
            this.pnlLeftCategoriesList.Controls.Add(this.lnkMusic);
            this.pnlLeftCategoriesList.Controls.Add(this.lnkGuns);
            this.pnlLeftCategoriesList.Controls.Add(this.lnkTextures);
            this.pnlLeftCategoriesList.Controls.Add(this.lnkMap);
            this.pnlLeftCategoriesList.Controls.Add(this.lnkCars);
            this.pnlLeftCategoriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCategoriesList.Location = new System.Drawing.Point(15, 27);
            this.pnlLeftCategoriesList.Name = "pnlLeftCategoriesList";
            this.pnlLeftCategoriesList.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.pnlLeftCategoriesList.Size = new System.Drawing.Size(161, 296);
            this.pnlLeftCategoriesList.TabIndex = 27;
            // 
            // lnkMusic
            // 
            this.lnkMusic.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkMusic.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkMusic.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkMusic.ForeColor = System.Drawing.Color.Black;
            this.lnkMusic.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMusic.LinkColor = System.Drawing.Color.Black;
            this.lnkMusic.Location = new System.Drawing.Point(7, 110);
            this.lnkMusic.Name = "lnkMusic";
            this.lnkMusic.Size = new System.Drawing.Size(154, 25);
            this.lnkMusic.TabIndex = 34;
            this.lnkMusic.TabStop = true;
            this.lnkMusic.Text = "Music";
            this.lnkMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkGuns
            // 
            this.lnkGuns.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkGuns.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkGuns.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkGuns.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkGuns.ForeColor = System.Drawing.Color.Black;
            this.lnkGuns.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkGuns.LinkColor = System.Drawing.Color.Black;
            this.lnkGuns.Location = new System.Drawing.Point(7, 85);
            this.lnkGuns.Name = "lnkGuns";
            this.lnkGuns.Size = new System.Drawing.Size(154, 25);
            this.lnkGuns.TabIndex = 33;
            this.lnkGuns.TabStop = true;
            this.lnkGuns.Text = "Guns";
            this.lnkGuns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkTextures
            // 
            this.lnkTextures.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkTextures.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkTextures.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkTextures.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkTextures.ForeColor = System.Drawing.Color.Black;
            this.lnkTextures.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTextures.LinkColor = System.Drawing.Color.Black;
            this.lnkTextures.Location = new System.Drawing.Point(7, 60);
            this.lnkTextures.Name = "lnkTextures";
            this.lnkTextures.Size = new System.Drawing.Size(154, 25);
            this.lnkTextures.TabIndex = 32;
            this.lnkTextures.TabStop = true;
            this.lnkTextures.Text = "Textures";
            this.lnkTextures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkMap
            // 
            this.lnkMap.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkMap.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkMap.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkMap.ForeColor = System.Drawing.Color.Black;
            this.lnkMap.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMap.LinkColor = System.Drawing.Color.Black;
            this.lnkMap.Location = new System.Drawing.Point(7, 35);
            this.lnkMap.Name = "lnkMap";
            this.lnkMap.Size = new System.Drawing.Size(154, 25);
            this.lnkMap.TabIndex = 31;
            this.lnkMap.TabStop = true;
            this.lnkMap.Text = "Map";
            this.lnkMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkCars
            // 
            this.lnkCars.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkCars.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkCars.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkCars.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkCars.ForeColor = System.Drawing.Color.Black;
            this.lnkCars.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCars.LinkColor = System.Drawing.Color.Black;
            this.lnkCars.Location = new System.Drawing.Point(7, 10);
            this.lnkCars.Name = "lnkCars";
            this.lnkCars.Size = new System.Drawing.Size(154, 25);
            this.lnkCars.TabIndex = 30;
            this.lnkCars.TabStop = true;
            this.lnkCars.Text = "Cars";
            this.lnkCars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueCyr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(15, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "CATEGORIES";
            // 
            // pnlLeftGeneral
            // 
            this.pnlLeftGeneral.Controls.Add(this.pnlLeftGeneralList);
            this.pnlLeftGeneral.Controls.Add(this.lblGeneral);
            this.pnlLeftGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftGeneral.Location = new System.Drawing.Point(15, 15);
            this.pnlLeftGeneral.Name = "pnlLeftGeneral";
            this.pnlLeftGeneral.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.pnlLeftGeneral.Size = new System.Drawing.Size(176, 252);
            this.pnlLeftGeneral.TabIndex = 27;
            // 
            // pnlLeftGeneralList
            // 
            this.pnlLeftGeneralList.Controls.Add(this.lnkMostPopular);
            this.pnlLeftGeneralList.Controls.Add(this.lnkInProgress);
            this.pnlLeftGeneralList.Controls.Add(this.lnkNewReleases);
            this.pnlLeftGeneralList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftGeneralList.Location = new System.Drawing.Point(15, 27);
            this.pnlLeftGeneralList.Name = "pnlLeftGeneralList";
            this.pnlLeftGeneralList.Padding = new System.Windows.Forms.Padding(7, 10, 0, 0);
            this.pnlLeftGeneralList.Size = new System.Drawing.Size(161, 225);
            this.pnlLeftGeneralList.TabIndex = 27;
            // 
            // lnkMostPopular
            // 
            this.lnkMostPopular.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkMostPopular.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkMostPopular.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkMostPopular.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkMostPopular.ForeColor = System.Drawing.Color.Black;
            this.lnkMostPopular.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMostPopular.LinkColor = System.Drawing.Color.Black;
            this.lnkMostPopular.Location = new System.Drawing.Point(7, 60);
            this.lnkMostPopular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lnkMostPopular.Name = "lnkMostPopular";
            this.lnkMostPopular.Size = new System.Drawing.Size(154, 25);
            this.lnkMostPopular.TabIndex = 32;
            this.lnkMostPopular.TabStop = true;
            this.lnkMostPopular.Text = "Most Popular";
            this.lnkMostPopular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkInProgress
            // 
            this.lnkInProgress.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkInProgress.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkInProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkInProgress.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkInProgress.ForeColor = System.Drawing.Color.Black;
            this.lnkInProgress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkInProgress.LinkColor = System.Drawing.Color.Black;
            this.lnkInProgress.Location = new System.Drawing.Point(7, 35);
            this.lnkInProgress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lnkInProgress.Name = "lnkInProgress";
            this.lnkInProgress.Size = new System.Drawing.Size(154, 25);
            this.lnkInProgress.TabIndex = 31;
            this.lnkInProgress.TabStop = true;
            this.lnkInProgress.Text = "In Progress";
            this.lnkInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkNewReleases
            // 
            this.lnkNewReleases.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lnkNewReleases.DisabledLinkColor = System.Drawing.Color.Red;
            this.lnkNewReleases.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnkNewReleases.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkNewReleases.ForeColor = System.Drawing.Color.Black;
            this.lnkNewReleases.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNewReleases.LinkColor = System.Drawing.Color.Black;
            this.lnkNewReleases.Location = new System.Drawing.Point(7, 10);
            this.lnkNewReleases.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lnkNewReleases.Name = "lnkNewReleases";
            this.lnkNewReleases.Size = new System.Drawing.Size(154, 25);
            this.lnkNewReleases.TabIndex = 30;
            this.lnkNewReleases.TabStop = true;
            this.lnkNewReleases.Text = "New Releases";
            this.lnkNewReleases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGeneral.Font = new System.Drawing.Font("HelveticaNeueCyr", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.lblGeneral.Location = new System.Drawing.Point(15, 10);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(78, 17);
            this.lblGeneral.TabIndex = 26;
            this.lblGeneral.Text = "GENERAL";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.pctWhiteBG);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlMain.Location = new System.Drawing.Point(191, 85);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(989, 589);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContainer.Controls.Add(this.wsNewReleases);
            this.pnlContainer.Controls.Add(this.wsMap);
            this.pnlContainer.Controls.Add(this.wsCars);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(989, 589);
            this.pnlContainer.TabIndex = 8;
            this.pnlContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlContainer_Scroll);
            // 
            // wsNewReleases
            // 
            this.wsNewReleases.AutoScroll = true;
            this.wsNewReleases.BackColor = System.Drawing.Color.Silver;
            this.wsNewReleases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wsNewReleases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsNewReleases.Location = new System.Drawing.Point(0, 0);
            this.wsNewReleases.Margin = new System.Windows.Forms.Padding(22, 13, 22, 13);
            this.wsNewReleases.Name = "wsNewReleases";
            this.wsNewReleases.Size = new System.Drawing.Size(989, 589);
            this.wsNewReleases.TabIndex = 2;
            // 
            // wsMap
            // 
            this.wsMap.AutoScroll = true;
            this.wsMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsMap.Location = new System.Drawing.Point(0, 0);
            this.wsMap.Margin = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.wsMap.Name = "wsMap";
            this.wsMap.Size = new System.Drawing.Size(989, 589);
            this.wsMap.TabIndex = 1;
            // 
            // wsCars
            // 
            this.wsCars.AutoScroll = true;
            this.wsCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wsCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wsCars.Location = new System.Drawing.Point(0, 0);
            this.wsCars.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.wsCars.Name = "wsCars";
            this.wsCars.Size = new System.Drawing.Size(989, 589);
            this.wsCars.TabIndex = 0;
            // 
            // pctWhiteBG
            // 
            this.pctWhiteBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctWhiteBG.BackgroundImage")));
            this.pctWhiteBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctWhiteBG.Enabled = false;
            this.pctWhiteBG.Location = new System.Drawing.Point(0, 0);
            this.pctWhiteBG.Name = "pctWhiteBG";
            this.pctWhiteBG.Size = new System.Drawing.Size(989, 589);
            this.pctWhiteBG.TabIndex = 0;
            this.pctWhiteBG.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.pnlFootAbout);
            this.pnlFooter.Controls.Add(this.pnlVersion);
            this.pnlFooter.Controls.Add(this.pnlUpdate);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Font = new System.Drawing.Font("HelveticaNeueCyr", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlFooter.Location = new System.Drawing.Point(0, 674);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1180, 86);
            this.pnlFooter.TabIndex = 12;
            // 
            // pnlFootAbout
            // 
            this.pnlFootAbout.Controls.Add(this.pnlSocialLinks);
            this.pnlFootAbout.Controls.Add(this.lnlRevTeam);
            this.pnlFootAbout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFootAbout.Location = new System.Drawing.Point(0, 0);
            this.pnlFootAbout.Name = "pnlFootAbout";
            this.pnlFootAbout.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlFootAbout.Size = new System.Drawing.Size(226, 86);
            this.pnlFootAbout.TabIndex = 13;
            // 
            // pnlSocialLinks
            // 
            this.pnlSocialLinks.Controls.Add(this.socialIG);
            this.pnlSocialLinks.Controls.Add(this.socialYT);
            this.pnlSocialLinks.Controls.Add(this.socialFB);
            this.pnlSocialLinks.Controls.Add(this.socialVK);
            this.pnlSocialLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSocialLinks.Location = new System.Drawing.Point(0, 31);
            this.pnlSocialLinks.Name = "pnlSocialLinks";
            this.pnlSocialLinks.Padding = new System.Windows.Forms.Padding(43, 0, 43, 0);
            this.pnlSocialLinks.Size = new System.Drawing.Size(226, 55);
            this.pnlSocialLinks.TabIndex = 13;
            // 
            // socialIG
            // 
            this.socialIG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("socialIG.BackgroundImage")));
            this.socialIG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.socialIG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialIG.Dock = System.Windows.Forms.DockStyle.Left;
            this.socialIG.Location = new System.Drawing.Point(148, 0);
            this.socialIG.Margin = new System.Windows.Forms.Padding(37, 19, 37, 19);
            this.socialIG.MaximumSize = new System.Drawing.Size(35, 49);
            this.socialIG.MinimumSize = new System.Drawing.Size(35, 49);
            this.socialIG.Name = "socialIG";
            this.socialIG.Size = new System.Drawing.Size(35, 49);
            this.socialIG.TabIndex = 4;
            this.socialIG.URL = "https://instagram.com/revteam";
            // 
            // socialYT
            // 
            this.socialYT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("socialYT.BackgroundImage")));
            this.socialYT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.socialYT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialYT.Dock = System.Windows.Forms.DockStyle.Left;
            this.socialYT.Location = new System.Drawing.Point(113, 0);
            this.socialYT.Margin = new System.Windows.Forms.Padding(22, 13, 22, 13);
            this.socialYT.MaximumSize = new System.Drawing.Size(35, 49);
            this.socialYT.MinimumSize = new System.Drawing.Size(35, 49);
            this.socialYT.Name = "socialYT";
            this.socialYT.Size = new System.Drawing.Size(35, 49);
            this.socialYT.TabIndex = 3;
            this.socialYT.URL = "https://www.youtube.com/user/RevTeamHD";
            // 
            // socialFB
            // 
            this.socialFB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("socialFB.BackgroundImage")));
            this.socialFB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.socialFB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialFB.Dock = System.Windows.Forms.DockStyle.Left;
            this.socialFB.Location = new System.Drawing.Point(78, 0);
            this.socialFB.Margin = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.socialFB.MaximumSize = new System.Drawing.Size(35, 49);
            this.socialFB.MinimumSize = new System.Drawing.Size(35, 49);
            this.socialFB.Name = "socialFB";
            this.socialFB.Size = new System.Drawing.Size(35, 49);
            this.socialFB.TabIndex = 2;
            this.socialFB.URL = "https://www.facebook.com/revteam";
            // 
            // socialVK
            // 
            this.socialVK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("socialVK.BackgroundImage")));
            this.socialVK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.socialVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.socialVK.Dock = System.Windows.Forms.DockStyle.Left;
            this.socialVK.Location = new System.Drawing.Point(43, 0);
            this.socialVK.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.socialVK.MaximumSize = new System.Drawing.Size(35, 49);
            this.socialVK.MinimumSize = new System.Drawing.Size(35, 49);
            this.socialVK.Name = "socialVK";
            this.socialVK.Size = new System.Drawing.Size(35, 49);
            this.socialVK.TabIndex = 1;
            this.socialVK.URL = "https://vk.com/vice_city_2";
            // 
            // lnlRevTeam
            // 
            this.lnlRevTeam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lnlRevTeam.Font = new System.Drawing.Font("HelveticaNeueCyr", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnlRevTeam.Location = new System.Drawing.Point(0, 10);
            this.lnlRevTeam.Name = "lnlRevTeam";
            this.lnlRevTeam.Size = new System.Drawing.Size(226, 21);
            this.lnlRevTeam.TabIndex = 8;
            this.lnlRevTeam.Text = "Revolution Team";
            this.lnlRevTeam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlVersion
            // 
            this.pnlVersion.Controls.Add(this.lblNewVersion);
            this.pnlVersion.Controls.Add(this.lblCurrentVersion);
            this.pnlVersion.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVersion.Location = new System.Drawing.Point(768, 0);
            this.pnlVersion.Name = "pnlVersion";
            this.pnlVersion.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.pnlVersion.Size = new System.Drawing.Size(253, 86);
            this.pnlVersion.TabIndex = 11;
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNewVersion.Font = new System.Drawing.Font("HelveticaNeueCyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewVersion.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNewVersion.Location = new System.Drawing.Point(0, 48);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(253, 23);
            this.lblNewVersion.TabIndex = 4;
            this.lblNewVersion.Text = "New is 0.02";
            this.lblNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentVersion.Font = new System.Drawing.Font("HelveticaNeueCyr", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentVersion.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentVersion.Location = new System.Drawing.Point(0, 15);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(253, 23);
            this.lblCurrentVersion.TabIndex = 3;
            this.lblCurrentVersion.Text = "Your Version is 0.01";
            this.lblCurrentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblUpdate);
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpdate.Location = new System.Drawing.Point(1021, 0);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Padding = new System.Windows.Forms.Padding(15);
            this.pnlUpdate.Size = new System.Drawing.Size(159, 86);
            this.pnlUpdate.TabIndex = 9;
            // 
            // lblUpdate
            // 
            this.lblUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblUpdate.Location = new System.Drawing.Point(15, 15);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(129, 56);
            this.lblUpdate.TabIndex = 4;
            this.lblUpdate.Text = "UPDATE";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxSettings
            // 
            this.ctxSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExit});
            this.ctxSettings.Name = "ctxSettings";
            this.ctxSettings.Size = new System.Drawing.Size(109, 26);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(108, 22);
            this.tsExit.Text = "Выход";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 760);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pnlFooter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            this.pnlHeadLinksContainer.ResumeLayout(false);
            this.pnlTopLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.pnlLeftCategories.ResumeLayout(false);
            this.pnlLeftCategories.PerformLayout();
            this.pnlLeftCategoriesList.ResumeLayout(false);
            this.pnlLeftGeneral.ResumeLayout(false);
            this.pnlLeftGeneral.PerformLayout();
            this.pnlLeftGeneralList.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctWhiteBG)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFootAbout.ResumeLayout(false);
            this.pnlSocialLinks.ResumeLayout(false);
            this.pnlVersion.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.ctxSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctWhiteBG;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel pnlVersion;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Panel pnlFootAbout;
        private System.Windows.Forms.Panel pnlSocialLinks;
        private System.Windows.Forms.Label lnlRevTeam;
        private System.Windows.Forms.Panel pnlLeftGeneral;
        private System.Windows.Forms.Panel pnlLeftGeneralList;
        private System.Windows.Forms.LinkLabel lnkMostPopular;
        private System.Windows.Forms.LinkLabel lnkInProgress;
        private System.Windows.Forms.LinkLabel lnkNewReleases;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.Panel pnlLeftCategories;
        private System.Windows.Forms.Panel pnlLeftCategoriesList;
        private System.Windows.Forms.LinkLabel lnkMusic;
        private System.Windows.Forms.LinkLabel lnkGuns;
        private System.Windows.Forms.LinkLabel lnkTextures;
        private System.Windows.Forms.LinkLabel lnkMap;
        private System.Windows.Forms.LinkLabel lnkCars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHeadLinksContainer;
        public System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.ContextMenuStrip ctxSettings;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Panel pnlTopLinks;
        private System.Windows.Forms.LinkLabel lnkSettings;
        private System.Windows.Forms.LinkLabel lnkContacts;
        private System.Windows.Forms.LinkLabel lnkDownloads;
        private System.Windows.Forms.LinkLabel lnkNews;
        private SocialLink socialVK;
        private SocialLink socialFB;
        private SocialLink socialYT;
        private SocialLink socialIG;
        private Workspace wsCars;
        private Workspace wsMap;
        private Workspace wsNewReleases;
    }
}

