**Netscaler Cert Store Type Setup**

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

**Netscaler Cert Store Setup**

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

## Test Cases

Case Number|Case Name|Enrollment Params|Expected Results|Passed|Screenshot
----|------------------------|------------------------------------|--------------|----------------|-------------------------
1	|Add Unbound Cert|**Alias:** TC1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Adds New Unbound Cert To Citrix ADC|True|![](Images/TC1.gif)
2	|Remove Unbound Cert|**Alias:** TC1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:** false|Removes Unbound Cert From Citrix ADC|True|![](Images/TC2.gif)
3	|Add Unbound Cert|**Alias:** TC3.boingy.com<br/>**Virtual Server Name:** TestVServer<br/>**Sni Cert:** false|Adds a new bound cert to TestVServer Virtual Server|True|![](Images/TC3.gif)
4	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
5	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
6	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
7	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
8	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
9	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
10	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
11	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
12	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)
13	|Add Unbound Cert|**Alias:** TCN1.boingy.com<br/>**Virtual Server Name:**<br/>**Sni Cert:**false|Adds New Unbound Cert To Citrix|True|![](images/TC1.gif)