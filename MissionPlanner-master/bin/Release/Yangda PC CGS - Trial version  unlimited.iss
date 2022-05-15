; �ű��� Inno Setup �ű������ɡ�
; �����ĵ���ȡ���� INNO SETUP �ű��ļ���ϸ����!

[Setup]
AppName=LAUNCH GCS Trial version unlimited
AppVerName=LAUNCH GCS V1.1.5
VersionInfoVersion=1.1.5
AppPublisher=Shenzhen Yangda UAV Co., Ltd
AppPublisherURL=http://www.yangda.com/
AppSupportURL=http://www.yangda.com/
AppUpdatesURL=http://www.yangda.com/
DefaultDirName={pf}\LAUNCH\GCS
DefaultGroupName=LAUNCH UAV\LAUNCH GCS
DisableDirPage = no
CreateAppDir=yes
OutputDir=.
OutputBaseFilename=LAUNCH GCS V1.1.5 Trial version unlimited
Compression=lzma
;WindowVisible=yes
FlatComponentsList=yes         
VersionInfoDescription=LAUNCH GCS V1.1.5
SolidCompression=true
WizardImageFile=.\net461\Office2007-1.bmp
WizardSmallImageFile=.\net461\WizModernSmallImage-Is-1.bmp
;��װ��鿴�ı��ļ�  
;InfoAfterFile=.\net461\readme.txt 
;��װͼ��
SetupIconFile=.\net461\mpdesktop.ico
;��װЭ��
LicenseFile=.\net461\en.txt


[Languages]
;Name: "chs"; MessagesFile: "compiler:default.isl"  
;Name: "eng"; MessagesFile: "compiler:Languages\English.isl" 

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}" ;

;Flags: unchecked

[Files]
Source: ".\net461\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; ע��: ��Ҫ���κι���ϵͳ�ļ���ʹ�á�Flags: ignoreversion��   

[Icons]    
Name: "{group}\LAUNCH GCS"; Filename: "{app}\LAUNCH GCS.exe"
Name: "{group}\{cm:UninstallProgram,LAUNCH GCS}"; Filename: "{uninstallexe}"
Name: "{userdesktop}\LAUNCH GCS V1.1.5";Filename: "{app}\LAUNCH GCS.exe"

; Name: "{group}\Start service"; Filename: "{app}\install.bat" ;  IconFilename: "{app}\install.ICO"  ;WorkingDir: "{app}" ;Comment: "Start service"
; Name: "{group}\Stop service"; Filename: "{app}\uninstall.bat" ;  IconFilename: "{app}\uninstall.ICO"  ;WorkingDir: "{app}" ;Comment: "Stop service"

;Name: "{userdesktop}\�����ϴ�����v2.02"; Filename: "{app}\ZSInterface.exe"; Tasks: desktopicon

[Run]
;Filename: "{app}\SMD_GCS.exe"; Description: "{cm:LaunchProgram,�Ƿ��������� SMD PC ����վ�������}"; Flags: postinstall runhidden waituntilterminated
;Filename: "{app}\Drivers\Driver64.exe"; Description: "{cm:LaunchProgram,Driver64����}";Check:IsWin64
;Filename: "{app}\Drivers\Driver86.exe"; Description: "{cm:LaunchProgram,Driver86����}";Check:not IsWin64
;Filename: "{app}\readme.txt"
;Filename: "{app}\readme.txt"; Description: "{cm:LaunchProgram,Start service}"; Flags: postinstall runhidden waituntilterminated

[UninstallRun]
Filename: "{app}\uninstall.bat"; Flags: runhidden waituntilterminated


[UninstallDelete]
Type: filesandordirs; Name: "{app}"


[Code]
procedure UnInstallOldVersion() ;
var ResultCode:Integer  ;
begin
         shellExec('open',ExpandConstant('{app}\uninstall.bat'),   '', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
end;


procedure Uninstallser();
var ResultCode:Integer;
begin
 shellExec('open',ExpandConstant('{app}\uninstall.bat'),   '', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
end;

// Importing LoadSkin API from ISSkin.DLL
procedure LoadSkin(lpszPath: AnsiString; lpszIniFileName: AnsiString);
external 'LoadSkin@files:isskin.dll stdcall';

// Importing UnloadSkin API from ISSkin.DLL
procedure UnloadSkin();
external 'UnloadSkin@files:isskin.dll stdcall';

// Importing ShowWindow Windows API from User32.DLL
function ShowWindow(hWnd: Integer; uType: Integer): Integer;
external 'ShowWindow@user32.dll stdcall';

function InitializeSetup(): Boolean;
begin
	ExtractTemporaryFile('Office2007.cjstyles');
	LoadSkin(AnsiString(ExpandConstant('{tmp}\Office2007.cjstyles')), 'NormalBlack.ini');
	Result := True;
end;

procedure DeinitializeSetup();
begin
	// Hide Window before unloading skin so user does not get
	// a glimse of an unskinned window before it is closed.
	ShowWindow(StrToInt(ExpandConstant('{wizardhwnd}')), 0);
	UnloadSkin();
end;
