namespace BusTicketManagementSystem.Popups
{
    partial class EditTripInfo_Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTripInfo_Popup));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.tripIDTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.destinationComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.departTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.departDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateTrip = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // tripIDTxt
            // 
            this.tripIDTxt.AutoSize = true;
            this.tripIDTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.tripIDTxt.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripIDTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.tripIDTxt.Location = new System.Drawing.Point(55, 36);
            this.tripIDTxt.Name = "tripIDTxt";
            this.tripIDTxt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tripIDTxt.Size = new System.Drawing.Size(72, 21);
            this.tripIDTxt.TabIndex = 7;
            this.tripIDTxt.Text = "TRIP ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 78);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.BackColor = System.Drawing.Color.Transparent;
            this.destinationComboBox.BorderRadius = 6;
            this.destinationComboBox.BorderThickness = 0;
            this.destinationComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.destinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.destinationComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.destinationComboBox.FocusedState.Parent = this.destinationComboBox;
            this.destinationComboBox.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.destinationComboBox.ForeColor = System.Drawing.Color.White;
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.HoverState.Parent = this.destinationComboBox;
            this.destinationComboBox.ItemHeight = 30;
            this.destinationComboBox.Items.AddRange(new object[] {
            "Dhaka",
            "Chattogram",
            "Barishal",
            "Rajshahi",
            "Sylhet",
            "Comilla",
            "Rangpur"});
            this.destinationComboBox.ItemsAppearance.Parent = this.destinationComboBox;
            this.destinationComboBox.Location = new System.Drawing.Point(59, 106);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.ShadowDecoration.Parent = this.destinationComboBox;
            this.destinationComboBox.Size = new System.Drawing.Size(165, 36);
            this.destinationComboBox.TabIndex = 12;
            this.destinationComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // departTimePicker
            // 
            this.departTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.departTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.departTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.departTimePicker.Checked = false;
            this.departTimePicker.CustomFormat = "  hh:mm tt";
            this.departTimePicker.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departTimePicker.Location = new System.Drawing.Point(59, 183);
            this.departTimePicker.MinimumSize = new System.Drawing.Size(165, 36);
            this.departTimePicker.Name = "departTimePicker";
            this.departTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.departTimePicker.ShowUpDown = true;
            this.departTimePicker.Size = new System.Drawing.Size(165, 36);
            this.departTimePicker.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 155);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Depart. Time";
            // 
            // departDatePicker
            // 
            this.departDatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.departDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.departDatePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.departDatePicker.Checked = false;
            this.departDatePicker.CustomFormat = "  dd, MMM, yyyy";
            this.departDatePicker.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departDatePicker.Location = new System.Drawing.Point(59, 260);
            this.departDatePicker.MinimumSize = new System.Drawing.Size(165, 36);
            this.departDatePicker.Name = "departDatePicker";
            this.departDatePicker.Size = new System.Drawing.Size(165, 36);
            this.departDatePicker.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 232);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Depart. Date";
            // 
            // btnUpdateTrip
            // 
            this.btnUpdateTrip.AllowToggling = false;
            this.btnUpdateTrip.AnimationSpeed = 200;
            this.btnUpdateTrip.AutoGenerateColors = false;
            this.btnUpdateTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateTrip.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnUpdateTrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateTrip.BackgroundImage")));
            this.btnUpdateTrip.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUpdateTrip.ButtonText = "Update Info";
            this.btnUpdateTrip.ButtonTextMarginLeft = 0;
            this.btnUpdateTrip.ColorContrastOnClick = 45;
            this.btnUpdateTrip.ColorContrastOnHover = 45;
            this.btnUpdateTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnUpdateTrip.CustomizableEdges = borderEdges2;
            this.btnUpdateTrip.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateTrip.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnUpdateTrip.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUpdateTrip.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUpdateTrip.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUpdateTrip.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTrip.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTrip.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTrip.IconMarginLeft = 11;
            this.btnUpdateTrip.IconPadding = 10;
            this.btnUpdateTrip.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTrip.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateTrip.IdleBorderRadius = 10;
            this.btnUpdateTrip.IdleBorderThickness = 1;
            this.btnUpdateTrip.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnUpdateTrip.IdleIconLeftImage = null;
            this.btnUpdateTrip.IdleIconRightImage = null;
            this.btnUpdateTrip.IndicateFocus = false;
            this.btnUpdateTrip.Location = new System.Drawing.Point(57, 318);
            this.btnUpdateTrip.Name = "btnUpdateTrip";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 10;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnUpdateTrip.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 10;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnUpdateTrip.OnPressedState = stateProperties4;
            this.btnUpdateTrip.Size = new System.Drawing.Size(165, 36);
            this.btnUpdateTrip.TabIndex = 19;
            this.btnUpdateTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateTrip.TextMarginLeft = 0;
            this.btnUpdateTrip.UseDefaultRadiusAndThickness = true;
            this.btnUpdateTrip.Click += new System.EventHandler(this.btnUpdateTrip_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(238, 21);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeBtn.ShadowDecoration.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
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
            this.guna2Panel1.Size = new System.Drawing.Size(279, 390);
            this.guna2Panel1.TabIndex = 21;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.guna2Panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // EditTripInfo_Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(279, 390);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnUpdateTrip);
            this.Controls.Add(this.departDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.tripIDTxt);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EditTripInfo_Popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTripInfo_Popup";
            this.Load += new System.EventHandler(this.EditTripInfo_Popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tripIDTxt;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox destinationComboBox;
        private System.Windows.Forms.DateTimePicker departTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker departDatePicker;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUpdateTrip;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}