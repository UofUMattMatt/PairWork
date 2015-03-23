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
        
        public GitHubBrowser()
        {
            InitializeComponent();
            test = new Connect();
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();
            string search = searchText.Text;
            Dictionary<string, Repository> tempr = await test.GetReposAsync(searchText.Text);

            ImageList avatars = ImageList(tempr);
            
            
            foreach (var t in tempr)
            {
                searchResults.SmallImageList = avatars;
                ListViewItem row = new ListViewItem(t.Value.Avatar);
                row.SubItems.Add(t.Value.RepName);
                row.SubItems.Add(t.Value.Username);
                row.SubItems.Add(t.Value.Description);
                searchResults.Items.Add(row);
            }
           
        }
        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        public ImageList ImageList(Dictionary<string, Repository> tempr)
        {
            ImageList imagelist1 = new ImageList();
            imagelist1.ImageSize = new Size(25, 25);
            
            foreach(var t in tempr){
                Image i = GetImageFromUrl(t.Value.Avatar);
                imagelist1.Images.Add(i);
            }
            return imagelist1;
        }

    }
}
