using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    internal class Appdata
    {
        public const int ROLE_Librarian = 0;
        public const int ROLE_Reader = 1;

        public static bool isLogin = false;
        public static string email;
        public static int role;
    }
}
