using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// monitor.heartbeat.syn
    /// 验签时该参数不做任何处理
    /// </summary>
    public class MonitorHeartbeatSynRequest : BizAopRequest<MonitorHeartbeatSynResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "monitor.heartbeat.syn";
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
