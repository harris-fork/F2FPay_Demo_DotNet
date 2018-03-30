using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.public.life.msg.recall
    /// 生活号消息撤回接口
    /// </summary>
    public class AlipayOpenPublicLifeMsgRecallRequest : BizAopRequest<AlipayOpenPublicLifeMsgRecallResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.life.msg.recall";
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
