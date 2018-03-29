using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.point.order.add
    /// </summary>
    public class AlipayPointOrderAddRequest : IAopRequest<AlipayPointOrderAddResponse>
    {
        /// <summary>
        /// 向用户展示集分宝发放备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// isv提供的发放订单号，由数字和字母组成，最大长度为32位，需要保证每笔订单发放的唯一性，支付宝对该参数做唯一性校验。如果订单号已存在，支付宝将返回订单号已经存在的错误
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 发放集分宝时间
        /// </summary>
        public Nullable<DateTime> OrderTime { get; set; }

        /// <summary>
        /// 发放集分宝的数量
        /// </summary>
        public Nullable<long> PointCount { get; set; }

        /// <summary>
        /// 用户标识符，用于指定集分宝发放的用户，和user_symbol_type一起使用，确定一个唯一的支付宝用户
        /// </summary>
        public string UserSymbol { get; set; }

        /// <summary>
        /// 用户标识符类型，现在支持ALIPAY_USER_ID:表示支付宝用户ID,ALIPAY_LOGON_ID:表示支付宝登陆号
        /// </summary>
        public string UserSymbolType { get; set; }

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
            return "alipay.point.order.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("memo", this.Memo);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("order_time", this.OrderTime);
            parameters.Add("point_count", this.PointCount);
            parameters.Add("user_symbol", this.UserSymbol);
            parameters.Add("user_symbol_type", this.UserSymbolType);
            return parameters;
        }

        #endregion
    }
}
