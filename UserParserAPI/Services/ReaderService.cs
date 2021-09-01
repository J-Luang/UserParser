using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UserParserAPI.Interfaces;
using UserParserAPI.Models;

namespace UserParserAPI.Services
{
    public class ReaderService : IJSONReader
    {
        public Dictionary<string, User> returnDictionary(string jsonFile)
        {
            Dictionary<string, User> dictUsers = new Dictionary<string, User>();

            using (WebClient wc = new WebClient())
            {
                var json = new WebClient().DownloadString(jsonFile);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var item in users) {
                    dictUsers.Add(item.UserPrincipalName, item);
                }
            }
            return dictUsers;
        }
    }
}
