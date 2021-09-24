// Decompiled with JetBrains decompiler
// Type: com.citrix.netscaler.nitro.resource.Base.base_resource
// Assembly: nitro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CF5DDEF-E052-4F9D-953F-6644F8378A66


using com.citrix.netscaler.nitro.exception;
using com.citrix.netscaler.nitro.service;
using com.citrix.netscaler.nitro.util;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Web;

namespace com.citrix.netscaler.nitro.resource.Base
{
  public abstract class base_resource
  {
    internal abstract base_resource[] get_nitro_response(
      nitro_service service,
      string str);

    internal abstract string get_object_name();

    internal string get_object_type()
    {
      string str = this.GetType().ToString();
      int num = str.LastIndexOf(".");
      if (num > 0)
        str = str.Substring(num + 1);
      if (str.LastIndexOf("_stats") > 0)
        str = str.Substring(0, str.Length - 6);
      return str;
    }

    internal string resource_to_string(nitro_service service, string id, options option)
    {
      bool warning = service.get_warning();
      string onerror = service.get_onerror();
      return service.get_payload_formatter().resource_to_string(this, id, option, warning, onerror);
    }

    internal string resource_to_string(nitro_service service) => service.get_payload_formatter().resource_to_string(this);

    internal string resource_to_string_put(nitro_service service, string id, options option)
    {
      bool warning = service.get_warning();
      string onerror = service.get_onerror();
      return service.get_payload_formatter().resource_to_string_put(this, id, option, warning, onerror);
    }

    internal base_response delete_resource(nitro_service client)
    {
      if (!client.isLogin() && !this.get_object_type().Equals("login"))
        client.login();
      string stringWithoutquotes = nitro_util.object_to_string_withoutquotes((object) this);
      return this.delete_request(client, stringWithoutquotes);
    }

    internal void rename_name(string newname) => throw new nitro_exception("Rename is not supported for this resource", -1);

    internal base_response rename_resource(nitro_service client)
    {
      if (!client.isLogin() && !this.get_object_type().Equals("login"))
        client.login();
      options option = new options();
      option.set_action("rename");
      return this.post_request(client, option);
    }

    internal base_response unset_resource(nitro_service service, string[] args)
    {
      if (!service.isLogin() && !this.get_object_type().Equals("login"))
        service.login();
      options option = new options();
      option.set_action("unset");
      return this.unset_request(service, option, args);
    }

    private base_response unset_request(
      nitro_service service,
      options option,
      string[] args)
    {
      string sessionid = service.get_sessionid();
      string request = this.unset_string(service, sessionid, option, args);
      return base_resource.post_data(service, request);
    }

    internal string unset_string(nitro_service service, string id, options option, string[] args)
    {
      bool warning = service.get_warning();
      return service.get_payload_formatter().unset_string(this, id, option, args, warning);
    }

    internal static base_responses unset_bulk_request(
      nitro_service client,
      base_resource[] resources,
      string[] args)
    {
      if (!client.isLogin())
        client.login();
      options option = new options();
      option.set_action("unset");
      string onerror = client.get_onerror();
      bool warning = client.get_warning();
      string sessionid = client.get_sessionid();
      string request = client.get_payload_formatter().unset_string(resources, sessionid, option, args, warning, onerror);
      return base_resource.post_bulk_data(client, request);
    }

    internal static base_responses update_bulk_request(
      nitro_service service,
      base_resource[] resources)
    {
      if (!service.isLogin())
        service.login();
      string sessionid = service.get_sessionid();
      bool warning = service.get_warning();
      string onerror = service.get_onerror();
      string stringPut = service.get_payload_formatter().resource_to_string_put(resources, sessionid, (options) null, warning, onerror);
      return base_resource.put_bulk_data(service, stringPut);
    }

    public base_response perform_operation(nitro_service service) => this.perform_operation(service, (options) null);

    public base_response perform_operation(nitro_service service, options option)
    {
      if (!service.isLogin() && !this.get_object_type().Equals("login"))
        service.login();
      return this.post_request(service, option);
    }

    public base_response perform_operation_byaction(
      nitro_service service,
      string action)
    {
      if (!service.isLogin() && !this.get_object_type().Equals("login"))
        service.login();
      options option = new options();
      option.set_action(action);
      return this.post_request(service, option);
    }

