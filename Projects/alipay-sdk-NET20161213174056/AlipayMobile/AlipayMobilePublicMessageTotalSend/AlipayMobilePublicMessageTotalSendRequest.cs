using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.public.message.total.send
    /// 业务内容，其中包括消息类型msgType和消息体两部分，具体参见“表1-2 服务窗群发消息的biz_content参数说明”。
    /// </summary>
    public class AlipayMobilePublicMessageTotalSendRequest : BizAopRequest<AlipayMobilePublicMessageTotalSendResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.message.total.send";
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
