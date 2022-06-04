using System.Globalization;
using LangChange.Utils;
using LangChange.ViewModels;

namespace LangChange;

public partial class MainPage : ContentPage
{
    int count = 0;
    bool isArabic = false;
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ViewModelBase();

    }

    void OnLangChangeClicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            CultureInfo ci = null;
            if (isArabic)
            {
                isArabic = false;
                LangChangeBtn.Text = "Arabic";
                ci = new CultureInfo("en");
                mainPage.FlowDirection = FlowDirection.LeftToRight;
            }
            else
            {
                isArabic = true;
                LangChangeBtn.Text = "English";
                ci = new CultureInfo("ar");
                mainPage.FlowDirection = FlowDirection.RightToLeft;
            }
            if (ci != null)
            {
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                CultureInfo.DefaultThreadCurrentCulture = ci;
                CultureInfo.DefaultThreadCurrentUICulture = ci;
                LangResourceLoader.Instance.SetCultureInfo(ci);
            }

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.StackTrace);
        }
    }
   
}


