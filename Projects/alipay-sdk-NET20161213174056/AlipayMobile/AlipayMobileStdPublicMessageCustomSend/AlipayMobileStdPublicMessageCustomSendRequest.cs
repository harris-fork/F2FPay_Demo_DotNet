using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.mobile.std.public.message.custom.send
    /// 业务内容，其中包括消息类型msgType、消息体和消息接受人toUserId三大块，具体参见“表1-2 服务窗单发客服消息的biz_content参数说明”。
    /// </summary>
    public class AlipayMobileStdPublicMessageCustomSendRequest : BizAopRequest<AlipayMobileStdPublicMessageCustomSendResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.std.public.message.custom.send";
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
