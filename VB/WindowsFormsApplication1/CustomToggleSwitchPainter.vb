Imports Microsoft.VisualBasic
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication1
	Friend Class CustomToggleSwitchPainter
		Inherits ToggleSwitchPainter
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub DrawContent(ByVal info As ControlGraphicsInfoArgs)
			Dim vi As BaseCheckEditViewInfo = TryCast(info.ViewInfo, BaseCheckEditViewInfo)
			vi.CheckInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

			Dim args As ToggleObjectInfoArgs = TryCast((vi.CheckInfo), ToggleObjectInfoArgs)

			If args.GlyphRect.X = args.SwitchRect.X Then
				vi.CheckInfo.CaptionRect = New Rectangle(args.SwitchRect.Right, args.SwitchRect.Y, args.SwitchRect.Width, args.SwitchRect.Height)
			Else
				If args.GlyphRect.Right = args.SwitchRect.Right Then
					vi.CheckInfo.CaptionRect = New Rectangle(args.GlyphRect.X, args.GlyphRect.Y, args.SwitchRect.Width, args.SwitchRect.Height)
				End If
			End If

			MyBase.DrawContent(info)
		End Sub
	End Class
End Namespace
