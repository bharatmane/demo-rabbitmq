using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RabbitMQ.Demo.Common
{
    public static class ObjectSerialize
    {
        public static byte[] Serialize(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            var json = JsonSerializer.Serialize(obj);
            return Encoding.ASCII.GetBytes(json);
        }

        public static object DeSerialize(this byte[] arrBytes, Type type)
        {
            var json = Encoding.Default.GetString(arrBytes);
            return JsonSerializer.Deserialize(json, type);
        }

        public static string DeSerializeText(this byte[] arrBytes)
        {
            return Encoding.Default.GetString(arrBytes);
        }
    }
}
