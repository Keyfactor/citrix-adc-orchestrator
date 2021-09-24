// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.vpn.vpnepaprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.vpn
{
  public class vpnepaprofile : base_resource
  {
    private string nameField = (string) null;
    private string filenameField = (string) null;
    private string dataField = (string) null;
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

    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    public string data
    {
      get => this.dataField;
      set => this.dataField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      vpnepaprofile.vpnepaprofile_response vpnepaprofileResponse = new vpnepaprofile.vpnepaprofile_response();
      vpnepaprofile.vpnepaprofile_response resource = (vpnepaprofile.vpnepaprofile_response) service.get_payload_formatter().string_to_resource(vpnepaprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.vpnepaprofile;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, vpnepaprofile resource) => new vpnepaprofile()
    {
      name = resource.name,
      filename = resource.filename,
      data = resource.data
    }.add_resource(client);

    public static base_responses add(nitro_service client, vpnepaprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnepaprofile[] vpnepaprofileArray = new vpnepaprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnepaprofileArray[index] = new vpnepaprofile();
          vpnepaprofileArray[index].name = resources[index].name;
          vpnepaprofileArray[index].filename = resources[index].filename;
          vpnepaprofileArray[index].data = resources[index].data;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) vpnepaprofileArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new vpnepaprofile()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, vpnepaprofile resource) => new vpnepaprofile()
    {
      name = resource.name
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        vpnepaprofile[] vpnepaprofileArray = new vpnepaprofile[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          vpnepaprofileArray[index] = new vpnepaprofile();
          vpnepaprofileArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnepaprofileArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      vpnepaprofile[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        vpnepaprofile[] vpnepaprofileArray = new vpnepaprofile[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          vpnepaprofileArray[index] = new vpnepaprofile();
          vpnepaprofileArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) vpnepaprofileArray);
      }
      return baseResponses;
    }

    public static vpnepaprofile[] get(nitro_service service) => (vpnepaprofile[]) new vpnepaprofile().get_resources(service, (options) null);

    public static vpnepaprofile[] get(nitro_service service, options option) => (vpnepaprofile[]) new vpnepaprofile().get_resources(service, option);

    public static vpnepaprofile get(nitro_service service, string name) => (vpnepaprofile) new vpnepaprofile()
    {
      name = name
    }.get_resource(service);

    public static vpnepaprofile[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (vpnepaprofile[]) null;
      vpnepaprofile[] vpnepaprofileArray1 = new vpnepaprofile[name.Length];
      vpnepaprofile[] vpnepaprofileArray2 = new vpnepaprofile[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        vpnepaprofileArray2[index] = new vpnepaprofile();
        vpnepaprofileArray2[index].name = name[index];
        vpnepaprofileArray1[index] = (vpnepaprofile) vpnepaprofileArray2[index].get_resource(service);
      }
      return vpnepaprofileArray1;
    }

    public static vpnepaprofile[] get_filtered(nitro_service service, string filter)
    {
      vpnepaprofile vpnepaprofile = new vpnepaprofile();
      options option = new options();
      option.set_filter(filter);
      return (vpnepaprofile[]) vpnepaprofile.getfiltered(service, option);
    }

    public static vpnepaprofile[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      vpnepaprofile vpnepaprofile = new vpnepaprofile();
      options option = new options();
      option.set_filter(filter);
      return (vpnepaprofile[]) vpnepaprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      vpnepaprofile vpnepaprofile = new vpnepaprofile();
      options option = new options();
      option.set_count(true);
      vpnepaprofile[] resources = (vpnepaprofile[]) vpnepaprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      vpnepaprofile vpnepaprofile = new vpnepaprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnepaprofile[] vpnepaprofileArray = (vpnepaprofile[]) vpnepaprofile.getfiltered(service, option);
      return vpnepaprofileArray != null && vpnepaprofileArray.Length > 0 ? vpnepaprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      vpnepaprofile vpnepaprofile = new vpnepaprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      vpnepaprofile[] vpnepaprofileArray = (vpnepaprofile[]) vpnepaprofile.getfiltered(service, option);
      return vpnepaprofileArray != null && vpnepaprofileArray.Length > 0 ? vpnepaprofileArray[0].__count.Value : 0U;
    }

    private class vpnepaprofile_response : base_response
    {
      public vpnepaprofile[] vpnepaprofile = (vpnepaprofile[]) null;
    }
  }
}
