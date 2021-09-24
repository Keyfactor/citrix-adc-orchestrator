// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcertfile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcertfile : base_resource
  {
    private string nameField = (string) null;
    private string srcField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string src
    {
      get => this.srcField;
      set => this.srcField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcertfile.sslcertfile_response sslcertfileResponse = new sslcertfile.sslcertfile_response();
      sslcertfile.sslcertfile_response resource = (sslcertfile.sslcertfile_response) service.get_payload_formatter().string_to_resource(sslcertfileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcertfile;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Import(nitro_service client, sslcertfile resource) => new sslcertfile()
    {
      name = resource.name,
      src = resource.src
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(nitro_service client, sslcertfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertfile[] sslcertfileArray = new sslcertfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertfileArray[index] = new sslcertfile();
          sslcertfileArray[index].name = resources[index].name;
          sslcertfileArray[index].src = resources[index].src;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslcertfileArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, sslcertfile resource) => new sslcertfile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, sslcertfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcertfile[] sslcertfileArray = new sslcertfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcertfileArray[index] = new sslcertfile();
          sslcertfileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcertfileArray);
      }
      return baseResponses;
    }

    public static sslcertfile[] get(nitro_service service) => (sslcertfile[]) new sslcertfile().get_resources(service, (options) null);

    public static sslcertfile[] get(nitro_service service, options option) => (sslcertfile[]) new sslcertfile().get_resources(service, option);

    public static sslcertfile[] get_filtered(nitro_service service, string filter)
    {
      sslcertfile sslcertfile = new sslcertfile();
      options option = new options();
      option.set_filter(filter);
      return (sslcertfile[]) sslcertfile.getfiltered(service, option);
    }

    public static sslcertfile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertfile sslcertfile = new sslcertfile();
      options option = new options();
      option.set_filter(filter);
      return (sslcertfile[]) sslcertfile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcertfile sslcertfile = new sslcertfile();
      options option = new options();
      option.set_count(true);
      sslcertfile[] resources = (sslcertfile[]) sslcertfile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcertfile sslcertfile = new sslcertfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertfile[] sslcertfileArray = (sslcertfile[]) sslcertfile.getfiltered(service, option);
      return sslcertfileArray != null && sslcertfileArray.Length > 0 ? sslcertfileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcertfile sslcertfile = new sslcertfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcertfile[] sslcertfileArray = (sslcertfile[]) sslcertfile.getfiltered(service, option);
      return sslcertfileArray != null && sslcertfileArray.Length > 0 ? sslcertfileArray[0].__count.Value : 0U;
    }

    private class sslcertfile_response : base_response
    {
      public sslcertfile[] sslcertfile = (sslcertfile[]) null;
    }
  }
}
