using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Board.Board_student
{
    public class Board_student_Response
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class Root_Board_student_Response
    {
        public List<Board_student_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_student
    {
        public static Root_Board_student_Response sets_student { get; set; }
        public static void set_student(Root_Board_student_Response value)
        {
            sets_student = value;
        }
    }
}