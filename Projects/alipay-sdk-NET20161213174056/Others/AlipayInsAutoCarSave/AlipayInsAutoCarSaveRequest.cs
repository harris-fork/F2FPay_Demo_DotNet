using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ins.auto.car.save
    /// </summary>
    public class AlipayInsAutoCarSaveRequest : IAopRequest<AlipayInsAutoCarSaveResponse>
    {
        /// <summary>
        /// 蚂蚁乐驾车主车辆保存服务
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ins.auto.car.save";
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
