// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.lsn
{
  public class lsngroup_binding : base_resource
  {
    private string groupnameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnsipalgprofile_binding[] lsngroup_lsnsipalgprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnsipalgprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsntransportprofile_binding[] lsngroup_lsntransportprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsntransportprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnlogprofile_binding[] lsngroup_lsnlogprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnlogprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnhttphdrlogprofile_binding[] lsngroup_lsnhttphdrlogprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnhttphdrlogprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnpool_binding[] lsngroup_lsnpool_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnpool_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnrtspalgprofile_binding[] lsngroup_lsnrtspalgprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnrtspalgprofile_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnappsprofile_binding[] lsngroup_lsnappsprofile_bindingField = (com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnappsprofile_binding[]) null;

    public string groupname
    {
      get => this.groupnameField;
      set => this.groupnameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnhttphdrlogprofile_binding[] lsngroup_lsnhttphdrlogprofile_binding
    {
      get => this.lsngroup_lsnhttphdrlogprofile_bindingField;
      private set => this.lsngroup_lsnhttphdrlogprofile_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnrtspalgprofile_binding[] lsngroup_lsnrtspalgprofile_binding
    {
      get => this.lsngroup_lsnrtspalgprofile_bindingField;
      private set => this.lsngroup_lsnrtspalgprofile_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnsipalgprofile_binding[] lsngroup_lsnsipalgprofile_binding
    {
      get => this.lsngroup_lsnsipalgprofile_bindingField;
      private set => this.lsngroup_lsnsipalgprofile_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnlogprofile_binding[] lsngroup_lsnlogprofile_binding
    {
      get => this.lsngroup_lsnlogprofile_bindingField;
      private set => this.lsngroup_lsnlogprofile_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnappsprofile_binding[] lsngroup_lsnappsprofile_binding
    {
      get => this.lsngroup_lsnappsprofile_bindingField;
      private set => this.lsngroup_lsnappsprofile_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsnpool_binding[] lsngroup_lsnpool_binding
    {
      get => this.lsngroup_lsnpool_bindingField;
      private set => this.lsngroup_lsnpool_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.lsn.lsngroup_lsntransportprofile_binding[] lsngroup_lsntransportprofile_binding
    {
      get => this.lsngroup_lsntransportprofile_bindingField;
      private set => this.lsngroup_lsntransportprofile_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      lsngroup_binding.lsngroup_binding_response lsngroupBindingResponse = new lsngroup_binding.lsngroup_binding_response();
      lsngroup_binding.lsngroup_binding_response resource = (lsngroup_binding.lsngroup_binding_response) service.get_payload_formatter().string_to_resource(lsngroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.lsngroup_binding;
    }

    internal override string get_object_name() => this.groupname;

    public static lsngroup_binding get(nitro_service service, string groupname) => (lsngroup_binding) new lsngroup_binding()
    {
      groupname = groupname
    }.get_resource(service);

    public static lsngroup_binding[] get(nitro_service service, string[] groupname)
    {
      if (groupname == null || groupname.Length <= 0)
        return (lsngroup_binding[]) null;
      lsngroup_binding[] lsngroupBindingArray1 = new lsngroup_binding[groupname.Length];
      lsngroup_binding[] lsngroupBindingArray2 = new lsngroup_binding[groupname.Length];
      for (int index = 0; index < groupname.Length; ++index)
      {
        lsngroupBindingArray2[index] = new lsngroup_binding();
        lsngroupBindingArray2[index].groupname = groupname[index];
        lsngroupBindingArray1[index] = (lsngroup_binding) lsngroupBindingArray2[index].get_resource(service);
      }
      return lsngroupBindingArray1;
    }

    private class lsngroup_binding_response : base_response
    {
      public lsngroup_binding[] lsngroup_binding = (lsngroup_binding[]) null;
    }
  }
}
