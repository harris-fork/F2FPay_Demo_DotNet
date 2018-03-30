using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.cplife.notice.publish
    /// 发布物业通知公告
    /// </summary>
    public class AlipayEcoCplifeNoticePublishRequest : BizAopRequest<AlipayEcoCplifeNoticePublishResponse>
    {
        

        #region BizAopRequest Members

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
