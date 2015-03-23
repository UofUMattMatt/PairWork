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


namespace GitHubBrowser
{
    public partial class GitHubBrowser : Form
    {
        Connect test;
        
        public GitHubBrowser()
        {
            InitializeComponent();
            test = new Connect();
        }

        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string search = searchText.Text;
            test.GetReposAsync();
            string tmp = "";
            foreach (var t in test.repos)
            {
                tmp = tmp + "/n" + t;
            }
        }

    }
}
