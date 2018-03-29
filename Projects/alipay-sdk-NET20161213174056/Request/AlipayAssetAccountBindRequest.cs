using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.asset.account.bind
    /// </summary>
    public class AlipayAssetAccountBindRequest : IAopRequest<AlipayAssetAccountBindResponse>
    {
        /// <summary>
        /// 绑定场景，目前仅支持如下：  wechat：微信公众平台；  transport：物流转运平台；  appOneBind：一对一app绑定；   注意：必须是这些值，区分大小写。
        /// </summary>
        public string BindScene { get; set; }

        /// <summary>
        /// 使用该app提供用户信息的商户，可以和app相同。
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员标识。商户需确保其唯一性，不可变更。
        /// </summary>
        public string ProviderUserId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员名（登录号或昵称）。
        /// </summary>
        public string ProviderUserName { get; set; }

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
            return "alipay.asset.account.bind";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("bind_scene", this.BindScene);
            parameters.Add("provider_id", this.ProviderId);
            parameters.Add("provider_user_id", this.ProviderUserId);
            parameters.Add("provider_user_name", this.ProviderUserName);
            return parameters;
        }

        #endregion
    }
}
