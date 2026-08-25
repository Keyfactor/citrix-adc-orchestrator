## Overview

The Citrix ADC Orchestrator remotely manages certificate objects on a Citrix ADC device.  Since the ADC supports services including: 
Load Balancing, Authentication/Authorization/Auditing (AAA), and Gateways, this orchestrator can bind to any of these virtual servers when using unique virtual server names for each service.

## Requirements

The Citrix ADC user needs permission to perform the following API calls:

API Endpoint|Methods
---|---
/nitro/v1/config/login|post
/nitro/v1/config/lbvserver| get
/nitro/v1/config/sslcertkey| get, update, add, delete
/nitro/v1/config/sslcertkey_service_binding| get, update, add, delete
/nitro/v1/config/sslcertreq| add
/nitro/v1/config/sslrsakey| add
/nitro/v1/config/sslecdsakey| add
/nitro/v1/config/systemfile| get, add, delete

Here is a sample policy with Min Permissions:
* Action: 
Allow
* Command Spec: 
(^stat\s+(cr|cs|lb|system|vpn))|(^(add|rm|show)\s+system\s+file\s+.*)|(^\S+\s+ssl\s+.*)|(^(show|stat|sync)\s+HA\s+.*)|(^save\s+ns\s+config)|(^(switch|show)\s+ns\s+partition.*)

## Post Installation

An optional config.json configuration file has been provided in the extensions folder with a single setting - AutoSaveConfig.  Setting this value to "Y" means successful changes made by a management job will automatically be saved to disk; no interaction with the Citrix ADC UI is necessary.  Setting this value to "N" (or if the config entry or config file is missing) will keep these changes in memory only.

**NOTE:** Any changes in-process through the Citrix ADC UI will also be persisted to disk when a management job is performed and the AutoSaveConfig flag is set to 'Y'. 

## Notes and Limitations

* As of release 2.2.0, ONLY certificate objects (installed certificates) will be managed by the Citrix ADC Orchestrator Extension.  Prior versions also managed certificate/key file combinations uploaded to the Citrix ADC device but not yet installed.  This functionality has been removed due to issues attempting to match certificate and key files due to inconsistent file naming.

* Direct PFX Binding Inventory: In NetScaler you can directly Bind a Pfx file to a Virtual Server.  Keyfactor cannot inventory these because it does not have access to the password.  The recommended way to Import PFX Files in NetScaler is descibed in this [NetScaler Documentation](https://docs.netscaler.com/en-us/citrix-adc/12-1/ssl/ssl-certificates/export-existing-certs-keys.html#convert-ssl-certificates-for-import-or-export)

* Removing Certs from Store: Certificates that are bound to a server will not be removed.  This was done to limit the possibility of bringing production servers down.  Users are currently required to manually unbind the certificate from the server first and then remove via the Command and this orchestrator extension.

* Reenrollment (On-Device Key Generation/ODKG): Reenrollment always generates a brand new key pair and CSR directly on the Citrix ADC appliance, and the private key never leaves the appliance. If the target alias already exists, Overwrite must be set to True; the new key and certificate then replace the existing key and certificate for that alias in place, so any existing virtual server bindings are preserved automatically. The previous key and certificate files remain on the appliance's filesystem and are not automatically deleted. Both RSA and ECC keys are supported; for ECC, only 256 and 384-bit curves (P_256, P_384) are supported by the Citrix ADC appliance for on-device key generation. When reenrolling a new alias (one that does not already exist), the virtualServerName and sniCert Entry Parameters can be used to bind the new certificate the same way they are used for Management-Add; they are ignored when reenrolling an existing alias since its bindings are unaffected.
