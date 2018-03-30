using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.std.public.follow.list
    /// </summary>
    public class AlipayMobileStdPublicFollowListRequest : IAopRequest<AlipayMobileStdPublicFollowListResponse>
    {
        /// <summary>
        /// 当nextUserId为空时,代表查询第一组,如果有值时以当前值为准查询下一组
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.std.public.follow.list";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
