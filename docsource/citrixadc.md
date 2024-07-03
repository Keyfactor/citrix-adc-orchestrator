## Overview

The CitrixAdc Certificate Store Type is designed to manage and handle certificates on Citrix ADC (formerly NetScaler) devices. This Certificate Store Type enables Keyfactor Command to remotely add, remove, and inventory certificates on the Citrix ADC, supporting critical services such as Load Balancing, Authentication/Authorization/Auditing (AAA), and Gateways.

The CitrixAdc Certificate Store Type represents specific locations on the Citrix ADC device where certificates are stored, such as paths on the appliance or configurations linked to virtual servers. These stores are essential for maintaining secure communications and proper certificate management.

However, there are some caveats and limitations associated with this Certificate Store Type. For instance, direct PFX file binding inventory is not supported because Keyfactor cannot access the password for these files. Users must import PFX files following Citrix guidelines. Moreover, downtime may occur when replacing certificates, albeit for a brief moment, due to the Citrix-recommended method for cert replacement.

Another consideration is the removal of certificates. Certificates that are bound to a server will not be automatically removed to prevent potential disruptions in production environments. Users are required to manually unbind certificates before removal. Additionally, renewal processes will update all instances of a certificate across VServers.

The CitrixAdc Certificate Store Type does not utilize an SDK. Instead, it leverages direct interactions with the Citrix ADC API to perform its functions. Users should also be aware of configuration specifications, such as using a comma-separated list of values when binding to multiple VServers and handling SNI certificates.

Overall, while the CitrixAdc Certificate Store Type provides robust capabilities for managing certificates on Citrix ADC devices, users should be aware of these limitations and best practices to ensure effective and smooth operations.

## Requirements

### Step-by-Step Configuration

#### 1. Citrix Netscaler Configuration
- Ensure your Citrix Netscaler device is properly set up and accessible.
- The NetScaler user must have permissions to perform specific API calls as follows:

API Endpoint | Methods
--- | ---
/nitro/v1/config/login | post
/nitro/v1/config/lbvserver | get
/nitro/v1/config/sslcertkey | get, update, add, delete
/nitro/v1/config/sslcertkey_service_binding | get, update, add, delete
/nitro/v1/config/systemfile | get, add, delete

For instance, set the permissions for the NetScaler user as follows:

- **Action:** Allow
- **Command Spec:**
  ```
  (^stat\s+(cr|cs|lb|system|vpn))|(^(add|rm|show)\s+system\s+file\s+.*)|(^\S+\s+ssl\s+.*)|(^(show|stat|sync)\s+HA\s+.*)|(^save\s+ns\s+config)|(^(switch|show)\s+ns\s+partition.*)
  ````

#### 2. Service Account Creation
- Create a service account on the Citrix Netscaler device with the permissions specified above.

#### 3. Version Requirements
- Ensure you are running a compatible version of Citrix ADC that supports the necessary API endpoints and functionalities required by the CitrixAdc Certificate Store Type.

### Additional Notes

- **Direct PFX Binding Inventory:** Keyfactor cannot inventory directly bound PFX files on Netscaler because it does not have access to the password. Refer to [NetScaler Documentation](https://docs.netscaler.com/en-us/citrix-adc/12-1/ssl/ssl-certificates/export-existing-certs-keys.html#convert-ssl-certificates-for-import-or-export) for guidance on how to import PFX files.
- **Replacing Certificates:** The orchestrator replaces bound certificates following [NetScaler recommended methods](https://docs.netscaler.com/en-us/citrix-adc/12-1/ssl/ssl-certificates/add-group-certs.html), causing a sub-second blip of downtime.
- **Removing Certificates:** Certificates bound to a virtual server will not be removed automatically. You need to unbind the certificate manually before removal.
- **Renewals:** Renewal processes update the certificate's thumbprint across all virtual servers where it is used.

