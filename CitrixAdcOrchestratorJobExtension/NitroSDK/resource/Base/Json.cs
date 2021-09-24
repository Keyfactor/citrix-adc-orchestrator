// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.Base.Json
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Reflection;

namespace com.citrix.netscaler.nitro.resource.Base
{
  public class Json : ipayload_formatter
  {
    public string resource_to_string(base_resource resrc)
    {
      JsonSerializer jsonSerializer = new JsonSerializer();
      jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
      StringWriter stringWriter = new StringWriter();
      JsonTextWriter jsonTextWriter = new JsonTextWriter((TextWriter) stringWriter);
      jsonTextWriter.QuoteChar = '"';
      jsonSerializer.Serialize((JsonWriter) jsonTextWriter, (object) resrc);
      string str = stringWriter.ToString();
      jsonTextWriter.Close();
      stringWriter.Close();
      return str;
    }

    public string resource_to_string_put(base_resource resrc)
    {
      JsonSerializer jsonSerializer = new JsonSerializer();
      jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
      StringWriter stringWriter = new StringWriter();
      JsonTextWriter jsonTextWriter = new JsonTextWriter((TextWriter) stringWriter);
      jsonTextWriter.QuoteChar = '"';
      jsonSerializer.Serialize((JsonWriter) jsonTextWriter, (object) resrc);
      string str = stringWriter.ToString();
      jsonTextWriter.Close();
      stringWriter.Close();
      return str;
    }

    public object string_to_resource(Type objtype, string response)
    {
      com.citrix.netscaler.nitro.resource.Base.Json.MyJsonDefaultContractResolver contractResolver = new com.citrix.netscaler.nitro.resource.Base.Json.MyJsonDefaultContractResolver();
      JsonSerializerSettings settings = new JsonSerializerSettings()
      {
        ContractResolver = (IContractResolver) contractResolver
      };
      return JsonConvert.DeserializeObject(response, objtype, settings);
    }

    public string resource_to_string(
      base_resource resrc,
      string id,
      options option,
      bool warning,
      string onerror)
    {
      string str1 = "{ ";
      if (option != null || warning || !onerror.Equals(""))
      {
        string str2 = str1 + "\"params\":{";
        if (option != null && option.get_action() != null)
          str2 = str2 + "\"action\":\"" + option.get_action() + "\",";
        if (warning)
          str2 += "\"warning\":\"yes\",";
        if (!onerror.Equals(""))
          str2 = str2 + "\"onerror\":\"" + onerror + "\"";
        str1 = str2 + "},";
      }
      if (id != null)
        str1 = str1 + "\"sessionid\":\"" + id + "\",";
      return str1 + "\"" + resrc.get_object_type() + "\":" + this.resource_to_string(resrc) + "}";
    }

    public string resource_to_string(
      base_resource[] resources,
      string id,
      options option,
      bool warning,
      string onerror)
    {
      string objectType = resources[0].get_object_type();
      string str1 = "{";
      if (option != null && option.get_action() != null || warning || !onerror.Equals(""))
      {
        string str2 = str1 + "\"params\":{";
        if (option != null && option.get_action() != null)
          str2 = str2 + "\"action\":\"" + option.get_action() + "\",";
        if (warning)
          str2 += "\"warning\":\"yes\",";
        if (!onerror.Equals(""))
          str2 = str2 + "\"onerror\":\"" + onerror + "\"";
        str1 = str2 + "},";
      }
      string str3 = id;
      if (str3 != null)
        str1 = str1 + "\"sessionid\":\"" + str3 + "\",";
      string str4 = str1 + "\"" + objectType + "\":[";
      for (int index = 0; index < resources.Length; ++index)
      {
        string str5 = this.resource_to_string(resources[index]);
        str4 = str4 + str5 + ",";
      }
      return str4 + "]}";
    }

    public string resource_to_string_put(
      base_resource resrc,
      string id,
      options option,
      bool warning,
      string onerror)
    {
      string str1 = "{ ";
      if (option != null && option.get_action() != null || warning || !onerror.Equals(""))
      {
        string str2 = str1 + "\"params\":{";
        if (option != null && option.get_action() != null)
          str2 = str2 + "\"action\":\"" + option.get_action() + "\",";
        if (warning)
          str2 += "\"warning\":\"yes\",";
        if (!onerror.Equals(""))
          str2 = str2 + "\"onerror\":\"" + onerror + "\"";
        str1 = str2 + "},";
      }
      if (id != null)
        str1 = str1 + "\"sessionid\":\"" + id + "\",";
      return str1 + "\"" + resrc.get_object_type() + "\":" + this.resource_to_string_put(resrc) + "}";
    }

