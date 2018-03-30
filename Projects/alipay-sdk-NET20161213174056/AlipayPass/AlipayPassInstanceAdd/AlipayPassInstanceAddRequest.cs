using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.pass.instance.add
    /// 支付宝pass新建卡券实例接口
    /// </summary>
    public class AlipayPassInstanceAddRequest : BizAopRequest<AlipayPassInstanceAddResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.pass.instance.add";
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
