FUNCTION: GolfIn::Interface::ballHasMoveEnough
ENTRY: 1800ec8f0
REASONS: name:ballHasMoveEnough


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001800ee053) */
/* WARNING: Removing unreachable block (ram,0x0001800ee040) */
/* WARNING: Removing unreachable block (ram,0x0001800ee06a) */
/* WARNING: Removing unreachable block (ram,0x0001800ee080) */
/* WARNING: Removing unreachable block (ram,0x0001800ee029) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: bool __cdecl GolfIn::Interface::ballHasMoveEnough(class std::map<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,class
   Libraries::CamerasCore::Frame,struct std::less<class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > >,class std::allocator<struct std::pair<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const ,class
   Libraries::CamerasCore::Frame> > > const * __ptr64) __ptr64 */

bool __thiscall
GolfIn::Interface::ballHasMoveEnough
          (Interface *this,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_1)

{
  int *piVar1;
  int iVar2;
  char cVar3;
  bool bVar4;
  undefined8 uVar5;
  Mat *pMVar6;
  undefined8 *puVar7;
  undefined8 *puVar8;
  bool bVar9;
  undefined4 uVar10;
  longlong *plVar11;
  longlong *plVar12;
  undefined8 *puVar13;
  undefined8 *puVar14;
  float *pfVar15;
  undefined1 (*pauVar16) [16];
  undefined8 *puVar17;
  void *pvVar18;
  longlong lVar19;
  char *pcVar20;
  undefined *puVar21;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar22;
  uint uVar23;
  undefined8 *puVar24;
  uint uVar25;
  vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *pvVar26;
  int iVar27;
  float fVar28;
  float fVar29;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *local_res10;
  undefined1 auStackY_688 [32];
  longlong local_630;
  undefined8 local_628;
  ulonglong local_620;
  undefined8 uStack_618;
  undefined8 local_610;
  undefined8 uStack_608;
  longlong local_600;
  longlong lStack_5f8;
  longlong local_5f0;
  longlong lStack_5e8;
  longlong local_5e0;
  longlong lStack_5d8;
  longlong local_5d0;
  longlong lStack_5c8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_5c0 [16];
  undefined8 local_5b0;
  undefined8 uStack_5a8;
  undefined8 local_5a0;
  longlong local_598;
  undefined8 uStack_590;
  undefined8 local_588;
  undefined8 uStack_580;
  uint local_578;
  undefined4 uStack_574;
  undefined8 uStack_570;
  float local_568;
  uint uStack_564;
  longlong local_560;
  longlong lStack_558;
  longlong local_550;
  longlong lStack_548;
  uint local_540;
  undefined4 uStack_53c;
  undefined8 uStack_538;
  float local_530;
  uint uStack_52c;
  longlong local_528;
  longlong lStack_520;
  longlong local_518;
  longlong lStack_510;
  longlong local_508;
  longlong lStack_500;
  longlong local_4f8;
  longlong lStack_4f0;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  **local_4e8;
  Interface *pIStack_4e0;
  uint *local_4d8;
  undefined8 *puStack_4d0;
  float *local_4c8;
  int *piStack_4c0;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  **local_4b8;
  Interface *local_4b0;
  uint *local_4a8;
  undefined8 *local_4a0;
  float *local_498;
  int *local_490;
  ulonglong local_488;
  undefined8 uStack_480;
  undefined8 local_478;
  undefined8 uStack_470;
  longlong local_468 [4];
  longlong local_448 [4];
  longlong local_428 [4];
  longlong local_408 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_3e8 [32];
  longlong local_3c8 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_3a8 [32];
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  **local_388;
  Interface *pIStack_380;
  uint *local_378;
  undefined8 *puStack_370;
  float *local_368;
  int *piStack_360;
  longlong local_358 [4];
  longlong local_338 [4];
  longlong local_318 [20];
  uint local_278 [2];
  float local_270;
  float fStack_26c;
  float local_268;
  float local_260;
  float fStack_25c;
  float local_258;
  ulonglong local_250;
  void *local_248;
  longlong *plStack_240;
  longlong *local_238;
  longlong lStack_230;
  undefined8 local_228;
  float local_220;
  undefined8 local_218;
  float local_210;
  int local_208;
  int local_204;
  undefined8 *local_200;
  undefined8 *puStack_1f8;
  undefined8 *local_1f0;
  undefined8 *local_1e8;
  undefined8 *puStack_1e0;
  undefined8 *local_1d8;
  undefined8 *local_1d0;
  undefined8 uStack_1c8;
  undefined8 *local_1c0;
  undefined8 uStack_1b8;
  longlong local_1b0;
  longlong lStack_1a8;
  undefined8 local_1a0;
  void *local_198;
  longlong *plStack_190;
  longlong *local_188;
  void *local_180;
  undefined8 *puStack_178;
  undefined8 *local_170;
  undefined8 *local_168;
  ulonglong uStack_160;
  ulonglong local_158;
  undefined8 *local_150;
  ulonglong uStack_148;
  ulonglong local_140;
  undefined8 local_138;
  undefined8 uStack_130;
  undefined8 local_128;
  undefined8 uStack_120;
  undefined8 local_118;
  undefined8 uStack_110;
  undefined8 local_108;
  undefined8 uStack_100;
  undefined8 local_f8;
  undefined8 uStack_f0;
  undefined8 local_e8;
  undefined8 uStack_e0;
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  undefined8 uStack_c0;
  undefined8 local_b8;
  undefined8 uStack_b0;
  undefined8 local_a8;
  undefined8 uStack_a0;
  undefined8 local_98;
  undefined8 uStack_90;
  undefined8 local_88;
  undefined8 uStack_80;
  undefined1 local_64;
  undefined1 local_63 [3];
  ulonglong local_60;
  
                    /* 0xec8f0  413
                       ?ballHasMoveEnough@Interface@GolfIn@@IEAA_NPEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@std@@@Z
                        */
  local_60 = DAT_1801d1040 ^ (ulonglong)auStackY_688;
  if ((param_1 ==
       (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
        *)0x0) || (*(longlong *)(param_1 + 8) == 0)) {
    return false;
  }
  local_res10 = param_1;
  fVar28 = getCalibrationPPMM(this,false);
  fVar29 = 0.0;
  if (fVar28 <= 0.0) {
    plVar11 = FUN_1800014c0();
    local_620 = 0;
    uStack_618 = 0;
    local_610 = 0;
    uStack_608 = 0;
    FUN_18000c1d0(&local_620,"[Ball.Has.MoveEnough] Calibration not done or wrong, ppmm <= 0.0f",
                  0x41);
    FUN_180084c00(plVar11,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_620,3,'\x01');
    return false;
  }
  local_5c0._0_12_ = ZEXT812(0);
  local_5c0._12_4_ = 0;
  local_5b0 = 0;
  uStack_5a8 = 0;
  FUN_18000c1d0((undefined8 *)local_5c0,"Camera1",7);
  plVar11 = FUN_1800f7eb0((longlong *)(this + 0x2c8),(longlong *)local_5c0);
  puVar13 = *(undefined8 **)local_res10;
  cVar3 = *(char *)((longlong)puVar13[1] + 0x19);
  puVar14 = puVar13;
  puVar17 = (undefined8 *)puVar13[1];
  while (cVar3 == '\0') {
    uVar10 = FUN_180008ca0(puVar17 + 4,plVar11);
    if ((char)uVar10 < '\0') {
      puVar24 = (undefined8 *)puVar17[2];
      puVar17 = puVar14;
    }
    else {
      puVar24 = (undefined8 *)*puVar17;
    }
    puVar14 = puVar17;
    puVar17 = puVar24;
    cVar3 = *(char *)((longlong)puVar24 + 0x19);
  }
  if ((*(char *)((longlong)puVar14 + 0x19) != '\0') ||
     (uVar10 = FUN_180008ca0(plVar11,puVar14 + 4), (char)uVar10 < '\0')) {
    puVar14 = puVar13;
  }
  lVar19 = (longlong)(puVar14[10] - puVar14[9]) / 6 + ((longlong)(puVar14[10] - puVar14[9]) >> 0x3f)
  ;
  local_630 = (lVar19 >> 4) - (lVar19 >> 0x3f);
  FUN_18000c8d0((longlong *)local_5c0);
  local_508 = 0;
  lStack_500 = 0;
  local_4f8 = 0;
  lStack_4f0 = 0;
  FUN_18000c1d0(&local_508,"Camera2",7);
  plVar11 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_508);
  puVar13 = *(undefined8 **)local_res10;
  cVar3 = *(char *)((longlong)puVar13[1] + 0x19);
  puVar14 = puVar13;
  puVar17 = (undefined8 *)puVar13[1];
  while (cVar3 == '\0') {
    uVar10 = FUN_180008ca0(puVar17 + 4,plVar11);
    if ((char)uVar10 < '\0') {
      puVar24 = (undefined8 *)puVar17[2];
      puVar17 = puVar14;
    }
    else {
      puVar24 = (undefined8 *)*puVar17;
    }
    puVar14 = puVar17;
    puVar17 = puVar24;
    cVar3 = *(char *)((longlong)puVar24 + 0x19);
  }
  if ((*(char *)((longlong)puVar14 + 0x19) != '\0') ||
     (uVar10 = FUN_180008ca0(plVar11,puVar14 + 4), (char)uVar10 < '\0')) {
    puVar14 = puVar13;
  }
  lVar19 = (longlong)(puVar14[10] - puVar14[9]) / 6 + ((longlong)(puVar14[10] - puVar14[9]) >> 0x3f)
  ;
  iVar27 = (int)local_630;
  FUN_18000c8d0(&local_508);
  if ((longlong)iVar27 != (lVar19 >> 4) - (lVar19 >> 0x3f)) {
    plVar11 = FUN_1800014c0();
    local_598 = 0;
    uStack_590 = 0;
    local_588 = 0;
    uStack_580 = 0;
    FUN_18000c1d0(&local_598,"Camera2",7);
    plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_598);
    puVar13 = *(undefined8 **)local_res10;
    cVar3 = *(char *)((longlong)puVar13[1] + 0x19);
    puVar14 = puVar13;
    puVar17 = (undefined8 *)puVar13[1];
    while (cVar3 == '\0') {
      uVar10 = FUN_180008ca0(puVar17 + 4,plVar12);
      if ((char)uVar10 < '\0') {
        puVar24 = (undefined8 *)puVar17[2];
        puVar17 = puVar14;
      }
      else {
        puVar24 = (undefined8 *)*puVar17;
      }
      puVar14 = puVar17;
      puVar17 = puVar24;
      cVar3 = *(char *)((longlong)puVar24 + 0x19);
    }
    if ((*(char *)((longlong)puVar14 + 0x19) != '\0') ||
       (uVar10 = FUN_180008ca0(plVar12,puVar14 + 4), (char)uVar10 < '\0')) {
      puVar14 = puVar13;
    }
    puVar13 = FUN_180116e70(local_338,(longlong)(puVar14[10] - puVar14[9]) / 0x60);
    puVar14 = FUN_18000c2d0(local_318,(uint)local_630);
    plVar12 = FUN_180007680(puVar14,0,
                            "[Ball.Has.MoveEnough] Buffer size of camera 1 and camera 2 are not the same. Cam 1: "
                            ,0x54);
    local_528 = *plVar12;
    lStack_520 = plVar12[1];
    local_518 = plVar12[2];
    lStack_510 = plVar12[3];
    plVar12[3] = 0xf;
    plVar12[2] = 0;
    *(undefined1 *)plVar12 = 0;
    pcVar20 = " Cam 2: ";
    plVar12 = FUN_18000a490(&local_528," Cam 2: ",8);
    local_5e0 = *plVar12;
    lStack_5d8 = plVar12[1];
    local_5d0 = plVar12[2];
    lStack_5c8 = plVar12[3];
    plVar12[2] = 0;
    plVar12[3] = 0xf;
    *(undefined1 *)plVar12 = 0;
    FUN_1800228c0((undefined8 *)local_3a8,pcVar20,&local_5e0,puVar13);
    FUN_180084c00(plVar11,local_3a8,3,'\x01');
    FUN_18000c8d0(&local_5e0);
    FUN_18000c8d0(&local_528);
    FUN_18000c8d0(local_318);
    FUN_18000c8d0(local_338);
    FUN_18000c8d0(&local_598);
    return false;
  }
  local_278[0] = (iVar27 + -0x46) / 0x3c;
  local_d8 = 0;
  uStack_d0 = 0;
  local_c8 = 0;
  uStack_c0 = 0;
  local_b8 = 0;
  uStack_b0 = 0;
  local_a8 = 0;
  uStack_a0 = 0;
  local_98 = 0;
  uStack_90 = 0;
  local_88 = 0;
  uStack_80 = 0;
  cv::Mat::Mat((Mat *)&local_d8);
  local_138 = 0;
  uStack_130 = 0;
  local_128 = 0;
  uStack_120 = 0;
  local_118 = 0;
  uStack_110 = 0;
  local_108 = 0;
  uStack_100 = 0;
  local_f8 = 0;
  uStack_f0 = 0;
  local_e8 = 0;
  uStack_e0 = 0;
  cv::Mat::Mat((Mat *)&local_138);
  local_204 = 0;
  local_208 = 0;
  local_228 = CONCAT44(DAT_1801d120c,DAT_1801d1208);
  local_210 = DAT_1801d1210;
  local_220 = DAT_1801d1210;
  local_598 = 0;
  uStack_590 = 0;
  local_588 = 0;
  uStack_580 = 0;
  local_218 = local_228;
  FUN_18000c1d0(&local_598,"Camera1",7);
  plVar11 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_598);
  puVar13 = *(undefined8 **)local_res10;
  cVar3 = *(char *)((longlong)puVar13[1] + 0x19);
  puVar14 = puVar13;
  puVar17 = (undefined8 *)puVar13[1];
  while (cVar3 == '\0') {
    uVar10 = FUN_180008ca0(puVar17 + 4,plVar11);
    if ((char)uVar10 < '\0') {
      puVar24 = (undefined8 *)puVar17[2];
      puVar17 = puVar14;
    }
    else {
      puVar24 = (undefined8 *)*puVar17;
    }
    puVar14 = puVar17;
    puVar17 = puVar24;
    cVar3 = *(char *)((longlong)puVar24 + 0x19);
  }
  if ((*(char *)((longlong)puVar14 + 0x19) != '\0') ||
     (uVar10 = FUN_180008ca0(plVar11,puVar14 + 4), (char)uVar10 < '\0')) {
    puVar14 = puVar13;
  }
  if ((ulonglong)((longlong)(puVar14[10] - puVar14[9]) / 0x60) < 3) {
                    /* WARNING: Subroutine does not return */
    FUN_180006690();
  }
  local_628 = (Mat *)(puVar14[9] + 0xc0);
  FUN_18000c8d0(&local_598);
  local_600 = 0;
  lStack_5f8 = 0;
  local_5f0 = 0;
  lStack_5e8 = 0;
  FUN_18000c1d0(&local_600,"Camera2",7);
  plVar11 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_600);
  puVar13 = *(undefined8 **)local_res10;
  cVar3 = *(char *)((longlong)puVar13[1] + 0x19);
  puVar14 = puVar13;
  puVar17 = (undefined8 *)puVar13[1];
  while (cVar3 == '\0') {
    uVar10 = FUN_180008ca0(puVar17 + 4,plVar11);
    if ((char)uVar10 < '\0') {
      puVar24 = (undefined8 *)puVar17[2];
      puVar17 = puVar14;
    }
    else {
      puVar24 = (undefined8 *)*puVar17;
    }
    puVar14 = puVar17;
    puVar17 = puVar24;
    cVar3 = *(char *)((longlong)puVar24 + 0x19);
  }
  if ((*(char *)((longlong)puVar14 + 0x19) != '\0') ||
     (uVar10 = FUN_180008ca0(plVar11,puVar14 + 4), (char)uVar10 < '\0')) {
    puVar14 = puVar13;
  }
  lVar19 = puVar14[9];
  if ((ulonglong)((puVar14[10] - lVar19) / 0x60) < 3) {
                    /* WARNING: Subroutine does not return */
    FUN_180006690();
  }
  FUN_18000c8d0(&local_600);
  local_620 = 0;
  uStack_618 = 0;
  local_610 = 0;
  uStack_608 = 0;
  FUN_18000c1d0(&local_620,"Camera1",7);
  local_528 = 0;
  lStack_520 = 0;
  local_518 = 0;
  lStack_510 = 0;
  FUN_18000c1d0(&local_528,"ballHasMoveEnough",0x11);
  pMVar6 = local_628;
  extractBallByImage_Segmentation
            (this,local_628,(Point3_<float> *)&DAT_1801d1208,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &local_528,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &local_620,2,(Point3_<float> *)&local_218,&local_204,false);
  FUN_18000c8d0(&local_528);
  FUN_18000c8d0((longlong *)&local_620);
  local_248 = (void *)0x0;
  plStack_240 = (longlong *)0x0;
  local_238 = (longlong *)0x0;
  lStack_230 = 0;
  FUN_18000c1d0(&local_248,"Camera2",7);
  local_5e0 = 0;
  lStack_5d8 = 0;
  local_5d0 = 0;
  lStack_5c8 = 0;
  FUN_18000c1d0(&local_5e0,"ballHasMoveEnough",0x11);
  extractBallByImage_Segmentation
            (this,(Mat *)(lVar19 + 0xc0),(Point3_<float> *)&DAT_1801d1208,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &local_5e0,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &local_248,2,(Point3_<float> *)&local_228,&local_208,false);
  FUN_18000c8d0(&local_5e0);
  FUN_18000c8d0((longlong *)&local_248);
  uVar23 = local_278[0];
  local_200 = (undefined8 *)0x0;
  puStack_1f8 = (undefined8 *)0x0;
  puVar14 = (undefined8 *)0x0;
  local_1f0 = (undefined8 *)0x0;
  local_1e8 = (undefined8 *)0x0;
  puStack_1e0 = (undefined8 *)0x0;
  local_1d8 = (undefined8 *)0x0;
  local_278[0] = local_278[0] * -4 + 0x46;
  puVar13 = (undefined8 *)(ulonglong)local_278[0];
  iVar27 = (int)local_630;
  local_260 = (float)local_218;
  fStack_25c = local_218._4_4_;
  local_258 = local_210;
  local_270 = (float)local_228;
  fStack_26c = local_228._4_4_;
  local_268 = local_220;
  for (; (int)local_278[0] < iVar27; local_278[0] = local_278[0] + uVar23) {
    local_1d0 = (undefined8 *)0x0;
    uStack_1c8 = 0;
    local_168 = (undefined8 *)0x0;
    uStack_160 = 0;
    local_158 = 0;
    local_4b8 = &local_res10;
    local_4a8 = local_278;
    local_4a0 = &local_218;
    local_498 = &local_260;
    local_490 = &local_204;
    local_4b0 = this;
    puVar13 = FUN_1800fd0c0(puVar13,&local_4b8);
    uStack_160 = uStack_160 & 0xffffffffffffff00;
    local_158 = local_158 & 0xffffffffffffff00;
    local_168 = puVar13;
    if (puVar13 == (undefined8 *)0x0) {
                    /* WARNING: Subroutine does not return */
      FUN_180009ac0(4);
    }
    uStack_1c8 = CONCAT71(uStack_1c8._1_7_,1);
    LOCK();
    *(int *)(puVar13 + 1) = *(int *)(puVar13 + 1) + 1;
    UNLOCK();
    LOCK();
    piVar1 = (int *)(puVar13 + 1);
    iVar2 = *piVar1;
    *piVar1 = *piVar1 + -1;
    UNLOCK();
    local_1d0 = puVar13;
    if (iVar2 == 1) {
      puVar17 = (undefined8 *)puVar13[0x19];
      if (puVar17 == (undefined8 *)0x0) {
        (**(code **)*puVar13)(puVar13,1);
      }
      else {
        (**(code **)*puVar17)(puVar17,puVar13);
        puVar13 = puVar17;
      }
    }
    local_1c0 = (undefined8 *)0x0;
    uStack_1b8 = 0;
    local_4e8 = &local_res10;
    local_4d8 = local_278;
    puStack_4d0 = &local_228;
    local_4c8 = &local_270;
    piStack_4c0 = &local_208;
    local_150 = (undefined8 *)0x0;
    uStack_148 = 0;
    local_140 = 0;
    pIStack_4e0 = this;
    local_388 = local_4e8;
    pIStack_380 = this;
    local_378 = local_4d8;
    puStack_370 = puStack_4d0;
    local_368 = local_4c8;
    piStack_360 = piStack_4c0;
    local_150 = FUN_1800fd240(puVar13,&local_388);
    uStack_148 = uStack_148 & 0xffffffffffffff00;
    local_140 = local_140 & 0xffffffffffffff00;
    if (local_150 == (undefined8 *)0x0) {
                    /* WARNING: Subroutine does not return */
      FUN_180009ac0(4);
    }
    uStack_1b8 = CONCAT71(uStack_1b8._1_7_,1);
    LOCK();
    *(int *)(local_150 + 1) = *(int *)(local_150 + 1) + 1;
    UNLOCK();
    LOCK();
    piVar1 = (int *)(local_150 + 1);
    iVar2 = *piVar1;
    *piVar1 = *piVar1 + -1;
    UNLOCK();
    local_1c0 = local_150;
    if (iVar2 == 1) {
      puVar13 = (undefined8 *)local_150[0x19];
      if (puVar13 == (undefined8 *)0x0) {
        (**(code **)*local_150)(local_150,1);
      }
      else {
        (**(code **)*puVar13)(puVar13,local_150);
      }
    }
    FUN_180084940((longlong *)&local_1d0);
    FUN_180084940((longlong *)&local_1c0);
    if ((((local_260 == DAT_1801d1208) && (fStack_25c == DAT_1801d120c)) &&
        (local_258 == DAT_1801d1210)) ||
       (((local_260 == 0.0 && (fStack_25c == 0.0)) && (local_258 == 0.0)))) {
      bVar9 = false;
    }
    else {
      bVar9 = true;
    }
    if ((((local_270 == DAT_1801d1208) && (fStack_26c == DAT_1801d120c)) &&
        (local_268 == DAT_1801d1210)) ||
       (((local_270 == 0.0 && (fStack_26c == 0.0)) && (local_268 == 0.0)))) {
      bVar4 = false;
    }
    else {
      bVar4 = true;
    }
    if ((bVar9) && (bVar4)) {
      local_628 = (Mat *)CONCAT44(*(undefined4 *)(pMVar6 + 8),*(undefined4 *)(pMVar6 + 0xc));
      bVar9 = isBallInUnsafeReadingZone
                        (this,(Size_<int> *)&local_628,(Point3_<float> *)&local_260,
                         (Point3_<float> *)&local_270);
      if (bVar9) {
        if (local_1c0 != (undefined8 *)0x0) {
          LOCK();
          piVar1 = (int *)(local_1c0 + 1);
          iVar27 = *piVar1;
          *piVar1 = *piVar1 + -1;
          UNLOCK();
          if (iVar27 == 1) {
            puVar13 = (undefined8 *)local_1c0[0x19];
            if (puVar13 == (undefined8 *)0x0) {
              (**(code **)*local_1c0)(local_1c0,1);
            }
            else {
              (**(code **)*puVar13)(puVar13,local_1c0);
            }
          }
        }
        if (local_1d0 != (undefined8 *)0x0) {
          LOCK();
          piVar1 = (int *)(local_1d0 + 1);
          iVar27 = *piVar1;
          *piVar1 = *piVar1 + -1;
          UNLOCK();
          if (iVar27 == 1) {
            puVar13 = (undefined8 *)local_1d0[0x19];
            if (puVar13 == (undefined8 *)0x0) {
              (**(code **)*local_1d0)(local_1d0,1);
            }
            else {
              (**(code **)*puVar13)(puVar13,local_1d0);
            }
          }
        }
        break;
      }
      local_578 = local_278[0];
      uStack_574 = 0xffffffff;
      uStack_570 = CONCAT44(fStack_25c,local_260);
      local_568 = local_258;
      if (((local_260 != DAT_1801d1208) || (fStack_25c != DAT_1801d120c)) ||
         (uStack_564 = uStack_564 & 0xffffff00, local_258 != DAT_1801d1210)) {
        uStack_564 = CONCAT31(uStack_564._1_3_,1);
      }
      local_540 = local_278[0];
      uStack_53c = 0xffffffff;
      uStack_538 = CONCAT44(fStack_26c,local_270);
      local_530 = local_268;
      if (((local_270 != DAT_1801d1208) || (fStack_26c != DAT_1801d120c)) ||
         (uStack_52c = uStack_52c & 0xffffff00, local_268 != DAT_1801d1210)) {
        uStack_52c = CONCAT31(uStack_52c._1_3_,1);
      }
      if (puStack_1f8 == local_1f0) {
        FUN_1800fd3c0((longlong *)&local_200,puStack_1f8,(undefined8 *)&local_578);
      }
      else {
        *puStack_1f8 = CONCAT44(0xffffffff,local_278[0]);
        puStack_1f8[1] = uStack_570;
        puStack_1f8[2] = CONCAT44(uStack_564,local_258);
        puStack_1f8 = puStack_1f8 + 3;
      }
      if (puStack_1e0 == local_1d8) {
        FUN_1800fd3c0((longlong *)&local_1e8,puStack_1e0,(undefined8 *)&local_540);
      }
      else {
        *puStack_1e0 = CONCAT44(uStack_53c,local_540);
        puStack_1e0[1] = uStack_538;
        puStack_1e0[2] = CONCAT44(uStack_52c,local_530);
        puStack_1e0 = puStack_1e0 + 3;
      }
      local_218 = CONCAT44(fStack_25c,local_260);
      local_210 = local_258;
      local_228 = CONCAT44(fStack_26c,local_270);
      local_220 = local_268;
    }
    else {
      local_218 = CONCAT44(DAT_1801d120c,DAT_1801d1208);
      local_210 = DAT_1801d1210;
      local_228 = CONCAT44(DAT_1801d120c,DAT_1801d1208);
      local_220 = DAT_1801d1210;
    }
    local_260 = DAT_1801d1208;
    fStack_25c = DAT_1801d120c;
    local_258 = DAT_1801d1210;
    local_270 = DAT_1801d1208;
    fStack_26c = DAT_1801d120c;
    local_268 = DAT_1801d1210;
    if (local_1c0 != (undefined8 *)0x0) {
      LOCK();
      piVar1 = (int *)(local_1c0 + 1);
      iVar2 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar2 == 1) {
        puVar13 = (undefined8 *)local_1c0[0x19];
        if (puVar13 == (undefined8 *)0x0) {
          (**(code **)*local_1c0)(local_1c0,1);
        }
        else {
          (**(code **)*puVar13)(puVar13,local_1c0);
        }
      }
    }
    puVar13 = local_1d0;
    if (local_1d0 != (undefined8 *)0x0) {
      LOCK();
      piVar1 = (int *)(local_1d0 + 1);
      iVar2 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar2 == 1) {
        puVar13 = (undefined8 *)local_1d0[0x19];
        if (puVar13 == (undefined8 *)0x0) {
          puVar13 = local_1d0;
          (**(code **)*local_1d0)(local_1d0,1);
        }
        else {
          (**(code **)*puVar13)(puVar13,local_1d0);
        }
      }
    }
  }
  lVar19 = ((longlong)puStack_1e0 - (longlong)local_1e8) / 6 +
           ((longlong)puStack_1e0 - (longlong)local_1e8 >> 0x3f);
  uVar25 = (int)(lVar19 >> 2) - (int)(lVar19 >> 0x3f);
  lVar19 = ((longlong)puStack_1f8 - (longlong)local_200) / 6 +
           ((longlong)puStack_1f8 - (longlong)local_200 >> 0x3f);
  uVar23 = (int)(lVar19 >> 2) - (int)(lVar19 >> 0x3f);
  if ((int)uVar25 < (int)uVar23) {
    uVar23 = uVar25;
  }
  if ((int)uVar23 < 3) {
    plVar11 = FUN_1800014c0();
    local_64 = 0x32;
    local_5e0 = 0;
    lStack_5d8 = 0;
    local_5d0 = 0;
    lStack_5c8 = 0;
    if (&local_64 == local_63) {
      local_5d0 = _DAT_18017ef00;
      lStack_5c8 = _UNK_18017ef08;
      local_5e0 = 0;
    }
    else {
      FUN_18000c1d0(&local_5e0,&local_64,(size_t)(local_63 + -(longlong)&local_64));
    }
    puVar13 = FUN_18000c2d0(local_358,uVar23);
    plVar12 = FUN_180007680(puVar13,0,"[Ball.Has.MoveEnough] Insufficient data points (",0x30);
    local_600 = *plVar12;
    lStack_5f8 = plVar12[1];
    local_5f0 = plVar12[2];
    lStack_5e8 = plVar12[3];
    plVar12[3] = 0xf;
    plVar12[2] = 0;
    *(undefined1 *)plVar12 = 0;
    puVar21 = &DAT_180177800;
    plVar12 = FUN_18000a490(&local_600,&DAT_180177800,3);
    local_560 = *plVar12;
    lStack_558 = plVar12[1];
    local_550 = plVar12[2];
    lStack_548 = plVar12[3];
    plVar12[3] = 0xf;
    plVar12[2] = 0;
    *(undefined1 *)plVar12 = 0;
    FUN_1800228c0(local_3c8,puVar21,&local_560,&local_5e0);
    plVar12 = FUN_18000a490(local_3c8,") for trajectory validation. Shot will be rejected...",0x35);
    local_248 = (void *)*plVar12;
    plStack_240 = (longlong *)plVar12[1];
    local_238 = (longlong *)plVar12[2];
    lStack_230 = plVar12[3];
    plVar12[2] = 0;
    plVar12[3] = 0xf;
    *(undefined1 *)plVar12 = 0;
    FUN_180084c00(plVar11,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_248,2,'\x01');
    FUN_18000c8d0(local_3c8);
    FUN_18000c8d0(&local_560);
    FUN_18000c8d0(&local_600);
    FUN_18000c8d0(local_358);
    FUN_18000c8d0(&local_5e0);
    bVar9 = false;
  }
  else {
    bVar9 = validateMovementConsistency
                      (this,(vector<struct_GolfIn::BallModelDetection,class_std::allocator<struct_GolfIn::BallModelDetection>_>
                             *)&local_200,DAT_18017ec98,DAT_18017eac8,DAT_18017e91c);
    puVar17 = puStack_1f8;
    puVar13 = local_200;
    if (bVar9) {
      local_1b0 = 0;
      lStack_1a8 = 0;
      local_1a0 = 0;
      bVar9 = true;
      local_248 = (void *)0x0;
      plStack_240 = (longlong *)0x0;
      local_238 = (longlong *)0x0;
      local_250 = 0x10;
      FUN_180044d40((longlong *)&local_248,&local_250);
      puVar24 = puVar14;
LAB_1800edaa2:
      puVar8 = puStack_1e0;
      puVar7 = local_1e8;
      plStack_190 = plStack_240;
      if (bVar9) {
        bVar9 = false;
        puVar24 = puVar13;
      }
      else {
        if (puVar24 == puVar17) goto LAB_1800edb13;
        puVar24 = puVar24 + 3;
      }
      if (puVar24 == puVar17) goto LAB_1800edb13;
      local_630 = puVar24[1];
      lVar19 = puVar24[1];
      if (plStack_240 == local_238) {
        FUN_1800468a0((longlong *)&local_248,plStack_240,&local_630);
      }
      else {
        *plStack_240 = lVar19;
        plStack_240 = plStack_240 + 1;
        local_630 = lVar19;
      }
      goto LAB_1800edaa2;
    }
    bVar9 = false;
  }
  goto LAB_1800ee20b;
