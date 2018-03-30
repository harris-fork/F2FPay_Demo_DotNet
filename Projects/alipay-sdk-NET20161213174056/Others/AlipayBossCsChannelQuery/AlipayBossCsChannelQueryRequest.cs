using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.boss.cs.channel.query
    /// 云客服热线数据查询，云客服会有很多外部客服，他们需要查询落地在站内的自己公司的服务数据。
    /// </summary>
    public class AlipayBossCsChannelQueryRequest : BizAopRequest<AlipayBossCsChannelQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.boss.cs.channel.query";
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
