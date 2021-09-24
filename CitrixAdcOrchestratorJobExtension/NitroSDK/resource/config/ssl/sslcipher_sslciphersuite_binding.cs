// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcipher_sslciphersuite_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcipher_sslciphersuite_binding : base_resource
  {
    private string ciphernameField = (string) null;
    private string descriptionField = (string) null;
    private uint? cipherpriorityField = new uint?();
    private string ciphergroupnameField = (string) null;
    private string cipheroperationField = (string) null;
    private string ciphgrpalsField = (string) null;
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

    public string ciphgrpals
    {
      get => this.ciphgrpalsField;
      set => this.ciphgrpalsField = value;
    }

    public uint? cipherpriority
    {
      get => this.cipherpriorityField;
      set => this.cipherpriorityField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public string ciphergroupname
    {
      get => this.ciphergroupnameField;
      set => this.ciphergroupnameField = value;
    }

    public string cipheroperation
    {
      get => this.cipheroperationField;
      set => this.cipheroperationField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcipher_sslciphersuite_binding.sslcipher_sslciphersuite_binding_response sslciphersuiteBindingResponse = new sslcipher_sslciphersuite_binding.sslcipher_sslciphersuite_binding_response();
      sslcipher_sslciphersuite_binding.sslcipher_sslciphersuite_binding_response resource = (sslcipher_sslciphersuite_binding.sslcipher_sslciphersuite_binding_response) service.get_payload_formatter().string_to_resource(sslciphersuiteBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcipher_sslciphersuite_binding;
    }

    internal override string get_object_name() => this.ciphergroupname;

    public static base_response add(
      nitro_service client,
      sslcipher_sslciphersuite_binding resource)
    {
      return new sslcipher_sslciphersuite_binding()
      {
        ciphergroupname = resource.ciphergroupname,
        cipheroperation = resource.cipheroperation,
        ciphgrpals = resource.ciphgrpals,
        ciphername = resource.ciphername,
        cipherpriority = resource.cipherpriority
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslcipher_sslciphersuite_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcipher_sslciphersuite_binding[] sslciphersuiteBindingArray = new sslcipher_sslciphersuite_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslciphersuiteBindingArray[index] = new sslcipher_sslciphersuite_binding();
          sslciphersuiteBindingArray[index].ciphergroupname = resources[index].ciphergroupname;
          sslciphersuiteBindingArray[index].cipheroperation = resources[index].cipheroperation;
          sslciphersuiteBindingArray[index].ciphgrpals = resources[index].ciphgrpals;
          sslciphersuiteBindingArray[index].ciphername = resources[index].ciphername;
          sslciphersuiteBindingArray[index].cipherpriority = resources[index].cipherpriority;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslciphersuiteBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslcipher_sslciphersuite_binding resource)
    {
      return new sslcipher_sslciphersuite_binding()
      {
        ciphergroupname = resource.ciphergroupname,
        ciphername = resource.ciphername
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslcipher_sslciphersuite_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcipher_sslciphersuite_binding[] sslciphersuiteBindingArray = new sslcipher_sslciphersuite_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslciphersuiteBindingArray[index] = new sslcipher_sslciphersuite_binding();
          sslciphersuiteBindingArray[index].ciphergroupname = resources[index].ciphergroupname;
          sslciphersuiteBindingArray[index].ciphername = resources[index].ciphername;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslciphersuiteBindingArray);
      }
      return baseResponses;
    }

    public static sslcipher_sslciphersuite_binding[] get(
      nitro_service service,
      string ciphergroupname)
    {
      return (sslcipher_sslciphersuite_binding[]) new sslcipher_sslciphersuite_binding()
      {
        ciphergroupname = ciphergroupname
      }.get_resources(service, (options) null);
    }

    public static sslcipher_sslciphersuite_binding[] get_filtered(
      nitro_service service,
      string ciphergroupname,
      string filter)
    {
      sslcipher_sslciphersuite_binding sslciphersuiteBinding = new sslcipher_sslciphersuite_binding();
      sslciphersuiteBinding.ciphergroupname = ciphergroupname;
      options option = new options();
      option.set_filter(filter);
      return (sslcipher_sslciphersuite_binding[]) sslciphersuiteBinding.getfiltered(service, option);
    }

    public static sslcipher_sslciphersuite_binding[] get_filtered(
      nitro_service service,
      string ciphergroupname,
      filtervalue[] filter)
    {
      sslcipher_sslciphersuite_binding sslciphersuiteBinding = new sslcipher_sslciphersuite_binding();
      sslciphersuiteBinding.ciphergroupname = ciphergroupname;
      options option = new options();
      option.set_filter(filter);
      return (sslcipher_sslciphersuite_binding[]) sslciphersuiteBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string ciphergroupname)
    {
      sslcipher_sslciphersuite_binding sslciphersuiteBinding = new sslcipher_sslciphersuite_binding();
      sslciphersuiteBinding.ciphergroupname = ciphergroupname;
      options option = new options();
      option.set_count(true);
      sslcipher_sslciphersuite_binding[] resources = (sslcipher_sslciphersuite_binding[]) sslciphersuiteBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string ciphergroupname, string filter)
    {
      sslcipher_sslciphersuite_binding sslciphersuiteBinding = new sslcipher_sslciphersuite_binding();
      sslciphersuiteBinding.ciphergroupname = ciphergroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcipher_sslciphersuite_binding[] sslciphersuiteBindingArray = (sslcipher_sslciphersuite_binding[]) sslciphersuiteBinding.getfiltered(service, option);
      return sslciphersuiteBindingArray != null && sslciphersuiteBindingArray.Length > 0 ? sslciphersuiteBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string ciphergroupname,
      filtervalue[] filter)
    {
      sslcipher_sslciphersuite_binding sslciphersuiteBinding = new sslcipher_sslciphersuite_binding();
      sslciphersuiteBinding.ciphergroupname = ciphergroupname;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcipher_sslciphersuite_binding[] sslciphersuiteBindingArray = (sslcipher_sslciphersuite_binding[]) sslciphersuiteBinding.getfiltered(service, option);
      return sslciphersuiteBindingArray != null && sslciphersuiteBindingArray.Length > 0 ? sslciphersuiteBindingArray[0].__count.Value : 0U;
    }

    private class sslcipher_sslciphersuite_binding_response : base_response
    {
      public sslcipher_sslciphersuite_binding[] sslcipher_sslciphersuite_binding = (sslcipher_sslciphersuite_binding[]) null;
    }

    public static class cipheroperationEnum
    {
      public const string ADD = "ADD";
      public const string REM = "REM";
      public const string ORD = "ORD";
    }
  }
}
