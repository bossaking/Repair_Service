using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Repair_Service.Controllers
{
    public class Validator
    {
        public static bool HasErrors(DependencyObject obj)
        {
            foreach (object child in LogicalTreeHelper.GetChildren(obj))
            {
                if (Validation.GetHasError((DependencyObject)child))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
