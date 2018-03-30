using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.provider.shopaction.record
    /// isv 回传的商户操作行为信息调用接口
    /// </summary>
    public class AlipayOfflineProviderShopactionRecordRequest : BizAopRequest<AlipayOfflineProviderShopactionRecordResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.provider.shopaction.record";
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
