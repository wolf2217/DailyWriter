﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Journal")>  _
Partial Public Class FunctionsDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertdw_user(instance As dw_user)
    End Sub
  Partial Private Sub Updatedw_user(instance As dw_user)
    End Sub
  Partial Private Sub Deletedw_user(instance As dw_user)
    End Sub
  Partial Private Sub Insertdw_journal(instance As dw_journal)
    End Sub
  Partial Private Sub Updatedw_journal(instance As dw_journal)
    End Sub
  Partial Private Sub Deletedw_journal(instance As dw_journal)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.DailyWriter.My.MySettings.Default.JournalConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property dw_users() As System.Data.Linq.Table(Of dw_user)
		Get
			Return Me.GetTable(Of dw_user)
		End Get
	End Property
	
	Public ReadOnly Property dw_journals() As System.Data.Linq.Table(Of dw_journal)
		Get
			Return Me.GetTable(Of dw_journal)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.dw_users")>  _
Partial Public Class dw_user
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _userID As Integer
	
	Private _Username As String
	
	Private _Password As String
	
	Private _Created As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnuserIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnuserIDChanged()
    End Sub
    Partial Private Sub OnUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnUsernameChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnCreatedChanging(value As String)
    End Sub
    Partial Private Sub OnCreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_userID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property userID() As Integer
		Get
			Return Me._userID
		End Get
		Set
			If ((Me._userID = value)  _
						= false) Then
				Me.OnuserIDChanging(value)
				Me.SendPropertyChanging
				Me._userID = value
				Me.SendPropertyChanged("userID")
				Me.OnuserIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Username", DbType:="NVarChar(50)")>  _
	Public Property Username() As String
		Get
			Return Me._Username
		End Get
		Set
			If (String.Equals(Me._Username, value) = false) Then
				Me.OnUsernameChanging(value)
				Me.SendPropertyChanging
				Me._Username = value
				Me.SendPropertyChanged("Username")
				Me.OnUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(50)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Created", DbType:="NVarChar(50)")>  _
	Public Property Created() As String
		Get
			Return Me._Created
		End Get
		Set
			If (String.Equals(Me._Created, value) = false) Then
				Me.OnCreatedChanging(value)
				Me.SendPropertyChanging
				Me._Created = value
				Me.SendPropertyChanged("Created")
				Me.OnCreatedChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.dw_journal")>  _
Partial Public Class dw_journal
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _journalID As Integer
	
	Private _Username As String
	
	Private _JournalCover As String
	
	Private _JournalTitle As String
	
	Private _JournalDescription As String
	
	Private _IsPassword As System.Nullable(Of Boolean)
	
	Private _Password As String
	
	Private _Created As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnjournalIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnjournalIDChanged()
    End Sub
    Partial Private Sub OnUsernameChanging(value As String)
    End Sub
    Partial Private Sub OnUsernameChanged()
    End Sub
    Partial Private Sub OnJournalCoverChanging(value As String)
    End Sub
    Partial Private Sub OnJournalCoverChanged()
    End Sub
    Partial Private Sub OnJournalTitleChanging(value As String)
    End Sub
    Partial Private Sub OnJournalTitleChanged()
    End Sub
    Partial Private Sub OnJournalDescriptionChanging(value As String)
    End Sub
    Partial Private Sub OnJournalDescriptionChanged()
    End Sub
    Partial Private Sub OnIsPasswordChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnIsPasswordChanged()
    End Sub
    Partial Private Sub OnPasswordChanging(value As String)
    End Sub
    Partial Private Sub OnPasswordChanged()
    End Sub
    Partial Private Sub OnCreatedChanging(value As String)
    End Sub
    Partial Private Sub OnCreatedChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_journalID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property journalID() As Integer
		Get
			Return Me._journalID
		End Get
		Set
			If ((Me._journalID = value)  _
						= false) Then
				Me.OnjournalIDChanging(value)
				Me.SendPropertyChanging
				Me._journalID = value
				Me.SendPropertyChanged("journalID")
				Me.OnjournalIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Username", DbType:="NVarChar(50)")>  _
	Public Property Username() As String
		Get
			Return Me._Username
		End Get
		Set
			If (String.Equals(Me._Username, value) = false) Then
				Me.OnUsernameChanging(value)
				Me.SendPropertyChanging
				Me._Username = value
				Me.SendPropertyChanged("Username")
				Me.OnUsernameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_JournalCover", DbType:="NVarChar(MAX)")>  _
	Public Property JournalCover() As String
		Get
			Return Me._JournalCover
		End Get
		Set
			If (String.Equals(Me._JournalCover, value) = false) Then
				Me.OnJournalCoverChanging(value)
				Me.SendPropertyChanging
				Me._JournalCover = value
				Me.SendPropertyChanged("JournalCover")
				Me.OnJournalCoverChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_JournalTitle", DbType:="NVarChar(50)")>  _
	Public Property JournalTitle() As String
		Get
			Return Me._JournalTitle
		End Get
		Set
			If (String.Equals(Me._JournalTitle, value) = false) Then
				Me.OnJournalTitleChanging(value)
				Me.SendPropertyChanging
				Me._JournalTitle = value
				Me.SendPropertyChanged("JournalTitle")
				Me.OnJournalTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_JournalDescription", DbType:="NVarChar(MAX)")>  _
	Public Property JournalDescription() As String
		Get
			Return Me._JournalDescription
		End Get
		Set
			If (String.Equals(Me._JournalDescription, value) = false) Then
				Me.OnJournalDescriptionChanging(value)
				Me.SendPropertyChanging
				Me._JournalDescription = value
				Me.SendPropertyChanged("JournalDescription")
				Me.OnJournalDescriptionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsPassword", DbType:="Bit")>  _
	Public Property IsPassword() As System.Nullable(Of Boolean)
		Get
			Return Me._IsPassword
		End Get
		Set
			If (Me._IsPassword.Equals(value) = false) Then
				Me.OnIsPasswordChanging(value)
				Me.SendPropertyChanging
				Me._IsPassword = value
				Me.SendPropertyChanged("IsPassword")
				Me.OnIsPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Password", DbType:="NVarChar(50)")>  _
	Public Property Password() As String
		Get
			Return Me._Password
		End Get
		Set
			If (String.Equals(Me._Password, value) = false) Then
				Me.OnPasswordChanging(value)
				Me.SendPropertyChanging
				Me._Password = value
				Me.SendPropertyChanged("Password")
				Me.OnPasswordChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Created", DbType:="NVarChar(50)")>  _
	Public Property Created() As String
		Get
			Return Me._Created
		End Get
		Set
			If (String.Equals(Me._Created, value) = false) Then
				Me.OnCreatedChanging(value)
				Me.SendPropertyChanging
				Me._Created = value
				Me.SendPropertyChanged("Created")
				Me.OnCreatedChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class