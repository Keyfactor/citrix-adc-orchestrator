// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemsshkey
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemsshkey : base_resource
  {
    private string nameField = (string) null;
    private string sshkeytypeField = (string) null;
    private string srcField = (string) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string sshkeytype
    {
      get => this.sshkeytypeField;
      set => this.sshkeytypeField = value;
    }

    public string src
    {
      get => this.srcField;
      set => this.srcField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemsshkey[] systemsshkeyArray = new systemsshkey[1];
      systemsshkey.systemsshkey_response systemsshkeyResponse = new systemsshkey.systemsshkey_response();
      systemsshkey.systemsshkey_response resource = (systemsshkey.systemsshkey_response) service.get_payload_formatter().string_to_resource(systemsshkeyResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemsshkeyArray[0] = resource.systemsshkey;
      return (base_resource[]) systemsshkeyArray;
    }

    internal override string get_object_name() => this.name;

    public static base_response delete(nitro_service client, string name) => new systemsshkey()
    {
      name = name
    }.delete_resource(client);

    public static base_response delete(nitro_service client, systemsshkey resource) => new systemsshkey()
    {
      name = resource.name,
      sshkeytype = resource.sshkeytype
    }.delete_resource(client);

    public static base_response Import(nitro_service client, systemsshkey resource) => new systemsshkey()
    {
      name = resource.name,
      src = resource.src,
      sshkeytype = resource.sshkeytype
    }.perform_operation_byaction(client, nameof (Import));

    public static systemsshkey get(nitro_service service) => ((systemsshkey[]) new systemsshkey().get_resources(service, (options) null))[0];

    public static systemsshkey get(nitro_service service, options option) => ((systemsshkey[]) new systemsshkey().get_resources(service, option))[0];

    public static systemsshkey[] get(nitro_service service, systemsshkey_args args)
    {
      systemsshkey systemsshkey = new systemsshkey();
      options option = new options();
      option.set_args(nitro_util.object_to_string_withoutquotes((object) args));
      return (systemsshkey[]) systemsshkey.get_resources(service, option);
    }

    private class systemsshkey_response : base_response
    {
      public systemsshkey systemsshkey = (systemsshkey) null;
    }

    public static class sshkeytypeEnum
    {
      public const string PRIVATE = "PRIVATE";
      public const string PUBLIC = "PUBLIC";
    }
  }
}
