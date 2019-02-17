using Xamarin.Forms;

namespace NestedScrollTest.CustomRenderer
{
    public class NestedScroll : Xamarin.Forms.ListView
    {
        public static readonly BindableProperty IsNestedScrollProperty = BindableProperty.Create(
            propertyName: "IsNestedScroll",
            returnType: typeof(bool),
            declaringType: typeof(NestedScroll),
            defaultValue: false
            );

        public bool IsNestedScroll
        {
            get
            {
                return (bool)GetValue(IsNestedScrollProperty);
            }
            set
            {
                SetValue(IsNestedScrollProperty, value);
            }
        }
    }
}
