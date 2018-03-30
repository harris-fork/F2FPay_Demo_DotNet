using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.provider.equipment.auth.querybypage
    /// 解绑查询接口
    /// </summary>
    public class AlipayOfflineProviderEquipmentAuthQuerybypageRequest : BizAopRequest<AlipayOfflineProviderEquipmentAuthQuerybypageResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.provider.equipment.auth.querybypage";
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
