// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ssl.sslfips
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.service;

namespace com.citrix.netscaler.nitro.resource.config.ssl
{
  public class sslfips : base_resource
  {
    private string inithsmField = (string) null;
    private string sopasswordField = (string) null;
    private string oldsopasswordField = (string) null;
    private string userpasswordField = (string) null;
    private string hsmlabelField = (string) null;
    private string fipsfwField = (string) null;
    private string erasedataField = (string) null;
    private int? serialField = new int?();
    private int? majorversionField = new int?();
    private int? minorversionField = new int?();
    private int? fipshwmajorversionField = new int?();
    private int? fipshwminorversionField = new int?();
    private string fipshwversionstringField = (string) null;
    private int? flashmemorytotalField = new int?();
    private int? flashmemoryfreeField = new int?();
    private int? sramtotalField = new int?();
    private int? sramfreeField = new int?();
    private int? statusField = new int?();
    private int? flagField = new int?();
    private string serialnoField = (string) null;
    private string modelField = (string) null;
    private int? stateField = new int?();
    private string firmwarereleasedateField = (string) null;
    private int? coresmaxField = new int?();
    private int? coresenabledField = new int?();

    public string inithsm
    {
      get => this.inithsmField;
      set => this.inithsmField = value;
    }

    public string sopassword
    {
      get => this.sopasswordField;
      set => this.sopasswordField = value;
    }

    public string oldsopassword
    {
      get => this.oldsopasswordField;
      set => this.oldsopasswordField = value;
    }

    public string userpassword
    {
      get => this.userpasswordField;
      set => this.userpasswordField = value;
    }

    public string hsmlabel
    {
      get => this.hsmlabelField;
      set => this.hsmlabelField = value;
    }

    public string fipsfw
    {
      get => this.fipsfwField;
      set => this.fipsfwField = value;
    }

    public string erasedata
    {
      get => this.erasedataField;
      private set => this.erasedataField = value;
    }

    public int? serial
    {
      get => this.serialField;
      private set => this.serialField = value;
    }

    public int? majorversion
    {
      get => this.majorversionField;
      private set => this.majorversionField = value;
    }

    public int? minorversion
    {
      get => this.minorversionField;
      private set => this.minorversionField = value;
    }

    public int? fipshwmajorversion
    {
      get => this.fipshwmajorversionField;
      private set => this.fipshwmajorversionField = value;
    }

    public int? fipshwminorversion
    {
      get => this.fipshwminorversionField;
      private set => this.fipshwminorversionField = value;
    }

    public string fipshwversionstring
    {
      get => this.fipshwversionstringField;
      private set => this.fipshwversionstringField = value;
    }

    public int? flashmemorytotal
    {
      get => this.flashmemorytotalField;
      private set => this.flashmemorytotalField = value;
    }

    public int? flashmemoryfree
    {
      get => this.flashmemoryfreeField;
      private set => this.flashmemoryfreeField = value;
    }

    public int? sramtotal
    {
      get => this.sramtotalField;
      private set => this.sramtotalField = value;
    }

    public int? sramfree
    {
      get => this.sramfreeField;
      private set => this.sramfreeField = value;
    }

    public int? status
    {
      get => this.statusField;
      private set => this.statusField = value;
    }

    public int? flag
    {
      get => this.flagField;
      private set => this.flagField = value;
    }

    public string serialno
    {
      get => this.serialnoField;
      private set => this.serialnoField = value;
    }

    public string model
    {
      get => this.modelField;
      private set => this.modelField = value;
    }

    public int? state
    {
      get => this.stateField;
      private set => this.stateField = value;
    }

    public string firmwarereleasedate
    {
      get => this.firmwarereleasedateField;
      private set => this.firmwarereleasedateField = value;
    }

    public int? coresmax
    {
      get => this.coresmaxField;
      private set => this.coresmaxField = value;
    }

    public int? coresenabled
    {
      get => this.coresenabledField;
      private set => this.coresenabledField = value;
    }

    internal override base_resource[] get_nitro_response(
      nitro_service service,
      string response)
    {
      sslfips[] sslfipsArray = new sslfips[1];
      sslfips.sslfips_response sslfipsResponse = new sslfips.sslfips_response();
      sslfips.sslfips_response resource = (sslfips.sslfips_response) service.get_payload_formatter().string_to_resource(sslfipsResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      sslfipsArray[0] = resource.sslfips;
      return (base_resource[]) sslfipsArray;
    }

    internal override string get_object_name() => (string) null;

    public static base_response update(nitro_service client, sslfips resource) => new sslfips()
    {
      inithsm = resource.inithsm,
      sopassword = resource.sopassword,
      oldsopassword = resource.oldsopassword,
      userpassword = resource.userpassword,
      hsmlabel = resource.hsmlabel
    }.update_resource(client);

    public static base_response unset(
      nitro_service client,
      sslfips resource,
      string[] args)
    {
      return new sslfips().unset_resource(client, args);
    }

    public static base_response reset(nitro_service client, sslfips resource) => new sslfips().perform_operation_byaction(client, nameof (reset));

    public static base_response change(nitro_service client, sslfips resource) => new sslfips()
    {
      fipsfw = resource.fipsfw
    }.perform_operation_byaction(client, "update");

    public static sslfips get(nitro_service service) => ((sslfips[]) new sslfips().get_resources(service, (options) null))[0];

    public static sslfips get(nitro_service service, options option) => ((sslfips[]) new sslfips().get_resources(service, option))[0];

    private class sslfips_response : base_response
    {
      public sslfips sslfips = (sslfips) null;
    }

    public static class inithsmEnum
    {
      public const string Level_2 = "Level-2";
    }
  }
}
