using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.mycar.dataservice.maintainvehicle.share
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareRequest : IAopRequest<AlipayEcoMycarDataserviceMaintainvehicleShareResponse>
    {
        /// <summary>
        /// 同步评论接口
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

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
