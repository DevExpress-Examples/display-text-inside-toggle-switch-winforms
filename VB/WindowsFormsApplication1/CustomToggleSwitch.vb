Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


Namespace WindowsFormsApplication1
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemCustomToggle
		Inherits RepositoryItemToggleSwitch
		Shared Sub New()
			RegisterCustomToggle()
		End Sub

		Public Sub New()

		End Sub

		Public Const CustomToggleName As String = "CustomToggle"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomToggleName
			End Get
		End Property

		Public Overrides Property GlyphAlignment() As DevExpress.Utils.HorzAlignment
			Get
				Return DevExpress.Utils.HorzAlignment.Center
			End Get
			Set(ByVal value As DevExpress.Utils.HorzAlignment)
			End Set
		End Property

		Public Shared Sub RegisterCustomToggle()

			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomToggleName, GetType(CustomToggle), GetType(RepositoryItemCustomToggle), GetType(ToggleSwitchViewInfo), New CustomToggleSwitchPainter(), True))
		End Sub


	End Class

	<ToolboxItem(True)> _
	Public Class CustomToggle
		Inherits ToggleSwitch

		Shared Sub New()
			RepositoryItemCustomToggle.RegisterCustomToggle()
		End Sub

		Public Sub New()

		End Sub


		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomToggle.CustomToggleName
			End Get
		End Property


		<System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomToggle
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomToggle)
			End Get
		End Property

	End Class
End Namespace
