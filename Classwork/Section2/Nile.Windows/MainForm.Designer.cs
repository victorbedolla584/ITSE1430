namespace Nile.Windows
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miProductEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._miProductAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._miProductRemove = new System.Windows.Forms.ToolStripMenuItem();
            this._miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit,
            this.pRODUCTToolStripMenuItem,
            this._miHelpAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(511, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip2";
            // 
            // _miFileExit
            // 
            this._miFileExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miExit});
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(40, 20);
            this._miFileExit.Text = "&FILE";
            // 
            // pRODUCTToolStripMenuItem
            // 
            this.pRODUCTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miProductAdd,
            this._miProductEdit,
            this.toolStripSeparator1,
            this._miProductRemove});
            this.pRODUCTToolStripMenuItem.Name = "pRODUCTToolStripMenuItem";
            this.pRODUCTToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.pRODUCTToolStripMenuItem.Text = "&PRODUCT";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miHelpAbout.Size = new System.Drawing.Size(47, 20);
            this._miHelpAbout.Text = "&HELP";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // _miProductEdit
            // 
            this._miProductEdit.Name = "_miProductEdit";
            this._miProductEdit.Size = new System.Drawing.Size(152, 22);
            this._miProductEdit.Text = "Edit";
            this._miProductEdit.Click += new System.EventHandler(this._miProductEdit_Click);
            // 
            // _miProductAdd
            // 
            this._miProductAdd.Name = "_miProductAdd";
            this._miProductAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._miProductAdd.Size = new System.Drawing.Size(152, 22);
            this._miProductAdd.Text = "Add";
            this._miProductAdd.Click += new System.EventHandler(this._miProductAdd_Click);
            // 
            // _miProductRemove
            // 
            this._miProductRemove.Name = "_miProductRemove";
            this._miProductRemove.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miProductRemove.Size = new System.Drawing.Size(152, 22);
            this._miProductRemove.Text = "Remove";
            this._miProductRemove.Click += new System.EventHandler(this._miProductRemove_Click);
            // 
            // _miExit
            // 
            this._miExit.Name = "_miExit";
            this._miExit.Size = new System.Drawing.Size(152, 22);
            this._miExit.Text = "Exit";
            this._miExit.Click += new System.EventHandler(this._miExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 478);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nile";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miProductEdit;
        private System.Windows.Forms.ToolStripMenuItem _miProductAdd;
        private System.Windows.Forms.ToolStripMenuItem _miProductRemove;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

