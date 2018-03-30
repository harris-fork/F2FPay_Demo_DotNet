using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.public.template.message.industry.modify
    /// 模板消息行业设置修改接口
    /// </summary>
    public class AlipayOpenPublicTemplateMessageIndustryModifyRequest : BizAopRequest<AlipayOpenPublicTemplateMessageIndustryModifyResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.template.message.industry.modify";
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
