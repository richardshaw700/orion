FUNCTION: GolfIn::Interface::extractBallClub
ENTRY: 1800e97c0
REASONS: name:club; name:extractBallClub; string:Extract.BallClub; string:ExtractBallClub


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: bool __cdecl GolfIn::Interface::extractBallClub(class GolfIn::Shot & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::map<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> >,class Libraries::CamerasCore::Frame,struct std::less<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class
   std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const ,class Libraries::CamerasCore::Frame> > > const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64) __ptr64 */

bool __thiscall
GolfIn::Interface::extractBallClub
          (Interface *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_3,basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                   *param_4)

{
  char cVar1;
  longlong lVar2;
  Interface *pIVar3;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *pmVar4;
  bool bVar5;
  undefined4 uVar6;
  longlong *plVar7;
  undefined8 *puVar8;
  longlong *plVar9;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar10;
  longlong lVar11;
  void *pvVar12;
  ulonglong uVar13;
  undefined8 *puVar14;
  size_t sVar15;
  longlong lVar16;
  longlong lVar17;
  undefined8 *puVar18;
  undefined8 *puVar19;
  undefined1 auStackY_298 [32];
  bool local_268 [8];
  Interface *local_260;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_258;
  Frame *local_250;
  void *local_248;
  undefined8 *puStack_240;
  undefined8 *local_238;
  longlong lStack_230;
  longlong local_228;
  longlong lStack_220;
  longlong local_218;
  longlong lStack_210;
  longlong local_208;
  longlong lStack_200;
  longlong local_1f8;
  longlong lStack_1f0;
  longlong local_1e8;
  longlong lStack_1e0;
  longlong local_1d8;
  longlong lStack_1d0;
  longlong local_1c8;
  longlong lStack_1c0;
  longlong local_1b8;
  longlong lStack_1b0;
  Interface *local_1a8;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_1a0;
  longlong local_198;
  longlong lStack_190;
  longlong local_188;
  longlong lStack_180;
  longlong local_178;
  longlong lStack_170;
  longlong local_168;
  longlong lStack_160;
  longlong local_158;
  longlong lStack_150;
  longlong local_148;
  longlong lStack_140;
  longlong local_138;
  longlong lStack_130;
  longlong local_128;
  longlong lStack_120;
  longlong local_118 [5];
  longlong local_f0 [4];
  longlong local_d0 [4];
  longlong local_b0 [4];
  longlong local_90 [4];
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *local_70;
  void *local_68;
  undefined8 *puStack_60;
  undefined8 *local_58;
  longlong lStack_50;
  ulonglong local_48;
  
                    /* 0xe97c0  562
                       ?extractBallClub@Interface@GolfIn@@QEAA_NAEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@5@1@Z
                        */
  local_48 = DAT_1801d1040 ^ (ulonglong)auStackY_298;
  local_258 = param_4;
  local_1a8 = this;
  local_1a0 = param_2;
  local_70 = param_3;
  Shot::clear(param_1);
  plVar7 = FUN_1800014c0();
  local_1c8 = 0;
  lStack_1c0 = 0;
  local_1b8 = 0;
  lStack_1b0 = 0;
  FUN_18000c1d0(&local_1c8,"[ExtractBallClub] Start analysing the shot",0x2a);
  FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_1c8,0,'\x01');
  local_198 = 0;
  lStack_190 = 0;
  local_188 = 0;
  lStack_180 = 0;
  local_260 = this + 0x2c8;
  FUN_18000c1d0(&local_198,"Camera1",7);
  plVar7 = FUN_1800f7eb0((longlong *)(this + 0x2c8),&local_198);
  puVar8 = *(undefined8 **)param_3;
  cVar1 = *(char *)((longlong)puVar8[1] + 0x19);
  puVar19 = puVar8;
  puVar18 = (undefined8 *)puVar8[1];
  while (cVar1 == '\0') {
    uVar6 = FUN_180008ca0(puVar18 + 4,plVar7);
    if ((char)uVar6 < '\0') {
      puVar14 = (undefined8 *)puVar18[2];
      puVar18 = puVar19;
    }
    else {
      puVar14 = (undefined8 *)*puVar18;
    }
    puVar19 = puVar18;
    puVar18 = puVar14;
    cVar1 = *(char *)((longlong)puVar14 + 0x19);
  }
  if ((*(char *)((longlong)puVar19 + 0x19) != '\0') ||
     (uVar6 = FUN_180008ca0(plVar7,puVar19 + 4), (char)uVar6 < '\0')) {
    puVar19 = puVar8;
  }
  FUN_18000c8d0(&local_198);
  local_250 = (Frame *)(puVar19 + 8);
  getDeltaTimeArray(this,local_250,(vector<float,class_std::allocator<float>_> *)(param_1 + 0x90),
                    (vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *)
                    (param_1 + 0xa8));
  local_68 = (void *)0x0;
  puStack_60 = (void *)0x0;
  local_58 = (undefined8 *)0x0;
  uVar13 = *(longlong *)(param_1 + 0x98) - *(longlong *)(param_1 + 0x90) >> 2;
  if (uVar13 != 0) {
    if (0x3fffffffffffffff < uVar13) {
                    /* WARNING: Subroutine does not return */
      FUN_1800075d0();
    }
    FUN_180008f50((ulonglong *)&local_68,uVar13);
    pvVar12 = local_68;
    sVar15 = *(longlong *)(param_1 + 0x98) - (longlong)*(void **)(param_1 + 0x90);
    memmove(local_68,*(void **)(param_1 + 0x90),sVar15);
    puStack_60 = (undefined8 *)((longlong)pvVar12 + ((longlong)sVar15 >> 2) * 4);
  }
  FUN_18007ca70((longlong *)(param_1 + 0x330),(longlong *)&local_68);
  if (local_68 != (void *)0x0) {
    pvVar12 = local_68;
    if ((0xfff < (ulonglong)(((longlong)local_58 - (longlong)local_68 >> 2) * 4)) &&
       (pvVar12 = *(void **)((longlong)local_68 + -8),
       0x1f < (ulonglong)((longlong)local_68 + (-8 - (longlong)pvVar12)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar12);
  }
  local_68 = (void *)0x0;
  puStack_60 = (void *)0x0;
  local_58 = (undefined8 *)0x0;
  uVar13 = *(longlong *)(param_1 + 0xb0) - *(longlong *)(param_1 + 0xa8) >> 3;
  if (uVar13 != 0) {
    if (0x1fffffffffffffff < uVar13) {
                    /* WARNING: Subroutine does not return */
      FUN_1800075d0();
    }
    FUN_180008fe0((ulonglong *)&local_68,uVar13);
    pvVar12 = local_68;
    sVar15 = *(longlong *)(param_1 + 0xb0) - (longlong)*(void **)(param_1 + 0xa8);
    memmove(local_68,*(void **)(param_1 + 0xa8),sVar15);
    puStack_60 = (undefined8 *)((longlong)pvVar12 + ((longlong)sVar15 >> 3) * 8);
  }
  FUN_1800f7cd0((longlong *)(param_1 + 0x348),(longlong *)&local_68);
  if (local_68 != (void *)0x0) {
    pvVar12 = local_68;
    if ((0xfff < (ulonglong)(((longlong)local_58 - (longlong)local_68 >> 3) * 8)) &&
       (pvVar12 = *(void **)((longlong)local_68 + -8),
       0x1f < (ulonglong)((longlong)local_68 + (-8 - (longlong)pvVar12)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar12);
  }
  local_208 = 0;
  lStack_200 = 0;
  local_1f8 = 0;
  lStack_1f0 = 0;
  FUN_18000c1d0(&local_208,"Camera2",7);
  FUN_1800f7eb0((longlong *)local_260,&local_208);
  FUN_18000c8d0(&local_208);
  getDeltaTimeArray(local_1a8,local_250,
                    (vector<float,class_std::allocator<float>_> *)(param_1 + 0x1b0),
                    (vector<unsigned___int64,class_std::allocator<unsigned___int64>_> *)
                    (param_1 + 0x1c8));
  local_68 = (void *)0x0;
  puStack_60 = (void *)0x0;
  local_58 = (undefined8 *)0x0;
  uVar13 = *(longlong *)(param_1 + 0x1b8) - *(longlong *)(param_1 + 0x1b0) >> 2;
  if (uVar13 != 0) {
    if (0x3fffffffffffffff < uVar13) {
                    /* WARNING: Subroutine does not return */
      FUN_1800075d0();
    }
    FUN_180008f50((ulonglong *)&local_68,uVar13);
    pvVar12 = local_68;
    sVar15 = *(longlong *)(param_1 + 0x1b8) - (longlong)*(void **)(param_1 + 0x1b0);
    memmove(local_68,*(void **)(param_1 + 0x1b0),sVar15);
    puStack_60 = (undefined8 *)((longlong)pvVar12 + ((longlong)sVar15 >> 2) * 4);
  }
  FUN_18007ca70((longlong *)(param_1 + 0x4e0),(longlong *)&local_68);
  if (local_68 != (void *)0x0) {
    pvVar12 = local_68;
    if ((0xfff < (ulonglong)(((longlong)local_58 - (longlong)local_68 >> 2) * 4)) &&
       (pvVar12 = *(void **)((longlong)local_68 + -8),
       0x1f < (ulonglong)((longlong)local_68 + (-8 - (longlong)pvVar12)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar12);
  }
  local_68 = (void *)0x0;
  puStack_60 = (void *)0x0;
  local_58 = (undefined8 *)0x0;
  uVar13 = *(longlong *)(param_1 + 0x1d0) - *(longlong *)(param_1 + 0x1c8) >> 3;
  if (uVar13 != 0) {
    if (0x1fffffffffffffff < uVar13) {
                    /* WARNING: Subroutine does not return */
      FUN_1800075d0();
    }
    FUN_180008fe0((ulonglong *)&local_68,uVar13);
    pvVar12 = local_68;
    sVar15 = *(longlong *)(param_1 + 0x1d0) - (longlong)*(void **)(param_1 + 0x1c8);
    memmove(local_68,*(void **)(param_1 + 0x1c8),sVar15);
    puStack_60 = (undefined8 *)((longlong)pvVar12 + ((longlong)sVar15 >> 3) * 8);
  }
  FUN_1800f7cd0((longlong *)(param_1 + 0x4f8),(longlong *)&local_68);
  if (local_68 != (void *)0x0) {
    pvVar12 = local_68;
    if ((0xfff < (ulonglong)(((longlong)local_58 - (longlong)local_68 >> 3) * 8)) &&
       (pvVar12 = *(void **)((longlong)local_68 + -8),
       0x1f < (ulonglong)((longlong)local_68 + (-8 - (longlong)pvVar12)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar12);
  }
  FUN_1800090b0((longlong *)&local_250);
  pmVar4 = local_70;
  pIVar3 = local_1a8;
  bVar5 = ballHasMoveEnough(local_1a8,local_70);
  FUN_1800090b0((longlong *)&local_70);
  lVar11 = (longlong)local_70 - (longlong)local_250;
  plVar7 = FUN_1800014c0();
  puVar8 = FUN_180084840(local_f0,lVar11 / 1000000);
  plVar9 = FUN_180007680(puVar8,0,"[Extract.BallClub] Time to compute ball has moved enough: ",0x3a)
  ;
  local_158 = *plVar9;
  lStack_150 = plVar9[1];
  local_148 = plVar9[2];
  lStack_140 = plVar9[3];
  plVar9[3] = 0xf;
  plVar9[2] = 0;
  *(undefined1 *)plVar9 = 0;
  plVar9 = FUN_18000a490(&local_158,&DAT_180175efc,4);
  local_248 = (void *)*plVar9;
  puStack_240 = (undefined8 *)plVar9[1];
  local_238 = (undefined8 *)plVar9[2];
  lStack_230 = plVar9[3];
  plVar9[2] = 0;
  plVar9[3] = 0xf;
  *(undefined1 *)plVar9 = 0;
  FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_248,1,'\x01');
  FUN_18000c8d0(&local_158);
  FUN_18000c8d0(local_f0);
  if (bVar5) {
    plVar7 = FUN_1800014c0();
    local_68 = (void *)0x0;
    puStack_60 = (undefined8 *)0x0;
    local_58 = (undefined8 *)0x0;
    lStack_50 = 0;
    FUN_18000c1d0(&local_68,"[Extract.BallClub] Extracting Ball...",0x25);
    FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_68,1,'\x01');
    plVar7 = FUN_1800090b0((longlong *)&local_70);
    lVar11 = *plVar7;
    *(undefined4 *)(pIVar3 + 0x5c0) = 0xffffffff;
    local_268[0] = false;
    extractBall(pIVar3,param_1,local_1a0,pmVar4,local_268);
    plVar7 = FUN_1800090b0((longlong *)&local_70);
    lVar2 = *plVar7;
    plVar7 = FUN_1800014c0();
    puVar8 = FUN_180084840(local_d0,(lVar2 - lVar11) / 1000000);
    plVar9 = FUN_180007680(puVar8,0,"[Extract.BallClub] Time to extract BALL: ",0x29);
    local_228 = *plVar9;
    lStack_220 = plVar9[1];
    local_218 = plVar9[2];
    lStack_210 = plVar9[3];
    plVar9[3] = 0xf;
    plVar9[2] = 0;
    *(undefined1 *)plVar9 = 0;
    plVar9 = FUN_18000a490(&local_228,&DAT_180175efc,4);
    local_68 = (void *)*plVar9;
    puStack_60 = (undefined8 *)plVar9[1];
    local_58 = (undefined8 *)plVar9[2];
    lStack_50 = plVar9[3];
    plVar9[2] = 0;
    plVar9[3] = 0xf;
    *(undefined1 *)plVar9 = 0;
    FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_68,1,'\x01');
    FUN_18000c8d0(&local_228);
    FUN_18000c8d0(local_d0);
    plVar7 = FUN_1800014c0();
    local_228 = 0;
    lStack_220 = 0;
    local_218 = 0;
    lStack_210 = 0;
    FUN_18000c1d0(&local_228,"[Extract.BallClub] Building Ball...",0x23);
    FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_228,1,'\x01');
    plVar7 = FUN_1800090b0((longlong *)&local_70);
    lVar11 = *plVar7;
    *(undefined4 *)(param_1 + 0x398) = 0;
    bVar5 = Ball::built((Ball *)(param_1 + 8));
    if (!bVar5) {
      lVar11 = *(longlong *)(param_1 + 0x68);
      lVar2 = *(longlong *)(param_1 + 0x60);
      bVar5 = true;
      local_68 = (void *)0x0;
      puStack_60 = (undefined8 *)0x0;
      lVar17 = 0;
      local_58 = (undefined8 *)0x0;
      local_70 = (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
                  *)0x10;
      FUN_180044d40((longlong *)&local_68,(ulonglong *)&local_70);
      lVar16 = lVar17;
LAB_1800ea100:
      if (bVar5) {
        bVar5 = false;
        lVar16 = lVar2;
      }
      else {
        if (lVar16 == lVar11) goto LAB_1800ea178;
        lVar16 = lVar16 + 0x18;
      }
      if (lVar16 == lVar11) goto LAB_1800ea178;
      puVar8 = (undefined8 *)(lVar16 + 8);
      local_260 = (Interface *)*puVar8;
      pIVar3 = (Interface *)*puVar8;
      if (puStack_60 == local_58) {
        FUN_1800468a0((longlong *)&local_68,puStack_60,&local_260);
      }
      else {
        *puStack_60 = *puVar8;
        puStack_60 = puStack_60 + 1;
        local_260 = pIVar3;
      }
      goto LAB_1800ea100;
    }
    plVar7 = FUN_1800090b0((longlong *)&local_70);
    lVar2 = *plVar7;
    plVar7 = FUN_1800014c0();
    puVar8 = FUN_180084840(local_b0,(lVar2 - lVar11) / 1000000);
    plVar9 = FUN_180007680(puVar8,0,"[Extract.BallClub] Time to built BALL: ",0x27);
    local_138 = *plVar9;
    lStack_130 = plVar9[1];
    local_128 = plVar9[2];
    lStack_120 = plVar9[3];
    plVar9[3] = 0xf;
    plVar9[2] = 0;
    *(undefined1 *)plVar9 = 0;
    plVar9 = FUN_18000a490(&local_138,&DAT_180175efc,4);
    local_178 = *plVar9;
    lStack_170 = plVar9[1];
    local_168 = plVar9[2];
    lStack_160 = plVar9[3];
    plVar9[2] = 0;
    plVar9[3] = 0xf;
    *(undefined1 *)plVar9 = 0;
    FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_178,1,'\x01');
    FUN_18000c8d0(&local_138);
    FUN_18000c8d0(local_b0);
    if (((DAT_18017eac8 <= *(float *)(param_1 + 0x18) * DAT_18017eaf8) &&
        (*(float *)(param_1 + 0x10) <= _DAT_18017ec70)) &&
       ((*(float *)(param_1 + 0x18) * DAT_18017eaf8 <= _DAT_18017eca8 ||
        (*(float *)(param_1 + 0x10) <= _DAT_18017ec54)))) {
      plVar7 = FUN_1800014c0();
      local_1e8 = 0;
      lStack_1e0 = 0;
      local_1d8 = 0;
      lStack_1d0 = 0;
      FUN_18000c1d0(&local_1e8,"[Extract.BallClub] Extracting Club...",0x25);
      FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_1e8,1,'\x01');
      plVar7 = FUN_1800090b0((longlong *)&local_70);
      lVar11 = *plVar7;
      extractClubByCamera_SegmentationClubTemplateContinue
                (pIVar3,param_1,local_1a0,pmVar4,local_258);
      plVar7 = FUN_1800090b0((longlong *)&local_258);
      lVar2 = *plVar7;
      plVar7 = FUN_1800014c0();
      puVar8 = FUN_180084840(local_90,(lVar2 - lVar11) / 1000000);
      plVar9 = FUN_180007680(puVar8,0,"[Extract.BallClub] Times to extract CLUB >>  ",0x2d);
      local_208 = *plVar9;
      lStack_200 = plVar9[1];
      local_1f8 = plVar9[2];
      lStack_1f0 = plVar9[3];
      plVar9[3] = 0xf;
      plVar9[2] = 0;
      *(undefined1 *)plVar9 = 0;
      plVar9 = FUN_18000a490(&local_208,&DAT_180175e94,3);
      local_1e8 = *plVar9;
      lStack_1e0 = plVar9[1];
      local_1d8 = plVar9[2];
      lStack_1d0 = plVar9[3];
      plVar9[2] = 0;
      plVar9[3] = 0xf;
      *(undefined1 *)plVar9 = 0;
      FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_1e8,1,'\x01');
      FUN_18000c8d0(&local_208);
      FUN_18000c8d0(local_90);
      plVar7 = FUN_1800014c0();
      local_208 = 0;
      lStack_200 = 0;
      local_1f8 = 0;
      lStack_1f0 = 0;
      FUN_18000c1d0(&local_208,"[Extract.BallClub] Building shot...",0x23);
      FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_208,1,'\x01');
      plVar7 = FUN_1800090b0((longlong *)&local_258);
      lVar11 = *plVar7;
      Shot::clear_built(param_1);
      bVar5 = Ball::built((Ball *)(param_1 + 8));
      if (bVar5) {
        Club::built((Club *)(param_1 + 0x2a0));
      }
      plVar7 = FUN_1800090b0((longlong *)&local_258);
      lVar2 = *plVar7;
      plVar7 = FUN_1800014c0();
      puVar8 = FUN_180084840(local_118,(lVar2 - lVar11) / 1000000);
      plVar9 = FUN_180007680(puVar8,0,"[Extract.BallClub] Times to build shot >>  ",0x2b);
      local_198 = *plVar9;
      lStack_190 = plVar9[1];
      local_188 = plVar9[2];
      lStack_180 = plVar9[3];
      plVar9[3] = 0xf;
      plVar9[2] = 0;
      *(undefined1 *)plVar9 = 0;
      plVar9 = FUN_18000a490(&local_198,&DAT_180175e94,3);
      local_1c8 = *plVar9;
      lStack_1c0 = plVar9[1];
      local_1b8 = plVar9[2];
      lStack_1b0 = plVar9[3];
      plVar9[2] = 0;
      plVar9[3] = 0xf;
      *(undefined1 *)plVar9 = 0;
      FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_1c8,1,'\x01');
      FUN_18000c8d0(&local_198);
      FUN_18000c8d0(local_118);
      return bVar5;
    }
    plVar7 = FUN_1800014c0();
    pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format((char *)local_118,
                         "[Extract.BallClub] Stop analysing the shot. Ball speed or the launch angle are not acceptable. Ball speed: %f mph, Launch angle: %f"
                         ,(double)(*(float *)(param_1 + 0x18) * DAT_18017eaf8),
                         (double)*(float *)(param_1 + 0x10));
    FUN_180084c00(plVar7,pbVar10,3,'\x01');
  }
  return false;
