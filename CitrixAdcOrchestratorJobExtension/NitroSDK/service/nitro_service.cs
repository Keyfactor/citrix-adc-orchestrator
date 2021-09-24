// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.service.nitro_service
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.resource.Base;
using com.citrix.netscaler.nitro.resource.config.ha;
using com.citrix.netscaler.nitro.resource.config.ns;
using System.Collections;
using System.Reflection;

namespace com.citrix.netscaler.nitro.service
{
  public class nitro_service
  {
    private string user_name;
    private string password;
    private string ipaddress;
    private string version;
    private string sessionid;
    private string protocol;
    private bool warning;
    private ipayload_formatter format = (ipayload_formatter) null;
    private uint? timeout;
    private nitro_service.OnerrorEnum onerror;

    public ipayload_formatter get_payload_formatter() => this.format;

    public nitro_service(string ip)
      : this(ip, (ipayload_formatter) new Json(), "http")
    {
    }

    public nitro_service(string ip, string protocol)
      : this(ip, (ipayload_formatter) new Json(), protocol)
    {
    }

    public nitro_service(string ip, ipayload_formatter format)
      : this(ip, format, "http")
    {
    }

    public nitro_service(string ip, ipayload_formatter format, string protocol)
    {
      if (protocol == null || !protocol.ToLower().Equals("http") && !protocol.ToLower().Equals("https"))
        throw new nitro_exception("error: protocol value " + protocol + " is not supported");
      this.ipaddress = ip;
      this.version = "v1";
      this.protocol = protocol;
      this.format = format;
      if (this.format != null)
        return;
      this.format = (ipayload_formatter) new Json();
    }

    public void set_credential(string username, string password)
    {
      this.user_name = username;
      this.password = password;
    }

    public void set_timeout(uint? timeout) => this.timeout = timeout;

    public bool isLogin() => this.sessionid != null;

    public void set_warning(bool warning) => this.warning = warning;

    public bool get_warning() => this.warning;

    public string get_onerror() => this.onerror.ToString();

    public void set_onerror(nitro_service.OnerrorEnum val) => this.onerror = val;

    public string get_ipaddress() => this.ipaddress;

    public string get_version() => this.version;

    public string get_sessionid() => this.sessionid;

    public string get_protocol() => this.protocol;

    public void set_protocol(string protocol) => this.protocol = protocol != null && (protocol.ToLower().Equals("http") || protocol.ToLower().Equals("https")) ? protocol : throw new nitro_exception("error: protocol value " + protocol + " is not supported");

    public ipayload_formatter get_format() => this.format;

    public base_response login()
    {
      base_response baseResponse = new com.citrix.netscaler.nitro.resource.Base.login(this.user_name, this.password, this.timeout).perform_operation(this, (options) null);
      if (baseResponse.errorcode == 0 || baseResponse.errorcode == 1034)
        this.sessionid = baseResponse.sessionid;
      return baseResponse;
    }

    public base_response loginchallengeresponse(string response)
    {
      base_response baseResponse = new com.citrix.netscaler.nitro.resource.Base.loginchallengeresponse(response).perform_operation(this, (options) null);
      if (baseResponse.errorcode == 0)
        this.sessionid = baseResponse.sessionid;
      return baseResponse;
    }

    public void clear_session() => this.sessionid = (string) null;

    public base_response relogin()
    {
      this.sessionid = (string) null;
      return this.login();
    }

    public base_response login(string username, string password)
    {
      this.set_credential(username, password);
      return this.login();
    }

    public base_response login(string username, string password, uint? timeout)
    {
      this.set_credential(username, password);
      this.set_timeout(timeout);
      return this.login();
    }

    public base_response logout()
    {
      base_response baseResponse = new com.citrix.netscaler.nitro.resource.Base.logout().perform_operation(this, (options) null);
      this.sessionid = (string) null;
      this.user_name = (string) null;
      this.password = (string) null;
      return baseResponse;
    }

    public base_response reboot(bool warm) => new com.citrix.netscaler.nitro.resource.config.ns.reboot()
    {
      warm = new bool?(warm)
    }.perform_operation(this);

    public base_response forcehasync(bool force, string save)
    {
      hasync hasync = new hasync();
      hasync.force = new bool?(force);
      hasync.save = save;
      options option = new options();
      option.set_action(nameof (force));
      return hasync.perform_operation(this, option);
    }

    public base_response forcehafailover(bool force)
    {
      hafailover hafailover = new hafailover();
      hafailover.force = new bool?(force);
      options option = new options();
      option.set_action(nameof (force));
      return hafailover.perform_operation(this, option);
    }

