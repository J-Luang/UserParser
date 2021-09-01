using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserParserAPI.Models;

namespace UserParserAPI.Interfaces
{
    public interface IReader
    {
        public Dictionary<string, User> returnDictionary(string file);
    }
}
