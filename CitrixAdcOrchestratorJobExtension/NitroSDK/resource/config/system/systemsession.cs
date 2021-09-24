// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemsession
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemsession : base_resource
  {
    private uint? sidField = new uint?();
    private bool? allField = new bool?();
    private string usernameField = (string) null;
    private string logintimeField = (string) null;
    private string lastactivitytimeField = (string) null;
    private int? expirytimeField = new int?();
    private uint? numofconnectionsField = new uint?();
    private bool? currentconnField = new bool?();
    private string clienttypeField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public uint? sid
    {
      get => this.sidField;
      set => this.sidField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public string username
    {
      get => this.usernameField;
      private set => this.usernameField = value;
    }

    public string logintime
    {
      get => this.logintimeField;
      private set => this.logintimeField = value;
    }

    public string lastactivitytime
    {
      get => this.lastactivitytimeField;
      private set => this.lastactivitytimeField = value;
    }

    public int? expirytime
    {
      get => this.expirytimeField;
      private set => this.expirytimeField = value;
    }

    public uint? numofconnections
    {
      get => this.numofconnectionsField;
      private set => this.numofconnectionsField = value;
    }

    public bool? currentconn
    {
      get => this.currentconnField;
      private set => this.currentconnField = value;
    }

    public string clienttype
    {
      get => this.clienttypeField;
      private set => this.clienttypeField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemsession.systemsession_response systemsessionResponse = new systemsession.systemsession_response();
      systemsession.systemsession_response resource = (systemsession.systemsession_response) service.get_payload_formatter().string_to_resource(systemsessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.systemsession;
    }

    internal override string get_object_name() => this.sid.HasValue ? this.sid.ToString() : (string) null;

    public static base_response kill(nitro_service client, systemsession resource) => new systemsession()
    {
      sid = resource.sid,
      all = resource.all
    }.perform_operation_byaction(client, nameof (kill));

    public static base_responses kill(nitro_service client, systemsession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        systemsession[] systemsessionArray = new systemsession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          systemsessionArray[index] = new systemsession();
          systemsessionArray[index].sid = resources[index].sid;
          systemsessionArray[index].all = resources[index].all;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) systemsessionArray, nameof (kill));
      }
      return baseResponses;
    }

    public static systemsession[] get(nitro_service service) => (systemsession[]) new systemsession().get_resources(service, (options) null);

    public static systemsession[] get(nitro_service service, options option) => (systemsession[]) new systemsession().get_resources(service, option);

    public static systemsession get(nitro_service service, uint? sid) => (systemsession) new systemsession()
    {
      sid = sid
    }.get_resource(service);

    public static systemsession[] get(nitro_service service, uint?[] sid)
    {
      if (sid == null || sid.Length <= 0)
        return (systemsession[]) null;
      systemsession[] systemsessionArray1 = new systemsession[sid.Length];
      systemsession[] systemsessionArray2 = new systemsession[sid.Length];
      for (int index = 0; index < sid.Length; ++index)
      {
        systemsessionArray2[index] = new systemsession();
        systemsessionArray2[index].sid = sid[index];
        systemsessionArray1[index] = (systemsession) systemsessionArray2[index].get_resource(service);
      }
      return systemsessionArray1;
    }

    public static systemsession[] get_filtered(nitro_service service, string filter)
    {
      systemsession systemsession = new systemsession();
      options option = new options();
      option.set_filter(filter);
      return (systemsession[]) systemsession.getfiltered(service, option);
    }

    public static systemsession[] get_filtered(
      nitro_service service,
      filtervalue[] filter)
    {
      systemsession systemsession = new systemsession();
      options option = new options();
      option.set_filter(filter);
      return (systemsession[]) systemsession.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      systemsession systemsession = new systemsession();
      options option = new options();
      option.set_count(true);
      systemsession[] resources = (systemsession[]) systemsession.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      systemsession systemsession = new systemsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemsession[] systemsessionArray = (systemsession[]) systemsession.getfiltered(service, option);
      return systemsessionArray != null && systemsessionArray.Length > 0 ? systemsessionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      systemsession systemsession = new systemsession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      systemsession[] systemsessionArray = (systemsession[]) systemsession.getfiltered(service, option);
      return systemsessionArray != null && systemsessionArray.Length > 0 ? systemsessionArray[0].__count.Value : 0U;
    }

    private class systemsession_response : base_response
    {
      public systemsession[] systemsession = (systemsession[]) null;
    }

    public static class clienttypeEnum
    {
      public const string CLI = "CLI";
      public const string API = "API";
      public const string GUI = "GUI";
    }
  }
}
