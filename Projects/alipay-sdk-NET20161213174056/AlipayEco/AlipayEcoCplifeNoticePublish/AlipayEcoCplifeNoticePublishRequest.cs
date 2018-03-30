using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.cplife.notice.publish
    /// </summary>
    public class AlipayEcoCplifeNoticePublishRequest : IAopRequest<AlipayEcoCplifeNoticePublishResponse>
    {
        /// <summary>
        /// 发布物业通知公告
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.notice.publish";
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
