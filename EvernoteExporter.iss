; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{AFCCB115-99F6-466C-AB89-B244A5E5D8BA}
AppName=Evernote Exporter
AppVerName=Evernote Exporter 0.1.0
AppPublisher=Karthik Abiraman
AppPublisherURL=http://evernoteexporter.codeplex.com
AppSupportURL=http://evernoteexporter.codeplex.com
AppUpdatesURL=http://evernoteexporter.codeplex.com
DefaultDirName={pf}\Evernote Exporter
DefaultGroupName=Evernote Exporter
AllowNoIcons=yes
OutputBaseFilename=EvernoteExporter_0.1.0_setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\Karthik\Documents\Work\Tech\Desktop Application\DotNet\C#\EvernoteExporter\EvernoteExporter\bin\Release\EvernoteExporter.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Karthik\Documents\Work\Tech\Desktop Application\DotNet\C#\EvernoteExporter\EvernoteExporter\bin\Release\EvernoteExporter.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Evernote Exporter"; Filename: "{app}\EvernoteExporter.exe"
Name: "{group}\{cm:ProgramOnTheWeb,Evernote Exporter}"; Filename: "http://evernoteexporter.codeplex.com"
Name: "{group}\{cm:UninstallProgram,Evernote Exporter}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\Evernote Exporter"; Filename: "{app}\EvernoteExporter.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Evernote Exporter"; Filename: "{app}\EvernoteExporter.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\EvernoteExporter.exe"; Description: "{cm:LaunchProgram,Evernote Exporter}"; Flags: nowait postinstall skipifsilent

