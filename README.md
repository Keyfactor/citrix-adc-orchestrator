# Citrix Netscaler Universal Orchestrator

Orchestrator to manage certificates and keys on one to many VServers in Netscaler.  The integration supports Enrollment, Renewal, Inventory and Remove from Store.

#### Integration status: Production - Ready for use in production environments.

## About the Keyfactor Universal Orchestrator Extension

This repository contains a Universal Orchestrator Extension which is a plugin to the Keyfactor Universal Orchestrator. Within the Keyfactor Platform, Orchestrators are used to manage “certificate stores” &mdash; collections of certificates and roots of trust that are found within and used by various applications.

The Universal Orchestrator is part of the Keyfactor software distribution and is available via the Keyfactor customer portal. For general instructions on installing Extensions, see the “Keyfactor Command Orchestrator Installation and Configuration Guide” section of the Keyfactor documentation. For configuration details of this specific Extension see below in this readme.

The Universal Orchestrator is the successor to the Windows Orchestrator. This Orchestrator Extension plugin only works with the Universal Orchestrator and does not work with the Windows Orchestrator.



## Support for Citrix Netscaler Universal Orchestrator

Citrix Netscaler Universal Orchestrator is supported by Keyfactor for Keyfactor customers. If you have a support issue, please open a support ticket with your Keyfactor representative.

###### To report a problem or suggest a new feature, use the **[Issues](../../issues)** tab. If you want to contribute actual bug fixes or proposed enhancements, use the **[Pull requests](../../pulls)** tab.
___



---




---


<details>
  <summary>Cert Store Type Settings</summary>
<br />

![](Images/CertStoreTypeSettings.gif)

**Basic Settings:**

CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Name	|A descriptive name for the extension.  Example:  CitrixAdc
Short Name	|The short name that identifies the registered functionality of the orchestrator. Must be CitrixAdc.
Custom Capability|Store type name orchestrator will register with. Uncheck This
Job Types	|Inventory (Checked), check the additional checkboxes: Add, Remove
General Settings|Needs Server - Checked<br>Blueprint Allowed - Unchecked<br>Uses PowerShell - Unchecked
Requires Store Password	|Determines if a store password is required when configuring an individual store.  This must be unchecked.
Supports Entry Password	|Determined if an individual entry within a store can have a password.  This must be unchecked.

**Advanced Settings:**

CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Store Path Type	|Determines what restrictions are applied to the store path field when configuring a new store.  Select Freeform
Supports Custom Alias	|Determines if an individual entry within a store can have a custom Alias.  This must be Required.
Private Keys	|This determines if Keyfactor can send the private key associated with a certificate to the store.  This is required since Citrix ADC will need the private key material to establish TLS connections.
PFX Password Style	|This determines how the platform generate passwords to protect a PFX enrollment job that is delivered to the store.  This can be either Default (system generated) or Custom (user determined).

**Custom Fields:**

Parameter Name|Display Name|Parameter Type|Default Value|Required|Description
---|---|---|---|---|---
ServerUsername|Server Username|Secret||No|The username to log into the Server
ServerPassword|Server Password|Secret||No|The password that matches the username to log into the Server
ServerUseSsl|Use SSL|Bool|True|Yes|Determine whether the server uses SSL or not

**Custom Fields:**

Parameter Name|Display Name|Parameter Type|Default Value|Required When
---|---|---|---|---
virtualServerName|Virtual Server Name|String| |Leave All Unchecked
sniCert|SNI Cert|String|false|Adding Entry


#### STORE TYPE ENTRY PARAMS
CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Virtual Server	| When Enrolling, this can be a single or comma separated list of VServers in Netscaler to replace.
Key Pair| When Enrolling, this is the name of the Certificate that will be installed on Netscaler

</details>

**Netscaler Cert Store Setup**

![](Images/CertStoreTypeSettings.gif)

