using System;
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
    }
}
