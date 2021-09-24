// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnsipalgcall_binding : base_resource
  {
    private string callidField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_datachannel_binding[] lsnsipalgcall_datachannel_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_datachannel_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_controlchannel_binding[] lsnsipalgcall_controlchannel_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_controlchannel_binding[]) null;

    public string callid
    {
      get => this.callidField;
      set => this.callidField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_controlchannel_binding[] lsnsipalgcall_controlchannel_binding
    {
      get => this.lsnsipalgcall_controlchannel_bindingField;
      private set => this.lsnsipalgcall_controlchannel_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnsipalgcall_datachannel_binding[] lsnsipalgcall_datachannel_binding
    {
      get => this.lsnsipalgcall_datachannel_bindingField;
      private set => this.lsnsipalgcall_datachannel_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnsipalgcall_binding.lsnsipalgcall_binding_response lsnsipalgcallBindingResponse = new lsnsipalgcall_binding.lsnsipalgcall_binding_response();
      lsnsipalgcall_binding.lsnsipalgcall_binding_response resource = (lsnsipalgcall_binding.lsnsipalgcall_binding_response) service.get_payload_formatter().string_to_resource(lsnsipalgcallBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnsipalgcall_binding;
    }

    internal override string get_object_name() => this.callid;

    public static lsnsipalgcall_binding get(
      nitro_service service,
      string callid)
    {
      return (lsnsipalgcall_binding) new lsnsipalgcall_binding()
      {
        callid = callid
      }.get_resource(service);
    }

    public static lsnsipalgcall_binding[] get(
      nitro_service service,
      string[] callid)
    {
      if (callid == null || callid.Length <= 0)
        return (lsnsipalgcall_binding[]) null;
      lsnsipalgcall_binding[] lsnsipalgcallBindingArray1 = new lsnsipalgcall_binding[callid.Length];
      lsnsipalgcall_binding[] lsnsipalgcallBindingArray2 = new lsnsipalgcall_binding[callid.Length];
      for (int index = 0; index < callid.Length; ++index)
      {
        lsnsipalgcallBindingArray2[index] = new lsnsipalgcall_binding();
        lsnsipalgcallBindingArray2[index].callid = callid[index];
        lsnsipalgcallBindingArray1[index] = (lsnsipalgcall_binding) lsnsipalgcallBindingArray2[index].get_resource(service);
      }
      return lsnsipalgcallBindingArray1;
    }

    private class lsnsipalgcall_binding_response : base_response
    {
      public lsnsipalgcall_binding[] lsnsipalgcall_binding = (lsnsipalgcall_binding[]) null;
    }
  }
}
