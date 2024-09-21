namespace yes.GUI.GROUPS
{
    partial class frmAddUpdateGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUpdateGroups));
            this.btnOK = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumSurfs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDatesForGroup = new System.Windows.Forms.GroupBox();
            this.btnCancelLesson = new System.Windows.Forms.Button();
            this.btnLessonTookPlace = new System.Windows.Forms.Button();
            this.btnEraseLesson = new System.Windows.Forms.Button();
            this.lvDates = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpDateForLesson = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinutes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbHourEnd = new System.Windows.Forms.ComboBox();
            this.cmbMinutesEnd = new System.Windows.Forms.ComboBox();
            this.btnAddToListview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpDatesForGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOK.Location = new System.Drawing.Point(356, 507);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(210, 55);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "אישור";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(633, 147);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(132, 20);
            this.txtNew.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(771, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "קוד קבוצה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(594, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "הוספה/עדכון - קבוצות";
            // 
            // txtNumSurfs
            // 
            this.txtNumSurfs.Location = new System.Drawing.Point(633, 191);
            this.txtNumSurfs.Name = "txtNumSurfs";
            this.txtNumSurfs.Size = new System.Drawing.Size(132, 20);
            this.txtNumSurfs.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(771, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "מספר גולשים בקבוצה";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpDatesForGroup
            // 
            this.grpDatesForGroup.Controls.Add(this.btnCancelLesson);
            this.grpDatesForGroup.Controls.Add(this.btnLessonTookPlace);
            this.grpDatesForGroup.Controls.Add(this.btnEraseLesson);
            this.grpDatesForGroup.Controls.Add(this.lvDates);
            this.grpDatesForGroup.Location = new System.Drawing.Point(64, 74);
            this.grpDatesForGroup.Name = "grpDatesForGroup";
            this.grpDatesForGroup.Size = new System.Drawing.Size(502, 411);
            this.grpDatesForGroup.TabIndex = 20;
            this.grpDatesForGroup.TabStop = false;
            this.grpDatesForGroup.Text = "תאריכים לקבוצות";
            this.grpDatesForGroup.Enter += new System.EventHandler(this.grpDatesForGroup_Enter);
            // 
            // btnCancelLesson
            // 
            this.btnCancelLesson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelLesson.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelLesson.Location = new System.Drawing.Point(84, 354);
            this.btnCancelLesson.Name = "btnCancelLesson";
            this.btnCancelLesson.Size = new System.Drawing.Size(81, 31);
            this.btnCancelLesson.TabIndex = 2;
            this.btnCancelLesson.Text = "שעור התבטל";
            this.btnCancelLesson.UseVisualStyleBackColor = false;
            this.btnCancelLesson.Click += new System.EventHandler(this.btnCancelLesson_Click);
            // 
            // btnLessonTookPlace
            // 
            this.btnLessonTookPlace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLessonTookPlace.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLessonTookPlace.Location = new System.Drawing.Point(202, 354);
            this.btnLessonTookPlace.Name = "btnLessonTookPlace";
            this.btnLessonTookPlace.Size = new System.Drawing.Size(83, 31);
            this.btnLessonTookPlace.TabIndex = 1;
            this.btnLessonTookPlace.Text = "שעור התקיים";
            this.btnLessonTookPlace.UseVisualStyleBackColor = false;
            this.btnLessonTookPlace.Click += new System.EventHandler(this.btnLessonTookPlace_Click);
            // 
            // btnEraseLesson
            // 
            this.btnEraseLesson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEraseLesson.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEraseLesson.Location = new System.Drawing.Point(320, 354);
            this.btnEraseLesson.Name = "btnEraseLesson";
            this.btnEraseLesson.Size = new System.Drawing.Size(83, 31);
            this.btnEraseLesson.TabIndex = 1;
            this.btnEraseLesson.Text = "מחק שורה";
            this.btnEraseLesson.UseVisualStyleBackColor = false;
            this.btnEraseLesson.Click += new System.EventHandler(this.btnEraseLesson_Click);
            // 
            // lvDates
            // 
            this.lvDates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDates.FullRowSelect = true;
            this.lvDates.GridLines = true;
            this.lvDates.Location = new System.Drawing.Point(84, 36);
            this.lvDates.MultiSelect = false;
            this.lvDates.Name = "lvDates";
            this.lvDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvDates.RightToLeftLayout = true;
            this.lvDates.Size = new System.Drawing.Size(319, 300);
            this.lvDates.TabIndex = 0;
            this.lvDates.UseCompatibleStateImageBehavior = false;
            this.lvDates.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "תאריך שעור";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "שעת התחלה";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שעת סיום";
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "התקיים כן/לא";
            this.columnHeader4.Width = 90;
            // 
            // dtpDateForLesson
            // 
            this.dtpDateForLesson.Location = new System.Drawing.Point(17, 57);
            this.dtpDateForLesson.Name = "dtpDateForLesson";
            this.dtpDateForLesson.Size = new System.Drawing.Size(144, 20);
            this.dtpDateForLesson.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(177, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "תאריך שעור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(179, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "שעת התחלה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(190, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "שעת סיום";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(99, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = ":";
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHour.Location = new System.Drawing.Point(52, 105);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(41, 21);
            this.cmbHour.TabIndex = 23;
            // 
            // cmbMinutes
            // 
            this.cmbMinutes.FormattingEnabled = true;
            this.cmbMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutes.Location = new System.Drawing.Point(120, 105);
            this.cmbMinutes.Name = "cmbMinutes";
            this.cmbMinutes.Size = new System.Drawing.Size(41, 21);
            this.cmbMinutes.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(99, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = ":";
            // 
            // cmbHourEnd
            // 
            this.cmbHourEnd.FormattingEnabled = true;
            this.cmbHourEnd.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbHourEnd.Location = new System.Drawing.Point(52, 153);
            this.cmbHourEnd.Name = "cmbHourEnd";
            this.cmbHourEnd.Size = new System.Drawing.Size(41, 21);
            this.cmbHourEnd.TabIndex = 23;
            // 
            // cmbMinutesEnd
            // 
            this.cmbMinutesEnd.FormattingEnabled = true;
            this.cmbMinutesEnd.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbMinutesEnd.Location = new System.Drawing.Point(120, 153);
            this.cmbMinutesEnd.Name = "cmbMinutesEnd";
            this.cmbMinutesEnd.Size = new System.Drawing.Size(41, 21);
            this.cmbMinutesEnd.TabIndex = 23;
            // 
            // btnAddToListview
            // 
            this.btnAddToListview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToListview.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddToListview.Location = new System.Drawing.Point(103, 206);
            this.btnAddToListview.Name = "btnAddToListview";
            this.btnAddToListview.Size = new System.Drawing.Size(92, 49);
            this.btnAddToListview.TabIndex = 24;
            this.btnAddToListview.Text = "הוסף";
            this.btnAddToListview.UseVisualStyleBackColor = false;
            this.btnAddToListview.Click += new System.EventHandler(this.btnAddToListview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToListview);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbMinutesEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbMinutes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbHourEnd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbHour);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpDateForLesson);
            this.groupBox1.Location = new System.Drawing.Point(581, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 277);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "הוסף פרטי שעור";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(935, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddUpdateGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1088, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDatesForGroup);
            this.Controls.Add(this.txtNumSurfs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "frmAddUpdateGroups";
            this.Text = "frmAddUpdateGroups";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpDatesForGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumSurfs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateForLesson;
        private System.Windows.Forms.GroupBox grpDatesForGroup;
        private System.Windows.Forms.Button btnLessonTookPlace;
        private System.Windows.Forms.Button btnEraseLesson;
        private System.Windows.Forms.ListView lvDates;
        private System.Windows.Forms.ComboBox cmbMinutesEnd;
        private System.Windows.Forms.ComboBox cmbMinutes;
        private System.Windows.Forms.ComboBox cmbHourEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddToListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCancelLesson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}