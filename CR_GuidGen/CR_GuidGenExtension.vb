Imports System.ComponentModel.Composition
Imports DevExpress.CodeRush.Common

Namespace DX_GuidGen
  <Export(GetType(IVsixPluginExtension))> _
  Public Class DX_GuidGenExtension
	  Implements IVsixPluginExtension
  End Class
End Namespace