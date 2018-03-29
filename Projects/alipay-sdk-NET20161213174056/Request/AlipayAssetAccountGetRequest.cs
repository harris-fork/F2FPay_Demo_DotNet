using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.account.get
    /// </summary>
    public class AlipayAssetAccountGetRequest : IAopRequest<AlipayAssetAccountGetResponse>
    {
        /// <summary>
        /// 使用该app提供用户信息的商户，可以和app相同。
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员标识。商户需确保其唯一性，不可变更。  注意：根据provider_user_id查询时该值不可空。
        /// </summary>
        public string ProviderUserId { get; set; }

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
            return "alipay.asset.account.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("provider_id", this.ProviderId);
            parameters.Add("provider_user_id", this.ProviderUserId);
            return parameters;
        }

        #endregion
    }
}
