using System;
using System.Collections.Generic;
using System.Web;
using Com.Alipay;
using System.Threading;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;


namespace Com.Alipay
{
    /// <summary>
    /// F2FBiz 的摘要说明
    /// </summary>
    public class F2FMonitor
    {
        private F2FMonitor() { }

        public static AlipayMonitor monitorClient = null;

        public static AlipayMonitor CreateClientInstance(string monitorUrl, string appId, string merchant_private_key, string version,
                             string sign_type, string alipay_public_key, string charset)
        {
            if (monitorClient == null)
            {
                monitorClient = new AlipayMonitor(monitorUrl, appId, merchant_private_key, "json", version,
                sign_type, alipay_public_key, charset);
            }
            return monitorClient;
        }

    }
}
