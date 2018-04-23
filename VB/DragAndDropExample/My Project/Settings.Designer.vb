﻿' Developer Express Code Central Example:
' How to add DragAndDrop capability to the detail grid
' 
' This example demonstrates how to add the DragAndDrop capability to the detail
' grid.
' 
' Our detail grid with DataControlDetailDescriptor doesn't support drag
' and drop. To provide this capability in this sample, we create a
' GridDragDropManager class descendant and override the CalcDraggingRows method to
' obtain a selected row. Then, we subscribe to the GridDragDropManager's DragOver
' and Drop events. When Drop is raised, we calculate to which position we must
' insert a selected row.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T163179

' Developer Express Code Central Example:
' How to add DragAndDrop capability to the detail grid
' 
' This example demonstrates how to add the DragAndDrop capability to the detail
' grid.
' 
' Our detail grid with DataControlDetailDescriptor doesn't support drag
' and drop. To provide this capability in this sample, we create a
' GridDragDropManager class descendant and override the CalcDraggingRows method to
' obtain a selected row. Then, we subscribe to the GridDragDropManager's DragOver
' and Drop events. When Drop is raised, we calculate to which position we must
' insert a selected row.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T163179

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


	<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property
	End Class
End Namespace
