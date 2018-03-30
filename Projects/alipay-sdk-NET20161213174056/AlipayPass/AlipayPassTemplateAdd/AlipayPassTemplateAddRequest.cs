using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.pass.template.add
    /// 卡券模板创建
    /// </summary>
    public class AlipayPassTemplateAddRequest : BizAopRequest<AlipayPassTemplateAddResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.pass.template.add";
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
