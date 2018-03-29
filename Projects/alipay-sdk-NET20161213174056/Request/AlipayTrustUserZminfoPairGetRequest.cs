using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trust.user.zminfo.pair.get
    /// </summary>
    public class AlipayTrustUserZminfoPairGetRequest : IAopRequest<AlipayTrustUserZminfoPairGetResponse>
    {
        /// <summary>
        /// 描述申请者的用户信息JSON串，身份证号，姓名等
        /// </summary>
        public string ApplyUserInfo { get; set; }

        /// <summary>
        /// 被申请人的用户信息JSON串
        /// </summary>
        public string OwnerUserInfo { get; set; }

        /// <summary>
        /// 请求的芝麻信用信息类型，目前仅支持芝麻分
        /// </summary>
        public string ZmInfoType { get; set; }

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
            return "alipay.trust.user.zminfo.pair.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("apply_user_info", this.ApplyUserInfo);
            parameters.Add("owner_user_info", this.OwnerUserInfo);
            parameters.Add("zm_info_type", this.ZmInfoType);
            return parameters;
        }

        #endregion
    }
}
