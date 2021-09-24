// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmptrap_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmptrap_binding : base_resource
  {
    private string trapclassField = (string) null;
    private string trapdestinationField = (string) null;
    private string versionField = (string) null;
    private uint? tdField = new uint?();
    private com.citrix.netscaler.nitro.resource.config.snmp.snmptrap_snmpuser_binding[] snmptrap_snmpuser_bindingField = (com.citrix.netscaler.nitro.resource.config.snmp.snmptrap_snmpuser_binding[]) null;

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

    public uint? td
    {
      get => this.tdField;
      set => this.tdField = value;
    }

    public string trapclass
    {
      get => this.trapclassField;
      set => this.trapclassField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.snmp.snmptrap_snmpuser_binding[] snmptrap_snmpuser_binding
    {
      get => this.snmptrap_snmpuser_bindingField;
      private set => this.snmptrap_snmpuser_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmptrap_binding.snmptrap_binding_response snmptrapBindingResponse = new snmptrap_binding.snmptrap_binding_response();
      snmptrap_binding.snmptrap_binding_response resource = (snmptrap_binding.snmptrap_binding_response) service.get_payload_formatter().string_to_resource(snmptrapBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.snmptrap_binding;
    }

    internal override string get_object_name() => this.trapclass;

    public static snmptrap_binding get(nitro_service service, snmptrap_binding obj)
    {
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (snmptrap_binding) obj.get_resource(service, option);
    }

    public static snmptrap_binding[] get(
      nitro_service service,
      snmptrap_binding[] obj)
    {
      if (obj == null || obj.Length <= 0)
        return (snmptrap_binding[]) null;
      snmptrap_binding[] snmptrapBindingArray = new snmptrap_binding[obj.Length];
      for (int index = 0; index < obj.Length; ++index)
      {
        options option = new options();
        option.set_args(nitro_util.object_to_string_withoutquotes((object) obj[index]));
        snmptrapBindingArray[index] = (snmptrap_binding) obj[index].get_resource(service, option);
      }
      return snmptrapBindingArray;
    }

    private class snmptrap_binding_response : base_response
    {
      public snmptrap_binding[] snmptrap_binding = (snmptrap_binding[]) null;
    }

    public static class versionEnum
    {
      public const string V1 = "V1";
      public const string V2 = "V2";
      public const string V3 = "V3";
    }

    public static class trapclassEnum
    {
      public const string generic = "generic";
      public const string specific = "specific";
    }
  }
}
