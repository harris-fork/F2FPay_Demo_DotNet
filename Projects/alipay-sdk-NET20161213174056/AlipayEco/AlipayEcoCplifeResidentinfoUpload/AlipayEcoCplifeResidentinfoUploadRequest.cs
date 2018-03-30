using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.eco.cplife.residentinfo.upload
    /// </summary>
    public class AlipayEcoCplifeResidentinfoUploadRequest : IAopRequest<AlipayEcoCplifeResidentinfoUploadResponse>
    {
        /// <summary>
        /// 物业小区业主信息上传
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.cplife.residentinfo.upload";
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
