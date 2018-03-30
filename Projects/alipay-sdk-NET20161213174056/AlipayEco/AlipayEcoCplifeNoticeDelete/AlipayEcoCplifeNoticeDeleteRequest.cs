using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.cplife.notice.delete
    /// </summary>
    public class AlipayEcoCplifeNoticeDeleteRequest : IAopRequest<AlipayEcoCplifeNoticeDeleteResponse>
    {
        /// <summary>
        /// 删除物业社区通知通告
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.notice.delete";
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
