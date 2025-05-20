using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Classes
{
    public static class SidebarHelper
    {
        public static void AdjustSidebarForRole(
            int roleId,
            List<Label> sidebarLabels,
            List<Label> adminOnlyLabels,
            int topStart,
            int verticalSpacing = 10)
        {
            int currentTop = topStart;

            foreach (Label lbl in sidebarLabels)
            {
                if (adminOnlyLabels.Contains(lbl) && roleId != 1) // Not admin
                {
                    lbl.Visible = false;
                    continue;
                }

                lbl.Visible = true;
                lbl.Top = currentTop;
                currentTop += lbl.Height + verticalSpacing;
            }
        }
    }
}
