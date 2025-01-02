using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.DTO_s.PaymentCommon.GetTransactionConfig
{
    public class Response_GetTransactionConfig
    {
       public Response_GetTransactionConfig response { get; set; }
       public bool isSuccessful { get; set; }
       public int statusCode { get; set; }
       public string stripeAccountName { get; set; }
       public int configId { get; set; }
       public string stripeSecretKey { get; set; }
       public string stripePublishableKey { get; set; }
       public object stripeWebhookSecretKey { get; set; }
       public string stripeClientKey { get; set; }
       public string plaidSecretKey { get; set; }
       public string plaidClientKey { get; set; }
       public string plaidPublicKey { get; set; }
       public string stripeAccountId { get; set; }
       public object stripeDashboardUrl { get; set; }
       public object plaidDashboardUrl { get; set; }
       public bool isDefaultStripeAccount { get; set; }
       public object stripeWebhookID { get; set; }
       public bool isAchAllow { get; set; }
       public bool isCreditCardAllow { get; set; }
       public int bankAccountConfigOpt { get; set; }
       public bool isStripeKeysValid { get; set; }
       public bool isPlaidKeysValid { get; set; }
       public int paymentGateway { get; set; }
       public object razorPayKeyId { get; set; }
       public object razorPayKeySecret { get; set; }
       public object razorPayDashboardUrl { get; set; }
       public object razorPayApiKeysUrl { get; set; }
       public string nmiapiKey { get; set; }
       public string nmiCollectJsKey { get; set; }
       public string plaidPaymentEnvironment { get; set; }
       public string plaidClientName { get; set; }
       public string currencyCode { get; set; }
       public int stripeConfigureOption { get; set; }
       public int companyPaymentGateway { get; set; }
    }
    public class Root_GetTransactionConfig
    {
       public Response_GetTransactionConfig response { get; set; }
       public bool isSuccessful { get; set; }
       public int statusCode { get; set; }
    }
    //
    public class ApiResponse_GetTransactionConfig
    {
        // Public property to store the Main_Response value
        public static Root_GetTransactionConfig Sets_GetTransactionConfig { get; set; }

        // Method to set the Main_Response value
        public static void Set_GetTransactionConfig(Root_GetTransactionConfig value)
        {
            Sets_GetTransactionConfig = value;
        }
    }
}