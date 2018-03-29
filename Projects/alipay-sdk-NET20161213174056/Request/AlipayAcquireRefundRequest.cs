using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.acquire.refund
    /// </summary>
    public class AlipayAcquireRefundRequest : IAopRequest<AlipayAcquireRefundResponse>
    {
        /// <summary>
        /// 卖家的操作员ID。
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员的类型：  0：支付宝操作员  1：商户的操作员  如果传入其它值或者为空，则默认设置为1。
        /// </summary>
        public string OperatorType { get; set; }

        /// <summary>
        /// 商户退款请求单号，用以标识本次交易的退款请求。  如果不传入本参数，则以out_trade_no填充本参数的值。同时，认为本次请求为全额退款，要求退款金额和交易支付金额一致。
        /// </summary>
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户网站唯一订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 业务关联ID集合，用于放置商户的退款单号、退款流水号等信息，json格式
        /// </summary>
        public string RefIds { get; set; }

        /// <summary>
        /// 退款金额；退款金额不能大于订单金额，全额退款必须与订单金额一致。
        /// </summary>
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因说明。
        /// </summary>
        public string RefundReason { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。  最短16位，最长64位。  如果同时传了out_trade_no和trade_no，则以trade_no为准
        /// </summary>
        public string TradeNo { get; set; }

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
            return "alipay.acquire.refund";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("operator_id", this.OperatorId);
            parameters.Add("operator_type", this.OperatorType);
            parameters.Add("out_request_no", this.OutRequestNo);
            parameters.Add("out_trade_no", this.OutTradeNo);
            parameters.Add("ref_ids", this.RefIds);
            parameters.Add("refund_amount", this.RefundAmount);
            parameters.Add("refund_reason", this.RefundReason);
            parameters.Add("trade_no", this.TradeNo);
            return parameters;
        }

        #endregion
    }
}
