FUNCTION: GolfIn::Detection::ClubDetection::computeBallImpact
ENTRY: 18008ac20
REASONS: name:club; string:Ball.Impact.On.Club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: virtual float __cdecl GolfIn::Detection::ClubDetection::computeBallImpact(struct
   GolfIn::Detection::ClubDetectionBallImpactParams & __ptr64) __ptr64 */

float __thiscall
GolfIn::Detection::ClubDetection::computeBallImpact
          (ClubDetection *this,ClubDetectionBallImpactParams *param_1)

{
  ClubDetectionBallImpactParams CVar1;
  float fVar2;
  float fVar3;
  float fVar4;
  bool bVar5;
  uint uVar6;
  longlong *plVar7;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar8;
  undefined8 *puVar9;
  undefined8 uVar10;
  int iVar11;
  float *pfVar12;
  Point_<float> *pPVar13;
  void *_Memory;
  uint uVar14;
  float *pfVar15;
  longlong lVar16;
  int iVar17;
  char *pcVar18;
  ClubDetection *pCVar19;
  int iVar20;
  double dVar21;
  double dVar22;
  float fVar23;
  double dVar24;
  float fVar25;
  float fVar26;
  float fVar27;
  float fVar28;
  float fVar29;
  float fVar30;
  float fVar31;
  undefined1 auStack_328 [32];
  double local_308;
  undefined8 *local_300;
  undefined4 local_2f8;
  undefined4 local_2f0;
  undefined1 local_2e8;
  int local_2d8;
  int iStack_2d4;
  undefined8 local_2d0;
  undefined8 uStack_2c8;
  longlong local_2c0;
  undefined8 uStack_2b8;
  float local_2b0 [4];
  longlong local_2a0;
  undefined8 *puStack_298;
  undefined8 local_290;
  undefined8 uStack_288;
  int local_280;
  int iStack_27c;
  float local_278;
  float local_274;
  float local_270;
  float local_26c;
  int iStack_268;
  double local_260;
  longlong local_258 [5];
  undefined8 local_230 [3];
  undefined8 local_218 [4];
  Mat local_1f8 [96];
  int local_198 [2];
  uint local_190;
  int local_18c;
  undefined8 local_188;
  undefined8 uStack_180;
  undefined8 local_178;
  undefined8 uStack_170;
  undefined8 local_168;
  undefined8 uStack_160;
  undefined8 local_158;
  undefined8 uStack_150;
  undefined8 local_148;
  undefined8 uStack_140;
  undefined8 local_138;
  undefined8 uStack_130;
  float local_128;
  float local_124;
  undefined8 local_120;
  ulonglong local_118;
  float local_110;
  float local_10c;
  float local_108;
  float local_104;
  uint local_100;
  Point_<float> local_f8 [4];
  Point_<float> aPStack_f4 [4];
  float local_f0;
  float local_ec;
  float local_e8;
  float local_e4;
  ulonglong local_d8;
  
                    /* 0x8ac20  460
                       ?computeBallImpact@ClubDetection@Detection@GolfIn@@UEAAMAEAUClubDetectionBallImpactParams@23@@Z
                        */
  local_d8 = DAT_1801d1040 ^ (ulonglong)auStack_328;
  if (*(int *)(this + 0x88) == -1) {
    return 0.0;
  }
  local_118 = 0;
  local_128 = 2.3693558e-38;
  local_120 = this + 8;
  cv::boundingRect((_InputArray *)local_198);
  uVar14 = local_190;
  fVar31 = _DAT_18017ec88;
  fVar28 = _DAT_18017ec7c;
  CVar1 = param_1[0x80];
  if (CVar1 == (ClubDetectionBallImpactParams)0x0) {
    fVar27 = *(float *)(this + 0x70);
  }
  else {
    fVar27 = 0.0;
  }
  if (*(int *)param_1 == 2) {
    local_198[0] = local_198[0] + local_190;
  }
  iVar17 = *(int *)(param_1 + 0x78) + local_198[0] + (int)fVar27;
  fVar27 = *(float *)(this + 0x1fc);
  fVar23 = fVar27 * _DAT_18017ec44;
  fVar25 = fVar27 * _DAT_18017ec38;
  fVar29 = DAT_18017ec78;
  fVar30 = _DAT_18017ec90;
  if (this[0x201] != (ClubDetection)0x0) {
    fVar29 = DAT_18017ec80;
    fVar30 = _DAT_18017ec94;
  }
  iVar11 = *(int *)(this + 0x84);
  switch(iVar11) {
  case 0:
  case 1:
    if (iVar11 == 1) {
      fVar29 = DAT_18017ec80;
    }
    fVar27 = fVar27 * fVar29;
    plVar7 = FUN_1800014c0();
    puVar9 = (undefined8 *)ClubTypeToString((ClubType)&local_2a0);
    if (0xf < (ulonglong)puVar9[3]) {
      puVar9 = (undefined8 *)*puVar9;
    }
    local_308 = (double)CONCAT44(local_308._4_4_,local_190);
    pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_f8,
                        "[Ball.Impact] Take the %s club head width for the ball impact, which is in pixels: %f vs mask width %d"
                        ,puVar9,(double)fVar27);
    FUN_180084c00(plVar7,pbVar8,1,'\x01');
    FUN_18000c8d0(&local_2a0);
    break;
  case 2:
  case 3:
  case 4:
  case 5:
    if (iVar11 == 2) {
      iVar11 = (fVar27 * fVar30 <= (float)(int)local_190) + 4;
      *(int *)(this + 0x84) = iVar11;
    }
    if (iVar11 != 5) {
      fVar31 = fVar28;
    }
    fVar27 = fVar27 * fVar31;
    plVar7 = FUN_1800014c0();
    pcVar18 = "FAIRWAY WOOD";
    if (*(int *)(this + 0x84) == 5) {
      pcVar18 = "DRIVER";
    }
    local_308 = (double)CONCAT44(local_308._4_4_,local_190);
    pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_f8,
                        "[Ball.Impact] Take the %s club head width for the ball impact, which is in pixels: %f vs mask width %d"
                        ,pcVar18,(double)fVar27);
    FUN_180084c00(plVar7,pbVar8,1,'\x01');
    break;
  case 6:
    fVar27 = (float)(int)local_190;
    plVar7 = FUN_1800014c0();
    pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_f8,
                        "[Ball.Impact] Take the putter mask width for the ball impact, which is in pixels: %f vs mask width %d"
                        ,(double)(int)uVar14,(ulonglong)local_190);
    FUN_180084c00(plVar7,pbVar8,1,'\x01');
    break;
  default:
    FUN_180009760(local_218,"Invalid club type handedness.");
                    /* WARNING: Subroutine does not return */
    _CxxThrowException(local_218,(ThrowInfo *)&DAT_1801a9018);
  }
  fVar31 = DAT_18017ed38;
  iVar11 = *(int *)param_1;
  if (iVar11 == 1) {
    switch(*(int *)(this + 0x84)) {
    default:
      goto switchD_18008afce_caseD_0;
    case 2:
    case 3:
    case 4:
    case 5:
      if (*(int *)(this + 0x84) != 5) {
        fVar23 = fVar25;
      }
      fVar23 = (float)iVar17 + fVar23;
    }
  }
  else {
    if (iVar11 != 2) {
      FUN_180009760(local_230,"Invalid player handedness.");
                    /* WARNING: Subroutine does not return */
      _CxxThrowException(local_230,(ThrowInfo *)&DAT_1801a9018);
    }
    switch(*(int *)(this + 0x84)) {
    case 2:
    case 3:
    case 4:
    case 5:
      if (*(int *)(this + 0x84) != 5) {
        fVar23 = fVar25;
      }
      iVar17 = (int)((float)iVar17 - fVar23);
    }
    fVar23 = (float)iVar17 - fVar27;
  }
  iVar17 = (int)fVar23;
