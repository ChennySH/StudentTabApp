using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentTabApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        Student s;
        public TabPage()
        {
            InitializeComponent();
            s = new Student();
            this.BindingContext = s;
            RegPart1.BindingContext = this.BindingContext;
            RegPart2.BindingContext = this.BindingContext;
            RegPart3.BindingContext = this.BindingContext;
        }
    }
}