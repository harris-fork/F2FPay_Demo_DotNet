using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.parking.cardbarcode.create
    /// 停车卡生成二维码
    /// </summary>
    public class AlipayEcoMycarParkingCardbarcodeCreateRequest : BizAopRequest<AlipayEcoMycarParkingCardbarcodeCreateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.parking.cardbarcode.create";
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
