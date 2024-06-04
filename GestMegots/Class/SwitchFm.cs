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
        if (currentForm == null) return;
        ((Form)Activator.CreateInstance(Type.GetType($"GestMegots.Formulaires.{form.ToString()}"))).Show();
        currentForm.Hide();
    }
}