using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserParserAPI.Models;

namespace UserParserAPI.Interfaces
{
    public interface IOutput
    {
        public void returnFile(List<User> users);
    }
}
