using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Util
{
    /// <summary>
    /// XML数据转换为Entity数据
    /// </summary>
    public static class XML2Entity
    {
        public static T GetEntityFromXElement<T>(XElement record)
               where T : class
        {
            T result = Activator.CreateInstance<T>();
            try
            {
                XmlSerializer xmldes = new XmlSerializer(typeof(T));
                string x = record.ToString().Trim();
                StringReader sr = new StringReader(record.ToString().Trim().Replace("\r\n", ""));
                result = (T)xmldes.Deserialize(sr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}