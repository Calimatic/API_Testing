using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon
{
    public class ErrorHandler_PaymentCommon
    {
      public ErrorHandler_PaymentCommon response { get; set; }
      public bool isSuccessful { get; set; }
      public int statusCode { get; set; }
      public object id { get; set; }
      public object firstName { get; set; }
      public object lastName { get; set; }
      public object userName { get; set; }
      public bool isExist { get; set; }
    }
    public class Root_ErrorHandler_DuplicateUserName
    {
      public ErrorHandler_PaymentCommon response { get; set; }
      public bool isSuccessful { get; set; }
      public int statusCode { get; set; }
    }
}
