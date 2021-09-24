// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmptrap_snmpuser_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmptrap_snmpuser_binding : base_resource
  {
    private string usernameField = (string) null;
    private string securitylevelField = (string) null;
    private string trapclassField = (string) null;
    private string trapdestinationField = (string) null;
    private uint? tdField = new uint?();
    private string versionField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string trapclass
    {
      get => this.trapclassField;
      set => this.trapclassField = value;
    }

    public string securitylevel
    {
      get => this.securitylevelField;
      set => this.securitylevelField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string trapdestination
    {
      get => this.trapdestinationField;
      set => this.trapdestinationField = value;
    }

    public string version
    {
      get => this.versionField;
      set => this.versionField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmptrap_snmpuser_binding.snmptrap_snmpuser_binding_response snmpuserBindingResponse = new snmptrap_snmpuser_binding.snmptrap_snmpuser_binding_response();
      snmptrap_snmpuser_binding.snmptrap_snmpuser_binding_response resource = (snmptrap_snmpuser_binding.snmptrap_snmpuser_binding_response) service.get_payload_formatter().string_to_resource(snmpuserBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmptrap_snmpuser_binding;
    }

    internal override string get_object_name() => this.trapclass;

    public static base_response add(
      nitro_service client,
      snmptrap_snmpuser_binding resource)
    {
      return new snmptrap_snmpuser_binding()
      {
        trapclass = resource.trapclass,
        trapdestination = resource.trapdestination,
        td = resource.td,
        version = resource.version,
        username = resource.username,
        securitylevel = resource.securitylevel
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      snmptrap_snmpuser_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmptrap_snmpuser_binding[] snmptrapSnmpuserBindingArray = new snmptrap_snmpuser_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmptrapSnmpuserBindingArray[index] = new snmptrap_snmpuser_binding();
          snmptrapSnmpuserBindingArray[index].trapclass = resources[index].trapclass;
          snmptrapSnmpuserBindingArray[index].trapdestination = resources[index].trapdestination;
          snmptrapSnmpuserBindingArray[index].td = resources[index].td;
          snmptrapSnmpuserBindingArray[index].version = resources[index].version;
          snmptrapSnmpuserBindingArray[index].username = resources[index].username;
          snmptrapSnmpuserBindingArray[index].securitylevel = resources[index].securitylevel;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) snmptrapSnmpuserBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      snmptrap_snmpuser_binding resource)
    {
      return new snmptrap_snmpuser_binding()
      {
        trapclass = resource.trapclass,
        trapdestination = resource.trapdestination,
        td = resource.td,
        version = resource.version,
        username = resource.username
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      snmptrap_snmpuser_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        snmptrap_snmpuser_binding[] snmptrapSnmpuserBindingArray = new snmptrap_snmpuser_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          snmptrapSnmpuserBindingArray[index] = new snmptrap_snmpuser_binding();
          snmptrapSnmpuserBindingArray[index].trapclass = resources[index].trapclass;
          snmptrapSnmpuserBindingArray[index].trapdestination = resources[index].trapdestination;
          snmptrapSnmpuserBindingArray[index].td = resources[index].td;
          snmptrapSnmpuserBindingArray[index].version = resources[index].version;
          snmptrapSnmpuserBindingArray[index].username = resources[index].username;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) snmptrapSnmpuserBindingArray);
      }
      return baseResponses;
    }

    public static snmptrap_snmpuser_binding[] get(
      nitro_service service,
      snmptrap_snmpuser_binding obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmptrap_snmpuser_binding[]) obj.get_resources(service, option);
    }

    public static snmptrap_snmpuser_binding[] get_filtered(
      nitro_service service,
      snmptrap_snmpuser_binding obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmptrap_snmpuser_binding[]) obj.getfiltered(service, option);
    }

    public static snmptrap_snmpuser_binding[] get_filtered(
      nitro_service service,
      snmptrap_snmpuser_binding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmptrap_snmpuser_binding[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, snmptrap_snmpuser_binding obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      snmptrap_snmpuser_binding[] resources = (snmptrap_snmpuser_binding[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      snmptrap_snmpuser_binding obj,
      string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      snmptrap_snmpuser_binding[] snmptrapSnmpuserBindingArray = (snmptrap_snmpuser_binding[]) obj.getfiltered(service, option);
      return snmptrapSnmpuserBindingArray != null && snmptrapSnmpuserBindingArray.Length > 0 ? snmptrapSnmpuserBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      snmptrap_snmpuser_binding obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      snmptrap_snmpuser_binding[] snmptrapSnmpuserBindingArray = (snmptrap_snmpuser_binding[]) obj.getfiltered(service, option);
      return snmptrapSnmpuserBindingArray != null && snmptrapSnmpuserBindingArray.Length > 0 ? snmptrapSnmpuserBindingArray[0].__count.Value : 0U;
    }

    private class snmptrap_snmpuser_binding_response : base_response
    {
      public snmptrap_snmpuser_binding[] snmptrap_snmpuser_binding = (snmptrap_snmpuser_binding[]) null;
    }

    public static class trapclassEnum
    {
      public const string generic = "generic";
      public const string specific = "specific";
    }

    public static class securitylevelEnum
    {
      public const string noAuthNoPriv = "noAuthNoPriv";
      public const string authNoPriv = "authNoPriv";
      public const string authPriv = "authPriv";
    }

    public static class versionEnum
    {
      public const string V1 = "V1";
      public const string V2 = "V2";
      public const string V3 = "V3";
    }
  }
}