    public base_resource perform_operation_byactionEx(
      nitro_service service,
      string action)
    {
      if (!service.isLogin() && !this.get_object_type().Equals("login"))
        service.login();
      options option = new options();
      option.set_action(action);
      return this.post_requestEx(service, option);
    }

    internal static base_responses perform_operation_bulk_request(
      nitro_service service,
      base_resource[] resources,
      string action)
    {
      if (!service.isLogin())
        service.login();
      options option = new options();
      option.set_action(action);
      string onerror = service.get_onerror();
      bool warning = service.get_warning();
      string sessionid = service.get_sessionid();
      string request = service.get_payload_formatter().resource_to_string(resources, sessionid, option, warning, onerror);
      return base_resource.post_bulk_data(service, request);
    }

    private base_response post_request(nitro_service service, options option)
    {
      string sessionid = service.get_sessionid();
      string request = this.resource_to_string(service, sessionid, option);
      return base_resource.post_data(service, request);
    }

    private base_resource post_requestEx(nitro_service service, options option)
    {
      string sessionid = service.get_sessionid();
      string request = this.resource_to_string(service, sessionid, option);
      return this.post_dataEx(service, request);
    }

    internal base_resource[] getfiltered(nitro_service client, options option)
    {
      if (!client.isLogin())
        client.login();
      return this.get_request(client, option);
    }

    internal base_resource[] stat_resources(nitro_service client, options option)
    {
      if (!client.isLogin())
        client.login();
      return this.stat_request(client, option);
    }

    internal base_resource[] stat_resources(nitro_service client) => this.stat_resources(client, (options) null);

    internal base_resource stat_resource(nitro_service client, options option)
    {
      if (!client.isLogin())
        client.login();
      base_resource[] baseResourceArray = this.stat_request(client, option);
      return baseResourceArray != null && baseResourceArray.Length > 0 ? baseResourceArray[0] : (base_resource) null;
    }

    internal base_resource stat_resource(nitro_service client) => this.stat_resource(client, (options) null);

    internal base_resource[] get_resources(nitro_service client, options option)
    {
      if (!client.isLogin())
        client.login();
      return this.get_request(client, option);
    }

    internal base_resource get_resource(nitro_service client, options option)
    {
      if (!client.isLogin())
        client.login();
      base_resource[] request = this.get_request(client, option);
      return request != null && request.Length > 0 ? request[0] : (base_resource) null;
    }

    internal base_resource get_resource(nitro_service service) => this.get_resource(service, (options) null);

    internal static base_responses add_bulk_request(
      nitro_service client,
      base_resource[] resources)
    {
      if (!client.isLogin())
        client.login();
      string sessionid = client.get_sessionid();
      string onerror = client.get_onerror();
      bool warning = client.get_warning();
      string request = client.get_payload_formatter().resource_to_string(resources, sessionid, (options) null, warning, onerror);
      return base_resource.post_bulk_data(client, request);
    }

    internal static base_responses delete_bulk_request(
      nitro_service client,
      base_resource[] resources)
    {
      if (!client.isLogin())
        client.login();
      options option = new options();
      option.set_action("rm");
      if (resources[0].get_object_type().IndexOf("_binding") > 0)
        option.set_action("unbind");
      string sessionid = client.get_sessionid();
      string onerror = client.get_onerror();
      bool warning = client.get_warning();
      string request = client.get_payload_formatter().resource_to_string(resources, sessionid, option, warning, onerror);
      return base_resource.post_bulk_data(client, request);
    }

    internal base_response add_resource(nitro_service service, options option)
    {
      if (!service.isLogin() && !this.get_object_type().Equals("login"))
        service.login();
      string sessionid = service.get_sessionid();
      string request = this.resource_to_string(service, sessionid, option);
      return base_resource.post_data(service, request);
    }

    internal base_response add_resource(nitro_service service) => this.add_resource(service, (options) null);

    internal base_response update_resource(nitro_service service, options option)
    {
      if (!service.isLogin() && !this.get_object_type().Equals("login"))
        service.login();
      string sessionid = service.get_sessionid();
      string stringPut = this.resource_to_string_put(service, sessionid, option);
      return base_resource.put_data(service, stringPut);
    }

    internal base_response update_resource(nitro_service service) => this.update_resource(service, (options) null);

