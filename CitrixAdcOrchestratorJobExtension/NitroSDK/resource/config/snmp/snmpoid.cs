// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpoid
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpoid : base_resource
  {
    private string entitytypeField = (string) null;
    private string nameField = (string) null;
    private string SnmpoidField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string entitytype
    {
      get => this.entitytypeField;
      set => this.entitytypeField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string Snmpoid
    {
      get => this.SnmpoidField;
      private set => this.SnmpoidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpoid.snmpoid_response snmpoidResponse = new snmpoid.snmpoid_response();
      snmpoid.snmpoid_response resource = (snmpoid.snmpoid_response) service.get_payload_formatter().string_to_resource(snmpoidResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmpoid;
    }

    internal override string get_object_name() => this.name;

    public static snmpoid get(nitro_service service, snmpoid obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmpoid) obj.get_resource(service, option);
    }

    public static snmpoid[] get(nitro_service service, snmpoid[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (snmpoid[]) null;
      snmpoid[] snmpoidArray = new snmpoid[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        snmpoidArray[index] = (snmpoid) obj[index].get_resource(service, option);
      }
      return snmpoidArray;
    }

    public static snmpoid[] get(nitro_service service, snmpoid_args args)
    {
      snmpoid snmpoid = new snmpoid();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (snmpoid[]) snmpoid.get_resources(service, option);
    }

    public static snmpoid[] get_filtered(nitro_service service, snmpoid obj, string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmpoid[]) obj.getfiltered(service, option);
    }

    public static snmpoid[] get_filtered(
      nitro_service service,
      snmpoid obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmpoid[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, snmpoid obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      snmpoid[] resources = (snmpoid[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, snmpoid obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      snmpoid[] snmpoidArray = (snmpoid[]) obj.getfiltered(service, option);
      return snmpoidArray != null && snmpoidArray.Length > 0 ? snmpoidArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, snmpoid obj, filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      snmpoid[] snmpoidArray = (snmpoid[]) obj.getfiltered(service, option);
      return snmpoidArray != null && snmpoidArray.Length > 0 ? snmpoidArray[0].__count.Value : 0U;
    }

    private class snmpoid_response : base_response
    {
      public snmpoid[] snmpoid = (snmpoid[]) null;
    }

    public static class entitytypeEnum
    {
      public const string VSERVER = "VSERVER";
      public const string SERVICE = "SERVICE";
      public const string SERVICEGROUP = "SERVICEGROUP";
    }
  }
}
