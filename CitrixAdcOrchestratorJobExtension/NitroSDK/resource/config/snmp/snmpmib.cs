// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.snmp.snmpmib
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.snmp
{
  public class snmpmib : base_resource
  {
    private string contactField = (string) null;
    private string nameField = (string) null;
    private string locationField = (string) null;
    private string customidField = (string) null;
    private string sysdescField = (string) null;
    private long? sysuptimeField = new long?();
    private uint? sysservicesField = new uint?();
    private string sysoidField = (string) null;

    public string contact
    {
      get => this.contactField;
      set => this.contactField = value;
    }

    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public string location
    {
      get => this.locationField;
      set => this.locationField = value;
    }

    public string customid
    {
      get => this.customidField;
      set => this.customidField = value;
    }

    public string sysdesc
    {
      get => this.sysdescField;
      private set => this.sysdescField = value;
    }

    public long? sysuptime
    {
      get => this.sysuptimeField;
      private set => this.sysuptimeField = value;
    }

    public uint? sysservices
    {
      get => this.sysservicesField;
      private set => this.sysservicesField = value;
    }

    public string sysoid
    {
      get => this.sysoidField;
      private set => this.sysoidField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      snmpmib[] snmpmibArray = new snmpmib[1];
      snmpmib.snmpmib_response snmpmibResponse = new snmpmib.snmpmib_response();
      snmpmib.snmpmib_response resource = (snmpmib.snmpmib_response) service.get_payload_formatter().string_to_resource(snmpmibResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      snmpmibArray[0] = resource.snmpmib;
      return (base_resource[]) snmpmibArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, snmpmib resource) => new snmpmib()
    {
      contact = resource.contact,
      name = resource.name,
      location = resource.location,
      customid = resource.customid
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      snmpmib resource,
      string[] args)
    {
      return new snmpmib().unset_resource(client, args);
    }

    public static snmpmib get(nitro_service service) => ((snmpmib[]) new snmpmib().get_resources(service, (options) null))[0];

    public static snmpmib get(nitro_service service, options option) => ((snmpmib[]) new snmpmib().get_resources(service, option))[0];

    private class snmpmib_response : base_response
    {
      public snmpmib snmpmib = (snmpmib) null;
    }
  }
}
