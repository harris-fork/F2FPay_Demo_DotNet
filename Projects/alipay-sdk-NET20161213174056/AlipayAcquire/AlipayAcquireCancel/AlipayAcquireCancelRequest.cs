using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.acquire.cancel
    /// </summary>
    public class AlipayAcquireCancelRequest : IAopRequest<AlipayAcquireCancelResponse>
    {
        /// <summary>
        /// 操作员ID。
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员的类型：  0：支付宝操作员  1：商户的操作员  如果传入其它值或者为空，则默认设置为1
        /// </summary>
        public string OperatorType { get; set; }

        /// <summary>
        /// 支付宝合作商户网站唯一订单号。
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。  最短16位，最长64位。  如果同时传了out_trade_no和trade_no，则以trade_no为准。
        /// </summary>
        public string TradeNo { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.acquire.cancel";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("operator_id", this.OperatorId);
            parameters.Add("operator_type", this.OperatorType);
            parameters.Add("out_trade_no", this.OutTradeNo);
            parameters.Add("trade_no", this.TradeNo);
            return parameters;
        }

        #endregion
    }
}