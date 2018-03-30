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

        public override string GetApiName()
        {
            return "alipay.user.contract.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("subscriber_user_id", this.SubscriberUserId);
            return parameters;
        }

        #endregion
    }
}
