﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslprofile_sslcipher_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslprofile_sslcipher_binding : base_resource
  {
    private string cipheraliasnameField = (string) null;
    private uint? cipherpriorityField = new uint?();
    private string descriptionField = (string) null;
    private string ciphernameField = (string) null;
    private string nameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string ciphername
    {
      get => this.ciphernameField;
      set => this.ciphernameField = value;
    }

    public string cipheraliasname
    {
      get => this.cipheraliasnameField;
      set => this.cipheraliasnameField = value;
    }

    public uint? cipherpriority
    {
      get => this.cipherpriorityField;
      set => this.cipherpriorityField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslprofile_sslcipher_binding.sslprofile_sslcipher_binding_response sslcipherBindingResponse = new sslprofile_sslcipher_binding.sslprofile_sslcipher_binding_response();
      sslprofile_sslcipher_binding.sslprofile_sslcipher_binding_response resource = (sslprofile_sslcipher_binding.sslprofile_sslcipher_binding_response) service.get_payload_formatter().string_to_resource(sslcipherBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslprofile_sslcipher_binding;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(
      nitro_service client,
      sslprofile_sslcipher_binding resource)
    {
      return new sslprofile_sslcipher_binding()
      {
        name = resource.name,
        ciphername = resource.ciphername,
        cipherpriority = resource.cipherpriority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslprofile_sslcipher_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslprofile_sslcipher_binding[] sslcipherBindingArray = new sslprofile_sslcipher_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherBindingArray[index] = new sslprofile_sslcipher_binding();
          sslcipherBindingArray[index].name = resources[index].name;
          sslcipherBindingArray[index].ciphername = resources[index].ciphername;
          sslcipherBindingArray[index].cipherpriority = resources[index].cipherpriority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslcipherBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslprofile_sslcipher_binding resource)
    {
      return new sslprofile_sslcipher_binding()
      {
        name = resource.name,
        ciphername = resource.ciphername
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslprofile_sslcipher_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslprofile_sslcipher_binding[] sslcipherBindingArray = new sslprofile_sslcipher_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherBindingArray[index] = new sslprofile_sslcipher_binding();
          sslcipherBindingArray[index].name = resources[index].name;
          sslcipherBindingArray[index].ciphername = resources[index].ciphername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcipherBindingArray);
      }
      return baseResponses;
    }

    public static sslprofile_sslcipher_binding[] get(
      nitro_service service,
      string name)
    {
      return (sslprofile_sslcipher_binding[]) new sslprofile_sslcipher_binding()
      {
        name = name
      }.get_resources(service, (options) null);
    }

    public static sslprofile_sslcipher_binding[] get_filtered(
      nitro_service service,
      string name,
      string filter)
    {
      sslprofile_sslcipher_binding sslcipherBinding = new sslprofile_sslcipher_binding();
      sslcipherBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (sslprofile_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
    }

    public static sslprofile_sslcipher_binding[] get_filtered(
      nitro_service service,
      string name,
      filtervalue[] filter)
    {
      sslprofile_sslcipher_binding sslcipherBinding = new sslprofile_sslcipher_binding();
      sslcipherBinding.name = name;
      options option = new options();
      option.set_filter(filter);
      return (sslprofile_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string name)
    {
      sslprofile_sslcipher_binding sslcipherBinding = new sslprofile_sslcipher_binding();
      sslcipherBinding.name = name;
      options option = new options();
      option.set_count(true);
      sslprofile_sslcipher_binding[] resources = (sslprofile_sslcipher_binding[]) sslcipherBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, string filter)
    {
      sslprofile_sslcipher_binding sslcipherBinding = new sslprofile_sslcipher_binding();
      sslcipherBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslprofile_sslcipher_binding[] sslcipherBindingArray = (sslprofile_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
      return sslcipherBindingArray != null && sslcipherBindingArray.Length > 0 ? sslcipherBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string name, filtervalue[] filter)
    {
      sslprofile_sslcipher_binding sslcipherBinding = new sslprofile_sslcipher_binding();
      sslcipherBinding.name = name;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslprofile_sslcipher_binding[] sslcipherBindingArray = (sslprofile_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
      return sslcipherBindingArray != null && sslcipherBindingArray.Length > 0 ? sslcipherBindingArray[0].__count.Value : 0U;
    }

    private class sslprofile_sslcipher_binding_response : base_response
    {
      public sslprofile_sslcipher_binding[] sslprofile_sslcipher_binding = (sslprofile_sslcipher_binding[]) null;
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
    }
  }
}
