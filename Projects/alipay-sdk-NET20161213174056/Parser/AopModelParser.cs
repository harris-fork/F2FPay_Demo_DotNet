using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Aop.Api;
using System.Reflection;
using System.Collections;
using System.Xml.Serialization;

namespace Aop.Api.Parser
{
    public class AopModelParser
    {

        /// <summary>
        /// 获取Xml属性名
        /// </summary>
        /// <param name="pi"></param>
        /// <returns></returns>
        private String getElementName(PropertyInfo pi)
        {
            if (pi == null)
            {
                return null;
            }

            // 获取XmlElement属性
            XmlElementAttribute[] xeas = pi.GetCustomAttributes(typeof(XmlElementAttribute), true) as XmlElementAttribute[];
            String elementName = null;
            if (xeas != null && xeas.Length > 0)
            {
                elementName = xeas[0].ElementName;
            }

            // 如果获取XmlElement属性为空，则去获取XmlArray属性
            if (String.IsNullOrEmpty(elementName))
            {
                XmlArrayAttribute[] xaas = pi.GetCustomAttributes(typeof(XmlArrayAttribute), true) as XmlArrayAttribute[];
                if (xaas != null && xaas.Length > 0)
                {
                    elementName = xaas[0].ElementName;
                }
            }
            return elementName;
        }

    }
}
