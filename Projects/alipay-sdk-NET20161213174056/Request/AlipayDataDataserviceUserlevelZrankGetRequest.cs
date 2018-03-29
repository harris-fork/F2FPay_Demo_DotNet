using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.data.dataservice.userlevel.zrank.get
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetRequest : IAopRequest<AlipayDataDataserviceUserlevelZrankGetResponse>
    {
        /// <summary>
        /// 通用的活跃高价值用户等级，支持EMAIL,PHONE,BANKCARD,CERTNO,IMEI,MAC，TBID维度查询用户活跃高价值等级。等级从Z0-Z7，等级越高价值越高，Z0表示未实名认证或者用户信息不全。
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
            return "alipay.data.dataservice.userlevel.zrank.get";
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
