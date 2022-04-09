namespace BusTicketManagementSystem.User_Controls
{
    partial class Reservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.reservationGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_print = new System.Windows.Forms.DataGridViewImageColumn();
            this.ticket_cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.searchBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // reservationGrid
            // 
            this.reservationGrid.AllowCustomTheming = true;
            this.reservationGrid.AllowUserToAddRows = false;
            this.reservationGrid.AllowUserToDeleteRows = false;
            this.reservationGrid.AllowUserToResizeColumns = false;
            this.reservationGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.reservationGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reservationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservationGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservationGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservationGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reservationGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reservationGrid.ColumnHeadersHeight = 60;
            this.reservationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column7,
            this.Column8,
            this.ticket_print,
            this.ticket_cancel});
            this.reservationGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.reservationGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.reservationGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.reservationGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.reservationGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.reservationGrid.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservationGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservationGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservationGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.reservationGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reservationGrid.CurrentTheme.Name = null;
            this.reservationGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.reservationGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.reservationGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.reservationGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.reservationGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.reservationGrid.EnableHeadersVisualStyles = false;
            this.reservationGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservationGrid.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.reservationGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.reservationGrid.HeaderForeColor = System.Drawing.Color.White;
            this.reservationGrid.Location = new System.Drawing.Point(18, 77);
            this.reservationGrid.MultiSelect = false;
            this.reservationGrid.Name = "reservationGrid";
            this.reservationGrid.ReadOnly = true;
            this.reservationGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reservationGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.reservationGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reservationGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.reservationGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.reservationGrid.RowTemplate.DividerHeight = 10;
            this.reservationGrid.RowTemplate.Height = 60;
            this.reservationGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reservationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationGrid.ShowEditingIcon = false;
            this.reservationGrid.Size = new System.Drawing.Size(941, 523);
            this.reservationGrid.TabIndex = 17;
            this.reservationGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.reservationGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationGrid_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ticket Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Phone Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Purchased On";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Reserved Seats";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bus Number";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // ticket_print
            // 
            this.ticket_print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ticket_print.HeaderText = "";
            this.ticket_print.Image = ((System.Drawing.Image)(resources.GetObject("ticket_print.Image")));
            this.ticket_print.MinimumWidth = 50;
            this.ticket_print.Name = "ticket_print";
            this.ticket_print.ReadOnly = true;
            this.ticket_print.Width = 50;
            // 
            // ticket_cancel
            // 
            this.ticket_cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ticket_cancel.HeaderText = "";
            this.ticket_cancel.Image = ((System.Drawing.Image)(resources.GetObject("ticket_cancel.Image")));
            this.ticket_cancel.MinimumWidth = 80;
            this.ticket_cancel.Name = "ticket_cancel";
            this.ticket_cancel.ReadOnly = true;
            this.ticket_cancel.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.panel1.Location = new System.Drawing.Point(939, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 523);
            this.panel1.TabIndex = 19;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.reservationGrid;
            this.bunifuDragControl2.Vertical = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(248, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 35);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSearch.TabIndex = 21;
            this.btnSearch.TabStop = false;
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
            this.searchBox.Location = new System.Drawing.Point(18, 32);
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
            this.searchBox.PlaceholderText = "Search by Ticket Number...";
            this.searchBox.ReadOnly = false;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(215, 35);
            this.searchBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.searchBox.TabIndex = 20;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.TextMarginBottom = 0;
            this.searchBox.TextMarginLeft = 5;
            this.searchBox.TextMarginTop = 0;
            this.searchBox.TextPlaceholder = "Search by Ticket Number...";
            this.searchBox.UseSystemPasswordChar = false;
            this.searchBox.WordWrap = true;
            this.searchBox.TextChange += new System.EventHandler(this.searchBoxEvenet);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reservationGrid);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Reservations";
            this.Size = new System.Drawing.Size(977, 626);
            this.Load += new System.EventHandler(this.Reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView reservationGrid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn ticket_print;
        private System.Windows.Forms.DataGridViewImageColumn ticket_cancel;
        private System.Windows.Forms.PictureBox btnSearch;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchBox;
    }
}
