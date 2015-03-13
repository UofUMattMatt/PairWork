namespace GitHubBrowser
{
    partial class GitHubBrowser
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchResults = new System.Windows.Forms.ListView();
            this.repName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repAvatar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prev_b = new System.Windows.Forms.Button();
            this.nxt_b = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(815, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // searchResults
            // 
            this.searchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.repAvatar,
            this.repName,
            this.repOwner,
            this.repDescription});
            this.searchResults.Location = new System.Drawing.Point(12, 55);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(791, 304);
            this.searchResults.TabIndex = 3;
            this.searchResults.UseCompatibleStateImageBehavior = false;
            this.searchResults.View = System.Windows.Forms.View.Details;
            // 
            // repName
            // 
            this.repName.Text = "Repository";
            this.repName.Width = 100;
            // 
            // repOwner
            // 
            this.repOwner.Text = "Owner";
            this.repOwner.Width = 120;
            // 
            // repAvatar
            // 
            this.repAvatar.Text = "Avatar";
            this.repAvatar.Width = 80;
            // 
            // repDescription
            // 
            this.repDescription.Text = "Description";
            this.repDescription.Width = 500;
            // 
            // prev_b
            // 
            this.prev_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prev_b.Location = new System.Drawing.Point(12, 361);
            this.prev_b.Name = "prev_b";
            this.prev_b.Size = new System.Drawing.Size(59, 23);
            this.prev_b.TabIndex = 4;
            this.prev_b.Text = "Previous";
            this.prev_b.UseVisualStyleBackColor = true;
            // 
            // nxt_b
            // 
            this.nxt_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nxt_b.Location = new System.Drawing.Point(77, 361);
            this.nxt_b.Name = "nxt_b";
            this.nxt_b.Size = new System.Drawing.Size(59, 23);
            this.nxt_b.TabIndex = 5;
            this.nxt_b.Text = "Next";
            this.nxt_b.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Items.AddRange(new object[] {
            "Profile Info",
            "Language",
            "Rating"});
            this.searchBox.Location = new System.Drawing.Point(12, 27);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(541, 21);
            this.searchBox.TabIndex = 6;
            // 
            // GitHubBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 387);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.nxt_b);
            this.Controls.Add(this.prev_b);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "GitHubBrowser";
            this.Text = "GitHub Browser";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView searchResults;
        private System.Windows.Forms.ColumnHeader repAvatar;
        private System.Windows.Forms.ColumnHeader repName;
        private System.Windows.Forms.ColumnHeader repOwner;
        private System.Windows.Forms.ColumnHeader repDescription;
        private System.Windows.Forms.Button prev_b;
        private System.Windows.Forms.Button nxt_b;
        private System.Windows.Forms.ComboBox searchBox;
    }
}

