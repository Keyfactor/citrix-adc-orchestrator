// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.stat.lsn.lsngroup_stats
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.stat.lsn
{
  public class lsngroup_stats : base_resource
  {
    private string groupnameField = (string) null;
    private string clearstatsField = (string) null;
    private long lsngrpcursessionsField = 0;
    private long lsngrpcursessionsrateField = 0;
    private long lsngrptottranslbytesField = 0;
    private long lsngrptranslbytesrateField = 0;
    private long lsngrptottranslpktsField = 0;
    private long lsngrptranslpktsrateField = 0;
    private long lsngrptottcptranslpktsField = 0;
    private long lsngrptcptranslpktsrateField = 0;
    private long lsngrptottcptranslbytesField = 0;
    private long lsngrptcptranslbytesrateField = 0;
    private long lsngrptottcpdrppktsField = 0;
    private long lsngrptcpdrppktsrateField = 0;
    private long lsngrpcurtcpsessionsField = 0;
    private long lsngrpcurtcpsessionsrateField = 0;
    private long lsngrptotudptranslpktsField = 0;
    private long lsngrpudptranslpktsrateField = 0;
    private long lsngrptotudptranslbytesField = 0;
    private long lsngrpudptranslbytesrateField = 0;
    private long lsngrptotudpdrppktsField = 0;
    private long lsngrpudpdrppktsrateField = 0;
    private long lsngrpcurudpsessionsField = 0;
    private long lsngrpcurudpsessionsrateField = 0;
    private long lsngrptoticmptranslpktsField = 0;
    private long lsngrpicmptranslpktsrateField = 0;
    private long lsngrptoticmptranslbytesField = 0;
    private long lsngrpicmptranslbytesrateField = 0;
    private long lsngrptoticmpdrppktsField = 0;
    private long lsngrpicmpdrppktsrateField = 0;
    private long lsngrpcuricmpsessionsField = 0;
    private long lsngrpcuricmpsessionsrateField = 0;
    private long lsngrpcursubscribersField = 0;
    private long lsngrpcursubscribersrateField = 0;

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public string clearstats
    {
      get => this.clearstatsField;
      set => this.clearstatsField = value;
    }

    public long lsngrptcptranslbytesrate
    {
      get => this.lsngrptcptranslbytesrateField;
      private set => this.lsngrptcptranslbytesrateField = value;
    }

    public long lsngrptottranslpkts
    {
      get => this.lsngrptottranslpktsField;
      private set => this.lsngrptottranslpktsField = value;
    }

    public long lsngrptoticmptranslpkts
    {
      get => this.lsngrptoticmptranslpktsField;
      private set => this.lsngrptoticmptranslpktsField = value;
    }

    public long lsngrpcurtcpsessions
    {
      get => this.lsngrpcurtcpsessionsField;
      private set => this.lsngrpcurtcpsessionsField = value;
    }

    public long lsngrpicmptranslbytesrate
    {
      get => this.lsngrpicmptranslbytesrateField;
      private set => this.lsngrpicmptranslbytesrateField = value;
    }

    public long lsngrptotudptranslpkts
    {
      get => this.lsngrptotudptranslpktsField;
      private set => this.lsngrptotudptranslpktsField = value;
    }

    public long lsngrptottcpdrppkts
    {
      get => this.lsngrptottcpdrppktsField;
      private set => this.lsngrptottcpdrppktsField = value;
    }

    public long lsngrptranslbytesrate
    {
      get => this.lsngrptranslbytesrateField;
      private set => this.lsngrptranslbytesrateField = value;
    }

    public long lsngrptotudptranslbytes
    {
      get => this.lsngrptotudptranslbytesField;
      private set => this.lsngrptotudptranslbytesField = value;
    }

    public long lsngrptoticmptranslbytes
    {
      get => this.lsngrptoticmptranslbytesField;
      private set => this.lsngrptoticmptranslbytesField = value;
    }

    public long lsngrpcursubscribersrate
    {
      get => this.lsngrpcursubscribersrateField;
      private set => this.lsngrpcursubscribersrateField = value;
    }

    public long lsngrptottranslbytes
    {
      get => this.lsngrptottranslbytesField;
      private set => this.lsngrptottranslbytesField = value;
    }

    public long lsngrptoticmpdrppkts
    {
      get => this.lsngrptoticmpdrppktsField;
      private set => this.lsngrptoticmpdrppktsField = value;
    }

    public long lsngrptcptranslpktsrate
    {
      get => this.lsngrptcptranslpktsrateField;
      private set => this.lsngrptcptranslpktsrateField = value;
    }

    public long lsngrpudptranslpktsrate
    {
      get => this.lsngrpudptranslpktsrateField;
      private set => this.lsngrpudptranslpktsrateField = value;
    }

    public long lsngrpcursubscribers
    {
      get => this.lsngrpcursubscribersField;
      private set => this.lsngrpcursubscribersField = value;
    }

    public long lsngrpudptranslbytesrate
    {
      get => this.lsngrpudptranslbytesrateField;
      private set => this.lsngrpudptranslbytesrateField = value;
    }

    public long lsngrpcuricmpsessionsrate
    {
      get => this.lsngrpcuricmpsessionsrateField;
      private set => this.lsngrpcuricmpsessionsrateField = value;
    }

    public long lsngrpcurudpsessions
    {
      get => this.lsngrpcurudpsessionsField;
      private set => this.lsngrpcurudpsessionsField = value;
    }

    public long lsngrptottcptranslpkts
    {
      get => this.lsngrptottcptranslpktsField;
      private set => this.lsngrptottcptranslpktsField = value;
    }

    public long lsngrptotudpdrppkts
    {
      get => this.lsngrptotudpdrppktsField;
      private set => this.lsngrptotudpdrppktsField = value;
    }

    public long lsngrpicmptranslpktsrate
    {
      get => this.lsngrpicmptranslpktsrateField;
      private set => this.lsngrpicmptranslpktsrateField = value;
    }

    public long lsngrpcuricmpsessions
    {
      get => this.lsngrpcuricmpsessionsField;
      private set => this.lsngrpcuricmpsessionsField = value;
    }

    public long lsngrpcurtcpsessionsrate
    {
      get => this.lsngrpcurtcpsessionsrateField;
      private set => this.lsngrpcurtcpsessionsrateField = value;
    }

    public long lsngrpcurudpsessionsrate
    {
      get => this.lsngrpcurudpsessionsrateField;
      private set => this.lsngrpcurudpsessionsrateField = value;
    }

    public long lsngrptranslpktsrate
    {
      get => this.lsngrptranslpktsrateField;
      private set => this.lsngrptranslpktsrateField = value;
    }

    public long lsngrptottcptranslbytes
    {
      get => this.lsngrptottcptranslbytesField;
      private set => this.lsngrptottcptranslbytesField = value;
    }

    public long lsngrpicmpdrppktsrate
    {
      get => this.lsngrpicmpdrppktsrateField;
      private set => this.lsngrpicmpdrppktsrateField = value;
    }

    public long lsngrpcursessionsrate
    {
      get => this.lsngrpcursessionsrateField;
      private set => this.lsngrpcursessionsrateField = value;
    }

    public long lsngrpudpdrppktsrate
    {
      get => this.lsngrpudpdrppktsrateField;
      private set => this.lsngrpudpdrppktsrateField = value;
    }

    public long lsngrptcpdrppktsrate
    {
      get => this.lsngrptcpdrppktsrateField;
      private set => this.lsngrptcpdrppktsrateField = value;
    }

    public long lsngrpcursessions
    {
      get => this.lsngrpcursessionsField;
      private set => this.lsngrpcursessionsField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsngroup_stats.lsngroup_response lsngroupResponse = new lsngroup_stats.lsngroup_response();
      lsngroup_stats.lsngroup_response resource = (lsngroup_stats.lsngroup_response) service.get_payload_formatter().string_to_resource(lsngroupResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup;
    }

    internal override string get_object_name() => this.groupname;

    public static lsngroup_stats[] get(nitro_service service) => (lsngroup_stats[]) new lsngroup_stats().stat_resources(service, (options) null);

    public static lsngroup_stats[] get(nitro_service service, options option) => (lsngroup_stats[]) new lsngroup_stats().stat_resources(service, option);

    public static lsngroup_stats get(nitro_service service, string groupname) => (lsngroup_stats) new lsngroup_stats()
    {
      groupname = groupname
    }.stat_resource(service);

    private class lsngroup_response : base_response
    {
      public lsngroup_stats[] lsngroup = (lsngroup_stats[]) null;
    }

    public static class clearstatsEnum
    {
      public const string basic = "basic";
      public const string full = "full";
    }
  }
}
