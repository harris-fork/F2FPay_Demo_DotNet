using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.system.oauth.token
    /// </summary>
    public class AlipaySystemOauthTokenRequest : IAopRequest<AlipaySystemOauthTokenResponse>
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到。
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 值为authorization_code时，代表用code换取；值为refresh_token时，代表用refresh_token换取
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌时得到。见出参的refresh_token字段
        /// </summary>
        public string RefreshToken { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.system.oauth.token";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("grant_type", this.GrantType);
            parameters.Add("refresh_token", this.RefreshToken);
            return parameters;
        }

        #endregion
    }
}
