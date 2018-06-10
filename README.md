# PKCS11Cloud

The PKCS#11 Driver for Cloud Cryptography is a virtual smart card configurated to use the Cloud environment for applying digital signatures on a document. It can be integrated with the existing signing applications.

The main part of the PKCS#11 Driver is from the [SoftHSMv2 project](https://github.com/opendnssec/SoftHSMv2).

The PKCS#11 Cloud Driver communicates through a [wrapper](https://github.com/leahulorena/PKCS11Cloud_Wrapper) with the Cloud environment. The user's cryptographic objects are stored on a Web Server. For computing and applying a digital signature on a document the PKCS#11 Cloud Driver sends the request to the Web Server through a Web Service.


##### Features
- It can be used with the existing signing application
- The digital signature is computed in Cloud, and it is only applied on the document.
- For each use of the cryptographic objects, the user is prompted to submit his credentials (used for generating the keys and the certificate)
- The crytographic operations are computed in the Cloud environment.



## Licence
This project is licensed under the MIT License - see the LICENSE.md file for details
