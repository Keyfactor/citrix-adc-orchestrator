// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_binding
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class clusternodegroup_binding : base_resource
  {
    private string nameField = (string) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_csvserver_binding[] clusternodegroup_csvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_csvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_gslbsite_binding[] clusternodegroup_gslbsite_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_gslbsite_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_nslimitidentifier_binding[] clusternodegroup_nslimitidentifier_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_nslimitidentifier_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_clusternode_binding[] clusternodegroup_clusternode_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_clusternode_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_lbvserver_binding[] clusternodegroup_lbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_lbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_vpnvserver_binding[] clusternodegroup_vpnvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_vpnvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_service_binding[] clusternodegroup_service_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_service_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_streamidentifier_binding[] clusternodegroup_streamidentifier_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_streamidentifier_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_gslbvserver_binding[] clusternodegroup_gslbvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_gslbvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_authenticationvserver_binding[] clusternodegroup_authenticationvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_authenticationvserver_binding[]) null;
    private com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_crvserver_binding[] clusternodegroup_crvserver_bindingField = (com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_crvserver_binding[]) null;

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_csvserver_binding[] clusternodegroup_csvserver_binding
    {
      get => this.clusternodegroup_csvserver_bindingField;
      private set => this.clusternodegroup_csvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_vpnvserver_binding[] clusternodegroup_vpnvserver_binding
    {
      get => this.clusternodegroup_vpnvserver_bindingField;
      private set => this.clusternodegroup_vpnvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_crvserver_binding[] clusternodegroup_crvserver_binding
    {
      get => this.clusternodegroup_crvserver_bindingField;
      private set => this.clusternodegroup_crvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_nslimitidentifier_binding[] clusternodegroup_nslimitidentifier_binding
    {
      get => this.clusternodegroup_nslimitidentifier_bindingField;
      private set => this.clusternodegroup_nslimitidentifier_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_gslbsite_binding[] clusternodegroup_gslbsite_binding
    {
      get => this.clusternodegroup_gslbsite_bindingField;
      private set => this.clusternodegroup_gslbsite_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_clusternode_binding[] clusternodegroup_clusternode_binding
    {
      get => this.clusternodegroup_clusternode_bindingField;
      private set => this.clusternodegroup_clusternode_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_authenticationvserver_binding[] clusternodegroup_authenticationvserver_binding
    {
      get => this.clusternodegroup_authenticationvserver_bindingField;
      private set => this.clusternodegroup_authenticationvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_lbvserver_binding[] clusternodegroup_lbvserver_binding
    {
      get => this.clusternodegroup_lbvserver_bindingField;
      private set => this.clusternodegroup_lbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_gslbvserver_binding[] clusternodegroup_gslbvserver_binding
    {
      get => this.clusternodegroup_gslbvserver_bindingField;
      private set => this.clusternodegroup_gslbvserver_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_streamidentifier_binding[] clusternodegroup_streamidentifier_binding
    {
      get => this.clusternodegroup_streamidentifier_bindingField;
      private set => this.clusternodegroup_streamidentifier_bindingField = value;
    }

    public com.citrix.netscaler.nitro.resource.config.cluster.clusternodegroup_service_binding[] clusternodegroup_service_binding
    {
      get => this.clusternodegroup_service_bindingField;
      private set => this.clusternodegroup_service_bindingField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      clusternodegroup_binding.clusternodegroup_binding_response clusternodegroupBindingResponse = new clusternodegroup_binding.clusternodegroup_binding_response();
      clusternodegroup_binding.clusternodegroup_binding_response resource = (clusternodegroup_binding.clusternodegroup_binding_response) service.get_payload_formatter().string_to_resource(clusternodegroupBindingResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return (base_resource[]) resource.clusternodegroup_binding;
    }

    internal override string get_object_name() => this.name;

    public static clusternodegroup_binding get(
      nitro_service service,
      string name)
    {
      return (clusternodegroup_binding) new clusternodegroup_binding()
      {
        name = name
      }.get_resource(service);
    }

    public static clusternodegroup_binding[] get(
      nitro_service service,
      string[] name)
    {
      if (name == null || name.Length <= 0)
        return (clusternodegroup_binding[]) null;
      clusternodegroup_binding[] clusternodegroupBindingArray1 = new clusternodegroup_binding[name.Length];
      clusternodegroup_binding[] clusternodegroupBindingArray2 = new clusternodegroup_binding[name.Length];
      for (int index = 0; index < name.Length; ++index)
      {
        clusternodegroupBindingArray2[index] = new clusternodegroup_binding();
        clusternodegroupBindingArray2[index].name = name[index];
        clusternodegroupBindingArray1[index] = (clusternodegroup_binding) clusternodegroupBindingArray2[index].get_resource(service);
      }
      return clusternodegroupBindingArray1;
    }

    private class clusternodegroup_binding_response : base_response
    {
      public clusternodegroup_binding[] clusternodegroup_binding = (clusternodegroup_binding[]) null;
    }
  }
}
