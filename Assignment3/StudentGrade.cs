/*
 * CSCI 504: Programming principles in .NET
 * Assignment 3
 * Benjamin Simpson - Z100820
 * Xueqiong Li - z1785226
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class StudentGrade
    {
        #region Properties
        private uint? courseNumber;
        private string departmentCode;
        public uint? ZId { get; set; }
        public string Grade { get; set; }

        public string DepartmentCode
        {
            get
            {
                return departmentCode;
            }
            set
            {
                if (value.Length <= 4 && value.Length > 0)
                {
                    departmentCode = value.ToUpper();
                }
            }
        }

        public uint? CourseNumber
        {
            get
            {
                return courseNumber;
            }
            set
            {
                if (value >= 100 && value <= 499)
                {
                    courseNumber = value;
                }
            }
        }
        #endregion

        // constructor
        public StudentGrade(uint? zId, string departmentCode, uint? courseNum, string grade)
        {
            ZId = zId;
            DepartmentCode = departmentCode;
            CourseNumber = courseNum;
            Grade = grade;
        }

        // orverride toString method
        public override string ToString()
        {
            return string.Format("z{0}  |  {1}-{2}  |  {3}", ZId, DepartmentCode, CourseNumber, Grade);
        }
    }
}
