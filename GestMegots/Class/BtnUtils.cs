
namespace GestMegots.Class
{
    public static class BtnUtils
    {
        public static void SetButtonVisibility(Form currentForm)
        {
            foreach (var requirement in BtnAbilityRequirement)
            {
                Control[] foundControls = currentForm.Controls.Find(requirement.Key, true);
                if (foundControls[0] is Button button)
                {
                    button.Visible = requirement.Value <= Session.SessionHab;
                }
            }
        }

        private static readonly Dictionary<string, int> BtnAbilityRequirement = new()
        {
            { "bt_add", 1 },
            { "bt_dell", 2 },
            { "bt_update", 2 },
            { "bt_collect", 1 },
            { "bt_hotspot", 2 },
            { "bt_materiel", 2 },
            { "bt_user", 3 },
        };

        public static bool VerifyDecision()
        {
            return MessageBox.Show(@"comfirmez vous cette action?", null, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}