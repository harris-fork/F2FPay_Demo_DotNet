using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.acquire.close
    /// </summary>
    public class AlipayAcquireCloseRequest : IAopRequest<AlipayAcquireCloseResponse>
    {
        /// <summary>
        /// 卖家的操作员ID
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 支付宝合作商户网站唯一订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。  最短16位，最长64位。  如果同时传了out_trade_no和trade_no，则以trade_no为准
        /// </summary>
        public string TradeNo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.acquire.close";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("operator_id", this.OperatorId);
            parameters.Add("out_trade_no", this.OutTradeNo);
            parameters.Add("trade_no", this.TradeNo);
            return parameters;
        }

        #endregion
    }
}
