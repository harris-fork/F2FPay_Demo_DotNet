using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.data.dataexchange.sfasdf
    /// 1232456374
    /// </summary>
    public class AlipayDataDataexchangeSfasdfRequest : BizAopRequest<AlipayDataDataexchangeSfasdfResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.dataexchange.sfasdf";
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
