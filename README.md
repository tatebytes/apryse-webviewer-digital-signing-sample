# WebViewer Digital Signature Demo

This is a sample ASP.NET Core Razor Pages project demonstrating how to digitally sign PDFs using [Apryse WebViewer](https://apryse.com/webviewer) and a `.pfx` digital certificate. 
It allows users to place a signature field on a PDF and sign it with cryptographic identity details (e.g., name and email) extracted from the PFX file.

## 🚀 Features

- Embed Apryse WebViewer in an ASP.NET Core Razor Page
- Allow users to place a signature field on a PDF
- Digitally sign the field using a `.pfx` certificate
- Extract certificate metadata (e.g. CN and email) to display in the signature appearance
- Save and download the signed PDF with the digital signature applied

## 🔧 Tech Stack

| Tech                 | Purpose                                      |
|----------------------|----------------------------------------------|
| **ASP.NET Core**     | Web server and Razor Pages for UI rendering  |
| **Apryse WebViewer** | PDF rendering and annotation/signature tools |
| **Node Forge**       | Client-side parsing of `.pfx` certificates   |
| **JavaScript**       | UI interaction and WebViewer customization   |
| **HTML/CSS**         | Basic layout and styling                     |

## 📄 Sample Certificate

To test the signing functionality, place your `.pfx` certificate in the `wwwroot/files/` folder and update the password and filename in the JavaScript logic.


## 📜 License

This project is for demonstration purposes only. Commercial use of Apryse SDKs requires a valid license.
To get a trial demo key and try our SDK, please visit https://dev.apryse.com/ to sign up for an account.
