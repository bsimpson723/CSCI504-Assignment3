namespace Assignment3
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.queryResult_textBox = new System.Windows.Forms.RichTextBox();
            this.queryResult_label = new System.Windows.Forms.Label();
            this.gradeReportStudent_label = new System.Windows.Forms.Label();
            this.zID_label = new System.Windows.Forms.Label();
            this.zID_textBox = new System.Windows.Forms.TextBox();
            this.showGradeReportStudent_button = new System.Windows.Forms.Button();
            this.gradeThresh_label = new System.Windows.Forms.Label();
            this.showGradeThresh_button = new System.Windows.Forms.Button();
            this.showGradeReportCourse_button = new System.Windows.Forms.Button();
            this.showFailedByMajorReport_button = new System.Windows.Forms.Button();
            this.showAllPassReport_button = new System.Windows.Forms.Button();
            this.showAllFailReport_button = new System.Windows.Forms.Button();
            this.threshLessThan_radio = new System.Windows.Forms.RadioButton();
            this.threshRadio_groupBox = new System.Windows.Forms.GroupBox();
            this.threshGreaterThan_radio = new System.Windows.Forms.RadioButton();
            this.threshGrade_combo = new System.Windows.Forms.ComboBox();
            this.threshGrade_label = new System.Windows.Forms.Label();
            this.threshCourse_label = new System.Windows.Forms.Label();
            this.threshCourse_textBox = new System.Windows.Forms.TextBox();
            this.failedCourseByMajor_label = new System.Windows.Forms.Label();
            this.major_label = new System.Windows.Forms.Label();
            this.major_combo = new System.Windows.Forms.ComboBox();
            this.failedByMajorCourse_label = new System.Windows.Forms.Label();
            this.failedByMajorCourse_textBox = new System.Windows.Forms.TextBox();
            this.gradeReportByCourse_label = new System.Windows.Forms.Label();
            this.gradeReportByCourseInput_label = new System.Windows.Forms.Label();
            this.gradeReportByCourseInput_textBox = new System.Windows.Forms.TextBox();
            this.failReport_label = new System.Windows.Forms.Label();
            this.failRadio_groupBox = new System.Windows.Forms.GroupBox();
            this.failGreaterThan_radio = new System.Windows.Forms.RadioButton();
            this.failLessThan_radio = new System.Windows.Forms.RadioButton();
            this.passReport_label = new System.Windows.Forms.Label();
            this.passRadio_groupBox = new System.Windows.Forms.GroupBox();
            this.passGreaterThan_radio = new System.Windows.Forms.RadioButton();
            this.passLessThan_radio = new System.Windows.Forms.RadioButton();
            this.passGrade_label = new System.Windows.Forms.Label();
            this.passGrade_combo = new System.Windows.Forms.ComboBox();
            this.percentage_upDown = new System.Windows.Forms.NumericUpDown();
            this.percentage_label = new System.Windows.Forms.Label();
            this.threshRadio_groupBox.SuspendLayout();
            this.failRadio_groupBox.SuspendLayout();
            this.passRadio_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentage_upDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 0;
            // 
            // listBox3
            // 
            this.listBox3.Location = new System.Drawing.Point(0, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 0;
            // 
            // queryResult_textBox
            // 
            this.queryResult_textBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryResult_textBox.Location = new System.Drawing.Point(478, 39);
            this.queryResult_textBox.Name = "queryResult_textBox";
            this.queryResult_textBox.ReadOnly = true;
            this.queryResult_textBox.Size = new System.Drawing.Size(577, 629);
            this.queryResult_textBox.TabIndex = 0;
            this.queryResult_textBox.Text = "";
            // 
            // queryResult_label
            // 
            this.queryResult_label.AutoSize = true;
            this.queryResult_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryResult_label.Location = new System.Drawing.Point(474, 9);
            this.queryResult_label.Name = "queryResult_label";
            this.queryResult_label.Size = new System.Drawing.Size(141, 24);
            this.queryResult_label.TabIndex = 1;
            this.queryResult_label.Text = "Query Results";
            // 
            // gradeReportStudent_label
            // 
            this.gradeReportStudent_label.AutoSize = true;
            this.gradeReportStudent_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeReportStudent_label.Location = new System.Drawing.Point(12, 16);
            this.gradeReportStudent_label.Name = "gradeReportStudent_label";
            this.gradeReportStudent_label.Size = new System.Drawing.Size(228, 17);
            this.gradeReportStudent_label.TabIndex = 2;
            this.gradeReportStudent_label.Text = "Grade Report for One Student";
            // 
            // zID_label
            // 
            this.zID_label.AutoSize = true;
            this.zID_label.Location = new System.Drawing.Point(12, 43);
            this.zID_label.Name = "zID_label";
            this.zID_label.Size = new System.Drawing.Size(28, 13);
            this.zID_label.TabIndex = 3;
            this.zID_label.Text = "Z-ID";
            // 
            // zID_textBox
            // 
            this.zID_textBox.Location = new System.Drawing.Point(46, 40);
            this.zID_textBox.Name = "zID_textBox";
            this.zID_textBox.Size = new System.Drawing.Size(124, 20);
            this.zID_textBox.TabIndex = 4;
            // 
            // showGradeReportStudent_button
            // 
            this.showGradeReportStudent_button.Location = new System.Drawing.Point(375, 39);
            this.showGradeReportStudent_button.Name = "showGradeReportStudent_button";
            this.showGradeReportStudent_button.Size = new System.Drawing.Size(97, 21);
            this.showGradeReportStudent_button.TabIndex = 5;
            this.showGradeReportStudent_button.Text = "Show Results";
            this.showGradeReportStudent_button.UseVisualStyleBackColor = true;
            this.showGradeReportStudent_button.Click += new System.EventHandler(this.showGradeReportStudent_button_Click);
            // 
            // gradeThresh_label
            // 
            this.gradeThresh_label.AutoSize = true;
            this.gradeThresh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeThresh_label.Location = new System.Drawing.Point(12, 90);
            this.gradeThresh_label.Name = "gradeThresh_label";
            this.gradeThresh_label.Size = new System.Drawing.Size(247, 17);
            this.gradeThresh_label.TabIndex = 6;
            this.gradeThresh_label.Text = "Grade Threshold for One Course";
            // 
            // showGradeThresh_button
            // 
            this.showGradeThresh_button.Location = new System.Drawing.Point(375, 158);
            this.showGradeThresh_button.Name = "showGradeThresh_button";
            this.showGradeThresh_button.Size = new System.Drawing.Size(97, 21);
            this.showGradeThresh_button.TabIndex = 7;
            this.showGradeThresh_button.Text = "Show Results";
            this.showGradeThresh_button.UseVisualStyleBackColor = true;
            // 
            // showGradeReportCourse_button
            // 
            this.showGradeReportCourse_button.Location = new System.Drawing.Point(375, 374);
            this.showGradeReportCourse_button.Name = "showGradeReportCourse_button";
            this.showGradeReportCourse_button.Size = new System.Drawing.Size(97, 20);
            this.showGradeReportCourse_button.TabIndex = 8;
            this.showGradeReportCourse_button.Text = "Show Results";
            this.showGradeReportCourse_button.UseVisualStyleBackColor = true;
            // 
            // showFailedByMajorReport_button
            // 
            this.showFailedByMajorReport_button.Location = new System.Drawing.Point(375, 260);
            this.showFailedByMajorReport_button.Name = "showFailedByMajorReport_button";
            this.showFailedByMajorReport_button.Size = new System.Drawing.Size(97, 20);
            this.showFailedByMajorReport_button.TabIndex = 9;
            this.showFailedByMajorReport_button.Text = "Show Results";
            this.showFailedByMajorReport_button.UseVisualStyleBackColor = true;
            // 
            // showAllPassReport_button
            // 
            this.showAllPassReport_button.Location = new System.Drawing.Point(375, 592);
            this.showAllPassReport_button.Name = "showAllPassReport_button";
            this.showAllPassReport_button.Size = new System.Drawing.Size(97, 20);
            this.showAllPassReport_button.TabIndex = 10;
            this.showAllPassReport_button.Text = "Show Results";
            this.showAllPassReport_button.UseVisualStyleBackColor = true;
            // 
            // showAllFailReport_button
            // 
            this.showAllFailReport_button.Location = new System.Drawing.Point(375, 486);
            this.showAllFailReport_button.Name = "showAllFailReport_button";
            this.showAllFailReport_button.Size = new System.Drawing.Size(97, 20);
            this.showAllFailReport_button.TabIndex = 11;
            this.showAllFailReport_button.Text = "Show Results";
            this.showAllFailReport_button.UseVisualStyleBackColor = true;
            // 
            // threshLessThan_radio
            // 
            this.threshLessThan_radio.AutoSize = true;
            this.threshLessThan_radio.Location = new System.Drawing.Point(6, 19);
            this.threshLessThan_radio.Name = "threshLessThan_radio";
            this.threshLessThan_radio.Size = new System.Drawing.Size(133, 17);
            this.threshLessThan_radio.TabIndex = 12;
            this.threshLessThan_radio.TabStop = true;
            this.threshLessThan_radio.Text = "Less Than or Equal To";
            this.threshLessThan_radio.UseVisualStyleBackColor = true;
            // 
            // threshRadio_groupBox
            // 
            this.threshRadio_groupBox.Controls.Add(this.threshGreaterThan_radio);
            this.threshRadio_groupBox.Controls.Add(this.threshLessThan_radio);
            this.threshRadio_groupBox.Location = new System.Drawing.Point(15, 110);
            this.threshRadio_groupBox.Name = "threshRadio_groupBox";
            this.threshRadio_groupBox.Size = new System.Drawing.Size(155, 70);
            this.threshRadio_groupBox.TabIndex = 13;
            this.threshRadio_groupBox.TabStop = false;
            // 
            // threshGreaterThan_radio
            // 
            this.threshGreaterThan_radio.AutoSize = true;
            this.threshGreaterThan_radio.Location = new System.Drawing.Point(6, 42);
            this.threshGreaterThan_radio.Name = "threshGreaterThan_radio";
            this.threshGreaterThan_radio.Size = new System.Drawing.Size(146, 17);
            this.threshGreaterThan_radio.TabIndex = 13;
            this.threshGreaterThan_radio.TabStop = true;
            this.threshGreaterThan_radio.Text = "Greater Than or Equal To";
            this.threshGreaterThan_radio.UseVisualStyleBackColor = true;
            // 
            // threshGrade_combo
            // 
            this.threshGrade_combo.FormattingEnabled = true;
            this.threshGrade_combo.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C++",
            "C",
            "C-",
            "D",
            "F"});
            this.threshGrade_combo.Location = new System.Drawing.Point(176, 158);
            this.threshGrade_combo.Name = "threshGrade_combo";
            this.threshGrade_combo.Size = new System.Drawing.Size(49, 21);
            this.threshGrade_combo.TabIndex = 14;
            // 
            // threshGrade_label
            // 
            this.threshGrade_label.AutoSize = true;
            this.threshGrade_label.Location = new System.Drawing.Point(173, 143);
            this.threshGrade_label.Name = "threshGrade_label";
            this.threshGrade_label.Size = new System.Drawing.Size(36, 13);
            this.threshGrade_label.TabIndex = 15;
            this.threshGrade_label.Text = "Grade";
            // 
            // threshCourse_label
            // 
            this.threshCourse_label.AutoSize = true;
            this.threshCourse_label.Location = new System.Drawing.Point(226, 143);
            this.threshCourse_label.Name = "threshCourse_label";
            this.threshCourse_label.Size = new System.Drawing.Size(40, 13);
            this.threshCourse_label.TabIndex = 16;
            this.threshCourse_label.Text = "Course";
            // 
            // threshCourse_textBox
            // 
            this.threshCourse_textBox.Location = new System.Drawing.Point(229, 159);
            this.threshCourse_textBox.Name = "threshCourse_textBox";
            this.threshCourse_textBox.Size = new System.Drawing.Size(140, 20);
            this.threshCourse_textBox.TabIndex = 17;
            // 
            // failedCourseByMajor_label
            // 
            this.failedCourseByMajor_label.AutoSize = true;
            this.failedCourseByMajor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedCourseByMajor_label.Location = new System.Drawing.Point(12, 217);
            this.failedCourseByMajor_label.Name = "failedCourseByMajor_label";
            this.failedCourseByMajor_label.Size = new System.Drawing.Size(274, 17);
            this.failedCourseByMajor_label.TabIndex = 18;
            this.failedCourseByMajor_label.Text = "Major Students Who Failed A Course";
            // 
            // major_label
            // 
            this.major_label.AutoSize = true;
            this.major_label.Location = new System.Drawing.Point(12, 243);
            this.major_label.Name = "major_label";
            this.major_label.Size = new System.Drawing.Size(33, 13);
            this.major_label.TabIndex = 19;
            this.major_label.Text = "Major";
            // 
            // major_combo
            // 
            this.major_combo.FormattingEnabled = true;
            this.major_combo.Location = new System.Drawing.Point(15, 259);
            this.major_combo.Name = "major_combo";
            this.major_combo.Size = new System.Drawing.Size(121, 21);
            this.major_combo.TabIndex = 20;
            this.major_combo.Text = "-- Select Major --";
            // 
            // failedByMajorCourse_label
            // 
            this.failedByMajorCourse_label.AutoSize = true;
            this.failedByMajorCourse_label.Location = new System.Drawing.Point(226, 244);
            this.failedByMajorCourse_label.Name = "failedByMajorCourse_label";
            this.failedByMajorCourse_label.Size = new System.Drawing.Size(40, 13);
            this.failedByMajorCourse_label.TabIndex = 21;
            this.failedByMajorCourse_label.Text = "Course";
            // 
            // failedByMajorCourse_textBox
            // 
            this.failedByMajorCourse_textBox.Location = new System.Drawing.Point(229, 260);
            this.failedByMajorCourse_textBox.Name = "failedByMajorCourse_textBox";
            this.failedByMajorCourse_textBox.Size = new System.Drawing.Size(140, 20);
            this.failedByMajorCourse_textBox.TabIndex = 22;
            // 
            // gradeReportByCourse_label
            // 
            this.gradeReportByCourse_label.AutoSize = true;
            this.gradeReportByCourse_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeReportByCourse_label.Location = new System.Drawing.Point(12, 332);
            this.gradeReportByCourse_label.Name = "gradeReportByCourse_label";
            this.gradeReportByCourse_label.Size = new System.Drawing.Size(223, 17);
            this.gradeReportByCourse_label.TabIndex = 23;
            this.gradeReportByCourse_label.Text = "Grade Report for One Course";
            // 
            // gradeReportByCourseInput_label
            // 
            this.gradeReportByCourseInput_label.AutoSize = true;
            this.gradeReportByCourseInput_label.Location = new System.Drawing.Point(12, 358);
            this.gradeReportByCourseInput_label.Name = "gradeReportByCourseInput_label";
            this.gradeReportByCourseInput_label.Size = new System.Drawing.Size(40, 13);
            this.gradeReportByCourseInput_label.TabIndex = 24;
            this.gradeReportByCourseInput_label.Text = "Course";
            // 
            // gradeReportByCourseInput_textBox
            // 
            this.gradeReportByCourseInput_textBox.Location = new System.Drawing.Point(15, 374);
            this.gradeReportByCourseInput_textBox.Name = "gradeReportByCourseInput_textBox";
            this.gradeReportByCourseInput_textBox.Size = new System.Drawing.Size(140, 20);
            this.gradeReportByCourseInput_textBox.TabIndex = 25;
            // 
            // failReport_label
            // 
            this.failReport_label.AutoSize = true;
            this.failReport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failReport_label.Location = new System.Drawing.Point(12, 416);
            this.failReport_label.Name = "failReport_label";
            this.failReport_label.Size = new System.Drawing.Size(204, 17);
            this.failReport_label.TabIndex = 26;
            this.failReport_label.Text = "Fail Report For All Courses";
            // 
            // failRadio_groupBox
            // 
            this.failRadio_groupBox.Controls.Add(this.failGreaterThan_radio);
            this.failRadio_groupBox.Controls.Add(this.failLessThan_radio);
            this.failRadio_groupBox.Location = new System.Drawing.Point(15, 436);
            this.failRadio_groupBox.Name = "failRadio_groupBox";
            this.failRadio_groupBox.Size = new System.Drawing.Size(155, 70);
            this.failRadio_groupBox.TabIndex = 27;
            this.failRadio_groupBox.TabStop = false;
            // 
            // failGreaterThan_radio
            // 
            this.failGreaterThan_radio.AutoSize = true;
            this.failGreaterThan_radio.Location = new System.Drawing.Point(6, 42);
            this.failGreaterThan_radio.Name = "failGreaterThan_radio";
            this.failGreaterThan_radio.Size = new System.Drawing.Size(146, 17);
            this.failGreaterThan_radio.TabIndex = 13;
            this.failGreaterThan_radio.TabStop = true;
            this.failGreaterThan_radio.Text = "Greater Than or Equal To";
            this.failGreaterThan_radio.UseVisualStyleBackColor = true;
            // 
            // failLessThan_radio
            // 
            this.failLessThan_radio.AutoSize = true;
            this.failLessThan_radio.Location = new System.Drawing.Point(6, 19);
            this.failLessThan_radio.Name = "failLessThan_radio";
            this.failLessThan_radio.Size = new System.Drawing.Size(133, 17);
            this.failLessThan_radio.TabIndex = 12;
            this.failLessThan_radio.TabStop = true;
            this.failLessThan_radio.Text = "Less Than or Equal To";
            this.failLessThan_radio.UseVisualStyleBackColor = true;
            // 
            // passReport_label
            // 
            this.passReport_label.AutoSize = true;
            this.passReport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passReport_label.Location = new System.Drawing.Point(12, 522);
            this.passReport_label.Name = "passReport_label";
            this.passReport_label.Size = new System.Drawing.Size(213, 17);
            this.passReport_label.TabIndex = 28;
            this.passReport_label.Text = "Pass Report For All Courses";
            // 
            // passRadio_groupBox
            // 
            this.passRadio_groupBox.Controls.Add(this.passGreaterThan_radio);
            this.passRadio_groupBox.Controls.Add(this.passLessThan_radio);
            this.passRadio_groupBox.Location = new System.Drawing.Point(15, 542);
            this.passRadio_groupBox.Name = "passRadio_groupBox";
            this.passRadio_groupBox.Size = new System.Drawing.Size(155, 70);
            this.passRadio_groupBox.TabIndex = 28;
            this.passRadio_groupBox.TabStop = false;
            // 
            // passGreaterThan_radio
            // 
            this.passGreaterThan_radio.AutoSize = true;
            this.passGreaterThan_radio.Location = new System.Drawing.Point(6, 42);
            this.passGreaterThan_radio.Name = "passGreaterThan_radio";
            this.passGreaterThan_radio.Size = new System.Drawing.Size(146, 17);
            this.passGreaterThan_radio.TabIndex = 13;
            this.passGreaterThan_radio.TabStop = true;
            this.passGreaterThan_radio.Text = "Greater Than or Equal To";
            this.passGreaterThan_radio.UseVisualStyleBackColor = true;
            // 
            // passLessThan_radio
            // 
            this.passLessThan_radio.AutoSize = true;
            this.passLessThan_radio.Location = new System.Drawing.Point(6, 19);
            this.passLessThan_radio.Name = "passLessThan_radio";
            this.passLessThan_radio.Size = new System.Drawing.Size(133, 17);
            this.passLessThan_radio.TabIndex = 12;
            this.passLessThan_radio.TabStop = true;
            this.passLessThan_radio.Text = "Less Than or Equal To";
            this.passLessThan_radio.UseVisualStyleBackColor = true;
            // 
            // passGrade_label
            // 
            this.passGrade_label.AutoSize = true;
            this.passGrade_label.Location = new System.Drawing.Point(173, 575);
            this.passGrade_label.Name = "passGrade_label";
            this.passGrade_label.Size = new System.Drawing.Size(36, 13);
            this.passGrade_label.TabIndex = 29;
            this.passGrade_label.Text = "Grade";
            // 
            // passGrade_combo
            // 
            this.passGrade_combo.FormattingEnabled = true;
            this.passGrade_combo.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C++",
            "C",
            "C-",
            "D",
            "F"});
            this.passGrade_combo.Location = new System.Drawing.Point(176, 591);
            this.passGrade_combo.Name = "passGrade_combo";
            this.passGrade_combo.Size = new System.Drawing.Size(49, 21);
            this.passGrade_combo.TabIndex = 30;
            // 
            // percentage_upDown
            // 
            this.percentage_upDown.Location = new System.Drawing.Point(176, 486);
            this.percentage_upDown.Name = "percentage_upDown";
            this.percentage_upDown.Size = new System.Drawing.Size(49, 20);
            this.percentage_upDown.TabIndex = 31;
            // 
            // percentage_label
            // 
            this.percentage_label.AutoSize = true;
            this.percentage_label.Location = new System.Drawing.Point(173, 470);
            this.percentage_label.Name = "percentage_label";
            this.percentage_label.Size = new System.Drawing.Size(62, 13);
            this.percentage_label.TabIndex = 32;
            this.percentage_label.Text = "Percentage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 695);
            this.Controls.Add(this.percentage_label);
            this.Controls.Add(this.percentage_upDown);
            this.Controls.Add(this.passGrade_combo);
            this.Controls.Add(this.passGrade_label);
            this.Controls.Add(this.passRadio_groupBox);
            this.Controls.Add(this.passReport_label);
            this.Controls.Add(this.failRadio_groupBox);
            this.Controls.Add(this.failReport_label);
            this.Controls.Add(this.gradeReportByCourseInput_textBox);
            this.Controls.Add(this.gradeReportByCourseInput_label);
            this.Controls.Add(this.gradeReportByCourse_label);
            this.Controls.Add(this.failedByMajorCourse_textBox);
            this.Controls.Add(this.failedByMajorCourse_label);
            this.Controls.Add(this.major_combo);
            this.Controls.Add(this.major_label);
            this.Controls.Add(this.failedCourseByMajor_label);
            this.Controls.Add(this.threshCourse_textBox);
            this.Controls.Add(this.threshCourse_label);
            this.Controls.Add(this.threshGrade_label);
            this.Controls.Add(this.threshGrade_combo);
            this.Controls.Add(this.threshRadio_groupBox);
            this.Controls.Add(this.showAllFailReport_button);
            this.Controls.Add(this.showAllPassReport_button);
            this.Controls.Add(this.showFailedByMajorReport_button);
            this.Controls.Add(this.showGradeReportCourse_button);
            this.Controls.Add(this.showGradeThresh_button);
            this.Controls.Add(this.gradeThresh_label);
            this.Controls.Add(this.showGradeReportStudent_button);
            this.Controls.Add(this.zID_textBox);
            this.Controls.Add(this.zID_label);
            this.Controls.Add(this.gradeReportStudent_label);
            this.Controls.Add(this.queryResult_label);
            this.Controls.Add(this.queryResult_textBox);
            this.Name = "Form1";
            this.Text = "NIU Academic Performance Query System";
            this.threshRadio_groupBox.ResumeLayout(false);
            this.threshRadio_groupBox.PerformLayout();
            this.failRadio_groupBox.ResumeLayout(false);
            this.failRadio_groupBox.PerformLayout();
            this.passRadio_groupBox.ResumeLayout(false);
            this.passRadio_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentage_upDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.RichTextBox queryResult_textBox;
        private System.Windows.Forms.Label queryResult_label;
        private System.Windows.Forms.Label gradeReportStudent_label;
        private System.Windows.Forms.Label zID_label;
        private System.Windows.Forms.TextBox zID_textBox;
        private System.Windows.Forms.Button showGradeReportStudent_button;
        private System.Windows.Forms.Label gradeThresh_label;
        private System.Windows.Forms.Button showGradeThresh_button;
        private System.Windows.Forms.Button showGradeReportCourse_button;
        private System.Windows.Forms.Button showFailedByMajorReport_button;
        private System.Windows.Forms.Button showAllPassReport_button;
        private System.Windows.Forms.Button showAllFailReport_button;
        private System.Windows.Forms.RadioButton threshLessThan_radio;
        private System.Windows.Forms.GroupBox threshRadio_groupBox;
        private System.Windows.Forms.RadioButton threshGreaterThan_radio;
        private System.Windows.Forms.ComboBox threshGrade_combo;
        private System.Windows.Forms.Label threshGrade_label;
        private System.Windows.Forms.Label threshCourse_label;
        private System.Windows.Forms.TextBox threshCourse_textBox;
        private System.Windows.Forms.Label failedCourseByMajor_label;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.ComboBox major_combo;
        private System.Windows.Forms.Label failedByMajorCourse_label;
        private System.Windows.Forms.TextBox failedByMajorCourse_textBox;
        private System.Windows.Forms.Label gradeReportByCourse_label;
        private System.Windows.Forms.Label gradeReportByCourseInput_label;
        private System.Windows.Forms.TextBox gradeReportByCourseInput_textBox;
        private System.Windows.Forms.Label failReport_label;
        private System.Windows.Forms.GroupBox failRadio_groupBox;
        private System.Windows.Forms.RadioButton failGreaterThan_radio;
        private System.Windows.Forms.RadioButton failLessThan_radio;
        private System.Windows.Forms.Label passReport_label;
        private System.Windows.Forms.GroupBox passRadio_groupBox;
        private System.Windows.Forms.RadioButton passGreaterThan_radio;
        private System.Windows.Forms.RadioButton passLessThan_radio;
        private System.Windows.Forms.Label passGrade_label;
        private System.Windows.Forms.ComboBox passGrade_combo;
        private System.Windows.Forms.NumericUpDown percentage_upDown;
        private System.Windows.Forms.Label percentage_label;
    }
}

