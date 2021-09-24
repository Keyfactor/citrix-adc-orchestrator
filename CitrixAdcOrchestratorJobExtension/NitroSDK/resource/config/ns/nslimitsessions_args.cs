// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.ns.nslimitsessions_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.ns
{
  public class nslimitsessions_args
  {
    private string limitidentifierField = (string) null;
    private bool? detailField = new bool?();

    public string limitidentifier
    {
      get => this.limitidentifierField;
      set => this.limitidentifierField = value;
    }

    public bool? detail
    {
      get => this.detailField;
      set => this.detailField = value;
    }
  }
}
