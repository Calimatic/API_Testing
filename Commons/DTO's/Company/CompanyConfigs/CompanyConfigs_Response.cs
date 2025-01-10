using Commons.DTO_s.Notification.VisitNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.CompanyConfigs
{
    public class CompanyConfigs_Response
    {
        public string brandingTitle { get; set; }
        public string brandingFavicon { get; set; }
        public object loginLogo { get; set; }
        public string loginImage { get; set; }
        public string loginImageSize { get; set; }
        public string loginImageType { get; set; }
        public string companyLogo { get; set; }
        public string loginBgColor { get; set; }
        public string loginBgColorRight { get; set; }
        public string loginFontColor { get; set; }
        public object loginTemplate { get; set; }
        public string loginButtonColor { get; set; }
        public string bodyFontSize { get; set; }
        public string loginFirstSvg { get; set; }
        public string loginSecondSvg { get; set; }
        public string loginThirdSvg { get; set; }
        public string loginFourthSvg { get; set; }
        public string fontFamily { get; set; }
        public string primaryColor { get; set; }
        public string logoBg { get; set; }
        public string websiteLogoBg { get; set; }
    }
    public class Root_CompanyConfigs_Response
    {
        public CompanyConfigs_Response response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    // Main Response
    public class Root_CompanyConfigs
    {
        public object response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_CompanyConfigs
    {
        // Public property to store the Main_Response value
        public static Root_CompanyConfigs Sets_CompanyConfigs { get; set; }

        // Method to set the Main_Response value
        public static void Set_CompanyConfigs(Root_CompanyConfigs value)
        {
            Sets_CompanyConfigs = value;
        }
    }
}