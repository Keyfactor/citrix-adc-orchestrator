// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.Base.ipayload_formatter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.service;
using System;

namespace com.citrix.netscaler.nitro.resource.Base
{
  public interface ipayload_formatter
  {
    string resource_to_string(base_resource resrc);

    string resource_to_string(
      base_resource resrc,
      string id,
      options option,
      bool warning,
      string onerror);

    string resource_to_string_put(base_resource resrc);

    string resource_to_string_put(
      base_resource resrc,
      string id,
      options option,
      bool warning,
      string onerror);

    string unset_string(
      base_resource resrc,
      string id,
      options option,
      string[] args,
      bool warning);

    string unset_string(
      base_resource[] resrc,
      string id,
      options option,
      string[] args,
      bool warning,
      string onerror);

    string resource_to_string(
      base_resource[] resrc,
      string id,
      options option,
      bool warning,
      string onerror);

    string resource_to_string_put(
      base_resource[] resrc,
      string id,
      options option,
      bool warning,
      string onerror);

    object string_to_resource(Type responseClass, string response);
  }
}
