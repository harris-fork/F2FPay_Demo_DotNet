using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.eco.mycar.parking.lotbarcode.create
    /// 物料二维码
    /// </summary>
    public class AlipayEcoMycarParkingLotbarcodeCreateRequest : BizAopRequest<AlipayEcoMycarParkingLotbarcodeCreateResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.eco.mycar.parking.lotbarcode.create";
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
