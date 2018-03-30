using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.alisis.report.query
    /// 报表详情查询接口
    /// </summary>
    public class KoubeiMarketingDataAlisisReportQueryRequest : BizAopRequest<KoubeiMarketingDataAlisisReportQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.alisis.report.query";
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
