'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
Namespace WCF

	Partial Public Class sysdiagram
		Private privatename As String
		Public Property name() As String
			Get
				Return privatename
			End Get
			Set(ByVal value As String)
				privatename = value
			End Set
		End Property
		Private privateprincipal_id As Integer
		Public Property principal_id() As Integer
			Get
				Return privateprincipal_id
			End Get
			Set(ByVal value As Integer)
				privateprincipal_id = value
			End Set
		End Property
		Private privatediagram_id As Integer
		Public Property diagram_id() As Integer
			Get
				Return privatediagram_id
			End Get
			Set(ByVal value As Integer)
				privatediagram_id = value
			End Set
		End Property
		Private privateversion As Nullable(Of Integer)
		Public Property version() As Nullable(Of Integer)
			Get
				Return privateversion
			End Get
			Set(ByVal value As Nullable(Of Integer))
				privateversion = value
			End Set
		End Property
		Private privatedefinition As Byte()
		Public Property definition() As Byte()
			Get
				Return privatedefinition
			End Get
			Set(ByVal value As Byte())
				privatedefinition = value
			End Set
		End Property
	End Class
End Namespace
