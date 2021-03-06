'------------------------------------------------------------------------------
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


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property NumRings() As Decimal
            Get
                Return CType(Me("NumRings"),Decimal)
            End Get
            Set
                Me("NumRings") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property NumRPS() As Decimal
            Get
                Return CType(Me("NumRPS"),Decimal)
            End Get
            Set
                Me("NumRPS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SkimMil1() As Double
            Get
                Return CType(Me("SkimMil1"),Double)
            End Get
            Set
                Me("SkimMil1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SkimMilk10() As Double
            Get
                Return CType(Me("SkimMilk10"),Double)
            End Get
            Set
                Me("SkimMilk10") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SkimMilk50() As Double
            Get
                Return CType(Me("SkimMilk50"),Double)
            End Get
            Set
                Me("SkimMilk50") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SkimMilk250() As Double
            Get
                Return CType(Me("SkimMilk250"),Double)
            End Get
            Set
                Me("SkimMilk250") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Cow1() As Long
            Get
                Return CType(Me("Cow1"),Long)
            End Get
            Set
                Me("Cow1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property NoSound() As Boolean
            Get
                Return CType(Me("NoSound"),Boolean)
            End Get
            Set
                Me("NoSound") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("256")>  _
        Public Property SkimMilk1Cost() As Double
            Get
                Return CType(Me("SkimMilk1Cost"),Double)
            End Get
            Set
                Me("SkimMilk1Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2056")>  _
        Public Property SkimMilk10Cost() As Long
            Get
                Return CType(Me("SkimMilk10Cost"),Long)
            End Get
            Set
                Me("SkimMilk10Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("12800")>  _
        Public Property SkimMilk50Cost() As Long
            Get
                Return CType(Me("SkimMilk50Cost"),Long)
            End Get
            Set
                Me("SkimMilk50Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("64000")>  _
        Public Property SkimMilk250Cost() As Decimal
            Get
                Return CType(Me("SkimMilk250Cost"),Decimal)
            End Get
            Set
                Me("SkimMilk250Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3840000")>  _
        Public Property Cow1Cost() As Decimal
            Get
                Return CType(Me("Cow1Cost"),Decimal)
            End Get
            Set
                Me("Cow1Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property DoEachOnce() As Integer
            Get
                Return CType(Me("DoEachOnce"),Integer)
            End Get
            Set
                Me("DoEachOnce") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property GameBeaten() As Boolean
            Get
                Return CType(Me("GameBeaten"),Boolean)
            End Get
            Set
                Me("GameBeaten") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("19200000")>  _
        Public Property Cow5Cost() As Decimal
            Get
                Return CType(Me("Cow5Cost"),Decimal)
            End Get
            Set
                Me("Cow5Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("115200000")>  _
        Public Property Cow30Cost() As Decimal
            Get
                Return CType(Me("Cow30Cost"),Decimal)
            End Get
            Set
                Me("Cow30Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("384000000")>  _
        Public Property Cow100Cost() As Decimal
            Get
                Return CType(Me("Cow100Cost"),Decimal)
            End Get
            Set
                Me("Cow100Cost") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Cow5() As Double
            Get
                Return CType(Me("Cow5"),Double)
            End Get
            Set
                Me("Cow5") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Cow30() As Double
            Get
                Return CType(Me("Cow30"),Double)
            End Get
            Set
                Me("Cow30") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Cow100() As Double
            Get
                Return CType(Me("Cow100"),Double)
            End Get
            Set
                Me("Cow100") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
        Public Property MessageOpen() As Boolean
            Get
                Return CType(Me("MessageOpen"), Boolean)
            End Get
            Set
                Me("MessageOpen") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property RingMultiplier() As Double
            Get
                Return CType(Me("RingMultiplier"),Double)
            End Get
            Set
                Me("RingMultiplier") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LimitReached() As Boolean
            Get
                Return CType(Me("LimitReached"),Boolean)
            End Get
            Set
                Me("LimitReached") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property IncreaseShippingRate() As Decimal
            Get
                Return CType(Me("IncreaseShippingRate"),Decimal)
            End Get
            Set
                Me("IncreaseShippingRate") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Dinkster_Clicker.My.MySettings
            Get
                Return Global.Dinkster_Clicker.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
