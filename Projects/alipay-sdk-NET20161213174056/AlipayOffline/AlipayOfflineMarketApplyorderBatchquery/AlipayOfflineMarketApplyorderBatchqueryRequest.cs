using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.market.applyorder.batchquery
    /// 分页查询Leads、门店、商品相关操作流水信息
    /// </summary>
    public class AlipayOfflineMarketApplyorderBatchqueryRequest : BizAopRequest<AlipayOfflineMarketApplyorderBatchqueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.applyorder.batchquery";
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
