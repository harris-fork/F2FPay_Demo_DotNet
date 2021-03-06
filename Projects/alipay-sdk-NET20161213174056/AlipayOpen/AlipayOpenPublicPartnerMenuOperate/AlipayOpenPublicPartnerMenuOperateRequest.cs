using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.public.partner.menu.operate
    /// 为服务窗合作伙伴（如YunOS），提供操作服务窗菜单的功能
    /// </summary>
    public class AlipayOpenPublicPartnerMenuOperateRequest : BizAopRequest<AlipayOpenPublicPartnerMenuOperateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.partner.menu.operate";
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
