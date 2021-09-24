// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systemkek
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systemkek : base_resource
  {
    private string passphraseField = (string) null;
    private string passwordField = (string) null;

    public string passphrase
    {
      get => this.passphraseField;
      set => this.passphraseField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      systemkek[] systemkekArray = new systemkek[1];
      systemkek.systemkek_response systemkekResponse = new systemkek.systemkek_response();
      systemkek.systemkek_response resource = (systemkek.systemkek_response) service.get_payload_formatter().string_to_resource(systemkekResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      systemkekArray[0] = resource.systemkek;
      return (base_resource[]) systemkekArray;
    }

    internal override string get_object_name() => this.passphrase;

    public static base_response create(nitro_service client, systemkek resource) => new systemkek()
    {
      passphrase = resource.passphrase
    }.perform_operation_byaction(client, nameof (create));

    public static base_response export(nitro_service client, systemkek resource) => new systemkek()
    {
      password = resource.password
    }.perform_operation_byaction(client, nameof (export));

    public static base_response Import(nitro_service client, systemkek resource) => new systemkek()
    {
      password = resource.password
    }.perform_operation_byaction(client, nameof (Import));

    private class systemkek_response : base_response
    {
      public systemkek systemkek = (systemkek) null;
    }
  }
}
