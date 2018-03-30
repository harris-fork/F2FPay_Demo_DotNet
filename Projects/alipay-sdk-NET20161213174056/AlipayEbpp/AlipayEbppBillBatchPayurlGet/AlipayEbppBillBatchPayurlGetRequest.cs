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

        public override string GetApiName()
        {
            return "alipay.ebpp.bill.batch.payurl.get";
        }

        public override IDictionary<string, string> GetParameters()
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
