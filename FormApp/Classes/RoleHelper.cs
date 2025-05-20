using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Classes
{
    public static class RoleHelper
    {
        public static void ApplyRolePermissions(int roleId, Label lblRole, params Control[] adminOnlyControls)
        {
            if (roleId == 1) // Admin
            {
                lblRole.Text = "Admin";
                foreach (var control in adminOnlyControls)
                {
                    control.Visible = true;
                }
            }
            else if (roleId == 2) // Manager
            {
                lblRole.Text = "Manager";
                foreach (var control in adminOnlyControls)
                {
                    control.Visible = false;
                }
            }
        }
    }
}
