﻿using Commons.DTO_s.Dashboards.Calender;
using Commons.DTO_s.PaymentCommon.GetTransactionConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon.GetAllEnrolledCourses
{
    public class Response_GetAllEnrolledCourses
    {
        public object response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class Root_GetAllEnrolledCourses
    {
        public Response_GetAllEnrolledCourses response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    public class ApiResponse_GetAllEnrolledCourses
    {
        // Public property to store the Main_Response value
        public static Root_GetAllEnrolledCourses Sets_GetAllEnrolledCourses { get; set; }

        // Method to set the Main_Response value
        public static void Set_GetAllEnrolledCourses(Root_GetAllEnrolledCourses value)
        {
            Sets_GetAllEnrolledCourses = value;
        }
    }
}