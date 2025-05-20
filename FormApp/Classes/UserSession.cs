using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Classes
{
    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string FullName { get; set; }
        public static string Email { get; set; }
        public static int RoleID { get; set; }
    }
}
