using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.medical.instcard.createandpay
    /// 根据用户已经在支付宝绑定过的医保卡为医疗行业提供收单支付服务。同时支持自费支付服务
    /// </summary>
    public class AlipayCommerceMedicalInstcardCreateandpayRequest : BizAopRequest<AlipayCommerceMedicalInstcardCreateandpayResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.medical.instcard.createandpay";
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
