// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.appfw.appfwlearningdata_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.appfw
{
  public class appfwlearningdata_args
  {
    private string profilenameField = (string) null;
    private string securitycheckField = (string) null;

    public string profilename
    {
      get => this.profilenameField;
      set => this.profilenameField = value;
    }

    public string securitycheck
    {
      get => this.securitycheckField;
      set => this.securitycheckField = value;
    }

    public static class securitycheckEnum
    {
      public const string startURL = "startURL";
      public const string cookieConsistency = "cookieConsistency";
      public const string fieldConsistency = "fieldConsistency";
      public const string crossSiteScripting = "crossSiteScripting";
      public const string SQLInjection = "SQLInjection";
      public const string fieldFormat = "fieldFormat";
      public const string CSRFtag = "CSRFtag";
      public const string XMLDoSCheck = "XMLDoSCheck";
      public const string XMLWSICheck = "XMLWSICheck";
      public const string XMLAttachmentCheck = "XMLAttachmentCheck";
      public const string TotalXMLRequests = "TotalXMLRequests";
      public const string creditCardNumber = "creditCardNumber";
      public const string ContentType = "ContentType";
    }
  }
}
