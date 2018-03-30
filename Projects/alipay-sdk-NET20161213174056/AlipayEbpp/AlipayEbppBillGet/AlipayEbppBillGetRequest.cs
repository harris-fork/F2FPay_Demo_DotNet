using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.bill.get
    /// </summary>
    public class AlipayEbppBillGetRequest : IAopRequest<AlipayEbppBillGetResponse>
    {
        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        public string OrderType { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ebpp.bill.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("order_type", this.OrderType);
            return parameters;
        }

        #endregion
    }
}
