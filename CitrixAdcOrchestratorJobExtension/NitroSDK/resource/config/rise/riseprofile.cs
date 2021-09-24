// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.rise.riseprofile
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.rise
{
  public class riseprofile : base_resource
  {
    private string profilenameField = (string) null;
    private string servicenameField = (string) null;
    private string deviceidField = (string) null;
    private uint? slotidField = new uint?();
    private uint? slotnoField = new uint?();
    private uint? vdcidField = new uint?();
    private uint? vpcidField = new uint?();
    private string ipaddressField = (string) null;
    private string modeField = (string) null;
    private string statusField = (string) null;
    private uint? vlanField = new uint?();
    private uint? vlangroupidField = new uint?();
    private string vlancfgstatusField = (string) null;
    private string ifnumField = (string) null;
    private string issuField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public string servicename
    {
      get => this.servicenameField;
      private set => this.servicenameField = value;
    }

    public string deviceid
    {
      get => this.deviceidField;
      private set => this.deviceidField = value;
    }

    public uint? slotid
    {
      get => this.slotidField;
      private set => this.slotidField = value;
    }

    public uint? slotno
    {
      get => this.slotnoField;
      private set => this.slotnoField = value;
    }

    public uint? vdcid
    {
      get => this.vdcidField;
      private set => this.vdcidField = value;
    }

    public uint? vpcid
    {
      get => this.vpcidField;
      private set => this.vpcidField = value;
    }

    public string ipaddress
    {
      get => this.ipaddressField;
      private set => this.ipaddressField = value;
    }

    public string mode
    {
      get => this.modeField;
      private set => this.modeField = value;
    }

    public string status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public uint? vlan
    {
      get => this.vlanField;
      private set => this.vlanField = value;
    }

    public uint? vlangroupid
    {
      get => this.vlangroupidField;
      private set => this.vlangroupidField = value;
    }

    public string vlancfgstatus
    {
      get => this.vlancfgstatusField;
      private set => this.vlancfgstatusField = value;
    }

    public string ifnum
    {
      get => this.ifnumField;
      private set => this.ifnumField = value;
    }

    public string issu
    {
      get => this.issuField;
      private set => this.issuField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      riseprofile.riseprofile_response riseprofileResponse = new riseprofile.riseprofile_response();
      riseprofile.riseprofile_response resource = (riseprofile.riseprofile_response) service.get_payload_formatter().string_to_resource(riseprofileResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.riseprofile;
    }

    internal override string get_object_name() => this.profilename;

    public static riseprofile[] get(nitro_service service) => (riseprofile[]) new riseprofile().get_resources(service, (options) null);

    public static riseprofile[] get(nitro_service service, options option) => (riseprofile[]) new riseprofile().get_resources(service, option);

    public static riseprofile get(nitro_service service, string profilename) => (riseprofile) new riseprofile()
    {
      profilename = profilename
    }.get_resource(service);

    public static riseprofile[] get(nitro_service service, string[] profilename)
    {
      if (profilename == null || profilename.Length <= 0)
        return (riseprofile[]) null;
      riseprofile[] riseprofileArray1 = new riseprofile[profilename.Length];
      riseprofile[] riseprofileArray2 = new riseprofile[profilename.Length];
      for (int index = 0; index < profilename.Length; ++index)
      {
        riseprofileArray2[index] = new riseprofile();
        riseprofileArray2[index].profilename = profilename[index];
        riseprofileArray1[index] = (riseprofile) riseprofileArray2[index].get_resource(service);
      }
      return riseprofileArray1;
    }

    public static riseprofile[] get_filtered(nitro_service service, string filter)
    {
      riseprofile riseprofile = new riseprofile();
      options option = new options();
      option.set_filter(filter);
      return (riseprofile[]) riseprofile.getfiltered(service, option);
    }

    public static riseprofile[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      riseprofile riseprofile = new riseprofile();
      options option = new options();
      option.set_filter(filter);
      return (riseprofile[]) riseprofile.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      riseprofile riseprofile = new riseprofile();
      options option = new options();
      option.set_count(true);
      riseprofile[] resources = (riseprofile[]) riseprofile.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      riseprofile riseprofile = new riseprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riseprofile[] riseprofileArray = (riseprofile[]) riseprofile.getfiltered(service, option);
      return riseprofileArray != null && riseprofileArray.Length > 0 ? riseprofileArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      riseprofile riseprofile = new riseprofile();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      riseprofile[] riseprofileArray = (riseprofile[]) riseprofile.getfiltered(service, option);
      return riseprofileArray != null && riseprofileArray.Length > 0 ? riseprofileArray[0].__count.Value : 0U;
    }

    private class riseprofile_response : base_response
    {
      public riseprofile[] riseprofile = (riseprofile[]) null;
    }

    public static class modeEnum
    {
      public const string Direct = "Direct";
      public const string Indirect = "Indirect";
      public const string vPC_Direct = "vPC-Direct";
    }

    public static class issuEnum
    {
      public const string InProgress = "InProgress";
      public const string None = "None";
    }

    public static class statusEnum
    {
      public const string Active = "Active";
      public const string Inactive = "Inactive";
    }

    public static class vlancfgstatusEnum
    {
      public const string Ok = "Ok";
      public const string Invalid = "Invalid";
    }
  }
}
