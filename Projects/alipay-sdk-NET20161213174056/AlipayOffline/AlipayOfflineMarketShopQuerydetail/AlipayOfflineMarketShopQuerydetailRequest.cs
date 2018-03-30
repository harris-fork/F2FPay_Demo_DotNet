using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.querydetail
    /// </summary>
    public class AlipayOfflineMarketShopQuerydetailRequest : IAopRequest<AlipayOfflineMarketShopQuerydetailResponse>
    {
        /// <summary>
        /// 系统商通过该接口可以查询单个门店的详细信息，包括门店基础信息，门店状态等信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.querydetail";
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
