using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yes.DAL;

namespace yes.BLL.classes
{
   public class GeneralTable
    {
        protected static Dal dal = new Dal(); //מופע יחיד של מחלקת dal
        protected DataTable table; // טבלת נתונים
        protected string tableName; // שם הטבלה
        protected string key; // שם שדה המפתח הראשי
        private int currentRow; //לניווט

        public GeneralTable
            (string tableName, string key) //פעולה בונה
        {
            this.table = dal.GetTable(tableName);
            this.tableName = tableName;
            this.key = key;
        }
        public DataTable GetDataTable() //מאחזר את אוביקט הטבלה 
        {
            return this.table;
        }
        public string GetTableName() //מאחזרת את שם הטבלה
        {
            return this.tableName;
        }
        public string GetPrimaryKey() // מאחזרת את שם המפתח הראשי
        {
            return this.key;
        }
        public int GetNewKey() // מחזירה קוד חדש לטבלאות בהן המפתח הראשי הוא  מספור עוקב 
        {
            if (this.table.Rows.Count == 0)
                return 0;
            return Convert.ToInt32(dal.GetQuery("SELECT Max(" + this.tableName + "." + this.key + ") AS Max1 FROM " + this.tableName).Rows[0][0]) + 1;
        }
        public int GetNumOfFields() // מאחזרת את מספר השדות בטבלה
        {
            return this.table.Columns.Count;
        }
        public bool IsEmpty() // מחזירה האם הטבלה היא ריקה או לא
        {
            if (table.Rows.Count == 0)
                return true;
            return false;
        }
        public DataRow GetCurrentRow() // מחזירה את השורה הנוחכית
        {
            if (IsEmpty())
                throw new Exception("The Table Is Empty");
            return table.Rows[currentRow];
        }
        public DataRow GetNext() // מחזירה את השורה הבאה ומשנה את האינדקס בהתאם
        {
            if (IsEmpty())
                throw new Exception("The Table Is Empty");
            currentRow++;
            if (currentRow == table.Rows.Count)
                currentRow = 0;
            return table.Rows[currentRow];
        }
        public DataRow GetPrevious() // מחזירה את השורה הקודמת ומשנה את האינדקס בהתאם
        {
            if (IsEmpty())
                throw new Exception("The Table Is Empty");
            currentRow--;
            if (currentRow == -1)
                currentRow = table.Rows.Count - 1;
            return table.Rows[currentRow];
        }
        public DataRow GetFirst() // מחזירה את השורה הראשונה ומשנה את האינדקס בהתאם
        {
            if (IsEmpty())
                throw new Exception("The Table Is Empty");
            currentRow = 0;
            return table.Rows[currentRow];
        }

        public DataRow GetLast()  // מחזירה את השורה האחרונה ומשנה את האינדקס בהתאם
        {
            if (IsEmpty())
                throw new Exception("The Table Is Empty");
            currentRow = table.Rows.Count - 1;
            return table.Rows[currentRow];
        }
        public DataRow Find(string fieldName, object value) //מחזירה את הרשומה הראשונה שנמצאה לפי שם שדה וערך לחיפוס
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[fieldName].Equals(value))
                    return row;
            }
            return null;
        }
        public DataRow Find(object value) //  מחזירה את הרשומה הראשונה שנמצאה ע"פ חיפוס הערך הנשלח בעמודת המפתח
        {
            return Find(this.key, value);
        }
        public DataTable FindAll(string fieldName, object value) // מחזירה טבלה עם תוצאות החיפוס ע"פ שם טבלה וערך לחיפוס
        {
            if (value is string)
                value = "" + value as string + "";
            DataTable dtTemp = dal.GetQuery("select*from " + this.tableName + "where" + fieldName + "=" + value.ToString());
            return dtTemp;
        }
       
        public DataRow GetNewRow() // מחזירה רשומה ריקה במבנה הטבלה
        {
            return table.NewRow();
        }
        public void AddRow(DataRow drow) // מקבלת רשומה ומחזירה אותה לטבלה
        {
            table.Rows.Add(drow);
            Save();
        }
        public void Save() // שמירת נתונים שבוצעו בטבלה - במסד הנתונים
        {
            try
            {
                dal.Update(table.TableName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "בעיה בעדכון מסד נתונים");
            }
        }

    }
}
