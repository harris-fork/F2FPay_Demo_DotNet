using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.public.account.reset
    /// json
    /// </summary>
    public class AlipayMobilePublicAccountResetRequest : BizAopRequest<AlipayMobilePublicAccountResetResponse>
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

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.account.reset";
        }

        public override IDictionary<string, string> GetParameters()
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
