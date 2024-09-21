using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yes.BLL.classes
{
 public abstract class GeneralItem
    {
       protected DataRow drow; // data setהפניה לשורת פריט זו
       protected GeneralTable table; // הטבלה המכילה פריט זה
       protected object keyValue; // ערך שדה המפתח הראשי בפרית זה
       private DataRow dr; 
       protected abstract void FillFields(); // מחייב כתיבת פעולה זו במחלקות היורשות - לצורך פולימורפיזם
       protected abstract void FillDataRow(); // כנ"ל
       
       public GeneralItem (GeneralTable tb) // פעולה בונה לפריט ריק
       {
           table = tb;
       }
       public GeneralItem(DataRow dr, GeneralTable tb) // data rowפעולה בונה לפי
       {
           drow = dr;
           table = tb;
           FillFields ();
       }
       public GeneralItem(object keyValue, GeneralTable tb) // פעולה בונה לפי מפתח ראשי
       {
           this.keyValue = keyValue;
           table = tb;
           drow = tb.Find(keyValue);
           FillFields();
       }

       
       public DataRow Drow // datasetמאחזרת את ההפניה לפריט ב
       {
           get { return this.drow; }
       }
       public GeneralTable Table //מאחזרת את הטבלה המכילה פריט זה
       {
           get { return this.table; }
       }
       public void Add()
       {
           if (table.Find(keyValue) != null)
               throw new Exception("Already exists in Databace");
           drow = table.GetNewRow();
           FillDataRow();
           table.AddRow(drow);
       }
       public void Update()
       {
           FillDataRow();
           table.Save();
       }
       public virtual void Delete()
       {
           drow.Delete();
           table.Save();
       }
    }
}

