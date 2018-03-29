using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.contract.get
    /// </summary>
    public class AlipayUserContractGetRequest : IAopRequest<AlipayUserContractGetResponse>
    {
        /// <summary>
        /// 订购者支付宝ID。session与subscriber_user_id二选一即可。
        /// </summary>
        public string SubscriberUserId { get; set; }

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
            return "alipay.user.contract.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("subscriber_user_id", this.SubscriberUserId);
            return parameters;
        }

        #endregion
    }
}
