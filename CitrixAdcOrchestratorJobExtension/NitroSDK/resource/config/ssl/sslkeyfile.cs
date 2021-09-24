// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslkeyfile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslkeyfile : base_resource
  {
    private string nameField = (string) null;
    private string srcField = (string) null;
    private string passwordField = (string) null;
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

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslkeyfile.sslkeyfile_response sslkeyfileResponse = new sslkeyfile.sslkeyfile_response();
      sslkeyfile.sslkeyfile_response resource = (sslkeyfile.sslkeyfile_response) service.get_payload_formatter().string_to_resource(sslkeyfileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslkeyfile;
    }

    internal override string get_object_name() => (string) null;

    public static base_response Import(nitro_service client, sslkeyfile resource) => new sslkeyfile()
    {
      name = resource.name,
      src = resource.src,
      password = resource.password
    }.perform_operation_byaction(client, nameof (Import));

    public static base_responses Import(nitro_service client, sslkeyfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslkeyfile[] sslkeyfileArray = new sslkeyfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslkeyfileArray[index] = new sslkeyfile();
          sslkeyfileArray[index].name = resources[index].name;
          sslkeyfileArray[index].src = resources[index].src;
          sslkeyfileArray[index].password = resources[index].password;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) sslkeyfileArray, nameof (Import));
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, sslkeyfile resource) => new sslkeyfile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, sslkeyfile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslkeyfile[] sslkeyfileArray = new sslkeyfile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslkeyfileArray[index] = new sslkeyfile();
          sslkeyfileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslkeyfileArray);
      }
      return baseResponses;
    }

    public static sslkeyfile[] get(nitro_service service) => (sslkeyfile[]) new sslkeyfile().get_resources(service, (options) null);

    public static sslkeyfile[] get(nitro_service service, options option) => (sslkeyfile[]) new sslkeyfile().get_resources(service, option);

    public static sslkeyfile[] get_filtered(nitro_service service, string filter)
    {
      sslkeyfile sslkeyfile = new sslkeyfile();
      options option = new options();
      option.set_filter(filter);
      return (sslkeyfile[]) sslkeyfile.getfiltered(service, option);
    }

    public static sslkeyfile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      sslkeyfile sslkeyfile = new sslkeyfile();
      options option = new options();
      option.set_filter(filter);
      return (sslkeyfile[]) sslkeyfile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      sslkeyfile sslkeyfile = new sslkeyfile();
      options option = new options();
      option.set_count(true);
      sslkeyfile[] resources = (sslkeyfile[]) sslkeyfile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      sslkeyfile sslkeyfile = new sslkeyfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslkeyfile[] sslkeyfileArray = (sslkeyfile[]) sslkeyfile.getfiltered(service, option);
      return sslkeyfileArray != null && sslkeyfileArray.Length > 0 ? sslkeyfileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      sslkeyfile sslkeyfile = new sslkeyfile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslkeyfile[] sslkeyfileArray = (sslkeyfile[]) sslkeyfile.getfiltered(service, option);
      return sslkeyfileArray != null && sslkeyfileArray.Length > 0 ? sslkeyfileArray[0].__count.Value : 0U;
    }

    private class sslkeyfile_response : base_response
    {
      public sslkeyfile[] sslkeyfile = (sslkeyfile[]) null;
    }
  }
}
