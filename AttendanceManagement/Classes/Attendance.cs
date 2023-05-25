using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagement.Classes
{
    public class Attendance
    {
        public int attendanceId { get; set; }
        public int studentId { get; set; }
        public int courseId { get; set; }
        public DateTime date { get; set; }
        public bool isPresent { get; set; }
    }
}
