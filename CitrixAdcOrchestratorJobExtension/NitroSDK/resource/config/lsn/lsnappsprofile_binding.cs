// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsnappsprofile_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsnappsprofile_binding : base_resource
  {
    private string appsprofilenameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsnappsprofile_port_binding[] lsnappsprofile_port_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsnappsprofile_port_binding[]) null;

    public string appsprofilename
    {
      get => this.appsprofilenameField;
      set => this.appsprofilenameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsnappsprofile_port_binding[] lsnappsprofile_port_binding
    {
      get => this.lsnappsprofile_port_bindingField;
      private set => this.lsnappsprofile_port_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsnappsprofile_binding.lsnappsprofile_binding_response lsnappsprofileBindingResponse = new lsnappsprofile_binding.lsnappsprofile_binding_response();
      lsnappsprofile_binding.lsnappsprofile_binding_response resource = (lsnappsprofile_binding.lsnappsprofile_binding_response) service.get_payload_formatter().string_to_resource(lsnappsprofileBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsnappsprofile_binding;
    }

    internal override string get_object_name() => this.appsprofilename;

    public static lsnappsprofile_binding get(
      nitro_service service,
      string appsprofilename)
    {
      return (lsnappsprofile_binding) new lsnappsprofile_binding()
      {
        appsprofilename = appsprofilename
      }.get_resource(service);
    }

    public static lsnappsprofile_binding[] get(
      nitro_service service,
      string[] appsprofilename)
    {
      if (appsprofilename == null || appsprofilename.Length <= 0)
        return (lsnappsprofile_binding[]) null;
      lsnappsprofile_binding[] lsnappsprofileBindingArray1 = new lsnappsprofile_binding[appsprofilename.Length];
      lsnappsprofile_binding[] lsnappsprofileBindingArray2 = new lsnappsprofile_binding[appsprofilename.Length];
      for (int index = 0; index < appsprofilename.Length; ++index)
      {
        lsnappsprofileBindingArray2[index] = new lsnappsprofile_binding();
        lsnappsprofileBindingArray2[index].appsprofilename = appsprofilename[index];
        lsnappsprofileBindingArray1[index] = (lsnappsprofile_binding) lsnappsprofileBindingArray2[index].get_resource(service);
      }
      return lsnappsprofileBindingArray1;
    }

    private class lsnappsprofile_binding_response : base_response
    {
      public lsnappsprofile_binding[] lsnappsprofile_binding = (lsnappsprofile_binding[]) null;
    }
  }
}
