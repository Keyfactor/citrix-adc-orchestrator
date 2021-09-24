// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.util.nitro_util
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using System.Reflection;
using System.Web;

namespace com.citrix.netscaler.nitro.util
{
  internal class nitro_util
  {
    public static string object_to_string_withoutquotes(object obj)
    {
      string str1 = (string) null;
      PropertyInfo[] properties = obj.GetType().GetProperties();
      for (int index = 0; index < properties.Length; ++index)
      {
        if (properties[index].GetValue(obj, (object[]) null) != null)
        {
          string str2 = "";
          string str3;
          if (properties[index].GetValue(obj, (object[]) null).GetType().IsArray)
          {
            object obj1 = properties[index].GetValue(obj, (object[]) null);
            switch (obj1)
            {
              case string[] _:
                foreach (string str4 in (string[]) obj1)
                  str2 = str2 + str4 + " ";
                break;
              case int[] _:
                foreach (int num in (int[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case uint[] _:
                foreach (int num in (uint[]) obj1)
                  str2 = str2 + (object) (uint) num + " ";
                break;
              case ushort[] _:
                foreach (int num in (ushort[]) obj1)
                  str2 = str2 + (object) (ushort) num + " ";
                break;
              case long[] _:
                foreach (long num in (long[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case double[] _:
                foreach (double num in (double[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case bool[] _:
                foreach (double num in (double[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
            }
            str3 = str2.Trim();
          }
          else
            str3 = properties[index].GetValue(obj, (object[]) null).ToString();
          if (str1 != null)
            str1 += ",";
          str1 = str1 != null ? str1 + properties[index].Name + ":" + HttpUtility.UrlEncode(str3) : properties[index].Name + ":" + HttpUtility.UrlEncode(str3);
        }
      }
      return str1;
    }

    public static string statobject_to_string_withoutquotes(object obj)
    {
      string str1 = (string) null;
      PropertyInfo[] properties = obj.GetType().GetProperties();
      for (int index = 0; index < properties.Length; ++index)
      {
        if (properties[index].GetValue(obj, (object[]) null) != null && (object) properties[index].GetSetMethod() != null)
        {
          string str2 = "";
          string str3;
          if (properties[index].GetValue(obj, (object[]) null).GetType().IsArray)
          {
            object obj1 = properties[index].GetValue(obj, (object[]) null);
            switch (obj1)
            {
              case string[] _:
                foreach (string str4 in (string[]) obj1)
                  str2 = str2 + str4 + " ";
                break;
              case int[] _:
                foreach (int num in (int[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case uint[] _:
                foreach (int num in (uint[]) obj1)
                  str2 = str2 + (object) (uint) num + " ";
                break;
              case ushort[] _:
                foreach (int num in (ushort[]) obj1)
                  str2 = str2 + (object) (ushort) num + " ";
                break;
              case long[] _:
                foreach (long num in (long[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case double[] _:
                foreach (double num in (double[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case bool[] _:
                foreach (double num in (double[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
            }
            str3 = str2.Trim();
          }
          else
            str3 = properties[index].GetValue(obj, (object[]) null).ToString();
          if (str1 != null)
            str1 += ",";
          str1 = str1 != null ? str1 + properties[index].Name + ":" + HttpUtility.UrlEncode(str3) : properties[index].Name + ":" + HttpUtility.UrlEncode(str3);
        }
      }
      return str1;
    }

    public static string object_to_string(object obj)
    {
      string str1 = (string) null;
      PropertyInfo[] properties = obj.GetType().GetProperties();
      for (int index = 0; index < properties.Length; ++index)
      {
        if (properties[index].GetValue(obj, (object[]) null) != null)
        {
          string str2 = "";
          string str3;
          if (properties[index].GetValue(obj, (object[]) null).GetType().IsArray)
          {
            object obj1 = properties[index].GetValue(obj, (object[]) null);
            switch (obj1)
            {
              case string[] _:
                foreach (string str4 in (string[]) obj1)
                  str2 = str2 + str4 + " ";
                break;
              case int[] _:
                foreach (int num in (int[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case uint[] _:
                foreach (int num in (uint[]) obj1)
                  str2 = str2 + (object) (uint) num + " ";
                break;
              case ushort[] _:
                foreach (int num in (ushort[]) obj1)
                  str2 = str2 + (object) (ushort) num + " ";
                break;
              case long[] _:
                foreach (long num in (long[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case double[] _:
                foreach (double num in (double[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
              case bool[] _:
                foreach (double num in (double[]) obj1)
                  str2 = str2 + (object) num + " ";
                break;
            }
            str3 = str2.Trim();
          }
          else
            str3 = properties[index].GetValue(obj, (object[]) null).ToString();
          if (str1 != null)
            str1 += ",";
          if (str1 == null)
            str1 = "\"" + properties[index].Name + "\":\"" + str3 + "\"";
          else
            str1 = str1 + "\"" + properties[index].Name + "\":\"" + str3 + "\"";
        }
      }
      return str1;
    }
  }
}
