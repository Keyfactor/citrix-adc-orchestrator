// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaasession
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaasession : base_resource
  {
    private string usernameField = (string) null;
    private string groupnameField = (string) null;
    private string iipField = (string) null;
    private string netmaskField = (string) null;
    private bool? allField = new bool?();
    private string publicipField = (string) null;
    private ushort? publicportField = new ushort?();
    private string ipaddressField = (string) null;
    private ushort? portField = new ushort?();
    private string privateipField = (string) null;
    private ushort? privateportField = new ushort?();
    private string destipField = (string) null;
    private ushort? destportField = new ushort?();
    private string intranetipField = (string) null;
    private string intranetip6Field = (string) null;
    private uint? peidField = new uint?();
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string iip
    {
      get => this.iipField;
      set => this.iipField = value;
    }

    public string netmask
    {
      get => this.netmaskField;
      set => this.netmaskField = value;
    }

    public bool? all
    {
      get => this.allField;
      set => this.allField = value;
    }

    public string publicip
    {
      get => this.publicipField;
      private set => this.publicipField = value;
    }

    public ushort? publicport
    {
      get => this.publicportField;
      private set => this.publicportField = value;
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

    public string privateip
    {
      get => this.privateipField;
      private set => this.privateipField = value;
    }

    public ushort? privateport
    {
      get => this.privateportField;
      private set => this.privateportField = value;
    }

    public string destip
    {
      get => this.destipField;
      private set => this.destipField = value;
    }

    public ushort? destport
    {
      get => this.destportField;
      private set => this.destportField = value;
    }

    public string intranetip
    {
      get => this.intranetipField;
      private set => this.intranetipField = value;
    }

    public string intranetip6
    {
      get => this.intranetip6Field;
      private set => this.intranetip6Field = value;
    }

    public uint? peid
    {
      get => this.peidField;
      private set => this.peidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaasession.aaasession_response aaasessionResponse = new aaasession.aaasession_response();
      aaasession.aaasession_response resource = (aaasession.aaasession_response) service.get_payload_formatter().string_to_resource(aaasessionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.aaasession;
    }

    internal override string get_object_name() => (string) null;

    public static base_response kill(nitro_service client, aaasession resource) => new aaasession()
    {
      username = resource.username,
      groupname = resource.groupname,
      iip = resource.iip,
      netmask = resource.netmask,
      all = resource.all
    }.perform_operation_byaction(client, nameof (kill));

    public static base_responses kill(nitro_service client, aaasession[] resources)
    {
      base_responses baseResponses = (base_responses) null;
      if (resources != null && resources.Length > 0)
      {
        aaasession[] aaasessionArray = new aaasession[resources.Length];
        for (int index = 0; index < resources.Length; ++index)
        {
          aaasessionArray[index] = new aaasession();
          aaasessionArray[index].username = resources[index].username;
          aaasessionArray[index].groupname = resources[index].groupname;
          aaasessionArray[index].iip = resources[index].iip;
          aaasessionArray[index].netmask = resources[index].netmask;
          aaasessionArray[index].all = resources[index].all;
        }
        baseResponses = base_resource.perform_operation_bulk_request(client, (base_resource[]) aaasessionArray, nameof (kill));
      }
      return baseResponses;
    }

    public static aaasession[] get(nitro_service service) => (aaasession[]) new aaasession().get_resources(service, (options) null);

    public static aaasession[] get(nitro_service service, options option) => (aaasession[]) new aaasession().get_resources(service, option);

    public static aaasession[] get(nitro_service service, aaasession_args args)
    {
      aaasession aaasession = new aaasession();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (aaasession[]) aaasession.get_resources(service, option);
    }

    public static aaasession[] get_filtered(nitro_service service, string filter)
    {
      aaasession aaasession = new aaasession();
      options option = new options();
      option.set_filter(filter);
      return (aaasession[]) aaasession.getfiltered(service, option);
    }

    public static aaasession[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      aaasession aaasession = new aaasession();
      options option = new options();
      option.set_filter(filter);
      return (aaasession[]) aaasession.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      aaasession aaasession = new aaasession();
      options option = new options();
      option.set_count(true);
      aaasession[] resources = (aaasession[]) aaasession.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      aaasession aaasession = new aaasession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaasession[] aaasessionArray = (aaasession[]) aaasession.getfiltered(service, option);
      return aaasessionArray != null && aaasessionArray.Length > 0 ? aaasessionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      aaasession aaasession = new aaasession();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      aaasession[] aaasessionArray = (aaasession[]) aaasession.getfiltered(service, option);
      return aaasessionArray != null && aaasessionArray.Length > 0 ? aaasessionArray[0].__count.Value : 0U;
    }

    private class aaasession_response : base_response
    {
      public aaasession[] aaasession = (aaasession[]) null;
    }
  }
}
