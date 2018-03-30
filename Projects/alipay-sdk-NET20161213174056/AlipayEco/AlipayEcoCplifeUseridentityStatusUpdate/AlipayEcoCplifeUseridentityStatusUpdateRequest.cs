using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.cplife.useridentity.status.update
    /// </summary>
    public class AlipayEcoCplifeUseridentityStatusUpdateRequest : IAopRequest<AlipayEcoCplifeUseridentityStatusUpdateResponse>
    {
        /// <summary>
        /// 社区物业业主鉴权状态更新
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
