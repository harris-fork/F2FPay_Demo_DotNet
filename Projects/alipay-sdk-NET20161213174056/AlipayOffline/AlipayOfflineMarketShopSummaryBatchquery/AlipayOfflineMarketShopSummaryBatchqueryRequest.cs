using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.market.shop.summary.batchquery
    /// 门店摘要信息批量查询接口
    /// </summary>
    public class AlipayOfflineMarketShopSummaryBatchqueryRequest : BizAopRequest<AlipayOfflineMarketShopSummaryBatchqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.summary.batchquery";
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
