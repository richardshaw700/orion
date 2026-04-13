FUNCTION: GolfIn::Interface::waitForShot
ENTRY: 1800dae80
REASONS: name:waitForShot; string:waitForShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Type propagation algorithm not settling */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: bool __cdecl GolfIn::Interface::waitForShot(class GolfIn::Shot & __ptr64,bool,bool)
   __ptr64 */

bool __thiscall
GolfIn::Interface::waitForShot(Interface *this,Shot *param_1,bool param_2,bool param_3)

{
  char cVar1;
  undefined1 auVar2 [12];
  undefined8 uVar3;
  undefined8 uVar4;
  uint uVar5;
  Shot *pSVar6;
  bool bVar7;
  bool bVar8;
  Interface IVar9;
  Parameter *this_00;
  longlong *plVar10;
  undefined8 *puVar11;
  longlong *plVar12;
  longlong lVar13;
  size_t sVar14;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar15;
  char *pcVar16;
  Shot *pSVar17;
  uint uVar18;
  undefined8 *******pppppppuVar19;
  undefined1 auVar20 [16];
  undefined1 auStackY_428 [32];
  bool local_3f7;
  bool local_3f6 [6];
  uint local_3f0;
  Shot *local_3e8;
  longlong local_3e0;
  undefined8 local_3d8;
  undefined8 uStack_3d0;
  undefined8 local_3c8;
  undefined8 local_3c0;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *local_3b8;
  Shot *local_3b0;
  undefined8 local_3a8;
  undefined8 uStack_3a0;
  undefined8 local_398;
  undefined8 local_390;
  float local_388;
  float local_384;
  float local_380;
  undefined8 *******local_378;
  undefined8 uStack_370;
  undefined8 local_368;
  ulonglong uStack_360;
  longlong local_358;
  longlong local_350;
  longlong local_348;
  longlong local_340;
  longlong local_338;
  longlong local_330;
  longlong local_328;
  longlong local_320;
  undefined8 local_318;
  undefined8 uStack_310;
  undefined8 local_308;
  undefined8 uStack_300;
  undefined1 local_2f8 [8];
  longlong local_2f0;
  longlong lStack_2e8;
  longlong local_2e0;
  longlong lStack_2d8;
  longlong local_2d0;
  longlong lStack_2c8;
  longlong local_2c0;
  longlong lStack_2b8;
  longlong local_2b0;
  longlong lStack_2a8;
  longlong local_2a0;
  longlong lStack_298;
  longlong local_290;
  longlong lStack_288;
  longlong local_280;
  longlong lStack_278;
  longlong local_270;
  longlong lStack_268;
  longlong local_260;
  longlong lStack_258;
  longlong local_250;
  longlong lStack_248;
  longlong local_240;
  longlong lStack_238;
  longlong local_230 [4];
  longlong local_210 [4];
  longlong local_1f0 [4];
  longlong local_1d0 [4];
  longlong local_1b0 [4];
  longlong local_190 [4];
  longlong local_170 [5];
  undefined8 local_148;
  undefined8 uStack_140;
  undefined8 local_138;
  undefined8 uStack_130;
  double local_128;
  double dStack_120;
  double local_118;
  undefined8 uStack_110;
  longlong local_108 [4];
  longlong local_e8 [4];
  longlong local_c8 [4];
  char local_a8 [32];
  int local_88;
  undefined4 uStack_84;
  void *local_80;
  void *local_78;
  undefined8 local_68;
  undefined8 uStack_60;
  undefined8 local_58;
  undefined8 uStack_50;
  ulonglong local_48;
  
                    /* 0xdae80  1057  ?waitForShot@Interface@GolfIn@@QEAA_NAEAVShot@2@_N1@Z */
  local_48 = DAT_1801d1040 ^ (ulonglong)auStackY_428;
  local_3f0 = 0;
  if (this[0x28a] == (Interface)0x0) {
    return true;
  }
  local_3b0 = param_1;
  if (param_3) {
    bVar8 = false;
LAB_1800daf40:
    bVar7 = true;
  }
  else {
    local_230[0] = 0;
    local_230[1] = 0;
    local_230[2] = 0;
    local_230[3] = 0;
    FUN_18000c1d0(local_230,"Configurations.Debug.UseCameras",0x1f);
    bVar8 = true;
    local_3f0 = 1;
    this_00 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)local_230);
    bVar7 = Libraries::Core::Parameter::toBoolean(this_00);
    if (!bVar7) goto LAB_1800daf40;
    bVar7 = false;
  }
  if (bVar8) {
    local_3f0 = 0;
    FUN_18000c8d0(local_230);
  }
  if (this[0x28b] != (Interface)0x0) {
    if (this[0x2d8] == (Interface)0x0) {
      LOCK();
      *(undefined4 *)(this + 0x704) = 2;
      UNLOCK();
      IVar9 = (Interface)validBallDetectionAnalysis(this,param_1);
      LOCK();
      this[0x900] = IVar9;
      UNLOCK();
    }
    LOCK();
    this[0x28a] = (Interface)0x1;
    UNLOCK();
    LOCK();
    this[0x28b] = (Interface)0x0;
    UNLOCK();
    LOCK();
    this[0x28c] = (Interface)0x0;
    UNLOCK();
    resumeCameraAcquisition(this);
    return false;
  }
  plVar10 = FUN_1800014c0();
  local_3a8 = 0;
  uStack_3a0 = 0;
  local_398 = 0;
  local_390 = 0;
  FUN_18000c1d0(&local_3a8,"Ball stopped to move. Determining inital ball position...",0x39);
  FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_3a8,0,'\x01');
  Shot::clear(param_1);
  FUN_1800090b0(&local_350);
  local_1f0[0] = 0;
  local_1f0[1] = 0;
  local_1f0[2] = 0;
  local_1f0[3] = 0;
  FUN_18000c1d0(local_1f0,&DAT_18016a0f8,0);
  local_210[0] = 0;
  local_210[1] = 0;
  local_210[2] = 0;
  local_210[3] = 0;
  FUN_18000c1d0(local_210,&DAT_18016a0f8,0);
  local_3b8 = grabFrames(this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)local_210,
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)local_1f0);
  FUN_18000c8d0(local_210);
  FUN_18000c8d0(local_1f0);
  FUN_1800090b0(&local_358);
  plVar10 = FUN_1800014c0();
  puVar11 = FUN_180084840(local_108,(local_358 - local_350) / 1000000);
  plVar12 = FUN_180007680(puVar11,0,"Times to grab frames at waitForShot >>  ",0x28);
  uVar5 = local_3f0;
  local_290 = *plVar12;
  lStack_288 = plVar12[1];
  local_280 = plVar12[2];
  lStack_278 = plVar12[3];
  plVar12[3] = 0xf;
  plVar12[2] = 0;
  *(undefined1 *)plVar12 = 0;
  plVar12 = FUN_18000a490(&local_290,&DAT_180175e94,3);
  local_2b0 = *plVar12;
  lStack_2a8 = plVar12[1];
  local_2a0 = plVar12[2];
  lStack_298 = plVar12[3];
  plVar12[2] = 0;
  plVar12[3] = 0xf;
  *(undefined1 *)plVar12 = 0;
  uVar18 = uVar5 | 0x18;
  local_3f0 = uVar18;
  FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0,0,'\x01');
  FUN_18000c8d0(&local_290);
  FUN_18000c8d0(local_108);
  pSVar6 = local_3b0;
  uVar4 = _UNK_18017ef38;
  uVar3 = _DAT_18017ef30;
  if (local_3b8 ==
      (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
       *)0x0) {
    plVar10 = FUN_1800014c0();
    local_3a8 = 0;
    uStack_3a0 = 0;
    local_398 = 0;
    local_390 = 0;
    FUN_18000c1d0(&local_3a8,"WaitForShot >> Frame Not Found !! ",0x22);
    FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_3a8,1,'\x01');
    LOCK();
    this[0x28b] = (Interface)0x0;
    UNLOCK();
    return false;
  }
  pSVar17 = local_3b0 + 8;
  local_3e8 = pSVar17;
  if (param_3) {
    *(undefined4 *)(local_3b0 + 0x30) = 0xff;
    *(undefined4 *)(local_3b0 + 0x34) = 0x159;
    *(undefined4 *)(local_3b0 + 0x38) = 0x1e;
    *(undefined4 *)(local_3b0 + 0x3c) = 0x1e;
    *(undefined8 *)(local_3b0 + 0x40) = 0x406fe00000000000;
    *(undefined8 *)(local_3b0 + 0x48) = 0x406fe00000000000;
    *(undefined8 *)(local_3b0 + 0x50) = 0x406fe00000000000;
    *(undefined8 *)(local_3b0 + 0x58) = 0;
    *(undefined8 *)(local_3b0 + 0x150) = uVar3;
    *(undefined8 *)(local_3b0 + 0x158) = uVar4;
    *(undefined8 *)(local_3b0 + 0x160) = 0x406fe00000000000;
    *(undefined8 *)(local_3b0 + 0x168) = 0x406fe00000000000;
    *(undefined8 *)(local_3b0 + 0x170) = 0x406fe00000000000;
    *(undefined8 *)(local_3b0 + 0x178) = 0;
  }
  else {
    FUN_1800090b0(&local_340);
    local_3f7 = true;
    local_1d0[0] = 0;
    local_1d0[1] = 0;
    local_1d0[2] = 0;
    local_1d0[3] = 0;
    FUN_18000c1d0(local_1d0,"waitForShot",0xb);
    extractBall(this,pSVar6,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                local_1d0,local_3b8,&local_3f7);
    FUN_18000c8d0(local_1d0);
    FUN_1800090b0(&local_348);
    plVar10 = FUN_1800014c0();
    puVar11 = FUN_180084840(local_e8,(local_348 - local_340) / 1000000);
    plVar12 = FUN_180007680(puVar11,0,"Times to extract ball: ",0x17);
    local_270 = *plVar12;
    lStack_268 = plVar12[1];
    local_260 = plVar12[2];
    lStack_258 = plVar12[3];
    plVar12[3] = 0xf;
    plVar12[2] = 0;
    *(undefined1 *)plVar12 = 0;
    plVar12 = FUN_18000a490(&local_270,&DAT_180175efc,4);
    local_2f0 = *plVar12;
    lStack_2e8 = plVar12[1];
    local_2e0 = plVar12[2];
    lStack_2d8 = plVar12[3];
    plVar12[2] = 0;
    plVar12[3] = 0xf;
    *(undefined1 *)plVar12 = 0;
    uVar18 = uVar5 | 0x78;
    local_3f0 = uVar18;
    FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2f0,0,'\x01');
    FUN_18000c8d0(&local_270);
    FUN_18000c8d0(local_e8);
    pSVar17 = local_3e8;
    if ((*(longlong *)(local_3e8 + 0x58) == *(longlong *)(local_3e8 + 0x60)) ||
       (*(longlong *)(local_3e8 + 0x178) == *(longlong *)(local_3e8 + 0x180))) {
      if (bVar7) {
        replaceFirstFrames(this,local_3b8);
        local_3f6[0] = true;
        local_1b0[0] = 0;
        local_1b0[1] = 0;
        local_1b0[2] = 0;
        local_1b0[3] = 0;
        FUN_18000c1d0(local_1b0,"waitForShot",0xb);
        extractBall(this,local_3b0,
                    (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    local_1b0,local_3b8,local_3f6);
        FUN_18000c8d0(local_1b0);
        goto LAB_1800db478;
      }
      if (*(longlong *)(local_3e8 + 0x58) == *(longlong *)(local_3e8 + 0x60)) goto LAB_1800dbaa6;
    }
    if (*(longlong *)(local_3e8 + 0x178) == *(longlong *)(local_3e8 + 0x180)) {
LAB_1800dbaa6:
      *(undefined4 *)(this + 0x5a0) = DAT_1801d1200;
      *(undefined4 *)(this + 0x5a4) = DAT_1801d1204;
      *(undefined4 *)(this + 0x5b0) = DAT_1801d1200;
      *(undefined4 *)(this + 0x5b4) = DAT_1801d1204;
      FUN_1800633a0((longlong *)&local_88);
      *(ulonglong *)(this + 0x5a8) = CONCAT44(uStack_84,local_88);
      FUN_1800633a0(&local_3e0);
      *(longlong *)(this + 0x5b8) = local_3e0;
      LOCK();
      this[0x28b] = (Interface)0x0;
      UNLOCK();
      OnCameraStateChanged(this,2);
      return false;
    }
  }
