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
            searchText.Focus();
            test = new Connect();
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            searchResults.Items.Clear();
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
                string search = searchText.Text;
                Dictionary<string, Repository> tempr = await test.GetReposAsync(searchParam);
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
            catch(ArgumentNullException)
            {
                MessageBox.Show("Please select a search parameter");
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



    }
}
