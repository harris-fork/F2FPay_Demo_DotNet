using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.customreport.detail.query
    /// 自定义数据报表规则详情查询接口
    /// </summary>
    public class KoubeiMarketingDataCustomreportDetailQueryRequest : BizAopRequest<KoubeiMarketingDataCustomreportDetailQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.customreport.detail.query";
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