    private static string _post(nitro_service service, string request)
    {
      string str1 = "";
      string ipaddress = service.get_ipaddress();
      string version = service.get_version();
      service.get_sessionid();
      string requestUriString = service.get_protocol() + "://" + ipaddress + "/nitro/" + version + "/config/";
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUriString);
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        request = HttpUtility.UrlEncode(request);
        string str2 = "object=" + request;
        httpWebRequest.ContentLength = (long) str2.Length;
        httpWebRequest.Method = "POST";
        ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((sender, cert, chain, sslPolicyErrors) => true);
        StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
        streamWriter.Write(str2);
        streamWriter.Flush();
        streamWriter.Close();
        StreamReader streamReader;
        try
        {
          streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
        }
        catch (WebException ex)
        {
          streamReader = new StreamReader(ex.Response.GetResponseStream());
        }
        string str3;
        while ((str3 = streamReader.ReadLine()) != null)
          str1 += str3;
        streamReader.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return str1;
    }

    private static base_response post_data(nitro_service service, string request)
    {
      string response = base_resource._post(service, request);
      base_response baseResponse = new base_response();
      base_response resource = (base_response) service.get_payload_formatter().string_to_resource(baseResponse.GetType(), response);
      if (resource.errorcode != 0 && resource.errorcode != 1034)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return resource;
    }

    private base_resource post_dataEx(nitro_service service, string request)
    {
      string str = base_resource._post(service, request);
      return this.get_nitro_response(service, str)[0];
    }