LAB_1800ea178:
  local_248 = local_68;
  local_238 = local_58;
  puStack_240 = puStack_60;
  FUN_1800f7cd0((longlong *)(param_1 + 0x108),(longlong *)&local_248);
  if (local_248 != (void *)0x0) {
    pvVar12 = local_248;
    if ((0xfff < (ulonglong)(((longlong)local_238 - (longlong)local_248 >> 3) * 8)) &&
       (pvVar12 = *(void **)((longlong)local_248 + -8),
       0x1f < (ulonglong)((longlong)local_248 + (-8 - (longlong)pvVar12)))) goto LAB_1800ea31d;
    free(pvVar12);
  }
  lVar11 = *(longlong *)(param_1 + 0x188);
  lVar2 = *(longlong *)(param_1 + 0x180);
  bVar5 = true;
  local_68 = (void *)0x0;
  puStack_60 = (undefined8 *)0x0;
  local_58 = (undefined8 *)0x0;
  local_70 = (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
              *)0x10;
  FUN_180044d40((longlong *)&local_68,(ulonglong *)&local_70);
LAB_1800ea241:
  if (bVar5) {
    bVar5 = false;
    lVar17 = lVar2;
  }
  else {
    if (lVar17 == lVar11) goto LAB_1800ea2b6;
    lVar17 = lVar17 + 0x18;
  }
  if (lVar17 == lVar11) goto LAB_1800ea2b6;
  puVar8 = (undefined8 *)(lVar17 + 8);
  local_260 = (Interface *)*puVar8;
  pIVar3 = (Interface *)*puVar8;
  if (puStack_60 == local_58) {
    FUN_1800468a0((longlong *)&local_68,puStack_60,&local_260);
  }
  else {
    *puStack_60 = *puVar8;
    puStack_60 = puStack_60 + 1;
    local_260 = pIVar3;
  }
  goto LAB_1800ea241;
LAB_1800ea2b6:
  local_248 = local_68;
  local_238 = local_58;
  puStack_240 = puStack_60;
  FUN_1800f7cd0((longlong *)(param_1 + 0x228),(longlong *)&local_248);
  if (local_248 != (void *)0x0) {
    pvVar12 = local_248;
    if ((0xfff < ((longlong)local_238 - (longlong)local_248 & 0xfffffffffffffff8U)) &&
       (pvVar12 = *(void **)((longlong)local_248 + -8),
       0x1f < (ulonglong)((longlong)local_248 + (-8 - (longlong)pvVar12)))) {
LAB_1800ea31d:
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar12);
  }
  plVar7 = FUN_1800014c0();
  local_228 = 0;
  lStack_220 = 0;
  local_218 = 0;
  lStack_210 = 0;
  FUN_18000c1d0(&local_228,"[Extract.BallClub] Fail on ball build!",0x26);
  FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_228,3,'\x01');
  return false;
}

