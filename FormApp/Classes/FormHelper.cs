using FormApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Classes
{
    public static class FormHelper
    {
        public static void ConfirmAndLogout(Form currentForm)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                currentForm.Hide();

                Login login = new Login
                {
                    StartPosition = FormStartPosition.CenterScreen
                };

                login.Show();
            }
        }

        public static void NavigateTo<T>(Form currentForm) where T : Form, new()
        {
            currentForm.Hide();
            T targetForm = new T
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            targetForm.Show();
        }

        public static void ExitApp()
        {
            Application.Exit();
        }
    }
}
