namespace StudentManagementUI.UserControls.Navigators
{
    partial class AddDelNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDelNavigator));
            this.controlNavigator = new DevExpress.XtraEditors.ControlNavigator();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // controlNavigator
            // 
            this.controlNavigator.Buttons.Append.ImageIndex = 0;
            this.controlNavigator.Buttons.CancelEdit.Visible = false;
            this.controlNavigator.Buttons.Edit.Visible = false;
            this.controlNavigator.Buttons.EndEdit.Visible = false;
            this.controlNavigator.Buttons.First.ImageIndex = 2;
            this.controlNavigator.Buttons.ImageList = this.imageCollection;
            this.controlNavigator.Buttons.Last.ImageIndex = 3;
            this.controlNavigator.Buttons.Next.ImageIndex = 4;
            this.controlNavigator.Buttons.NextPage.Visible = false;
            this.controlNavigator.Buttons.Prev.ImageIndex = 5;
            this.controlNavigator.Buttons.PrevPage.Visible = false;
            this.controlNavigator.Buttons.Remove.ImageIndex = 1;
            this.controlNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator.Location = new System.Drawing.Point(0, 0);
            this.controlNavigator.Name = "controlNavigator";
            this.controlNavigator.Size = new System.Drawing.Size(700, 24);
            this.controlNavigator.TabIndex = 0;
            this.controlNavigator.Text = "controlNavigator1";
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "addfile_16x16.png");
            this.imageCollection.Images.SetKeyName(1, "deletelist_16x16.png");
            this.imageCollection.Images.SetKeyName(2, "first_16x16.png");
            this.imageCollection.Images.SetKeyName(3, "last_16x16.png");
            this.imageCollection.Images.SetKeyName(4, "next_16x16.png");
            this.imageCollection.Images.SetKeyName(5, "prev_16x16.png");
            // 
            // AddDelNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlNavigator);
            this.Name = "AddDelNavigator";
            this.Size = new System.Drawing.Size(700, 24);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator;
        private DevExpress.Utils.ImageCollection imageCollection;
    }
}
