// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.policy.policypatset_pattern_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.policy
{
  public class policypatset_pattern_binding : base_resource
  {
    private string StringField = (string) null;
    private uint? indexField = new uint?();
    private string charsetField = (string) null;
    private string[] builtinField = (string[]) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string String
    {
      get => this.StringField;
      set => this.StringField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      set => this.builtinField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string charset
    {
      get => this.charsetField;
      set => this.charsetField = value;
    }

    public uint? index
    {
      get => this.indexField;
      set => this.indexField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      policypatset_pattern_binding.policypatset_pattern_binding_response patternBindingResponse = new policypatset_pattern_binding.policypatset_pattern_binding_response();
      policypatset_pattern_binding.policypatset_pattern_binding_response resource = (policypatset_pattern_binding.policypatset_pattern_binding_response) service.get_payload_formatter().string_to_resource(patternBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.policypatset_pattern_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      policypatset_pattern_binding resource)
    {
      return new policypatset_pattern_binding()
      {
        name = resource.name,
        String = resource.String,
        index = resource.index,
        charset = resource.charset
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      policypatset_pattern_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policypatset_pattern_binding[] policypatsetPatternBindingArray = new policypatset_pattern_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policypatsetPatternBindingArray[index] = new policypatset_pattern_binding();
          policypatsetPatternBindingArray[index].name = resources[index].name;
          policypatsetPatternBindingArray[index].String = resources[index].String;
          policypatsetPatternBindingArray[index].index = resources[index].index;
          policypatsetPatternBindingArray[index].charset = resources[index].charset;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) policypatsetPatternBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      policypatset_pattern_binding resource)
    {
      return new policypatset_pattern_binding()
      {
        name = resource.name,
        String = resource.String
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      policypatset_pattern_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        policypatset_pattern_binding[] policypatsetPatternBindingArray = new policypatset_pattern_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          policypatsetPatternBindingArray[index] = new policypatset_pattern_binding();
          policypatsetPatternBindingArray[index].name = resources[index].name;
          policypatsetPatternBindingArray[index].String = resources[index].String;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) policypatsetPatternBindingArray);
      }
      return baseResponses;
    }

    public static policypatset_pattern_binding[] get(
      nitro_service service,
      string name)
    {
      return (policypatset_pattern_binding[]) new policypatset_pattern_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static policypatset_pattern_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      policypatset_pattern_binding policypatsetPatternBinding = new policypatset_pattern_binding();
      policypatsetPatternBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (policypatset_pattern_binding[]) policypatsetPatternBinding.getfiltered(service, option);
    }

    public static policypatset_pattern_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      policypatset_pattern_binding policypatsetPatternBinding = new policypatset_pattern_binding();
      policypatsetPatternBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (policypatset_pattern_binding[]) policypatsetPatternBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      policypatset_pattern_binding policypatsetPatternBinding = new policypatset_pattern_binding();
      policypatsetPatternBinding.name = name;
      options option = new options();
      option.set_count(true);
      policypatset_pattern_binding[] resources = (policypatset_pattern_binding[]) policypatsetPatternBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      policypatset_pattern_binding policypatsetPatternBinding = new policypatset_pattern_binding();
      policypatsetPatternBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policypatset_pattern_binding[] policypatsetPatternBindingArray = (policypatset_pattern_binding[]) policypatsetPatternBinding.getfiltered(service, option);
      return policypatsetPatternBindingArray != null && policypatsetPatternBindingArray.Length > 0 ? policypatsetPatternBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      policypatset_pattern_binding policypatsetPatternBinding = new policypatset_pattern_binding();
      policypatsetPatternBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      policypatset_pattern_binding[] policypatsetPatternBindingArray = (policypatset_pattern_binding[]) policypatsetPatternBinding.getfiltered(service, option);
      return policypatsetPatternBindingArray != null && policypatsetPatternBindingArray.Length > 0 ? policypatsetPatternBindingArray[0].__count.Value : 0U;
    }

    private class policypatset_pattern_binding_response : base_response
    {
      public policypatset_pattern_binding[] policypatset_pattern_binding = (policypatset_pattern_binding[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class charsetEnum
    {
      public const string ASCII = "ASCII";
      public const string UTF_8 = "UTF_8";
    }
  }
}
