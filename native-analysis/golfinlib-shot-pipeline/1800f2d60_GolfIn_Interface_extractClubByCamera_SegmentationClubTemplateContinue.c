FUNCTION: GolfIn::Interface::extractClubByCamera_SegmentationClubTemplateContinue
ENTRY: 1800f2d60
REASONS: name:club; string:Club.Detection


/* WARNING: Function: __chkstk replaced with injection: alloca_probe */
/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001800f3c38) */
/* WARNING: Removing unreachable block (ram,0x0001800f3c45) */
/* WARNING: Removing unreachable block (ram,0x0001800f3c5a) */
/* WARNING: Removing unreachable block (ram,0x0001800f3bab) */
/* WARNING: Removing unreachable block (ram,0x0001800f3bb8) */
/* WARNING: Removing unreachable block (ram,0x0001800f3bcd) */
/* WARNING: Removing unreachable block (ram,0x0001800f3cc5) */
/* WARNING: Removing unreachable block (ram,0x0001800f3cd2) */
/* WARNING: Removing unreachable block (ram,0x0001800f3ce7) */
/* WARNING: Removing unreachable block (ram,0x0001800f3d28) */
/* WARNING: Removing unreachable block (ram,0x0001800f3d35) */
/* WARNING: Removing unreachable block (ram,0x0001800f3d4a) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: void __cdecl
   GolfIn::Interface::extractClubByCamera_SegmentationClubTemplateContinue(class GolfIn::Shot *
   __ptr64,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >
   const & __ptr64,class std::map<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> >,class Libraries::CamerasCore::Frame,struct std::less<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class
   std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const ,class Libraries::CamerasCore::Frame> > > const * __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64) __ptr64 */

void __thiscall
GolfIn::Interface::extractClubByCamera_SegmentationClubTemplateContinue
          (Interface *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_3,basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                   *param_4)

