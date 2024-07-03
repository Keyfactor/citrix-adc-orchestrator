<h1 align="center" style="border-bottom: none">
    Citrix Netscaler Universal Orchestrator Extension
</h1>

<p align="center">
  <!-- Badges -->
<img src="https://img.shields.io/badge/integration_status-production-3D1973?style=flat-square" alt="Integration Status: production" />
<a href="https://github.com/Keyfactor/citrix-adc-orchestrator/releases"><img src="https://img.shields.io/github/v/release/Keyfactor/citrix-adc-orchestrator?style=flat-square" alt="Release" /></a>
<img src="https://img.shields.io/github/issues/Keyfactor/citrix-adc-orchestrator?style=flat-square" alt="Issues" />
<img src="https://img.shields.io/github/downloads/Keyfactor/citrix-adc-orchestrator/total?style=flat-square&label=downloads&color=28B905" alt="GitHub Downloads (all assets, all releases)" />
</p>

<p align="center">
  <!-- TOC -->
  <a href="#support">
    <b>Support</b>
  </a>
  ·
  <a href="#installation">
    <b>Installation</b>
  </a>
  ·
  <a href="#license">
    <b>License</b>
  </a>
  ·
  <a href="https://github.com/orgs/Keyfactor/repositories?q=orchestrator">
    <b>Related Integrations</b>
  </a>
</p>


## Overview

The Citrix Netscaler Universal Orchestrator extension remotely manages certificates on Citrix Netscaler devices. Citrix Netscaler supports services including Load Balancing, Authentication/Authorization/Auditing (AAA), and Gateways, enabling binding to any of these virtual servers using unique virtual server names for each service.

Certificates are essential for securing communications and establishing trust within Citrix Netscaler. They ensure the integrity and confidentiality of data transmitted between clients and servers.

Defined Certificate Stores within the context of this orchestrator represent locations on the Citrix Netscaler device where certificates are stored, such as file paths or configurations tied to virtual servers. These Certificate Stores facilitate the management tasks, including inventory, addition, and removal of certificates, enhancing the security and manageability of the Citrix Netscaler environment.

## Compatibility

This integration is compatible with Keyfactor Universal Orchestrator version 10.1 and later.

## Support
The Citrix Netscaler Universal Orchestrator extension is supported by Keyfactor for Keyfactor customers. If you have a support issue, please open a support ticket with your Keyfactor representative. If you have a support issue, please open a support ticket via the Keyfactor Support Portal at https://support.keyfactor.com. 
 
> To report a problem or suggest a new feature, use the **[Issues](../../issues)** tab. If you want to contribute actual bug fixes or proposed enhancements, use the **[Pull requests](../../pulls)** tab.

## Installation
Before installing the Citrix Netscaler Universal Orchestrator extension, it's recommended to install [kfutil](https://github.com/Keyfactor/kfutil). Kfutil is a command-line tool that simplifies the process of creating store types, installing extensions, and instantiating certificate stores in Keyfactor Command.


1. Follow the [requirements section](docs/citrixadc.md#requirements) to configure a Service Account and grant necessary API permissions.

    <details><summary>Requirements</summary>

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



    </details>

2. Create Certificate Store Types for the Citrix Netscaler Orchestrator extension. 

    * **Using kfutil**:

        ```shell
        # CitrixAdc
        kfutil store-types create CitrixAdc
        ```

    * **Manually**:
        * [CitrixAdc](docs/citrixadc.md#certificate-store-type-configuration)

3. Install the Citrix Netscaler Universal Orchestrator extension.
    
    * **Using kfutil**: On the server that that hosts the Universal Orchestrator, run the following command:

        ```shell
        # Windows Server
        kfutil orchestrator extension -e citrix-adc-orchestrator@latest --out "C:\Program Files\Keyfactor\Keyfactor Orchestrator\extensions"

        # Linux
        kfutil orchestrator extension -e citrix-adc-orchestrator@latest --out "/opt/keyfactor/orchestrator/extensions"
        ```

    * **Manually**: Follow the [official Command documentation](https://software.keyfactor.com/Core-OnPrem/Current/Content/InstallingAgents/NetCoreOrchestrator/CustomExtensions.htm?Highlight=extensions) to install the latest [Citrix Netscaler Universal Orchestrator extension](https://github.com/Keyfactor/citrix-adc-orchestrator/releases/latest).

4. Create new certificate stores in Keyfactor Command for the Sample Universal Orchestrator extension.

    * [CitrixAdc](docs/citrixadc.md#certificate-store-configuration)



## License

Apache License 2.0, see [LICENSE](LICENSE).

## Related Integrations

See all [Keyfactor Universal Orchestrator extensions](https://github.com/orgs/Keyfactor/repositories?q=orchestrator).