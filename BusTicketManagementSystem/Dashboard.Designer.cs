namespace BusTicketManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPassenger = new Guna.UI2.WinForms.Guna2Button();
            this.btnBusFare = new Guna.UI2.WinForms.Guna2Button();
            this.btnBusInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnReservations = new Guna.UI2.WinForms.Guna2Button();
            this.btnTicketBooking = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvailable = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bus_Fare1 = new BusTicketManagementSystem.User_Controls.Bus_Fare();
            this.analytics1 = new BusTicketManagementSystem.User_Controls.Analytics();
            this.reservations1 = new BusTicketManagementSystem.User_Controls.Reservations();
            this.ticket_booking1 = new BusTicketManagementSystem.User_Controls.Ticket_booking();
            this.bus_Info1 = new BusTicketManagementSystem.User_Controls.Bus_Info();
            this.available_Trip1 = new BusTicketManagementSystem.User_Controls.Available_Trip();
            this.user_Dashboard1 = new BusTicketManagementSystem.User_Controls.User_Dashboard();
            this.passengers1 = new BusTicketManagementSystem.User_Controls.Passengers();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.btnPassenger);
            this.panel1.Controls.Add(this.btnBusFare);
            this.panel1.Controls.Add(this.btnBusInfo);
            this.panel1.Controls.Add(this.btnReservations);
            this.panel1.Controls.Add(this.btnTicketBooking);
            this.panel1.Controls.Add(this.btnAvailable);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 645);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 6;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnLogout.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(46)))), ((int)(((byte)(113)))));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Location = new System.Drawing.Point(13, 585);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(148, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 6;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(12, 448);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(148, 37);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Edit & Reset";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // btnPassenger
            // 
            this.btnPassenger.BackColor = System.Drawing.Color.Transparent;
            this.btnPassenger.BorderRadius = 6;
            this.btnPassenger.CheckedState.Parent = this.btnPassenger;
            this.btnPassenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassenger.CustomImages.Parent = this.btnPassenger;
            this.btnPassenger.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnPassenger.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassenger.ForeColor = System.Drawing.Color.White;
            this.btnPassenger.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnPassenger.HoverState.Parent = this.btnPassenger;
            this.btnPassenger.Image = ((System.Drawing.Image)(resources.GetObject("btnPassenger.Image")));
            this.btnPassenger.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassenger.Location = new System.Drawing.Point(12, 403);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.ShadowDecoration.Parent = this.btnPassenger;
            this.btnPassenger.Size = new System.Drawing.Size(148, 37);
            this.btnPassenger.TabIndex = 4;
            this.btnPassenger.Tag = "passengers1";
            this.btnPassenger.Text = "Passengers";
            this.btnPassenger.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassenger.UseTransparentBackground = true;
            this.btnPassenger.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // btnBusFare
            // 
            this.btnBusFare.BackColor = System.Drawing.Color.Transparent;
            this.btnBusFare.BorderRadius = 6;
            this.btnBusFare.CheckedState.Parent = this.btnBusFare;
            this.btnBusFare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusFare.CustomImages.Parent = this.btnBusFare;
            this.btnBusFare.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnBusFare.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusFare.ForeColor = System.Drawing.Color.White;
            this.btnBusFare.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBusFare.HoverState.Parent = this.btnBusFare;
            this.btnBusFare.Image = ((System.Drawing.Image)(resources.GetObject("btnBusFare.Image")));
            this.btnBusFare.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBusFare.Location = new System.Drawing.Point(12, 358);
            this.btnBusFare.Name = "btnBusFare";
            this.btnBusFare.ShadowDecoration.Parent = this.btnBusFare;
            this.btnBusFare.Size = new System.Drawing.Size(148, 37);
            this.btnBusFare.TabIndex = 4;
            this.btnBusFare.Tag = "bus_Fare1";
            this.btnBusFare.Text = "Bus Fare";
            this.btnBusFare.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBusFare.UseTransparentBackground = true;
            this.btnBusFare.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // btnBusInfo
            // 
            this.btnBusInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnBusInfo.BorderRadius = 6;
            this.btnBusInfo.CheckedState.Parent = this.btnBusInfo;
            this.btnBusInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusInfo.CustomImages.Parent = this.btnBusInfo;
            this.btnBusInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnBusInfo.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusInfo.ForeColor = System.Drawing.Color.White;
            this.btnBusInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnBusInfo.HoverState.Parent = this.btnBusInfo;
            this.btnBusInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnBusInfo.Image")));
            this.btnBusInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBusInfo.Location = new System.Drawing.Point(12, 313);
            this.btnBusInfo.Name = "btnBusInfo";
            this.btnBusInfo.ShadowDecoration.Parent = this.btnBusInfo;
            this.btnBusInfo.Size = new System.Drawing.Size(148, 37);
            this.btnBusInfo.TabIndex = 4;
            this.btnBusInfo.Tag = "bus_Info1";
            this.btnBusInfo.Text = "Bus Info";
            this.btnBusInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBusInfo.UseTransparentBackground = true;
            this.btnBusInfo.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnReservations.BorderRadius = 6;
            this.btnReservations.CheckedState.Parent = this.btnReservations;
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.CustomImages.Parent = this.btnReservations;
            this.btnReservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnReservations.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnReservations.HoverState.Parent = this.btnReservations;
            this.btnReservations.Image = ((System.Drawing.Image)(resources.GetObject("btnReservations.Image")));
            this.btnReservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservations.Location = new System.Drawing.Point(16, 226);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.ShadowDecoration.Parent = this.btnReservations;
            this.btnReservations.Size = new System.Drawing.Size(148, 37);
            this.btnReservations.TabIndex = 4;
            this.btnReservations.Tag = "reservations1";
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReservations.UseTransparentBackground = true;
            this.btnReservations.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // btnTicketBooking
            // 
            this.btnTicketBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnTicketBooking.BorderRadius = 6;
            this.btnTicketBooking.CheckedState.Parent = this.btnTicketBooking;
            this.btnTicketBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketBooking.CustomImages.Parent = this.btnTicketBooking;
            this.btnTicketBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnTicketBooking.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketBooking.ForeColor = System.Drawing.Color.White;
            this.btnTicketBooking.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnTicketBooking.HoverState.Parent = this.btnTicketBooking;
            this.btnTicketBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnTicketBooking.Image")));
            this.btnTicketBooking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTicketBooking.Location = new System.Drawing.Point(16, 182);
            this.btnTicketBooking.Name = "btnTicketBooking";
            this.btnTicketBooking.ShadowDecoration.Parent = this.btnTicketBooking;
            this.btnTicketBooking.Size = new System.Drawing.Size(148, 37);
            this.btnTicketBooking.TabIndex = 4;
            this.btnTicketBooking.Tag = "ticket_booking1";
            this.btnTicketBooking.Text = "Ticket Booking";
            this.btnTicketBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTicketBooking.UseTransparentBackground = true;
            this.btnTicketBooking.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.Color.Transparent;
            this.btnAvailable.BorderRadius = 6;
            this.btnAvailable.CheckedState.Parent = this.btnAvailable;
            this.btnAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvailable.CustomImages.Parent = this.btnAvailable;
            this.btnAvailable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnAvailable.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.ForeColor = System.Drawing.Color.White;
            this.btnAvailable.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnAvailable.HoverState.Parent = this.btnAvailable;
            this.btnAvailable.Image = ((System.Drawing.Image)(resources.GetObject("btnAvailable.Image")));
            this.btnAvailable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAvailable.Location = new System.Drawing.Point(16, 138);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.ShadowDecoration.Parent = this.btnAvailable;
            this.btnAvailable.Size = new System.Drawing.Size(148, 37);
            this.btnAvailable.TabIndex = 4;
            this.btnAvailable.Tag = "available_Trip1";
            this.btnAvailable.Text = "Available Trip";
            this.btnAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAvailable.UseTransparentBackground = true;
            this.btnAvailable.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 6;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnDashboard.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(16, 94);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(148, 37);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Tag = "user_Dashboard1";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.UseTransparentBackground = true;
            this.btnDashboard.Click += new System.EventHandler(this.dashboardSidebarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(19, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "SETTINGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAVIGATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.passengers1);
            this.panel2.Controls.Add(this.bus_Fare1);
            this.panel2.Controls.Add(this.analytics1);
            this.panel2.Controls.Add(this.reservations1);
            this.panel2.Controls.Add(this.ticket_booking1);
            this.panel2.Controls.Add(this.bus_Info1);
            this.panel2.Controls.Add(this.available_Trip1);
            this.panel2.Controls.Add(this.user_Dashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 645);
            this.panel2.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.CustomImages.Parent = this.closeBtn;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(97)))), ((int)(((byte)(93)))));
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(97)))), ((int)(((byte)(93)))));
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(954, 18);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(64)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(64)))));
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Location = new System.Drawing.Point(930, 18);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bus_Fare1
            // 
            this.bus_Fare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.bus_Fare1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_Fare1.Location = new System.Drawing.Point(9, 9);
            this.bus_Fare1.Margin = new System.Windows.Forms.Padding(5);
            this.bus_Fare1.Name = "bus_Fare1";
            this.bus_Fare1.Size = new System.Drawing.Size(977, 626);
            this.bus_Fare1.TabIndex = 12;
            // 
            // analytics1
            // 
            this.analytics1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.analytics1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analytics1.Location = new System.Drawing.Point(9, 9);
            this.analytics1.Margin = new System.Windows.Forms.Padding(5);
            this.analytics1.Name = "analytics1";
            this.analytics1.Size = new System.Drawing.Size(977, 626);
            this.analytics1.TabIndex = 11;
            // 
            // reservations1
            // 
            this.reservations1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservations1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservations1.Location = new System.Drawing.Point(9, 9);
            this.reservations1.Margin = new System.Windows.Forms.Padding(5);
            this.reservations1.Name = "reservations1";
            this.reservations1.Size = new System.Drawing.Size(977, 626);
            this.reservations1.TabIndex = 10;
            // 
            // ticket_booking1
            // 
            this.ticket_booking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.ticket_booking1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket_booking1.Location = new System.Drawing.Point(9, 9);
            this.ticket_booking1.Margin = new System.Windows.Forms.Padding(5);
            this.ticket_booking1.Name = "ticket_booking1";
            this.ticket_booking1.Size = new System.Drawing.Size(977, 626);
            this.ticket_booking1.TabIndex = 9;
            // 
            // bus_Info1
            // 
            this.bus_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.bus_Info1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus_Info1.Location = new System.Drawing.Point(9, 9);
            this.bus_Info1.Margin = new System.Windows.Forms.Padding(5);
            this.bus_Info1.Name = "bus_Info1";
            this.bus_Info1.Size = new System.Drawing.Size(977, 626);
            this.bus_Info1.TabIndex = 2;
            // 
            // available_Trip1
            // 
            this.available_Trip1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.available_Trip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.available_Trip1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_Trip1.Location = new System.Drawing.Point(9, 9);
            this.available_Trip1.Margin = new System.Windows.Forms.Padding(5);
            this.available_Trip1.Name = "available_Trip1";
            this.available_Trip1.Size = new System.Drawing.Size(977, 626);
            this.available_Trip1.TabIndex = 1;
            // 
            // user_Dashboard1
            // 
            this.user_Dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.user_Dashboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_Dashboard1.BackgroundImage")));
            this.user_Dashboard1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Dashboard1.Location = new System.Drawing.Point(9, 9);
            this.user_Dashboard1.Margin = new System.Windows.Forms.Padding(5);
            this.user_Dashboard1.Name = "user_Dashboard1";
            this.user_Dashboard1.Size = new System.Drawing.Size(977, 626);
            this.user_Dashboard1.TabIndex = 0;
            // 
            // passengers1
            // 
            this.passengers1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.passengers1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengers1.Location = new System.Drawing.Point(9, 9);
            this.passengers1.Margin = new System.Windows.Forms.Padding(5);
            this.passengers1.Name = "passengers1";
            this.passengers1.Size = new System.Drawing.Size(977, 626);
            this.passengers1.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1167, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnAvailable;
        private Guna.UI2.WinForms.Guna2Button btnTicketBooking;
        private Guna.UI2.WinForms.Guna2Button btnReservations;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private User_Controls.User_Dashboard user_Dashboard1;
        private User_Controls.Available_Trip available_Trip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPassenger;
        private Guna.UI2.WinForms.Guna2Button btnBusInfo;
        private User_Controls.Bus_Info bus_Info1;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        public User_Controls.Ticket_booking ticket_booking1;
        private User_Controls.Reservations reservations1;
        private User_Controls.Analytics analytics1;
        private Guna.UI2.WinForms.Guna2Button btnBusFare;
        private User_Controls.Bus_Fare bus_Fare1;
        private User_Controls.Passengers passengers1;
    }
}