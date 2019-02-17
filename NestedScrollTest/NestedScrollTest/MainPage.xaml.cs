using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NestedScrollTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listview.ItemsSource = AddPandaFamily();
        }
        List<string> pandaFamily = new List<string>();
        public List<string> AddPandaFamily()
        {
            for(int i=0; i<10; i++)
            {
                pandaFamily.Add("Smiley Panda");
                pandaFamily.Add("Red Panda");
                pandaFamily.Add("Qinling Panda");
                pandaFamily.Add("Oleosa Panda");
                pandaFamily.Add("Ailuropoda Panda");

            }
            return pandaFamily;
        }
        
    }
}
