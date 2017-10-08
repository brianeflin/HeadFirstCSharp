
using System.Windows.Forms;

namespace SubclassConstructor
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis, string anotherValue)
            : base(baseClassNeedsThis)
        {
            MessageBox.Show("This is the subclass: " + baseClassNeedsThis + " and " + anotherValue);
        }
    }
}
