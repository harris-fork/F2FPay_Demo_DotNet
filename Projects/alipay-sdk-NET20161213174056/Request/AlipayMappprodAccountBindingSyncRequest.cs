using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mappprod.account.binding.sync
    /// </summary>
    public class AlipayMappprodAccountBindingSyncRequest : IAopRequest<AlipayMappprodAccountBindingSyncResponse>
    {
        /// <summary>
        /// 扩展数据，格式：JSON字符串。预留，暂时没用
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户的商户会员号
        /// </summary>
        public string UserAccountNo { get; set; }

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
            return "alipay.mappprod.account.binding.sync";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("user_account_no", this.UserAccountNo);
            return parameters;
        }

        #endregion
    }
}
