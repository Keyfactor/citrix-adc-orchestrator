// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.cache.cacheparameter
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.cache
{
  public class cacheparameter : base_resource
  {
    private long? memlimitField = new long?();
    private string viaField = (string) null;
    private string verifyusingField = (string) null;
    private uint? maxpostlenField = new uint?();
    private uint? prefetchmaxpendingField = new uint?();
    private string enablebypassField = (string) null;
    private string undefactionField = (string) null;
    private string enablehaobjpersistField = (string) null;
    private long? disklimitField = new long?();
    private long? maxdisklimitField = new long?();
    private long? memlimitactiveField = new long?();
    private long? maxmemlimitField = new long?();
    private uint? prefetchcurField = new uint?();

    public long? memlimit
    {
      get => this.memlimitField;
      set => this.memlimitField = value;
    }

    public string via
    {
      get => this.viaField;
      set => this.viaField = value;
    }

    public string verifyusing
    {
      get => this.verifyusingField;
      set => this.verifyusingField = value;
    }

    public uint? maxpostlen
    {
      get => this.maxpostlenField;
      set => this.maxpostlenField = value;
    }

    public uint? prefetchmaxpending
    {
      get => this.prefetchmaxpendingField;
      set => this.prefetchmaxpendingField = value;
    }

    public string enablebypass
    {
      get => this.enablebypassField;
      set => this.enablebypassField = value;
    }

    public string undefaction
    {
      get => this.undefactionField;
      set => this.undefactionField = value;
    }

    public string enablehaobjpersist
    {
      get => this.enablehaobjpersistField;
      set => this.enablehaobjpersistField = value;
    }

    public long? disklimit
    {
      get => this.disklimitField;
      private set => this.disklimitField = value;
    }

    public long? maxdisklimit
    {
      get => this.maxdisklimitField;
      private set => this.maxdisklimitField = value;
    }

    public long? memlimitactive
    {
      get => this.memlimitactiveField;
      private set => this.memlimitactiveField = value;
    }

    public long? maxmemlimit
    {
      get => this.maxmemlimitField;
      private set => this.maxmemlimitField = value;
    }

    public uint? prefetchcur
    {
      get => this.prefetchcurField;
      private set => this.prefetchcurField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      cacheparameter[] cacheparameterArray = new cacheparameter[1];
      cacheparameter.cacheparameter_response cacheparameterResponse = new cacheparameter.cacheparameter_response();
      cacheparameter.cacheparameter_response resource = (cacheparameter.cacheparameter_response) service.get_payload_formatter().string_to_resource(cacheparameterResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      cacheparameterArray[0] = resource.cacheparameter;
      return (base_resource[]) cacheparameterArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, cacheparameter resource) => new cacheparameter()
    {
      memlimit = resource.memlimit,
      via = resource.via,
      verifyusing = resource.verifyusing,
      maxpostlen = resource.maxpostlen,
      prefetchmaxpending = resource.prefetchmaxpending,
      enablebypass = resource.enablebypass,
      undefaction = resource.undefaction,
      enablehaobjpersist = resource.enablehaobjpersist
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      cacheparameter resource,
      string[] args)
    {
      return new cacheparameter().unset_resource(client, args);
    }

    public static cacheparameter get(nitro_service service) => ((cacheparameter[]) new cacheparameter().get_resources(service, (options) null))[0];

    public static cacheparameter get(nitro_service service, options option) => ((cacheparameter[]) new cacheparameter().get_resources(service, option))[0];

    private class cacheparameter_response : base_response
    {
      public cacheparameter cacheparameter = (cacheparameter) null;
    }

    public static class verifyusingEnum
    {
      public const string HOSTNAME = "HOSTNAME";
      public const string HOSTNAME_AND_IP = "HOSTNAME_AND_IP";
      public const string DNS = "DNS";
    }

    public static class enablehaobjpersistEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }

    public static class undefactionEnum
    {
      public const string NOCACHE = "NOCACHE";
      public const string RESET = "RESET";
    }

    public static class enablebypassEnum
    {
      public const string YES = "YES";
      public const string NO = "NO";
    }
  }
}