{
  undefined4 *puVar1;
  code *pcVar2;
  bool bVar3;
  double dVar4;
  bool bVar5;
  bool bVar6;
  char cVar7;
  char cVar8;
  undefined4 uVar9;
  int iVar10;
  uint uVar11;
  longlong *plVar12;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar13;
  Parameter *pPVar14;
  longlong *plVar15;
  undefined8 *puVar16;
  undefined8 *puVar17;
  longlong *plVar18;
  undefined8 uVar19;
  Mat *pMVar20;
  Mat *pMVar21;
  undefined4 *puVar22;
  ulonglong *puVar23;
  undefined8 *puVar24;
  undefined8 ****ppppuVar25;
  int *piVar26;
  char *pcVar27;
  undefined *puVar28;
  undefined8 *puVar29;
  int iVar30;
  ulonglong uVar31;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar32;
  Shot *_Dst;
  size_t sVar33;
  longlong lVar34;
  DetectionMethod DVar35;
  float fVar36;
  float fVar37;
  float fVar38;
  double dVar39;
  double dVar40;
  undefined1 auStackY_1148 [32];
  bool local_10d4;
  bool local_10c8 [4];
  undefined4 local_10c4;
  int local_10c0;
  int local_10bc;
  int local_10b8;
  int local_10b4;
  int local_10b0;
  int local_10ac;
  int local_10a8 [2];
  undefined8 local_10a0;
  undefined8 local_1098;
  undefined4 local_1090;
  undefined4 local_108c;
  undefined4 local_1088 [2];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_1080;
  longlong *local_1078;
  undefined8 *local_1070;
  undefined8 *local_1068;
  longlong *local_1060;
  ulonglong local_1058;
  undefined8 *local_1050;
  undefined8 *puStack_1048;
  undefined8 local_1040;
  undefined8 ***local_1038;
  undefined8 uStack_1030;
  undefined8 *local_1028;
  ulonglong uStack_1020;
  longlong local_1018;
  longlong local_1010;
  longlong local_1008;
  longlong *local_1000;
  longlong **local_ff8;
  Interface *local_ff0;
  code *local_fe8;
  longlong local_fe0;
  longlong local_fd8;
  longlong local_fd0;
  longlong *local_fc8;
  longlong **local_fc0;
  Interface *local_fb8;
  code *local_fb0;
  longlong *local_fa8;
  longlong **local_fa0;
  Interface *local_f98;
  code *local_f90;
  longlong local_f88;
  longlong local_f80;
  undefined8 uStack_f78;
  undefined8 local_f70;
  undefined8 uStack_f68;
  longlong local_f60;
  longlong local_f58;
  undefined8 uStack_f50;
  undefined8 local_f48;
  undefined8 uStack_f40;
  longlong local_f38;
  undefined8 uStack_f30;
  undefined8 *local_f28;
  ulonglong uStack_f20;
  longlong local_f18;
  longlong local_f10;
  longlong lStack_f08;
  longlong local_f00;
  longlong lStack_ef8;
  longlong local_ef0;
  undefined8 uStack_ee8;
  undefined8 *local_ee0;
  ulonglong uStack_ed8;
  longlong local_ed0;
  longlong lStack_ec8;
  longlong local_ec0;
  longlong lStack_eb8;
  undefined8 local_eb0;
  undefined8 uStack_ea8;
  undefined8 local_ea0;
  undefined8 uStack_e98;
  undefined8 local_e90;
  undefined8 uStack_e88;
  undefined8 local_e80;
  undefined8 local_e78;
  undefined8 uStack_e70;
  undefined8 local_e68;
  undefined8 local_e60;
  undefined8 uStack_e58;
  undefined8 local_e50;
  undefined8 local_e48;
  longlong local_e40;
  longlong lStack_e38;
  longlong local_e30;
  longlong lStack_e28;
  undefined8 local_e20;
  undefined8 uStack_e18;
  undefined8 local_e10;
  undefined8 local_e08;
  undefined8 local_e00;
  undefined8 uStack_df8;
  undefined8 local_df0;
  undefined8 local_de8;
  undefined8 local_de0;
  undefined8 uStack_dd8;
  undefined8 local_dd0;
  undefined8 local_dc8;
  longlong local_dc0;
  longlong lStack_db8;
  longlong local_db0;
  longlong lStack_da8;
  longlong local_da0;
  longlong lStack_d98;
  longlong local_d90;
  longlong lStack_d88;
  undefined8 local_d80;
  undefined8 uStack_d78;
  undefined8 local_d70;
  undefined8 local_d68;
  longlong local_d60;
  undefined8 uStack_d58;
  undefined8 local_d50;
  undefined8 uStack_d48;
  longlong local_d40;
  undefined8 uStack_d38;
  undefined8 local_d30;
  undefined8 uStack_d28;
  longlong local_d20;
  undefined8 uStack_d18;
  undefined8 local_d10;
  undefined8 uStack_d08;
  longlong local_d00;
  undefined8 uStack_cf8;
  undefined8 local_cf0;
  undefined8 uStack_ce8;
  longlong local_ce0;
  undefined8 uStack_cd8;
  undefined8 local_cd0;
  undefined8 uStack_cc8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_cc0 [16];
  undefined8 local_cb0;
  undefined8 uStack_ca8;
  longlong local_ca0;
  undefined8 uStack_c98;
  undefined8 local_c90;
  undefined8 uStack_c88;
  undefined4 local_c80 [2];
  undefined8 local_c78;
  undefined8 local_c70;
  char *local_c68;
  longlong *local_c60;
  undefined8 local_c58;
  int local_c50;
  int local_c48;
  int local_c40;
  int local_c38;
  longlong **local_c30;
  Interface *local_c28;
  code *local_c20;
  longlong local_c18 [2];
  undefined8 **local_c08;
  longlong local_c00;
  longlong local_bf8;
  longlong local_bf0;
  longlong local_be8 [2];
  longlong local_bd8;
  longlong lStack_bd0;
  longlong local_bc8;
  longlong lStack_bc0;
  longlong local_bb8;
  longlong lStack_bb0;
  longlong local_ba8;
  longlong lStack_ba0;
  char local_b98 [32];
  longlong local_b78;
  longlong local_b70 [4];
  longlong local_b50 [4];
  longlong local_b30 [4];
  longlong local_b10 [6];
  char local_ae0 [32];
  char local_ac0 [48];
  longlong local_a90 [4];
  longlong local_a70 [4];
  longlong local_a50 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_a30 [32];
  undefined8 local_a10 [4];
  undefined8 local_9f0 [4];
  longlong local_9d0 [4];
  char local_9b0 [32];
  char local_990 [32];
  char local_970 [32];
  longlong local_950 [4];
  longlong local_930 [4];
  longlong local_910 [4];
  undefined8 local_8f0 [4];
  undefined8 local_8d0 [4];
  longlong local_8b0 [4];
  longlong local_890 [4];
  undefined8 local_870 [4];
  longlong local_850 [4];
  longlong local_830 [4];
  longlong local_810 [5];
  Mat local_7e8 [96];
  Mat local_788 [96];
  Mat local_728 [96];
  Mat local_6c8 [96];
  undefined4 local_668 [40];
  char local_5c8 [8];
  undefined8 local_5c0;
  longlong *plStack_5b8;
  undefined8 local_5b0;
  longlong *plStack_5a8;
  undefined8 ***local_5a0;
  undefined8 uStack_598;
  undefined8 *local_590;
  ulonglong uStack_588;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_580;
  undefined8 uStack_578;
  longlong *local_570;
  longlong lStack_568;
  longlong local_560;
  longlong lStack_558;
  ulonglong local_550;
  longlong *local_548;
  longlong lStack_540;
  longlong local_538;
  longlong lStack_530;
  ulonglong local_528;
  longlong local_520;
  longlong *plStack_518;
  longlong local_510;
  longlong *plStack_508;
  undefined8 *local_500;
  undefined8 uStack_4f8;
  undefined8 *local_4f0 [2];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_4e0;
  undefined8 uStack_4d8;
  undefined8 *local_4d0;
  undefined8 uStack_4c8;
  undefined8 *local_4c0;
  undefined8 uStack_4b8;
  undefined8 *local_4b0;
  undefined8 uStack_4a8;
  undefined8 *local_4a0;
  undefined8 uStack_498;
  undefined8 *local_490;
  ulonglong uStack_488;
  ulonglong local_480;
  longlong local_478;
  longlong lStack_470;
  longlong local_468;
  longlong lStack_460;
  longlong local_458;
  undefined8 uStack_450;
  undefined8 local_448;
  undefined8 *local_440;
  undefined8 *puStack_438;
  undefined8 **local_430;
  longlong *local_428;
  undefined8 uStack_420;
  Interface *local_418;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_410;
  longlong *local_408;
  undefined8 *local_400;
  Interface *local_3f8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_3f0;
  longlong *local_3e8;
  undefined8 *local_3e0;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_3d8 [32];
  Interface *local_3b8;
  char *local_3b0;
  longlong *local_3a8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_3a0;
  longlong *local_398;
  undefined8 *local_390;
  Interface *local_388;
  char *local_380;
  longlong *local_378;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_370;
  longlong *local_368;
  undefined8 *local_360;
  GICTSShotData local_358 [32];
  longlong local_338 [8];
  longlong local_2f8 [4];
  longlong local_2d8 [4];
  ClubDetectionInput local_2b8 [40];
  Mat local_290 [96];
  Mat local_230 [132];
  undefined4 local_1ac;
  ClubDetectionInput local_1a8 [40];
  Mat local_180 [96];
  Mat local_120 [132];
  undefined4 local_9c;
  undefined1 local_84;
  undefined1 local_83 [3];
  ulonglong local_80;
  
                    /* 0xf2d60  564
                       ?extractClubByCamera_SegmentationClubTemplateContinue@Interface@GolfIn@@IEAAXPEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@PEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@5@1@Z
                        */
  local_80 = DAT_1801d1040 ^ (ulonglong)auStackY_1148;
  fVar36 = DAT_18017e95c;
  local_1080 = param_2;
  if (this[0x31d] != (Interface)0x0) {
    fVar36 = getCalibrationPPMM(this,false);
  }
  fVar36 = fVar36 * _DAT_18017ec60 * DAT_18017e97c;
  local_5a0 = (undefined8 ****)0x0;
  uStack_598 = 0;
  local_590 = (undefined8 *)0x0;
  uStack_588 = 0;
  FUN_18000c1d0(&local_5a0,"unknown",7);
  local_d60 = 0;
  uStack_d58 = 0;
  local_d50 = 0;
  uStack_d48 = 0;
  FUN_18000c1d0(&local_d60,"Camera1",7);
  plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_d60);
  puVar16 = *(undefined8 **)param_3;
  cVar7 = *(char *)((longlong)puVar16[1] + 0x19);
  puVar17 = puVar16;
  local_1070 = puVar16;
  puVar24 = (undefined8 *)puVar16[1];
  while (cVar7 == '\0') {
    uVar9 = FUN_180008ca0(puVar24 + 4,plVar12);
    if ((char)uVar9 < '\0') {
      puVar29 = (undefined8 *)puVar24[2];
      puVar24 = puVar17;
    }
    else {
      puVar29 = (undefined8 *)*puVar24;
    }
    puVar17 = puVar24;
    puVar24 = puVar29;
    cVar7 = *(char *)((longlong)puVar29 + 0x19);
  }
  if ((*(char *)((longlong)puVar17 + 0x19) != '\0') ||
     (local_1070 = puVar17, uVar9 = FUN_180008ca0(plVar12,puVar17 + 4), (char)uVar9 < '\0')) {
    puVar17 = puVar16;
    local_1070 = puVar16;
  }
  FUN_18000c8d0(&local_d60);
  local_1078 = puVar17 + 9;
  if (*local_1078 == puVar17[10]) goto LAB_1800f57f2;
  local_d40 = 0;
  uStack_d38 = 0;
  local_d30 = 0;
  uStack_d28 = 0;
  FUN_18000c1d0(&local_d40,"Camera2",7);
  plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_d40);
  puVar16 = *(undefined8 **)param_3;
  cVar7 = *(char *)((longlong)puVar16[1] + 0x19);
  puVar17 = puVar16;
  local_1068 = puVar16;
  puVar24 = (undefined8 *)puVar16[1];
  while (cVar7 == '\0') {
    uVar9 = FUN_180008ca0(puVar24 + 4,plVar12);
    if ((char)uVar9 < '\0') {
      puVar29 = (undefined8 *)puVar24[2];
      puVar24 = puVar17;
    }
    else {
      puVar29 = (undefined8 *)*puVar24;
    }
    puVar17 = puVar24;
    puVar24 = puVar29;
    cVar7 = *(char *)((longlong)puVar29 + 0x19);
  }
  if ((*(char *)((longlong)puVar17 + 0x19) != '\0') ||
     (local_1068 = puVar17, uVar9 = FUN_180008ca0(plVar12,puVar17 + 4), (char)uVar9 < '\0')) {
    puVar17 = puVar16;
    local_1068 = puVar16;
  }
  FUN_18000c8d0(&local_d40);
  local_1060 = puVar17 + 9;
  if (*local_1060 == puVar17[10]) goto LAB_1800f57f2;
  iVar30 = *(int *)(param_1 + 0x24);
  if (iVar30 < 6) {
    plVar12 = FUN_1800014c0();
    ppppuVar25 = &local_5a0;
    if (0xf < uStack_588) {
      ppppuVar25 = (undefined8 ****)local_5a0;
    }
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(local_ae0,
                         "[Segmentation.Club] Detect no ball movement. Trying from color variation hit frame..."
                         ,ppppuVar25);
    FUN_180084c00(plVar12,pbVar13,2,'\x01');
    iVar30 = 0x46;
  }
  dVar4 = DAT_18017ec00;
  fVar38 = DAT_18017eaf8;
  dVar39 = DAT_18017ec00 / *(double *)(param_1 + 0xd8);
  fVar37 = logf(*(float *)(param_1 + 0x18) * DAT_18017eaf8);
  dVar39 = floor((DAT_18017eb38 - (double)fVar37 * DAT_18017eae8) / dVar39);
  local_10c0 = (int)dVar39;
  if (local_10c0 < 1) {
    local_10c0 = 1;
  }
  local_10c0 = local_10c0 + 1;
  iVar30 = iVar30 - local_10c0;
  local_1090 = 5;
  for (piVar26 = *(int **)(param_1 + 0x60); local_10b8 = iVar30,
      piVar26 != *(int **)(param_1 + 0x68); piVar26 = piVar26 + 6) {
    if (*piVar26 == 5) {
      local_e78 = *(undefined8 *)piVar26;
      uStack_e70 = *(undefined8 *)(piVar26 + 2);
      local_e68 = *(undefined8 *)(piVar26 + 4);
      goto LAB_1800f30cc;
    }
    if (piVar26 == *(int **)(param_1 + 0x68)) break;
  }
  FUN_1800a40b0((undefined4 *)&local_e78);
