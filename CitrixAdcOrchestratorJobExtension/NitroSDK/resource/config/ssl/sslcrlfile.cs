// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcrlfile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcrlfile : base_resource
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
      sslcrlfile.sslcrlfile_response sslcrlfileResponse = new sslcrlfile.sslcrlfile_response();
      sslcrlfile.sslcrlfile_response resource = (sslcrlfile.sslcrlfile_response) service.get_payload_formatter().string_to_resource(sslcrlfileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcrlfile;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Import(nitro_service client, sslcrlfile resource) => new sslcrlfile()
    {
      name = resource.name,
      src = resource.src
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(nitro_service client, sslcrlfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrlfile[] sslcrlfileArray = new sslcrlfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlfileArray[index] = new sslcrlfile();
          sslcrlfileArray[index].name = resources[index].name;
          sslcrlfileArray[index].src = resources[index].src;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslcrlfileArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, sslcrlfile resource) => new sslcrlfile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, sslcrlfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslcrlfile[] sslcrlfileArray = new sslcrlfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslcrlfileArray[index] = new sslcrlfile();
          sslcrlfileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslcrlfileArray);
      }
      return baseResponses;
    }

    public static sslcrlfile[] get(nitro_service service) => (sslcrlfile[]) new sslcrlfile().get_resources(service, (options) null);

    public static sslcrlfile[] get(nitro_service service, options option) => (sslcrlfile[]) new sslcrlfile().get_resources(service, option);

    public static sslcrlfile[] get_filtered(nitro_service service, string filter)
    {
      sslcrlfile sslcrlfile = new sslcrlfile();
      options option = new options();
      option.set_filter(filter);
      return (sslcrlfile[]) sslcrlfile.getfiltered(service, option);
    }

    public static sslcrlfile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcrlfile sslcrlfile = new sslcrlfile();
      options option = new options();
      option.set_filter(filter);
      return (sslcrlfile[]) sslcrlfile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslcrlfile sslcrlfile = new sslcrlfile();
      options option = new options();
      option.set_count(true);
      sslcrlfile[] resources = (sslcrlfile[]) sslcrlfile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslcrlfile sslcrlfile = new sslcrlfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcrlfile[] sslcrlfileArray = (sslcrlfile[]) sslcrlfile.getfiltered(service, option);
      return sslcrlfileArray != null && sslcrlfileArray.Length > 0 ? sslcrlfileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslcrlfile sslcrlfile = new sslcrlfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslcrlfile[] sslcrlfileArray = (sslcrlfile[]) sslcrlfile.getfiltered(service, option);
      return sslcrlfileArray != null && sslcrlfileArray.Length > 0 ? sslcrlfileArray[0].__count.Value : 0U;
    }

    private class sslcrlfile_response : base_response
    {
      public sslcrlfile[] sslcrlfile = (sslcrlfile[]) null;
    }
  }
}
