using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserParserAPI.Interfaces;
using UserParserAPI.Models;

namespace UserParserAPI.Services
{
    public class OutputFileService : IOutput
    {
        public void returnFile(List<User> users)
        {

            //using StreamWriter file = new("Users.csv");

            var csv = new StringBuilder();

            foreach (User user in users)
            {
                string UserPName = user.UserPrincipalName;
                string DisplayName = user.DisplayName;
                string AccountEnabled = user.AccountEnabled.ToString();

                string newLine = string.Format("{0},{1},{2}\n", UserPName, DisplayName, AccountEnabled);

                csv.Append(newLine);
            }

            File.WriteAllText("./OutputFile/users.csv", csv.ToString());
        }
    }
}
