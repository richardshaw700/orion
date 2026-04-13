FUNCTION: GolfIn::Detection::MLClubDetection::computeBallImpact
ENTRY: 18008bc70
REASONS: name:club; string:Ball.Impact.On.Club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: virtual float __cdecl GolfIn::Detection::MLClubDetection::computeBallImpact(struct
   GolfIn::Detection::ClubDetectionBallImpactParams & __ptr64) __ptr64 */

float __thiscall
GolfIn::Detection::MLClubDetection::computeBallImpact
          (MLClubDetection *this,ClubDetectionBallImpactParams *param_1)

{
  float fVar1;
  char cVar2;
  char cVar3;
  int *piVar4;
  code *pcVar5;
  longlong *plVar6;
  int iVar7;
  longlong *plVar8;
  undefined4 *puVar9;
  longlong *plVar10;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar11;
  int *piVar12;
  undefined8 uVar13;
  int iVar14;
  int iVar15;
  undefined8 *puVar16;
  float *pfVar17;
  int *piVar18;
  void *_Memory;
  longlong lVar19;
  undefined8 *puVar20;
  float *pfVar21;
  int iVar22;
  undefined8 *puVar23;
  MLClubDetection *pMVar24;
  undefined8 *puVar25;
  int iVar26;
  bool bVar27;
  bool bVar28;
  float fVar29;
  float fVar30;
  float fVar31;
  float fVar32;
  float fVar33;
  undefined1 auStack_328 [32];
  undefined8 local_308;
  longlong *local_300;
  undefined4 local_2f8;
  undefined4 local_2f0;
  undefined1 local_2e8;
  undefined4 local_2d8 [2];
  undefined8 *local_2d0;
  undefined8 local_2c8;
  undefined8 local_2b8;
  undefined8 *puStack_2b0;
  longlong local_2a8;
  longlong local_298;
  undefined8 uStack_290;
  undefined8 local_288;
  undefined8 uStack_280;
  float local_278;
  float local_274;
  MLClubDetection *local_270;
  undefined8 local_260 [3];
  undefined8 local_248;
  undefined8 uStack_240;
  undefined8 local_238;
  undefined8 uStack_230;
  undefined8 local_228;
  undefined8 uStack_220;
  undefined8 local_218;
  undefined8 uStack_210;
  undefined8 local_208;
  undefined8 uStack_200;
  undefined8 local_1f8;
  undefined8 uStack_1f0;
  int local_1e8;
  int iStack_1e4;
  int iStack_1e0;
  int iStack_1dc;
  undefined8 *local_1d8;
  longlong lStack_1d0;
  int *local_1c8;
  int *piStack_1c0;
  longlong local_1b8;
  longlong *local_1b0;
  undefined8 uStack_1a8;
  undefined8 local_1a0;
  int local_198;
  int local_194 [3];
  undefined8 local_188;
  undefined8 uStack_180;
  undefined4 local_168;
  undefined4 local_164;
  undefined8 local_160;
  undefined8 uStack_158;
  Mat local_150 [8];
  int local_148;
  int local_144;
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
  ulonglong local_68;
  
                    /* 0x8bc70  461
                       ?computeBallImpact@MLClubDetection@Detection@GolfIn@@UEAAMAEAUClubDetectionBallImpactParams@23@@Z
                        */
  local_68 = DAT_1801d1040 ^ (ulonglong)auStack_328;
  local_270 = this;
  if (*(YoloClubSegmentation **)(this + 0x220) == (YoloClubSegmentation *)0x0) {
    param_1[0x80] = (ClubDetectionBallImpactParams)0x1;
    fVar29 = ClubDetection::computeBallImpact((ClubDetection *)this,param_1);
    return fVar29;
  }
  local_1c8 = (int *)0x0;
  piStack_1c0 = (int *)0x0;
  local_1b8 = 0;
  YoloClubSegmentation::predict
            (*(YoloClubSegmentation **)(this + 0x220),(Mat *)(param_1 + 0x18),
             (vector<struct_GolfIn::ClubOutputParams,class_std::allocator<struct_GolfIn::ClubOutputParams>_>
              *)&local_1c8);
  local_1b0 = (longlong *)0x0;
  uStack_1a8 = 0;
  local_1b0 = (longlong *)FUN_1801327e0(0x40);
  piVar12 = piStack_1c0;
  *local_1b0 = (longlong)local_1b0;
  local_1b0[1] = (longlong)local_1b0;
  local_1b0[2] = (longlong)local_1b0;
  *(undefined2 *)(local_1b0 + 3) = 0x101;
  for (piVar18 = local_1c8; piVar18 != piVar12; piVar18 = piVar18 + 0x1e) {
    plVar8 = FUN_18008d4c0((longlong *)&local_1b0,piVar18);
    piVar4 = (int *)plVar8[1];
    if (piVar4 == (int *)plVar8[2]) {
      FUN_18008dc50(plVar8,(undefined8 *)piVar4,piVar18);
    }
    else {
      *piVar4 = *piVar18;
      piVar4[1] = piVar18[1];
      uVar13 = *(undefined8 *)(piVar18 + 4);
      *(undefined8 *)(piVar4 + 2) = *(undefined8 *)(piVar18 + 2);
      *(undefined8 *)(piVar4 + 4) = uVar13;
      cv::Mat::Mat((Mat *)(piVar4 + 6),(Mat *)(piVar18 + 6));
      plVar8[1] = plVar8[1] + 0x78;
    }
  }
  local_1d8 = (undefined8 *)0x0;
  lStack_1d0 = 0;
  local_1d8 = (undefined8 *)FUN_1801327e0(0xa0);
  *local_1d8 = local_1d8;
  local_1d8[1] = local_1d8;
  local_1d8[2] = local_1d8;
  *(undefined2 *)(local_1d8 + 3) = 0x101;
  plVar8 = (longlong *)*local_1b0;
  cVar2 = *(char *)((longlong)plVar8 + 0x19);
  while (cVar2 == '\0') {
    puVar9 = (undefined4 *)
             club_best_candidate_near_ball
                       (this,(Point_<float> *)&local_e8,
                        (vector<struct_GolfIn::ClubOutputParams,class_std::allocator<struct_GolfIn::ClubOutputParams>_>
                         *)(param_1 + 4));
    plVar10 = FUN_18008d310((longlong *)&local_1d8,(int *)(plVar8 + 4));
    *(undefined4 *)plVar10 = *puVar9;
    *(undefined4 *)((longlong)plVar10 + 4) = puVar9[1];
    lVar19 = *(longlong *)(puVar9 + 4);
    plVar10[1] = *(longlong *)(puVar9 + 2);
    plVar10[2] = lVar19;
    cv::Mat::operator=((Mat *)(plVar10 + 3),(Mat *)(puVar9 + 6));
    cv::Mat::~Mat((Mat *)&uStack_d0);
    plVar10 = (longlong *)plVar8[2];
    if (*(char *)((longlong)plVar10 + 0x19) == '\0') {
      cVar2 = *(char *)(*plVar10 + 0x19);
      plVar8 = plVar10;
      plVar10 = (longlong *)*plVar10;
      while (cVar2 == '\0') {
        cVar2 = *(char *)(*plVar10 + 0x19);
        plVar8 = plVar10;
        plVar10 = (longlong *)*plVar10;
      }
    }
    else {
      cVar2 = *(char *)(plVar8[1] + 0x19);
      plVar6 = (longlong *)plVar8[1];
      plVar10 = plVar8;
      while ((plVar8 = plVar6, cVar2 == '\0' && (plVar10 == (longlong *)plVar8[2]))) {
        cVar2 = *(char *)(plVar8[1] + 0x19);
        plVar6 = (longlong *)plVar8[1];
        plVar10 = plVar8;
      }
    }
    cVar2 = *(char *)((longlong)plVar8 + 0x19);
  }
  if (lStack_1d0 == 0) {
    plVar8 = FUN_1800014c0();
    pbVar11 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format((char *)&local_298,
                         "[ML.Club.Ball.Impact] No CLUB_HEAD or CLUB_FACE detected in frame.");
    FUN_180084c00(plVar8,pbVar11,2,'\x01');
    param_1[0x80] = (ClubDetectionBallImpactParams)0x1;
    fVar29 = ClubDetection::computeBallImpact((ClubDetection *)this,param_1);
    FUN_18008d450((longlong *)&local_1d8);
    FUN_18008d5c0((longlong *)&local_1b0);
    piVar12 = piStack_1c0;
    piVar18 = local_1c8;
    if (local_1c8 == (int *)0x0) {
      return fVar29;
    }
    for (; piVar18 != piVar12; piVar18 = piVar18 + 0x1e) {
      cv::Mat::~Mat((Mat *)(piVar18 + 6));
    }
    lVar19 = SUB168(SEXT816(-0x7777777777777777) * SEXT816(local_1b8 - (longlong)local_1c8),8) +
             (local_1b8 - (longlong)local_1c8);
    piVar18 = local_1c8;
    if ((0xfff < (ulonglong)(((lVar19 >> 6) - (lVar19 >> 0x3f)) * 0x78)) &&
       (piVar18 = *(int **)(local_1c8 + -2),
       0x1f < (ulonglong)((longlong)local_1c8 + (-8 - (longlong)piVar18)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(piVar18);
    return fVar29;
  }
  local_160 = 0;
  uStack_158 = 0;
  cv::Mat::Mat(local_150);
  puVar16 = (undefined8 *)local_1d8[1];
  cVar3 = *(char *)((longlong)puVar16 + 0x19);
  puVar20 = puVar16;
  puVar23 = local_1d8;
  cVar2 = cVar3;
  while (puVar25 = puVar20, cVar2 == '\0') {
    if (*(int *)(puVar25 + 4) < 0) {
      puVar20 = (undefined8 *)puVar25[2];
      puVar25 = puVar23;
    }
    else {
      puVar20 = (undefined8 *)*puVar25;
    }
    cVar2 = *(char *)((longlong)puVar20 + 0x19);
    puVar23 = puVar25;
  }
  puVar20 = local_1d8;
  if ((*(char *)((longlong)puVar23 + 0x19) == '\0') && (*(int *)(puVar23 + 4) < 1)) {
    while (puVar23 = puVar16, cVar3 == '\0') {
      if (*(int *)(puVar23 + 4) < 0) {
        puVar16 = (undefined8 *)puVar23[2];
        puVar23 = puVar20;
      }
      else {
        puVar16 = (undefined8 *)*puVar23;
      }
      cVar3 = *(char *)((longlong)puVar16 + 0x19);
      puVar20 = puVar23;
    }
    if (*(char *)((longlong)puVar20 + 0x19) != '\0') goto LAB_18008c8d1;
    iVar26 = *(int *)(puVar20 + 4);
    bVar28 = false;
    bVar27 = iVar26 == 0;
  }
  else {
    while (puVar23 = puVar16, cVar3 == '\0') {
      if (*(int *)(puVar23 + 4) < 1) {
        puVar16 = (undefined8 *)puVar23[2];
        puVar23 = puVar20;
      }
      else {
        puVar16 = (undefined8 *)*puVar23;
      }
      cVar3 = *(char *)((longlong)puVar16 + 0x19);
      puVar20 = puVar23;
    }
    if (*(char *)((longlong)puVar20 + 0x19) != '\0') goto LAB_18008c8d1;
    iVar15 = *(int *)(puVar20 + 4);
    bVar28 = SBORROW4(iVar15,1);
    iVar26 = iVar15 + -1;
    bVar27 = iVar15 == 1;
  }
  if (!bVar27 && bVar28 == iVar26 < 0) {
LAB_18008c8d1:
    std::_Xout_of_range("invalid map<K, T> key");
    pcVar5 = (code *)swi(3);
    fVar29 = (float)(*pcVar5)();
    return fVar29;
  }
  local_168 = *(undefined4 *)(puVar20 + 5);
  local_164 = *(undefined4 *)((longlong)puVar20 + 0x2c);
  local_160 = puVar20[6];
  uStack_158 = puVar20[7];
  cv::Mat::operator=(local_150,(Mat *)(puVar20 + 8));
  uVar13 = uStack_158;
  fVar29 = (float)local_160;
  iVar26 = local_160._4_4_;
  iVar15 = (int)uStack_158;
  iVar22 = uStack_158._4_4_;
  if ((local_148 < 0) || (local_144 < 0)) {
    FUN_180009760(local_260,"Result candidate found, but no mask has been extract.");
                    /* WARNING: Subroutine does not return */
    _CxxThrowException(local_260,(ThrowInfo *)&DAT_1801a9018);
  }
  fVar33 = (float)uStack_158._4_4_ * DAT_18017e97c;
  fVar30 = (float)local_160._4_4_;
  fVar32 = (float)(int)uStack_158 * DAT_18017e97c + (float)(int)(float)local_160;
  local_2b8 = (void *)CONCAT44(local_2b8._4_4_,0x42c80000);
  local_278 = -100.0;
  local_274 = ((*(float *)(param_1 + 4) - fVar32) / (float)(int)uStack_158) * DAT_18017ec84;
  local_274 = local_274 + local_274;
  pfVar21 = &local_278;
  if (DAT_18017eda0 <= local_274) {
    pfVar21 = &local_274;
  }
  pfVar17 = (float *)&local_2b8;
  if (local_274 <= DAT_18017ec84) {
    pfVar17 = pfVar21;
  }
  fVar1 = *pfVar17;
  *(float *)(this + 0x8c) = fVar1;
  fVar31 = DAT_18017e9d8;
  if (*(int *)param_1 == 1) {
    fVar31 = DAT_18017ed38;
  }
  *(float *)(this + 0x8c) = fVar1 * fVar31;
  if ((this[0xd0] == (MLClubDetection)0x0) ||
     (bVar27 = cv::Mat::empty((Mat *)(param_1 + 0x18)), bVar27)) goto LAB_18008c88b;
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
  local_98 = 0;
  uStack_90 = 0;
  cv::Mat::clone((Mat *)(param_1 + 0x18));
  local_298 = _DAT_18017f0c0;
  uStack_290 = _UNK_18017f0c8;
  local_288 = 0;
  uStack_280 = 0;
  local_2b8 = (void *)CONCAT44((int)ROUND(fVar33 + fVar30),(int)ROUND(fVar32));
  local_2c8 = 0;
  local_2d8[0] = 0x3010000;
  local_2d0 = &local_e8;
  local_2f8 = 8;
  local_300._0_4_ = 1;
  local_308._0_4_ = 7;
  cv::drawMarker(local_2d8,local_2b8,&local_298,0);
  local_298 = 0;
  uStack_290 = 0;
  local_288 = _DAT_18017eed0;
  uStack_280 = _UNK_18017eed8;
  local_2b8 = (void *)CONCAT44((int)ROUND(*(float *)(param_1 + 8)),
                               (int)ROUND(*(float *)(param_1 + 4)));
  local_2c8 = 0;
  local_2d8[0] = 0x3010000;
  local_2d0 = &local_e8;
  local_2f8 = 8;
  local_300._0_4_ = 1;
  local_308._0_4_ = 7;
  cv::drawMarker(local_2d8,local_2b8,&local_298,1);
  local_298 = _DAT_18017f060;
  uStack_290 = _UNK_18017f068;
  local_288 = _DAT_18017eed0;
  uStack_280 = _UNK_18017eed8;
  local_2c8 = 0;
  local_2d8[0] = 0x3010000;
  local_2d0 = &local_e8;
  local_2b8._0_4_ = fVar29;
  local_2b8._4_4_ = iVar26;
  puStack_2b0 = (undefined8 *)uVar13;
  local_300._0_4_ = 0;
  local_308 = CONCAT44(local_308._4_4_,8);
  cv::rectangle(local_2d8,&local_2b8,&local_298,1);
  iStack_1dc = iVar22 + 0x28;
  local_1a0 = 0;
  local_198 = uStack_e0._4_4_;
  local_194[0] = (int)uStack_e0;
  local_1e8 = (int)fVar29 + -0x14;
  iVar26 = iVar26 + -0x14;
  iStack_1e4 = iVar26;
  iStack_1e0 = iVar15 + 0x28;
  if ((iVar15 + 0x28 < 1) || (((iStack_1dc < 1 || (uStack_e0._4_4_ < 1)) || ((int)uStack_e0 < 1))))
  {
LAB_18008c5ba:
    local_188 = 0;
    uStack_180 = 0;
  }
  else {
    piVar12 = (int *)&local_1a0;
    piVar18 = &local_1e8;
    if (-1 < local_1e8) {
      piVar12 = &local_1e8;
      piVar18 = (int *)&local_1a0;
    }
    iVar15 = *piVar18;
    if ((iVar15 < 0) && (piVar18[2] + iVar15 < *piVar12)) goto LAB_18008c5ba;
    iVar22 = 0;
    if (iVar26 < 0) {
      iVar22 = iVar26;
    }
    if (iVar22 < 0) {
      iVar14 = (int)uStack_e0;
      if (iVar26 < 0) {
        iVar14 = iStack_1dc;
      }
      iVar7 = iVar26;
      if (iVar26 < 0) {
        iVar7 = 0;
      }
      if (iVar14 + iVar22 < iVar7) goto LAB_18008c5ba;
    }
    local_1e8 = *piVar12;
    iVar15 = piVar18[2] + (iVar15 - local_1e8);
    local_2b8 = (void *)CONCAT44(local_2b8._4_4_,iVar15);
    piVar18 = (int *)&local_2b8;
    if (piVar12[2] < iVar15) {
      piVar18 = piVar12 + 2;
    }
    iStack_1e0 = *piVar18;
    iVar15 = (int)uStack_e0;
    if (iVar26 < 0) {
      iVar15 = iStack_1dc;
      iStack_1e4 = 0;
    }
    local_2b8._0_4_ = (float)((iVar15 - iStack_1e4) + iVar22);
    piVar18 = local_194;
    if (-1 < iVar26) {
      piVar18 = &iStack_1dc;
    }
    piVar12 = (int *)&local_2b8;
    if (*piVar18 < (int)(float)local_2b8) {
      piVar12 = piVar18;
    }
    iStack_1dc = *piVar12;
    if ((iStack_1e0 < 1) || (iStack_1dc < 1)) goto LAB_18008c5ba;
    local_188 = CONCAT44(iStack_1e4,local_1e8);
    uStack_180 = CONCAT44(iStack_1dc,iStack_1e0);
  }
  local_248 = 0;
  uStack_240 = 0;
  local_238 = 0;
  uStack_230 = 0;
  local_228 = 0;
  uStack_220 = 0;
  local_218 = 0;
  uStack_210 = 0;
  local_208 = 0;
  uStack_200 = 0;
  local_1f8 = 0;
  uStack_1f0 = 0;
  cv::Mat::Mat((Mat *)&local_248,(Mat *)&local_e8,(Rect_<int> *)&local_188);
  local_2c8 = 0;
  local_2d8[0] = 0x2010000;
  local_2d0 = &local_248;
  local_2a8 = 0;
  local_2b8 = (void *)CONCAT44(local_2b8._4_4_,0x1010000);
  puStack_2b0 = &local_248;
  local_300 = (longlong *)CONCAT44(local_300._4_4_,1);
  local_308 = 0;
  cv::resize(&local_2b8,local_2d8,CONCAT44((int)uStack_240 * 6,uStack_240._4_4_ * 6));
  local_298 = _DAT_18017f070;
  uStack_290 = _UNK_18017f078;
  local_288 = _DAT_18017ee80;
  uStack_280 = _UNK_18017ee88;
  uVar13 = cv::format((char *)&local_2b8,"Impact: %.0f %%",(double)*(float *)(this + 0x8c));
  local_2c8 = 0;
  local_2d8[0] = 0x3010000;
  local_2d0 = &local_248;
  local_2e8 = 0;
  local_2f0 = 0x10;
  local_2f8 = 1;
  local_300 = &local_298;
  local_308 = DAT_18017eaa0;
  cv::putText(local_2d8,uVar13,0x1e0000000a,0);
  FUN_18000c8d0(&local_2b8);
  local_2b8 = (void *)0x0;
  puStack_2b0 = (undefined8 *)0x0;
  local_2a8 = 0;
  local_2c8 = 0;
  local_2d8[0] = 0x1010000;
  local_2d0 = &local_248;
  pMVar24 = this + 0x98;
  if (0xf < *(ulonglong *)(this + 0xb0)) {
    pMVar24 = *(MLClubDetection **)pMVar24;
  }
  pbVar11 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format((char *)&local_298,"%s\\%s.png",pMVar24,"ball_impact_camera1");
  cv::imwrite(pbVar11,(_InputArray *)local_2d8,(vector<int,class_std::allocator<int>_> *)&local_2b8)
  ;
  FUN_18000c8d0(&local_298);
  if (local_2b8 != (void *)0x0) {
    _Memory = local_2b8;
    if ((0xfff < (ulonglong)((local_2a8 - (longlong)local_2b8 >> 2) * 4)) &&
       (_Memory = *(void **)((longlong)local_2b8 + -8),
       0x1f < (ulonglong)((longlong)local_2b8 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(_Memory);
  }
  plVar8 = FUN_1800014c0();
  pbVar11 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format((char *)&local_298,"[Ball.Impact.On.Club] Impact: %.0f %%",
                       (double)*(float *)(this + 0x8c));
  FUN_180084c00(plVar8,pbVar11,1,'\x01');
  cv::Mat::~Mat((Mat *)&local_248);
  cv::Mat::~Mat((Mat *)&local_e8);
LAB_18008c88b:
  fVar29 = *(float *)(this + 0x8c);
  cv::Mat::~Mat(local_150);
  FUN_18008d450((longlong *)&local_1d8);
  FUN_18008d5c0((longlong *)&local_1b0);
  FUN_18008d630((longlong *)&local_1c8);
  return fVar29;
}

