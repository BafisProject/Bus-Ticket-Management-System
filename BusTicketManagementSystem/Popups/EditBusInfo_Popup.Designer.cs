namespace BusTicketManagementSystem.Popups
{
    partial class EditBusInfo_Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBusInfo_Popup));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label2 = new System.Windows.Forms.Label();
            this.busClassComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.busStatusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUpdateBus = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.busNumberTxt = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bus Class";
            // 
            // busClassComboBox
            // 
            this.busClassComboBox.BackColor = System.Drawing.Color.Transparent;
            this.busClassComboBox.BorderRadius = 6;
            this.busClassComboBox.BorderThickness = 0;
            this.busClassComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.busClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.busClassComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.busClassComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.busClassComboBox.FocusedState.Parent = this.busClassComboBox;
            this.busClassComboBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.busClassComboBox.ForeColor = System.Drawing.Color.White;
            this.busClassComboBox.FormattingEnabled = true;
            this.busClassComboBox.HoverState.Parent = this.busClassComboBox;
            this.busClassComboBox.ItemHeight = 30;
            this.busClassComboBox.Items.AddRange(new object[] {
            "Economy",
            "Business (AC)"});
            this.busClassComboBox.ItemsAppearance.Parent = this.busClassComboBox;
            this.busClassComboBox.Location = new System.Drawing.Point(46, 100);
            this.busClassComboBox.Name = "busClassComboBox";
            this.busClassComboBox.ShadowDecoration.Parent = this.busClassComboBox;
            this.busClassComboBox.Size = new System.Drawing.Size(165, 36);
            this.busClassComboBox.TabIndex = 7;
            this.busClassComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 148);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bus Status";
            // 
            // busStatusComboBox
            // 
            this.busStatusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.busStatusComboBox.BorderRadius = 6;
            this.busStatusComboBox.BorderThickness = 0;
            this.busStatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.busStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.busStatusComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.busStatusComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.busStatusComboBox.FocusedState.Parent = this.busStatusComboBox;
            this.busStatusComboBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.busStatusComboBox.ForeColor = System.Drawing.Color.White;
            this.busStatusComboBox.FormattingEnabled = true;
            this.busStatusComboBox.HoverState.Parent = this.busStatusComboBox;
            this.busStatusComboBox.ItemHeight = 30;
            this.busStatusComboBox.Items.AddRange(new object[] {
            "Available",
            "Departed"});
            this.busStatusComboBox.ItemsAppearance.Parent = this.busStatusComboBox;
            this.busStatusComboBox.Location = new System.Drawing.Point(46, 178);
            this.busStatusComboBox.Name = "busStatusComboBox";
            this.busStatusComboBox.ShadowDecoration.Parent = this.busStatusComboBox;
            this.busStatusComboBox.Size = new System.Drawing.Size(165, 36);
            this.busStatusComboBox.TabIndex = 7;
            this.busStatusComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.AllowToggling = false;
            this.btnUpdateBus.AnimationSpeed = 200;
            this.btnUpdateBus.AutoGenerateColors = false;
            this.btnUpdateBus.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateBus.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnUpdateBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateBus.BackgroundImage")));
            this.btnUpdateBus.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateBus.ButtonText = "Update Info";
            this.btnUpdateBus.ButtonTextMarginLeft = 0;
            this.btnUpdateBus.ColorContrastOnClick = 45;
            this.btnUpdateBus.ColorContrastOnHover = 45;
            this.btnUpdateBus.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUpdateBus.CustomizableEdges = borderEdges1;
            this.btnUpdateBus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateBus.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnUpdateBus.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdateBus.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdateBus.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdateBus.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBus.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBus.IconMarginLeft = 11;
            this.btnUpdateBus.IconPadding = 10;
            this.btnUpdateBus.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBus.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateBus.IdleBorderRadius = 10;
            this.btnUpdateBus.IdleBorderThickness = 1;
            this.btnUpdateBus.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnUpdateBus.IdleIconLeftImage = null;
            this.btnUpdateBus.IdleIconRightImage = null;
            this.btnUpdateBus.IndicateFocus = false;
            this.btnUpdateBus.Location = new System.Drawing.Point(46, 232);
            this.btnUpdateBus.Name = "btnUpdateBus";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnUpdateBus.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 10;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnUpdateBus.OnPressedState = stateProperties2;
            this.btnUpdateBus.Size = new System.Drawing.Size(165, 36);
            this.btnUpdateBus.TabIndex = 8;
            this.btnUpdateBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateBus.TextMarginLeft = 0;
            this.btnUpdateBus.UseDefaultRadiusAndThickness = true;
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.CustomImages.Parent = this.closeBtn;
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(97)))), ((int)(((byte)(93)))));
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(97)))), ((int)(((byte)(93)))));
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(217, 15);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.guna2Panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // busNumberTxt
            // 
            this.busNumberTxt.AutoSize = true;
            this.busNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.busNumberTxt.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busNumberTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.busNumberTxt.Location = new System.Drawing.Point(46, 33);
            this.busNumberTxt.Name = "busNumberTxt";
            this.busNumberTxt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.busNumberTxt.Size = new System.Drawing.Size(121, 21);
            this.busNumberTxt.TabIndex = 6;
            this.busNumberTxt.Text = "BUS NUMBER";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(256, 300);
            this.guna2Panel1.TabIndex = 10;
            // 
            // EditBusInfo_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(256, 300);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnUpdateBus);
            this.Controls.Add(this.busStatusComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busClassComboBox);
            this.Controls.Add(this.busNumberTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditBusInfo_Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBusInfo_Popup";
            this.Load += new System.EventHandler(this.EditBusInfo_Popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox busClassComboBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox busStatusComboBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateBus;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label busNumberTxt;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}