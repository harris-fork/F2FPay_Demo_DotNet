using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.customreport.batchquery
    /// 自定义数据报表列表分页查询接口
    /// </summary>
    public class KoubeiMarketingDataCustomreportBatchqueryRequest : BizAopRequest<KoubeiMarketingDataCustomreportBatchqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.customreport.batchquery";
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
