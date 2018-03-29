using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.micropay.order.direct.pay
    /// </summary>
    public class AlipayMicropayOrderDirectPayRequest : IAopRequest<AlipayMicropayOrderDirectPayResponse>
    {
        /// <summary>
        /// 支付宝订单号，冻结流水号.这个是创建冻结订单支付宝返回的
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付金额,区间必须在[0.01,30]，只能保留小数点后两位
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 收款方的支付宝ID
        /// </summary>
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 本次转账的外部单据号（只能由字母和数字组成,maxlength=32
        /// </summary>
        public string TransferOutOrderNo { get; set; }

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
            return "alipay.micropay.order.direct.pay";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("amount", this.Amount);
            parameters.Add("memo", this.Memo);
            parameters.Add("receive_user_id", this.ReceiveUserId);
            parameters.Add("transfer_out_order_no", this.TransferOutOrderNo);
            return parameters;
        }

        #endregion
    }
}
