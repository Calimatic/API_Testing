using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.AddOnsManage.getFeeList
{
    public class getFeeList_Response
    {
        public string feeName { get; set; }
        public string studentName { get; set; }
        public string feeType { get; set; }
        public DateTime feeStartDate { get; set; }
        public DateTime feeEndDate { get; set; }
        public string billingCycle { get; set; }
        public bool autoDeduct { get; set; }
        public double origAmt { get; set; }
        public double discountAmt { get; set; }
        public string discountType { get; set; }
        public double totalAmt { get; set; }
        public int studentFeeId { get; set; }
        public int? billingCycleDuration { get; set; }
        public string courseType { get; set; }
        public string classes { get; set; }
    }
    public class Root_getFeeList_Response
    {
        public List<getFeeList_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class Apiresponse_getFeeList
    {
        public static Root_getFeeList_Response sets_getFeeList {  get; set; }
        public static void set_getFeeList(Root_getFeeList_Response response)
        {
            sets_getFeeList = response;
        }
    }
}