// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nshostname
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nshostname : base_resource
  {
    private string hostnameField = (string) null;
    private uint? ownernodeField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string hostname
    {
      get => this.hostnameField;
      set => this.hostnameField = value;
    }

    public uint? ownernode
    {
      get => this.ownernodeField;
      set => this.ownernodeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nshostname.nshostname_response nshostnameResponse = new nshostname.nshostname_response();
      nshostname.nshostname_response resource = (nshostname.nshostname_response) service.get_payload_formatter().string_to_resource(nshostnameResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.nshostname;
    }

    internal override string get_object_name() => this.ownernode.HasValue ? this.ownernode.ToString() : (string) null;

    public static base_response update(nitro_service client, nshostname resource) => new nshostname()
    {
      hostname = resource.hostname,
      ownernode = resource.ownernode
    }.update_resource(client);

    public static base_responses update(nitro_service client, nshostname[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        nshostname[] nshostnameArray = new nshostname[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          nshostnameArray[index] = new nshostname();
          nshostnameArray[index].hostname = resources[index].hostname;
          nshostnameArray[index].ownernode = resources[index].ownernode;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) nshostnameArray);
      }
      return baseResponses;
    }

    public static nshostname[] get(nitro_service service) => (nshostname[]) new nshostname().get_resources(service, (options) null);

    public static nshostname[] get(nitro_service service, options option) => (nshostname[]) new nshostname().get_resources(service, option);

    public static nshostname[] get_filtered(nitro_service service, string filter)
    {
      nshostname nshostname = new nshostname();
      options option = new options();
      option.set_filter(filter);
      return (nshostname[]) nshostname.getfiltered(service, option);
    }

    public static nshostname[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      nshostname nshostname = new nshostname();
      options option = new options();
      option.set_filter(filter);
      return (nshostname[]) nshostname.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      nshostname nshostname = new nshostname();
      options option = new options();
      option.set_count(true);
      nshostname[] resources = (nshostname[]) nshostname.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      nshostname nshostname = new nshostname();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nshostname[] nshostnameArray = (nshostname[]) nshostname.getfiltered(service, option);
      return nshostnameArray != null && nshostnameArray.Length > 0 ? nshostnameArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      nshostname nshostname = new nshostname();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      nshostname[] nshostnameArray = (nshostname[]) nshostname.getfiltered(service, option);
      return nshostnameArray != null && nshostnameArray.Length > 0 ? nshostnameArray[0].__count.Value : 0U;
    }

    private class nshostname_response : base_response
    {
      public nshostname[] nshostname = (nshostname[]) null;
    }
  }
}
