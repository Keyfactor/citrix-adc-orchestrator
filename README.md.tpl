# {{ name }}
## {{ integration_type | capitalize }}

{{ description }}

<!-- add integration specific information below -->
*** 
**Netscaler Cert Store Type Setup**

*1. Cert Store Type Basic Settings*

![](Images/CertStoreType-Basic.gif)

*2. Cert Store Type Advanced Settings*
![](Images/CertStoreType-Advanced.gif)

*3. Cert Store Type Custom Fields*
![](Images/CertStoreType-CustomFields.gif)

*4. Cert Store Type Entry Params - Virtual Server*
![](Images/CertStoreType-VServerEntry.gif)

*5. Cert Store Type Entry Params - KPEntry*
![](Images/CertStoreType-KPEntry.gif)

#### STORE TYPE ENTRY PARAMS
CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Virtual Server	| When Enrolling, this can be a single or comma separated list of VServers in Netscaler to replace.
Key Pair| When Enrolling, this is the name of the Certificate that will be installed on Netscaler

**Netscaler Cert Store Setup**

*1. Cert Store Base Settings*
![](Images/CertStore-Base.gif)

*1. Cert Store Credential Setup*
![](Images/CertStore-Credentials.gif)

#### STORE CONFIG
CONFIG ELEMENT	| DESCRIPTION
------------------|------------------
Client Machine	| This is the IP Address of the Netscaler Appliance.
Store Path| This is the path of the Netscaler Appliance.  The value shown in the screenshot is the default path.
User| This is the user that will be authenticated against the Netscaler Appliance
Password| This is the password that will be authenticated against the Netscaler Appliance