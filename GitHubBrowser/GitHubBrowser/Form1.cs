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
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GitHubBrowser
{
    public partial class GitHubBrowser : Form
    {
        private Connect repositoryRequest;                  //Connect to github api to poppulate search results
        public Dictionary<string, Repository> RepoDict;     //Repository dictionary
        private int currentPage = 1;                        //page counter
        private int totalPages;                             //total pages
        private CancellationTokenSource tokenSource;        //cancel token
        
        public GitHubBrowser()
        {
            InitializeComponent();
            searchText.Focus();
            repositoryRequest = new Connect();
            searchResults.FullRowSelect = true;
            //GUI aesthetics 
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            bytelabel.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            loading.Visible = false;
            searchBox.SelectedIndex = 0;
            email.Visible = false;
            StarLabel.Visible = false;
            starlabelcount.Visible = false;
            cancel.Visible = false;
        }

        private async void SearchButton(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();        //cancelation token
            //GUI aesthetics 
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            bytelabel.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            email.Visible = false;
            StarLabel.Visible = false;
            starlabelcount.Visible = false;
            cancel.Visible = true;

            currentPage = 1;
            totalPages = 0;
            searchResults.Items.Clear();
            errorMessage.Text = "";
            string searchParam = "";
            //Check for search criteria
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
                loading.Visible = true;
                RepoDict = await repositoryRequest.GetReposAsync(searchParam, tokenSource.Token);   //Get search results

                //Populate listview
                foreach (var t in RepoDict)
                {
                    ListViewItem row = new ListViewItem(t.Value.RepName);
                    row.SubItems.Add(t.Value.Username);
                    row.SubItems.Add(t.Value.Description);
                    searchResults.Items.Add(row);
                }

            }
            catch (OperationCanceledException) { errorMessage.Text = "Operation was cancelled"; }
            catch (ArgumentNullException) { errorMessage.Text = "Enter something into the search parameter!"; }
            catch (Exception) { errorMessage.Text = "ERROR: Connection Failed. Please Try again."; }
            finally
            {   //GUI aesthetics 
                loading.Visible = false;    
                totalPages = repositoryRequest.pageNum;
                pageCount();
                cancel.Visible = false;
            }
        }


        private async void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {   //GUI aesthetics 
            loading.Visible = true;

            ListView.SelectedListViewItemCollection reps= searchResults.SelectedItems;
            Repository r;
            foreach(ListViewItem item in reps){
                RepoDict.TryGetValue(item.SubItems[1].Text + item.SubItems[0].Text, out r);
                string avatarURL = r.Avatar;
                avatar.ImageLocation = avatarURL;
                username.Text = r.Username;
                repolabel.Text = r.RepName;
                starlabelcount.Text = r.Stars;
                
                if(String.IsNullOrWhiteSpace(r.Email))
                {
                    using (HttpClient client = repositoryRequest.CreateClient())
                    {
                        HttpResponseMessage response = await client.GetAsync("users/" + r.Username);
                        if (response.IsSuccessStatusCode)
                        {
                            String result2 = await response.Content.ReadAsStringAsync();
                            dynamic orgs2 = JsonConvert.DeserializeObject(result2);
                            repositoryRequest.repos[r.Username + r.RepName].Email = orgs2.email;
                        }
                        else
                        {
                            errorMessage.Text = "Failed to get Users Email. Error: " + response.StatusCode + " " + response.ReasonPhrase;
                        }
                    }
                }
                email.Text = r.Email;
                langs.Text = r.languages.type;
                bytelabel.Text = r.languages.lines;
            }
            repo.Visible = true;
            repolabel.Visible = true;
            label1.Visible = true;
            bytes.Visible = true;
            langs.Visible = true;
            bytelabel.Visible = true;
            avatar.Visible = true;
            username.Visible = true;
            loading.Visible = false;
            email.Visible = true;
            StarLabel.Visible = true;
            starlabelcount.Visible = true;
        }

        private async void nxt_b_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            bytelabel.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            email.Visible = false;
            StarLabel.Visible = false;
            starlabelcount.Visible = false;

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
                    loading.Visible = true;
                    // string search = searchText.Text;
                    RepoDict = await repositoryRequest.GetReposAsync(searchParam, tokenSource.Token);

                    foreach (var t in RepoDict)
                    {
                        ListViewItem row = new ListViewItem(t.Value.RepName);
                        row.SubItems.Add(t.Value.Username);
                        row.SubItems.Add(t.Value.Description);
                        searchResults.Items.Add(row);
                    }

                }
                catch (ArgumentNullException)
                {
                    errorMessage.Text = "Please select a search parameter";

                }
                catch (OperationCanceledException)
                {
                    errorMessage.Text = "Operation was cancelled";
                }
                catch (Exception)
                {
                    errorMessage.Text = "ERROR: Connection Failed. Please Try again.";
                }
                finally { loading.Visible = false; }

            }
        }
        

        private async void prev_b_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();

            repo.Visible = false;
            repolabel.Visible = false;
            label1.Visible = false;
            bytes.Visible = false;
            langs.Visible = false;
            bytelabel.Visible = false;
            avatar.Visible = false;
            username.Visible = false;
            email.Visible = false;
            StarLabel.Visible = false;
            starlabelcount.Visible = false;

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
                    loading.Visible = true;
                    // string search = searchText.Text;
                    RepoDict = await repositoryRequest.GetReposAsync(searchParam, tokenSource.Token);

                    foreach (var t in RepoDict)
                    {
                        ListViewItem row = new ListViewItem(t.Value.RepName);
                        row.SubItems.Add(t.Value.Username);
                        row.SubItems.Add(t.Value.Description);
                        searchResults.Items.Add(row);
                    }

                }
                catch (ArgumentNullException)
                {
                    errorMessage.Text = "Please select a search parameter";
                    
                }
                catch(OperationCanceledException)
                {
                    errorMessage.Text = "Operation was cancelled";
                }
                catch (Exception)
                {
                    errorMessage.Text = "ERROR: Connection Failed. Please Try again.";
                }
                finally { loading.Visible = false; }

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
        private void pageCount()
        {
            pages.Text = "Page " + currentPage + " of " + totalPages;
        }

        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Spaces inbetween string lines show where the string has a double return.
            string helpMessage = "\t\t\t GitHub Browswer Help\n\n"
                                + "Searching a repo by: name, description, or readme:\n"
                                + "Enter your desired search parameter and select Profile Info, then select search or press enter\n\n"

                                + "Searching a repo by a language:\n"
                                + "Enter your desired  language then select Language, again select search or press enter\n\n"

                                + "Searching a repo by star rating:\n"
                                + "Enter a comparator followed by the desired number of starts\n"
                                + "ex. >= 500 would search for a parameter for at least 500 stars\n\n"

                                + "To cancel an operation click the cancel button during an operation\n"
                                + "To navigate pages, press previous or next to traverse through pages\n"
                                + "To get more information for a respository, select the row; information will be\n"
                                + "displayed to the right of the results.";
                                

            MessageBox.Show(helpMessage);
        }


    }
}
