using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserParserAPI.Interfaces;
using UserParserAPI.Models;

namespace UserParserAPI.Services
{
    public class UserService
    {
        private IJSONReader reader = new ReaderService();
        private IOutput _output = new OutputFileService();

        public List<User> returnUsers(string jsonFile) {
            List<User> listUsers = new List<User>();

            foreach(KeyValuePair<string, User> kvp in reader.returnDictionary(jsonFile))
            {
                if (validUser(kvp.Value)) {
                    listUsers.Add(kvp.Value);
                }
            }

            _output.returnFile(listUsers);

            return listUsers;
        }

        private bool validUser(User user) {
            if (user.AccountEnabled == true && user.DisplayName.IndexOf('S', StringComparison.OrdinalIgnoreCase) > 0) {
                return true;
            }
            return false;
        }
    }
}
