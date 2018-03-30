using Aop.Api.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aop.Api.Request
{
    public abstract class BizAopRequest<T> : IAopRequest<T> where T : AopResponse
    {

        public string BizContent { get; set; }
    }
}
