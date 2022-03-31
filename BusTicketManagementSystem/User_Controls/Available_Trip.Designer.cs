namespace BusTicketManagementSystem.User_Controls
{
    partial class Available_Trip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available_Trip));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAddTrip = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.destinationComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.departDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.busNumberText = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tripGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tripGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.AllowToggling = false;
            this.btnAddTrip.AnimationSpeed = 200;
            this.btnAddTrip.AutoGenerateColors = false;
            this.btnAddTrip.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTrip.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAddTrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTrip.BackgroundImage")));
            this.btnAddTrip.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddTrip.ButtonText = "Add Trip";
            this.btnAddTrip.ButtonTextMarginLeft = 0;
            this.btnAddTrip.ColorContrastOnClick = 45;
            this.btnAddTrip.ColorContrastOnHover = 45;
            this.btnAddTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddTrip.CustomizableEdges = borderEdges1;
            this.btnAddTrip.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddTrip.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnAddTrip.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddTrip.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddTrip.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddTrip.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrip.ForeColor = System.Drawing.Color.White;
            this.btnAddTrip.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrip.IconMarginLeft = 11;
            this.btnAddTrip.IconPadding = 10;
            this.btnAddTrip.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrip.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAddTrip.IdleBorderRadius = 10;
            this.btnAddTrip.IdleBorderThickness = 1;
            this.btnAddTrip.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAddTrip.IdleIconLeftImage = null;
            this.btnAddTrip.IdleIconRightImage = null;
            this.btnAddTrip.IndicateFocus = false;
            this.btnAddTrip.Location = new System.Drawing.Point(774, 63);
            this.btnAddTrip.Name = "btnAddTrip";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 10;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnAddTrip.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 10;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnAddTrip.OnPressedState = stateProperties6;
            this.btnAddTrip.Size = new System.Drawing.Size(165, 36);
            this.btnAddTrip.TabIndex = 13;
            this.btnAddTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTrip.TextMarginLeft = 0;
            this.btnAddTrip.UseDefaultRadiusAndThickness = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
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
            this.destinationComboBox.Location = new System.Drawing.Point(38, 63);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.ShadowDecoration.Parent = this.destinationComboBox;
            this.destinationComboBox.Size = new System.Drawing.Size(165, 36);
            this.destinationComboBox.TabIndex = 9;
            this.destinationComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(38, 34);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Destination";
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
            this.departTimePicker.Location = new System.Drawing.Point(222, 63);
            this.departTimePicker.MinimumSize = new System.Drawing.Size(165, 36);
            this.departTimePicker.Name = "departTimePicker";
            this.departTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.departTimePicker.ShowUpDown = true;
            this.departTimePicker.Size = new System.Drawing.Size(165, 36);
            this.departTimePicker.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(219, 34);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 11;
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
            this.departDatePicker.Location = new System.Drawing.Point(406, 63);
            this.departDatePicker.MinimumSize = new System.Drawing.Size(165, 36);
            this.departDatePicker.Name = "departDatePicker";
            this.departDatePicker.Size = new System.Drawing.Size(165, 36);
            this.departDatePicker.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(403, 34);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Depart. Date";
            // 
            // busNumberText
            // 
            this.busNumberText.AcceptsReturn = false;
            this.busNumberText.AcceptsTab = false;
            this.busNumberText.AnimationSpeed = 200;
            this.busNumberText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.busNumberText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.busNumberText.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.busNumberText.BackColor = System.Drawing.Color.Transparent;
            this.busNumberText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("busNumberText.BackgroundImage")));
            this.busNumberText.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.busNumberText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.busNumberText.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.busNumberText.BorderColorIdle = System.Drawing.Color.Transparent;
            this.busNumberText.BorderRadius = 12;
            this.busNumberText.BorderThickness = 0;
            this.busNumberText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.busNumberText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.busNumberText.DefaultFont = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busNumberText.DefaultText = "";
            this.busNumberText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.busNumberText.ForeColor = System.Drawing.Color.White;
            this.busNumberText.HideSelection = true;
            this.busNumberText.IconLeft = null;
            this.busNumberText.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.busNumberText.IconPadding = 10;
            this.busNumberText.IconRight = null;
            this.busNumberText.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.busNumberText.Lines = new string[0];
            this.busNumberText.Location = new System.Drawing.Point(590, 64);
            this.busNumberText.MaxLength = 32767;
            this.busNumberText.MinimumSize = new System.Drawing.Size(100, 35);
            this.busNumberText.Modified = false;
            this.busNumberText.Multiline = false;
            this.busNumberText.Name = "busNumberText";
            stateProperties7.BorderColor = System.Drawing.Color.Transparent;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.busNumberText.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.busNumberText.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.busNumberText.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Transparent;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.busNumberText.OnIdleState = stateProperties10;
            this.busNumberText.PasswordChar = '\0';
            this.busNumberText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
            this.busNumberText.PlaceholderText = "";
            this.busNumberText.ReadOnly = false;
            this.busNumberText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busNumberText.SelectedText = "";
            this.busNumberText.SelectionLength = 0;
            this.busNumberText.SelectionStart = 0;
            this.busNumberText.ShortcutsEnabled = true;
            this.busNumberText.Size = new System.Drawing.Size(165, 35);
            this.busNumberText.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.busNumberText.TabIndex = 7;
            this.busNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.busNumberText.TextMarginBottom = 0;
            this.busNumberText.TextMarginLeft = 5;
            this.busNumberText.TextMarginTop = 0;
            this.busNumberText.TextPlaceholder = "";
            this.busNumberText.UseSystemPasswordChar = false;
            this.busNumberText.WordWrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label7.Location = new System.Drawing.Point(587, 34);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bus Number";
            // 
            // tripGrid
            // 
            this.tripGrid.AllowCustomTheming = true;
            this.tripGrid.AllowUserToAddRows = false;
            this.tripGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tripGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tripGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tripGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.tripGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tripGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tripGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tripGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tripGrid.ColumnHeadersHeight = 60;
            this.tripGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.editColumn,
            this.deleteColumn});
            this.tripGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.tripGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tripGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tripGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.tripGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tripGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.tripGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.tripGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.tripGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tripGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tripGrid.CurrentTheme.Name = null;
            this.tripGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.tripGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.tripGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.tripGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tripGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tripGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.tripGrid.EnableHeadersVisualStyles = false;
            this.tripGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.tripGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.tripGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.tripGrid.HeaderForeColor = System.Drawing.Color.White;
            this.tripGrid.Location = new System.Drawing.Point(41, 160);
            this.tripGrid.MultiSelect = false;
            this.tripGrid.Name = "tripGrid";
            this.tripGrid.ReadOnly = true;
            this.tripGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tripGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.tripGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tripGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.tripGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.tripGrid.RowTemplate.DividerHeight = 10;
            this.tripGrid.RowTemplate.Height = 60;
            this.tripGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tripGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tripGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tripGrid.ShowEditingIcon = false;
            this.tripGrid.Size = new System.Drawing.Size(898, 435);
            this.tripGrid.TabIndex = 16;
            this.tripGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.tripGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tripGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "DESTINATION";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DEPART. TIME";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "DEPART. DATE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "BUS NUMBER";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // editColumn
            // 
            this.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editColumn.HeaderText = "";
            this.editColumn.Image = ((System.Drawing.Image)(resources.GetObject("editColumn.Image")));
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 50;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumn.Image")));
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Width = 50;
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = false;
            this.searchBox.AcceptsTab = false;
            this.searchBox.AnimationSpeed = 200;
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchBox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBox.BackgroundImage")));
            this.searchBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchBox.BorderColorIdle = System.Drawing.Color.Transparent;
            this.searchBox.BorderRadius = 12;
            this.searchBox.BorderThickness = 0;
            this.searchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultFont = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.searchBox.DefaultText = "";
            this.searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.HideSelection = true;
            this.searchBox.IconLeft = null;
            this.searchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.IconPadding = 10;
            this.searchBox.IconRight = null;
            this.searchBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(38, 119);
            this.searchBox.MaxLength = 32767;
            this.searchBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.searchBox.Modified = false;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnIdleState = stateProperties4;
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
            this.searchBox.PlaceholderText = "Search by Bus Number...";
            this.searchBox.ReadOnly = false;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(215, 35);
            this.searchBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.searchBox.TabIndex = 15;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 5;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search by Bus Number...";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            this.searchBox.TextChange += new System.EventHandler(this.searchBox_TextChange);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(269, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 35);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSearch.TabIndex = 17;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.searchBox_TextChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(921, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 435);
            this.panel1.TabIndex = 18;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Available_Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.departDatePicker);
            this.Controls.Add(this.departTimePicker);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.busNumberText);
            this.Controls.Add(this.tripGrid);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Available_Trip";
            this.Size = new System.Drawing.Size(977, 626);
            this.Load += new System.EventHandler(this.Available_Trip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddTrip;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox destinationComboBox;
        private System.Windows.Forms.DateTimePicker departTimePicker;
        private System.Windows.Forms.DateTimePicker departDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox busNumberText;
        private Bunifu.UI.WinForms.BunifuDataGridView tripGrid;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchBox;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn editColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
