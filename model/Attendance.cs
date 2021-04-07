using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAttendance.model
{
    class Attendance
    {

        public string TeacherId { get; set; }
        public string CourseId { get; set; }
        public string RoomId { get; set; }
        public String StartTime { get; set; }
        public String LeaveTime { get; set; }
        public String Comment { get; set; }

        public Attendance(string TeacherId,string CourseId, string RoomId, String StartTime, String LeaveTime, String Comment)
        {
            this.TeacherId = TeacherId;
            this.CourseId = CourseId;
            this.RoomId = RoomId;
            this.StartTime = StartTime;
            this.LeaveTime = LeaveTime;
            this.Comment = Comment;
        }

     
    }
}
