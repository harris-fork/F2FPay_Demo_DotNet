using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.provider.staff.update
    /// </summary>
    public class AlipayOfflineProviderStaffUpdateRequest : IAopRequest<AlipayOfflineProviderStaffUpdateResponse>
    {
        /// <summary>
        /// 云纵员工信息同步到口碑
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.provider.staff.update";
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
