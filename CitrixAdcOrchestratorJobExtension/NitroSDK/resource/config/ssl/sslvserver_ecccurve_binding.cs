// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslvserver_ecccurve_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslvserver_ecccurve_binding : base_resource
  {
    private string ecccurvenameField = (string) null;
    private string vservernameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      set => this.__countField = value;
    }

    public string ecccurvename
    {
      get => this.ecccurvenameField;
      set => this.ecccurvenameField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      set => this.vservernameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslvserver_ecccurve_binding.sslvserver_ecccurve_binding_response ecccurveBindingResponse = new sslvserver_ecccurve_binding.sslvserver_ecccurve_binding_response();
      sslvserver_ecccurve_binding.sslvserver_ecccurve_binding_response resource = (sslvserver_ecccurve_binding.sslvserver_ecccurve_binding_response) service.get_payload_formatter().string_to_resource(ecccurveBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslvserver_ecccurve_binding;
    }

    internal override string get_object_name() => this.vservername;

    public static base_response add(
      nitro_service client,
      sslvserver_ecccurve_binding resource)
    {
      return new sslvserver_ecccurve_binding()
      {
        vservername = resource.vservername,
        ecccurvename = resource.ecccurvename
      }.update_resource(client);
    }

    public static base_responses add(
      nitro_service client,
      sslvserver_ecccurve_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslvserver_ecccurve_binding[] sslvserverEcccurveBindingArray = new sslvserver_ecccurve_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslvserverEcccurveBindingArray[index] = new sslvserver_ecccurve_binding();
          sslvserverEcccurveBindingArray[index].vservername = resources[index].vservername;
          sslvserverEcccurveBindingArray[index].ecccurvename = resources[index].ecccurvename;
        }
        baseResponses = base_resource.update_bulk_request(client, (base_resource[]) sslvserverEcccurveBindingArray);
      }
      return baseResponses;
    }

    public static base_response delete(
      nitro_service client,
      sslvserver_ecccurve_binding resource)
    {
      return new sslvserver_ecccurve_binding()
      {
        vservername = resource.vservername,
        ecccurvename = resource.ecccurvename
      }.delete_resource(client);
    }

    public static base_responses delete(
      nitro_service client,
      sslvserver_ecccurve_binding[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        sslvserver_ecccurve_binding[] sslvserverEcccurveBindingArray = new sslvserver_ecccurve_binding[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          sslvserverEcccurveBindingArray[index] = new sslvserver_ecccurve_binding();
          sslvserverEcccurveBindingArray[index].vservername = resources[index].vservername;
          sslvserverEcccurveBindingArray[index].ecccurvename = resources[index].ecccurvename;
        }
        baseResponses = base_resource.delete_bulk_request(client, (base_resource[]) sslvserverEcccurveBindingArray);
      }
      return baseResponses;
    }

    public static sslvserver_ecccurve_binding[] get(
      nitro_service service,
      string vservername)
    {
      return (sslvserver_ecccurve_binding[]) new sslvserver_ecccurve_binding()
      {
        vservername = vservername
      }.get_resources(service, (options) null);
    }

    public static sslvserver_ecccurve_binding[] get_filtered(
      nitro_service service,
      string vservername,
      string filter)
    {
      sslvserver_ecccurve_binding sslvserverEcccurveBinding = new sslvserver_ecccurve_binding();
      sslvserverEcccurveBinding.vservername = vservername;
      options option = new options();
      option.set_filter(filter);
      return (sslvserver_ecccurve_binding[]) sslvserverEcccurveBinding.getfiltered(service, option);
    }

    public static sslvserver_ecccurve_binding[] get_filtered(
      nitro_service service,
      string vservername,
      filtervalue[] filter)
    {
      sslvserver_ecccurve_binding sslvserverEcccurveBinding = new sslvserver_ecccurve_binding();
      sslvserverEcccurveBinding.vservername = vservername;
      options option = new options();
      option.set_filter(filter);
      return (sslvserver_ecccurve_binding[]) sslvserverEcccurveBinding.getfiltered(service, option);
    }

    public static uint count(nitro_service service, string vservername)
    {
      sslvserver_ecccurve_binding sslvserverEcccurveBinding = new sslvserver_ecccurve_binding();
      sslvserverEcccurveBinding.vservername = vservername;
      options option = new options();
      option.set_count(true);
      sslvserver_ecccurve_binding[] resources = (sslvserver_ecccurve_binding[]) sslvserverEcccurveBinding.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string vservername, string filter)
    {
      sslvserver_ecccurve_binding sslvserverEcccurveBinding = new sslvserver_ecccurve_binding();
      sslvserverEcccurveBinding.vservername = vservername;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslvserver_ecccurve_binding[] sslvserverEcccurveBindingArray = (sslvserver_ecccurve_binding[]) sslvserverEcccurveBinding.getfiltered(service, option);
      return sslvserverEcccurveBindingArray != null && sslvserverEcccurveBindingArray.Length > 0 ? sslvserverEcccurveBindingArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      string vservername,
      filtervalue[] filter)
    {
      sslvserver_ecccurve_binding sslvserverEcccurveBinding = new sslvserver_ecccurve_binding();
      sslvserverEcccurveBinding.vservername = vservername;
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      sslvserver_ecccurve_binding[] sslvserverEcccurveBindingArray = (sslvserver_ecccurve_binding[]) sslvserverEcccurveBinding.getfiltered(service, option);
      return sslvserverEcccurveBindingArray != null && sslvserverEcccurveBindingArray.Length > 0 ? sslvserverEcccurveBindingArray[0].__count.Value : 0U;
    }

    private class sslvserver_ecccurve_binding_response : base_response
    {
      public sslvserver_ecccurve_binding[] sslvserver_ecccurve_binding = (sslvserver_ecccurve_binding[]) null;
    }

    public static class ocspcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class ecccurvenameEnum
    {
      public const string ALL = "ALL";
      public const string P_224 = "P_224";
      public const string P_256 = "P_256";
      public const string P_384 = "P_384";
      public const string P_521 = "P_521";
    }

    public static class crlcheckEnum
    {
      public const string Mandatory = "Mandatory";
      public const string Optional = "Optional";
    }

    public static class labeltypeEnum
    {
      public const string vserver = "vserver";
      public const string service = "service";
      public const string policylabel = "policylabel";
    }
  }
}
