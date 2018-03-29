using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.micropay.order.unfreeze
    /// </summary>
    public class AlipayMicropayOrderUnfreezeRequest : IAopRequest<AlipayMicropayOrderUnfreezeResponse>
    {
        /// <summary>
        /// 冻结资金流水号,在创建资金订单时支付宝返回的流水号
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 冻结备注
        /// </summary>
        public string Memo { get; set; }

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
            return "alipay.micropay.order.unfreeze";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("memo", this.Memo);
            return parameters;
        }

        #endregion
    }
}
