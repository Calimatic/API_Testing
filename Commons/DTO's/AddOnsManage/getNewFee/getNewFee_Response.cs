using Commons.DTO_s.Dashboards.Calender;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.AddOnsManage.getNewFee
{
    public class getNewFee_Response
    {
        public int feeTypeTd { get; set; }
        public DateTime feeStartDate { get; set; }
        public DateTime feeEndDate { get; set; }
        public int billingDuration { get; set; }
        public string discountType { get; set; }
        public bool isAutoDeduct { get; set; }
        public double originalAmt { get; set; }
        public string feeName { get; set; }
        public double discountAmt { get; set; }
        public double totalAmt { get; set; }
        public string notes { get; set; }
        public int studentFeeId { get; set; }
        public object rpPlanId { get; set; }
        public bool isAddonFee { get; set; }
        public int addOnType { get; set; }
        public bool showAddonFee { get; set; }
        public bool disableAddonFee { get; set; }
        public List<int> classesIds { get; set; }
        public List<FeeTypesList> feeTypesList { get; set; }
        public List<AddonCourseType> addonCourseTypes { get; set; }
        public List<Class> classes { get; set; }
    }

    // AddonCourseType
    public class AddonCourseType
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    // Class
    public class Class
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    // FeeTypesList
    public class FeeTypesList
    {
        public int feeTypeId { get; set; }
        public string feeTypeName { get; set; }
        public bool isForAddOn { get; set; }
    }

    // Main_Response
    public class Root_getNewFee_Response
    {
        public getNewFee_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_getNewFee
    {
        public static Root_getNewFee_Response sets_getNewFee {  get; set; }
        public static void set_getNewFee(Root_getNewFee_Response response)
        {
            sets_getNewFee = response;
        }
    }
}