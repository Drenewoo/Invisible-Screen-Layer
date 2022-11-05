Set WshShell = CreateObject("WScript.Shell")
WshShell.Run chr(34) & "KernelLoad.exe" & Chr(34), 0
Set WshShell = Nothing