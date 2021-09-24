﻿// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservice_sslcipher_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservice_sslcipher_binding : base_resource
  {
    private string cipheraliasnameField = (string) null;
    private string descriptionField = (string) null;
    private string servicenameField = (string) null;
    private string ciphernameField = (string) null;
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

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
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
      sslservice_sslcipher_binding.sslservice_sslcipher_binding_response sslcipherBindingResponse = new sslservice_sslcipher_binding.sslservice_sslcipher_binding_response();
      sslservice_sslcipher_binding.sslservice_sslcipher_binding_response resource = (sslservice_sslcipher_binding.sslservice_sslcipher_binding_response) service.get_payload_formatter().string_to_resource(sslcipherBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservice_sslcipher_binding;
    }

    internal override string get_object_name() => this.servicename;

    public static base_response add(
      nitro_service client,
      sslservice_sslcipher_binding resource)
    {
      return new sslservice_sslcipher_binding()
      {
        servicename = resource.servicename,
        ciphername = resource.ciphername
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslservice_sslcipher_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservice_sslcipher_binding[] sslcipherBindingArray = new sslservice_sslcipher_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherBindingArray[index] = new sslservice_sslcipher_binding();
          sslcipherBindingArray[index].servicename = resources[index].servicename;
          sslcipherBindingArray[index].ciphername = resources[index].ciphername;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslcipherBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslservice_sslcipher_binding resource)
    {
      return new sslservice_sslcipher_binding()
      {
        servicename = resource.servicename,
        ciphername = resource.ciphername
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslservice_sslcipher_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservice_sslcipher_binding[] sslcipherBindingArray = new sslservice_sslcipher_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcipherBindingArray[index] = new sslservice_sslcipher_binding();
          sslcipherBindingArray[index].servicename = resources[index].servicename;
          sslcipherBindingArray[index].ciphername = resources[index].ciphername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcipherBindingArray);
      }
      return baseResponses;
    }

    public static sslservice_sslcipher_binding[] get(
      nitro_service service,
      string servicename)
    {
      return (sslservice_sslcipher_binding[]) new sslservice_sslcipher_binding()
      {
        servicename = servicename
      }.get_resources(service, (options) null);
    }

    public static sslservice_sslcipher_binding[] get_filtered(
      nitro_service service,
      string servicename,
      string filter)
    {
      sslservice_sslcipher_binding sslcipherBinding = new sslservice_sslcipher_binding();
      sslcipherBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (sslservice_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
    }

    public static sslservice_sslcipher_binding[] get_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      sslservice_sslcipher_binding sslcipherBinding = new sslservice_sslcipher_binding();
      sslcipherBinding.servicename = servicename;
      options option = new options();
      option.set_filter(filter);
      return (sslservice_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicename)
    {
      sslservice_sslcipher_binding sslcipherBinding = new sslservice_sslcipher_binding();
      sslcipherBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      sslservice_sslcipher_binding[] resources = (sslservice_sslcipher_binding[]) sslcipherBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string servicename, string filter)
    {
      sslservice_sslcipher_binding sslcipherBinding = new sslservice_sslcipher_binding();
      sslcipherBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservice_sslcipher_binding[] sslcipherBindingArray = (sslservice_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
      return sslcipherBindingArray != null && sslcipherBindingArray.Length > 0 ? sslcipherBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicename,
      filtervalue[] filter)
    {
      sslservice_sslcipher_binding sslcipherBinding = new sslservice_sslcipher_binding();
      sslcipherBinding.servicename = servicename;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservice_sslcipher_binding[] sslcipherBindingArray = (sslservice_sslcipher_binding[]) sslcipherBinding.getfiltered(service, option);
      return sslcipherBindingArray != null && sslcipherBindingArray.Length > 0 ? sslcipherBindingArray[0].__count.Value : 0U;
    }

    private class sslservice_sslcipher_binding_response : base_response
    {
      public sslservice_sslcipher_binding[] sslservice_sslcipher_binding = (sslservice_sslcipher_binding[]) null;
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class ocspcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }
  }
}