LAB_1800db478:
  this[0x31c] = (Interface)param_3;
  getCameraCapture_ROI(this,(Rect_<int> *)&local_68);
  getCameraCapture_ROI(this,(Rect_<int> *)&local_58);
  if (bVar7) {
LAB_1800db514:
    bVar8 = false;
  }
  else {
    local_190[0] = 0;
    local_190[1] = 0;
    local_190[2] = 0;
    local_190[3] = 0;
    FUN_18000c1d0(local_190,"Camera1",7);
    uVar18 = uVar18 | 2;
    local_3f0 = uVar18;
    bVar8 = validateCameraCapture_ROI
                      (this,(Rect_<int> *)(pSVar17 + 0x28),(Rect_<int> *)&local_68,
                       (Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_190);
    if (bVar8) goto LAB_1800db514;
    bVar8 = true;
  }
  if ((uVar18 & 2) != 0) {
    uVar18 = uVar18 & 0xfffffffd;
    local_3f0 = uVar18;
    FUN_18000c8d0(local_190);
  }
  if (bVar8) {
    LOCK();
    this[0x28b] = (Interface)0x0;
    UNLOCK();
    plVar10 = FUN_1800014c0();
    pcVar16 = "Ball Out of Bound on cam 1 !!";
    goto LAB_1800db54b;
  }
  if (bVar7) {
LAB_1800db5ff:
    bVar8 = false;
  }
  else {
    local_170[0] = 0;
    local_170[1] = 0;
    local_170[2] = 0;
    local_170[3] = 0;
    FUN_18000c1d0(local_170,"Camera2",7);
    uVar18 = uVar18 | 4;
    local_3f0 = uVar18;
    bVar8 = validateCameraCapture_ROI
                      (this,(Rect_<int> *)(pSVar17 + 0x148),(Rect_<int> *)&local_58,
                       (Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_170);
    if (bVar8) goto LAB_1800db5ff;
    bVar8 = true;
  }
  if ((uVar18 & 4) != 0) {
    local_3f0 = uVar18 & 0xfffffffb;
    FUN_18000c8d0(local_170);
  }
  if (bVar8) {
    LOCK();
    this[0x28b] = (Interface)0x0;
    UNLOCK();
    plVar10 = FUN_1800014c0();
    pcVar16 = "Ball Out of Bound on cam 2 !!";
LAB_1800db54b:
    local_3c0 = 0;
    local_3c8 = 0;
    local_3d8 = 0;
    uStack_3d0 = 0;
    FUN_18000c1d0(&local_3d8,pcVar16,0x1d);
    FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_3d8,1,'\x01');
    OnCameraStateChanged(this,2);
    return false;
  }
  FUN_1800090b0(&local_330);
  local_80 = (void *)0x0;
  local_78 = (void *)0x0;
  LOCK();
  this[0x28c] = (Interface)0x0;
  UNLOCK();
  local_138 = local_58;
  uStack_130 = uStack_50;
  local_148 = local_68;
  uStack_140 = uStack_60;
  lVar13 = startMultiFramesCameraProcess(this,local_2f8,pSVar17,&local_148);
  cVar1 = *(char *)(lVar13 + 4);
  FUN_1800090b0(&local_338);
  plVar10 = FUN_1800014c0();
  puVar11 = FUN_180084840(local_c8,(local_338 - local_330) / 1000000);
  plVar12 = FUN_180007680(puVar11,0,"Time to start camera in high-speed >>  ",0x27);
  uVar5 = local_3f0;
  local_250 = *plVar12;
  lStack_248 = plVar12[1];
  local_240 = plVar12[2];
  lStack_238 = plVar12[3];
  plVar12[3] = 0xf;
  plVar12[2] = 0;
  *(undefined1 *)plVar12 = 0;
  plVar12 = FUN_18000a490(&local_250,&DAT_180175e94,3);
  local_2d0 = *plVar12;
  lStack_2c8 = plVar12[1];
  local_2c0 = plVar12[2];
  lStack_2b8 = plVar12[3];
  plVar12[2] = 0;
  plVar12[3] = 0xf;
  *(undefined1 *)plVar12 = 0;
  local_3f0 = uVar5 | 0x180;
  FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2d0,1,'\x01');
  FUN_18000c8d0(&local_250);
  FUN_18000c8d0(local_c8);
  pSVar6 = local_3b0;
  if (cVar1 == '\0') {
    plVar10 = FUN_1800014c0();
    local_3d8 = 0;
    uStack_3d0 = 0;
    local_3c8 = 0;
    local_3c0 = 0;
    FUN_18000c1d0(&local_3d8,"WaitForShot >> Unable to start multiframe",0x29);
    FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_3d8,3,'\x01');
    LOCK();
    this[0x28a] = (Interface)0x1;
    UNLOCK();
    LOCK();
    this[0x28b] = (Interface)0x0;
    UNLOCK();
    LOCK();
    this[0x28c] = (Interface)0x0;
    UNLOCK();
    startSingleFrameCamera(this);
    if (((char)uStack_84 == '\0') && (local_88 == 2)) {
      OnCameraStateChanged(this,2);
    }
  }
  else {
    LOCK();
    this[0x28b] = (Interface)0x1;
    UNLOCK();
    getOffsetBall(this,(Shot *)&local_388);
    local_128 = (double)local_388;
    dStack_120 = (double)local_384;
    local_118 = (double)local_380;
    auVar2._4_8_ = dStack_120;
    auVar2._0_4_ = local_308._4_4_;
    auVar20._0_8_ = auVar2._0_8_ << 0x20;
    auVar20._8_4_ = (undefined4)uStack_300;
    auVar20._12_4_ = uStack_300._4_4_;
    uStack_300 = auVar20._8_8_;
    local_308 = local_118;
    uStack_110 = uStack_300;
    OnCameraStateChanged(this,4,&local_128);
    plVar10 = FUN_1800014c0();
    local_318 = 0;
    uStack_310 = 0;
    local_308 = 0.0;
    uStack_300 = 0;
    FUN_18000c1d0(&local_318,
                  "***************************************************** Wait for a shot !!! *****************************************************"
                  ,0x7f);
    FUN_180084c00(plVar10,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_318,1,'\x01');
    *(undefined4 *)(this + 0x5a0) = DAT_1801d1200;
    *(undefined4 *)(this + 0x5a4) = DAT_1801d1204;
    *(undefined4 *)(this + 0x5b0) = DAT_1801d1200;
    *(undefined4 *)(this + 0x5b4) = DAT_1801d1204;
    FUN_1800633a0(&local_328);
    *(longlong *)(this + 0x5a8) = local_328;
    FUN_1800633a0(&local_320);
    *(longlong *)(this + 0x5b8) = local_320;
    LOCK();
    this[0x28c] = (Interface)0x1;
    UNLOCK();
    if (!bVar7) {
      bVar8 = true;
      goto LAB_1800dba57;
    }
    plVar10 = FUN_1800014c0();
    uStack_370 = 0;
    local_368 = _DAT_18017ef00;
    uStack_360 = _UNK_18017ef08;
    local_378 = (undefined8 *******)0x0;
    local_3f0 = local_3f0 | 0x200;
    if (*(int *)(this + 0x6f8) == 2) {
      pcVar16 = "left";
      sVar14 = 4;
    }
    else if (*(int *)(this + 0x6f8) == 1) {
      pcVar16 = "right";
      sVar14 = 5;
    }
    else {
      pcVar16 = "unknown";
      sVar14 = 7;
    }
    FUN_18000a490((longlong *)&local_378,pcVar16,sVar14);
    pppppppuVar19 = &local_378;
    if (0xf < uStack_360) {
      pppppppuVar19 = local_378;
    }
    pbVar15 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(local_a8,"[Wait for shot] Player hand set to : %s",pppppppuVar19);
    FUN_180084c00(plVar10,pbVar15,1,'\x01');
    FUN_18000c8d0((longlong *)&local_378);
    IVar9 = (Interface)validBallDetectionAnalysis(this,pSVar6);
    LOCK();
    this[0x900] = IVar9;
    UNLOCK();
    LOCK();
    this[0x28a] = (Interface)0x1;
    UNLOCK();
    LOCK();
    this[0x28b] = (Interface)0x0;
    UNLOCK();
    LOCK();
    this[0x28c] = (Interface)0x0;
    UNLOCK();
    resumeCameraAcquisition(this);
  }
  bVar8 = false;
LAB_1800dba57:
  if (local_78 != (void *)0x0) {
    if (*(int *)((longlong)local_78 + 8) != 0) {
                    /* WARNING: Subroutine does not return */
      terminate();
    }
    free(local_78);
  }
  if (local_80 != (void *)0x0) {
    if (*(int *)((longlong)local_80 + 8) != 0) {
                    /* WARNING: Subroutine does not return */
      terminate();
    }
    free(local_80);
    return bVar8;
  }
  return bVar8;
}