LAB_1800f30cc:
  local_1098._0_4_ = (undefined4)uStack_e70;
  local_1098._4_4_ = uStack_e70._4_4_;
  local_108c = 5;
  for (piVar26 = *(int **)(param_1 + 0x180); piVar26 != *(int **)(param_1 + 0x188);
      piVar26 = piVar26 + 6) {
    if (*piVar26 == 5) {
      local_e90 = *(undefined8 *)piVar26;
      uStack_e88 = *(undefined8 *)(piVar26 + 2);
      local_e80 = *(undefined8 *)(piVar26 + 4);
      goto LAB_1800f313c;
    }
    if (piVar26 == *(int **)(param_1 + 0x188)) break;
  }
  FUN_1800a40b0((undefined4 *)&local_e90);
LAB_1800f313c:
  local_10a0._0_4_ = (undefined4)uStack_e88;
  local_10a0._4_4_ = uStack_e88._4_4_;
  uStack_1030 = 0;
  local_1028 = _DAT_18017ef00;
  uStack_1020 = _UNK_18017ef08;
  local_1038 = (undefined8 ****)0x0;
  if (*(int *)(this + 0x6f8) == 2) {
    pcVar27 = "left";
    sVar33 = 4;
  }
  else if (*(int *)(this + 0x6f8) == 1) {
    pcVar27 = "right";
    sVar33 = 5;
  }
  else {
    pcVar27 = "unknown";
    sVar33 = 7;
  }
  FUN_18000a490((longlong *)&local_1038,pcVar27,sVar33);
  if (0xf < uStack_588) {
    ppppuVar25 = (undefined8 ****)local_5a0;
    if ((0xfff < uStack_588 + 1) &&
       (ppppuVar25 = (undefined8 ****)local_5a0[-1],
       0x1f < (ulonglong)((longlong)local_5a0 + (-8 - (longlong)ppppuVar25)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(ppppuVar25);
  }
  local_5a0 = local_1038;
  uStack_598 = uStack_1030;
  local_590 = local_1028;
  uStack_588 = uStack_1020;
  local_1028 = _DAT_18017ef00;
  uStack_1020 = _UNK_18017ef08;
  local_1038 = (undefined8 ***)((ulonglong)local_1038 & 0xffffffffffffff00);
  FUN_18000c8d0((longlong *)&local_1038);
  plVar12 = FUN_1800014c0();
  ppppuVar25 = &local_5a0;
  if (0xf < uStack_588) {
    ppppuVar25 = (undefined8 ****)local_5a0;
  }
  pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format(local_ac0,"[Segmentation.Club] Player hand set to : %s",ppppuVar25);
  FUN_180084c00(plVar12,pbVar13,1,'\x01');
  local_d20 = 0;
  uStack_d18 = 0;
  local_d10 = 0;
  uStack_d08 = 0;
  FUN_18000c1d0(&local_d20,"Configurations.Debug.UseCameras",0x1f);
  pPVar14 = Libraries::Core::Parameters::get
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_d20);
  bVar5 = Libraries::Core::Parameter::toBoolean(pPVar14);
  if ((bVar5) && (*(longlong *)(this + 0x298) != 0)) {
    bVar5 = true;
  }
  else {
    bVar5 = false;
  }
  FUN_18000c8d0(&local_d20);
  if (bVar5) {
    plVar12 = *(longlong **)(this + 0x298);
    uStack_f30 = 0;
    local_f28 = _DAT_18017ef00;
    uStack_f20 = _UNK_18017ef08;
    local_f38 = 0;
    if (*(int *)(this + 0x6f8) == 2) {
      sVar33 = 4;
      pcVar27 = "left";
    }
    else if (*(int *)(this + 0x6f8) == 1) {
      sVar33 = 5;
      pcVar27 = "right";
    }
    else {
      sVar33 = 7;
      pcVar27 = "unknown";
    }
    FUN_18000a490(&local_f38,pcVar27,sVar33);
    local_1050 = (undefined8 *)0x0;
    puStack_1048 = (undefined8 *)0x0;
    local_1040 = 0;
    FUN_18000bc20((ulonglong *)&local_1050,1);
    puVar16 = local_1050;
    local_c08 = &local_1050;
    local_440 = local_1050;
    puStack_438 = local_1050;
    local_430 = &local_1050;
    FUN_18000cb00(local_1050,&local_f38);
    puStack_1048 = puVar16 + 4;
    local_1088[0] = 1;
    local_d00 = 0;
    uStack_cf8 = 0;
    local_cf0 = 0;
    uStack_ce8 = 0;
    puStack_438 = puStack_1048;
    FUN_18000c1d0(&local_d00,"Camera1",7);
    plVar15 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_d00);
    plVar18 = plVar12 + 2;
    uStack_420 = 0;
    local_428 = plVar18;
    iVar10 = _Mtx_lock(plVar18);
    if (iVar10 != 0) {
      std::_Throw_Cpp_error(5);
      pcVar2 = (code *)swi(3);
      (*pcVar2)();
      return;
    }
    if (*(int *)((longlong)plVar12 + 0x5c) == 0x7fffffff) {
      *(undefined4 *)((longlong)plVar12 + 0x5c) = 0x7ffffffe;
      std::_Throw_Cpp_error(6);
      pcVar2 = (code *)swi(3);
      (*pcVar2)();
      return;
    }
    uStack_420 = CONCAT71(uStack_420._1_7_,1);
    if ((char)plVar12[1] != '\0') {
      local_458 = 0;
      uStack_450 = 0;
      local_448 = 0;
      (**(code **)(*plVar12 + 0x18))(plVar12,plVar15,local_1088,&local_1050);
      FUN_18000bd00(&local_458);
    }
    _Mtx_unlock(plVar18);
    FUN_18000c8d0(&local_d00);
    FUN_18000bd00((longlong *)&local_1050);
    _eh_vector_destructor_iterator_(&local_f38,0x20,1,thunk_FUN_18000c8d0);
  }
  dVar39 = *(double *)(param_1 + 0xd8);
  dVar40 = exp((double)*(float *)(param_1 + 0x18) * _DAT_18017ed40);
  dVar39 = floor(dVar40 * (double)(float)((double)(float)dVar39 / dVar4) * _DAT_18017eb20);
  uVar11 = 10;
  if ((int)dVar39 < 10) {
    uVar11 = (int)dVar39;
  }
  uVar31 = 1;
  if (1 < (int)uVar11) {
    uVar31 = (ulonglong)uVar11;
  }
  iVar10 = (int)uVar31;
  *(int *)(param_1 + 0x328) = iVar10;
  *(int *)(param_1 + 0x4d8) = iVar10;
  local_10bc = iVar10;
  plVar12 = FUN_1800014c0();
  pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format(local_b98,"[Segmentation.Club] Skip every %d frames for the club tracking.",
                       uVar31);
  FUN_180084c00(plVar12,pbVar13,1,'\x01');
  local_10b4 = iVar30 + iVar10 * -10;
  if (local_10b4 < 0) {
    local_10b4 = 0;
  }
  uVar31 = (longlong)(iVar30 - local_10b4) / (longlong)iVar10;
  local_10b0 = iVar30;
  local_10ac = local_10b4;
  local_10a8[0] = iVar30;
  plVar12 = FUN_1800014c0();
  uVar11 = (uint)uVar31;
  puVar16 = FUN_18000c2d0(local_a90,uVar11);
  puVar16 = FUN_180007680(puVar16,0,"[Segmentation.Club] Nb. image detection : ",0x2a);
  local_eb0 = *puVar16;
  uStack_ea8 = puVar16[1];
  local_ea0 = puVar16[2];
  uStack_e98 = puVar16[3];
  puVar16[2] = 0;
  puVar16[3] = 0xf;
  *(undefined1 *)puVar16 = 0;
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_eb0,0,'\x01');
  FUN_18000c8d0(local_a90);
  plVar12 = FUN_1800014c0();
  if ((int)uVar11 < 0) {
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(local_b98,
                         "[Segmentation Club] Anormal nb of image detected: %d. No club detection will be available."
                         ,uVar31 & 0xffffffff);
    FUN_180084c00(plVar12,pbVar13,3,'\x01');
    goto LAB_1800f57f2;
  }
  uVar11 = _Thrd_hardware_concurrency();
  puVar16 = FUN_1800a3260(local_a50,uVar11);
  puVar17 = FUN_18000c2d0(local_a70,*(uint *)(this + 0x1d8));
  local_84 = 0x31;
  local_ef0 = 0;
  uStack_ee8 = 0;
  local_ee0 = (undefined8 *)0x0;
  uStack_ed8 = 0;
  if (&local_84 == local_83) {
    local_ee0 = _DAT_18017ef00;
    uStack_ed8 = _UNK_18017ef08;
    local_ef0 = 0;
  }
  else {
    FUN_18000c1d0(&local_ef0,&local_84,(size_t)(local_83 + -(longlong)&local_84));
  }
  plVar18 = FUN_180007680(&local_ef0,0,"[Segmentation.Club] Executing on multi-thread: ",0x2f);
  local_da0 = *plVar18;
  lStack_d98 = plVar18[1];
  local_d90 = plVar18[2];
  lStack_d88 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  pcVar27 = " threads. Using ";
  plVar18 = FUN_18000a490(&local_da0," threads. Using ",0x10);
  local_bb8 = *plVar18;
  lStack_bb0 = plVar18[1];
  local_ba8 = plVar18[2];
  lStack_ba0 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  FUN_1800228c0(local_b10,pcVar27,&local_bb8,puVar17);
  puVar28 = &DAT_18017809c;
  plVar18 = FUN_18000a490(local_b10,&DAT_18017809c,3);
  local_bd8 = *plVar18;
  lStack_bd0 = plVar18[1];
  local_bc8 = plVar18[2];
  lStack_bc0 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  FUN_1800228c0(local_b30,puVar28,&local_bd8,puVar16);
  plVar18 = FUN_18000a490(local_b30," threads.",9);
  local_ed0 = *plVar18;
  lStack_ec8 = plVar18[1];
  local_ec0 = plVar18[2];
  lStack_eb8 = plVar18[3];
  plVar18[2] = 0;
  plVar18[3] = 0xf;
  *(undefined1 *)plVar18 = 0;
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_ed0,1,'\x01');
  FUN_18000c8d0(local_b30);
  FUN_18000c8d0(&local_bd8);
  FUN_18000c8d0(local_b10);
  FUN_18000c8d0(&local_bb8);
  FUN_18000c8d0(&local_da0);
  FUN_18000c8d0(&local_ef0);
  FUN_18000c8d0(local_a70);
  FUN_18000c8d0(local_a50);
  FUN_1800090b0(&local_1008);
  local_ce0 = 0;
  uStack_cd8 = 0;
  local_cd0 = 0;
  uStack_cc8 = 0;
  FUN_18000c1d0(&local_ce0,"Results",7);
  plVar12 = (longlong *)getProcessImagesPath(this,local_a30);
  pbVar13 = local_1080;
  if (0xf < *(ulonglong *)(local_1080 + 0x18)) {
    pbVar13 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
               local_1080;
  }
  plVar12 = FUN_18000a490(plVar12,pbVar13,*(size_t *)(local_1080 + 0x10));
  local_dc0 = *plVar12;
  lStack_db8 = plVar12[1];
  local_db0 = plVar12[2];
  lStack_da8 = plVar12[3];
  plVar12[3] = 0xf;
  plVar12[2] = 0;
  *(undefined1 *)plVar12 = 0;
  plVar12 = FUN_18000a490(&local_dc0,"\\club_img_detection",0x13);
  local_478 = *plVar12;
  lStack_470 = plVar12[1];
  local_468 = plVar12[2];
  lStack_460 = plVar12[3];
  plVar12[2] = 0;
  plVar12[3] = 0xf;
  *(undefined1 *)plVar12 = 0;
  FUN_18000c8d0(&local_dc0);
  FUN_18000c8d0((longlong *)local_a30);
  FUN_18000c8d0(&local_ce0);
  local_1080 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
               ((ulonglong)local_1080 & 0xffffffff00000000);
  local_f58 = 0;
  uStack_f50 = 0;
  local_f48 = 0;
  uStack_f40 = 0;
  FUN_18000c1d0(&local_f58,"Configurations.Process.Club.DetectionMethodIndex",0x30);
  bVar5 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_f58);
  if (bVar5) {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_f58);
    iVar30 = Libraries::Core::Parameter::toInt(pPVar14);
  }
  else {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_f58);
    Libraries::Core::Parameter::setValue(pPVar14,(int *)&local_1080);
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_f58);
    iVar30 = Libraries::Core::Parameter::toInt(pPVar14);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_f58);
  if (iVar30 == 1) {
    DVar35 = 1;
  }
  else if (iVar30 == 2) {
    DVar35 = 3;
  }
  else {
    DVar35 = 2;
    if (iVar30 == 3) {
      DVar35 = 4;
    }
  }
  local_5c0 = 0;
  plStack_5b8 = (longlong *)0x0;
  local_5b0 = 0;
  plStack_5a8 = (longlong *)0x0;
  if (DVar35 == 2) {
    if (*(longlong *)(this + 0x868) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x868) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_5c0 = *(undefined8 *)(this + 0x860);
    plStack_5b8 = *(longlong **)(this + 0x868);
    if (*(longlong *)(this + 0x878) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x878) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_5b0 = *(undefined8 *)(this + 0x870);
    plStack_5a8 = *(longlong **)(this + 0x878);
  }
  else if (DVar35 == 3) {
    if (*(longlong *)(this + 0x888) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x888) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_5c0 = *(undefined8 *)(this + 0x880);
    plStack_5b8 = *(longlong **)(this + 0x888);
    if (*(longlong *)(this + 0x898) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x898) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_5b0 = *(undefined8 *)(this + 0x890);
    plStack_5a8 = *(longlong **)(this + 0x898);
  }
  else if (DVar35 == 4) {
    if (*(longlong *)(this + 0x8a8) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x8a8) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_5c0 = *(undefined8 *)(this + 0x8a0);
    plStack_5b8 = *(longlong **)(this + 0x8a8);
    if (*(longlong *)(this + 0x8b8) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x8b8) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_5b0 = *(undefined8 *)(this + 0x8b0);
    plStack_5a8 = *(longlong **)(this + 0x8b8);
  }
  fVar37 = getCalibrationPPMM(this,false);
  if (((this[0x729] != (Interface)0x0) || (*(float *)(param_1 + 0x18) * fVar38 <= DAT_18017ec50)) ||
     (local_10d4 = true,
     DAT_18017ec5c < *(float *)(param_1 + 0x10) || DAT_18017ec5c == *(float *)(param_1 + 0x10))) {
    local_10d4 = false;
  }
  fVar38 = getCalibrationPPMM(this,false);
  bVar5 = _DAT_18017e978 < fVar38;
  local_cc0._0_12_ = ZEXT812(0);
  local_cc0._12_4_ = 0;
  local_cb0 = 0;
  uStack_ca8 = 0;
  FUN_18000c1d0((undefined8 *)local_cc0,"Camera1",7);
  lVar34 = (longlong)local_10b8;
  iVar30 = (int)(fVar36 + fVar36);
  Detection::ClubDetectionInput::ClubDetectionInput
            (local_1a8,(Mat *)(lVar34 * 0x60 + *local_1078),(Mat *)(*local_1078 + 0x3c0),
             (Point_<float> *)&local_1098,iVar30,DVar35,local_10b8,local_cc0,fVar37,local_10d4,bVar5
            );
  FUN_18000c8d0((longlong *)local_cc0);
  local_ca0 = 0;
  uStack_c98 = 0;
  local_c90 = 0;
  uStack_c88 = 0;
  FUN_18000c1d0(&local_ca0,"Camera2",7);
  Detection::ClubDetectionInput::ClubDetectionInput
            (local_2b8,(Mat *)(*local_1060 + lVar34 * 0x60),(Mat *)(*local_1060 + 0x3c0),
             (Point_<float> *)&local_10a0,iVar30,DVar35,local_10b8,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &local_ca0,fVar37,local_10d4,bVar5);
  FUN_18000c8d0(&local_ca0);
  *(undefined8 *)(this + 0x820) = 0;
  plVar12 = *(longlong **)(this + 0x828);
  *(undefined8 *)(this + 0x828) = 0;
  if (plVar12 != (longlong *)0x0) {
    LOCK();
    plVar18 = plVar12 + 1;
    lVar34 = *plVar18;
    *(int *)plVar18 = (int)*plVar18 + -1;
    UNLOCK();
    if ((int)lVar34 == 1) {
      (**(code **)*plVar12)(plVar12);
      LOCK();
      piVar26 = (int *)((longlong)plVar12 + 0xc);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        (**(code **)(*plVar12 + 8))(plVar12);
      }
    }
  }
  *(undefined8 *)(this + 0x830) = 0;
  plVar12 = *(longlong **)(this + 0x838);
  *(undefined8 *)(this + 0x838) = 0;
  if (plVar12 != (longlong *)0x0) {
    LOCK();
    plVar18 = plVar12 + 1;
    lVar34 = *plVar18;
    *(int *)plVar18 = (int)*plVar18 + -1;
    UNLOCK();
    if ((int)lVar34 == 1) {
      (**(code **)*plVar12)(plVar12);
      LOCK();
      piVar26 = (int *)((longlong)plVar12 + 0xc);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        (**(code **)(*plVar12 + 8))(plVar12);
      }
    }
  }
  local_510 = 0;
  plStack_508 = (longlong *)0x0;
  local_520 = 0;
  plStack_518 = (longlong *)0x0;
  local_10c8[0] = true;
  local_f80 = 0;
  uStack_f78 = 0;
  local_f70 = 0;
  uStack_f68 = 0;
  FUN_18000c1d0(&local_f80,"Configurations.Process.UseMLForClub",0x23);
  bVar5 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_f80);
  if (bVar5) {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_f80);
    local_5c8[0] = Libraries::Core::Parameter::toBoolean(pPVar14);
  }
  else {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_f80);
    Libraries::Core::Parameter::setValue(pPVar14,local_10c8);
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_f80);
    local_5c8[0] = Libraries::Core::Parameter::toBoolean(pPVar14);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_f80);
  pbVar13 = local_3d8;
  getCurrentConfigParamFilePath(this);
  local_3b0 = local_5c8;
  local_3a8 = &local_510;
  local_3a0 = local_3d8;
  local_398 = &local_478;
  local_390 = &local_5c0;
  local_380 = local_5c8;
  local_378 = &local_520;
  local_370 = local_3d8;
  local_368 = &local_478;
  local_360 = &local_5c0;
  local_3f0 = local_3d8;
  local_3e8 = &local_478;
  local_3e0 = &local_5c0;
  local_410 = local_3d8;
  local_408 = &local_478;
  local_400 = &local_5c0;
  bVar5 = false;
  local_418 = this;
  local_3f8 = this;
  local_3b8 = this;
  local_388 = this;
  if (local_5c8[0] == '\0') {
LAB_1800f4459:
    local_4a0 = (undefined8 *)0x0;
    uStack_498 = 0;
    FUN_1800fad50(&local_4a0,pbVar13,&local_3f8,local_1a8);
    local_4d0 = (undefined8 *)0x0;
    uStack_4c8 = 0;
    FUN_1800faf40(&local_4d0,pbVar13,&local_418,local_2b8);
    FUN_180084940((longlong *)&local_4a0);
    FUN_180084940((longlong *)&local_4d0);
    *(undefined1 *)(*(longlong *)(this + 0x820) + 0x90) = 1;
    *(undefined1 *)(*(longlong *)(this + 0x830) + 0x90) = 1;
    if ((local_5c8[0] != '\0') && (!bVar5)) {
      plVar12 = FUN_1800014c0();
      local_e20 = 0;
      uStack_e18 = 0;
      local_e10 = 0;
      local_e08 = 0;
      FUN_18000c1d0(&local_e20,"[Segmentation.Club] Falling back to standard algorithmic detection."
                    ,0x43);
      FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_e20,2,'\x01');
    }
    if (local_4d0 != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(local_4d0 + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)local_4d0[0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*local_4d0)(local_4d0,1);
        }
        else {
          (**(code **)*puVar16)(puVar16,local_4d0);
        }
      }
    }
    if (local_4a0 != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(local_4a0 + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)local_4a0[0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*local_4a0)(local_4a0,1);
        }
        else {
          (**(code **)*puVar16)(puVar16,local_4a0);
        }
      }
    }
  }
  else {
    local_580 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0;
    uStack_578 = 0;
    FUN_1800fa910(&local_580,pbVar13,&local_3b8,local_1a8);
    local_4e0 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0;
    uStack_4d8 = 0;
    FUN_1800fab10(&local_4e0,pbVar13,&local_388,local_2b8);
    local_f60 = 800;
    FUN_1800090b0(&local_f18);
    pbVar32 = local_580;
    if ((local_580 ==
         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0) ||
       (((char)uStack_578 != '\0' &&
        (local_580[0xb8] !=
         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>)0x0)))) {
                    /* WARNING: Subroutine does not return */
      FUN_180009ac0(4);
    }
    uVar19 = FUN_1800fd9b0((longlong *)local_580,&local_f60);
    if ((int)uVar19 == 0) {
      plVar12 = FUN_1800090b0(&local_b78);
      local_1018 = 800 - (*plVar12 - local_f18) / 1000000;
      if (local_1018 < 1) {
        plVar12 = FUN_1800014c0();
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_18000c890(local_9f0,
                                "[Segmentation.Club] ML Detection timed out (Cam 1 took too long).")
        ;
        goto LAB_1800f42d4;
      }
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_1018;
      iVar30 = FUN_1800fad10(&local_4e0,(longlong *)pbVar13);
      if (iVar30 != 0) {
        plVar12 = FUN_1800014c0();
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_18000c890(local_a10,"[Segmentation.Club] ML Detection timed out on Camera 2.")
        ;
        goto LAB_1800f42d4;
      }
      bVar5 = true;
      FUN_180084940((longlong *)&local_580);
      FUN_180084940((longlong *)&local_4e0);
      pbVar32 = local_580;
    }
    else {
      plVar12 = FUN_1800014c0();
      local_e00 = 0;
      uStack_df8 = 0;
      local_df0 = 0;
      local_de8 = 0;
      FUN_18000c1d0(&local_e00,"[Segmentation.Club] ML Detection timed out on Camera 1.",0x37);
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_e00;
LAB_1800f42d4:
      FUN_180084c00(plVar12,pbVar13,2,'\x01');
    }
    if (local_4e0 !=
        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0) {
      LOCK();
      pbVar32 = local_4e0 + 8;
      iVar30 = *(int *)pbVar32;
      *(int *)pbVar32 = *(int *)pbVar32 + -1;
      UNLOCK();
      pbVar32 = local_580;
      if (iVar30 == 1) {
        puVar16 = *(undefined8 **)(local_4e0 + 200);
        if (puVar16 == (undefined8 *)0x0) {
          pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    0x1;
          (*(code *)**(undefined8 **)local_4e0)();
          pbVar32 = local_580;
        }
        else {
          pbVar13 = local_4e0;
          (**(code **)*puVar16)(puVar16);
          pbVar32 = local_580;
        }
      }
    }
    if (pbVar32 !=
        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0) {
      LOCK();
      pbVar32 = pbVar32 + 8;
      iVar30 = *(int *)pbVar32;
      *(int *)pbVar32 = *(int *)pbVar32 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = *(undefined8 **)(local_580 + 200);
        if (puVar16 == (undefined8 *)0x0) {
          pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    0x1;
          (*(code *)**(undefined8 **)local_580)();
        }
        else {
          pbVar13 = local_580;
          (**(code **)*puVar16)(puVar16);
        }
      }
    }
    plVar12 = plStack_508;
    lVar34 = local_510;
    if (((!bVar5) || (local_510 == 0)) || (local_520 == 0)) goto LAB_1800f4459;
    local_510 = 0;
    plStack_508 = (longlong *)0x0;
    *(longlong *)(this + 0x820) = lVar34;
    plVar18 = *(longlong **)(this + 0x828);
    *(longlong **)(this + 0x828) = plVar12;
    if (plVar18 != (longlong *)0x0) {
      LOCK();
      plVar12 = plVar18 + 1;
      lVar34 = *plVar12;
      *(int *)plVar12 = (int)*plVar12 + -1;
      UNLOCK();
      if ((int)lVar34 == 1) {
        (**(code **)*plVar18)(plVar18);
        LOCK();
        piVar26 = (int *)((longlong)plVar18 + 0xc);
        iVar30 = *piVar26;
        *piVar26 = *piVar26 + -1;
        UNLOCK();
        if (iVar30 == 1) {
          (**(code **)(*plVar18 + 8))(plVar18);
        }
      }
    }
    plVar18 = plStack_518;
    lVar34 = local_520;
    local_520 = 0;
    plStack_518 = (longlong *)0x0;
    *(longlong *)(this + 0x830) = lVar34;
    plVar12 = *(longlong **)(this + 0x838);
    *(longlong **)(this + 0x838) = plVar18;
    if (plVar12 != (longlong *)0x0) {
      LOCK();
      plVar18 = plVar12 + 1;
      lVar34 = *plVar18;
      *(int *)plVar18 = (int)*plVar18 + -1;
      UNLOCK();
      if ((int)lVar34 == 1) {
        (**(code **)*plVar12)(plVar12);
        LOCK();
        piVar26 = (int *)((longlong)plVar12 + 0xc);
        iVar30 = *piVar26;
        *piVar26 = *piVar26 + -1;
        UNLOCK();
        if (iVar30 == 1) {
          (**(code **)(*plVar12 + 8))(plVar12);
        }
      }
    }
  }
  FUN_1800090b0(&local_1010);
  plVar12 = FUN_1800014c0();
  puVar16 = FUN_180084840(local_9d0,(local_1010 - local_1008) / 1000000);
  plVar18 = FUN_180007680(puVar16,0,"[Segmentation.Club] Time to extract club head : ",0x30);
  local_e40 = *plVar18;
  lStack_e38 = plVar18[1];
  local_e30 = plVar18[2];
  lStack_e28 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  plVar18 = FUN_18000a490(&local_e40,&DAT_180175e94,3);
  local_f10 = *plVar18;
  lStack_f08 = plVar18[1];
  local_f00 = plVar18[2];
  lStack_ef8 = plVar18[3];
  plVar18[2] = 0;
  plVar18[3] = 0xf;
  *(undefined1 *)plVar18 = 0;
  bVar3 = false;
  bVar5 = false;
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_f10,1,'\x01');
  FUN_18000c8d0(&local_e40);
  FUN_18000c8d0(local_9d0);
  if ((*(ClubDetection **)(this + 0x820) == (ClubDetection *)0x0) ||
     (*(longlong *)(this + 0x830) == 0)) {
    plVar12 = FUN_1800014c0();
    local_d80 = 0;
    uStack_d78 = 0;
    local_d70 = 0;
    local_d68 = 0;
    FUN_18000c1d0(&local_d80,
                  "[Segmentation.Club] Unable to get a viable mask for the club. No club detection available."
                  ,0x5a);
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_d80;
LAB_1800f569a:
    FUN_180084c00(plVar12,pbVar13,3,'\x01');
  }
  else {
    bVar6 = Detection::ClubDetection::isDetectionValid(*(ClubDetection **)(this + 0x820));
    fVar36 = DAT_18017ed08;
    if ((bVar6) &&
       (bVar6 = Detection::ClubDetection::isDetectionValid(*(ClubDetection **)(this + 0x830)),
       fVar36 = DAT_18017ed08, bVar6)) {
      cv::Mat::Mat(local_788,(Mat *)(*(longlong *)(this + 0x830) + 8));
      cv::Mat::Mat(local_7e8,(Mat *)(*(longlong *)(this + 0x820) + 8));
      bVar3 = true;
      bVar5 = true;
      fVar36 = Libraries::Core::compareMaskShape(local_7e8,local_788);
    }
    if (bVar5) {
      cv::Mat::~Mat(local_7e8);
    }
    if (bVar3) {
      cv::Mat::~Mat(local_788);
    }
    plVar12 = FUN_1800014c0();
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(local_9b0,"[Segmentation.Club] Mask shape comparison result: %f",
                         SUB84((double)fVar36,0));
    FUN_180084c00(plVar12,pbVar13,1,'\x01');
    if (_DAT_18017ea40 < fVar36) {
      plVar12 = FUN_1800014c0();
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                cv::format(local_990,
                           "[Segmentation.Club] Using MOG2 detection to detect club head. Mask shape were not identical."
                           ,SUB84((double)fVar36,0));
      FUN_180084c00(plVar12,pbVar13,1,'\x01');
      *(undefined8 *)(this + 0x820) = 0;
      plVar12 = *(longlong **)(this + 0x828);
      *(undefined8 *)(this + 0x828) = 0;
      if (plVar12 != (longlong *)0x0) {
        LOCK();
        plVar18 = plVar12 + 1;
        lVar34 = *plVar18;
        *(int *)plVar18 = (int)*plVar18 + -1;
        UNLOCK();
        if ((int)lVar34 == 1) {
          (**(code **)*plVar12)(plVar12);
          LOCK();
          piVar26 = (int *)((longlong)plVar12 + 0xc);
          iVar30 = *piVar26;
          *piVar26 = *piVar26 + -1;
          UNLOCK();
          if (iVar30 == 1) {
            (**(code **)(*plVar12 + 8))(plVar12);
          }
        }
      }
      *(undefined8 *)(this + 0x830) = 0;
      plVar12 = *(longlong **)(this + 0x838);
      *(undefined8 *)(this + 0x838) = 0;
      if (plVar12 != (longlong *)0x0) {
        LOCK();
        plVar18 = plVar12 + 1;
        lVar34 = *plVar18;
        *(int *)plVar18 = (int)*plVar18 + -1;
        UNLOCK();
        if ((int)lVar34 == 1) {
          (**(code **)*plVar12)(plVar12);
          LOCK();
          piVar26 = (int *)((longlong)plVar12 + 0xc);
          iVar30 = *piVar26;
          *piVar26 = *piVar26 + -1;
          UNLOCK();
          if (iVar30 == 1) {
            (**(code **)(*plVar12 + 8))(plVar12);
          }
        }
      }
      local_9c = 1;
      local_1ac = 1;
      local_4c0 = (undefined8 *)0x0;
      uStack_4b8 = 0;
      FUN_1800fad50(&local_4c0,pbVar13,&local_3f8,local_1a8);
      local_4b0 = (undefined8 *)0x0;
      uStack_4a8 = 0;
      FUN_1800faf40(&local_4b0,pbVar13,&local_418,local_2b8);
      FUN_180084940((longlong *)&local_4c0);
      FUN_180084940((longlong *)&local_4b0);
      *(undefined1 *)(*(longlong *)(this + 0x820) + 0x90) = 1;
      *(undefined1 *)(*(longlong *)(this + 0x830) + 0x90) = 1;
      if (local_4b0 != (undefined8 *)0x0) {
        LOCK();
        piVar26 = (int *)(local_4b0 + 1);
        iVar30 = *piVar26;
        *piVar26 = *piVar26 + -1;
        UNLOCK();
        if (iVar30 == 1) {
          puVar16 = (undefined8 *)local_4b0[0x19];
          if (puVar16 == (undefined8 *)0x0) {
            (**(code **)*local_4b0)(local_4b0,1);
          }
          else {
            (**(code **)*puVar16)(puVar16,local_4b0);
          }
        }
      }
      if (local_4c0 != (undefined8 *)0x0) {
        LOCK();
        piVar26 = (int *)(local_4c0 + 1);
        iVar30 = *piVar26;
        *piVar26 = *piVar26 + -1;
        UNLOCK();
        if (iVar30 == 1) {
          puVar16 = (undefined8 *)local_4c0[0x19];
          if (puVar16 == (undefined8 *)0x0) {
            (**(code **)*local_4c0)(local_4c0,1);
          }
          else {
            (**(code **)*puVar16)(puVar16,local_4c0);
          }
        }
      }
    }
    if ((((*(ClubDetection **)(this + 0x820) == (ClubDetection *)0x0) ||
         (*(longlong *)(this + 0x830) == 0)) ||
        (bVar5 = Detection::ClubDetection::isDetectionValid(*(ClubDetection **)(this + 0x820)),
        !bVar5)) ||
       (bVar5 = Detection::ClubDetection::isDetectionValid(*(ClubDetection **)(this + 0x830)),
       !bVar5)) {
      plVar12 = FUN_1800014c0();
      local_e60 = 0;
      uStack_e58 = 0;
      local_e50 = 0;
      local_e48 = 0;
      FUN_18000c1d0(&local_e60,
                    "[Segmentation.Club] Unable to get a viable mask for the club. No club detection available."
                    ,0x5a);
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_e60;
      goto LAB_1800f569a;
    }
    pMVar20 = (Mat *)Detection::ClubDetection::getClubMask(*(ClubDetection **)(this + 0x830));
    pMVar21 = (Mat *)Detection::ClubDetection::getClubMask(*(ClubDetection **)(this + 0x820));
    fVar36 = Libraries::Core::compareMaskShape(pMVar21,pMVar20);
    cv::Mat::~Mat(local_728);
    cv::Mat::~Mat(local_6c8);
    if (_DAT_18017eae0 < fVar36) {
      plVar12 = FUN_1800014c0();
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                cv::format(local_970,
                           "[Segmentation.Club] Mask shape comparison result with MOG2: %f. Club detection refused."
                           ,(double)fVar36);
      goto LAB_1800f569a;
    }
    FUN_1800dd1e0((longlong)local_358);
    CopyCamShotToGICTShot(this,param_1,local_358);
    puVar22 = FUN_1800a5340(local_668,(undefined4 *)local_358);
    bVar5 = OnIsPutter(this,puVar22);
    (**(code **)(**(longlong **)(this + 0x820) + 0x28))
              (*(longlong **)(this + 0x820),*(undefined8 *)(this + 0x830),
               *(undefined4 *)(param_1 + 0x10),bVar5);
    *(undefined4 *)(param_1 + 0x398) = *(undefined4 *)(*(longlong *)(this + 0x820) + 0x84);
    local_10c4 = 0;
    local_de0 = 0;
    uStack_dd8 = 0;
    local_dd0 = 0;
    local_dc8 = 0;
    FUN_18000c1d0(&local_de0,&DAT_18016a0f8,0);
    loadTracker(this,0,&local_de0);
    local_548 = (longlong *)0x0;
    lStack_540 = 0;
    local_538 = 0;
    lStack_530 = 0;
    local_528 = 0;
    local_548 = (longlong *)FUN_1801327e0(0x10);
    local_548[1] = 0;
    *local_548 = (longlong)&local_548;
    local_570 = (longlong *)0x0;
    lStack_568 = 0;
    local_560 = 0;
    lStack_558 = 0;
    local_550 = 0;
    local_570 = (longlong *)FUN_1801327e0(0x10);
    local_570[1] = 0;
    *local_570 = (longlong)&local_570;
    plVar12 = &local_fd8;
    FUN_1800090b0(plVar12);
    local_500 = (undefined8 *)0x0;
    uStack_4f8 = 0;
    local_490 = (undefined8 *)0x0;
    uStack_488 = 0;
    local_480 = 0;
    local_c80[0] = 0;
    if (*(longlong *)(this + 0x828) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x828) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    local_c78 = *(undefined8 *)(this + 0x820);
    local_c70 = *(undefined8 *)(this + 0x828);
    local_c68 = "Camera1";
    local_c60 = local_1078;
    local_c58 = CONCAT44(local_1098._4_4_,(undefined4)local_1098);
    local_c50 = local_10c0;
    local_c48 = local_10bc;
    local_c40 = local_10ac;
    local_c38 = local_10a8[0];
    local_c30 = &local_548;
    local_c20 = _extractClubTracking;
    puVar22 = local_c80;
    local_c28 = this;
    local_490 = FUN_1800fdb90(plVar12,puVar22);
    uStack_488 = uStack_488 & 0xffffffffffffff00;
    local_480 = local_480 & 0xffffffffffffff00;
    FUN_180082f80((longlong)local_c80);
    plVar12 = FUN_1800fb950((longlong *)&local_490);
    FUN_1800fb9e0((longlong *)&local_500,puVar22,plVar12);
    FUN_180008c60((longlong *)&local_490);
    FUN_1800706f0(local_4f0);
    plVar12 = local_1060;
    local_1000 = local_1060;
    local_ff8 = &local_570;
    local_fe8 = _extractClubTracking;
    local_ff0 = this;
    FUN_1800fb130(local_4f0,puVar22,&local_fe8,&local_ff0,&local_ff8,&local_10b0,&local_10b4,
                  &local_10bc,&local_10c0,&local_10a0,&local_1000,"Camera2",
                  (undefined8 *)(this + 0x830),&local_10c4);
    cVar7 = FUN_1800f6540((longlong *)&local_500);
    cVar8 = FUN_1800f6540((longlong *)local_4f0);
    FUN_1800090b0(&local_fe0);
    local_fd0 = local_fe0 - local_fd8;
    FUN_1800084f0((longlong *)&local_1058,&local_fd0);
    filterByMatchingID(this,(deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                             *)&local_548,
                       (deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                        *)&local_570);
    plVar18 = FUN_1800014c0();
    puVar16 = FUN_180084840(local_910,local_1058);
    plVar15 = FUN_1800066b0(local_930,"[Segmentation.Club] Time to track club >>  ",puVar16);
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              FUN_18000a510(local_950,plVar15,&DAT_180175e94);
    puVar16 = (undefined8 *)0x1;
    FUN_180084c00(plVar18,pbVar13,1,'\x01');
    FUN_18000c8d0(local_930);
    FUN_18000c8d0(local_910);
    if (((local_528 < 3) || (local_550 < 3)) || ((cVar7 == '\0' || (cVar8 == '\0')))) {
      FUN_1800f8170((longlong)&local_548);
      FUN_1800f8170((longlong)&local_570);
      local_10c4 = 1;
      puVar16 = FUN_18000c890(local_8f0,&DAT_18016a0f8);
      loadTracker(this,1,puVar16);
      plVar18 = FUN_1800014c0();
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                FUN_18000c890(local_8d0,
                              "[Segmentation.Club] Fail to extract club with Median Flow tracker. Trying to extract the club with CSRT tracker"
                             );
      FUN_180084c00(plVar18,pbVar13,2,'\x01');
      plVar18 = FUN_1800090b0(&local_bf8);
      lVar34 = *plVar18;
      local_fc8 = plVar12;
      local_fc0 = &local_570;
      local_fb0 = _extractClubTracking;
      local_fb8 = this;
      plVar12 = FUN_1800fb130(local_be8,pbVar13,&local_fb0,&local_fb8,&local_fc0,&local_10b0,
                              &local_10b4,&local_10bc,&local_10c0,&local_10a0,&local_fc8,"Camera2",
                              (undefined8 *)(this + 0x830),&local_10c4);
      FUN_1800f5eb0((longlong *)local_4f0,plVar12);
      FUN_180008c60(local_be8);
      local_fa8 = local_1078;
      local_fa0 = &local_548;
      local_f90 = _extractClubTracking;
      local_f98 = this;
      plVar12 = FUN_1800fb130(local_c18,plVar12,&local_f90,&local_f98,&local_fa0,local_10a8,
                              &local_10ac,&local_10bc,&local_10c0,&local_1098,&local_fa8,"Camera1",
                              (undefined8 *)(this + 0x820),&local_10c4);
      FUN_1800f5eb0((longlong *)&local_500,plVar12);
      FUN_180008c60(local_c18);
      cVar7 = FUN_1800f6540((longlong *)&local_500);
      cVar8 = FUN_1800f6540((longlong *)local_4f0);
      plVar12 = FUN_1800090b0(&local_bf0);
      local_f88 = *plVar12 - lVar34;
      puVar23 = (ulonglong *)FUN_1800084f0(&local_c00,&local_f88);
      uVar31 = *puVar23;
      local_1058 = uVar31;
      filterByMatchingID(this,(deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                               *)&local_548,
                         (deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                          *)&local_570);
      plVar12 = FUN_1800014c0();
      puVar16 = FUN_180084840(local_890,uVar31);
      plVar18 = FUN_1800066b0(local_8b0,
                              "[Segmentation.Club] Time to extract club centroid with CSRT >>  ",
                              puVar16);
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                FUN_18000a510(local_810,plVar18,&DAT_180175e94);
      puVar16 = (undefined8 *)0x1;
      FUN_180084c00(plVar12,pbVar13,1,'\x01');
      FUN_18000c8d0(local_8b0);
      FUN_18000c8d0(local_890);
      if ((cVar7 == '\0') || (cVar8 == '\0')) {
        plVar12 = FUN_1800014c0();
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_18000c890(local_870,
                                "[Segmentation.Club] Fail to extract club with CSRT tracker. Club detection won\'t be accurate."
                               );
        puVar16 = (undefined8 *)0x3;
        FUN_180084c00(plVar12,pbVar13,3,'\x01');
      }
    }
    if ((local_528 != 0) && (local_550 != 0)) {
      FUN_180006580((longlong *)(param_1 + 0x2e0));
      FUN_180006580((longlong *)(param_1 + 0x2f8));
      FUN_18000c400((longlong *)(param_1 + 0x360),(longlong *)&local_5a0,puVar16);
      puVar17 = local_1070;
      puVar24 = (undefined8 *)
                Libraries::CamerasCore::Frame::getCaptureRect((Frame *)(local_1070 + 8));
      uVar19 = puVar24[1];
      *(undefined8 *)(param_1 + 0x388) = *puVar24;
      *(undefined8 *)(param_1 + 0x390) = uVar19;
      dVar39 = (double)puVar17[0x14];
      *(double *)(param_1 + 0x380) = dVar39;
      if (dVar39 == 0.0) {
        FUN_18000c890(local_b70,"Camera1");
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_180115ca0(local_850,local_b70,puVar16);
        pPVar14 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar13);
        dVar39 = Libraries::Core::Parameter::toDouble(pPVar14);
        *(double *)(param_1 + 0x380) = dVar39;
        FUN_18000c8d0(local_850);
        FUN_18000c8d0(local_b70);
      }
      iVar30 = (int)local_528 + -1;
      if (-1 < iVar30) {
        lVar34 = (longlong)iVar30;
        do {
          puVar22 = *(undefined4 **)(lStack_540 + (local_538 - 1U & lStack_530 + lVar34) * 8);
          puVar1 = *(undefined4 **)(param_1 + 0x2e8);
          if (puVar1 == *(undefined4 **)(param_1 + 0x2f0)) {
            FUN_180046a00((longlong *)(param_1 + 0x2e0),puVar1,puVar22);
          }
          else {
            *puVar1 = *puVar22;
            *(longlong *)(param_1 + 0x2e8) = *(longlong *)(param_1 + 0x2e8) + 4;
          }
          puVar16 = (undefined8 *)(puVar22 + 10);
          puVar17 = *(undefined8 **)(param_1 + 0x300);
          if (puVar17 == *(undefined8 **)(param_1 + 0x308)) {
            FUN_1800468a0((longlong *)(param_1 + 0x2f8),puVar17,puVar16);
          }
          else {
            *puVar17 = *puVar16;
            *(longlong *)(param_1 + 0x300) = *(longlong *)(param_1 + 0x300) + 8;
          }
          lVar34 = lVar34 + -1;
          iVar30 = iVar30 + -1;
        } while (-1 < iVar30);
      }
      puVar17 = local_590;
      if (*(longlong *)(param_1 + 0x490) != *(longlong *)(param_1 + 0x498)) {
        *(longlong *)(param_1 + 0x498) = *(longlong *)(param_1 + 0x490);
      }
      if (*(longlong *)(param_1 + 0x4a8) != *(longlong *)(param_1 + 0x4b0)) {
        *(longlong *)(param_1 + 0x4b0) = *(longlong *)(param_1 + 0x4a8);
      }
      _Dst = param_1 + 0x510;
      if (_Dst != (Shot *)&local_5a0) {
        ppppuVar25 = &local_5a0;
        if (0xf < uStack_588) {
          ppppuVar25 = (undefined8 ****)local_5a0;
        }
        if (*(undefined8 **)(param_1 + 0x528) < local_590) {
          FUN_18000c490((longlong *)_Dst,(ulonglong)local_590,puVar16,ppppuVar25);
        }
        else {
          if ((undefined8 *)0xf < *(undefined8 **)(param_1 + 0x528)) {
            _Dst = *(Shot **)_Dst;
          }
          *(undefined8 **)(param_1 + 0x520) = local_590;
          puVar16 = local_590;
          memmove(_Dst,ppppuVar25,(size_t)local_590);
          _Dst[(longlong)puVar17] = (Shot)0x0;
        }
      }
      puVar17 = local_1068;
      puVar24 = (undefined8 *)
                Libraries::CamerasCore::Frame::getCaptureRect((Frame *)(local_1068 + 8));
      uVar19 = puVar24[1];
      *(undefined8 *)(param_1 + 0x538) = *puVar24;
      *(undefined8 *)(param_1 + 0x540) = uVar19;
      dVar39 = (double)puVar17[0x14];
      *(double *)(param_1 + 0x530) = dVar39;
      if (dVar39 == 0.0) {
        FUN_18000c890(local_b50,"Camera2");
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_180115ca0(local_830,local_b50,puVar16);
        pPVar14 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar13);
        dVar39 = Libraries::Core::Parameter::toDouble(pPVar14);
        *(double *)(param_1 + 0x530) = dVar39;
        FUN_18000c8d0(local_830);
        FUN_18000c8d0(local_b50);
      }
      iVar30 = (int)local_550 + -1;
      if (-1 < iVar30) {
        lVar34 = (longlong)iVar30;
        do {
          puVar22 = *(undefined4 **)(lStack_568 + (local_560 - 1U & lStack_558 + lVar34) * 8);
          puVar1 = *(undefined4 **)(param_1 + 0x498);
          if (puVar1 == *(undefined4 **)(param_1 + 0x4a0)) {
            FUN_180046a00((longlong *)(param_1 + 0x490),puVar1,puVar22);
          }
          else {
            *puVar1 = *puVar22;
            *(longlong *)(param_1 + 0x498) = *(longlong *)(param_1 + 0x498) + 4;
          }
          puVar16 = *(undefined8 **)(param_1 + 0x4b0);
          if (puVar16 == *(undefined8 **)(param_1 + 0x4b8)) {
            FUN_1800468a0((longlong *)(param_1 + 0x4a8),puVar16,(undefined8 *)(puVar22 + 10));
          }
          else {
            *puVar16 = *(undefined8 *)(puVar22 + 10);
            *(longlong *)(param_1 + 0x4b0) = *(longlong *)(param_1 + 0x4b0) + 8;
          }
          lVar34 = lVar34 + -1;
          iVar30 = iVar30 + -1;
        } while (-1 < iVar30);
      }
    }
    if (local_4f0[0] != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(local_4f0[0] + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)local_4f0[0][0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*local_4f0[0])(local_4f0[0],1);
        }
        else {
          (**(code **)*puVar16)(puVar16,local_4f0[0]);
        }
      }
    }
    if (local_500 != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(local_500 + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)local_500[0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*local_500)(local_500,1);
        }
        else {
          (**(code **)*puVar16)(puVar16,local_500);
        }
      }
    }
    FUN_1800f8170((longlong)&local_570);
    plVar12 = local_570;
    local_570 = (longlong *)0x0;
    free(plVar12);
    FUN_1800f8170((longlong)&local_548);
    plVar12 = local_548;
    local_548 = (longlong *)0x0;
    free(plVar12);
    FUN_18000c8d0(local_2d8);
    FUN_18000c8d0(local_2f8);
    FUN_18000c8d0(local_338);
  }
  FUN_18000c8d0((longlong *)local_3d8);
  plVar12 = plStack_518;
  if (plStack_518 != (longlong *)0x0) {
    LOCK();
    plVar18 = plStack_518 + 1;
    lVar34 = *plVar18;
    *(int *)plVar18 = (int)*plVar18 + -1;
    UNLOCK();
    if ((int)lVar34 == 1) {
      (**(code **)*plStack_518)(plStack_518);
      LOCK();
      piVar26 = (int *)((longlong)plVar12 + 0xc);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        (**(code **)(*plVar12 + 8))(plVar12);
      }
    }
  }
  plVar12 = plStack_508;
  if (plStack_508 != (longlong *)0x0) {
    LOCK();
    plVar18 = plStack_508 + 1;
    lVar34 = *plVar18;
    *(int *)plVar18 = (int)*plVar18 + -1;
    UNLOCK();
    if ((int)lVar34 == 1) {
      (**(code **)*plStack_508)(plStack_508);
      LOCK();
      piVar26 = (int *)((longlong)plVar12 + 0xc);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        (**(code **)(*plVar12 + 8))(plVar12);
      }
    }
  }
  cv::Mat::~Mat(local_230);
  cv::Mat::~Mat(local_290);
  FUN_18000c8d0((longlong *)local_2b8);
  cv::Mat::~Mat(local_120);
  cv::Mat::~Mat(local_180);
  FUN_18000c8d0((longlong *)local_1a8);
  plVar12 = plStack_5a8;
  if (plStack_5a8 != (longlong *)0x0) {
    LOCK();
    plVar18 = plStack_5a8 + 1;
    lVar34 = *plVar18;
    *(int *)plVar18 = (int)*plVar18 + -1;
    UNLOCK();
    if ((int)lVar34 == 1) {
      (**(code **)*plStack_5a8)(plStack_5a8);
      LOCK();
      piVar26 = (int *)((longlong)plVar12 + 0xc);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        (**(code **)(*plVar12 + 8))(plVar12);
      }
    }
  }
  plVar12 = plStack_5b8;
  if (plStack_5b8 != (longlong *)0x0) {
    LOCK();
    plVar18 = plStack_5b8 + 1;
    lVar34 = *plVar18;
    *(int *)plVar18 = (int)*plVar18 + -1;
    UNLOCK();
    if ((int)lVar34 == 1) {
      (**(code **)*plStack_5b8)(plStack_5b8);
      LOCK();
      piVar26 = (int *)((longlong)plVar12 + 0xc);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        (**(code **)(*plVar12 + 8))(plVar12);
      }
    }
  }
  FUN_18000c8d0(&local_478);
LAB_1800f57f2:
  FUN_18000c8d0((longlong *)&local_5a0);
  return;
}

