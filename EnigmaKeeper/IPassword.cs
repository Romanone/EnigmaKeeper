using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaKeeper
{
    interface IPassword
    {
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        bool Encrypted { get; set; }
    }
}
