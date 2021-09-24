// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslcrl_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslcrl_binding : base_resource
  {
    private string crlnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.ssl.sslcrl_serialnumber_binding[] sslcrl_serialnumber_bindingField = (com.citrix.netscaler.nitro.resource.config.ssl.sslcrl_serialnumber_binding[]) null;

    public string crlname
    {
      get => this.crlnameField;
      set => this.crlnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.ssl.sslcrl_serialnumber_binding[] sslcrl_serialnumber_binding
    {
      get => this.sslcrl_serialnumber_bindingField;
      private set => this.sslcrl_serialnumber_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslcrl_binding.sslcrl_binding_response sslcrlBindingResponse = new sslcrl_binding.sslcrl_binding_response();
      sslcrl_binding.sslcrl_binding_response resource = (sslcrl_binding.sslcrl_binding_response) service.get_payload_formatter().string_to_resource(sslcrlBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.sslcrl_binding;
    }

    internal override string get_object_name() => this.crlname;

    public static sslcrl_binding get(nitro_service service, string crlname) => (sslcrl_binding) new sslcrl_binding()
    {
      crlname = crlname
    }.get_resource(service);

    public static sslcrl_binding[] get(nitro_service service, string[] crlname)
    {
      if (crlname == null || crlname.Length <= 0)
        return (sslcrl_binding[]) null;
      sslcrl_binding[] sslcrlBindingArray1 = new sslcrl_binding[crlname.Length];
      sslcrl_binding[] sslcrlBindingArray2 = new sslcrl_binding[crlname.Length];
      for (int index = 0; index < crlname.Length; ++index)
      {
        sslcrlBindingArray2[index] = new sslcrl_binding();
        sslcrlBindingArray2[index].crlname = crlname[index];
        sslcrlBindingArray1[index] = (sslcrl_binding) sslcrlBindingArray2[index].get_resource(service);
      }
      return sslcrlBindingArray1;
    }

    private class sslcrl_binding_response : base_response
    {
      public sslcrl_binding[] sslcrl_binding = (sslcrl_binding[]) null;
    }
  }
}
