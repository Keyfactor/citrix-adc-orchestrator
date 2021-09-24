// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.rnat
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class rnat : base_resource
  {
    private string networkField = (string) null;
    private string netmaskField = (string) null;
    private string aclnameField = (string) null;
    private bool? redirectportField = new bool?();
    private string natipField = (string) null;
    private uint? tdField = new uint?();
    private string ownergroupField = (string) null;
    private string natip2Field = (string) null;
    private string srcippersistencyField = (string) null;
    private string useproxyportField = (string) null;
    private string connfailoverField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string network
    {
      get => this.networkField;
      set => this.networkField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public string aclname
    {
      get => this.aclnameField;
      set => this.aclnameField = value;
    }

    public bool? redirectport
    {
      get => this.redirectportField;
      set => this.redirectportField = value;
    }

    public string natip
    {
      get => this.natipField;
      set => this.natipField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string ownergroup
    {
      get => this.ownergroupField;
      set => this.ownergroupField = value;
    }

    public string natip2
    {
      get => this.natip2Field;
      set => this.natip2Field = value;
    }

    public string srcippersistency
    {
      get => this.srcippersistencyField;
      set => this.srcippersistencyField = value;
    }

    public string useproxyport
    {
      get => this.useproxyportField;
      set => this.useproxyportField = value;
    }

    public string connfailover
    {
      get => this.connfailoverField;
      set => this.connfailoverField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      rnat.rnat_response rnatResponse = new rnat.rnat_response();
      rnat.rnat_response resource = (rnat.rnat_response) service.get_payload_formatter().string_to_resource(rnatResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.rnat;
    }

    internal override string get_object_name() => (string) null;

    public static base_response clear(nitro_service client, rnat resource) => new rnat()
    {
      network = resource.network,
      netmask = resource.netmask,
      aclname = resource.aclname,
      redirectport = resource.redirectport,
      natip = resource.natip,
      td = resource.td,
      ownergroup = resource.ownergroup
    }.perform_operation_byaction(client, nameof (clear));

    public static base_responses clear(nitro_service client, rnat[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat[] rnatArray = new rnat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnatArray[index] = new rnat();
          rnatArray[index].network = resources[index].network;
          rnatArray[index].netmask = resources[index].netmask;
          rnatArray[index].aclname = resources[index].aclname;
          rnatArray[index].redirectport = resources[index].redirectport;
          rnatArray[index].natip = resources[index].natip;
          rnatArray[index].td = resources[index].td;
          rnatArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) rnatArray, nameof (clear));
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, rnat resource) => new rnat()
    {
      network = resource.network,
      netmask = resource.netmask,
      natip = resource.natip,
      td = resource.td,
      aclname = resource.aclname,
      redirectport = resource.redirectport,
      natip2 = resource.natip2,
      srcippersistency = resource.srcippersistency,
      useproxyport = resource.useproxyport,
      ownergroup = resource.ownergroup,
      connfailover = resource.connfailover
    }.update_resource(client);

    public static base_responses update(nitro_service client, rnat[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat[] rnatArray = new rnat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnatArray[index] = new rnat();
          rnatArray[index].network = resources[index].network;
          rnatArray[index].netmask = resources[index].netmask;
          rnatArray[index].natip = resources[index].natip;
          rnatArray[index].td = resources[index].td;
          rnatArray[index].aclname = resources[index].aclname;
          rnatArray[index].redirectport = resources[index].redirectport;
          rnatArray[index].natip2 = resources[index].natip2;
          rnatArray[index].srcippersistency = resources[index].srcippersistency;
          rnatArray[index].useproxyport = resources[index].useproxyport;
          rnatArray[index].ownergroup = resources[index].ownergroup;
          rnatArray[index].connfailover = resources[index].connfailover;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) rnatArray);
      }
      return baseResponses;
    }

    public static base_response unset(
      nitro_service client,
      rnat resource,
      string[] args)
    {
      return new rnat()
      {
        network = resource.network,
        netmask = resource.netmask,
        td = resource.td,
        aclname = resource.aclname,
        redirectport = resource.redirectport,
        natip = resource.natip,
        ownergroup = resource.ownergroup
      }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      rnat[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        rnat[] rnatArray = new rnat[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          rnatArray[index] = new rnat();
          rnatArray[index].network = resources[index].network;
          rnatArray[index].netmask = resources[index].netmask;
          rnatArray[index].td = resources[index].td;
          rnatArray[index].aclname = resources[index].aclname;
          rnatArray[index].redirectport = resources[index].redirectport;
          rnatArray[index].natip = resources[index].natip;
          rnatArray[index].ownergroup = resources[index].ownergroup;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) rnatArray, args);
      }
      return baseResponses;
    }

    public static rnat[] get(nitro_service service) => (rnat[]) new rnat().get_resources(service, (options) null);

    public static rnat[] get(nitro_service service, options option) => (rnat[]) new rnat().get_resources(service, option);

    public static rnat[] get_filtered(nitro_service service, string filter)
    {
      rnat rnat = new rnat();
      options option = new options();
      option.set_filter(filter);
      return (rnat[]) rnat.getfiltered(service, option);
    }

    public static rnat[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      rnat rnat = new rnat();
      options option = new options();
      option.set_filter(filter);
      return (rnat[]) rnat.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      rnat rnat = new rnat();
      options option = new options();
      option.set_count(true);
      rnat[] resources = (rnat[]) rnat.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      rnat rnat = new rnat();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnat[] rnatArray = (rnat[]) rnat.getfiltered(service, option);
      return rnatArray != null && rnatArray.Length > 0 ? rnatArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      rnat rnat = new rnat();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      rnat[] rnatArray = (rnat[]) rnat.getfiltered(service, option);
      return rnatArray != null && rnatArray.Length > 0 ? rnatArray[0].__count.Value : 0U;
    }

    private class rnat_response : base_response
    {
      public rnat[] rnat = (rnat[]) null;
    }

    public static class srcippersistencyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class useproxyportEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class connfailoverEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
