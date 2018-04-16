Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web

Public Class EmbedHttpHandler
	Implements IHttpHandler

	Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
		Get
			Return False
		End Get
	End Property

	Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
		context.Response.Clear()

		If Not String.IsNullOrEmpty(context.Request.QueryString("flash")) Then
			context.Response.ContentType = "application/x-shockwave-flash"
			context.Response.BinaryWrite(GetByteFile(context.Server.MapPath("~/Files/FlashClocks")))
		End If

		context.Response.End()
	End Sub

	Private Function GetByteFile(ByVal filePath As String) As Byte()
		Dim bytes() As Byte
		Using fileStream As Stream = File.OpenRead(filePath)
			bytes = New Byte(fileStream.Length - 1){}
			For i As Integer = 0 To bytes.Length - 1
				bytes(i) = CByte(fileStream.ReadByte())
			Next i
		End Using

		Return bytes
	End Function
End Class