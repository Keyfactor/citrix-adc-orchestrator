// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.network.l2param
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.network
{
  public class l2param : base_resource
  {
    private uint? mbfpeermacupdateField = new uint?();
    private uint? maxbridgecollisionField = new uint?();
    private string bdggrpproxyarpField = (string) null;
    private string bdgsettingField = (string) null;
    private string garponvridintfField = (string) null;
    private string macmodefwdmypktField = (string) null;
    private string usemymacField = (string) null;
    private string proxyarpField = (string) null;
    private string garpreplyField = (string) null;
    private string mbfinstlearningField = (string) null;
    private string rstintfonhafoField = (string) null;
    private string skipproxyingbsdtrafficField = (string) null;
    private string returntoethernetsenderField = (string) null;
    private string stopmacmoveupdateField = (string) null;

    public uint? mbfpeermacupdate
    {
      get => this.mbfpeermacupdateField;
      set => this.mbfpeermacupdateField = value;
    }

    public uint? maxbridgecollision
    {
      get => this.maxbridgecollisionField;
      set => this.maxbridgecollisionField = value;
    }

    public string bdggrpproxyarp
    {
      get => this.bdggrpproxyarpField;
      set => this.bdggrpproxyarpField = value;
    }

    public string bdgsetting
    {
      get => this.bdgsettingField;
      set => this.bdgsettingField = value;
    }

    public string garponvridintf
    {
      get => this.garponvridintfField;
      set => this.garponvridintfField = value;
    }

    public string macmodefwdmypkt
    {
      get => this.macmodefwdmypktField;
      set => this.macmodefwdmypktField = value;
    }

    public string usemymac
    {
      get => this.usemymacField;
      set => this.usemymacField = value;
    }

    public string proxyarp
    {
      get => this.proxyarpField;
      set => this.proxyarpField = value;
    }

    public string garpreply
    {
      get => this.garpreplyField;
      set => this.garpreplyField = value;
    }

    public string mbfinstlearning
    {
      get => this.mbfinstlearningField;
      set => this.mbfinstlearningField = value;
    }

    public string rstintfonhafo
    {
      get => this.rstintfonhafoField;
      set => this.rstintfonhafoField = value;
    }

    public string skipproxyingbsdtraffic
    {
      get => this.skipproxyingbsdtrafficField;
      set => this.skipproxyingbsdtrafficField = value;
    }

    public string returntoethernetsender
    {
      get => this.returntoethernetsenderField;
      set => this.returntoethernetsenderField = value;
    }

    public string stopmacmoveupdate
    {
      get => this.stopmacmoveupdateField;
      set => this.stopmacmoveupdateField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      l2param[] l2paramArray = new l2param[1];
      l2param.l2param_response l2paramResponse = new l2param.l2param_response();
      l2param.l2param_response resource = (l2param.l2param_response) service.get_payload_formatter().string_to_resource(l2paramResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      l2paramArray[0] = resource.l2param;
      return (base_resource[]) l2paramArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, l2param resource) => new l2param()
    {
      mbfpeermacupdate = resource.mbfpeermacupdate,
      maxbridgecollision = resource.maxbridgecollision,
      bdggrpproxyarp = resource.bdggrpproxyarp,
      bdgsetting = resource.bdgsetting,
      garponvridintf = resource.garponvridintf,
      macmodefwdmypkt = resource.macmodefwdmypkt,
      usemymac = resource.usemymac,
      proxyarp = resource.proxyarp,
      garpreply = resource.garpreply,
      mbfinstlearning = resource.mbfinstlearning,
      rstintfonhafo = resource.rstintfonhafo,
      skipproxyingbsdtraffic = resource.skipproxyingbsdtraffic,
      returntoethernetsender = resource.returntoethernetsender,
      stopmacmoveupdate = resource.stopmacmoveupdate
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      l2param resource,
      string[] args)
    {
      return new l2param().unset_resource(client, args);
    }

    public static l2param get(nitro_service service) => ((l2param[]) new l2param().get_resources(service, (options) null))[0];

    public static l2param get(nitro_service service, options option) => ((l2param[]) new l2param().get_resources(service, option))[0];

    private class l2param_response : base_response
    {
      public l2param l2param = (l2param) null;
    }

    public static class proxyarpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class usemymacEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class bdgsettingEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class returntoethernetsenderEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class rstintfonhafoEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class mbfinstlearningEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class macmodefwdmypktEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class bdggrpproxyarpEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class garponvridintfEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class garpreplyEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class skipproxyingbsdtrafficEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }

    public static class stopmacmoveupdateEnum
    {
      public const string ENABLED = "ENABLED";
      public const string DISABLED = "DISABLED";
    }
  }
}
