// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.forwardingsession
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class forwardingsession : base_resource
  {
    private string nameField = (string) null;
    private string networkField = (string) null;
    private string netmaskField = (string) null;
    private string acl6nameField = (string) null;
    private string aclnameField = (string) null;
    private uint? tdField = new uint?();
    private string connfailoverField = (string) null;
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

    public string acl6name
    {
      get => this.acl6nameField;
      set => this.acl6nameField = value;
    }

    public string aclname
    {
      get => this.aclnameField;
      set => this.aclnameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
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
      forwardingsession.forwardingsession_response forwardingsessionResponse = new forwardingsession.forwardingsession_response();
      forwardingsession.forwardingsession_response resource = (forwardingsession.forwardingsession_response) service.get_payload_formatter().string_to_resource(forwardingsessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.forwardingsession;
    }

    internal override string get_object_name() => this.name;

    public static base_response add(nitro_service client, forwardingsession resource) => new forwardingsession()
    {
      name = resource.name,
      network = resource.network,
      netmask = resource.netmask,
      acl6name = resource.acl6name,
      aclname = resource.aclname,
      td = resource.td,
      connfailover = resource.connfailover
    }.add_resource(client);

    public static base_responses add(
      nitro_service client,
      forwardingsession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        forwardingsession[] forwardingsessionArray = new forwardingsession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          forwardingsessionArray[index] = new forwardingsession();
          forwardingsessionArray[index].name = resources[index].name;
          forwardingsessionArray[index].network = resources[index].network;
          forwardingsessionArray[index].netmask = resources[index].netmask;
          forwardingsessionArray[index].acl6name = resources[index].acl6name;
          forwardingsessionArray[index].aclname = resources[index].aclname;
          forwardingsessionArray[index].td = resources[index].td;
          forwardingsessionArray[index].connfailover = resources[index].connfailover;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) forwardingsessionArray);
      }
      return baseResponses;
    }

    public static base_response update(
      nitro_service client,
      forwardingsession resource)
    {
      return new forwardingsession()
      {
        name = resource.name,
        connfailover = resource.connfailover
      }.update_resource(client);
    }

    public static base_responses update(
      nitro_service client,
      forwardingsession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        forwardingsession[] forwardingsessionArray = new forwardingsession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          forwardingsessionArray[index] = new forwardingsession();
          forwardingsessionArray[index].name = resources[index].name;
          forwardingsessionArray[index].connfailover = resources[index].connfailover;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) forwardingsessionArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, string name) => new forwardingsession()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(
      nitro_service client,
      forwardingsession resource)
    {
      return new forwardingsession()
      {
        name = resource.name
      }.delete_resource(client);
    }

    public static base_responses delete(nitro_service client, string[] name)
    {
      base_responses baseResponses = (base_responses) null;
      if (name != null && name.Length > 0)
      {
        forwardingsession[] forwardingsessionArray = new forwardingsession[name.Length];
        for (int index = 0; index < name.Length; ++index)
        {
          forwardingsessionArray[index] = new forwardingsession();
          forwardingsessionArray[index].name = name[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) forwardingsessionArray);
      }
      return baseResponses;
    }

    public static base_responses delete(
      nitro_service client,
      forwardingsession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        forwardingsession[] forwardingsessionArray = new forwardingsession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          forwardingsessionArray[index] = new forwardingsession();
          forwardingsessionArray[index].name = resources[index].name;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) forwardingsessionArray);
      }
      return baseResponses;
    }

    public static forwardingsession[] get(nitro_service service) => (forwardingsession[]) new forwardingsession().get_resources(service, (options) null);

    public static forwardingsession[] get(nitro_service service, options option) => (forwardingsession[]) new forwardingsession().get_resources(service, option);

    public static forwardingsession get(nitro_service service, string name) => (forwardingsession) new forwardingsession()
    {
      name = name
    }.get_resource(service);

    public static forwardingsession[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (forwardingsession[]) null;
      forwardingsession[] forwardingsessionArray1 = new forwardingsession[name.Length];
      forwardingsession[] forwardingsessionArray2 = new forwardingsession[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        forwardingsessionArray2[index] = new forwardingsession();
        forwardingsessionArray2[index].name = name[index];
        forwardingsessionArray1[index] = (forwardingsession) forwardingsessionArray2[index].get_resource(service);
      }
      return forwardingsessionArray1;
    }

    public static forwardingsession[] get_filtered(
      nitro_service service,
      string filter)
    {
      forwardingsession forwardingsession = new forwardingsession();
      options option = new options();
      option.set_filter(filter);
      return (forwardingsession[]) forwardingsession.getfiltered(service, option);
    }

    public static forwardingsession[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      forwardingsession forwardingsession = new forwardingsession();
      options option = new options();
      option.set_filter(filter);
      return (forwardingsession[]) forwardingsession.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      forwardingsession forwardingsession = new forwardingsession();
      options option = new options();
      option.set_count(true);
      forwardingsession[] resources = (forwardingsession[]) forwardingsession.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      forwardingsession forwardingsession = new forwardingsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      forwardingsession[] forwardingsessionArray = (forwardingsession[]) forwardingsession.getfiltered(service, option);
      return forwardingsessionArray != null && forwardingsessionArray.Length > 0 ? forwardingsessionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      forwardingsession forwardingsession = new forwardingsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      forwardingsession[] forwardingsessionArray = (forwardingsession[]) forwardingsession.getfiltered(service, option);
      return forwardingsessionArray != null && forwardingsessionArray.Length > 0 ? forwardingsessionArray[0].__count.Value : 0U;
    }

    private class forwardingsession_response : base_response
    {
      public forwardingsession[] forwardingsession = (forwardingsession[]) null;
    }

    public static class connfailoverEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
