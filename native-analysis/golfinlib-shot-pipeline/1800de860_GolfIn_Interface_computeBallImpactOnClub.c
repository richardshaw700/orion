FUNCTION: GolfIn::Interface::computeBallImpactOnClub
ENTRY: 1800de860
REASONS: name:club; string:Ball.Impact.On.Club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: void __cdecl GolfIn::Interface::computeBallImpactOnClub(class GolfIn::Shot &
   __ptr64,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >
   const & __ptr64,class std::map<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> >,class Libraries::CamerasCore::Frame,struct std::less<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class
   std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const ,class Libraries::CamerasCore::Frame> > > const & __ptr64) __ptr64
    */

void __thiscall
GolfIn::Interface::computeBallImpactOnClub
          (Interface *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_3)

{
  vector<float,class_std::allocator<float>_> *pvVar1;
  char cVar2;
  undefined8 *puVar3;
  longlong lVar4;
  undefined1 auVar5 [16];
  uint uVar6;
  Interface *this_00;
  Shot *pSVar7;
  undefined1 auVar8 [15];
  bool bVar9;
  undefined4 uVar10;
  PlayerHandedness PVar11;
  longlong *plVar12;
  Mat *pMVar13;
  float *pfVar14;
  undefined1 (*pauVar15) [32];
  longlong *plVar16;
  float *pfVar17;
  int iVar18;
  undefined8 *puVar19;
  Interface *pIVar20;
  undefined8 *puVar21;
  undefined8 *puVar22;
  vector<float,class_std::allocator<float>_> *pvVar23;
  int iVar24;
  ulonglong uVar25;
  GICTSShotData *pGVar26;
  undefined8 uVar27;
  char *pcVar28;
  undefined8 uVar29;
  float fVar30;
  double dVar31;
  float fVar32;
  float fVar33;
  float fVar34;
  float fVar35;
  float fVar36;
  float fVar37;
  undefined1 auStackY_3c8 [32];
  undefined8 local_380;
  float local_378 [2];
  Shot *local_370;
  longlong local_368;
  longlong lStack_360;
  longlong local_358;
  longlong lStack_350;
  undefined8 local_348;
  longlong local_338;
  longlong lStack_330;
  longlong local_328;
  longlong lStack_320;
  Interface *local_318;
  Shot *local_310;
  Shot *local_308;
  longlong local_2f8 [4];
  undefined8 local_2d8;
  undefined8 uStack_2d0;
  undefined4 local_2c8;
  undefined4 local_2c4;
  undefined4 local_2c0;
  undefined8 local_2b8 [4];
  undefined8 local_298;
  undefined8 uStack_290;
  undefined1 local_288;
  undefined4 local_284;
  undefined4 local_280;
  undefined4 local_27c;
  undefined8 local_278 [4];
  undefined8 local_258 [4];
  float local_238 [4];
  undefined8 local_228;
  undefined8 uStack_220;
  undefined4 local_218;
  undefined4 local_214;
  undefined4 local_210;
  undefined1 local_208 [16];
  undefined8 local_1f8;
  undefined8 uStack_1f0;
  undefined8 local_1e8;
  undefined8 uStack_1e0;
  undefined1 local_1d8;
  undefined4 local_1d4;
  undefined4 local_1d0;
  undefined4 local_1cc;
  undefined1 local_1c8 [16];
  undefined8 local_1b8;
  undefined8 uStack_1b0;
  undefined1 local_1a8 [16];
  undefined8 local_198;
  undefined8 uStack_190;
  PlayerHandedness local_188;
  float local_184;
  float local_180;
  float local_17c;
  float local_178;
  Mat local_170 [96];
  int local_110;
  float local_10c;
  undefined1 local_108;
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
  ulonglong local_98;
  
                    /* 0xde860  462
                       ?computeBallImpactOnClub@Interface@GolfIn@@QEAAXAEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@5@@Z
                        */
  local_98 = DAT_1801d1040 ^ (ulonglong)auStackY_3c8;
  local_318 = this + 0x820;
  if (*(longlong *)local_318 != 0) {
    local_f8 = 0;
    uStack_f0 = 0;
    local_e8 = 0;
    uStack_e0 = 0;
    local_d8 = 0;
    uStack_d0 = 0;
    local_c8 = 0;
    uStack_c0 = 0;
    local_b8 = 0;
    uStack_b0 = 0;
    local_a8 = 0;
    uStack_a0 = 0;
    local_380 = this;
    local_370 = param_1;
    local_348 = this;
    local_310 = param_1;
    local_308 = param_1;
    cv::Mat::Mat((Mat *)&local_f8);
    local_368 = 0;
    lStack_360 = 0;
    local_358 = 0;
    lStack_350 = 0;
    FUN_18000c1d0(&local_368,"Camera1",7);
    plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_368);
    puVar3 = *(undefined8 **)param_3;
    cVar2 = *(char *)((longlong)puVar3[1] + 0x19);
    puVar22 = puVar3;
    puVar21 = (undefined8 *)puVar3[1];
    while (cVar2 == '\0') {
      uVar10 = FUN_180008ca0(puVar21 + 4,plVar12);
      if ((char)uVar10 < '\0') {
        puVar19 = (undefined8 *)puVar21[2];
        puVar21 = puVar22;
      }
      else {
        puVar19 = (undefined8 *)*puVar21;
      }
      puVar22 = puVar21;
      puVar21 = puVar19;
      cVar2 = *(char *)((longlong)puVar19 + 0x19);
    }
    if ((*(char *)((longlong)puVar22 + 0x19) != '\0') ||
       (uVar10 = FUN_180008ca0(plVar12,puVar22 + 4), (char)uVar10 < '\0')) {
      puVar22 = puVar3;
    }
    uVar25 = (ulonglong)(*(int *)(param_1 + 0x24) + 1);
    if ((ulonglong)((longlong)(puVar22[10] - puVar22[9]) / 0x60) <= uVar25) {
                    /* WARNING: Subroutine does not return */
      FUN_180006690();
    }
    pMVar13 = (Mat *)cv::Mat::clone((Mat *)(uVar25 * 0x60 + puVar22[9]));
    cv::Mat::operator=((Mat *)&local_f8,pMVar13);
    cv::Mat::~Mat((Mat *)&local_2d8);
    FUN_18000c8d0(&local_368);
    this_00 = local_380;
    local_238[0] = (float)(*(int *)(param_1 + 0x24) + 1);
    fVar34 = DAT_1801d1204;
    fVar35 = DAT_1801d1200;
    while (((fVar35 == DAT_1801d1200 && (fVar34 == DAT_1801d1204)) && (local_238[0] != 0.0))) {
      BallData::getDetectionPoint((BallData *)(param_1 + 0x28),(int *)&local_348,(bool *)local_238);
      local_378[0] = (float)((*(longlong *)(param_1 + 0x68) - *(longlong *)(param_1 + 0x60)) / 0x18)
      ;
      local_380 = (Interface *)((ulonglong)local_380 & 0xffffffff00000000);
      local_238[0] = (float)((int)local_238[0] + -1);
      pfVar17 = (float *)&local_380;
      if (-1 < (int)local_238[0]) {
        pfVar17 = local_238;
      }
      pfVar14 = local_378;
      if ((int)local_238[0] <= (int)local_378[0]) {
        pfVar14 = pfVar17;
      }
      local_238[0] = *pfVar14;
      fVar34 = local_348._4_4_;
      fVar35 = (float)local_348;
    }
    pauVar15 = FUN_1801324f0(*(undefined1 (**) [32])(param_1 + 0x3c0),
                             *(undefined1 (**) [32])(param_1 + 0x3c8),
                             *(uint *)(*(longlong *)local_318 + 0x80));
    pSVar7 = local_370;
    uVar6 = DAT_18017f140;
    if (pauVar15 == *(undefined1 (**) [32])(param_1 + 0x3c8)) {
      iVar18 = (int)((longlong)*(undefined1 (**) [32])(param_1 + 0x3c8) -
                     *(longlong *)(param_1 + 0x3c0) >> 2) + -2;
    }
    else {
      iVar18 = (int)((longlong)pauVar15 - *(longlong *)(param_1 + 0x3c0) >> 2);
    }
    fVar32 = 0.0;
    iVar24 = 1;
    pfVar17 = *(float **)(param_1 + 0x3a8);
    uVar25 = *(longlong *)(param_1 + 0x3b0) - (longlong)pfVar17 >> 2;
    fVar36 = 0.0;
    if (1 < uVar25) {
      do {
        fVar32 = fVar32 + (*pfVar17 - pfVar17[1]);
        iVar24 = iVar24 + 1;
        pfVar17 = pfVar17 + 1;
        fVar36 = fVar32;
      } while ((ulonglong)(longlong)iVar24 < uVar25);
    }
    local_378[0] = (float)((uint)(fVar36 / (float)uVar25) ^ DAT_18017f140);
    pvVar1 = (vector<float,class_std::allocator<float>_> *)(param_1 + 0x428);
    pvVar23 = (vector<float,class_std::allocator<float>_> *)(local_370 + 0x440);
    fVar36 = DAT_1801d1200;
    fVar32 = DAT_1801d1204;
    if ((*(longlong *)pvVar1 != *(longlong *)(param_1 + 0x430)) &&
       (*(longlong *)pvVar23 != *(longlong *)(local_370 + 0x448))) {
      local_380 = (Interface *)CONCAT44(DAT_1801d1204,DAT_1801d1200);
      bVar9 = Libraries::Core::polyFitFindPoint
                        (pvVar1,pvVar23,local_378,(Point_<float> *)&local_380);
      fVar36 = DAT_1801d1200;
      fVar32 = DAT_1801d1204;
      if (bVar9) {
        fVar36 = (float)local_380 - (float)*(int *)(param_1 + 0x388);
        fVar32 = local_380._4_4_ - (float)*(int *)(param_1 + 0x38c);
      }
    }
    fVar33 = DAT_1801d1200;
    if ((*(longlong *)pvVar1 != *(longlong *)(param_1 + 0x430)) &&
       (*(longlong *)pvVar23 != *(longlong *)(pSVar7 + 0x448))) {
      local_378[0] = DAT_1801d1200;
      bVar9 = Libraries::Core::polyFitFindPoint
                        (pvVar1,pvVar23,
                         (float *)(*(longlong *)(param_1 + 0x3a8) + (longlong)iVar18 * 4),
                         (Point_<float> *)local_378);
      fVar33 = DAT_1801d1200;
      if (bVar9) {
        fVar33 = local_378[0] - (float)*(int *)(param_1 + 0x388);
      }
    }
    local_1f8 = _DAT_18017ef00;
    uStack_1f0 = _UNK_18017ef08;
    local_208._1_15_ = SUB1615(ZEXT416(0),1);
    auVar8 = local_208._1_15_;
    auVar5[0xf] = 0;
    auVar5._0_15_ = local_208._1_15_;
    local_208 = auVar5 << 8;
    local_1b8 = _DAT_18017ef00;
    uStack_1b0 = _UNK_18017ef08;
    local_1c8[0xf] = 0;
    local_1c8._0_15_ = auVar8;
    local_1c8 = local_1c8 << 8;
    local_198 = _DAT_18017ef00;
    uStack_190 = _UNK_18017ef08;
    local_1a8[0xf] = 0;
    local_1a8._0_15_ = auVar8;
    local_1a8 = local_1a8 << 8;
    pGVar26 = (GICTSShotData *)&local_228;
    CopyCamShotToGICTShot(this_00,param_1,pGVar26);
    local_370 = (Shot *)&local_2d8;
    local_2d8 = local_228;
    uStack_2d0 = uStack_220;
    local_2c8 = local_218;
    local_2c4 = local_214;
    local_2c0 = local_210;
    FUN_18000cb00(local_2b8,(undefined8 *)local_208);
    local_298 = local_1e8;
    uStack_290 = uStack_1e0;
    local_288 = local_1d8;
    local_284 = local_1d4;
    local_280 = local_1d0;
    local_27c = local_1cc;
    FUN_18000cb00(local_278,(undefined8 *)local_1c8);
    FUN_18000cb00(local_258,(undefined8 *)local_1a8);
    dVar31 = OnComputeClubFace(this_00,&local_2d8);
    fVar37 = (float)dVar31;
    PVar11 = Shot::getPlayerHanded(param_1);
    fVar30 = fVar37;
    if (PVar11 == 2) {
      fVar30 = (float)((uint)fVar37 ^ uVar6);
    }
    *(float *)(param_1 + 0x2b4) = fVar30;
    PVar11 = Shot::getPlayerHanded(param_1);
    local_188 = 0;
    local_184 = (float)DAT_1801d1160;
    local_180 = (float)DAT_1801d1164;
    local_17c = (float)DAT_1801d1160;
    local_178 = (float)DAT_1801d1164;
    cv::Mat::Mat(local_170);
    local_110 = 0xffffffff;
    local_10c = -1.0;
    local_108 = 0;
    local_188 = PVar11;
    local_184 = fVar35;
    local_180 = fVar34;
    local_17c = fVar36;
    local_178 = fVar32;
    pMVar13 = (Mat *)cv::Mat::clone((Mat *)&local_f8);
    cv::Mat::operator=(local_170,pMVar13);
    cv::Mat::~Mat((Mat *)&local_2d8);
    pIVar20 = local_318;
    local_110 = (int)(fVar36 - fVar33);
    local_10c = fVar37;
    uVar10 = (**(code **)(**(longlong **)local_318 + 0x20))(*(longlong **)local_318,&local_188);
    *(undefined4 *)(param_1 + 0x39c) = uVar10;
    *(undefined4 *)(param_1 + 0x54c) = uVar10;
    *(undefined4 *)(param_1 + 0x398) = *(undefined4 *)(*(longlong *)pIVar20 + 0x84);
    plVar12 = (longlong *)Detection::ClubDetection::ClubTypeToString((ClubType)local_2f8);
    pIVar20 = this_00 + 0x708;
    FUN_180009d70((longlong *)pIVar20,plVar12);
    FUN_18000c8d0(local_2f8);
    plVar12 = FUN_1800014c0();
    lVar4 = *(longlong *)(this_00 + 0x718);
    if (0x7fffffffffffffffU - lVar4 < 0x2a) {
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    if (0xf < *(ulonglong *)(this_00 + 0x720)) {
      pIVar20 = *(Interface **)pIVar20;
    }
    pcVar28 = "[Ball.Impact.On.Club] Club type detected: ";
    FUN_18000bff0(&local_368,lVar4,pGVar26,"[Ball.Impact.On.Club] Club type detected: ",0x2a,pIVar20
                  ,lVar4);
    uVar29 = CONCAT71((int7)((ulonglong)pcVar28 >> 8),1);
    uVar27 = 1;
    FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_368,1,'\x01');
    plVar12 = FUN_1800014c0();
    FUN_18006a0d0(local_2f8,(double)*(float *)(param_1 + 0x39c),uVar27,uVar29);
    plVar16 = FUN_180007680(local_2f8,0,"[Ball.Impact.On.Club] Ball impact on club read: ",0x30);
    local_368 = *plVar16;
    lStack_360 = plVar16[1];
    local_358 = plVar16[2];
    lStack_350 = plVar16[3];
    plVar16[3] = 0xf;
    plVar16[2] = 0;
    *(undefined1 *)plVar16 = 0;
    plVar16 = FUN_18000a490(&local_368,&DAT_180176734,1);
    local_338 = *plVar16;
    lStack_330 = plVar16[1];
    local_328 = plVar16[2];
    lStack_320 = plVar16[3];
    plVar16[2] = 0;
    plVar16[3] = 0xf;
    *(undefined1 *)plVar16 = 0;
    FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_338,1,'\x01');
    FUN_18000c8d0(&local_368);
    FUN_18000c8d0(local_2f8);
    cv::Mat::~Mat(local_170);
    FUN_18000c8d0((longlong *)local_1a8);
    FUN_18000c8d0((longlong *)local_1c8);
    FUN_18000c8d0((longlong *)local_208);
    cv::Mat::~Mat((Mat *)&local_f8);
  }
  return;
}

