namespace StudentManagementUI.Forms.CityForms
{
    partial class CityEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new StudentManagementUI.UserControls.Controls.MyDataLayoutControl();
            this.txtDescription = new StudentManagementUI.UserControls.Controls.MyMemoEdit();
            this.txtCityName = new StudentManagementUI.UserControls.Controls.MyTextEdit();
            this.tglState = new StudentManagementUI.UserControls.Controls.MyToggleSwitch();
            this.txtPrivateCode = new StudentManagementUI.UserControls.Controls.MyPrivateCodeTextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            // 
            // 
            // 
            this.ribbonControl.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl.SearchEditItem.EditWidth = 150;
            this.ribbonControl.SearchEditItem.Id = -5000;
            this.ribbonControl.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl.Size = new System.Drawing.Size(373, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.txtDescription);
            this.myDataLayoutControl.Controls.Add(this.txtCityName);
            this.myDataLayoutControl.Controls.Add(this.tglState);
            this.myDataLayoutControl.Controls.Add(this.txtPrivateCode);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 109);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.Root;
            this.myDataLayoutControl.Size = new System.Drawing.Size(373, 136);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(86, 60);
            this.txtDescription.MenuManager = this.ribbonControl;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Properties.MaxLength = 500;
            this.txtDescription.Size = new System.Drawing.Size(275, 64);
            this.txtDescription.StatusBarDescription = "Enter the Description.";
            this.txtDescription.StyleController = this.myDataLayoutControl;
            this.txtDescription.TabIndex = 7;
            // 
            // txtCityName
            // 
            this.txtCityName.EnterMoveNextControl = true;
            this.txtCityName.Location = new System.Drawing.Point(86, 36);
            this.txtCityName.MenuManager = this.ribbonControl;
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCityName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCityName.Properties.MaxLength = 50;
            this.txtCityName.Size = new System.Drawing.Size(132, 20);
            this.txtCityName.StatusBarDescription = null;
            this.txtCityName.StyleController = this.myDataLayoutControl;
            this.txtCityName.TabIndex = 6;
            // 
            // tglState
            // 
            this.tglState.EditValue = true;
            this.tglState.EnterMoveNextControl = true;
            this.tglState.Location = new System.Drawing.Point(273, 12);
            this.tglState.MenuManager = this.ribbonControl;
            this.tglState.Name = "tglState";
            this.tglState.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tglState.Properties.Appearance.Options.UseForeColor = true;
            this.tglState.Properties.AutoHeight = false;
            this.tglState.Properties.AutoWidth = true;
            this.tglState.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tglState.Properties.OffText = "Passive";
            this.tglState.Properties.OnText = "Active";
            this.tglState.Size = new System.Drawing.Size(89, 20);
            this.tglState.StatusBarDescription = "Choose the state of your form";
            this.tglState.StyleController = this.myDataLayoutControl;
            this.tglState.TabIndex = 5;
            // 
            // txtPrivateCode
            // 
            this.txtPrivateCode.EnterMoveNextControl = true;
            this.txtPrivateCode.Location = new System.Drawing.Point(86, 12);
            this.txtPrivateCode.MenuManager = this.ribbonControl;
            this.txtPrivateCode.Name = "txtPrivateCode";
            this.txtPrivateCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtPrivateCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtPrivateCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPrivateCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPrivateCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtPrivateCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPrivateCode.Properties.MaxLength = 35;
            this.txtPrivateCode.Size = new System.Drawing.Size(132, 20);
            this.txtPrivateCode.StatusBarDescription = "Enter the Private Code.";
            this.txtPrivateCode.StyleController = this.myDataLayoutControl;
            this.txtPrivateCode.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition4.Width = 210D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 100D;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition6.Width = 92D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition4,
            columnDefinition5,
            columnDefinition6});
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 24D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 100D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.Root.Size = new System.Drawing.Size(373, 136);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txtPrivateCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem1.Text = "Private Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.tglState;
            this.layoutControlItem2.Location = new System.Drawing.Point(261, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(92, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txtCityName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem3.Text = "City Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtDescription;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnSpan = 3;
            this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem4.Size = new System.Drawing.Size(353, 68);
            this.layoutControlItem4.Text = "Description";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(62, 13);
            // 
            // CityEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 269);
            this.Controls.Add(this.myDataLayoutControl);
            this.IconOptions.ShowIcon = false;
            this.Name = "CityEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "City Edit";
            this.Load += new System.EventHandler(this.CityEditForm_Load);
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tglState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrivateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private UserControls.Controls.MyMemoEdit txtDescription;
        private UserControls.Controls.MyTextEdit txtCityName;
        private UserControls.Controls.MyToggleSwitch tglState;
        private UserControls.Controls.MyPrivateCodeTextEdit txtPrivateCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}