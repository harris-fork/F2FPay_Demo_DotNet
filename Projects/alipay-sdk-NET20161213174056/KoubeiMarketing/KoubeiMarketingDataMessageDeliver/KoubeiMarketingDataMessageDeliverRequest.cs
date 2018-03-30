using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// koubei.marketing.data.message.deliver
    /// 一键营销商家中心PUSH消息接口
    /// </summary>
    public class KoubeiMarketingDataMessageDeliverRequest : BizAopRequest<KoubeiMarketingDataMessageDeliverResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "koubei.marketing.data.message.deliver";
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
