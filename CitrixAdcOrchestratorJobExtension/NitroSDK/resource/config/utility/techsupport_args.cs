// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.utility.techsupport_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.utility
{
  public class techsupport_args
  {
    private string scopeField = (string) null;
    private string partitionnameField = (string) null;
    private bool? uploadField = new bool?();
    private string proxyField = (string) null;
    private string casenumberField = (string) null;
    private string fileField = (string) null;
    private string descriptionField = (string) null;
    private string usernameField = (string) null;
    private string passwordField = (string) null;

    public string scope
    {
      get => this.scopeField;
      set => this.scopeField = value;
    }

    public string partitionname
    {
      get => this.partitionnameField;
      set => this.partitionnameField = value;
    }

    public bool? upload
    {
      get => this.uploadField;
      set => this.uploadField = value;
    }

    public string proxy
    {
      get => this.proxyField;
      set => this.proxyField = value;
    }

    public string casenumber
    {
      get => this.casenumberField;
      set => this.casenumberField = value;
    }

    public string file
    {
      get => this.fileField;
      set => this.fileField = value;
    }

    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public string username
    {
      get => this.usernameField;
      set => this.usernameField = value;
    }

    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public static class scopeEnum
    {
      public const string NODE = "NODE";
      public const string CLUSTER = "CLUSTER";
      public const string PARTITION = "PARTITION";
    }
  }
}
