using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.market.leads.batchquery
    /// 通过该接口多组合条件查询口碑线下Leads信息
    /// </summary>
    public class AlipayOfflineMarketLeadsBatchqueryRequest : BizAopRequest<AlipayOfflineMarketLeadsBatchqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.leads.batchquery";
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
