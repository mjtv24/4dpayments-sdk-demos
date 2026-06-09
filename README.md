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

## Notes

- Each demo uses the workspace demo folder as its working directory.
- The workspace `.vscode` folder contains shared task and launch configuration files.
- If a demo requires a newer or different SDK path, update its project reference to `lib/net6.0` as needed.
