// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.system.systementity_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.system
{
  public class systementity_args
  {
    private string typeField = (string) null;
    private string datasourceField = (string) null;
    private int? coreField = new int?();

    public string type
    {
      get => this.typeField;
      set => this.typeField = value;
    }

    public string datasource
    {
      get => this.datasourceField;
      set => this.datasourceField = value;
    }

    public int? core
    {
      get => this.coreField;
      set => this.coreField = value;
    }
  }
}
