using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using githubConnect;
using System.Text.RegularExpressions;

namespace githubConnect
{
    public class Connect
    {
        // You'll need to put your own OAuth token here
        // It needs to have repo deletion capability
        private const string TOKEN = "9aa3463f2763e664792b13534949acba34d5502f";

        // You'll need to put your own GitHub user name here
        private const string USER_NAME = "mahowa";

        // You'll need to put your own login name here
        private const string EMAIL = "jdbball1@gmail.com";

        // You'll need to put one of your public REPOs here
        private const string PUBLIC_REPO = "TEST_REPO";
        public Dictionary<string, Repository> repos;
        public string header;
        public int pageNum;
        public Connect() { }
        public HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.UserAgent.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", Uri.EscapeDataString(EMAIL));
            client.DefaultRequestHeaders.Add("Authorization", "token " + TOKEN);
            return client;
        }

        /// <summary>
        /// Prints out the names of the organizations to which the user belongs
        /// </summary> 
        public async Task<Dictionary<string, Repository>> GetReposAsync(string searchterm, CancellationToken cancel)
        {
            repos = new Dictionary<string, Repository>();                                                       //Dictionary of repositories
            using (HttpClient client = CreateClient())
            {
                HttpResponseMessage response = await client.GetAsync("/search/repositories?q=" + searchterm);   
                if (response.IsSuccessStatusCode)
                {
                    String login = "", avatar = "", repname = "", description = "", lang = "", bytes = "";
                    Languages language;
                    String result = await response.Content.ReadAsStringAsync();
                    dynamic orgs = JsonConvert.DeserializeObject(result);
                    foreach (dynamic c in orgs.items)
                    {                                       //Parse
                        repname = c.name;               //Repository name
                        login = c.owner.login;          //Username
                        avatar = c.owner.avatar_url;    //avatar url
                        description = c.description;    //repo description
                        lang = c.language;              //main repo Language
                        bytes = c.size;                 //repo size
                        if (String.IsNullOrWhiteSpace(lang))
                            lang = "Unknown";           //Unknown repo language
                        language = new Languages(lang, bytes);
                        Repository temp = new Repository(login, repname, description, avatar, null, language);      //Creates repository object
                        repos.Add(login + repname, temp);                 //KEY IS LOGIN + REPNAME
                        cancel.ThrowIfCancellationRequested();            //Allows cancelation of task
                    }
                    header = response.Headers.GetValues("Link").FirstOrDefault();   //Get link header
                    pageSift(header);       //Get page number (GITHUB API MAXIMUM '34')
                }
                else
                    throw new Exception("Connection Failed ");
                return repos;
            }
        }


        public void pageSift(string link)
        {
            string pattern = @"(\d+)";
            foreach (Match match in Regex.Matches(link, pattern))
                pageNum = Convert.ToInt16(match.Value);
        }
    }
}
