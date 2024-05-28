using GestMegots.Formulaires;

namespace GestMegots.Class;

public class SwitchFm
{
    public enum Forms
    {
        FmHotspot,
        FmMateriel,
        FmCollecte,
        FmUser
    }
    
    public static void To(Forms form)
    {
        Form currentForm = Form.ActiveForm;
        if (currentForm != null)
        {
            ((Form)Activator.CreateInstance(Type.GetType($"GestMegots.Formulaires.{form.ToString()}"))).Show();
            currentForm.Hide();
        }
    }
}