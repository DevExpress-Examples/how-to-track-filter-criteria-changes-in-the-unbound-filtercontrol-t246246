﻿' Developer Express Code Central Example:
' How to track filter criteria changes in the unbound FilterControl
' 
' By default, the FilterControl's FilterCriteria
' (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_FilterCriteriatopic.htm)
' property is updated only after the ApplyFilter method has been called, while the
' ActualFilterCriteria
' (ms-help://DevExpress.NETv11.1/DevExpress.Wpf/DevExpressXpfEditorsFilteringFilterControl_ActualFilterCriteriatopic.htm)
' property does not send notifications when the user changes the filter.
' 
' This
' sample project shows how to force an unbound FilterControl to update its
' FilterCriteria property and bind another control or a view model to this
' property.
' 
' This is a temporary solution until the ID S135378, 'FilterControl
' criteria changed event' suggestion is implemented.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3766

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("DXSLSample")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Microsoft")>
<Assembly: AssemblyProduct("DXSLSample")>
<Assembly: AssemblyCopyright("Copyright © Microsoft 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("28cd7910-298f-4da6-a5a4-b1d1d00325ac")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
