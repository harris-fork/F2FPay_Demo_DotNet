using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.offline.provider.monitor.log.sync
    /// ISV服务商监控数据回流
    /// </summary>
    public class AlipayOfflineProviderMonitorLogSyncRequest : BizAopRequest<AlipayOfflineProviderMonitorLogSyncResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.offline.provider.monitor.log.sync";
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
