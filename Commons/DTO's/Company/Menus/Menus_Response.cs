using Commons.DTO_s.Company.CompanyNameByUserName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.Company.Menus
{
    public class Menus_Response
    {
        public string name { get; set; }
        public int code { get; set; }
        public string icon { get; set; }
        public bool hasSubMenu { get; set; }
        public string subMenuType { get; set; }
        public bool isDirectLink { get; set; }
        public List<SubMenu> subMenus { get; set; }
    }
    public class SubMenu
    {
        public string name { get; set; }
        public int code { get; set; }
        public string link { get; set; }
        public string linkB { get; set; }
        public int pagePermission { get; set; }
        public bool runFromV3 { get; set; }
    }
    public class Root_Menus_Response
    {
        public List<Menus_Response> response { get; set; }
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
    }
    //
    public class ApiResponse_Menus
    {
        // Public property to store the Main_Response value
        public static Root_Menus_Response Sets_Menus { get; set; }

        // Method to set the Main_Response value
        public static void Set_Menus(Root_Menus_Response value)
        {
            Sets_Menus = value;
        }
    }
}