    public string resource_to_string_put(
      base_resource[] resources,
      string id,
      options option,
      bool warning,
      string onerror)
    {
      string objectType = resources[0].get_object_type();
      string str1 = "{";
      if (option != null && option.get_action() != null || warning || !onerror.Equals(""))
      {
        string str2 = str1 + "\"params\":{";
        if (option != null && option.get_action() != null)
          str2 = str2 + "\"action\":\"" + option.get_action() + "\",";
        if (warning)
          str2 += "\"warning\":\"yes\",";
        if (!onerror.Equals(""))
          str2 = str2 + "\"onerror\":\"" + onerror + "\"";
        str1 = str2 + "},";
      }
      string str3 = id;
      if (str3 != null)
        str1 = str1 + "\"sessionid\":\"" + str3 + "\",";
      string str4 = str1 + "\"" + objectType + "\":[";
      for (int index = 0; index < resources.Length; ++index)
      {
        string stringPut = this.resource_to_string_put(resources[index]);
        str4 = str4 + stringPut + ",";
      }
      return str4 + "]}";
    }

    public string unset_string(base_resource resrc, string[] args)
    {
      string str1 = "{ ";
      string str2 = nitro_util.object_to_string((object) resrc);
      if (str2 != null)
        str1 = str1 + str2 + ",";
      for (int index = 0; index < args.Length; ++index)
        str1 = str1 + "\"" + args[index] + "\": true,";
      return str1 + "}";
    }

    public string unset_string(
      base_resource resrc,
      string id,
      options option,
      string[] args,
      bool warning)
    {
      string str1 = "{ ";
      if (option != null && option.get_action() != null || warning)
      {
        string str2 = str1 + "\"params\":{";
        if (option != null && option.get_action() != null)
          str2 = str2 + "\"action\":\"" + option.get_action() + "\",";
        if (warning)
          str2 += "\"warning\":\"yes\"";
        str1 = str2 + "},";
      }
      if (id != null)
        str1 = str1 + "\"sessionid\":\"" + id + "\",";
      string str3 = str1 + "\"" + resrc.get_object_type() + "\": {";
      string str4 = nitro_util.object_to_string((object) resrc);
      if (str4 != null)
        str3 = str3 + str4 + ",";
      if (args != null)
      {
        for (int index = 0; index < args.Length; ++index)
          str3 = str3 + "\"" + args[index] + "\": true,";
      }
      return str3 + "}," + "}";
    }

    public string unset_string(
      base_resource[] resrc,
      string id,
      options option,
      string[] args,
      bool warning,
      string onerror)
    {
      string objectType = resrc[0].get_object_type();
      string str1 = "{ ";
      if (option != null && option.get_action() != null || warning || !onerror.Equals(""))
      {
        string str2 = str1 + "\"params\":{";
        if (option != null && option.get_action() != null)
          str2 = str2 + "\"action\":\"" + option.get_action() + "\",";
        if (warning)
          str2 += "\"warning\":\"yes\",";
        if (!onerror.Equals(""))
          str2 = str2 + "\"onerror\":\"" + onerror + "\"";
        str1 = str2 + "},";
      }
      if (id != null)
        str1 = str1 + "\"sessionid\":\"" + id + "\",";
      string str3 = str1 + "\"" + objectType + "\":[";
      for (int index = 0; index < resrc.Length; ++index)
      {
        string str4 = this.unset_string(resrc[index], args);
        str3 = str3 + str4 + ",";
      }
      return str3 + "]}";
    }

    public class MyJsonDefaultContractResolver : DefaultContractResolver
    {
      protected override JsonProperty CreateProperty(
        MemberInfo member,
        MemberSerialization memberSerialization)
      {
        JsonProperty property = base.CreateProperty(member, memberSerialization);
        if (!property.Writable)
        {
          PropertyInfo propertyInfo = member as PropertyInfo;
          if ((object) propertyInfo != null)
          {
            bool flag = (object) propertyInfo.GetSetMethod(true) != null;
            property.Writable = flag;
          }
        }
        return property;
      }
    }
  }
}
