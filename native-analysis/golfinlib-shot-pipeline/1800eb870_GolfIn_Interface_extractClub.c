FUNCTION: GolfIn::Interface::extractClub
ENTRY: 1800eb870
REASONS: name:club


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
/* protected: void __cdecl GolfIn::Interface::extractClub(class GolfIn::Shot & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::map<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> >,class Libraries::CamerasCore::Frame,struct std::less<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class
   std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const ,class Libraries::CamerasCore::Frame> > > const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64) __ptr64 */

void __thiscall
GolfIn::Interface::extractClub
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
  bool bStack_10d4;
  bool abStack_10c8 [4];
  undefined4 uStack_10c4;
  int iStack_10c0;
  int iStack_10bc;
  int iStack_10b8;
  int iStack_10b4;
  int iStack_10b0;
  int iStack_10ac;
  int aiStack_10a8 [2];
  undefined8 uStack_10a0;
  undefined8 uStack_1098;
  undefined4 uStack_1090;
  undefined4 uStack_108c;
  undefined4 auStack_1088 [2];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_1080;
  longlong *plStack_1078;
  undefined8 *puStack_1070;
  undefined8 *puStack_1068;
  longlong *plStack_1060;
  ulonglong uStack_1058;
  undefined8 *puStack_1050;
  undefined8 *puStack_1048;
  undefined8 uStack_1040;
  undefined8 ***pppuStack_1038;
  undefined8 uStack_1030;
  undefined8 *puStack_1028;
  ulonglong uStack_1020;
  longlong lStack_1018;
  longlong lStack_1010;
  longlong lStack_1008;
  longlong *plStack_1000;
  longlong **pplStack_ff8;
  Interface *pIStack_ff0;
  code *pcStack_fe8;
  longlong lStack_fe0;
  longlong lStack_fd8;
  longlong lStack_fd0;
  longlong *plStack_fc8;
  longlong **pplStack_fc0;
  Interface *pIStack_fb8;
  code *pcStack_fb0;
  longlong *plStack_fa8;
  longlong **pplStack_fa0;
  Interface *pIStack_f98;
  code *pcStack_f90;
  longlong lStack_f88;
  longlong lStack_f80;
  undefined8 uStack_f78;
  undefined8 uStack_f70;
  undefined8 uStack_f68;
  longlong lStack_f60;
  longlong lStack_f58;
  undefined8 uStack_f50;
  undefined8 uStack_f48;
  undefined8 uStack_f40;
  longlong lStack_f38;
  undefined8 uStack_f30;
  undefined8 *puStack_f28;
  ulonglong uStack_f20;
  longlong lStack_f18;
  longlong lStack_f10;
  longlong lStack_f08;
  longlong lStack_f00;
  longlong lStack_ef8;
  longlong lStack_ef0;
  undefined8 uStack_ee8;
  undefined8 *puStack_ee0;
  ulonglong uStack_ed8;
  longlong lStack_ed0;
  longlong lStack_ec8;
  longlong lStack_ec0;
  longlong lStack_eb8;
  undefined8 uStack_eb0;
  undefined8 uStack_ea8;
  undefined8 uStack_ea0;
  undefined8 uStack_e98;
  undefined8 uStack_e90;
  undefined8 uStack_e88;
  undefined8 uStack_e80;
  undefined8 uStack_e78;
  undefined8 uStack_e70;
  undefined8 uStack_e68;
  undefined8 uStack_e60;
  undefined8 uStack_e58;
  undefined8 uStack_e50;
  undefined8 uStack_e48;
  longlong lStack_e40;
  longlong lStack_e38;
  longlong lStack_e30;
  longlong lStack_e28;
  undefined8 uStack_e20;
  undefined8 uStack_e18;
  undefined8 uStack_e10;
  undefined8 uStack_e08;
  undefined8 uStack_e00;
  undefined8 uStack_df8;
  undefined8 uStack_df0;
  undefined8 uStack_de8;
  undefined8 uStack_de0;
  undefined8 uStack_dd8;
  undefined8 uStack_dd0;
  undefined8 uStack_dc8;
  longlong lStack_dc0;
  longlong lStack_db8;
  longlong lStack_db0;
  longlong lStack_da8;
  longlong lStack_da0;
  longlong lStack_d98;
  longlong lStack_d90;
  longlong lStack_d88;
  undefined8 uStack_d80;
  undefined8 uStack_d78;
  undefined8 uStack_d70;
  undefined8 uStack_d68;
  longlong lStack_d60;
  undefined8 uStack_d58;
  undefined8 uStack_d50;
  undefined8 uStack_d48;
  longlong lStack_d40;
  undefined8 uStack_d38;
  undefined8 uStack_d30;
  undefined8 uStack_d28;
  longlong lStack_d20;
  undefined8 uStack_d18;
  undefined8 uStack_d10;
  undefined8 uStack_d08;
  longlong lStack_d00;
  undefined8 uStack_cf8;
  undefined8 uStack_cf0;
  undefined8 uStack_ce8;
  longlong lStack_ce0;
  undefined8 uStack_cd8;
  undefined8 uStack_cd0;
  undefined8 uStack_cc8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> abStack_cc0 [16];
  undefined8 uStack_cb0;
  undefined8 uStack_ca8;
  longlong lStack_ca0;
  undefined8 uStack_c98;
  undefined8 uStack_c90;
  undefined8 uStack_c88;
  undefined4 auStack_c80 [2];
  undefined8 uStack_c78;
  undefined8 uStack_c70;
  char *pcStack_c68;
  longlong *plStack_c60;
  undefined8 uStack_c58;
  int iStack_c50;
  int iStack_c48;
  int iStack_c40;
  int iStack_c38;
  longlong **pplStack_c30;
  Interface *pIStack_c28;
  code *pcStack_c20;
  longlong alStack_c18 [2];
  undefined8 **ppuStack_c08;
  longlong lStack_c00;
  longlong lStack_bf8;
  longlong lStack_bf0;
  longlong alStack_be8 [2];
  longlong lStack_bd8;
  longlong lStack_bd0;
  longlong lStack_bc8;
  longlong lStack_bc0;
  longlong lStack_bb8;
  longlong lStack_bb0;
  longlong lStack_ba8;
  longlong lStack_ba0;
  char acStack_b98 [32];
  longlong lStack_b78;
  longlong alStack_b70 [4];
  longlong alStack_b50 [4];
  longlong alStack_b30 [4];
  longlong alStack_b10 [6];
  char acStack_ae0 [32];
  char acStack_ac0 [48];
  longlong alStack_a90 [4];
  longlong alStack_a70 [4];
  longlong alStack_a50 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> abStack_a30 [32];
  undefined8 auStack_a10 [4];
  undefined8 auStack_9f0 [4];
  longlong alStack_9d0 [4];
  char acStack_9b0 [32];
  char acStack_990 [32];
  char acStack_970 [32];
  longlong alStack_950 [4];
  longlong alStack_930 [4];
  longlong alStack_910 [4];
  undefined8 auStack_8f0 [4];
  undefined8 auStack_8d0 [4];
  longlong alStack_8b0 [4];
  longlong alStack_890 [4];
  undefined8 auStack_870 [4];
  longlong alStack_850 [4];
  longlong alStack_830 [4];
  longlong alStack_810 [5];
  Mat aMStack_7e8 [96];
  Mat aMStack_788 [96];
  Mat aMStack_728 [96];
  Mat aMStack_6c8 [96];
  undefined4 auStack_668 [40];
  char acStack_5c8 [8];
  undefined8 uStack_5c0;
  longlong *plStack_5b8;
  undefined8 uStack_5b0;
  longlong *plStack_5a8;
  undefined8 ***pppuStack_5a0;
  undefined8 uStack_598;
  undefined8 *puStack_590;
  ulonglong uStack_588;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_580;
  undefined8 uStack_578;
  longlong *plStack_570;
  longlong lStack_568;
  longlong lStack_560;
  longlong lStack_558;
  ulonglong uStack_550;
  longlong *plStack_548;
  longlong lStack_540;
  longlong lStack_538;
  longlong lStack_530;
  ulonglong uStack_528;
  longlong lStack_520;
  longlong *plStack_518;
  longlong lStack_510;
  longlong *plStack_508;
  undefined8 *puStack_500;
  undefined8 uStack_4f8;
  undefined8 *apuStack_4f0 [2];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_4e0;
  undefined8 uStack_4d8;
  undefined8 *puStack_4d0;
  undefined8 uStack_4c8;
  undefined8 *puStack_4c0;
  undefined8 uStack_4b8;
  undefined8 *puStack_4b0;
  undefined8 uStack_4a8;
  undefined8 *puStack_4a0;
  undefined8 uStack_498;
  undefined8 *puStack_490;
  ulonglong uStack_488;
  ulonglong uStack_480;
  longlong lStack_478;
  longlong lStack_470;
  longlong lStack_468;
  longlong lStack_460;
  longlong lStack_458;
  undefined8 uStack_450;
  undefined8 uStack_448;
  undefined8 *puStack_440;
  undefined8 *puStack_438;
  undefined8 **ppuStack_430;
  longlong *plStack_428;
  undefined8 uStack_420;
  Interface *pIStack_418;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_410;
  longlong *plStack_408;
  undefined8 *puStack_400;
  Interface *pIStack_3f8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_3f0;
  longlong *plStack_3e8;
  undefined8 *puStack_3e0;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> abStack_3d8 [32];
  Interface *pIStack_3b8;
  char *pcStack_3b0;
  longlong *plStack_3a8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_3a0;
  longlong *plStack_398;
  undefined8 *puStack_390;
  Interface *pIStack_388;
  char *pcStack_380;
  longlong *plStack_378;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_370;
  longlong *plStack_368;
  undefined8 *puStack_360;
  GICTSShotData aGStack_358 [32];
  longlong alStack_338 [8];
  longlong alStack_2f8 [4];
  longlong alStack_2d8 [4];
  ClubDetectionInput aCStack_2b8 [40];
  Mat aMStack_290 [96];
  Mat aMStack_230 [132];
  undefined4 uStack_1ac;
  ClubDetectionInput aCStack_1a8 [40];
  Mat aMStack_180 [96];
  Mat aMStack_120 [132];
  undefined4 uStack_9c;
  undefined1 uStack_84;
  undefined1 auStack_83 [3];
  ulonglong uStack_80;
  
                    /* 0xeb870  563
                       ?extractClub@Interface@GolfIn@@IEAAXAEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@5@1@Z
                        */
  uStack_80 = DAT_1801d1040 ^ (ulonglong)auStackY_1148;
  fVar36 = DAT_18017e95c;
  pbStack_1080 = param_2;
  if (this[0x31d] != (Interface)0x0) {
    fVar36 = getCalibrationPPMM(this,false);
  }
  fVar36 = fVar36 * _DAT_18017ec60 * DAT_18017e97c;
  pppuStack_5a0 = (undefined8 ****)0x0;
  uStack_598 = 0;
  puStack_590 = (undefined8 *)0x0;
  uStack_588 = 0;
  FUN_18000c1d0(&pppuStack_5a0,"unknown",7);
  lStack_d60 = 0;
  uStack_d58 = 0;
  uStack_d50 = 0;
  uStack_d48 = 0;
  FUN_18000c1d0(&lStack_d60,"Camera1",7);
  plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&lStack_d60);
  puVar16 = *(undefined8 **)param_3;
  cVar7 = *(char *)((longlong)puVar16[1] + 0x19);
  puVar17 = puVar16;
  puStack_1070 = puVar16;
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
     (puStack_1070 = puVar17, uVar9 = FUN_180008ca0(plVar12,puVar17 + 4), (char)uVar9 < '\0')) {
    puVar17 = puVar16;
    puStack_1070 = puVar16;
  }
  FUN_18000c8d0(&lStack_d60);
  plStack_1078 = puVar17 + 9;
  if (*plStack_1078 == puVar17[10]) goto LAB_1800f57f2;
  lStack_d40 = 0;
  uStack_d38 = 0;
  uStack_d30 = 0;
  uStack_d28 = 0;
  FUN_18000c1d0(&lStack_d40,"Camera2",7);
  plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&lStack_d40);
  puVar16 = *(undefined8 **)param_3;
  cVar7 = *(char *)((longlong)puVar16[1] + 0x19);
  puVar17 = puVar16;
  puStack_1068 = puVar16;
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
     (puStack_1068 = puVar17, uVar9 = FUN_180008ca0(plVar12,puVar17 + 4), (char)uVar9 < '\0')) {
    puVar17 = puVar16;
    puStack_1068 = puVar16;
  }
  FUN_18000c8d0(&lStack_d40);
  plStack_1060 = puVar17 + 9;
  if (*plStack_1060 == puVar17[10]) goto LAB_1800f57f2;
  iVar30 = *(int *)(param_1 + 0x24);
  if (iVar30 < 6) {
    plVar12 = FUN_1800014c0();
    ppppuVar25 = &pppuStack_5a0;
    if (0xf < uStack_588) {
      ppppuVar25 = (undefined8 ****)pppuStack_5a0;
    }
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(acStack_ae0,
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
  iStack_10c0 = (int)dVar39;
  if (iStack_10c0 < 1) {
    iStack_10c0 = 1;
  }
  iStack_10c0 = iStack_10c0 + 1;
  iVar30 = iVar30 - iStack_10c0;
  uStack_1090 = 5;
  for (piVar26 = *(int **)(param_1 + 0x60); iStack_10b8 = iVar30,
      piVar26 != *(int **)(param_1 + 0x68); piVar26 = piVar26 + 6) {
    if (*piVar26 == 5) {
      uStack_e78 = *(undefined8 *)piVar26;
      uStack_e70 = *(undefined8 *)(piVar26 + 2);
      uStack_e68 = *(undefined8 *)(piVar26 + 4);
      goto LAB_1800f30cc;
    }
    if (piVar26 == *(int **)(param_1 + 0x68)) break;
  }
  FUN_1800a40b0((undefined4 *)&uStack_e78);
LAB_1800f30cc:
  uStack_1098._0_4_ = (undefined4)uStack_e70;
  uStack_1098._4_4_ = uStack_e70._4_4_;
  uStack_108c = 5;
  for (piVar26 = *(int **)(param_1 + 0x180); piVar26 != *(int **)(param_1 + 0x188);
      piVar26 = piVar26 + 6) {
    if (*piVar26 == 5) {
      uStack_e90 = *(undefined8 *)piVar26;
      uStack_e88 = *(undefined8 *)(piVar26 + 2);
      uStack_e80 = *(undefined8 *)(piVar26 + 4);
      goto LAB_1800f313c;
    }
    if (piVar26 == *(int **)(param_1 + 0x188)) break;
  }
  FUN_1800a40b0((undefined4 *)&uStack_e90);
LAB_1800f313c:
  uStack_10a0._0_4_ = (undefined4)uStack_e88;
  uStack_10a0._4_4_ = uStack_e88._4_4_;
  uStack_1030 = 0;
  puStack_1028 = _DAT_18017ef00;
  uStack_1020 = _UNK_18017ef08;
  pppuStack_1038 = (undefined8 ****)0x0;
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
  FUN_18000a490((longlong *)&pppuStack_1038,pcVar27,sVar33);
  if (0xf < uStack_588) {
    ppppuVar25 = (undefined8 ****)pppuStack_5a0;
    if ((0xfff < uStack_588 + 1) &&
       (ppppuVar25 = (undefined8 ****)pppuStack_5a0[-1],
       0x1f < (ulonglong)((longlong)pppuStack_5a0 + (-8 - (longlong)ppppuVar25)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(ppppuVar25);
  }
  pppuStack_5a0 = pppuStack_1038;
  uStack_598 = uStack_1030;
  puStack_590 = puStack_1028;
  uStack_588 = uStack_1020;
  puStack_1028 = _DAT_18017ef00;
  uStack_1020 = _UNK_18017ef08;
  pppuStack_1038 = (undefined8 ***)((ulonglong)pppuStack_1038 & 0xffffffffffffff00);
  FUN_18000c8d0((longlong *)&pppuStack_1038);
  plVar12 = FUN_1800014c0();
  ppppuVar25 = &pppuStack_5a0;
  if (0xf < uStack_588) {
    ppppuVar25 = (undefined8 ****)pppuStack_5a0;
  }
  pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format(acStack_ac0,"[Segmentation.Club] Player hand set to : %s",ppppuVar25);
  FUN_180084c00(plVar12,pbVar13,1,'\x01');
  lStack_d20 = 0;
  uStack_d18 = 0;
  uStack_d10 = 0;
  uStack_d08 = 0;
  FUN_18000c1d0(&lStack_d20,"Configurations.Debug.UseCameras",0x1f);
  pPVar14 = Libraries::Core::Parameters::get
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&lStack_d20);
  bVar5 = Libraries::Core::Parameter::toBoolean(pPVar14);
  if ((bVar5) && (*(longlong *)(this + 0x298) != 0)) {
    bVar5 = true;
  }
  else {
    bVar5 = false;
  }
  FUN_18000c8d0(&lStack_d20);
  if (bVar5) {
    plVar12 = *(longlong **)(this + 0x298);
    uStack_f30 = 0;
    puStack_f28 = _DAT_18017ef00;
    uStack_f20 = _UNK_18017ef08;
    lStack_f38 = 0;
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
    FUN_18000a490(&lStack_f38,pcVar27,sVar33);
    puStack_1050 = (undefined8 *)0x0;
    puStack_1048 = (undefined8 *)0x0;
    uStack_1040 = 0;
    FUN_18000bc20((ulonglong *)&puStack_1050,1);
    puVar16 = puStack_1050;
    ppuStack_c08 = &puStack_1050;
    puStack_440 = puStack_1050;
    puStack_438 = puStack_1050;
    ppuStack_430 = &puStack_1050;
    FUN_18000cb00(puStack_1050,&lStack_f38);
    puStack_1048 = puVar16 + 4;
    auStack_1088[0] = 1;
    lStack_d00 = 0;
    uStack_cf8 = 0;
    uStack_cf0 = 0;
    uStack_ce8 = 0;
    puStack_438 = puStack_1048;
    FUN_18000c1d0(&lStack_d00,"Camera1",7);
    plVar15 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&lStack_d00);
    plVar18 = plVar12 + 2;
    uStack_420 = 0;
    plStack_428 = plVar18;
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
      lStack_458 = 0;
      uStack_450 = 0;
      uStack_448 = 0;
      (**(code **)(*plVar12 + 0x18))(plVar12,plVar15,auStack_1088,&puStack_1050);
      FUN_18000bd00(&lStack_458);
    }
    _Mtx_unlock(plVar18);
    FUN_18000c8d0(&lStack_d00);
    FUN_18000bd00((longlong *)&puStack_1050);
    _eh_vector_destructor_iterator_(&lStack_f38,0x20,1,thunk_FUN_18000c8d0);
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
  iStack_10bc = iVar10;
  plVar12 = FUN_1800014c0();
  pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format(acStack_b98,"[Segmentation.Club] Skip every %d frames for the club tracking."
                       ,uVar31);
  FUN_180084c00(plVar12,pbVar13,1,'\x01');
  iStack_10b4 = iVar30 + iVar10 * -10;
  if (iStack_10b4 < 0) {
    iStack_10b4 = 0;
  }
  uVar31 = (longlong)(iVar30 - iStack_10b4) / (longlong)iVar10;
  iStack_10b0 = iVar30;
  iStack_10ac = iStack_10b4;
  aiStack_10a8[0] = iVar30;
  plVar12 = FUN_1800014c0();
  uVar11 = (uint)uVar31;
  puVar16 = FUN_18000c2d0(alStack_a90,uVar11);
  puVar16 = FUN_180007680(puVar16,0,"[Segmentation.Club] Nb. image detection : ",0x2a);
  uStack_eb0 = *puVar16;
  uStack_ea8 = puVar16[1];
  uStack_ea0 = puVar16[2];
  uStack_e98 = puVar16[3];
  puVar16[2] = 0;
  puVar16[3] = 0xf;
  *(undefined1 *)puVar16 = 0;
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&uStack_eb0,0,'\x01');
  FUN_18000c8d0(alStack_a90);
  plVar12 = FUN_1800014c0();
  if ((int)uVar11 < 0) {
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(acStack_b98,
                         "[Segmentation Club] Anormal nb of image detected: %d. No club detection will be available."
                         ,uVar31 & 0xffffffff);
    FUN_180084c00(plVar12,pbVar13,3,'\x01');
    goto LAB_1800f57f2;
  }
  uVar11 = _Thrd_hardware_concurrency();
  puVar16 = FUN_1800a3260(alStack_a50,uVar11);
  puVar17 = FUN_18000c2d0(alStack_a70,*(uint *)(this + 0x1d8));
  uStack_84 = 0x31;
  lStack_ef0 = 0;
  uStack_ee8 = 0;
  puStack_ee0 = (undefined8 *)0x0;
  uStack_ed8 = 0;
  if (&uStack_84 == auStack_83) {
    puStack_ee0 = _DAT_18017ef00;
    uStack_ed8 = _UNK_18017ef08;
    lStack_ef0 = 0;
  }
  else {
    FUN_18000c1d0(&lStack_ef0,&uStack_84,(size_t)(auStack_83 + -(longlong)&uStack_84));
  }
  plVar18 = FUN_180007680(&lStack_ef0,0,"[Segmentation.Club] Executing on multi-thread: ",0x2f);
  lStack_da0 = *plVar18;
  lStack_d98 = plVar18[1];
  lStack_d90 = plVar18[2];
  lStack_d88 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  pcVar27 = " threads. Using ";
  plVar18 = FUN_18000a490(&lStack_da0," threads. Using ",0x10);
  lStack_bb8 = *plVar18;
  lStack_bb0 = plVar18[1];
  lStack_ba8 = plVar18[2];
  lStack_ba0 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  FUN_1800228c0(alStack_b10,pcVar27,&lStack_bb8,puVar17);
  puVar28 = &DAT_18017809c;
  plVar18 = FUN_18000a490(alStack_b10,&DAT_18017809c,3);
  lStack_bd8 = *plVar18;
  lStack_bd0 = plVar18[1];
  lStack_bc8 = plVar18[2];
  lStack_bc0 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  FUN_1800228c0(alStack_b30,puVar28,&lStack_bd8,puVar16);
  plVar18 = FUN_18000a490(alStack_b30," threads.",9);
  lStack_ed0 = *plVar18;
  lStack_ec8 = plVar18[1];
  lStack_ec0 = plVar18[2];
  lStack_eb8 = plVar18[3];
  plVar18[2] = 0;
  plVar18[3] = 0xf;
  *(undefined1 *)plVar18 = 0;
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&lStack_ed0,1,'\x01');
  FUN_18000c8d0(alStack_b30);
  FUN_18000c8d0(&lStack_bd8);
  FUN_18000c8d0(alStack_b10);
  FUN_18000c8d0(&lStack_bb8);
  FUN_18000c8d0(&lStack_da0);
  FUN_18000c8d0(&lStack_ef0);
  FUN_18000c8d0(alStack_a70);
  FUN_18000c8d0(alStack_a50);
  FUN_1800090b0(&lStack_1008);
  lStack_ce0 = 0;
  uStack_cd8 = 0;
  uStack_cd0 = 0;
  uStack_cc8 = 0;
  FUN_18000c1d0(&lStack_ce0,"Results",7);
  plVar12 = (longlong *)getProcessImagesPath(this,abStack_a30);
  pbVar13 = pbStack_1080;
  if (0xf < *(ulonglong *)(pbStack_1080 + 0x18)) {
    pbVar13 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
               pbStack_1080;
  }
  plVar12 = FUN_18000a490(plVar12,pbVar13,*(size_t *)(pbStack_1080 + 0x10));
  lStack_dc0 = *plVar12;
  lStack_db8 = plVar12[1];
  lStack_db0 = plVar12[2];
  lStack_da8 = plVar12[3];
  plVar12[3] = 0xf;
  plVar12[2] = 0;
  *(undefined1 *)plVar12 = 0;
  plVar12 = FUN_18000a490(&lStack_dc0,"\\club_img_detection",0x13);
  lStack_478 = *plVar12;
  lStack_470 = plVar12[1];
  lStack_468 = plVar12[2];
  lStack_460 = plVar12[3];
  plVar12[2] = 0;
  plVar12[3] = 0xf;
  *(undefined1 *)plVar12 = 0;
  FUN_18000c8d0(&lStack_dc0);
  FUN_18000c8d0((longlong *)abStack_a30);
  FUN_18000c8d0(&lStack_ce0);
  pbStack_1080 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                 ((ulonglong)pbStack_1080 & 0xffffffff00000000);
  lStack_f58 = 0;
  uStack_f50 = 0;
  uStack_f48 = 0;
  uStack_f40 = 0;
  FUN_18000c1d0(&lStack_f58,"Configurations.Process.Club.DetectionMethodIndex",0x30);
  bVar5 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&lStack_f58);
  if (bVar5) {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&lStack_f58);
    iVar30 = Libraries::Core::Parameter::toInt(pPVar14);
  }
  else {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&lStack_f58);
    Libraries::Core::Parameter::setValue(pPVar14,(int *)&pbStack_1080);
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&lStack_f58);
    iVar30 = Libraries::Core::Parameter::toInt(pPVar14);
    saveParameters(this);
  }
  FUN_18000c8d0(&lStack_f58);
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
  uStack_5c0 = 0;
  plStack_5b8 = (longlong *)0x0;
  uStack_5b0 = 0;
  plStack_5a8 = (longlong *)0x0;
  if (DVar35 == 2) {
    if (*(longlong *)(this + 0x868) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x868) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_5c0 = *(undefined8 *)(this + 0x860);
    plStack_5b8 = *(longlong **)(this + 0x868);
    if (*(longlong *)(this + 0x878) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x878) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_5b0 = *(undefined8 *)(this + 0x870);
    plStack_5a8 = *(longlong **)(this + 0x878);
  }
  else if (DVar35 == 3) {
    if (*(longlong *)(this + 0x888) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x888) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_5c0 = *(undefined8 *)(this + 0x880);
    plStack_5b8 = *(longlong **)(this + 0x888);
    if (*(longlong *)(this + 0x898) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x898) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_5b0 = *(undefined8 *)(this + 0x890);
    plStack_5a8 = *(longlong **)(this + 0x898);
  }
  else if (DVar35 == 4) {
    if (*(longlong *)(this + 0x8a8) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x8a8) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_5c0 = *(undefined8 *)(this + 0x8a0);
    plStack_5b8 = *(longlong **)(this + 0x8a8);
    if (*(longlong *)(this + 0x8b8) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x8b8) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_5b0 = *(undefined8 *)(this + 0x8b0);
    plStack_5a8 = *(longlong **)(this + 0x8b8);
  }
  fVar37 = getCalibrationPPMM(this,false);
  if (((this[0x729] != (Interface)0x0) || (*(float *)(param_1 + 0x18) * fVar38 <= DAT_18017ec50)) ||
     (bStack_10d4 = true,
     DAT_18017ec5c < *(float *)(param_1 + 0x10) || DAT_18017ec5c == *(float *)(param_1 + 0x10))) {
    bStack_10d4 = false;
  }
  fVar38 = getCalibrationPPMM(this,false);
  bVar5 = _DAT_18017e978 < fVar38;
  abStack_cc0._0_12_ = ZEXT812(0);
  abStack_cc0._12_4_ = 0;
  uStack_cb0 = 0;
  uStack_ca8 = 0;
  FUN_18000c1d0((undefined8 *)abStack_cc0,"Camera1",7);
  lVar34 = (longlong)iStack_10b8;
  iVar30 = (int)(fVar36 + fVar36);
  Detection::ClubDetectionInput::ClubDetectionInput
            (aCStack_1a8,(Mat *)(lVar34 * 0x60 + *plStack_1078),(Mat *)(*plStack_1078 + 0x3c0),
             (Point_<float> *)&uStack_1098,iVar30,DVar35,iStack_10b8,abStack_cc0,fVar37,bStack_10d4,
             bVar5);
  FUN_18000c8d0((longlong *)abStack_cc0);
  lStack_ca0 = 0;
  uStack_c98 = 0;
  uStack_c90 = 0;
  uStack_c88 = 0;
  FUN_18000c1d0(&lStack_ca0,"Camera2",7);
  Detection::ClubDetectionInput::ClubDetectionInput
            (aCStack_2b8,(Mat *)(*plStack_1060 + lVar34 * 0x60),(Mat *)(*plStack_1060 + 0x3c0),
             (Point_<float> *)&uStack_10a0,iVar30,DVar35,iStack_10b8,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &lStack_ca0,fVar37,bStack_10d4,bVar5);
  FUN_18000c8d0(&lStack_ca0);
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
  lStack_510 = 0;
  plStack_508 = (longlong *)0x0;
  lStack_520 = 0;
  plStack_518 = (longlong *)0x0;
  abStack_10c8[0] = true;
  lStack_f80 = 0;
  uStack_f78 = 0;
  uStack_f70 = 0;
  uStack_f68 = 0;
  FUN_18000c1d0(&lStack_f80,"Configurations.Process.UseMLForClub",0x23);
  bVar5 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&lStack_f80);
  if (bVar5) {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&lStack_f80);
    acStack_5c8[0] = Libraries::Core::Parameter::toBoolean(pPVar14);
  }
  else {
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&lStack_f80);
    Libraries::Core::Parameter::setValue(pPVar14,abStack_10c8);
    pPVar14 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&lStack_f80);
    acStack_5c8[0] = Libraries::Core::Parameter::toBoolean(pPVar14);
    saveParameters(this);
  }
  FUN_18000c8d0(&lStack_f80);
  pbVar13 = abStack_3d8;
  getCurrentConfigParamFilePath(this);
  pcStack_3b0 = acStack_5c8;
  plStack_3a8 = &lStack_510;
  pbStack_3a0 = abStack_3d8;
  plStack_398 = &lStack_478;
  puStack_390 = &uStack_5c0;
  pcStack_380 = acStack_5c8;
  plStack_378 = &lStack_520;
  pbStack_370 = abStack_3d8;
  plStack_368 = &lStack_478;
  puStack_360 = &uStack_5c0;
  pbStack_3f0 = abStack_3d8;
  plStack_3e8 = &lStack_478;
  puStack_3e0 = &uStack_5c0;
  pbStack_410 = abStack_3d8;
  plStack_408 = &lStack_478;
  puStack_400 = &uStack_5c0;
  bVar5 = false;
  pIStack_418 = this;
  pIStack_3f8 = this;
  pIStack_3b8 = this;
  pIStack_388 = this;
  if (acStack_5c8[0] == '\0') {
LAB_1800f4459:
    puStack_4a0 = (undefined8 *)0x0;
    uStack_498 = 0;
    FUN_1800fad50(&puStack_4a0,pbVar13,&pIStack_3f8,aCStack_1a8);
    puStack_4d0 = (undefined8 *)0x0;
    uStack_4c8 = 0;
    FUN_1800faf40(&puStack_4d0,pbVar13,&pIStack_418,aCStack_2b8);
    FUN_180084940((longlong *)&puStack_4a0);
    FUN_180084940((longlong *)&puStack_4d0);
    *(undefined1 *)(*(longlong *)(this + 0x820) + 0x90) = 1;
    *(undefined1 *)(*(longlong *)(this + 0x830) + 0x90) = 1;
    if ((acStack_5c8[0] != '\0') && (!bVar5)) {
      plVar12 = FUN_1800014c0();
      uStack_e20 = 0;
      uStack_e18 = 0;
      uStack_e10 = 0;
      uStack_e08 = 0;
      FUN_18000c1d0(&uStack_e20,
                    "[Segmentation.Club] Falling back to standard algorithmic detection.",0x43);
      FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&uStack_e20,2,'\x01');
    }
    if (puStack_4d0 != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(puStack_4d0 + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)puStack_4d0[0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*puStack_4d0)(puStack_4d0,1);
        }
        else {
          (**(code **)*puVar16)(puVar16,puStack_4d0);
        }
      }
    }
    if (puStack_4a0 != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(puStack_4a0 + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)puStack_4a0[0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*puStack_4a0)(puStack_4a0,1);
        }
        else {
          (**(code **)*puVar16)(puVar16,puStack_4a0);
        }
      }
    }
  }
  else {
    pbStack_580 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  0x0;
    uStack_578 = 0;
    FUN_1800fa910(&pbStack_580,pbVar13,&pIStack_3b8,aCStack_1a8);
    pbStack_4e0 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  0x0;
    uStack_4d8 = 0;
    FUN_1800fab10(&pbStack_4e0,pbVar13,&pIStack_388,aCStack_2b8);
    lStack_f60 = 800;
    FUN_1800090b0(&lStack_f18);
    pbVar32 = pbStack_580;
    if ((pbStack_580 ==
         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0) ||
       (((char)uStack_578 != '\0' &&
        (pbStack_580[0xb8] !=
         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>)0x0)))) {
                    /* WARNING: Subroutine does not return */
      FUN_180009ac0(4);
    }
    uVar19 = FUN_1800fd9b0((longlong *)pbStack_580,&lStack_f60);
    if ((int)uVar19 == 0) {
      plVar12 = FUN_1800090b0(&lStack_b78);
      lStack_1018 = 800 - (*plVar12 - lStack_f18) / 1000000;
      if (lStack_1018 < 1) {
        plVar12 = FUN_1800014c0();
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_18000c890(auStack_9f0,
                                "[Segmentation.Club] ML Detection timed out (Cam 1 took too long).")
        ;
        goto LAB_1800f42d4;
      }
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &lStack_1018;
      iVar30 = FUN_1800fad10(&pbStack_4e0,(longlong *)pbVar13);
      if (iVar30 != 0) {
        plVar12 = FUN_1800014c0();
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_18000c890(auStack_a10,
                                "[Segmentation.Club] ML Detection timed out on Camera 2.");
        goto LAB_1800f42d4;
      }
      bVar5 = true;
      FUN_180084940((longlong *)&pbStack_580);
      FUN_180084940((longlong *)&pbStack_4e0);
      pbVar32 = pbStack_580;
    }
    else {
      plVar12 = FUN_1800014c0();
      uStack_e00 = 0;
      uStack_df8 = 0;
      uStack_df0 = 0;
      uStack_de8 = 0;
      FUN_18000c1d0(&uStack_e00,"[Segmentation.Club] ML Detection timed out on Camera 1.",0x37);
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &uStack_e00;
LAB_1800f42d4:
      FUN_180084c00(plVar12,pbVar13,2,'\x01');
    }
    if (pbStack_4e0 !=
        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0) {
      LOCK();
      pbVar32 = pbStack_4e0 + 8;
      iVar30 = *(int *)pbVar32;
      *(int *)pbVar32 = *(int *)pbVar32 + -1;
      UNLOCK();
      pbVar32 = pbStack_580;
      if (iVar30 == 1) {
        puVar16 = *(undefined8 **)(pbStack_4e0 + 200);
        if (puVar16 == (undefined8 *)0x0) {
          pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    0x1;
          (*(code *)**(undefined8 **)pbStack_4e0)();
          pbVar32 = pbStack_580;
        }
        else {
          pbVar13 = pbStack_4e0;
          (**(code **)*puVar16)(puVar16);
          pbVar32 = pbStack_580;
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
        puVar16 = *(undefined8 **)(pbStack_580 + 200);
        if (puVar16 == (undefined8 *)0x0) {
          pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    0x1;
          (*(code *)**(undefined8 **)pbStack_580)();
        }
        else {
          pbVar13 = pbStack_580;
          (**(code **)*puVar16)(puVar16);
        }
      }
    }
    plVar12 = plStack_508;
    lVar34 = lStack_510;
    if (((!bVar5) || (lStack_510 == 0)) || (lStack_520 == 0)) goto LAB_1800f4459;
    lStack_510 = 0;
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
    lVar34 = lStack_520;
    lStack_520 = 0;
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
  FUN_1800090b0(&lStack_1010);
  plVar12 = FUN_1800014c0();
  puVar16 = FUN_180084840(alStack_9d0,(lStack_1010 - lStack_1008) / 1000000);
  plVar18 = FUN_180007680(puVar16,0,"[Segmentation.Club] Time to extract club head : ",0x30);
  lStack_e40 = *plVar18;
  lStack_e38 = plVar18[1];
  lStack_e30 = plVar18[2];
  lStack_e28 = plVar18[3];
  plVar18[3] = 0xf;
  plVar18[2] = 0;
  *(undefined1 *)plVar18 = 0;
  plVar18 = FUN_18000a490(&lStack_e40,&DAT_180175e94,3);
  lStack_f10 = *plVar18;
  lStack_f08 = plVar18[1];
  lStack_f00 = plVar18[2];
  lStack_ef8 = plVar18[3];
  plVar18[2] = 0;
  plVar18[3] = 0xf;
  *(undefined1 *)plVar18 = 0;
  bVar3 = false;
  bVar5 = false;
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&lStack_f10,1,'\x01');
  FUN_18000c8d0(&lStack_e40);
  FUN_18000c8d0(alStack_9d0);
  if ((*(ClubDetection **)(this + 0x820) == (ClubDetection *)0x0) ||
     (*(longlong *)(this + 0x830) == 0)) {
    plVar12 = FUN_1800014c0();
    uStack_d80 = 0;
    uStack_d78 = 0;
    uStack_d70 = 0;
    uStack_d68 = 0;
    FUN_18000c1d0(&uStack_d80,
                  "[Segmentation.Club] Unable to get a viable mask for the club. No club detection available."
                  ,0x5a);
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &uStack_d80;
LAB_1800f569a:
    FUN_180084c00(plVar12,pbVar13,3,'\x01');
  }
  else {
    bVar6 = Detection::ClubDetection::isDetectionValid(*(ClubDetection **)(this + 0x820));
    fVar36 = DAT_18017ed08;
    if ((bVar6) &&
       (bVar6 = Detection::ClubDetection::isDetectionValid(*(ClubDetection **)(this + 0x830)),
       fVar36 = DAT_18017ed08, bVar6)) {
      cv::Mat::Mat(aMStack_788,(Mat *)(*(longlong *)(this + 0x830) + 8));
      cv::Mat::Mat(aMStack_7e8,(Mat *)(*(longlong *)(this + 0x820) + 8));
      bVar3 = true;
      bVar5 = true;
      fVar36 = Libraries::Core::compareMaskShape(aMStack_7e8,aMStack_788);
    }
    if (bVar5) {
      cv::Mat::~Mat(aMStack_7e8);
    }
    if (bVar3) {
      cv::Mat::~Mat(aMStack_788);
    }
    plVar12 = FUN_1800014c0();
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(acStack_9b0,"[Segmentation.Club] Mask shape comparison result: %f",
                         SUB84((double)fVar36,0));
    FUN_180084c00(plVar12,pbVar13,1,'\x01');
    if (_DAT_18017ea40 < fVar36) {
      plVar12 = FUN_1800014c0();
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                cv::format(acStack_990,
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
      uStack_9c = 1;
      uStack_1ac = 1;
      puStack_4c0 = (undefined8 *)0x0;
      uStack_4b8 = 0;
      FUN_1800fad50(&puStack_4c0,pbVar13,&pIStack_3f8,aCStack_1a8);
      puStack_4b0 = (undefined8 *)0x0;
      uStack_4a8 = 0;
      FUN_1800faf40(&puStack_4b0,pbVar13,&pIStack_418,aCStack_2b8);
      FUN_180084940((longlong *)&puStack_4c0);
      FUN_180084940((longlong *)&puStack_4b0);
      *(undefined1 *)(*(longlong *)(this + 0x820) + 0x90) = 1;
      *(undefined1 *)(*(longlong *)(this + 0x830) + 0x90) = 1;
      if (puStack_4b0 != (undefined8 *)0x0) {
        LOCK();
        piVar26 = (int *)(puStack_4b0 + 1);
        iVar30 = *piVar26;
        *piVar26 = *piVar26 + -1;
        UNLOCK();
        if (iVar30 == 1) {
          puVar16 = (undefined8 *)puStack_4b0[0x19];
          if (puVar16 == (undefined8 *)0x0) {
            (**(code **)*puStack_4b0)(puStack_4b0,1);
          }
          else {
            (**(code **)*puVar16)(puVar16,puStack_4b0);
          }
        }
      }
      if (puStack_4c0 != (undefined8 *)0x0) {
        LOCK();
        piVar26 = (int *)(puStack_4c0 + 1);
        iVar30 = *piVar26;
        *piVar26 = *piVar26 + -1;
        UNLOCK();
        if (iVar30 == 1) {
          puVar16 = (undefined8 *)puStack_4c0[0x19];
          if (puVar16 == (undefined8 *)0x0) {
            (**(code **)*puStack_4c0)(puStack_4c0,1);
          }
          else {
            (**(code **)*puVar16)(puVar16,puStack_4c0);
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
      uStack_e60 = 0;
      uStack_e58 = 0;
      uStack_e50 = 0;
      uStack_e48 = 0;
      FUN_18000c1d0(&uStack_e60,
                    "[Segmentation.Club] Unable to get a viable mask for the club. No club detection available."
                    ,0x5a);
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &uStack_e60;
      goto LAB_1800f569a;
    }
    pMVar20 = (Mat *)Detection::ClubDetection::getClubMask(*(ClubDetection **)(this + 0x830));
    pMVar21 = (Mat *)Detection::ClubDetection::getClubMask(*(ClubDetection **)(this + 0x820));
    fVar36 = Libraries::Core::compareMaskShape(pMVar21,pMVar20);
    cv::Mat::~Mat(aMStack_728);
    cv::Mat::~Mat(aMStack_6c8);
    if (_DAT_18017eae0 < fVar36) {
      plVar12 = FUN_1800014c0();
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                cv::format(acStack_970,
                           "[Segmentation.Club] Mask shape comparison result with MOG2: %f. Club detection refused."
                           ,(double)fVar36);
      goto LAB_1800f569a;
    }
    FUN_1800dd1e0((longlong)aGStack_358);
    CopyCamShotToGICTShot(this,param_1,aGStack_358);
    puVar22 = FUN_1800a5340(auStack_668,(undefined4 *)aGStack_358);
    bVar5 = OnIsPutter(this,puVar22);
    (**(code **)(**(longlong **)(this + 0x820) + 0x28))
              (*(longlong **)(this + 0x820),*(undefined8 *)(this + 0x830),
               *(undefined4 *)(param_1 + 0x10),bVar5);
    *(undefined4 *)(param_1 + 0x398) = *(undefined4 *)(*(longlong *)(this + 0x820) + 0x84);
    uStack_10c4 = 0;
    uStack_de0 = 0;
    uStack_dd8 = 0;
    uStack_dd0 = 0;
    uStack_dc8 = 0;
    FUN_18000c1d0(&uStack_de0,&DAT_18016a0f8,0);
    loadTracker(this,0,&uStack_de0);
    plStack_548 = (longlong *)0x0;
    lStack_540 = 0;
    lStack_538 = 0;
    lStack_530 = 0;
    uStack_528 = 0;
    plStack_548 = (longlong *)FUN_1801327e0(0x10);
    plStack_548[1] = 0;
    *plStack_548 = (longlong)&plStack_548;
    plStack_570 = (longlong *)0x0;
    lStack_568 = 0;
    lStack_560 = 0;
    lStack_558 = 0;
    uStack_550 = 0;
    plStack_570 = (longlong *)FUN_1801327e0(0x10);
    plStack_570[1] = 0;
    *plStack_570 = (longlong)&plStack_570;
    plVar12 = &lStack_fd8;
    FUN_1800090b0(plVar12);
    puStack_500 = (undefined8 *)0x0;
    uStack_4f8 = 0;
    puStack_490 = (undefined8 *)0x0;
    uStack_488 = 0;
    uStack_480 = 0;
    auStack_c80[0] = 0;
    if (*(longlong *)(this + 0x828) != 0) {
      LOCK();
      piVar26 = (int *)(*(longlong *)(this + 0x828) + 8);
      *piVar26 = *piVar26 + 1;
      UNLOCK();
    }
    uStack_c78 = *(undefined8 *)(this + 0x820);
    uStack_c70 = *(undefined8 *)(this + 0x828);
    pcStack_c68 = "Camera1";
    plStack_c60 = plStack_1078;
    uStack_c58 = CONCAT44(uStack_1098._4_4_,(undefined4)uStack_1098);
    iStack_c50 = iStack_10c0;
    iStack_c48 = iStack_10bc;
    iStack_c40 = iStack_10ac;
    iStack_c38 = aiStack_10a8[0];
    pplStack_c30 = &plStack_548;
    pcStack_c20 = _extractClubTracking;
    puVar22 = auStack_c80;
    pIStack_c28 = this;
    puStack_490 = FUN_1800fdb90(plVar12,puVar22);
    uStack_488 = uStack_488 & 0xffffffffffffff00;
    uStack_480 = uStack_480 & 0xffffffffffffff00;
    FUN_180082f80((longlong)auStack_c80);
    plVar12 = FUN_1800fb950((longlong *)&puStack_490);
    FUN_1800fb9e0((longlong *)&puStack_500,puVar22,plVar12);
    FUN_180008c60((longlong *)&puStack_490);
    FUN_1800706f0(apuStack_4f0);
    plVar12 = plStack_1060;
    plStack_1000 = plStack_1060;
    pplStack_ff8 = &plStack_570;
    pcStack_fe8 = _extractClubTracking;
    pIStack_ff0 = this;
    FUN_1800fb130(apuStack_4f0,puVar22,&pcStack_fe8,&pIStack_ff0,&pplStack_ff8,&iStack_10b0,
                  &iStack_10b4,&iStack_10bc,&iStack_10c0,&uStack_10a0,&plStack_1000,"Camera2",
                  (undefined8 *)(this + 0x830),&uStack_10c4);
    cVar7 = FUN_1800f6540((longlong *)&puStack_500);
    cVar8 = FUN_1800f6540((longlong *)apuStack_4f0);
    FUN_1800090b0(&lStack_fe0);
    lStack_fd0 = lStack_fe0 - lStack_fd8;
    FUN_1800084f0((longlong *)&uStack_1058,&lStack_fd0);
    filterByMatchingID(this,(deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                             *)&plStack_548,
                       (deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                        *)&plStack_570);
    plVar18 = FUN_1800014c0();
    puVar16 = FUN_180084840(alStack_910,uStack_1058);
    plVar15 = FUN_1800066b0(alStack_930,"[Segmentation.Club] Time to track club >>  ",puVar16);
    pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              FUN_18000a510(alStack_950,plVar15,&DAT_180175e94);
    puVar16 = (undefined8 *)0x1;
    FUN_180084c00(plVar18,pbVar13,1,'\x01');
    FUN_18000c8d0(alStack_930);
    FUN_18000c8d0(alStack_910);
    if (((uStack_528 < 3) || (uStack_550 < 3)) || ((cVar7 == '\0' || (cVar8 == '\0')))) {
      FUN_1800f8170((longlong)&plStack_548);
      FUN_1800f8170((longlong)&plStack_570);
      uStack_10c4 = 1;
      puVar16 = FUN_18000c890(auStack_8f0,&DAT_18016a0f8);
      loadTracker(this,1,puVar16);
      plVar18 = FUN_1800014c0();
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                FUN_18000c890(auStack_8d0,
                              "[Segmentation.Club] Fail to extract club with Median Flow tracker. Trying to extract the club with CSRT tracker"
                             );
      FUN_180084c00(plVar18,pbVar13,2,'\x01');
      plVar18 = FUN_1800090b0(&lStack_bf8);
      lVar34 = *plVar18;
      plStack_fc8 = plVar12;
      pplStack_fc0 = &plStack_570;
      pcStack_fb0 = _extractClubTracking;
      pIStack_fb8 = this;
      plVar12 = FUN_1800fb130(alStack_be8,pbVar13,&pcStack_fb0,&pIStack_fb8,&pplStack_fc0,
                              &iStack_10b0,&iStack_10b4,&iStack_10bc,&iStack_10c0,&uStack_10a0,
                              &plStack_fc8,"Camera2",(undefined8 *)(this + 0x830),&uStack_10c4);
      FUN_1800f5eb0((longlong *)apuStack_4f0,plVar12);
      FUN_180008c60(alStack_be8);
      plStack_fa8 = plStack_1078;
      pplStack_fa0 = &plStack_548;
      pcStack_f90 = _extractClubTracking;
      pIStack_f98 = this;
      plVar12 = FUN_1800fb130(alStack_c18,plVar12,&pcStack_f90,&pIStack_f98,&pplStack_fa0,
                              aiStack_10a8,&iStack_10ac,&iStack_10bc,&iStack_10c0,&uStack_1098,
                              &plStack_fa8,"Camera1",(undefined8 *)(this + 0x820),&uStack_10c4);
      FUN_1800f5eb0((longlong *)&puStack_500,plVar12);
      FUN_180008c60(alStack_c18);
      cVar7 = FUN_1800f6540((longlong *)&puStack_500);
      cVar8 = FUN_1800f6540((longlong *)apuStack_4f0);
      plVar12 = FUN_1800090b0(&lStack_bf0);
      lStack_f88 = *plVar12 - lVar34;
      puVar23 = (ulonglong *)FUN_1800084f0(&lStack_c00,&lStack_f88);
      uVar31 = *puVar23;
      uStack_1058 = uVar31;
      filterByMatchingID(this,(deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                               *)&plStack_548,
                         (deque<struct_GolfIn::Interface::ExtractedClubTrackingResults,class_std::allocator<struct_GolfIn::Interface::ExtractedClubTrackingResults>_>
                          *)&plStack_570);
      plVar12 = FUN_1800014c0();
      puVar16 = FUN_180084840(alStack_890,uVar31);
      plVar18 = FUN_1800066b0(alStack_8b0,
                              "[Segmentation.Club] Time to extract club centroid with CSRT >>  ",
                              puVar16);
      pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                FUN_18000a510(alStack_810,plVar18,&DAT_180175e94);
      puVar16 = (undefined8 *)0x1;
      FUN_180084c00(plVar12,pbVar13,1,'\x01');
      FUN_18000c8d0(alStack_8b0);
      FUN_18000c8d0(alStack_890);
      if ((cVar7 == '\0') || (cVar8 == '\0')) {
        plVar12 = FUN_1800014c0();
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_18000c890(auStack_870,
                                "[Segmentation.Club] Fail to extract club with CSRT tracker. Club detection won\'t be accurate."
                               );
        puVar16 = (undefined8 *)0x3;
        FUN_180084c00(plVar12,pbVar13,3,'\x01');
      }
    }
    if ((uStack_528 != 0) && (uStack_550 != 0)) {
      FUN_180006580((longlong *)(param_1 + 0x2e0));
      FUN_180006580((longlong *)(param_1 + 0x2f8));
      FUN_18000c400((longlong *)(param_1 + 0x360),(longlong *)&pppuStack_5a0,puVar16);
      puVar17 = puStack_1070;
      puVar24 = (undefined8 *)
                Libraries::CamerasCore::Frame::getCaptureRect((Frame *)(puStack_1070 + 8));
      uVar19 = puVar24[1];
      *(undefined8 *)(param_1 + 0x388) = *puVar24;
      *(undefined8 *)(param_1 + 0x390) = uVar19;
      dVar39 = (double)puVar17[0x14];
      *(double *)(param_1 + 0x380) = dVar39;
      if (dVar39 == 0.0) {
        FUN_18000c890(alStack_b70,"Camera1");
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_180115ca0(alStack_850,alStack_b70,puVar16);
        pPVar14 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar13);
        dVar39 = Libraries::Core::Parameter::toDouble(pPVar14);
        *(double *)(param_1 + 0x380) = dVar39;
        FUN_18000c8d0(alStack_850);
        FUN_18000c8d0(alStack_b70);
      }
      iVar30 = (int)uStack_528 + -1;
      if (-1 < iVar30) {
        lVar34 = (longlong)iVar30;
        do {
          puVar22 = *(undefined4 **)(lStack_540 + (lStack_538 - 1U & lStack_530 + lVar34) * 8);
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
      puVar17 = puStack_590;
      if (*(longlong *)(param_1 + 0x490) != *(longlong *)(param_1 + 0x498)) {
        *(longlong *)(param_1 + 0x498) = *(longlong *)(param_1 + 0x490);
      }
      if (*(longlong *)(param_1 + 0x4a8) != *(longlong *)(param_1 + 0x4b0)) {
        *(longlong *)(param_1 + 0x4b0) = *(longlong *)(param_1 + 0x4a8);
      }
      _Dst = param_1 + 0x510;
      if (_Dst != (Shot *)&pppuStack_5a0) {
        ppppuVar25 = &pppuStack_5a0;
        if (0xf < uStack_588) {
          ppppuVar25 = (undefined8 ****)pppuStack_5a0;
        }
        if (*(undefined8 **)(param_1 + 0x528) < puStack_590) {
          FUN_18000c490((longlong *)_Dst,(ulonglong)puStack_590,puVar16,ppppuVar25);
        }
        else {
          if ((undefined8 *)0xf < *(undefined8 **)(param_1 + 0x528)) {
            _Dst = *(Shot **)_Dst;
          }
          *(undefined8 **)(param_1 + 0x520) = puStack_590;
          puVar16 = puStack_590;
          memmove(_Dst,ppppuVar25,(size_t)puStack_590);
          _Dst[(longlong)puVar17] = (Shot)0x0;
        }
      }
      puVar17 = puStack_1068;
      puVar24 = (undefined8 *)
                Libraries::CamerasCore::Frame::getCaptureRect((Frame *)(puStack_1068 + 8));
      uVar19 = puVar24[1];
      *(undefined8 *)(param_1 + 0x538) = *puVar24;
      *(undefined8 *)(param_1 + 0x540) = uVar19;
      dVar39 = (double)puVar17[0x14];
      *(double *)(param_1 + 0x530) = dVar39;
      if (dVar39 == 0.0) {
        FUN_18000c890(alStack_b50,"Camera2");
        pbVar13 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_180115ca0(alStack_830,alStack_b50,puVar16);
        pPVar14 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar13);
        dVar39 = Libraries::Core::Parameter::toDouble(pPVar14);
        *(double *)(param_1 + 0x530) = dVar39;
        FUN_18000c8d0(alStack_830);
        FUN_18000c8d0(alStack_b50);
      }
      iVar30 = (int)uStack_550 + -1;
      if (-1 < iVar30) {
        lVar34 = (longlong)iVar30;
        do {
          puVar22 = *(undefined4 **)(lStack_568 + (lStack_560 - 1U & lStack_558 + lVar34) * 8);
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
    if (apuStack_4f0[0] != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(apuStack_4f0[0] + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)apuStack_4f0[0][0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*apuStack_4f0[0])(apuStack_4f0[0],1);
        }
        else {
          (**(code **)*puVar16)(puVar16,apuStack_4f0[0]);
        }
      }
    }
    if (puStack_500 != (undefined8 *)0x0) {
      LOCK();
      piVar26 = (int *)(puStack_500 + 1);
      iVar30 = *piVar26;
      *piVar26 = *piVar26 + -1;
      UNLOCK();
      if (iVar30 == 1) {
        puVar16 = (undefined8 *)puStack_500[0x19];
        if (puVar16 == (undefined8 *)0x0) {
          (**(code **)*puStack_500)(puStack_500,1);
        }
        else {
          (**(code **)*puVar16)(puVar16,puStack_500);
        }
      }
    }
    FUN_1800f8170((longlong)&plStack_570);
    plVar12 = plStack_570;
    plStack_570 = (longlong *)0x0;
    free(plVar12);
    FUN_1800f8170((longlong)&plStack_548);
    plVar12 = plStack_548;
    plStack_548 = (longlong *)0x0;
    free(plVar12);
    FUN_18000c8d0(alStack_2d8);
    FUN_18000c8d0(alStack_2f8);
    FUN_18000c8d0(alStack_338);
  }
  FUN_18000c8d0((longlong *)abStack_3d8);
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
  cv::Mat::~Mat(aMStack_230);
  cv::Mat::~Mat(aMStack_290);
  FUN_18000c8d0((longlong *)aCStack_2b8);
  cv::Mat::~Mat(aMStack_120);
  cv::Mat::~Mat(aMStack_180);
  FUN_18000c8d0((longlong *)aCStack_1a8);
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
  FUN_18000c8d0(&lStack_478);
LAB_1800f57f2:
  FUN_18000c8d0((longlong *)&pppuStack_5a0);
  return;
}

