using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.tool.points.query
    /// 集点查询
    /// </summary>
    public class KoubeiMarketingToolPointsQueryRequest : BizAopRequest<KoubeiMarketingToolPointsQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.tool.points.query";
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
