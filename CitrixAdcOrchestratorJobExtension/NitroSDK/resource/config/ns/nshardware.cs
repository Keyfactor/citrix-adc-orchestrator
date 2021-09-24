// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nshardware
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nshardware : base_resource
  {
    private string hwdescriptionField = (string) null;
    private uint? sysidField = new uint?();
    private int? manufacturedayField = new int?();
    private int? manufacturemonthField = new int?();
    private int? manufactureyearField = new int?();
    private int? cpufrequncyField = new int?();
    private int? hostidField = new int?();
    private string hostField = (string) null;
    private string serialnoField = (string) null;
    private string encodedserialnoField = (string) null;

    public string hwdescription
    {
      get => this.hwdescriptionField;
      private set => this.hwdescriptionField = value;
    }

    public uint? sysid
    {
      get => this.sysidField;
      private set => this.sysidField = value;
    }

    public int? manufactureday
    {
      get => this.manufacturedayField;
      private set => this.manufacturedayField = value;
    }

    public int? manufacturemonth
    {
      get => this.manufacturemonthField;
      private set => this.manufacturemonthField = value;
    }

    public int? manufactureyear
    {
      get => this.manufactureyearField;
      private set => this.manufactureyearField = value;
    }

    public int? cpufrequncy
    {
      get => this.cpufrequncyField;
      private set => this.cpufrequncyField = value;
    }

    public int? hostid
    {
      get => this.hostidField;
      private set => this.hostidField = value;
    }

    public string host
    {
      get => this.hostField;
      private set => this.hostField = value;
    }

    public string serialno
    {
      get => this.serialnoField;
      private set => this.serialnoField = value;
    }

    public string encodedserialno
    {
      get => this.encodedserialnoField;
      private set => this.encodedserialnoField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      nshardware[] nshardwareArray = new nshardware[1];
      nshardware.nshardware_response nshardwareResponse = new nshardware.nshardware_response();
      nshardware.nshardware_response resource = (nshardware.nshardware_response) service.get_payload_formatter().string_to_resource(nshardwareResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      nshardwareArray[0] = resource.nshardware;
      return (base_resource[]) nshardwareArray;
    }

    internal override string get_object_name() => (string) null;

    public static nshardware get(nitro_service service) => ((nshardware[]) new nshardware().get_resources(service, (options) null))[0];

    public static nshardware get(nitro_service service, options option) => ((nshardware[]) new nshardware().get_resources(service, option))[0];

    private class nshardware_response : base_response
    {
      public nshardware nshardware = (nshardware) null;
    }
  }
}
