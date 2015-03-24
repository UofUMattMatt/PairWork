﻿namespace GitHubBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GitHubBrowser));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchResults = new System.Windows.Forms.ListView();
            this.repName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prev_b = new System.Windows.Forms.Button();
            this.nxt_b = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.repo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.langs = new System.Windows.Forms.Label();
            this.bytes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repolabel = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(717, 24);
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
            this.repName,
            this.repOwner,
            this.repDescription});
            this.searchResults.Location = new System.Drawing.Point(12, 55);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(463, 306);
            this.searchResults.TabIndex = 3;
            this.searchResults.UseCompatibleStateImageBehavior = false;
            this.searchResults.View = System.Windows.Forms.View.Details;
            this.searchResults.SelectedIndexChanged += new System.EventHandler(this.searchResults_SelectedIndexChanged);
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
            // repDescription
            // 
            this.repDescription.Text = "Description";
            this.repDescription.Width = 500;
            // 
            // prev_b
            // 
            this.prev_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prev_b.Location = new System.Drawing.Point(12, 367);
            this.prev_b.Name = "prev_b";
            this.prev_b.Size = new System.Drawing.Size(59, 23);
            this.prev_b.TabIndex = 4;
            this.prev_b.Text = "Previous";
            this.prev_b.UseVisualStyleBackColor = true;
            this.prev_b.Click += new System.EventHandler(this.prev_b_Click);
            // 
            // nxt_b
            // 
            this.nxt_b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nxt_b.Location = new System.Drawing.Point(77, 367);
            this.nxt_b.Name = "nxt_b";
            this.nxt_b.Size = new System.Drawing.Size(59, 23);
            this.nxt_b.TabIndex = 5;
            this.nxt_b.Text = "Next";
            this.nxt_b.UseVisualStyleBackColor = true;
            this.nxt_b.Click += new System.EventHandler(this.nxt_b_Click);
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Items.AddRange(new object[] {
            "Profile Info",
            "Language",
            "Rating"});
            this.searchBox.Location = new System.Drawing.Point(224, 27);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(78, 21);
            this.searchBox.TabIndex = 6;
            this.searchBox.SelectedIndexChanged += new System.EventHandler(this.searchBox_SelectedIndexChanged);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(12, 27);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(206, 20);
            this.searchText.TabIndex = 7;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(386, 26);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(72, 20);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar.Location = new System.Drawing.Point(481, 55);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(92, 96);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 10;
            this.avatar.TabStop = false;
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Freestyle Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(579, 55);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 32);
            this.username.TabIndex = 11;
            // 
            // repo
            // 
            this.repo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repo.AutoSize = true;
            this.repo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repo.Location = new System.Drawing.Point(491, 185);
            this.repo.Name = "repo";
            this.repo.Size = new System.Drawing.Size(80, 17);
            this.repo.TabIndex = 12;
            this.repo.Text = "Repository:";
            this.repo.Click += new System.EventHandler(this.repo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Languages";
            // 
            // langs
            // 
            this.langs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.langs.AutoSize = true;
            this.langs.Location = new System.Drawing.Point(521, 266);
            this.langs.Name = "langs";
            this.langs.Size = new System.Drawing.Size(35, 13);
            this.langs.TabIndex = 14;
            this.langs.Text = "label2";
            // 
            // bytes
            // 
            this.bytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bytes.AutoSize = true;
            this.bytes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bytes.Location = new System.Drawing.Point(626, 233);
            this.bytes.Name = "bytes";
            this.bytes.Size = new System.Drawing.Size(43, 17);
            this.bytes.TabIndex = 15;
            this.bytes.Text = "Bytes";
            this.bytes.Click += new System.EventHandler(this.bytes_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // repolabel
            // 
            this.repolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repolabel.AutoSize = true;
            this.repolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repolabel.ForeColor = System.Drawing.Color.Indigo;
            this.repolabel.Location = new System.Drawing.Point(573, 185);
            this.repolabel.Name = "repolabel";
            this.repolabel.Size = new System.Drawing.Size(52, 18);
            this.repolabel.TabIndex = 17;
            this.repolabel.Text = "label2";
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Crimson;
            this.errorMessage.Location = new System.Drawing.Point(221, 367);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 17);
            this.errorMessage.TabIndex = 18;
            // 
            // pages
            // 
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pages.AutoSize = true;
            this.pages.Location = new System.Drawing.Point(142, 372);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(0, 13);
            this.pages.TabIndex = 19;
            // 
            // GitHubBrowser
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 393);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.repolabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bytes);
            this.Controls.Add(this.langs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repo);
            this.Controls.Add(this.username);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.nxt_b);
            this.Controls.Add(this.prev_b);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(488, 331);
            this.Name = "GitHubBrowser";
            this.Text = "GitHub Browser";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView searchResults;
        private System.Windows.Forms.ColumnHeader repName;
        private System.Windows.Forms.ColumnHeader repOwner;
        private System.Windows.Forms.ColumnHeader repDescription;
        private System.Windows.Forms.Button prev_b;
        private System.Windows.Forms.Button nxt_b;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label repo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label langs;
        private System.Windows.Forms.Label bytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label repolabel;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Label pages;
    }
}

