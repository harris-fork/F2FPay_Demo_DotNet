using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.carlib.info.push
    /// 同步车型库
    /// </summary>
    public class AlipayEcoMycarCarlibInfoPushRequest : BizAopRequest<AlipayEcoMycarCarlibInfoPushResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.carlib.info.push";
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