#### STORE CONFIG
CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Client Machine	| This is the IP Address of the Netscaler Appliance.
Store Path| This is the path of the Netscaler Appliance.  /nsconfig/ssl/.
User| This is the user that will be authenticated against the Netscaler Appliance
Password| This is the password that will be authenticated against the Netscaler Appliance
Use SSL| This should be set to True in Production when there is a valid certificate.
Inventory Schedule| Set this for the appropriate inventory interval needed.


**Netscaler permissions needed**

The Netscaler user needs permission to perform the following API calls:

API Endpoint|Methods
---|---
/nitro/v1/config/login|post
/nitro/v1/config/lbvserver| get
/nitro/v1/config/sslcertkey| get, update, add, delete
/nitro/v1/config/sslcertkey_service_binding| get, update, add, delete
/nitro/v1/config/systemfile| get, add, delete

**Integration Limitations**

#### Limitation List

* Direct PFX Binding Inventory
	* In Netscaler you can directly Bind a Pfx file to a Virtual Server.  Keyfactor cannot inventory these because it does not have access to the password.  The recommended way to Import PFX Files in Netscaler is descibed in this [Netscaler Documentation](https://docs.netscaler.com/en-us/citrix-adc/12-1/ssl/ssl-certificates/export-existing-certs-keys.html#convert-ssl-certificates-for-import-or-export)


## Test Cases

Case Number|Case Name|Enrollment Params|Expected Results|Passed|Screenshot
----|------------------------|------------------------------------|--------------|----------------|-------------------------
1	|Add Unbound Cert|**Alias:** TC1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Adds New Unbound Cert To Citrix ADC|True|![](Images/TC1.gif)
2	|Remove Unbound Cert|**Alias:** TC1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Removes Unbound Cert From Citrix ADC|True|![](Images/TC2.gif)
3	|Add Bound Cert|**Alias:** TC3.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** false|Adds a new bound cert to TestVServer Virtual Server|True|![](Images/TC3.gif)
4	|Add Bound Cert Multiple VServers|**Alias:** TC4.boingy.com<br/>**Virtual Server Name:** TestVServer,TestVServer2<br/>**Sni Cert:** false,false|Adds New Bound Cert To Both Servers in Citrix|True|![](Images/TC4.gif)
5	|Remove Bound Cert|**Alias:** TC4.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will Not Remove because it is bound.  Must Unbind it First|True|![](Images/TC5.gif)
6	|Renew Bound Cert|**Alias:** TC4.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Renews Bound Cert on Both VServers|True|![](Images/TC6.gif)
7	|Replace Bound Cert No Overwrite |**Alias:** TC4.boingy.com<br/>**Virtual Server Name:** TestVServer,TestVServer2<br/>**Sni Cert:** false,false|Will Not replace, overwrite flag needed|True|![](Images/TC7.gif)
8	|Replace Bound Cert with Overwrite|**Alias:** 16934<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will do the replace because overwrite was used|True|![](Images/TC8.gif)
9	|Add Sni Cert and Bind|**Alias:** TC9.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** false|Will bind an additional SNI Cert to a VServer|True|![](Images/TC9.gif)
10	|Renew bound Sni Cert|**Alias:** TC10.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will Renew the Sni Cert Bound to the Site|True|![](Images/TC10.gif)
11	|Replace bound Sni Cert with Overwrite|**Alias:** TC9.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** true|Sni Cert Will Be Replaced and bound|True|![](Images/TC11.gif)
12	|Remove Bound Sni Cert|**Alias:** TC9.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Will Not Remove because it is bound.  Must Unbind it First|True|![](Images/TC12.gif)
13	|Add Sni Cert To Multiple VServers and bind|**Alias:** TC13.boingy.com<br/>**Virtual Server Name:** TestVServer,TestVServer2<br/>**Sni Cert:** false,true|Adds and binds Cert to TestVServer and adds and binds Sni Cert to TestVServer2|True|![](Images/TC13.gif)

