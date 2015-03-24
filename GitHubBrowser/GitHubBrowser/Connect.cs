﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using githubConnect;

namespace githubConnect
{
    public class Connect
    {
        // You'll need to put your own OAuth token here
        // It needs to have repo deletion capability
        private const string TOKEN = "a77976d3fc3fbaa2bff52877ad1c169fb3c26fda";

        // You'll need to put your own GitHub user name here
        private const string USER_NAME = "UofUMattMatt";

        // You'll need to put your own login name here
        private const string EMAIL = "ramilakus@yahoo.com";

        // You'll need to put one of your public REPOs here
        private const string PUBLIC_REPO = "PairWork";

        public Dictionary<string, Repository> repos;

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
        public async Task<Dictionary<string, Repository>> GetReposAsync(string searchterm)
        {
            if(searchterm == "")
            {
                throw new ArgumentNullException("search parameters are null");
            }
            repos = new Dictionary<string, Repository>();
            using (HttpClient client = CreateClient())
            {
                HttpResponseMessage response = await client.GetAsync("/search/repositories?q=" + searchterm);
                if (response.IsSuccessStatusCode)
                {
                    String login = "", avatar = "", repname = "" , description = "";
                    String result = await response.Content.ReadAsStringAsync();
                    dynamic orgs = JsonConvert.DeserializeObject(result);
                    foreach (dynamic c in orgs.items)
                    {
                            repname = c.name;
                            login = c.owner.login;
                            avatar = c.owner.avatar_url;  
                            description = c.description;

                            Repository temp = new Repository(login, repname, description, avatar, null);
                            repos.Add(login + repname, temp);               //KEY IS LOGIN + REPNAME

                     
                    }

                    return repos;
                }
                else
                {
                    throw new Exception("Connection Failed ");
                   /* Console.WriteLine("Error: " + response.StatusCode);
                    Console.WriteLine(response.ReasonPhrase);*/
                }
         /*       foreach (var key in repos)
                {
                    using (HttpClient client2 = CreateClient())
                    {
                        HttpResponseMessage response2 = await client2.GetAsync("GET /users/:" + key.Key);
                        if (response2.IsSuccessStatusCode)
                        {
                            String result2 = await response2.Content.ReadAsStringAsync();
                            dynamic orgs2 = JsonConvert.DeserializeObject(result2);
                            foreach (dynamic org in orgs2)
                            {
                                repos[key.Key].Email = org.email;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: " + response2.StatusCode);
                            Console.WriteLine(response2.ReasonPhrase);
                        }
                    }
                }*/
            }
        }
    }
}
