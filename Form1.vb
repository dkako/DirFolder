Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text

Public Class TheForm
	Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
		Const C As String = ";"
		Dim dir As String, save As String
		Dim append As Boolean
		With FolderBrowserDialog1
			.RootFolder = Environment.SpecialFolder.Desktop
			If .ShowDialog(Me) <> DialogResult.OK Then Return
			dir = .SelectedPath
		End With
		With SaveFileDialog1
			.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
			If .ShowDialog(Me) <> DialogResult.OK Then Return
			save = .FileName
			If (New FileInfo(save)).Exists Then
				Select Case MsgBox("Append to existing file?", vbYesNoCancel Or MsgBoxStyle.Exclamation, "Append")
					Case MsgBoxResult.Yes
						append = True
					Case MsgBoxResult.No
						append = False
					Case MsgBoxResult.Cancel
						Return
				End Select
			End If
		End With
		If Not append Then IO.File.Delete(save)
		Label2.Text = "Extracting directory info for " & dir & "..."
		Application.DoEvents()
		Dim files As FileInfo() = (New IO.DirectoryInfo(dir)).GetFiles(searchPattern:="*", searchOption:=SearchOption.AllDirectories)
		Dim cur_frame_count As Integer
		Using output As New StreamWriter(save, append, Encoding.UTF8)
			output.NewLine = vbCrLf
			If Not append Then output.WriteLine("name;path;size;mod_date;creation_date;image_file_pages")
			Dim f As Integer = -1
			Do
				Try
					For f = f + 1 To files.Count - 1
						With files(f)
							Using img As Image = Image.FromFile(.FullName)
								cur_frame_count = img.GetFrameCount(FrameDimension.Page)
							End Using
							output.WriteLine(Replace(.Name, .Extension, "") & C & .FullName & C & .Length & C & .LastWriteTime & C & .CreationTime & C & cur_frame_count)
							Label2.Text = f + 1 & "/" & files.Count & vbCrLf & "Saving info for " & .FullName & "..."
							Application.DoEvents()
						End With 'files(f)
					Next f
				Catch
					With files(f)
						output.WriteLine(Replace(.Name, .Extension, "") & C & .FullName & C & .Length & C & .LastWriteTime & C & .CreationTime & C & 0)
						Label2.Text = f + 1 & "/" & files.Count & vbCrLf & "Saving info for " & .FullName & "..."
						Application.DoEvents()
					End With 'files(f)
				End Try
			Loop Until f >= files.Count - 1
		End Using 'output
		Label2.Text = "Done (" & files.Count & " files found)."
	End Sub
End Class
