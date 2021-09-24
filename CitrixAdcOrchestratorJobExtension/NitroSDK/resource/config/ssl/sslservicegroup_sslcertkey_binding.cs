// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslservicegroup_sslcertkey_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslservicegroup_sslcertkey_binding : base_resource
  {
    private string certkeynameField = (string) null;
    private string crlcheckField = (string) null;
    private string ocspcheckField = (string) null;
    private bool? caField = new bool?();
    private bool? snicertField = new bool?();
    private string servicegroupnameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
    }

    public bool? ca
    {
      get => this.caField;
      set => this.caField = value;
    }

    public string crlcheck
    {
      get => this.crlcheckField;
      set => this.crlcheckField = value;
    }

    public string certkeyname
    {
      get => this.certkeynameField;
      set => this.certkeynameField = value;
    }

    public bool? snicert
    {
      get => this.snicertField;
      set => this.snicertField = value;
    }

    public string ocspcheck
    {
      get => this.ocspcheckField;
      set => this.ocspcheckField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslservicegroup_sslcertkey_binding.sslservicegroup_sslcertkey_binding_response sslcertkeyBindingResponse = new sslservicegroup_sslcertkey_binding.sslservicegroup_sslcertkey_binding_response();
      sslservicegroup_sslcertkey_binding.sslservicegroup_sslcertkey_binding_response resource = (sslservicegroup_sslcertkey_binding.sslservicegroup_sslcertkey_binding_response) service.get_payload_formatter().string_to_resource(sslcertkeyBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslservicegroup_sslcertkey_binding;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static base_response add(
      nitro_service client,
      sslservicegroup_sslcertkey_binding resource)
    {
      return new sslservicegroup_sslcertkey_binding()
      {
        servicegroupname = resource.servicegroupname,
        certkeyname = resource.certkeyname,
        ca = resource.ca,
        crlcheck = resource.crlcheck,
        snicert = resource.snicert,
        ocspcheck = resource.ocspcheck
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslservicegroup_sslcertkey_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservicegroup_sslcertkey_binding[] sslcertkeyBindingArray = new sslservicegroup_sslcertkey_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyBindingArray[index] = new sslservicegroup_sslcertkey_binding();
          sslcertkeyBindingArray[index].servicegroupname = resources[index].servicegroupname;
          sslcertkeyBindingArray[index].certkeyname = resources[index].certkeyname;
          sslcertkeyBindingArray[index].ca = resources[index].ca;
          sslcertkeyBindingArray[index].crlcheck = resources[index].crlcheck;
          sslcertkeyBindingArray[index].snicert = resources[index].snicert;
          sslcertkeyBindingArray[index].ocspcheck = resources[index].ocspcheck;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslcertkeyBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslservicegroup_sslcertkey_binding resource)
    {
      return new sslservicegroup_sslcertkey_binding()
      {
        servicegroupname = resource.servicegroupname,
        certkeyname = resource.certkeyname,
        ca = resource.ca,
        crlcheck = resource.crlcheck,
        snicert = resource.snicert
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslservicegroup_sslcertkey_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslservicegroup_sslcertkey_binding[] sslcertkeyBindingArray = new sslservicegroup_sslcertkey_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertkeyBindingArray[index] = new sslservicegroup_sslcertkey_binding();
          sslcertkeyBindingArray[index].servicegroupname = resources[index].servicegroupname;
          sslcertkeyBindingArray[index].certkeyname = resources[index].certkeyname;
          sslcertkeyBindingArray[index].ca = resources[index].ca;
          sslcertkeyBindingArray[index].crlcheck = resources[index].crlcheck;
          sslcertkeyBindingArray[index].snicert = resources[index].snicert;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcertkeyBindingArray);
      }
      return baseResponses;
    }

    public static sslservicegroup_sslcertkey_binding[] get(
      nitro_service service,
      string servicegroupname)
    {
      return (sslservicegroup_sslcertkey_binding[]) new sslservicegroup_sslcertkey_binding()
      {
        servicegroupname = servicegroupname
      }.get_resources(service, (options) null);
    }

    public static sslservicegroup_sslcertkey_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      sslservicegroup_sslcertkey_binding sslcertkeyBinding = new sslservicegroup_sslcertkey_binding();
      sslcertkeyBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (sslservicegroup_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
    }

    public static sslservicegroup_sslcertkey_binding[] get_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      sslservicegroup_sslcertkey_binding sslcertkeyBinding = new sslservicegroup_sslcertkey_binding();
      sslcertkeyBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_filter(filter);
      return (sslservicegroup_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string servicegroupname)
    {
      sslservicegroup_sslcertkey_binding sslcertkeyBinding = new sslservicegroup_sslcertkey_binding();
      sslcertkeyBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      sslservicegroup_sslcertkey_binding[] resources = (sslservicegroup_sslcertkey_binding[]) sslcertkeyBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      string filter)
    {
      sslservicegroup_sslcertkey_binding sslcertkeyBinding = new sslservicegroup_sslcertkey_binding();
      sslcertkeyBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservicegroup_sslcertkey_binding[] sslcertkeyBindingArray = (sslservicegroup_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
      return sslcertkeyBindingArray != null && sslcertkeyBindingArray.Length > 0 ? sslcertkeyBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string servicegroupname,
      filtervalue[] filter)
    {
      sslservicegroup_sslcertkey_binding sslcertkeyBinding = new sslservicegroup_sslcertkey_binding();
      sslcertkeyBinding.servicegroupname = servicegroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslservicegroup_sslcertkey_binding[] sslcertkeyBindingArray = (sslservicegroup_sslcertkey_binding[]) sslcertkeyBinding.getfiltered(service, option);
      return sslcertkeyBindingArray != null && sslcertkeyBindingArray.Length > 0 ? sslcertkeyBindingArray[0].__count.Value : 0U;
    }

    private class sslservicegroup_sslcertkey_binding_response : base_response
    {
      public sslservicegroup_sslcertkey_binding[] sslservicegroup_sslcertkey_binding = (sslservicegroup_sslcertkey_binding[]) null;
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
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
