// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnrtspalgsession_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnrtspalgsession_binding : base_resource
  {
    private string sessionidField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnrtspalgsession_datachannel_binding[] lsnrtspalgsession_datachannel_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnrtspalgsession_datachannel_binding[]) null;

    public string sessionid
    {
      get => this.sessionidField;
      set => this.sessionidField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnrtspalgsession_datachannel_binding[] lsnrtspalgsession_datachannel_binding
    {
      get => this.lsnrtspalgsession_datachannel_bindingField;
      private set => this.lsnrtspalgsession_datachannel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnrtspalgsession_binding.lsnrtspalgsession_binding_response lsnrtspalgsessionBindingResponse = new lsnrtspalgsession_binding.lsnrtspalgsession_binding_response();
      lsnrtspalgsession_binding.lsnrtspalgsession_binding_response resource = (lsnrtspalgsession_binding.lsnrtspalgsession_binding_response) service.get_payload_formatter().string_to_resource(lsnrtspalgsessionBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnrtspalgsession_binding;
    }

    internal override string get_object_name() => this.sessionid;

    public static lsnrtspalgsession_binding get(
      nitro_service service,
      string sessionid)
    {
      return (lsnrtspalgsession_binding) new lsnrtspalgsession_binding()
      {
        sessionid = sessionid
      }.get_resource(service);
    }

    public static lsnrtspalgsession_binding[] get(
      nitro_service service,
      string[] sessionid)
    {
      if (sessionid == null || sessionid.Length <= 0)
        return (lsnrtspalgsession_binding[]) null;
      lsnrtspalgsession_binding[] lsnrtspalgsessionBindingArray1 = new lsnrtspalgsession_binding[sessionid.Length];
      lsnrtspalgsession_binding[] lsnrtspalgsessionBindingArray2 = new lsnrtspalgsession_binding[sessionid.Length];
      for (int index = 0; index < sessionid.Length; ++index)
      {
        lsnrtspalgsessionBindingArray2[index] = new lsnrtspalgsession_binding();
        lsnrtspalgsessionBindingArray2[index].sessionid = sessionid[index];
        lsnrtspalgsessionBindingArray1[index] = (lsnrtspalgsession_binding) lsnrtspalgsessionBindingArray2[index].get_resource(service);
      }
      return lsnrtspalgsessionBindingArray1;
    }

    private class lsnrtspalgsession_binding_response : base_response
    {
      public lsnrtspalgsession_binding[] lsnrtspalgsession_binding = (lsnrtspalgsession_binding[]) null;
    }
  }
}
