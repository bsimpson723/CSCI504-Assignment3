﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            foreach (string mj in Program.m_majors)
            {
                major_combo.Items.Add(mj);
            }
        }

        private void showGradeReportStudent_button_Click(object sender, EventArgs e)
        {
            //If the user didn't enter a Z-ID display error and return
            if (zID_textBox.Text.Length == 0)
            {
                queryResult_textBox.Text = "Error: Please enter a Z-ID to search by.";
                return;
            }

            //Get Z-ID from input text box and format it
            var zid = zID_textBox.Text.ToLower();
            if (zid[0] == 'z') //strip z from input in case it was entered
            {
                zid = zid.Substring(1);
            }
            uint zidNum;

            //If the user didn't enter a VALID Z-ID display an error and return
            if (!uint.TryParse(zid, out zidNum) || zid.Length < 7) //zID must be at least 1000000
            {
                queryResult_textBox.Text = "Error: Please enter a valid Z-ID with at least seven digits.";
                return;
            }

            //Get List and Build String for query results box
            var builder = new StringBuilder();
            var gradeReportTitle = string.Format("Single Student Grade Report ({0})", zidNum);
            builder.Append(gradeReportTitle);
            builder.Append(Environment.NewLine);
            builder.Append("-------------------------------------------------------------------------");
            builder.Append(Environment.NewLine);
            var studentGrades = Program.m_studentGrades.ToList()
                .FindAll(x => x.ZId == zidNum)
                .OrderBy(x => x.DepartmentCode)
                .ThenBy(x => x.CourseNumber);
            if (!studentGrades.Any())
            {
                builder.Append("Student has no grades recoded at this time.");
            }
            else
            {
                foreach (var grade in studentGrades)
                {
                    builder.Append(grade);
                    builder.Append(Environment.NewLine);
                }
            }
            builder.Append(Environment.NewLine);
            builder.Append("### END RESULTS ###");

            //Assign builder to rich text box
            queryResult_textBox.Text = builder.ToString();
        }

        private void showGradeThresh_button_Click(object sender, EventArgs e)
        {
            if (validateCourseEntry(threshCourse_textBox.Text))
            {
                var builder = new StringBuilder();
                string[] words = threshCourse_textBox.Text.Split(' ');
                var reportTitle = string.Format("Grade Threshold Report for ({0} {1})", words[0], words[1]);
                builder.Append(reportTitle);
                builder.Append(Environment.NewLine);
                builder.Append("-------------------------------------------------------------------------");
                builder.Append(Environment.NewLine);
                var grades = new List<StudentGrade>();
                if (threshLessThan_radio.Checked)
                {
                    grades = Program.m_studentGrades.ToList()
                        .FindAll(x => x.DepartmentCode == words[0] &&
                                      x.CourseNumber == Convert.ToUInt64(words[1]) &&
                                      x.Grade.CompareTo(threshGrade_combo.SelectedItem) >= 0)
                        .OrderBy(x => x.ZId).ToList();
                }
                else
                {
                    grades = Program.m_studentGrades.ToList()
                        .FindAll(x => x.DepartmentCode == words[0] &&
                                      x.CourseNumber == Convert.ToUInt64(words[1]) &&
                                      x.Grade.CompareTo(threshGrade_combo.SelectedItem) <= 0)
                        .OrderBy(x => x.ZId).ToList();
                }

                if (!grades.Any())
                {
                    builder.Append("No results match your query.");
                }
                foreach (var grade in grades)
                {
                    builder.Append(grade);
                    builder.Append(Environment.NewLine);
                }

                queryResult_textBox.Text = builder.ToString();
            }
        }

        private bool validateCourseEntry(string course)
        {
            string[] words = course.Split(' ');
            if (words.Length < 2)
            {
                //print error if input is not formatted correctly
                queryResult_textBox.Text = string.Format("'{0}' doesn't follow required format.", course);
                return false;
            }
            Course foundCourse = Program.m_courses.ToList().Find(x =>
                x.DepartmentCode.ToUpper() == words[0].ToUpper() && x.CourseNumber == Convert.ToUInt64(words[1]));
            // check whether found the course
            if (foundCourse == null)
            {
                queryResult_textBox.Text = string.Format("Course {0} does not exist.", course);
                return false;
            }

            return true;
        }
        
        private void showFailedByMajorReport_button_Click(object sender, EventArgs e)
        {
            // check whether selected a major
            if (major_combo.SelectedIndex == -1)
            {
                queryResult_textBox.Text = "Error: Please select a major to search by.";
                return;
            }

            // check whether typed course is valid
            if (!validateCourseEntry(failedByMajorCourse_textBox.Text))
            {
                return;
            }

            //Get List and Build String for query results box
            var builder = new StringBuilder();
            var failMajorReportTitle = String.Format("Fail Report of Majors ({0}) in {1}", major_combo.SelectedValue, failedByMajorCourse_textBox.Text);
            builder.Append(failMajorReportTitle);
            builder.Append(Environment.NewLine);
            builder.Append("-------------------------------------------------------------------------");
            builder.Append(Environment.NewLine);

            var majorStudents = Program.m_students.ToList()
                .FindAll(x => x.Major == major_combo.SelectedItem.ToString())
                .Select(x => x.ZId);

            String[] words = failedByMajorCourse_textBox.Text.Split(' ');
            var failMajorGrades = Program.m_studentGrades.ToList()
                .FindAll(x => x.DepartmentCode == words[0].ToUpper() && x.CourseNumber.ToString() == words[1] && x.Grade == "F")
                .FindAll(x => majorStudents.Contains(x.ZId))
                .OrderBy(x => x.ZId);

            // check whether matching grades empty
            if (!failMajorGrades.Any())
            {
                builder.Append("No student matched the query criteria.");
                builder.Append(Environment.NewLine);
            }
            else
            {
                foreach (var failed in failMajorGrades)
                {
                    builder.Append(failed);
                    builder.Append(Environment.NewLine);
                }
            }

            builder.Append(Environment.NewLine);
            builder.Append("### END RESULTS ###");

            // print appended stringbuilder to textbox
            queryResult_textBox.Text = builder.ToString();
        }
    }
}
