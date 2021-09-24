// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ha.hanode
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ha
{
  public class hanode : base_resource
  {
    private uint? idField = new uint?();
    private string ipaddressField = (string) null;
    private string incField = (string) null;
    private string hastatusField = (string) null;
    private string hasyncField = (string) null;
    private string hapropField = (string) null;
    private uint? hellointervalField = new uint?();
    private long? deadintervalField = new long?();
    private string failsafeField = (string) null;
    private uint? maxflipsField = new uint?();
    private uint? maxfliptimeField = new uint?();
    private uint? syncvlanField = new uint?();
    private string nameField = (string) null;
    private uint? flagsField = new uint?();
    private string stateField = (string) null;
    private string enaifacesField = (string) null;
    private string disifacesField = (string) null;
    private string hamonifacesField = (string) null;
    private string pfifacesField = (string) null;
    private string ifacesField = (string) null;
    private string networkField = (string) null;
    private string netmaskField = (string) null;
    private string ssl2Field = (string) null;
    private long? masterstatetimeField = new long?();
    private string routemonitorField = (string) null;
    private uint? curflipsField = new uint?();
    private uint? completedfliptimeField = new uint?();
    private string routemonitorstateField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    public string inc
    {
      get => this.incField;
      set => this.incField = value;
    }

    public string hastatus
    {
      get => this.hastatusField;
      set => this.hastatusField = value;
    }

    public string hasync
    {
      get => this.hasyncField;
      set => this.hasyncField = value;
    }

    public string haprop
    {
      get => this.hapropField;
      set => this.hapropField = value;
    }

    public uint? hellointerval
    {
      get => this.hellointervalField;
      set => this.hellointervalField = value;
    }

    public long? deadinterval
    {
      get => this.deadintervalField;
      set => this.deadintervalField = value;
    }

    public string failsafe
    {
      get => this.failsafeField;
      set => this.failsafeField = value;
    }

    public uint? maxflips
    {
      get => this.maxflipsField;
      set => this.maxflipsField = value;
    }

    public uint? maxfliptime
    {
      get => this.maxfliptimeField;
      set => this.maxfliptimeField = value;
    }

    public uint? syncvlan
    {
      get => this.syncvlanField;
      set => this.syncvlanField = value;
    }

    public string name
    {
      get => this.nameField;
      private set => this.nameField = value;
    }

    public uint? flags
    {
      get => this.flagsField;
      private set => this.flagsField = value;
    }

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string enaifaces
    {
      get => this.enaifacesField;
      private set => this.enaifacesField = value;
    }

    public string disifaces
    {
      get => this.disifacesField;
      private set => this.disifacesField = value;
    }

    public string hamonifaces
    {
      get => this.hamonifacesField;
      private set => this.hamonifacesField = value;
    }

    public string pfifaces
    {
      get => this.pfifacesField;
      private set => this.pfifacesField = value;
    }

    public string ifaces
    {
      get => this.ifacesField;
      private set => this.ifacesField = value;
    }

    public string network
    {
      get => this.networkField;
      private set => this.networkField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      private set => this.netmaskField = value;
    }

    public string ssl2
    {
      get => this.ssl2Field;
      private set => this.ssl2Field = value;
    }

    public long? masterstatetime
    {
      get => this.masterstatetimeField;
      private set => this.masterstatetimeField = value;
    }

    public string routemonitor
    {
      get => this.routemonitorField;
      private set => this.routemonitorField = value;
    }

    public uint? curflips
    {
      get => this.curflipsField;
      private set => this.curflipsField = value;
    }

    public uint? completedfliptime
    {
      get => this.completedfliptimeField;
      private set => this.completedfliptimeField = value;
    }

    public string routemonitorstate
    {
      get => this.routemonitorstateField;
      private set => this.routemonitorstateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      hanode.hanode_response hanodeResponse = new hanode.hanode_response();
      hanode.hanode_response resource = (hanode.hanode_response) service.get_payload_formatter().string_to_resource(hanodeResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.hanode;
    }

    internal override string get_object_name() => this.id.HasValue ? this.id.ToString() : (string) null;

    public static base_response add(nitro_service client, hanode resource) => new hanode()
    {
      id = resource.id,
      ipaddress = resource.ipaddress,
      inc = resource.inc
    }.add_resource(client);

    public static base_responses add(nitro_service client, hanode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode[] hanodeArray = new hanode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          hanodeArray[index] = new hanode();
          hanodeArray[index].id = resources[index].id;
          hanodeArray[index].ipaddress = resources[index].ipaddress;
          hanodeArray[index].inc = resources[index].inc;
        }
        baseResponses = base_resource.add_bulk_request(client, (base_resource[]) hanodeArray);
      }
      return baseResponses;
    }

    public static base_response delete(nitro_service client, uint? id) => new hanode()
    {
      id = id
    }.delete_resource(client);

    public static base_response delete(nitro_service client, hanode resource) => new hanode()
    {
      id = resource.id
    }.delete_resource(client);

    public static base_responses delete(nitro_service client, uint?[] id)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        hanode[] hanodeArray = new hanode[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          hanodeArray[index] = new hanode();
          hanodeArray[index].id = id[index];
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) hanodeArray);
      }
      return baseResponses;
    }

    public static base_responses delete(nitro_service client, hanode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode[] hanodeArray = new hanode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          hanodeArray[index] = new hanode();
          hanodeArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) hanodeArray);
      }
      return baseResponses;
    }

    public static base_response update(nitro_service client, hanode resource) => new hanode()
    {
      id = resource.id,
      hastatus = resource.hastatus,
      hasync = resource.hasync,
      haprop = resource.haprop,
      hellointerval = resource.hellointerval,
      deadinterval = resource.deadinterval,
      failsafe = resource.failsafe,
      maxflips = resource.maxflips,
      maxfliptime = resource.maxfliptime,
      syncvlan = resource.syncvlan
    }.update_resource(client);

    public static base_responses update(nitro_service client, hanode[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode[] hanodeArray = new hanode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          hanodeArray[index] = new hanode();
          hanodeArray[index].id = resources[index].id;
          hanodeArray[index].hastatus = resources[index].hastatus;
          hanodeArray[index].hasync = resources[index].hasync;
          hanodeArray[index].haprop = resources[index].haprop;
          hanodeArray[index].hellointerval = resources[index].hellointerval;
          hanodeArray[index].deadinterval = resources[index].deadinterval;
          hanodeArray[index].failsafe = resources[index].failsafe;
          hanodeArray[index].maxflips = resources[index].maxflips;
          hanodeArray[index].maxfliptime = resources[index].maxfliptime;
          hanodeArray[index].syncvlan = resources[index].syncvlan;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) hanodeArray);
      }
      return baseResponses;
    }

    public static base_response unset(nitro_service client, uint? id, string[] args) => new hanode()
    {
      id = id
    }.unset_resource(client, args);

    public static base_response unset(
      nitro_service client,
      hanode resource,
      string[] args)
    {
      return new hanode() { id = resource.id }.unset_resource(client, args);
    }

    public static base_responses unset(
      nitro_service client,
      uint?[] id,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (id != null && id.Length > 0)
      {
        hanode[] hanodeArray = new hanode[id.Length];
        for (int index = 0; index < id.Length; ++index)
        {
          hanodeArray[index] = new hanode();
          hanodeArray[index].id = id[index];
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) hanodeArray, args);
      }
      return baseResponses;
    }

    public static base_responses unset(
      nitro_service client,
      hanode[] resources,
      string[] args)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        hanode[] hanodeArray = new hanode[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          hanodeArray[index] = new hanode();
          hanodeArray[index].id = resources[index].id;
        }
        baseResponses = base_resource.unset_bulk_request(client, (base_resource[]) hanodeArray, args);
      }
      return baseResponses;
    }

    public static hanode[] get(nitro_service service) => (hanode[]) new hanode().get_resources(service, (options) null);

    public static hanode[] get(nitro_service service, options option) => (hanode[]) new hanode().get_resources(service, option);

    public static hanode get(nitro_service service, uint? id) => (hanode) new hanode()
    {
      id = id
    }.get_resource(service);

    public static hanode[] get(nitro_service service, uint?[] id)
    {
      if (id == null || id.Length <= 0)
        return (hanode[]) null;
      hanode[] hanodeArray1 = new hanode[id.Length];
      hanode[] hanodeArray2 = new hanode[id.Length];
      for (int index = 0; index < id.Length; ++index)
      {
        hanodeArray2[index] = new hanode();
        hanodeArray2[index].id = id[index];
        hanodeArray1[index] = (hanode) hanodeArray2[index].get_resource(service);
      }
      return hanodeArray1;
    }

    public static hanode[] get_filtered(nitro_service service, string filter)
    {
      hanode hanode = new hanode();
      options option = new options();
      option.set_filter(filter);
      return (hanode[]) hanode.getfiltered(service, option);
    }

    public static hanode[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      hanode hanode = new hanode();
      options option = new options();
      option.set_filter(filter);
      return (hanode[]) hanode.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      hanode hanode = new hanode();
      options option = new options();
      option.set_count(true);
      hanode[] resources = (hanode[]) hanode.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      hanode hanode = new hanode();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode[] hanodeArray = (hanode[]) hanode.getfiltered(service, option);
      return hanodeArray != null && hanodeArray.Length > 0 ? hanodeArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      hanode hanode = new hanode();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      hanode[] hanodeArray = (hanode[]) hanode.getfiltered(service, option);
      return hanodeArray != null && hanodeArray.Length > 0 ? hanodeArray[0].__count.Value : 0U;
    }

    private class hanode_response : base_response
    {
      public hanode[] hanode = (hanode[]) null;
    }

    public static class stateEnum
    {
      public const string Primary = "Primary";
      public const string Secondary = "Secondary";
      public const string UNKNOWN = "UNKNOWN";
    }

    public static class hapropEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class incEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class routemonitorstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
    }

    public static class hasyncEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class failsafeEnum
    {
      public const string ON = "ON";
      public const string OFF = "OFF";
    }

    public static class hastatusEnum
    {
      public const string ENABLED = "ENABLED";
      public const string STAYSECONDARY = "STAYSECONDARY";
      public const string DISABLED = "DISABLED";
      public const string STAYPRIMARY = "STAYPRIMARY";
    }

    public static class ssl2Enum
    {
      public const string DOWN = "DOWN";
      public const string UP = "UP";
      public const string NOT_PRESENT = "NOT PRESENT";
      public const string UNKNOWN = "UNKNOWN";
    }
  }
}
