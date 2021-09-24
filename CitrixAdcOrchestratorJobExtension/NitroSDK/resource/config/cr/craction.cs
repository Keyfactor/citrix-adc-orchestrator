// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cr.craction
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.cr
{
  public class craction : base_resource
  {
    private string nameField = (string) null;
    private string crtypeField = (string) null;
    private string[] builtinField = (string[]) null;
    private bool? isdefaultField = new bool?();
    private long? hitsField = new long?();
    private string referencecountField = (string) null;
    private long? undefhitsField = new long?();
    private string commentField = (string) null;
    private uint? __countField = new uint?();

    public uint? __count
    {
      get => this.__countField;
      private set => this.__countField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string crtype
    {
      get => this.crtypeField;
      private set => this.crtypeField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    public bool? isdefault
    {
      get => this.isdefaultField;
      private set => this.isdefaultField = value;
    }

    public long? hits
    {
      get => this.hitsField;
      private set => this.hitsField = value;
    }

    public string referencecount
    {
      get => this.referencecountField;
      private set => this.referencecountField = value;
    }

    public long? undefhits
    {
      get => this.undefhitsField;
      private set => this.undefhitsField = value;
    }

    public string comment
    {
      get => this.commentField;
      private set => this.commentField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      craction.craction_response cractionResponse = new craction.craction_response();
      craction.craction_response resource = (craction.craction_response) service.get_payload_formatter().string_to_resource(cractionResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.craction;
    }

    internal override string get_object_name() => this.name;

    public static craction[] get(nitro_service service) => (craction[]) new craction().get_resources(service, (options) null);

    public static craction[] get(nitro_service service, options option) => (craction[]) new craction().get_resources(service, option);

    public static craction get(nitro_service service, string name) => (craction) new craction()
    {
      name = name
    }.get_resource(service);

    public static craction[] get(nitro_service service, string[] name)
    {
      if (name == null || name.Length <= 0)
        return (craction[]) null;
      craction[] cractionArray1 = new craction[name.Length];
      craction[] cractionArray2 = new craction[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        cractionArray2[index] = new craction();
        cractionArray2[index].name = name[index];
        cractionArray1[index] = (craction) cractionArray2[index].get_resource(service);
      }
      return cractionArray1;
    }

    public static craction[] get_filtered(nitro_service service, string filter)
    {
      craction craction = new craction();
      options option = new options();
      option.set_filter(filter);
      return (craction[]) craction.getfiltered(service, option);
    }

    public static craction[] get_filtered(nitro_service service, filtervalue[] filter)
    {
      craction craction = new craction();
      options option = new options();
      option.set_filter(filter);
      return (craction[]) craction.getfiltered(service, option);
    }

    public static uint count(nitro_service service)
    {
      craction craction = new craction();
      options option = new options();
      option.set_count(true);
      craction[] resources = (craction[]) craction.get_resources(service, option);
      return resources != null && resources.Length > 0 ? resources[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, string filter)
    {
      craction craction = new craction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      craction[] cractionArray = (craction[]) craction.getfiltered(service, option);
      return cractionArray != null && cractionArray.Length > 0 ? cractionArray[0].__count.Value : 0U;
    }

    public static uint count_filtered(nitro_service service, filtervalue[] filter)
    {
      craction craction = new craction();
      options option = new options();
      option.set_count(true);
      option.set_filter(filter);
      craction[] cractionArray = (craction[]) craction.getfiltered(service, option);
      return cractionArray != null && cractionArray.Length > 0 ? cractionArray[0].__count.Value : 0U;
    }

    private class craction_response : base_response
    {
      public craction[] craction = (craction[]) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class crtypeEnum
    {
      public const string origin = "origin";
      public const string cache = "cache";
    }
  }
}
