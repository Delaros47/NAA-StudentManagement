﻿namespace StudentManagementUI.Forms.CityForms
{
    partial class CityListForm
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
            this.gridControlCities = new StudentManagementUI.UserControls.Grids.MyGridControl();
            this.gridViewCities = new StudentManagementUI.UserControls.Grids.MyGridView();
            this.colId = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colPrivateCode = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colCityName = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            this.colDescription = new StudentManagementUI.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCities)).BeginInit();
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
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 351);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(1190, 24);
            this.longNavigator.TabIndex = 2;
            // 
            // gridControlCities
            // 
            this.gridControlCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCities.Location = new System.Drawing.Point(0, 109);
            this.gridControlCities.MainView = this.gridViewCities;
            this.gridControlCities.MenuManager = this.ribbonControl;
            this.gridControlCities.Name = "gridControlCities";
            this.gridControlCities.Size = new System.Drawing.Size(1190, 242);
            this.gridControlCities.TabIndex = 3;
            this.gridControlCities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCities});
            // 
            // gridViewCities
            // 
            this.gridViewCities.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridViewCities.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCities.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCities.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewCities.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCities.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCities.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCities.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCities.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.gridViewCities.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridViewCities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colPrivateCode,
            this.colCityName,
            this.colDescription});
            this.gridViewCities.GridControl = this.gridControlCities;
            this.gridViewCities.Name = "gridViewCities";
            this.gridViewCities.OptionsMenu.EnableColumnMenu = false;
            this.gridViewCities.OptionsMenu.EnableFooterMenu = false;
            this.gridViewCities.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewCities.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewCities.OptionsPrint.AutoWidth = false;
            this.gridViewCities.OptionsPrint.PrintFooter = false;
            this.gridViewCities.OptionsPrint.PrintGroupFooter = false;
            this.gridViewCities.OptionsView.ColumnAutoWidth = false;
            this.gridViewCities.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridViewCities.OptionsView.RowAutoHeight = true;
            this.gridViewCities.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCities.OptionsView.ShowGroupPanel = false;
            this.gridViewCities.OptionsView.ShowViewCaption = true;
            this.gridViewCities.StatusBarDescription = null;
            this.gridViewCities.StatusBarShortcut = null;
            this.gridViewCities.StatusBarShortcutDescription = null;
            this.gridViewCities.ViewCaption = "Cities";
            this.gridViewCities.DoubleClick += new System.EventHandler(this.gridViewCities_DoubleClick);
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
            this.colCityName.VisibleIndex = 1;
            this.colCityName.Width = 150;
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
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 400;
            // 
            // CityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 399);
            this.Controls.Add(this.gridControlCities);
            this.Controls.Add(this.longNavigator);
            this.IconOptions.ShowIcon = false;
            this.Name = "CityListForm";
            this.Text = "City List";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.gridControlCities, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridControl gridControlCities;
        private UserControls.Grids.MyGridView gridViewCities;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colPrivateCode;
        private UserControls.Grids.MyGridColumn colCityName;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}