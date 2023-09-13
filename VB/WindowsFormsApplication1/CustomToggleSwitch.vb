Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System.ComponentModel

Namespace WindowsFormsApplication1

    <UserRepositoryItem("RegisterCustomEdit")>
    Public Class RepositoryItemCustomToggle
        Inherits RepositoryItemToggleSwitch

        Shared Sub New()
            Call RegisterCustomToggle()
        End Sub

        Public Sub New()
        End Sub

        Public Const CustomToggleName As String = "CustomToggle"

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return CustomToggleName
            End Get
        End Property

        Public Overrides ReadOnly Property GlyphAlignment As DevExpress.Utils.HorzAlignment
            Get
                Return DevExpress.Utils.HorzAlignment.Center
            End Get
        End Property

        Public Shared Sub RegisterCustomToggle()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomToggleName, GetType(CustomToggle), GetType(RepositoryItemCustomToggle), GetType(ToggleSwitchViewInfo), New CustomToggleSwitchPainter(), True))
        End Sub
    End Class

    <ToolboxItem(True)>
    Public Class CustomToggle
        Inherits ToggleSwitch

        Shared Sub New()
            RepositoryItemCustomToggle.RegisterCustomToggle()
        End Sub

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return RepositoryItemCustomToggle.CustomToggleName
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemCustomToggle
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomToggle)
            End Get
        End Property
    End Class
End Namespace
