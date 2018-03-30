using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.dataservice.maintainvehicle.share
    /// 同步评论接口
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareRequest : BizAopRequest<AlipayEcoMycarDataserviceMaintainvehicleShareResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.dataservice.maintainvehicle.share";
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
