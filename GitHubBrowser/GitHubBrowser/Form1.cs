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
        
        public GitHubBrowser()
        {
            InitializeComponent();
            test = new Connect();
            searchResults.FullRowSelect = true; 
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();
            string search = searchText.Text;
            tempr = await test.GetReposAsync(searchText.Text);

            foreach (var t in tempr)
            {
                ListViewItem row = new ListViewItem(t.Value.RepName);
                row.SubItems.Add(t.Value.Username);
                row.SubItems.Add(t.Value.Description);
                searchResults.Items.Add(row);
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
               // avatar.Load(avatarURL);
            }
        }


    }
}
