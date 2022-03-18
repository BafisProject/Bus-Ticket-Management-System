namespace BusTicketManagementSystem.User_Controls
{
    partial class Bus_Info
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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bus_Info));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.busNumberTextBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.busClassComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.busStatusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBus = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.busInfoGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.busInfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // busNumberTextBox
            // 
            this.busNumberTextBox.AcceptsReturn = false;
            this.busNumberTextBox.AcceptsTab = false;
            this.busNumberTextBox.AnimationSpeed = 200;
            this.busNumberTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.busNumberTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.busNumberTextBox.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.busNumberTextBox.BackColor = System.Drawing.Color.Transparent;
            this.busNumberTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("busNumberTextBox.BackgroundImage")));
            this.busNumberTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.busNumberTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.busNumberTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.busNumberTextBox.BorderColorIdle = System.Drawing.Color.Transparent;
            this.busNumberTextBox.BorderRadius = 12;
            this.busNumberTextBox.BorderThickness = 0;
            this.busNumberTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.busNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.busNumberTextBox.DefaultFont = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busNumberTextBox.DefaultText = "";
            this.busNumberTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.busNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.busNumberTextBox.HideSelection = true;
            this.busNumberTextBox.IconLeft = null;
            this.busNumberTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.busNumberTextBox.IconPadding = 10;
            this.busNumberTextBox.IconRight = null;
            this.busNumberTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.busNumberTextBox.Lines = new string[0];
            this.busNumberTextBox.Location = new System.Drawing.Point(128, 55);
            this.busNumberTextBox.MaxLength = 32767;
            this.busNumberTextBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.busNumberTextBox.Modified = false;
            this.busNumberTextBox.Multiline = false;
            this.busNumberTextBox.Name = "busNumberTextBox";
            stateProperties7.BorderColor = System.Drawing.Color.Transparent;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.busNumberTextBox.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.busNumberTextBox.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.busNumberTextBox.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Transparent;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            stateProperties10.ForeColor = System.Drawing.Color.White;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.busNumberTextBox.OnIdleState = stateProperties10;
            this.busNumberTextBox.PasswordChar = '\0';
            this.busNumberTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(145)))));
            this.busNumberTextBox.PlaceholderText = "";
            this.busNumberTextBox.ReadOnly = false;
            this.busNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.busNumberTextBox.SelectedText = "";
            this.busNumberTextBox.SelectionLength = 0;
            this.busNumberTextBox.SelectionStart = 0;
            this.busNumberTextBox.ShortcutsEnabled = true;
            this.busNumberTextBox.Size = new System.Drawing.Size(165, 35);
            this.busNumberTextBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.busNumberTextBox.TabIndex = 1;
            this.busNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.busNumberTextBox.TextMarginBottom = 0;
            this.busNumberTextBox.TextMarginLeft = 5;
            this.busNumberTextBox.TextMarginTop = 0;
            this.busNumberTextBox.TextPlaceholder = "";
            this.busNumberTextBox.UseSystemPasswordChar = false;
            this.busNumberTextBox.WordWrap = true;
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
            this.busClassComboBox.Location = new System.Drawing.Point(314, 55);
            this.busClassComboBox.Name = "busClassComboBox";
            this.busClassComboBox.ShadowDecoration.Parent = this.busClassComboBox;
            this.busClassComboBox.Size = new System.Drawing.Size(165, 36);
            this.busClassComboBox.TabIndex = 2;
            this.busClassComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(125, 25);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bus Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bus Class";
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
            this.busStatusComboBox.Location = new System.Drawing.Point(500, 55);
            this.busStatusComboBox.Name = "busStatusComboBox";
            this.busStatusComboBox.ShadowDecoration.Parent = this.busStatusComboBox;
            this.busStatusComboBox.Size = new System.Drawing.Size(165, 36);
            this.busStatusComboBox.TabIndex = 2;
            this.busStatusComboBox.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(497, 25);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bus Status";
            // 
            // btnAddBus
            // 
            this.btnAddBus.AllowToggling = false;
            this.btnAddBus.AnimationSpeed = 200;
            this.btnAddBus.AutoGenerateColors = false;
            this.btnAddBus.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBus.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAddBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBus.BackgroundImage")));
            this.btnAddBus.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddBus.ButtonText = "Add Bus";
            this.btnAddBus.ButtonTextMarginLeft = 0;
            this.btnAddBus.ColorContrastOnClick = 45;
            this.btnAddBus.ColorContrastOnHover = 45;
            this.btnAddBus.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddBus.CustomizableEdges = borderEdges1;
            this.btnAddBus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBus.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnAddBus.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddBus.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddBus.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddBus.Font = new System.Drawing.Font("Montserrat SemiBold", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBus.IconMarginLeft = 11;
            this.btnAddBus.IconPadding = 10;
            this.btnAddBus.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBus.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAddBus.IdleBorderRadius = 10;
            this.btnAddBus.IdleBorderThickness = 1;
            this.btnAddBus.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnAddBus.IdleIconLeftImage = null;
            this.btnAddBus.IdleIconRightImage = null;
            this.btnAddBus.IndicateFocus = false;
            this.btnAddBus.Location = new System.Drawing.Point(686, 55);
            this.btnAddBus.Name = "btnAddBus";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddBus.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 10;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddBus.OnPressedState = stateProperties2;
            this.btnAddBus.Size = new System.Drawing.Size(165, 36);
            this.btnAddBus.TabIndex = 6;
            this.btnAddBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddBus.TextMarginLeft = 0;
            this.btnAddBus.UseDefaultRadiusAndThickness = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // busInfoGrid
            // 
            this.busInfoGrid.AllowCustomTheming = true;
            this.busInfoGrid.AllowUserToAddRows = false;
            this.busInfoGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.busInfoGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.busInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.busInfoGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.busInfoGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busInfoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.busInfoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.busInfoGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.busInfoGrid.ColumnHeadersHeight = 60;
            this.busInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.editColumn,
            this.deleteColumn});
            this.busInfoGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.busInfoGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.busInfoGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.busInfoGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.busInfoGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.busInfoGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.busInfoGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.busInfoGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.busInfoGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.busInfoGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.busInfoGrid.CurrentTheme.Name = null;
            this.busInfoGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.busInfoGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busInfoGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.busInfoGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.busInfoGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.busInfoGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.busInfoGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.busInfoGrid.EnableHeadersVisualStyles = false;
            this.busInfoGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.busInfoGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.busInfoGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.busInfoGrid.HeaderForeColor = System.Drawing.Color.White;
            this.busInfoGrid.Location = new System.Drawing.Point(128, 159);
            this.busInfoGrid.MultiSelect = false;
            this.busInfoGrid.Name = "busInfoGrid";
            this.busInfoGrid.ReadOnly = true;
            this.busInfoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.busInfoGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.busInfoGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.busInfoGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.busInfoGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.busInfoGrid.RowTemplate.DividerHeight = 10;
            this.busInfoGrid.RowTemplate.Height = 60;
            this.busInfoGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.busInfoGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.busInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.busInfoGrid.ShowEditingIcon = false;
            this.busInfoGrid.Size = new System.Drawing.Size(723, 435);
            this.busInfoGrid.TabIndex = 7;
            this.busInfoGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.busInfoGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busInfoGrid_CellClick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(834, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 435);
            this.panel1.TabIndex = 8;
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
            this.searchBox.Location = new System.Drawing.Point(128, 118);
            this.searchBox.MaxLength = 32767;
            this.searchBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.searchBox.Modified = false;
            this.searchBox.Multiline = false;
            this.searchBox.Name = "searchBox";
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnActiveState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Empty;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchBox.OnDisabledState = stateProperties4;
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Transparent;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchBox.OnIdleState = stateProperties6;
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
            this.searchBox.TabIndex = 1;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 5;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search by Bus Number...";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            this.searchBox.TextChange += new System.EventHandler(this.searchBoxEvenet);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(358, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 35);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.searchBoxEvenet);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "bus_number";
            this.Column2.FillWeight = 89.54315F;
            this.Column2.HeaderText = "BUS NUMBER";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "bus_class";
            this.Column3.FillWeight = 89.54315F;
            this.Column3.HeaderText = "BUS CLASS";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "bus_status";
            this.Column4.FillWeight = 89.54315F;
            this.Column4.HeaderText = "BUS STATUS";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // editColumn
            // 
            this.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editColumn.FillWeight = 152.2843F;
            this.editColumn.HeaderText = "";
            this.editColumn.Image = ((System.Drawing.Image)(resources.GetObject("editColumn.Image")));
            this.editColumn.MinimumWidth = 50;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editColumn.Width = 50;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteColumn.FillWeight = 89.54315F;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Image = ((System.Drawing.Image)(resources.GetObject("deleteColumn.Image")));
            this.deleteColumn.MinimumWidth = 50;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteColumn.Width = 50;
            // 
            // Bus_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.busInfoGrid);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.busStatusComboBox);
            this.Controls.Add(this.busClassComboBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.busNumberTextBox);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Bus_Info";
            this.Size = new System.Drawing.Size(977, 626);
            this.Load += new System.EventHandler(this.Bus_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busInfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox busNumberTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox busClassComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox busStatusComboBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddBus;
        private Bunifu.UI.WinForms.BunifuDataGridView busInfoGrid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchBox;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn editColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
    }
}
