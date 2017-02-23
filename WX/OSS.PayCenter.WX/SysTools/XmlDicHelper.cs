﻿#region Copyright (C) 2017 Kevin (OSS开源作坊) 公众号：osscoder

/***************************************************************************
*　　	文件功能描述：微信支付模快 —— xml和dictionary 辅助转化类
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*    	创建日期：2017-2-23
*       
*****************************************************************************/

#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OSS.PayCenter.WX.SysTools
{
    internal static class XmlDicHelper
    {
        /// <summary>
        ///  字典转到xml
        /// </summary>
        /// <param name="dics"></param>
        /// <returns></returns>
       internal static string ProduceXml(this SortedDictionary<string,object> dics )
        {
            StringBuilder xml = new StringBuilder();

            foreach (var item in dics)
            {
                if (item.Value is int
                    || item.Value is Int64
                    || item.Value is double
                    || item.Value is float)
                {
                    xml.Append("<").Append(item.Key).Append(">")
                        .Append(item.Value)
                        .Append("</").Append(item.Key).Append(">");
                }
                else
                {
                    xml.Append("<").Append(item.Key).Append(">")
                        .Append("<![CDATA[")
                        .Append(item.Value)
                        .Append("]]>")
                        .Append("</").Append(item.Key).Append(">");
                }
            }
            return xml.ToString();
        }
    }
}