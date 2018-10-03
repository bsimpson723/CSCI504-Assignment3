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
            this.oneStudentGradeReport_label = new System.Windows.Forms.Label();
            this.zID_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showStudentGradeReport_button = new System.Windows.Forms.Button();
            this.oneCourseGradeThresh_label = new System.Windows.Forms.Label();
            this.showCourseThreshReport_button = new System.Windows.Forms.Button();
            this.showCourseFailReport_button = new System.Windows.Forms.Button();
            this.showFailedStudents_button = new System.Windows.Forms.Button();
            this.showCourseGradeReport_button = new System.Windows.Forms.Button();
            this.showCoursePassReport_button = new System.Windows.Forms.Button();
            this.courseThresholdLessThan_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseThresholdGreaterThan_radio = new System.Windows.Forms.RadioButton();
            this.threshGrade_combo = new System.Windows.Forms.ComboBox();
            this.threshGrade_label = new System.Windows.Forms.Label();
            this.threshCourse_label = new System.Windows.Forms.Label();
            this.threshCourse_textBox = new System.Windows.Forms.TextBox();
            this.failedByMajor_label = new System.Windows.Forms.Label();
            this.major_label = new System.Windows.Forms.Label();
            this.major_combo = new System.Windows.Forms.ComboBox();
            this.failedStudentsCourse_label = new System.Windows.Forms.Label();
            this.failedStudentsCourse_textBox = new System.Windows.Forms.TextBox();
            this.gradeReportCourse_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.percentage_upDown = new System.Windows.Forms.NumericUpDown();
            this.percentage_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // oneStudentGradeReport_label
            // 
            this.oneStudentGradeReport_label.AutoSize = true;
            this.oneStudentGradeReport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneStudentGradeReport_label.Location = new System.Drawing.Point(12, 16);
            this.oneStudentGradeReport_label.Name = "oneStudentGradeReport_label";
            this.oneStudentGradeReport_label.Size = new System.Drawing.Size(228, 17);
            this.oneStudentGradeReport_label.TabIndex = 2;
            this.oneStudentGradeReport_label.Text = "Grade Report for One Student";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 4;
            // 
            // showStudentGradeReport_button
            // 
            this.showStudentGradeReport_button.Location = new System.Drawing.Point(375, 39);
            this.showStudentGradeReport_button.Name = "showStudentGradeReport_button";
            this.showStudentGradeReport_button.Size = new System.Drawing.Size(97, 21);
            this.showStudentGradeReport_button.TabIndex = 5;
            this.showStudentGradeReport_button.Text = "Show Results";
            this.showStudentGradeReport_button.UseVisualStyleBackColor = true;
            // 
            // oneCourseGradeThresh_label
            // 
            this.oneCourseGradeThresh_label.AutoSize = true;
            this.oneCourseGradeThresh_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneCourseGradeThresh_label.Location = new System.Drawing.Point(12, 90);
            this.oneCourseGradeThresh_label.Name = "oneCourseGradeThresh_label";
            this.oneCourseGradeThresh_label.Size = new System.Drawing.Size(247, 17);
            this.oneCourseGradeThresh_label.TabIndex = 6;
            this.oneCourseGradeThresh_label.Text = "Grade Threshold for One Course";
            // 
            // showCourseThreshReport_button
            // 
            this.showCourseThreshReport_button.Location = new System.Drawing.Point(375, 158);
            this.showCourseThreshReport_button.Name = "showCourseThreshReport_button";
            this.showCourseThreshReport_button.Size = new System.Drawing.Size(97, 21);
            this.showCourseThreshReport_button.TabIndex = 7;
            this.showCourseThreshReport_button.Text = "Show Results";
            this.showCourseThreshReport_button.UseVisualStyleBackColor = true;
            // 
            // showCourseFailReport_button
            // 
            this.showCourseFailReport_button.Location = new System.Drawing.Point(375, 374);
            this.showCourseFailReport_button.Name = "showCourseFailReport_button";
            this.showCourseFailReport_button.Size = new System.Drawing.Size(97, 20);
            this.showCourseFailReport_button.TabIndex = 8;
            this.showCourseFailReport_button.Text = "Show Results";
            this.showCourseFailReport_button.UseVisualStyleBackColor = true;
            // 
            // showFailedStudents_button
            // 
            this.showFailedStudents_button.Location = new System.Drawing.Point(375, 260);
            this.showFailedStudents_button.Name = "showFailedStudents_button";
            this.showFailedStudents_button.Size = new System.Drawing.Size(97, 20);
            this.showFailedStudents_button.TabIndex = 9;
            this.showFailedStudents_button.Text = "Show Results";
            this.showFailedStudents_button.UseVisualStyleBackColor = true;
            // 
            // showCourseGradeReport_button
            // 
            this.showCourseGradeReport_button.Location = new System.Drawing.Point(375, 592);
            this.showCourseGradeReport_button.Name = "showCourseGradeReport_button";
            this.showCourseGradeReport_button.Size = new System.Drawing.Size(97, 20);
            this.showCourseGradeReport_button.TabIndex = 10;
            this.showCourseGradeReport_button.Text = "Show Results";
            this.showCourseGradeReport_button.UseVisualStyleBackColor = true;
            // 
            // showCoursePassReport_button
            // 
            this.showCoursePassReport_button.Location = new System.Drawing.Point(375, 486);
            this.showCoursePassReport_button.Name = "showCoursePassReport_button";
            this.showCoursePassReport_button.Size = new System.Drawing.Size(97, 20);
            this.showCoursePassReport_button.TabIndex = 11;
            this.showCoursePassReport_button.Text = "Show Results";
            this.showCoursePassReport_button.UseVisualStyleBackColor = true;
            // 
            // courseThresholdLessThan_radio
            // 
            this.courseThresholdLessThan_radio.AutoSize = true;
            this.courseThresholdLessThan_radio.Location = new System.Drawing.Point(6, 19);
            this.courseThresholdLessThan_radio.Name = "courseThresholdLessThan_radio";
            this.courseThresholdLessThan_radio.Size = new System.Drawing.Size(133, 17);
            this.courseThresholdLessThan_radio.TabIndex = 12;
            this.courseThresholdLessThan_radio.TabStop = true;
            this.courseThresholdLessThan_radio.Text = "Less Than or Equal To";
            this.courseThresholdLessThan_radio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseThresholdGreaterThan_radio);
            this.groupBox1.Controls.Add(this.courseThresholdLessThan_radio);
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // courseThresholdGreaterThan_radio
            // 
            this.courseThresholdGreaterThan_radio.AutoSize = true;
            this.courseThresholdGreaterThan_radio.Location = new System.Drawing.Point(6, 42);
            this.courseThresholdGreaterThan_radio.Name = "courseThresholdGreaterThan_radio";
            this.courseThresholdGreaterThan_radio.Size = new System.Drawing.Size(146, 17);
            this.courseThresholdGreaterThan_radio.TabIndex = 13;
            this.courseThresholdGreaterThan_radio.TabStop = true;
            this.courseThresholdGreaterThan_radio.Text = "Greater Than or Equal To";
            this.courseThresholdGreaterThan_radio.UseVisualStyleBackColor = true;
            // 
            // threshGrade_combo
            // 
            this.threshGrade_combo.FormattingEnabled = true;
            this.threshGrade_combo.Location = new System.Drawing.Point(176, 158);
            this.threshGrade_combo.Name = "threshGrade_combo";
            this.threshGrade_combo.Size = new System.Drawing.Size(38, 21);
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
            // failedByMajor_label
            // 
            this.failedByMajor_label.AutoSize = true;
            this.failedByMajor_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedByMajor_label.Location = new System.Drawing.Point(12, 217);
            this.failedByMajor_label.Name = "failedByMajor_label";
            this.failedByMajor_label.Size = new System.Drawing.Size(274, 17);
            this.failedByMajor_label.TabIndex = 18;
            this.failedByMajor_label.Text = "Major Students Who Failed A Course";
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
            // 
            // failedStudentsCourse_label
            // 
            this.failedStudentsCourse_label.AutoSize = true;
            this.failedStudentsCourse_label.Location = new System.Drawing.Point(226, 244);
            this.failedStudentsCourse_label.Name = "failedStudentsCourse_label";
            this.failedStudentsCourse_label.Size = new System.Drawing.Size(40, 13);
            this.failedStudentsCourse_label.TabIndex = 21;
            this.failedStudentsCourse_label.Text = "Course";
            // 
            // failedStudentsCourse_textBox
            // 
            this.failedStudentsCourse_textBox.Location = new System.Drawing.Point(229, 260);
            this.failedStudentsCourse_textBox.Name = "failedStudentsCourse_textBox";
            this.failedStudentsCourse_textBox.Size = new System.Drawing.Size(140, 20);
            this.failedStudentsCourse_textBox.TabIndex = 22;
            // 
            // gradeReportCourse_label
            // 
            this.gradeReportCourse_label.AutoSize = true;
            this.gradeReportCourse_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeReportCourse_label.Location = new System.Drawing.Point(12, 332);
            this.gradeReportCourse_label.Name = "gradeReportCourse_label";
            this.gradeReportCourse_label.Size = new System.Drawing.Size(223, 17);
            this.gradeReportCourse_label.TabIndex = 23;
            this.gradeReportCourse_label.Text = "Grade Report for One Course";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Course";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 374);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fail Report For All Courses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(15, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 70);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(146, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Greater Than or Equal To";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Less Than or Equal To";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fail Report For All Courses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(15, 542);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 70);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(146, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Greater Than or Equal To";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(133, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Less Than or Equal To";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Grade";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 591);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(38, 21);
            this.comboBox1.TabIndex = 30;
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradeReportCourse_label);
            this.Controls.Add(this.failedStudentsCourse_textBox);
            this.Controls.Add(this.failedStudentsCourse_label);
            this.Controls.Add(this.major_combo);
            this.Controls.Add(this.major_label);
            this.Controls.Add(this.failedByMajor_label);
            this.Controls.Add(this.threshCourse_textBox);
            this.Controls.Add(this.threshCourse_label);
            this.Controls.Add(this.threshGrade_label);
            this.Controls.Add(this.threshGrade_combo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showCoursePassReport_button);
            this.Controls.Add(this.showCourseGradeReport_button);
            this.Controls.Add(this.showFailedStudents_button);
            this.Controls.Add(this.showCourseFailReport_button);
            this.Controls.Add(this.showCourseThreshReport_button);
            this.Controls.Add(this.oneCourseGradeThresh_label);
            this.Controls.Add(this.showStudentGradeReport_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zID_label);
            this.Controls.Add(this.oneStudentGradeReport_label);
            this.Controls.Add(this.queryResult_label);
            this.Controls.Add(this.queryResult_textBox);
            this.Name = "Form1";
            this.Text = "NIU Academic Performance Query System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label oneStudentGradeReport_label;
        private System.Windows.Forms.Label zID_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showStudentGradeReport_button;
        private System.Windows.Forms.Label oneCourseGradeThresh_label;
        private System.Windows.Forms.Button showCourseThreshReport_button;
        private System.Windows.Forms.Button showCourseFailReport_button;
        private System.Windows.Forms.Button showFailedStudents_button;
        private System.Windows.Forms.Button showCourseGradeReport_button;
        private System.Windows.Forms.Button showCoursePassReport_button;
        private System.Windows.Forms.RadioButton courseThresholdLessThan_radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton courseThresholdGreaterThan_radio;
        private System.Windows.Forms.ComboBox threshGrade_combo;
        private System.Windows.Forms.Label threshGrade_label;
        private System.Windows.Forms.Label threshCourse_label;
        private System.Windows.Forms.TextBox threshCourse_textBox;
        private System.Windows.Forms.Label failedByMajor_label;
        private System.Windows.Forms.Label major_label;
        private System.Windows.Forms.ComboBox major_combo;
        private System.Windows.Forms.Label failedStudentsCourse_label;
        private System.Windows.Forms.TextBox failedStudentsCourse_textBox;
        private System.Windows.Forms.Label gradeReportCourse_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown percentage_upDown;
        private System.Windows.Forms.Label percentage_label;
    }
}

