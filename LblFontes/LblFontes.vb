Imports System.Drawing
Imports System.Drawing.Text

Public Class LblFontes
    Public Property zTamanhoLetra As Integer
        Get
            zTamanhoLetra = LblTexto.Font.Size
        End Get
        Set(ByVal value As Integer)
            LblTexto.Font = CustomFont.GetInstance(value, FontStyle.Bold)
        End Set
    End Property
    Public Property zTexto As String
        Get
            zTexto = LblTexto.Text
        End Get
        Set(ByVal value As String)
            LblTexto.Text = value
        End Set
    End Property
    Private Sub LblFontes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblTexto.Font = CustomFont.GetInstance(zTamanhoLetra, FontStyle.Bold)
    End Sub
End Class
