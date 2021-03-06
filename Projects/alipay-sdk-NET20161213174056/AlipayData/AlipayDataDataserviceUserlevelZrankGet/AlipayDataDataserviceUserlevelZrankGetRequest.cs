using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.data.dataservice.userlevel.zrank.get
    /// 通用的活跃高价值用户等级，支持EMAIL,PHONE,BANKCARD,CERTNO,IMEI,MAC，TBID维度查询用户活跃高价值等级。等级从Z0-Z7，等级越高价值越高，Z0表示未实名认证或者用户信息不全。
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetRequest : BizAopRequest<AlipayDataDataserviceUserlevelZrankGetResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.data.dataservice.userlevel.zrank.get";
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
