using System;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinSandbox
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string version = Type.GetType("Mono.Runtime") is Type t 
                ? "You are running with the Mono VM " + t.GetMethods()
                    .FirstOrDefault(x => x.Name == "GetDisplayName")
                    ?.Invoke(null, null)
                    ?.ToString()
                : "";
            VersionInfomation.Text = version;
        }
    }
}
