using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.offline.saleleads.info.querybypage
    /// </summary>
    public class AlipayOfflineSaleleadsInfoQuerybypageRequest : IAopRequest<AlipayOfflineSaleleadsInfoQuerybypageResponse>
    {
        /// <summary>
        /// 服务商按照条件分页查询leads信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.saleleads.info.querybypage";
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
