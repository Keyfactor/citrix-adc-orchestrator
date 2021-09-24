// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertkey_sslocspresponder_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertkey_sslocspresponder_binding : base_resource
  {
    private string ocspresponderField = (string) null;
    private uint? priorityField = new uint?();
    private string certkeyField = (string) null;
    private bool? caField = new bool?();
    private string crlcheckField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public uint? priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
    }

    public string crlcheck
    {
      get => this.crlcheckField;
      set => this.crlcheckField = value;
    }

    public bool? ca
    {
      get => this.caField;
      set => this.caField = value;
    }

    public string certkey
    {
      get => this.certkeyField;
      set => this.certkeyField = value;
    }

    public string ocspresponder
    {
      get => this.ocspresponderField;
      set => this.ocspresponderField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertkey_sslocspresponder_binding.sslcertkey_sslocspresponder_binding_response sslocspresponderBindingResponse = new sslcertkey_sslocspresponder_binding.sslcertkey_sslocspresponder_binding_response();
      sslcertkey_sslocspresponder_binding.sslcertkey_sslocspresponder_binding_response resource = (sslcertkey_sslocspresponder_binding.sslcertkey_sslocspresponder_binding_response) service.get_payload_formatter().string_to_resource(sslocspresponderBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertkey_sslocspresponder_binding;
    }

    internal override string get_object_name() => this.certkey;

    public static base_response add(
      nitro_service client,
      sslcertkey_sslocspresponder_binding resource)
    {
      return new sslcertkey_sslocspresponder_binding()
      {
        certkey = resource.certkey,
        ocspresponder = resource.ocspresponder,
        priority = resource.priority,
        ca = resource.ca,
        crlcheck = resource.crlcheck
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslcertkey_sslocspresponder_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey_sslocspresponder_binding[] sslocspresponderBindingArray = new sslcertkey_sslocspresponder_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslocspresponderBindingArray[index] = new sslcertkey_sslocspresponder_binding();
          sslocspresponderBindingArray[index].certkey = resources[index].certkey;
          sslocspresponderBindingArray[index].ocspresponder = resources[index].ocspresponder;
          sslocspresponderBindingArray[index].priority = resources[index].priority;
          sslocspresponderBindingArray[index].ca = resources[index].ca;
          sslocspresponderBindingArray[index].crlcheck = resources[index].crlcheck;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslocspresponderBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslcertkey_sslocspresponder_binding resource)
    {
      return new sslcertkey_sslocspresponder_binding()
      {
        certkey = resource.certkey,
        ocspresponder = resource.ocspresponder,
        ca = resource.ca
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslcertkey_sslocspresponder_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertkey_sslocspresponder_binding[] sslocspresponderBindingArray = new sslcertkey_sslocspresponder_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslocspresponderBindingArray[index] = new sslcertkey_sslocspresponder_binding();
          sslocspresponderBindingArray[index].certkey = resources[index].certkey;
          sslocspresponderBindingArray[index].ocspresponder = resources[index].ocspresponder;
          sslocspresponderBindingArray[index].ca = resources[index].ca;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslocspresponderBindingArray);
      }
      return baseResponses;
    }

    public static sslcertkey_sslocspresponder_binding[] get(
      nitro_service service,
      string certkey)
    {
      return (sslcertkey_sslocspresponder_binding[]) new sslcertkey_sslocspresponder_binding()
      {
        certkey = certkey
      }.get_resources(service, (options) null);
    }

    public static sslcertkey_sslocspresponder_binding[] get_filtered(
      nitro_service service,
      string certkey,
      string filter)
    {
      sslcertkey_sslocspresponder_binding sslocspresponderBinding = new sslcertkey_sslocspresponder_binding();
      sslocspresponderBinding.certkey = certkey;
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey_sslocspresponder_binding[]) sslocspresponderBinding.getfiltered(service, option);
    }

    public static sslcertkey_sslocspresponder_binding[] get_filtered(
      nitro_service service,
      string certkey,
      filtervalue[] filter)
    {
      sslcertkey_sslocspresponder_binding sslocspresponderBinding = new sslcertkey_sslocspresponder_binding();
      sslocspresponderBinding.certkey = certkey;
      options option = new options();
      option.set_filter(filter);
      return (sslcertkey_sslocspresponder_binding[]) sslocspresponderBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string certkey)
    {
      sslcertkey_sslocspresponder_binding sslocspresponderBinding = new sslcertkey_sslocspresponder_binding();
      sslocspresponderBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      sslcertkey_sslocspresponder_binding[] resources = (sslcertkey_sslocspresponder_binding[]) sslocspresponderBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkey, string filter)
    {
      sslcertkey_sslocspresponder_binding sslocspresponderBinding = new sslcertkey_sslocspresponder_binding();
      sslocspresponderBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey_sslocspresponder_binding[] sslocspresponderBindingArray = (sslcertkey_sslocspresponder_binding[]) sslocspresponderBinding.getfiltered(service, option);
      return sslocspresponderBindingArray != null && sslocspresponderBindingArray.Length > 0 ? sslocspresponderBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string certkey, filtervalue[] filter)
    {
      sslcertkey_sslocspresponder_binding sslocspresponderBinding = new sslcertkey_sslocspresponder_binding();
      sslocspresponderBinding.certkey = certkey;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertkey_sslocspresponder_binding[] sslocspresponderBindingArray = (sslcertkey_sslocspresponder_binding[]) sslocspresponderBinding.getfiltered(service, option);
      return sslocspresponderBindingArray != null && sslocspresponderBindingArray.Length > 0 ? sslocspresponderBindingArray[0].__count.Value : 0U;
    }

    private class sslcertkey_sslocspresponder_binding_response : base_response
    {
      public sslcertkey_sslocspresponder_binding[] sslcertkey_sslocspresponder_binding = (sslcertkey_sslocspresponder_binding[]) null;
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }
  }
}
