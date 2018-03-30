using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.market.shop.applyorder.cancel
    /// </summary>
    public class AlipayOfflineMarketShopApplyorderCancelRequest : IAopRequest<AlipayOfflineMarketShopApplyorderCancelResponse>
    {
        /// <summary>
        /// 申请流水撤销
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.market.shop.applyorder.cancel";
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
