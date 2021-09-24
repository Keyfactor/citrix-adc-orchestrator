// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.svcbindings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class svcbindings : base_resource
  {
    private string servicenameField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string svrstateField = (string) null;
    private string vservernameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      set => this.servicenameField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public ushort? port
    {
      get => this.portField;
      private set => this.portField = value;
    }

    public string svrstate
    {
      get => this.svrstateField;
      private set => this.svrstateField = value;
    }

    public string vservername
    {
      get => this.vservernameField;
      private set => this.vservernameField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      svcbindings.svcbindings_response svcbindingsResponse = new svcbindings.svcbindings_response();
      svcbindings.svcbindings_response resource = (svcbindings.svcbindings_response) service.get_payload_formatter().string_to_resource(svcbindingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.svcbindings;
    }

    internal override string get_object_name() => this.servicename;

    public static svcbindings get(nitro_service service, string servicename) => (svcbindings) new svcbindings()
    {
      servicename = servicename
    }.get_resource(service);

    public static svcbindings[] get(nitro_service service, string[] servicename)
    {
      if (servicename == null || servicename.Length <= 0)
        return (svcbindings[]) null;
      svcbindings[] svcbindingsArray1 = new svcbindings[servicename.Length];
      svcbindings[] svcbindingsArray2 = new svcbindings[servicename.Length];
      for (int index = 0; index < servicename.Length; ++index)
      {
        svcbindingsArray2[index] = new svcbindings();
        svcbindingsArray2[index].servicename = servicename[index];
        svcbindingsArray1[index] = (svcbindings) svcbindingsArray2[index].get_resource(service);
      }
      return svcbindingsArray1;
    }

    public static svcbindings[] get_filtered(
      nitro_service service,
      svcbindings obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (svcbindings[]) obj.getfiltered(service, option);
    }

    public static svcbindings[] get_filtered(
      nitro_service service,
      svcbindings obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (svcbindings[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, svcbindings obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      svcbindings[] resources = (svcbindings[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, svcbindings obj, string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      svcbindings[] svcbindingsArray = (svcbindings[]) obj.getfiltered(service, option);
      return svcbindingsArray != null && svcbindingsArray.Length > 0 ? svcbindingsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, svcbindings obj, filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      svcbindings[] svcbindingsArray = (svcbindings[]) obj.getfiltered(service, option);
      return svcbindingsArray != null && svcbindingsArray.Length > 0 ? svcbindingsArray[0].__count.Value : 0U;
    }

    private class svcbindings_response : base_response
    {
      public svcbindings[] svcbindings = (svcbindings[]) null;
    }

    public static class svrstateEnum
    {
      public const string UP = "UP";
      public const string DOWN = "DOWN";
      public const string UNKNOWN = "UNKNOWN";
      public const string BUSY = "BUSY";
      public const string OUT_OF_SERVICE = "OUT OF SERVICE";
      public const string GOING_OUT_OF_SERVICE = "GOING OUT OF SERVICE";
      public const string DOWN_WHEN_GOING_OUT_OF_SERVICE = "DOWN WHEN GOING OUT OF SERVICE";
      public const string NS_EMPTY_STR = "NS_EMPTY_STR";
      public const string Unknown = "Unknown";
      public const string DISABLED = "DISABLED";
    }
  }
}