    public base_response save_config()
    {
      nsconfig nsconfig = new nsconfig();
      options option = new options();
      option.set_action("save");
      return nsconfig.perform_operation(this, option);
    }

    public base_response restart_resource(base_resource resource)
    {
      options option = new options();
      option.set_action("restart");
      return resource.perform_operation(this, option);
    }

    public base_response clear_config() => this.clear_config(true, "basic");

    public base_response clear_config(bool force) => this.clear_config(force, "basic");

    public base_response clear_config(bool force, string level)
    {
      nsconfig nsconfig = new nsconfig();
      if (force)
        nsconfig.force = new bool?(true);
      nsconfig.level = level;
      options option = new options();
      option.set_action("clear");
      return nsconfig.perform_operation(this, option);
    }

    public string[] get_features()
    {
      PropertyInfo[] properties = typeof (nsfeature).GetProperties();
      ArrayList arrayList = new ArrayList();
      int length = 0;
      for (int index = 0; index < properties.Length; ++index)
      {
        if (properties[index].PropertyType.FullName.Contains("System.Boolean"))
        {
          arrayList.Add((object) properties[index].Name);
          ++length;
        }
      }
      string[] strArray = new string[length];
      return arrayList.ToArray(typeof (string)) as string[];
    }

    public string[] get_enabled_features()
    {
      ArrayList arrayList = new ArrayList();
      int length = 0;
      MethodInfo[] methods = typeof (nsfeature).GetMethods();
      nsfeature nsfeature = nsfeature.get(this);
      string str = "get_";
      for (int index = 0; index < methods.Length; ++index)
      {
        string name = methods[index].Name;
        if (name.StartsWith(str) && methods[index].ReturnType.FullName.Contains("System.Boolean") && !name.Equals("get_object_name"))
        {
          bool? nullable = (bool?) typeof (nsfeature).GetMethod(methods[index].Name).Invoke((object) nsfeature, (object[]) null);
          if ((!nullable.GetValueOrDefault() ? 0 : (nullable.HasValue ? 1 : 0)) != 0)
          {
            arrayList.Add((object) name.Substring(str.Length));
            ++length;
          }
        }
      }
      string[] strArray = new string[length];
      return arrayList.ToArray(typeof (string)) as string[];
    }

    public base_response enable_features(string[] features)
    {
      nsfeature nsfeature = new nsfeature();
      nsfeature.feature = features;
      options option = new options();
      option.set_action("enable");
      return nsfeature.perform_operation(this, option);
    }

    public base_response disable_features(string[] features)
    {
      nsfeature nsfeature = new nsfeature();
      nsfeature.feature = features;
      options option = new options();
      option.set_action("disable");
      return nsfeature.perform_operation(this, option);
    }

    public string[] get_modes()
    {
      PropertyInfo[] properties = typeof (nsmode).GetProperties();
      ArrayList arrayList = new ArrayList();
      int length = 0;
      for (int index = 0; index < properties.Length; ++index)
      {
        if (properties[index].PropertyType.FullName.Contains("System.Boolean"))
        {
          arrayList.Add((object) properties[index].Name);
          ++length;
        }
      }
      string[] strArray = new string[length];
      return arrayList.ToArray(typeof (string)) as string[];
    }

    public string[] get_enabled_modes()
    {
      ArrayList arrayList = new ArrayList();
      int length = 0;
      MethodInfo[] methods = typeof (nsmode).GetMethods();
      nsmode nsmode = nsmode.get(this);
      string str = "get_";
      for (int index = 0; index < methods.Length; ++index)
      {
        string name = methods[index].Name;
        if (name.StartsWith(str) && methods[index].ReturnType.FullName.Contains("System.Boolean") && !name.Equals("get_object_name"))
        {
          bool? nullable = (bool?) typeof (nsmode).GetMethod(methods[index].Name).Invoke((object) nsmode, (object[]) null);
          if ((!nullable.GetValueOrDefault() ? 0 : (nullable.HasValue ? 1 : 0)) != 0)
          {
            arrayList.Add((object) name.Substring(str.Length));
            ++length;
          }
        }
      }
      string[] strArray = new string[length];
      return arrayList.ToArray(typeof (string)) as string[];
    }

    public base_response enable_modes(string[] modes)
    {
      nsmode nsmode = new nsmode();
      nsmode.mode = modes;
      options option = new options();
      option.set_action("enable");
      return nsmode.perform_operation(this, option);
    }

    public base_response disable_modes(string[] modes)
    {
      nsmode nsmode = new nsmode();
      nsmode.mode = modes;
      options option = new options();
      option.set_action("disable");
      return nsmode.perform_operation(this, option);
    }

    public enum OnerrorEnum
    {
      EXIT,
      CONTINUE,
      ROLLBACK,
    }
  }
}