switchD_18008afce_caseD_0:
  iVar20 = (int)(*(float *)(param_1 + 0x10) - (float)local_18c * DAT_18017e97c);
  local_280 = (int)fVar27;
  fVar30 = (float)local_18c * DAT_18017e97c + (float)iVar20;
  fVar23 = (float)local_280;
  fVar25 = fVar23 * DAT_18017e97c + (float)iVar17;
  fVar29 = *(float *)(param_1 + 0x7c) * DAT_18017ed38;
  local_260 = (double)fVar29;
  dVar24 = (local_260 * DAT_18017eaf0) / DAT_18017ebc0;
  local_274 = fVar25;
  local_26c = fVar30;
  dVar21 = cos(dVar24);
  dVar22 = sin(dVar24);
  fVar28 = *(float *)(param_1 + 4);
  dVar24 = (double)(fVar30 - *(float *)(param_1 + 8));
  fVar30 = (float)((double)*(float *)(param_1 + 8) +
                  (double)(fVar25 - fVar28) * dVar22 + dVar24 * dVar21);
  local_270 = (float)((double)fVar28 + ((double)(fVar25 - fVar28) * dVar21 - dVar24 * dVar22));
  local_2b0[0] = 100.0;
  local_278 = -100.0;
  local_2b0[1] = ((fVar28 - local_270) / fVar27) * DAT_18017ec84;
  local_2b0[1] = local_2b0[1] + local_2b0[1];
  pfVar15 = &local_278;
  if (DAT_18017eda0 <= local_2b0[1]) {
    pfVar15 = local_2b0 + 1;
  }
  pfVar12 = local_2b0;
  if (local_2b0[1] <= DAT_18017ec84) {
    pfVar12 = pfVar15;
  }
  fVar26 = *pfVar12;
  local_278 = fVar26;
  local_2b0[2] = 100.0;
  local_2b0[1] = -100.0;
  local_2b0[0] = ((fVar28 - fVar25) / fVar27) * DAT_18017ec84;
  local_2b0[0] = local_2b0[0] + local_2b0[0];
  pfVar15 = local_2b0 + 1;
  if (DAT_18017eda0 <= local_2b0[0]) {
    pfVar15 = local_2b0;
  }
  pfVar12 = local_2b0 + 2;
  if (local_2b0[0] <= DAT_18017ec84) {
    pfVar12 = pfVar15;
  }
  fVar28 = *pfVar12;
  if (iVar11 == 1) {
    fVar26 = fVar26 * fVar31;
    fVar28 = fVar28 * fVar31;
  }
  *(float *)(this + 0x8c) = fVar26;
  if ((this[0xd0] == (ClubDetection)0x0) ||
     (local_278 = fVar26, bVar5 = cv::Mat::empty((Mat *)(param_1 + 0x18)), bVar5)) {
    fVar26 = *(float *)(this + 0x8c);
  }
  else {
    local_2d8 = *(int *)(this + 0x14);
    local_188 = 0;
    uStack_180 = 0;
    local_178 = 0;
    uStack_170 = 0;
    local_168 = 0;
    uStack_160 = 0;
    local_158 = 0;
    uStack_150 = 0;
    local_148 = 0;
    uStack_140 = 0;
    local_138 = 0;
    uStack_130 = 0;
    cv::Mat::clone((Mat *)(param_1 + 0x18));
    fVar31 = *(float *)(param_1 + 0xc);
    fVar27 = *(float *)(param_1 + 0x10);
    fVar25 = *(float *)(param_1 + 4);
    local_2b0[2] = *(float *)(param_1 + 8);
    fVar2 = local_270;
    fVar3 = local_26c;
    local_2b0[0] = fVar27;
    local_2b0[1] = fVar25;
    if (CVar1 == (ClubDetectionBallImpactParams)0x0) {
      local_2d0 = (void *)CONCAT44((int)ROUND(*(float *)(this + 0x74)),
                                   (int)ROUND(*(float *)(this + 0x70)));
      uStack_2c8 = (undefined8 *)
                   CONCAT44((int)ROUND(*(float *)(this + 0x7c)),(int)ROUND(*(float *)(this + 0x78)))
      ;
      cv::Mat::Mat(local_1f8,(Mat *)&local_188,(Rect_<int> *)&local_2d0);
      cv::Mat::operator=((Mat *)&local_188,local_1f8);
      cv::Mat::~Mat(local_1f8);
      fVar4 = *(float *)(this + 0x70);
      iVar17 = (int)((float)iVar17 - fVar4);
      iVar20 = (int)((float)iVar20 - *(float *)(this + 0x74));
      local_274 = local_274 - fVar4;
      fVar30 = fVar30 - *(float *)(this + 0x74);
      fVar31 = fVar31 - fVar4;
      local_2b0[2] = local_2b0[2] - *(float *)(this + 0x74);
      fVar2 = local_270 - fVar4;
      fVar3 = local_26c - *(float *)(this + 0x74);
      local_2b0[0] = fVar27 - *(float *)(this + 0x74);
      local_2b0[1] = fVar25 - fVar4;
    }
    dVar24 = DAT_18017ea78;
    local_10c = (float)(int)ROUND((double)(local_18c + iVar20 * 2) * DAT_18017ea78);
    local_110 = (float)(int)ROUND((double)(local_280 + iVar17 * 2) * DAT_18017ea78);
    local_100 = (uint)fVar29 ^ DAT_18017f140;
    pPVar13 = local_f8;
    lVar16 = 4;
    while (lVar16 != 0) {
      *(undefined8 *)pPVar13 = 0;
      pPVar13 = pPVar13 + 8;
      lVar16 = lVar16 + -1;
    }
    local_108 = fVar23;
    local_104 = (float)local_18c;
    cv::RotatedRect::points((RotatedRect *)&local_110,local_f8);
    uVar14 = 0;
    while( true ) {
      local_2a0 = _DAT_18017f060;
      puStack_298 = (undefined8 *)_UNK_18017f068;
      local_290 = _DAT_18017eed0;
      uStack_288 = _UNK_18017eed8;
      if (3 < (int)uVar14) break;
      uVar6 = uVar14 + 1 & 0x80000003;
      if ((int)uVar6 < 0) {
        uVar6 = (uVar6 - 1 | 0xfffffffc) + 1;
      }
      local_280 = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar6 * 8));
      iStack_27c = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar6 * 8 + 4));
      iStack_268 = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar14 * 8 + 4));
      local_26c = (float)(int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar14 * 8));
      local_2c0 = 0;
      local_2d0 = (void *)CONCAT44(local_2d0._4_4_,0x3010000);
      uStack_2c8 = &local_188;
      local_2f8 = 0;
      local_300 = (undefined8 *)CONCAT44(local_300._4_4_,8);
      local_308 = (double)CONCAT44(local_308._4_4_,1);
      cv::line(&local_2d0,CONCAT44(iStack_268,local_26c),
               CONCAT44((int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar6 * 8 + 4)),
                        (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar6 * 8))),&local_2a0);
      uVar14 = uVar14 + 1;
    }
    local_2c0 = 0;
    local_2d0 = (void *)CONCAT44(local_2d0._4_4_,0x3010000);
    local_2f8 = 0;
    local_300 = (undefined8 *)CONCAT44(local_300._4_4_,8);
    local_308 = (double)CONCAT44(local_308._4_4_,1);
    if (*(int *)param_1 == 1) {
      iStack_27c = (int)ROUND(local_e4);
      local_280 = (int)ROUND(local_e8);
      uStack_2c8 = &local_188;
      cv::line(&local_2d0,local_2d8,CONCAT44(iStack_27c,local_280),&local_2a0);
    }
    else {
      iStack_2d4 = (int)ROUND(local_ec);
      local_2d8 = (int)ROUND(local_f0);
      uStack_2c8 = &local_188;
      cv::line(&local_2d0,0,CONCAT44(iStack_2d4,local_2d8),&local_2a0);
    }
    local_120 = (ClubDetection *)CONCAT44((float)local_18c,fVar23);
    local_118 = local_118 & 0xffffffff00000000;
    local_128 = fVar2;
    local_124 = fVar30;
    cv::RotatedRect::points((RotatedRect *)&local_128,local_f8);
    uVar14 = 0;
    while( true ) {
      if (3 < (int)uVar14) break;
      local_2a0 = _DAT_18017f0d0;
      puStack_298 = (undefined8 *)_UNK_18017f0d8;
      local_290 = 0;
      uStack_288 = 0;
      uVar6 = uVar14 + 1 & 0x80000003;
      if ((int)uVar6 < 0) {
        uVar6 = (uVar6 - 1 | 0xfffffffc) + 1;
      }
      iStack_2d4 = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar6 * 8 + 4));
      local_2d8 = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar6 * 8));
      iStack_27c = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar14 * 8 + 4));
      local_280 = (int)ROUND(*(float *)(local_f8 + (longlong)(int)uVar14 * 8));
      local_2c0 = 0;
      local_2d0 = (void *)CONCAT44(local_2d0._4_4_,0x3010000);
      uStack_2c8 = &local_188;
      local_2f8 = 0;
      local_300 = (undefined8 *)CONCAT44(local_300._4_4_,8);
      local_308 = (double)CONCAT44(local_308._4_4_,1);
      cv::line(&local_2d0,CONCAT44(iStack_27c,local_280),CONCAT44(iStack_2d4,local_2d8),&local_2a0);
      uVar14 = uVar14 + 1;
    }
    local_2a0 = _DAT_18017f060;
    puStack_298 = (undefined8 *)_UNK_18017f068;
    local_290 = _DAT_18017eed0;
    uStack_288 = _UNK_18017eed8;
    iStack_2d4 = (int)ROUND(fVar3);
    local_2d8 = (int)ROUND(local_274);
    local_2c0 = 0;
    local_2d0._0_4_ = 0x3010000;
    uStack_2c8 = &local_188;
    local_2f8 = 8;
    local_300._0_4_ = 1;
    local_308._0_4_ = 7;
    cv::drawMarker(&local_2d0,CONCAT44(iStack_2d4,local_2d8),&local_2a0,1);
    local_2a0 = _DAT_18017f0c0;
    puStack_298 = (undefined8 *)_UNK_18017f0c8;
    local_290 = 0;
    uStack_288 = 0;
    iStack_2d4 = (int)ROUND(local_2b0[0]);
    local_2d8 = (int)ROUND(fVar31);
    local_2c0 = 0;
    local_2d0._0_4_ = 0x3010000;
    uStack_2c8 = &local_188;
    local_2f8 = 8;
    local_300._0_4_ = 1;
    local_308._0_4_ = 7;
    cv::drawMarker(&local_2d0,CONCAT44(iStack_2d4,local_2d8),&local_2a0,0);
    local_2a0 = 0;
    puStack_298 = (undefined8 *)0x0;
    local_290 = _DAT_18017eed0;
    uStack_288 = _UNK_18017eed8;
    iStack_2d4 = (int)ROUND(local_2b0[2]);
    local_2d8 = (int)ROUND(local_2b0[1]);
    local_2c0 = 0;
    local_2d0._0_4_ = 0x3010000;
    uStack_2c8 = &local_188;
    local_2f8 = 8;
    local_300._0_4_ = 1;
    local_308._0_4_ = 7;
    cv::drawMarker(&local_2d0,CONCAT44(iStack_2d4,local_2d8),&local_2a0,1);
    local_2a0 = _DAT_18017f0d0;
    puStack_298 = (undefined8 *)_UNK_18017f0d8;
    local_290 = 0;
    uStack_288 = 0;
    iStack_2d4 = (int)ROUND(fVar30);
    local_2d8 = (int)ROUND(fVar2);
    local_2c0 = 0;
    local_2d0._0_4_ = 0x3010000;
    uStack_2c8 = &local_188;
    local_2f8 = 8;
    local_300._0_4_ = 1;
    local_308 = (double)CONCAT44(local_308._4_4_,7);
    cv::drawMarker(&local_2d0,CONCAT44(iStack_2d4,local_2d8),&local_2a0,0);
    local_2c0 = 0;
    local_2d0 = (void *)CONCAT44(local_2d0._4_4_,0x2010000);
    uStack_2c8 = &local_188;
    local_290 = 0;
    local_2a0._0_4_ = 0x1010000;
    puStack_298 = &local_188;
    local_300 = (undefined8 *)CONCAT44(local_300._4_4_,1);
    local_308 = 0.0;
    cv::resize(&local_2a0,&local_2d0,CONCAT44((int)uStack_180 * 2,uStack_180._4_4_ * 2));
    local_2d0 = (void *)_DAT_18017f070;
    uStack_2c8 = (undefined8 *)_UNK_18017f078;
    local_2c0 = _DAT_18017ee80;
    uStack_2b8 = _UNK_18017ee88;
    uVar10 = cv::format((char *)local_258,"Impact: %.0f %% vs %.0f %%",(double)fVar26,
                        SUB84((double)fVar28,0));
    local_290 = 0;
    local_2a0._0_4_ = 0x3010000;
    puStack_298 = &local_188;
    local_2e8 = 0;
    local_2f0 = 0x10;
    local_2f8 = 1;
    local_300 = &local_2d0;
    local_308 = dVar24;
    cv::putText(&local_2a0,uVar10,0x1e0000000a,0);
    FUN_18000c8d0(local_258);
    local_2d0 = (void *)0x0;
    uStack_2c8 = (undefined8 *)0x0;
    local_2c0 = 0;
    local_290 = 0;
    local_2a0 = CONCAT44(local_2a0._4_4_,0x1010000);
    puStack_298 = &local_188;
    pCVar19 = this + 0x98;
    if (0xf < *(ulonglong *)(this + 0xb0)) {
      pCVar19 = *(ClubDetection **)pCVar19;
    }
    pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_258,"%s\\%s.png",pCVar19,"9_ball_impact_camera1");
    cv::imwrite(pbVar8,(_InputArray *)&local_2a0,
                (vector<int,class_std::allocator<int>_> *)&local_2d0);
    FUN_18000c8d0(local_258);
    if (local_2d0 != (void *)0x0) {
      _Memory = local_2d0;
      if ((0xfff < (ulonglong)((local_2c0 - (longlong)local_2d0 >> 2) * 4)) &&
         (_Memory = *(void **)((longlong)local_2d0 + -8),
         0x1f < (ulonglong)((longlong)local_2d0 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
        _invalid_parameter_noinfo_noreturn();
      }
      free(_Memory);
    }
    plVar7 = FUN_1800014c0();
    local_308 = local_260;
    pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)local_258,
                        "[Ball.Impact.On.Club] Impact: %.0f %% vs %.0f %%, Club face: %f",
                        (double)fVar26,SUB84((double)fVar28,0));
    FUN_180084c00(plVar7,pbVar8,1,'\x01');
    cv::Mat::~Mat((Mat *)&local_188);
  }
  return fVar26;
}

