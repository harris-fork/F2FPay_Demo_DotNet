using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.bill.batch.payurl.get
    /// </summary>
    public class AlipayEbppBillBatchPayurlGetRequest : IAopRequest<AlipayEbppBillBatchPayurlGetResponse>
    {
        /// <summary>
        /// 回调系统url
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// alipayOrderNo-merchantOrderNo即业务流水号和业务订单号
        /// </summary>
        public List<string> PayBillList { get; set; }

        #region IAopRequest Members
        public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
        public string TerminalType { get; set; }
        public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
        public string NotifyUrl { get; set; }
        public AopObject BizModel { get; set; }

        

        

        

        public string GetApiName()
        {
            return "alipay.ebpp.bill.batch.payurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("pay_bill_list", this.PayBillList);
            return parameters;
        }

        #endregion
    }
}
