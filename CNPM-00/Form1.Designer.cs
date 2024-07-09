namespace HotelManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.avatarUser = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnRoles = new FontAwesome.Sharp.IconButton();
            this.btnRooms = new FontAwesome.Sharp.IconButton();
            this.btnRoomCategories = new FontAwesome.Sharp.IconButton();
            this.btnReservations = new FontAwesome.Sharp.IconButton();
            this.btnServices = new FontAwesome.Sharp.IconButton();
            this.btnInvoices = new FontAwesome.Sharp.IconButton();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarUser)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.flowLayoutPanel2);
            this.sidebar.Location = new System.Drawing.Point(0, 26);
            this.sidebar.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(165, 609);
            this.sidebar.MinimumSize = new System.Drawing.Size(38, 609);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(165, 609);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.roleName);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.avatarUser);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 148);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // roleName
            // 
            this.roleName.AutoSize = true;
            this.roleName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roleName.Location = new System.Drawing.Point(50, 125);
            this.roleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleName.Name = "roleName";
            this.roleName.Size = new System.Drawing.Size(62, 17);
            this.roleName.TabIndex = 3;
            this.roleName.Text = "Manager";
            this.roleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roleName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userName.Location = new System.Drawing.Point(18, 107);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(125, 18);
            this.userName.TabIndex = 2;
            this.userName.Text = "Luong Chi Trung";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnMenu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 36;
            this.btnMenu.Location = new System.Drawing.Point(2, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 32);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Tick);
            // 
            // avatarUser
            // 
            this.avatarUser.Image = ((System.Drawing.Image)(resources.GetObject("avatarUser.Image")));
            this.avatarUser.Location = new System.Drawing.Point(0, 36);
            this.avatarUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avatarUser.Name = "avatarUser";
            this.avatarUser.Size = new System.Drawing.Size(163, 65);
            this.avatarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarUser.TabIndex = 1;
            this.avatarUser.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnHome);
            this.flowLayoutPanel2.Controls.Add(this.btnDashboard);
            this.flowLayoutPanel2.Controls.Add(this.btnUsers);
            this.flowLayoutPanel2.Controls.Add(this.btnRoles);
            this.flowLayoutPanel2.Controls.Add(this.btnRooms);
            this.flowLayoutPanel2.Controls.Add(this.btnRoomCategories);
            this.flowLayoutPanel2.Controls.Add(this.btnReservations);
            this.flowLayoutPanel2.Controls.Add(this.btnServices);
            this.flowLayoutPanel2.Controls.Add(this.btnInvoices);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 154);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 420);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHome.IconSize = 36;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(2, 2);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(161, 41);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = " Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            this.btnHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHome_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnDashboard.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDashboard.IconSize = 36;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(1, 47);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(162, 41);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnUsers.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUsers.IconSize = 36;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(1, 92);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(162, 41);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = " Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoles.IconChar = FontAwesome.Sharp.IconChar.PencilRuler;
            this.btnRoles.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoles.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRoles.IconSize = 36;
            this.btnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.Location = new System.Drawing.Point(1, 137);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(162, 41);
            this.btnRoles.TabIndex = 9;
            this.btnRoles.Text = " Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoles.UseVisualStyleBackColor = false;
            // 
            // btnRooms
            // 
            this.btnRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRooms.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnRooms.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRooms.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRooms.IconSize = 36;
            this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.Location = new System.Drawing.Point(1, 182);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(162, 41);
            this.btnRooms.TabIndex = 4;
            this.btnRooms.Text = " Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRooms.UseVisualStyleBackColor = false;
            // 
            // btnRoomCategories
            // 
            this.btnRoomCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnRoomCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnRoomCategories.FlatAppearance.BorderSize = 0;
            this.btnRoomCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomCategories.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomCategories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoomCategories.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnRoomCategories.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnRoomCategories.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRoomCategories.IconSize = 36;
            this.btnRoomCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomCategories.Location = new System.Drawing.Point(1, 227);
            this.btnRoomCategories.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnRoomCategories.Name = "btnRoomCategories";
            this.btnRoomCategories.Size = new System.Drawing.Size(162, 47);
            this.btnRoomCategories.TabIndex = 8;
            this.btnRoomCategories.Text = " Room Categories";
            this.btnRoomCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomCategories.UseVisualStyleBackColor = false;
            this.btnRoomCategories.Click += new System.EventHandler(this.iconButton2_Click_2);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservations.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnReservations.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnReservations.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnReservations.IconSize = 36;
            this.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.Location = new System.Drawing.Point(1, 278);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(162, 41);
            this.btnReservations.TabIndex = 7;
            this.btnReservations.Text = " Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservations.UseVisualStyleBackColor = false;
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnServices.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.btnServices.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnServices.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnServices.IconSize = 36;
            this.btnServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.Location = new System.Drawing.Point(1, 323);
            this.btnServices.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(162, 41);
            this.btnServices.TabIndex = 5;
            this.btnServices.Text = " Services";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInvoices.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnInvoices.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnInvoices.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnInvoices.IconSize = 36;
            this.btnInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoices.Location = new System.Drawing.Point(1, 368);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(1, 2, 2, 2);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(162, 41);
            this.btnInvoices.TabIndex = 10;
            this.btnInvoices.Text = " Invoices";
            this.btnInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoices.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 28);
            this.panel2.TabIndex = 1;
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(887, 0);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(26, 28);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(949, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(26, 28);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(918, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(26, 28);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 1;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(975, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarUser)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnRooms;
        private FontAwesome.Sharp.IconButton btnServices;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnReservations;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox avatarUser;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label roleName;
        private FontAwesome.Sharp.IconButton btnRoomCategories;
        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnInvoices;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}

