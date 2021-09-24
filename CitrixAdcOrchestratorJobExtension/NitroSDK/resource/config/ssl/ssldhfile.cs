// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.ssldhfile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class ssldhfile : base_resource
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
      ssldhfile.ssldhfile_response ssldhfileResponse = new ssldhfile.ssldhfile_response();
      ssldhfile.ssldhfile_response resource = (ssldhfile.ssldhfile_response) service.get_payload_formatter().string_to_resource(ssldhfileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.ssldhfile;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Import(nitro_service client, ssldhfile resource) => new ssldhfile()
    {
      name = resource.name,
      src = resource.src
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(nitro_service client, ssldhfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ssldhfile[] ssldhfileArray = new ssldhfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ssldhfileArray[index] = new ssldhfile();
          ssldhfileArray[index].name = resources[index].name;
          ssldhfileArray[index].src = resources[index].src;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) ssldhfileArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, ssldhfile resource) => new ssldhfile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, ssldhfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        ssldhfile[] ssldhfileArray = new ssldhfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          ssldhfileArray[index] = new ssldhfile();
          ssldhfileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) ssldhfileArray);
      }
      return baseResponses;
    }

    public static ssldhfile[] get(nitro_service service) => (ssldhfile[]) new ssldhfile().get_resources(service, (options) null);

    public static ssldhfile[] get(nitro_service service, options option) => (ssldhfile[]) new ssldhfile().get_resources(service, option);

    public static ssldhfile[] get_filtered(nitro_service service, string filter)
    {
      ssldhfile ssldhfile = new ssldhfile();
      options option = new options();
      option.set_filter(filter);
      return (ssldhfile[]) ssldhfile.getfiltered(service, option);
    }

    public static ssldhfile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      ssldhfile ssldhfile = new ssldhfile();
      options option = new options();
      option.set_filter(filter);
      return (ssldhfile[]) ssldhfile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      ssldhfile ssldhfile = new ssldhfile();
      options option = new options();
      option.set_count(true);
      ssldhfile[] resources = (ssldhfile[]) ssldhfile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      ssldhfile ssldhfile = new ssldhfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ssldhfile[] ssldhfileArray = (ssldhfile[]) ssldhfile.getfiltered(service, option);
      return ssldhfileArray != null && ssldhfileArray.Length > 0 ? ssldhfileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      ssldhfile ssldhfile = new ssldhfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      ssldhfile[] ssldhfileArray = (ssldhfile[]) ssldhfile.getfiltered(service, option);
      return ssldhfileArray != null && ssldhfileArray.Length > 0 ? ssldhfileArray[0].__count.Value : 0U;
    }

    private class ssldhfile_response : base_response
    {
      public ssldhfile[] ssldhfile = (ssldhfile[]) null;
    }
  }
}
