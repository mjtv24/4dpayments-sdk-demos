# 4D Payments SDK Demo Workspace

## Overview

This workspace contains the converted .NET 6 WinForms demo projects for the 4D E-Banking SDK 2024 .NET Edition.

## Included demos

- `Account Info (WinForms)`
- `Bank Statement (WinForms)`
- `Bank Transfer (WinForms)`
- `Bill Payment (WinForms)`
- `CCStatement Demo (WinForms)`
- `FIProfile Demo (WinForms)`
- `InvStatement Demo (WinForms)`

## Setup

1. Install Visual Studio Code.
2. Install the recommended extension: `ms-dotnettools.csharp`.
3. Install .NET SDK 6.x.
4. Open this workspace file:
   - `4dpayments-demos.code-workspace`

## Build

Use the shared workspace task:

- `Ctrl+Shift+B` to run `Build All Demos`

Or run individual build tasks from the Command Palette:

- `Tasks: Run Task`
- Select one of:
  - `Build Account Info Demo`
  - `Build Bank Statement Demo`
  - `Build Bank Transfer Demo`
  - `Build Bill Payment Demo`
  - `Build CCStatement Demo`
  - `Build FIProfile Demo`
  - `Build InvStatement Demo`

## Debug

Open the Run view (`Ctrl+Shift+D`) and select one of the launch configurations:

- `Debug Account Info Demo`
- `Debug Bank Statement Demo`
- `Debug Bank Transfer Demo`
- `Debug Bill Payment Demo`
- `Debug CCStatement Demo`
- `Debug FIProfile Demo`
- `Debug InvStatement Demo`

Each launch configuration builds all demos first, then launches the selected WinForms executable.

## Secure local configuration

A secure local config file allows you to keep credentials and gateway settings out of source control.

1. Copy `local.settings.json.example` to `local.settings.json`.
2. Fill in your sandbox or production values for the demo you are running.
3. Keep `local.settings.json` local only; it is ignored by git.

Example values in the sample file include:

- `DPayments.Ofx.FiUrl`
- `DPayments.Ofx.FiOrganization`
- `DPayments.Ofx.FiId`
- `DPayments.Ofx.OfxUser`
- `DPayments.Ofx.OfxPassword`
- `DPayments.Gateway.Url`
- `DPayments.Gateway.MerchantId`
- `DPayments.Gateway.ApiKey`

If you want, you can extend the demo source code to load values from `local.settings.json` at runtime and populate the form fields automatically.

## GitHub Actions

A GitHub Actions workflow has been added at `.github/workflows/dotnet.yml`.
It restores and builds the Account Info demo on `push` and `pull_request` events to validate the converted .NET 6 project.

## E-Payment Integrator Integration

A new integration folder has been added at `E-Payment Integrator 2024 .NET Edition/`.
It includes a copy of the local E-Payment Integrator installation documentation and runtime libraries so the repository can reference the new edition alongside the existing 4D E-Banking SDK demos.

- `E-Payment Integrator 2024 .NET Edition/help/`
- `E-Payment Integrator 2024 .NET Edition/lib/`
- `E-Payment Integrator 2024 .NET Edition/readme.txt`
- `E-Payment Integrator 2024 .NET Edition/README.md`

## 4D Shipping SDK Integration

A new integration folder has been added at `4D Shipping SDK 2024 .NET Edition/`.
It includes the local Shipping SDK help asset and installation readme so the repository can reference the new Shipping SDK installation alongside the existing demos.

- `4D Shipping SDK 2024 .NET Edition/help/DPayments.DShippingSDK.htm`
- `4D Shipping SDK 2024 .NET Edition/help/html/`
- `4D Shipping SDK 2024 .NET Edition/help/lib/`
- `4D Shipping SDK 2024 .NET Edition/readme.txt`
- `4D Shipping SDK 2024 .NET Edition/README.md`

Use the external code reference at `https://cdn.4dpayments.com/help/DXJ/cs/` for the latest Shipping SDK documentation.

## Notes

- Each demo uses the workspace demo folder as its working directory.
- The workspace `.vscode` folder contains shared task and launch configuration files.
- If a demo requires a newer or different SDK path, update its project reference to `lib/net6.0` as needed.
