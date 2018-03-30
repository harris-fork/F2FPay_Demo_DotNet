using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.bill.payurl.get
    /// </summary>
    public class AlipayEbppBillPayurlGetRequest : IAopRequest<AlipayEbppBillPayurlGetResponse>
    {
        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 回调系统url
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK。
        /// </summary>
        public string OrderType { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ebpp.bill.payurl.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("callback_url", this.CallbackUrl);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("order_type", this.OrderType);
            return parameters;
        }

        #endregion
    }
}
