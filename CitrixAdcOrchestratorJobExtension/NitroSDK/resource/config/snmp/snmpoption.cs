// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpoption
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpoption : base_resource
  {
    private string snmpsetField = (string) null;
    private string snmptraploggingField = (string) null;
    private string partitionnameintrapField = (string) null;

    public string snmpset
    {
      get => this.snmpsetField;
      set => this.snmpsetField = value;
    }

    public string snmptraplogging
    {
      get => this.snmptraploggingField;
      set => this.snmptraploggingField = value;
    }

    public string partitionnameintrap
    {
      get => this.partitionnameintrapField;
      set => this.partitionnameintrapField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpoption[] snmpoptionArray = new snmpoption[1];
      snmpoption.snmpoption_response snmpoptionResponse = new snmpoption.snmpoption_response();
      snmpoption.snmpoption_response resource = (snmpoption.snmpoption_response) service.get_payload_formatter().string_to_resource(snmpoptionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      snmpoptionArray[0] = resource.snmpoption;
      return (base_resource[]) snmpoptionArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, snmpoption resource) => new snmpoption()
    {
      snmpset = resource.snmpset,
      snmptraplogging = resource.snmptraplogging,
      partitionnameintrap = resource.partitionnameintrap
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      snmpoption resource,
      string[] args)
    {
      return new snmpoption().unset_resource(client, args);
    }

    public static snmpoption get(nitro_service service) => ((snmpoption[]) new snmpoption().get_resources(service, (options) null))[0];

    public static snmpoption get(nitro_service service, options option) => ((snmpoption[]) new snmpoption().get_resources(service, option))[0];

    private class snmpoption_response : base_response
    {
      public snmpoption snmpoption = (snmpoption) null;
    }

    public static class snmptraploggingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class snmpsetEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class partitionnameintrapEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
