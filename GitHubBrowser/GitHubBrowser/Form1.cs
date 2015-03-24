using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using githubConnect;
using System.Windows.Media.Imaging;
using System.IO;
using System.Net;

namespace GitHubBrowser
{
    public partial class GitHubBrowser : Form
    {
        private Connect test;
        public Dictionary<string, Repository> tempr;
        private int currentPage = 1;
        private int totalPages;
        
        public GitHubBrowser()
        {
            InitializeComponent();
            searchText.Focus();
            test = new Connect();
            searchResults.FullRowSelect = true;
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            label3.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            label3.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            currentPage = 1;
            totalPages = 0;
            searchResults.Items.Clear();
            errorMessage.Text = "";
            string searchParam = "";

            switch (searchBox.Text)
            {
                case "Profile Info":
                    searchParam = searchText.Text;
                    break;
                case "Language":
                    searchParam = "language:" + searchText.Text;
                    break;
                case "Rating":
                    searchParam = "stars:" + searchText.Text ;
                    break;
                    
            }

            try
            {
           // string search = searchText.Text;
            tempr = await test.GetReposAsync(searchParam);

            foreach (var t in tempr)
            {
                ListViewItem row = new ListViewItem(t.Value.RepName);
                row.SubItems.Add(t.Value.Username);
                row.SubItems.Add(t.Value.Description);
                searchResults.Items.Add(row);
            }

            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Please select a search parameter");
            }
            catch(Exception){
                errorMessage.Text = "ERROR: Connection Failed. Please Try again.";}
            finally
            {
                totalPages = test.pageNum;
                pageCount();
            }
           

           
        }


        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection reps= searchResults.SelectedItems;
            Repository r;
            foreach(ListViewItem item in reps){
                tempr.TryGetValue(item.SubItems[1].Text + item.SubItems[0].Text, out r);
                string avatarURL = r.Avatar;
                avatar.ImageLocation = avatarURL;
                username.Text = r.Username;
                repolabel.Text = r.RepName;
            }
            repo.Visible = true;
            repolabel.Visible = true;
            label1.Visible = true;
            bytes.Visible = true;
            langs.Visible = true;
            label3.Visible = true;
            avatar.Visible = true;
            username.Visible = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string helpMessage = "\t\t\t GitHUb Browswer Help\n"
                                 + "If searching for repository whose name, description, or readme contains something:\n"
                                 + "\t-Enter your desired search parameter and select Profile Info, then select search or press enter\n"
                                 + "If searching for repositories by a specific language:\n"
                                 + "\t-Enter your desired search language then select Language, again select search or press enter\n"
                                 + "If searching for a respository with a specific rating:\n"
                                 + "\t-Enter a comparator followed by the desired number of starts:\n"
                                 + "-\t\t- ex >= 500 would search for a parameter for at least 500 stars";
           
            MessageBox.Show(helpMessage);
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void nxt_b_Click(object sender, EventArgs e)
        {
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            label3.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            if (currentPage < totalPages)
            {
                currentPage++;
                pageCount();
                searchResults.Items.Clear();
                errorMessage.Text = "";
                string searchParam = "";
                switch (searchBox.Text)
                {
                    case "Profile Info":
                        searchParam = searchText.Text + "&page=" + currentPage;
                        break;
                    case "Language":
                        searchParam = "language:" + searchText.Text + "&page=" + currentPage;;
                        break;
                    case "Rating":
                        searchParam = "stars:" + searchText.Text + "&page=" + currentPage;;
                        break;

                }
                try
                {
                    // string search = searchText.Text;
                    tempr = await test.GetReposAsync(searchParam);

                    foreach (var t in tempr)
                    {
                        ListViewItem row = new ListViewItem(t.Value.RepName);
                        row.SubItems.Add(t.Value.Username);
                        row.SubItems.Add(t.Value.Description);
                        searchResults.Items.Add(row);
                    }

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Please select a search parameter");
                }
                catch (Exception)
                {
                    errorMessage.Text = "ERROR: Connection Failed. Please Try again.";
                }

            }
        }

        private async void prev_b_Click(object sender, EventArgs e)
        {
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            label3.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            if (currentPage > 1)
            {
                currentPage--;
                pageCount();
                searchResults.Items.Clear();
                errorMessage.Text = "";
                string searchParam = "";
                switch (searchBox.Text)
                {
                    case "Profile Info":
                        searchParam = searchText.Text + "&page=" + currentPage;
                        break;
                    case "Language":
                        searchParam = "language:" + searchText.Text + "&page=" + currentPage; ;
                        break;
                    case "Rating":
                        searchParam = "stars:" + searchText.Text + "&page=" + currentPage; ;
                        break;

                }
                try
                {
                    // string search = searchText.Text;
                    tempr = await test.GetReposAsync(searchParam);

                    foreach (var t in tempr)
                    {
                        ListViewItem row = new ListViewItem(t.Value.RepName);
                        row.SubItems.Add(t.Value.Username);
                        row.SubItems.Add(t.Value.Description);
                        searchResults.Items.Add(row);
                    }

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Please select a search parameter");
                }
                catch (Exception)
                {
                    errorMessage.Text = "ERROR: Connection Failed. Please Try again.";
                }

            }
        }

        private void repo_Click(object sender, EventArgs e)
        {

        }

        private void bytes_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }
        private void pageCount()
        {
            pages.Text = "Page " + currentPage + " of " + totalPages;
        }


    }
}
