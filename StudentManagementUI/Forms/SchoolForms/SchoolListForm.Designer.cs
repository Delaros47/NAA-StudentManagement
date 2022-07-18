namespace StudentManagementUI.Forms.SchoolForms
{
    partial class SchoolListForm
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
            this.longNavigator = new StudentManagementUI.UserControls.Navigators.LongNavigator();
            this.gridControlSchools = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewSchools = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colSchoolName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colCityName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDistrictName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchools)).BeginInit();
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
            this.ribbonControl.Size = new System.Drawing.Size(1198, 109);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 351);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1198, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // gridControlSchools
            // 
            this.gridControlSchools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSchools.Location = new System.Drawing.Point(0, 109);
            this.gridControlSchools.MainView = this.gridViewSchools;
            this.gridControlSchools.MenuManager = this.ribbonControl;
            this.gridControlSchools.Name = "gridControlSchools";
            this.gridControlSchools.Size = new System.Drawing.Size(1198, 242);
            this.gridControlSchools.TabIndex = 3;
            this.gridControlSchools.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSchools});
            // 
            // gridViewSchools
            // 
            this.gridViewSchools.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewSchools.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchools.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewSchools.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewSchools.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchools.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSchools.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewSchools.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewSchools.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewSchools.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewSchools.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colSchoolName,
            this.colCityName,
            this.colDistrictName,
            this.colDescription});
            this.gridViewSchools.GridControl = this.gridControlSchools;
            this.gridViewSchools.Name = "gridViewSchools";
            this.gridViewSchools.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSchools.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSchools.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSchools.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewSchools.OptionsPrint.AutoWidth = false;
            this.gridViewSchools.OptionsPrint.PrintFooter = false;
            this.gridViewSchools.OptionsPrint.PrintGroupFooter = false;
            this.gridViewSchools.OptionsView.ColumnAutoWidth = false;
            this.gridViewSchools.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewSchools.OptionsView.RowAutoHeight = true;
            this.gridViewSchools.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSchools.OptionsView.ShowGroupPanel = false;
            this.gridViewSchools.OptionsView.ShowViewCaption = true;
            this.gridViewSchools.StatusBarDescription = null;
            this.gridViewSchools.StatusBarShortcut = null;
            this.gridViewSchools.StatusBarShortcutDescription = null;
            this.gridViewSchools.ViewCaption = "Schools";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarDescription = null;
            this.colId.StatusBarShortcut = null;
            this.colId.StatusBarShortcutDescription = null;
            // 
            // colPrivateCode
            // 
            this.colPrivateCode.AppearanceCell.Options.UseTextOptions = true;
            this.colPrivateCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrivateCode.Caption = "Private Code";
            this.colPrivateCode.FieldName = "PrivateCode";
            this.colPrivateCode.Name = "colPrivateCode";
            this.colPrivateCode.OptionsColumn.AllowEdit = false;
            this.colPrivateCode.StatusBarDescription = null;
            this.colPrivateCode.StatusBarShortcut = null;
            this.colPrivateCode.StatusBarShortcutDescription = null;
            this.colPrivateCode.Visible = true;
            this.colPrivateCode.VisibleIndex = 0;
            this.colPrivateCode.Width = 150;
            // 
            // colSchoolName
            // 
            this.colSchoolName.Caption = "School Name";
            this.colSchoolName.FieldName = "SchoolName";
            this.colSchoolName.Name = "colSchoolName";
            this.colSchoolName.OptionsColumn.AllowEdit = false;
            this.colSchoolName.StatusBarDescription = null;
            this.colSchoolName.StatusBarShortcut = null;
            this.colSchoolName.StatusBarShortcutDescription = null;
            this.colSchoolName.Visible = true;
            this.colSchoolName.VisibleIndex = 1;
            this.colSchoolName.Width = 300;
            // 
            // colCityName
            // 
            this.colCityName.Caption = "City Name";
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.OptionsColumn.AllowEdit = false;
            this.colCityName.StatusBarDescription = null;
            this.colCityName.StatusBarShortcut = null;
            this.colCityName.StatusBarShortcutDescription = null;
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 2;
            this.colCityName.Width = 130;
            // 
            // colDistrictName
            // 
            this.colDistrictName.Caption = "District Name";
            this.colDistrictName.FieldName = "DistrictName";
            this.colDistrictName.Name = "colDistrictName";
            this.colDistrictName.OptionsColumn.AllowEdit = false;
            this.colDistrictName.StatusBarDescription = null;
            this.colDistrictName.StatusBarShortcut = null;
            this.colDistrictName.StatusBarShortcutDescription = null;
            this.colDistrictName.Visible = true;
            this.colDistrictName.VisibleIndex = 3;
            this.colDistrictName.Width = 130;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.StatusBarDescription = null;
            this.colDescription.StatusBarShortcut = null;
            this.colDescription.StatusBarShortcutDescription = null;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 400;
            // 
            // SchoolListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 399);
            this.Controls.Add(this.gridControlSchools);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "SchoolListForm";
            this.Text = "School List";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlSchools, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSchools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlSchools;
        private UserControls.Grids.MyGridView gridViewSchools;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colSchoolName;
        private UserControls.Grids.MyGridColumn colCityName;
        private UserControls.Grids.MyGridColumn colDistrictName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}