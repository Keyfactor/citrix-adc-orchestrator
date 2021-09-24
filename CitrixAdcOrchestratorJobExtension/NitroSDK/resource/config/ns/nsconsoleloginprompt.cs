// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nsconsoleloginprompt
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nsconsoleloginprompt : base_resource
  {
    private string promptstringField = (string) null;

    public string promptstring
    {
      get => this.promptstringField;
      set => this.promptstringField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nsconsoleloginprompt[] nsconsoleloginpromptArray = new nsconsoleloginprompt[1];
      nsconsoleloginprompt.nsconsoleloginprompt_response nsconsoleloginpromptResponse = new nsconsoleloginprompt.nsconsoleloginprompt_response();
      nsconsoleloginprompt.nsconsoleloginprompt_response resource = (nsconsoleloginprompt.nsconsoleloginprompt_response) service.get_payload_formatter().string_to_resource(nsconsoleloginpromptResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nsconsoleloginpromptArray[0] = resource.nsconsoleloginprompt;
      return (base_resource[]) nsconsoleloginpromptArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(
      nitro_service client,
      nsconsoleloginprompt resource)
    {
      return new nsconsoleloginprompt()
      {
        promptstring = resource.promptstring
      }.update_resource(client);
    }

    public static base_response unset(
      nitro_service client,
      nsconsoleloginprompt resource,
      string[] args)
    {
      return new nsconsoleloginprompt().unset_resource(client, args);
    }

    public static nsconsoleloginprompt get(nitro_service service) => ((nsconsoleloginprompt[]) new nsconsoleloginprompt().get_resources(service, (options) null))[0];

    public static nsconsoleloginprompt get(
      nitro_service service,
      options option)
    {
      return ((nsconsoleloginprompt[]) new nsconsoleloginprompt().get_resources(service, option))[0];
    }

    private class nsconsoleloginprompt_response : base_response
    {
      public nsconsoleloginprompt nsconsoleloginprompt = (nsconsoleloginprompt) null;
    }
  }
}
