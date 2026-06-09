
4D Shipping SDK 2024 .NET Edition Usage and Deployment Instructions

This file includes information on using and deploying the libraries included
in the toolkit. 

****************************************************************
                       Trial Licensing             
****************************************************************

When installing by running the setup executable, no other actions are required.

When installing from NuGet, or to deploy to another system during the trial 
period visit the URL below to generate a 30-day Trial Runtime License value.

    https://www.4dpayments.com/trial/DXNJA

After obtaining the Runtime License value assign this to the RuntimeLicense 
property to license the application for deployment. For instance:

    component.RuntimeLicense = "value from above";

This provides a 30-day trial license to the component and your application 
will run without a license prompt on any machine to which it is distributed
during that time. 

Note that each component instance in your code must be assigned a 
Runtime License value.
  
****************************************************************
                Limited Distribution Licensing     
****************************************************************

The .NET components may be licensed for distribution using either Microsoft's 
.NET Licensing scheme (Windows only) or by assigning a Runtime License value 
to the component instances (all platforms).

Using a Runtime License (all platforms):

A Runtime License can be assigned to a component instance in order to license
the component. This is applicable to all project types for .NET Framework, 
.NET Core, or .NET 5 (and up). Visit the URL below to generate a 
Runtime License value.

    https://www.4dpayments.com/full/DXNJA


After obtaining the Runtime License value assign this to the RuntimeLicense
property to license the application for deployment. For instance:

    component.RuntimeLicense  ="value from above";

This provides a license to the component and your application will run 
without a license prompt on any machine to which it is distributed. 

Note that each component instance in your code must be assigned a 
Runtime License value.

Using Microsoft's .NET Licensing Scheme (Windows only):

This scheme is applicable to projects on Windows targeting .NET Framework
(Windows Forms, Console Applications, etc). In Microsoft's .NET Licensing 
scheme, Visual Studio automatically creates a file named "licenses.licx" 
whenever you drop a licensed component on the form. The "licenses.licx" file
is automatically added to your project as an embedded resource. When you 
build the project, this licenses.licx file will be used to embed license 
information into the compiled assembly (in ASP.NET 2.0, the license
information will be embedded into a separate App_Licenses.dll by default).

If you are not using a form or you are creating the components dynamically,
the easiest way to generate the licx file is to use a separate project, drop
a component on a form, and copy the licenses.licx file over to your formless
project.

Important Notes:

  * The licx file must be named "licenses.licx" and be included in the project
    as an embedded resource.
  * If you are developing a class library, the referencing project must also 
    include the .licx file as an embedded resource and be compiled on a machine
    with a valid license installed.
  * Activation checks are made on the developer machine only, not at runtime.

****************************************************************
                     Included Assemblies
****************************************************************
The .NET Edition includes assemblies (.dll files) which are supported in 
different environments. The following assemblies are present in the lib 
directory after installation:
	lib/net40/DPayments.DShippingSDK.dll
	lib/net6.0/DPayments.DShippingSDK.dll

****************************************************************
                      Supported Runtimes
****************************************************************
The library in the "lib\net40" folder is designed for use in .NET Framework 4.0
and up. This is the default library which maintains a familiar API in line with
previous versions of the product.

The library in the "lib\net6.0" folder is designed for use in .NET 6 and up. 
The .NET 6 library provides cross-platform support while maintaining the same 
API as the default library.

Support for asynchronous programming (async/await) is present in the .NET 6 
library in a separate DPayments.async.DShippingSDK namespace.

****************************************************************
                       System Assembly
****************************************************************

The "lib" folder also includes an assembly named 
DPayments.DShippingSDK.System.dll. This assembly implements 
calls to the underlying system APIs which are necessary
for some of the functionality in some of the components.  
By separating this functionality into its own assembly, we are 
able to provide DPayments.DShippingSDK.dll as a SAFE assembly,
suitable to run in environments with high security.

DPayments.DShippingSDK.System.dll is loaded only if necessary, 
and only if the security permissions allow it.  Note that 
distribution of  DPayments.DShippingSDK.System.dll is OPTIONAL, 
and it is only required if you are using any of the components 
that require access to the system APIs.


****************************************************************
                       Design Assembly
****************************************************************

The "lib/design" folder also includes an assembly named 
DPayments.DShippingSDK.Design.dll. This assembly contains functionality
used when modifying properties of the component in design view
in Visual Studio. It is only used at design time and should not 
be distributed.


