// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.basic.servicegroupbindings
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.basic
{
  public class servicegroupbindings : base_resource
  {
    private string servicegroupnameField = (string) null;
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string stateField = (string) null;
    private string svrstateField = (string) null;
    private string vservernameField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string servicegroupname
    {
      get => this.servicegroupnameField;
      set => this.servicegroupnameField = value;
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

    public string state
    {
      get => this.stateField;
      private set => this.stateField = value;
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
      servicegroupbindings.servicegroupbindings_response servicegroupbindingsResponse = new servicegroupbindings.servicegroupbindings_response();
      servicegroupbindings.servicegroupbindings_response resource = (servicegroupbindings.servicegroupbindings_response) service.get_payload_formatter().string_to_resource(servicegroupbindingsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.servicegroupbindings;
    }

    internal override string get_object_name() => this.servicegroupname;

    public static servicegroupbindings get(
      nitro_service service,
      string servicegroupname)
    {
      return (servicegroupbindings) new servicegroupbindings()
      {
        servicegroupname = servicegroupname
      }.get_resource(service);
    }

    public static servicegroupbindings[] get(
      nitro_service service,
      string[] servicegroupname)
    {
      if (servicegroupname == null || servicegroupname.Length <= 0)
        return (servicegroupbindings[]) null;
      servicegroupbindings[] servicegroupbindingsArray1 = new servicegroupbindings[servicegroupname.Length];
      servicegroupbindings[] servicegroupbindingsArray2 = new servicegroupbindings[servicegroupname.Length];
      for (int index = 0; index < servicegroupname.Length; ++index)
      {
        servicegroupbindingsArray2[index] = new servicegroupbindings();
        servicegroupbindingsArray2[index].servicegroupname = servicegroupname[index];
        servicegroupbindingsArray1[index] = (servicegroupbindings) servicegroupbindingsArray2[index].get_resource(service);
      }
      return servicegroupbindingsArray1;
    }

    public static servicegroupbindings[] get_filtered(
      nitro_service service,
      servicegroupbindings obj,
      string filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (servicegroupbindings[]) obj.getfiltered(service, option);
    }

    public static servicegroupbindings[] get_filtered(
      nitro_service service,
      servicegroupbindings obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      return (servicegroupbindings[]) obj.getfiltered(service, option);
    }

    public static uint count(nitro_service service, servicegroupbindings obj)
    {
      options option = new options();
      option.set_count(true);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      servicegroupbindings[] resources = (servicegroupbindings[]) obj.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      servicegroupbindings obj,
      string filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      servicegroupbindings[] servicegroupbindingsArray = (servicegroupbindings[]) obj.getfiltered(service, option);
      return servicegroupbindingsArray != null && servicegroupbindingsArray.Length > 0 ? servicegroupbindingsArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(
      nitro_service service,
      servicegroupbindings obj,
      filtervalue[] filter)
    {
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      option.set_args(nitro_util.object_to_string_withoutquotes((object) obj));
      servicegroupbindings[] servicegroupbindingsArray = (servicegroupbindings[]) obj.getfiltered(service, option);
      return servicegroupbindingsArray != null && servicegroupbindingsArray.Length > 0 ? servicegroupbindingsArray[0].__count.Value : 0U;
    }

    private class servicegroupbindings_response : base_response
    {
      public servicegroupbindings[] servicegroupbindings = (servicegroupbindings[]) null;
    }

    public static class stateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
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
