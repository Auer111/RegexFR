using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Auer_Find_Replace
{
    class ValidatingControl
    {
        private const int minimumLength = 3;

        public enum CRUDcontrolTypes { Read, Create, Edit, Delete }
        public CRUDcontrolTypes myCrudType { get; set; }

        public Control myControl { get; set; }
        public bool isValid { get; set; }
        public ValidatingControl(Control con, CRUDcontrolTypes crudType) {

            myControl = con;
            myCrudType = crudType;
            isValid = false;

            valueChanged();
        }
        public void valueChanged() {

            if (myControl is TextBox) { 
                TextBox mc = myControl as TextBox;
                if (mc.Text.Length >= minimumLength) { isValid = true; myControl.BackColor = Color.White; } 
                else  { isValid = false; myControl.BackColor = Color.PaleVioletRed; }
            }
            else if (myControl is ComboBox) { 
                ComboBox mc = myControl as ComboBox;
                if (mc.SelectedItem != null) { isValid = true; myControl.Parent.BackColor = Color.Transparent; }
                else { isValid = false; myControl.Parent.BackColor = Color.PaleVioletRed; }
            }
            //Console.WriteLine(myCrudType.ToString() + "  ---  " + myControl.Text + "  ---  " + isValid.ToString());
        }




    }
}
