using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.zdataassets.fcdatalab.zdatamergetask
    /// 业务参数
    /// </summary>
    public class AlipayZdataassetsFcdatalabZdatamergetaskRequest : BizAopRequest<AlipayZdataassetsFcdatalabZdatamergetaskResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.zdataassets.fcdatalab.zdatamergetask";
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
