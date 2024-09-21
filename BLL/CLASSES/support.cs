using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace yes.BLL
{
    public enum FormStatus
    {
        Add, Update, Display, Delrte
    }
    class support
    {
        public static void FillComboBox(ComboBox combo, DataTable table, string keyField, string DisplayField)
        {
            combo.DataSource = table;
            combo.ValueMember = keyField;
            combo.DisplayMember = DisplayField;
        }
    }
}