LAB_1800edb13:
  local_198 = local_248;
  local_188 = local_238;
  bVar9 = true;
  local_248 = (void *)0x0;
  plStack_240 = (undefined8 *)0x0;
  local_238 = (undefined8 *)0x0;
  local_250 = 0x10;
  FUN_180044d40((longlong *)&local_248,&local_250);
  puVar13 = puVar14;
LAB_1800edb90:
  local_170 = local_238;
  puStack_178 = plStack_240;
  local_180 = local_248;
  if (bVar9) {
    bVar9 = false;
    puVar13 = puVar7;
  }
  else {
    if (puVar13 == puVar8) goto LAB_1800edbfa;
    puVar13 = puVar13 + 3;
  }
  if (puVar13 == puVar8) goto LAB_1800edbfa;
  local_5a0 = puVar13[1];
  uVar5 = puVar13[1];
  if (plStack_240 == local_238) {
    FUN_1800468a0((longlong *)&local_248,plStack_240,&local_5a0);
  }
  else {
    *plStack_240 = uVar5;
    plStack_240 = plStack_240 + 1;
    local_5a0 = uVar5;
  }
  goto LAB_1800edb90;
LAB_1800edbfa:
  local_238 = (longlong *)0x0;
  plStack_240 = (longlong *)0x0;
  local_248 = (void *)0x0;
  pvVar26 = (vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *)
            &local_1b0;
  bVar9 = get3DRectify(this,(vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_>
                             *)&local_198,
                       (vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_>
                        *)&local_180,pvVar26);
  if (bVar9) {
    if ((local_1b0 == lStack_1a8) || ((ulonglong)((lStack_1a8 - local_1b0) / 0xc) < 3)) {
      plVar11 = FUN_1800014c0();
      local_5c0 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                    [16])ZEXT816(0);
      local_5b0 = 0;
      uStack_5a8 = 0;
      FUN_18000c1d0((undefined8 *)local_5c0,
                    "[Ball.Has.MoveEnough] Insufficient data points for trajectory validation. Shot will be rejected..."
                    ,0x62);
      pbVar22 = local_5c0;
      goto LAB_1800ee129;
    }
    local_598 = 0;
    uStack_590 = 0;
    local_588 = 0;
    uStack_580 = 0;
    FUN_18000c1d0(&local_598,"DIRECTION",9);
    pbVar22 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_598;
    fVar28 = getAngleFromVector(this,(vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_>
                                      *)&local_1b0,pbVar22);
    FUN_18000c8d0(&local_598);
    if (DAT_18017ec64 < (float)((uint)fVar28 & DAT_18017f110)) {
      plVar11 = FUN_1800014c0();
      FUN_18006a0d0(local_428,DAT_18017eb78,pbVar22,pvVar26);
      FUN_18006a0d0(local_408,(double)fVar28,pbVar22,pvVar26);
      plVar12 = FUN_180007680(local_408,0,
                              "[Ball.Has.MoveEnough] Ball launch direction is too high. Approx calculated ball launch dir angle: "
                              ,0x62);
      local_508 = *plVar12;
      lStack_500 = plVar12[1];
      local_4f8 = plVar12[2];
      lStack_4f0 = plVar12[3];
      plVar12[3] = 0xf;
      plVar12[2] = 0;
      *(undefined1 *)plVar12 = 0;
      pcVar20 = " > Max ball launch dir: ";
      plVar12 = FUN_18000a490(&local_508," > Max ball launch dir: ",0x18);
      local_560 = *plVar12;
      lStack_558 = plVar12[1];
      local_550 = plVar12[2];
      lStack_548 = plVar12[3];
      plVar12[2] = 0;
      plVar12[3] = 0xf;
      *(undefined1 *)plVar12 = 0;
      FUN_1800228c0((undefined8 *)local_3e8,pcVar20,&local_560,local_428);
      FUN_180084c00(plVar11,local_3e8,3,'\x01');
      FUN_18000c8d0(&local_560);
      FUN_18000c8d0(&local_508);
      FUN_18000c8d0(local_408);
      FUN_18000c8d0(local_428);
      goto LAB_1800ee13a;
    }
    fVar28 = 0.0;
    lVar19 = (lStack_1a8 - local_1b0) / 0xc;
    if (lVar19 != 1) {
      pfVar15 = (float *)(local_1b0 + 0x14);
      do {
        fVar29 = fVar29 + (pfVar15[-2] - pfVar15[-5]);
        fVar28 = fVar28 + (*pfVar15 - pfVar15[-3]);
        puVar14 = (undefined8 *)((longlong)puVar14 + 1);
        pfVar15 = pfVar15 + 3;
      } while (puVar14 < (undefined8 *)(lVar19 + -1));
    }
    if ((fVar29 <= *(float *)this * _DAT_18017ec0c) && (fVar28 <= *(float *)this * DAT_18017ebe8)) {
      lVar19 = local_1b0;
      plVar11 = FUN_1800014c0();
      FUN_18006a0d0(local_468,DAT_18017eb10,puVar14,lVar19);
      FUN_18006a0d0(local_448,(double)(fVar29 / *(float *)this),puVar14,lVar19);
      pauVar16 = (undefined1 (*) [16])
                 FUN_180007680(local_448,0,
                               "[Ball.Has.MoveEnough] Ball has move too short in distance (inches): "
                               ,0x44);
      local_5c0 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                    (*) [16])pauVar16;
      local_5b0 = *(undefined8 *)pauVar16[1];
      uStack_5a8 = *(undefined8 *)(pauVar16[1] + 8);
      *(undefined8 *)(pauVar16[1] + 8) = 0xf;
      *(undefined8 *)pauVar16[1] = 0;
      (*pauVar16)[0] = 0;
      puVar21 = &DAT_180177800;
      plVar12 = FUN_18000a490((longlong *)local_5c0,&DAT_180177800,3);
      local_560 = *plVar12;
      lStack_558 = plVar12[1];
      local_550 = plVar12[2];
      lStack_548 = plVar12[3];
      plVar12[2] = 0;
      plVar12[3] = 0xf;
      *(undefined1 *)plVar12 = 0;
      FUN_1800228c0(&local_620,puVar21,&local_560,local_468);
      local_488 = local_620;
      uStack_480 = uStack_618;
      local_478 = local_610;
      uStack_470 = uStack_608;
      local_610 = 0;
      uStack_608 = 0xf;
      local_620 = local_620 & 0xffffffffffffff00;
      FUN_180084c00(plVar11,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_488,3,'\x01');
      FUN_18000c8d0((longlong *)&local_620);
      FUN_18000c8d0(&local_560);
      FUN_18000c8d0((longlong *)local_5c0);
      FUN_18000c8d0(local_448);
      FUN_18000c8d0(local_468);
      goto LAB_1800ee13a;
    }
    bVar9 = true;
  }
  else {
    plVar11 = FUN_1800014c0();
    local_600 = 0;
    lStack_5f8 = 0;
    local_5f0 = 0;
    lStack_5e8 = 0;
    FUN_18000c1d0(&local_600,"[Ball.Has.MoveEnough] Error in get3DRectify",0x2b);
    pbVar22 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_600;
LAB_1800ee129:
    FUN_180084c00(plVar11,pbVar22,3,'\x01');
LAB_1800ee13a:
    bVar9 = false;
  }
  if (local_180 != (void *)0x0) {
    pvVar18 = local_180;
    if ((0xfff < (ulonglong)(((longlong)local_170 - (longlong)local_180 >> 3) * 8)) &&
       (pvVar18 = *(void **)((longlong)local_180 + -8),
       0x1f < (ulonglong)((longlong)local_180 + (-8 - (longlong)pvVar18)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar18);
    local_180 = (void *)0x0;
    puStack_178 = (undefined8 *)0x0;
    local_170 = (undefined8 *)0x0;
  }
  if (local_198 != (void *)0x0) {
    pvVar18 = local_198;
    if ((0xfff < (ulonglong)(((longlong)local_188 - (longlong)local_198 >> 3) * 8)) &&
       (pvVar18 = *(void **)((longlong)local_198 + -8),
       0x1f < (ulonglong)((longlong)local_198 + (-8 - (longlong)pvVar18)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar18);
    local_198 = (void *)0x0;
    plStack_190 = (longlong *)0x0;
    local_188 = (longlong *)0x0;
  }
  FUN_180043090(&local_1b0);
LAB_1800ee20b:
  FID_conflict__vector<struct_GSISymbolEntry,class_std::allocator<struct_GSISymbolEntry>_>
            ((longlong *)&local_1e8);
  FID_conflict__vector<struct_GSISymbolEntry,class_std::allocator<struct_GSISymbolEntry>_>
            ((longlong *)&local_200);
  cv::Mat::~Mat((Mat *)&local_138);
  cv::Mat::~Mat((Mat *)&local_d8);
  return bVar9;
}

