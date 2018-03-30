using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.dataservice.sdfsdf
    /// </summary>
    public class AlipayDataDataserviceSdfsdfRequest : IAopRequest<AlipayDataDataserviceSdfsdfResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.dataservice.sdfsdf";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
