[Setup]
AppName=RCProTanki
AppVersion=1.0
DefaultDirName={pf}\RCProTanki
DefaultGroupName=RCProTanki
OutputDir=.\Output
OutputBaseFilename=RCProTanki-Setup
SetupIconFile=C:\Users\bruno\Documents\RCPROTanki\rcprotanki\assets\icon.ico
Compression=lzma
SolidCompression=yes

[Files]
Source: "C:\Users\bruno\Documents\projetos\rcprotanki-win-x64\publish\RCPROTanki.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\bruno\Documents\projetos\rcprotanki-win-x64\publish\createdump.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\bruno\Documents\projetos\rcprotanki-win-x64\publish\RCPROTanki.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\bruno\Documents\projetos\rcprotanki-win-x64\publish\RCPROTanki.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\bruno\Documents\projetos\rcprotanki-win-x64\publish\RCPROTanki.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\bruno\Documents\projetos\rcprotanki-win-x64\publish\*.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\RCProTanki"; Filename: "{app}\Executavel.exe"
Name: "{group}\{cm:UninstallProgram,NomeDoSeuApp}"; Filename: "{uninstallexe}"
