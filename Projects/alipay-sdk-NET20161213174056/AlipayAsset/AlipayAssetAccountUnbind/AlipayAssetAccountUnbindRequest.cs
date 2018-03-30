using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.account.unbind
    /// </summary>
    public class AlipayAssetAccountUnbindRequest : IAopRequest<AlipayAssetAccountUnbindResponse>
    {
        /// <summary>
        /// 业务参数 使用该app提供用户信息的商户在支付宝签约时的支付宝账户userID，可以和app相同。
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员标识。商户需确保其唯一性，不可变更。
        /// </summary>
        public string ProviderUserId { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.asset.account.unbind";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("provider_id", this.ProviderId);
            parameters.Add("provider_user_id", this.ProviderUserId);
            return parameters;
        }

        #endregion
    }
}
