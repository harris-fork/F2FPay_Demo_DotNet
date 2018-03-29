using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.account.add
    /// </summary>
    public class AlipayMobilePublicAccountAddRequest : IAopRequest<AlipayMobilePublicAccountAddResponse>
    {
        /// <summary>
        /// 协议号
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 绑定账户
        /// </summary>
        public string BindAccountNo { get; set; }

        /// <summary>
        /// json
        /// </summary>
        public string BizContent { get; set; }

        /// <summary>
        /// 绑定账户的名
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 关注者标识
        /// </summary>
        public string FromUserId { get; set; }

        /// <summary>
        /// 绑定账户的用户名
        /// </summary>
        public string RealName { get; set; }

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
            return "alipay.mobile.public.account.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("bind_account_no", this.BindAccountNo);
            parameters.Add("biz_content", this.BizContent);
            parameters.Add("display_name", this.DisplayName);
            parameters.Add("from_user_id", this.FromUserId);
            parameters.Add("real_name", this.RealName);
            return parameters;
        }

        #endregion
    }
}
