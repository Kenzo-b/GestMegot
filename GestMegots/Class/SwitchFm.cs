using GestMegots.Formulaires;

namespace GestMegots.Class;

public static class SwitchFm
{
    public enum Forms
    {
        FmHotspot,
        FmMateriel,
        FmCollect,
        FmUser,
        FmLogin
    }
    
    public static void To(Forms form)
    {
        Form currentForm = Form.ActiveForm;
        Form nextForm = (Form)Activator.CreateInstance(Type.GetType($"GestMegots.Formulaires.{form.ToString()}"));
        nextForm.StartPosition = FormStartPosition.Manual;
        nextForm.Location = currentForm.Location;
        nextForm.Show();
        currentForm.Hide();
    }

    public static void ToDefaultFm()
    {
        switch (Session.SessionHab)
        {
            case 1:
                To(Forms.FmCollect);
                break;
            case 2: 
                To(Forms.FmHotspot);
                break;
            case 3:
                To(Forms.FmUser);
                break;
        }
    }

    public static void ToLoginFm()
    {
        Session.UnsetSession();
        To(Forms.FmLogin);
    }
}