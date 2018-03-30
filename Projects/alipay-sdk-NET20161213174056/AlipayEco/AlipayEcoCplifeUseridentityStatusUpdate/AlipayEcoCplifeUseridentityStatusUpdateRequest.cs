using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.cplife.useridentity.status.update
    /// 社区物业业主鉴权状态更新
    /// </summary>
    public class AlipayEcoCplifeUseridentityStatusUpdateRequest : BizAopRequest<AlipayEcoCplifeUseridentityStatusUpdateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.useridentity.status.update";
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
