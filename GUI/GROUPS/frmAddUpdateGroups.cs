using yes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yes.BLL.BCOUNSELORS;
using yes.BLL.BGROUPS;
using yes.BLL.BDATESFORGROUP;

namespace yes.GUI.GROUPS
{
    public partial class frmAddUpdateGroups : Form
    {
        Groups c = new Groups();
        groupsTabel cTable = new groupsTabel();
        string state = "true";
        public frmAddUpdateGroups()
        {
            InitializeComponent();
            txtNew.Text = cTable.GetNewKey().ToString();
            this.state = "add";
           

        }
        public frmAddUpdateGroups(Groups g)
        {
            InitializeComponent();
            this.state = "update";
            this.c = g;
            txtNew.Text = g.CodeGroup.ToString();
            txtNumSurfs.Text = g.NumberOfSurfersInGroup.ToString();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvDates.Items.Count > 0)
            {
                bool ok = true;
                errorProvider1.Clear();
                try
                {
                    c.CodeGroup = Convert.ToInt32(txtNew.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtNew, ex.Message);
                    ok = false;
                }

                try
                {
                    c.NumberOfSurfersInGroup = Convert.ToInt32(txtNumSurfs.Text);
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtNumSurfs, ex.Message);
                    ok = false;
                }
                if (ok)
                {
                    if (state == "add")
                    {
                        try
                        {
                            c.Add();
                            for (int i = 0; i < lvDates.Items.Count; i++)
                            {
                                DatesForGroup dfg = new DatesForGroup();
                                dfg.GroupCode = Convert.ToInt32(txtNew.Text);
                                dfg.GroupDate = Convert.ToDateTime(lvDates.Items[i].SubItems[0].Text);
                                dfg.StartingTime = Convert.ToDateTime(lvDates.Items[i].SubItems[1].Text);
                                dfg.EndingTime = Convert.ToDateTime(lvDates.Items[i].SubItems[2].Text);
                                dfg.TookPlace = Convert.ToBoolean(lvDates.Items[i].SubItems[3].Text);
                                dfg.Add();
                            }
                            MessageBox.Show("נקלט בהצלחה");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("בעיה בקליטה");

                        }
                    }
                    else
                    {
                        try
                        {
                            c.Update();
                            DataTable dtz = new DatesForGroupTable().getdatesForGroup(Convert.ToInt32(txtNew.Text));
                            for (int j = 0; j < dtz.Rows.Count; j++)
                            {
                                 DatesForGroup df = new DatesForGroup(Convert.ToInt32(dtz.Rows[j][0]), Convert.ToDateTime(dtz.Rows[j][1]));
                                df.Delete();
                            }
                            for (int i = 0; i < lvDates.Items.Count; i++)
                            {
                                DatesForGroup dfg = new DatesForGroup();
                                dfg.GroupCode = Convert.ToInt32(txtNew.Text);
                                dfg.GroupDate = Convert.ToDateTime(lvDates.Items[i].SubItems[0].Text);
                                dfg.StartingTime = Convert.ToDateTime(lvDates.Items[i].SubItems[1].Text);
                                dfg.EndingTime = Convert.ToDateTime(lvDates.Items[i].SubItems[2].Text);
                                dfg.TookPlace = Convert.ToBoolean(lvDates.Items[i].SubItems[3].Text);
                                dfg.Add();
                            }
                            MessageBox.Show("עודכן בהצלחה");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("בעיה בעדכון");
                        }
                    }
                }
                this.Close();
            }
            else
                MessageBox.Show("לא ניתן לשמור קבוצה ללא קביעת שעור/ים");
        }
        private void btnEraseLesson_Click(object sender, EventArgs e)
        {
           
            if (lvDates.SelectedItems.Count > 0)
                lvDates.Items.Remove(lvDates.SelectedItems[0]);
            else
                MessageBox.Show("בחר שעור למחיקה");
        }

        private void btnLessonTookPlace_Click(object sender, EventArgs e)
        {
            if (lvDates.SelectedItems.Count > 0)
                lvDates.SelectedItems[0].SubItems[3].Text = "true";
            else
                MessageBox.Show("בחר תאריך");
        }

        private void btnCancelLesson_Click(object sender, EventArgs e)
        {
            if (lvDates.SelectedItems.Count > 0)
            lvDates.SelectedItems[0].SubItems[3].Text = "false";
             else
                MessageBox.Show("בחר תאריך");
        }

        private void btnAddToListview_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(new string[] {dtpDateForLesson.Value.ToShortDateString(), cmbHour.Text + ":" + cmbMinutes.Text, cmbHourEnd.Text + ":" + cmbMinutesEnd.Text,"false" });
            lvDates.Items.Add(item);
        }

        private void grpDatesForGroup_Enter(object sender, EventArgs e)
        {

        }
            }
        }
    

        
   
