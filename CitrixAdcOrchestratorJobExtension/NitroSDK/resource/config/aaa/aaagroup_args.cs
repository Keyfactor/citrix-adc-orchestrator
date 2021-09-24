// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.config.aaa.aaagroup_args
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


namespace com.citrix.netscaler.nitro.resource.config.aaa
{
  public class aaagroup_args
  {
    private bool? loggedinField = new bool?();
    private uint? weightField = new uint?();

    public bool? loggedin
    {
      get => this.loggedinField;
      set => this.loggedinField = value;
    }

    public uint? weight
    {
      get => this.weightField;
      set => this.weightField = value;
    }
  }
}
