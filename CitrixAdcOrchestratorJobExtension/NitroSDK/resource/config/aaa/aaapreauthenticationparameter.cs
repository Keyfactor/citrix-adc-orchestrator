// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaapreauthenticationparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaapreauthenticationparameter : base_resource
  {
    private string preauthenticationactionField = (string) null;
    private string ruleField = (string) null;
    private string killprocessField = (string) null;
    private string deletefilesField = (string) null;
    private string[] builtinField = (string[]) null;

    public string preauthenticationaction
    {
      get => this.preauthenticationactionField;
      set => this.preauthenticationactionField = value;
    }

    public string rule
    {
      get => this.ruleField;
      set => this.ruleField = value;
    }

    public string killprocess
    {
      get => this.killprocessField;
      set => this.killprocessField = value;
    }

    public string deletefiles
    {
      get => this.deletefilesField;
      set => this.deletefilesField = value;
    }

    public string[] builtin
    {
      get => this.builtinField;
      private set => this.builtinField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      aaapreauthenticationparameter[] aaapreauthenticationparameterArray = new aaapreauthenticationparameter[1];
      aaapreauthenticationparameter.aaapreauthenticationparameter_response aaapreauthenticationparameterResponse = new aaapreauthenticationparameter.aaapreauthenticationparameter_response();
      aaapreauthenticationparameter.aaapreauthenticationparameter_response resource = (aaapreauthenticationparameter.aaapreauthenticationparameter_response) service.get_payload_formatter().string_to_resource(aaapreauthenticationparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      aaapreauthenticationparameterArray[0] = resource.aaapreauthenticationparameter;
      return (base_resource[]) aaapreauthenticationparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      aaapreauthenticationparameter resource)
    {
      return new aaapreauthenticationparameter()
      {
        preauthenticationaction = resource.preauthenticationaction,
        rule = resource.rule,
        killprocess = resource.killprocess,
        deletefiles = resource.deletefiles
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      aaapreauthenticationparameter resource,
      string[] args)
    {
      return new aaapreauthenticationparameter().unset_resource(client, args);
    }

    public static aaapreauthenticationparameter get(
      nitro_service service)
    {
      return ((aaapreauthenticationparameter[]) new aaapreauthenticationparameter().get_resources(service, (options) null))[0];
    }

    public static aaapreauthenticationparameter get(
      nitro_service service,
      options option)
    {
      return ((aaapreauthenticationparameter[]) new aaapreauthenticationparameter().get_resources(service, option))[0];
    }

    private class aaapreauthenticationparameter_response : base_response
    {
      public aaapreauthenticationparameter aaapreauthenticationparameter = (aaapreauthenticationparameter) null;
    }

    public static class builtinEnum
    {
      public const string MODIFIABLE = "MODIFIABLE";
      public const string DELETABLE = "DELETABLE";
      public const string IMMUTABLE = "IMMUTABLE";
      public const string PARTITION_ALL = "PARTITION_ALL";
    }

    public static class preauthenticationactionEnum
    {
      public const string ALLOW = "ALLOW";
      public const string DENY = "DENY";
    }
  }
}
