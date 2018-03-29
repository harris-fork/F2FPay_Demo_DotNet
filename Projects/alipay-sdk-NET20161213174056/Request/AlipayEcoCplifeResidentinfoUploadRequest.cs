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
		public bool NeedEncrypt { get; set; }
        public string ApiVersion { get; set; } = "1.0";
		public string TerminalType { get; set; }
		public string TerminalInfo { get; set; }
        public string ProdCode { get; set; }
		public string NotifyUrl { get; set; }
		public AopObject BizModel { get; set; }

		

        

		

        

        

    	

    	

    	

        

        

        public string GetApiName()
        {
            return "alipay.eco.cplife.residentinfo.upload";
        }

        

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

		

        #endregion
    }
}