    private static base_responses post_bulk_data(
      nitro_service service,
      string request)
    {
      string response = base_resource._post(service, request);
      base_responses baseResponses = new base_responses();
      base_responses resource = (base_responses) service.get_payload_formatter().string_to_resource(baseResponses.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          service.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return resource;
    }

    private base_resource[] get_request(nitro_service client, options option)
    {
      string str1 = "";
      string ipaddress = client.get_ipaddress();
      string version = client.get_version();
      string sessionid = client.get_sessionid();
      string objectType = this.get_object_type();
      string str2 = client.get_protocol() + "://" + ipaddress + "/nitro/" + version + "/config/" + objectType;
      string objectName = this.get_object_name();
      if (objectName != null && objectName.Length > 0)
        str2 = str2 + "/" + HttpUtility.UrlEncode(HttpUtility.UrlEncode(objectName));
      if (option != null || client.get_warning())
      {
        string str3 = (string) null;
        if (option != null)
        {
          str3 = option.to_string();
          if (str3.Length > 0)
            str2 = str2 + "?" + str3;
        }
        if (client.get_warning())
          str2 = (option == null || str3.Length <= 0 ? str2 + "?" : str2 + "&") + "warning=yes";
      }
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(str2);
        httpWebRequest.CookieContainer = new CookieContainer();
        httpWebRequest.Method = "GET";
        ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((sender, cert, chain, sslPolicyErrors) => true);
        Uri uri = new Uri(str2);
        httpWebRequest.CookieContainer.SetCookies(uri, "sessionid=" + HttpUtility.UrlEncode(sessionid));
        StreamReader streamReader;
        try
        {
          streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
        }
        catch (WebException ex)
        {
          streamReader = new StreamReader(ex.Response.GetResponseStream());
        }
        string str4;
        while ((str4 = streamReader.ReadLine()) != null)
          str1 += str4;
        streamReader.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return this.get_nitro_response(client, str1);
    }

    private base_resource[] stat_request(nitro_service client, options option)
    {
      string str1 = "";
      string ipaddress = client.get_ipaddress();
      string version = client.get_version();
      string sessionid = client.get_sessionid();
      string objectType = this.get_object_type();
      string str2 = client.get_protocol() + "://" + ipaddress + "/nitro/" + version + "/stat/" + objectType;
      string objectName = this.get_object_name();
      if (objectName != null && objectName.Length > 0)
        str2 = str2 + "/" + HttpUtility.UrlEncode(HttpUtility.UrlEncode(objectName));
      if (option != null || client.get_warning())
      {
        string str3 = (string) null;
        if (option != null)
        {
          str3 = option.to_string();
          if (str3.Length > 0)
            str2 = str2 + "?" + str3;
        }
        if (client.get_warning())
          str2 = (option == null || str3.Length <= 0 ? str2 + "?" : str2 + "&") + "warning=yes";
      }
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(str2);
        httpWebRequest.CookieContainer = new CookieContainer();
        httpWebRequest.Method = "GET";
        ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((sender, cert, chain, sslPolicyErrors) => true);
        Uri uri = new Uri(str2);
        httpWebRequest.CookieContainer.SetCookies(uri, "sessionid=" + HttpUtility.UrlEncode(sessionid));
        StreamReader streamReader;
        try
        {
          streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
        }
        catch (WebException ex)
        {
          streamReader = new StreamReader(ex.Response.GetResponseStream());
        }
        string str4;
        while ((str4 = streamReader.ReadLine()) != null)
          str1 += str4;
        streamReader.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return this.get_nitro_response(client, str1);
    }

    private static string _put(nitro_service client, string request)
    {
      string str1 = "";
      string ipaddress = client.get_ipaddress();
      string version = client.get_version();
      client.get_sessionid();
      string requestUriString = client.get_protocol() + "://" + ipaddress + "/nitro/" + version + "/config/";
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(requestUriString);
        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        httpWebRequest.ContentLength = (long) request.Length;
        httpWebRequest.Method = "PUT";
        ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((sender, cert, chain, sslPolicyErrors) => true);
        StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
        streamWriter.Write(request);
        streamWriter.Flush();
        streamWriter.Close();
        StreamReader streamReader;
        try
        {
          streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
        }
        catch (WebException ex)
        {
          streamReader = new StreamReader(ex.Response.GetResponseStream());
        }
        string str2;
        while ((str2 = streamReader.ReadLine()) != null)
          str1 += str2;
        streamReader.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return str1;
    }

    private static base_response put_data(nitro_service client, string request)
    {
      string response = base_resource._put(client, request);
      base_response baseResponse = new base_response();
      base_response resource = (base_response) client.get_payload_formatter().string_to_resource(baseResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          client.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return resource;
    }

    private static base_responses put_bulk_data(nitro_service client, string request)
    {
      string response = base_resource._put(client, request);
      base_responses baseResponses = new base_responses();
      base_responses resource = (base_responses) client.get_payload_formatter().string_to_resource(baseResponses.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          client.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return resource;
    }

    private base_response delete_request(nitro_service client, string req_args)
    {
      string response = "";
      string ipaddress = client.get_ipaddress();
      string version = client.get_version();
      string sessionid = client.get_sessionid();
      string objectType = this.get_object_type();
      string str1 = client.get_protocol() + "://" + ipaddress + "/nitro/" + version + "/config/" + objectType;
      string objectName = this.get_object_name();
      if (objectName != null && objectName.Length > 0)
        str1 = str1 + "/" + HttpUtility.UrlEncode(HttpUtility.UrlEncode(objectName));
      if (req_args != null || client.get_warning())
      {
        str1 += "?";
        if (req_args != null)
          str1 = str1 + "args=" + req_args;
        if (client.get_warning())
        {
          if (req_args != null)
            str1 += "&";
          str1 += "warning=yes";
        }
      }
      try
      {
        HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(str1);
        httpWebRequest.CookieContainer = new CookieContainer();
        httpWebRequest.Method = "DELETE";
        ServicePointManager.ServerCertificateValidationCallback += (RemoteCertificateValidationCallback) ((sender, cert, chain, sslPolicyErrors) => true);
        Uri uri = new Uri(str1);
        httpWebRequest.CookieContainer.SetCookies(uri, "sessionid=" + HttpUtility.UrlEncode(sessionid));
        StreamReader streamReader;
        try
        {
          streamReader = new StreamReader(httpWebRequest.GetResponse().GetResponseStream());
        }
        catch (WebException ex)
        {
          streamReader = new StreamReader(ex.Response.GetResponseStream());
        }
        string str2;
        while ((str2 = streamReader.ReadLine()) != null)
          response += str2;
        streamReader.Close();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      base_response baseResponse = new base_response();
      base_response resource = (base_response) client.get_payload_formatter().string_to_resource(baseResponse.GetType(), response);
      if (resource.errorcode != 0)
      {
        if (resource.errorcode == 444)
          client.clear_session();
        if (resource.severity == null)
          throw new nitro_exception(resource.message, resource.errorcode);
        if (resource.severity.Equals("ERROR"))
          throw new nitro_exception(resource.message, resource.errorcode);
      }
      return resource;
    }
  }
}
