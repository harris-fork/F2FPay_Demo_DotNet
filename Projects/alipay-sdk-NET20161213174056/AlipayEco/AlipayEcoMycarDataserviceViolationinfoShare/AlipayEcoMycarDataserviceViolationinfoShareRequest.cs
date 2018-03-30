using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.dataservice.violationinfo.share
    /// ISV获取违章车辆信息
    /// </summary>
    public class AlipayEcoMycarDataserviceViolationinfoShareRequest : BizAopRequest<AlipayEcoMycarDataserviceViolationinfoShareResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.dataservice.violationinfo.share";
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
