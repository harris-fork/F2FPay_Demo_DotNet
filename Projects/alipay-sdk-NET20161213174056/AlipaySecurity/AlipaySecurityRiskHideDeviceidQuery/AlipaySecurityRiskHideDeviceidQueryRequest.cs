using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.security.risk.hide.deviceid.query
    /// 设备指纹查询接口
    /// </summary>
    public class AlipaySecurityRiskHideDeviceidQueryRequest : BizAopRequest<AlipaySecurityRiskHideDeviceidQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.security.risk.hide.deviceid.query";
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
