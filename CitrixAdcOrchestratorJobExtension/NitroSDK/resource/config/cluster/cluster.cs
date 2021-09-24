// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cluster.cluster
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cluster
{
  public class cluster : base_resource
  {
    private string clipField = (string) null;
    private string passwordField = (string) null;

    public string clip
    {
      get => this.clipField;
      set => this.clipField = value;
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
      com.citrix.netscaler.nitro.resource.config.cluster.cluster[] clusterArray = new com.citrix.netscaler.nitro.resource.config.cluster.cluster[1];
      com.citrix.netscaler.nitro.resource.config.cluster.cluster.cluster_response clusterResponse = new com.citrix.netscaler.nitro.resource.config.cluster.cluster.cluster_response();
      com.citrix.netscaler.nitro.resource.config.cluster.cluster.cluster_response resource = (com.citrix.netscaler.nitro.resource.config.cluster.cluster.cluster_response) service.get_payload_formatter().string_to_resource(clusterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      clusterArray[0] = resource.cluster;
      return (base_resource[]) clusterArray;
    }

    internal override string get_object_name() => this.clip;

    public static base_response join(nitro_service client, com.citrix.netscaler.nitro.resource.config.cluster.cluster resource) => new com.citrix.netscaler.nitro.resource.config.cluster.cluster()
    {
      clip = resource.clip,
      password = resource.password
    }.perform_operation_byaction(client, nameof (join));

    private class cluster_response : base_response
    {
      public com.citrix.netscaler.nitro.resource.config.cluster.cluster cluster = (com.citrix.netscaler.nitro.resource.config.cluster.cluster) null;
    }
  }
}
