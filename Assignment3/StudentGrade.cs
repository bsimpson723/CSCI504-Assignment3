using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class StudentGrade
    {
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

        public StudentGrade(uint? zId, string departmentCode, uint? courseNum, string grade)
        {
            ZId = zId;
            DepartmentCode = departmentCode;
            CourseNumber = courseNum;
            Grade = grade;
        }
    }
}
