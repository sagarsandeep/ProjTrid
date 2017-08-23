Set objFSO = CreateObject("Scripting.FileSystemObject")

objStartFolder = ".\."

Set objFolder = objFSO.GetFolder(objStartFolder)

Set colFiles = objFolder.Files

strFileNames = ""
For Each objFile in colFiles
	File_Name = Left(objFile.Name, InStrRev(objFile.Name,".") - 1)
	File_Name_Ext = Mid (objFile.Name, InStrRev(objFile.Name,".") + 1)
	REM msgbox File_Name_Ext
    if (UCase(File_Name_Ext) = "CSV") And (UCase(File_Name) <> "HEADER") And (UCase(File_Name) <> "TRID_REPORT") Then
		strFileNames = strFileNames & objFile.Name & "+"
	End if
	
Next

If Len(strFileNames) > 0 Then
	strFileNames = Mid(strFileNames, 1,Len(strFileNames)-1)
	strFileNames = "Copy "  & "HEADER.csv" & "+" & strFileNames & " TRID_Report.csv"
End If

Wscript.Echo strFileNames

Dim oShell
Set oShell = WScript.CreateObject ("WScript.Shell")
oShell.run "cmd.exe /C " & strFileNames
Set oShell = Nothing
Set colFiles = Nothing
Set objFolder = Nothing
Set objFSO = Nothing
