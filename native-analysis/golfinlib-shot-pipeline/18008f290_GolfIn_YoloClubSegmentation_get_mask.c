FUNCTION: GolfIn::YoloClubSegmentation::get_mask
ENTRY: 18008f290
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl GolfIn::YoloClubSegmentation::get_mask(class cv::Mat const & __ptr64,class
   cv::Mat const & __ptr64,struct GolfIn::ClubOutputParams & __ptr64,struct GolfIn::ClubMaskParams
   const & __ptr64)const __ptr64 */

void __thiscall
GolfIn::YoloClubSegmentation::get_mask
          (YoloClubSegmentation *this,Mat *param_1,Mat *param_2,ClubOutputParams *param_3,
          ClubMaskParams *param_4)

{
  int iVar1;
  longlong lVar2;
  int iVar3;
  int iVar4;
  int iVar5;
  int iVar6;
  MatExpr *pMVar7;
  undefined8 *puVar8;
  int *piVar9;
  int *piVar10;
  void *_Memory;
  Mat *pMVar11;
  int *piVar12;
  int iVar13;
  int iVar14;
  int iVar15;
  int iVar16;
  int iVar17;
  float fVar18;
  double dVar19;
  double dVar20;
  float fVar21;
  float fVar22;
  float fVar23;
  float fVar24;
  float fVar25;
  float fVar26;
  float fVar27;
  float fVar28;
  undefined1 auStack_788 [32];
  undefined8 local_768;
  undefined4 local_760;
  _InputOutputArray *local_758;
  undefined4 local_750;
  undefined8 local_748;
  int local_738;
  int iStack_734;
  undefined8 *local_730;
  undefined8 *puStack_728;
  longlong local_720;
  int local_718 [2];
  int local_710;
  int iStack_70c;
  double local_708;
  longlong *local_700;
  undefined8 local_6f8;
  undefined8 uStack_6f0;
  int local_6e8;
  int local_6e4;
  int local_6e0 [3];
  int local_6d4;
  Mat *local_6d0;
  Mat *local_6c8;
  int local_6c0;
  int iStack_6bc;
  ClubOutputParams *local_6b8;
  undefined8 local_6b0;
  undefined8 local_6a8;
  undefined8 local_6a0;
  undefined8 uStack_698;
  Mat local_688 [96];
  Mat local_628 [16];
  Mat local_618 [96];
  Mat local_5b8 [96];
  Mat local_558 [144];
  Scalar_<double> local_4c8 [16];
  Mat local_4b8 [96];
  Mat local_458 [96];
  Mat local_3f8 [144];
  void *local_368;
  undefined8 *puStack_360;
  undefined8 *local_358;
  int local_350 [4];
  longlong local_340 [3];
  undefined8 local_328;
  undefined8 uStack_320;
  undefined8 local_318;
  undefined8 uStack_310;
  undefined8 local_308;
  undefined8 uStack_300;
  undefined8 local_2f8;
  undefined8 uStack_2f0;
  undefined8 local_2e8;
  undefined8 uStack_2e0;
  undefined8 local_2d8;
  undefined8 uStack_2d0;
  undefined8 local_2c8;
  undefined8 uStack_2c0;
  undefined8 local_2b8;
  undefined8 uStack_2b0;
  undefined8 local_2a8;
  undefined8 uStack_2a0;
  undefined8 local_298;
  undefined8 uStack_290;
  undefined8 local_288;
  undefined8 uStack_280;
  undefined8 local_278;
  undefined8 uStack_270;
  undefined8 local_268;
  undefined8 uStack_260;
  undefined8 local_258;
  undefined8 uStack_250;
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
  undefined8 local_1e8;
  undefined8 uStack_1e0;
  undefined8 local_1d8;
  undefined8 uStack_1d0;
  undefined8 local_1c8;
  undefined8 uStack_1c0;
  undefined8 local_1b8;
  undefined8 uStack_1b0;
  undefined8 local_1a8;
  undefined8 uStack_1a0;
  undefined8 local_198;
  undefined8 uStack_190;
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
  undefined8 local_128;
  undefined8 uStack_120;
  undefined8 local_118;
  undefined8 uStack_110;
  undefined8 local_108;
  undefined8 uStack_100;
  undefined8 local_f8;
  undefined8 uStack_f0;
  ulonglong local_e8;
  
                    /* 0x8f290  702
                       ?get_mask@YoloClubSegmentation@GolfIn@@QEBAXAEBVMat@cv@@0AEAUClubOutputParams@2@AEBUClubMaskParams@2@@Z
                        */
  local_e8 = DAT_1801d1040 ^ (ulonglong)auStack_788;
  local_6e4 = *(int *)(this + 0xe0);
  iVar6 = *(int *)(this + 0xe4);
  lVar2 = *(longlong *)(param_2 + 0x40);
  local_710 = *(undefined4 *)(lVar2 + 4);
  iVar5 = *(int *)(lVar2 + 8);
  local_6e8 = *(int *)(lVar2 + 0xc);
  fVar25 = (float)*(double *)(param_4 + 0x10);
  fVar26 = (float)*(double *)(param_4 + 0x18);
  fVar27 = (float)*(double *)(param_4 + 0x20);
  fVar28 = (float)*(double *)(param_4 + 0x28);
  iVar1 = *(int *)(param_3 + 8);
  iVar14 = *(int *)(param_3 + 0xc);
  iVar15 = *(int *)(param_3 + 0x10);
  iVar3 = *(int *)(param_3 + 0x14);
  fVar21 = (float)local_6e4;
  fVar23 = (float)local_6e8;
  local_738 = iVar5;
  local_718[0] = iVar6;
  local_6d0 = param_2;
  local_6c8 = param_1;
  local_6b8 = param_3;
  fVar18 = floorf((((float)iVar1 * fVar25 + fVar27) / fVar21) * fVar23);
  iVar16 = (int)fVar18;
  fVar22 = (float)iVar6;
  fVar24 = (float)iVar5;
  fVar18 = floorf((((float)iVar14 * fVar26 + fVar28) / fVar22) * fVar24);
  iVar13 = (int)fVar18;
  local_6c0 = iVar15;
  iStack_6bc = iVar3;
  fVar18 = ceilf((((float)(iVar15 + iVar1) * fVar25 + fVar27) / fVar21) * fVar23);
  iVar15 = (int)(fVar18 - (float)iVar16);
  fVar18 = ceilf((((float)(iVar3 + iVar14) * fVar26 + fVar28) / fVar22) * fVar24);
  iVar5 = local_6e8;
  iVar6 = local_738;
  iVar17 = (int)(fVar18 - (float)iVar13);
  if (iVar15 < 1) {
    iVar15 = 1;
  }
  if (iVar17 < 1) {
    iVar17 = 1;
  }
  iVar4 = iVar15;
  if ((local_6e8 < iVar15 + iVar16) && (iVar4 = local_6e8 - iVar16, iVar4 < 1)) {
    iVar16 = iVar16 + -1;
    iVar4 = iVar15;
  }
  iVar15 = iVar17;
  if ((local_738 < iVar17 + iVar13) && (iVar15 = local_738 - iVar13, iVar15 < 1)) {
    iVar13 = iVar13 + -1;
    iVar15 = iVar17;
  }
  local_368 = (void *)0x0;
  puStack_360 = (undefined8 *)0x0;
  local_358 = (undefined8 *)0x0;
  local_738 = 0;
  iStack_734 = 1;
  FUN_18005fce0((longlong *)&local_368,(void *)0x0,(undefined8 *)&local_738);
  local_738 = -0x80000000;
  iStack_734 = 0x7fffffff;
  if (puStack_360 == local_358) {
    FUN_18005fce0((longlong *)&local_368,puStack_360,(undefined8 *)&local_738);
  }
  else {
    *puStack_360 = 0x7fffffff80000000;
    puStack_360 = puStack_360 + 1;
  }
  iStack_734 = iVar15 + iVar13;
  if (puStack_360 == local_358) {
    local_738 = iVar13;
    FUN_18005fce0((longlong *)&local_368,puStack_360,(undefined8 *)&local_738);
  }
  else {
    *puStack_360 = CONCAT44(iStack_734,iVar13);
    puStack_360 = puStack_360 + 1;
  }
  iStack_734 = iVar4 + iVar16;
  local_738 = iVar16;
  if (puStack_360 == local_358) {
    FUN_18005fce0((longlong *)&local_368,puStack_360,(undefined8 *)&local_738);
  }
  else {
    *puStack_360 = CONCAT44(iStack_734,iVar16);
    puStack_360 = puStack_360 + 1;
  }
  local_148 = 0;
  uStack_140 = 0;
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
  cv::Mat::Mat(local_688,local_6d0,
               (vector<class_cv::Range,class_std::allocator<class_cv::Range>_> *)&local_368);
  cv::Mat::clone(local_688);
  cv::Mat::~Mat(local_688);
  local_1a8 = 0;
  uStack_1a0 = 0;
  local_198 = 0;
  uStack_190 = 0;
  local_188 = 0;
  uStack_180 = 0;
  local_178 = 0;
  uStack_170 = 0;
  local_168 = 0;
  uStack_160 = 0;
  local_158 = 0;
  uStack_150 = 0;
  iStack_70c = iVar15 * iVar4;
  local_730 = (undefined8 *)0x0;
  puStack_728 = (undefined8 *)0x0;
  local_720 = 0;
  FUN_180008f50((ulonglong *)&local_730,2);
  *local_730 = CONCAT44(iStack_70c,local_710);
  puStack_728 = local_730 + 1;
  cv::Mat::reshape((Mat *)&local_148,(int)&local_1a8,(vector<int,class_std::allocator<int>_> *)0x0);
  if (local_730 != (undefined8 *)0x0) {
    puVar8 = local_730;
    if ((0xfff < (ulonglong)((local_720 - (longlong)local_730 >> 2) * 4)) &&
       (puVar8 = (undefined8 *)local_730[-1],
       0x1f < (ulonglong)((longlong)local_730 + (-8 - (longlong)puVar8)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(puVar8);
    local_730 = (undefined8 *)0x0;
    puStack_728 = (undefined8 *)0x0;
    local_720 = 0;
  }
  local_208 = 0;
  uStack_200 = 0;
  local_1f8 = 0;
  uStack_1f0 = 0;
  local_1e8 = 0;
  uStack_1e0 = 0;
  local_1d8 = 0;
  uStack_1d0 = 0;
  local_1c8 = 0;
  uStack_1c0 = 0;
  local_1b8 = 0;
  uStack_1b0 = 0;
  pMVar7 = (MatExpr *)cv::operator*(local_628,local_6c8);
  puVar8 = (undefined8 *)cv::MatExpr::t(pMVar7);
  FUN_18000bf80(puVar8,(Mat *)&local_208);
  cv::Mat::~Mat(local_3f8);
  cv::Mat::~Mat(local_458);
  cv::Mat::~Mat(local_4b8);
  cv::Mat::~Mat(local_558);
  cv::Mat::~Mat(local_5b8);
  cv::Mat::~Mat(local_618);
  local_268 = 0;
  uStack_260 = 0;
  local_258 = 0;
  uStack_250 = 0;
  local_248 = 0;
  uStack_240 = 0;
  local_238 = 0;
  uStack_230 = 0;
  local_228 = 0;
  uStack_220 = 0;
  local_218 = 0;
  uStack_210 = 0;
  local_730 = (undefined8 *)0x0;
  puStack_728 = (undefined8 *)0x0;
  local_720 = 0;
  local_710 = iVar15;
  iStack_70c = iVar4;
  FUN_180008f50((ulonglong *)&local_730,2);
  *local_730 = CONCAT44(iStack_70c,local_710);
  puStack_728 = local_730 + 1;
  cv::Mat::reshape((Mat *)&local_208,(int)&local_268,(vector<int,class_std::allocator<int>_> *)0x1);
  if (local_730 != (undefined8 *)0x0) {
    puVar8 = local_730;
    if ((0xfff < (ulonglong)((local_720 - (longlong)local_730 >> 2) * 4)) &&
       (puVar8 = (undefined8 *)local_730[-1],
       0x1f < (ulonglong)((longlong)local_730 + (-8 - (longlong)puVar8)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(puVar8);
  }
  local_2c8 = 0;
  uStack_2c0 = 0;
  local_2b8 = 0;
  uStack_2b0 = 0;
  local_2a8 = 0;
  uStack_2a0 = 0;
  local_298 = 0;
  uStack_290 = 0;
  local_288 = 0;
  uStack_280 = 0;
  local_278 = 0;
  uStack_270 = 0;
  cv::Mat::Mat((Mat *)&local_2c8);
  local_328 = 0;
  uStack_320 = 0;
  local_318 = 0;
  uStack_310 = 0;
  local_308 = 0;
  uStack_300 = 0;
  local_2f8 = 0;
  uStack_2f0 = 0;
  local_2e8 = 0;
  uStack_2e0 = 0;
  local_2d8 = 0;
  uStack_2d0 = 0;
  cv::Mat::Mat((Mat *)&local_328);
  local_720 = 0;
  local_730._0_4_ = 0x2010000;
  puStack_728 = &local_2c8;
  pMVar7 = (MatExpr *)cv::operator-(local_628);
  cv::_InputArray::_InputArray((_InputArray *)&local_708,pMVar7);
  cv::exp((_InputArray *)&local_708,(_OutputArray *)&local_730);
  cv::Mat::~Mat(local_558);
  cv::Mat::~Mat(local_5b8);
  cv::Mat::~Mat(local_618);
  dVar20 = DAT_18017eaa0;
  local_708 = DAT_18017eaa0;
  local_6f8 = 0;
  uStack_6f0 = 0;
  local_700 = (longlong *)0x0;
  pMVar11 = (Mat *)&local_708;
  dVar19 = (double)cv::operator+(local_4c8,pMVar11);
  puVar8 = (undefined8 *)cv::operator/(dVar19,(MatExpr *)pMVar11);
  (**(code **)(*(longlong *)*puVar8 + 0x10))((longlong *)*puVar8,puVar8,&local_2c8,0xffffffff);
  cv::Mat::~Mat(local_558);
  cv::Mat::~Mat(local_5b8);
  cv::Mat::~Mat(local_618);
  cv::Mat::~Mat(local_3f8);
  cv::Mat::~Mat(local_458);
  cv::Mat::~Mat(local_4b8);
  iVar5 = local_6e4 / iVar5;
  fVar18 = floorf(((float)(iVar5 * iVar16) - fVar27) / fVar25);
  iVar6 = local_718[0] / iVar6;
  fVar21 = floorf(((float)(iVar6 * iVar13) - fVar28) / fVar26);
  fVar22 = ceilf((float)(iVar5 * iVar4) / fVar25);
  iVar13 = (int)fVar22;
  fVar22 = ceilf((float)(iVar6 * iVar15) / fVar26);
  iVar5 = (int)fVar22;
  local_720 = 0;
  local_730._0_4_ = 0x2010000;
  puStack_728 = &local_328;
  local_6f8 = 0;
  local_708._0_4_ = 0x1010000;
  local_700 = &local_2c8;
  local_760 = 1;
  local_768 = 0;
  cv::resize(&local_708,&local_730,CONCAT44(iVar5,iVar13),0);
  iVar6 = local_6c0;
  local_350[1] = iVar14 - (int)fVar21;
  local_350[0] = iVar1 - (int)fVar18;
  local_350[3] = iVar3;
  local_350[2] = local_6c0;
  local_6e0[0] = 0;
  local_6e0[1] = 0;
  local_6e0[2] = iVar13;
  local_6d4 = iVar5;
  if ((((0 < local_6c0) && (0 < iVar3)) && (0 < iVar13)) && (0 < iVar5)) {
    piVar12 = local_6e0;
    piVar10 = local_350;
    if (-1 < iVar1 - (int)fVar18) {
      piVar12 = local_350;
      piVar10 = local_6e0;
    }
    iVar1 = *piVar10;
    if ((-1 < iVar1) || (*piVar12 <= piVar10[2] + iVar1)) {
      iVar14 = 0;
      if (local_350[1] < 0) {
        iVar14 = local_350[1];
      }
      if (iVar14 < 0) {
        iVar15 = iVar5;
        if (local_350[1] < 0) {
          iVar15 = iVar3;
        }
        iVar13 = local_350[1];
        if (local_350[1] < 0) {
          iVar13 = 0;
        }
        if (iVar15 + iVar14 < iVar13) goto LAB_18008fc46;
      }
      local_718[0] = piVar10[2] + (iVar1 - *piVar12);
      piVar10 = local_718;
      if (piVar12[2] < local_718[0]) {
        piVar10 = piVar12 + 2;
      }
      local_350[2] = *piVar10;
      iVar1 = local_350[1];
      if (local_350[1] < 0) {
        iVar5 = iVar3;
        iVar1 = 0;
      }
      local_718[0] = (iVar5 - iVar1) + iVar14;
      piVar10 = &local_6d4;
      if (-1 < local_350[1]) {
        piVar10 = local_350 + 3;
      }
      piVar9 = local_718;
      if (*piVar10 < local_718[0]) {
        piVar9 = piVar10;
      }
      local_350[3] = *piVar9;
      local_350[1] = iVar1;
      local_350[0] = *piVar12;
      if ((0 < local_350[2]) && (0 < *piVar9)) goto LAB_18008fc51;
    }
  }
LAB_18008fc46:
  local_350[0] = 0;
  local_350[1] = 0;
  local_350[2] = 0;
  local_350[3] = 0;
LAB_18008fc51:
  cv::Mat::Mat(local_688,(Mat *)&local_328,(Rect_<int> *)local_350);
  puVar8 = (undefined8 *)cv::operator>(local_628,dVar20);
  (**(code **)(*(longlong *)*puVar8 + 0x10))((longlong *)*puVar8,puVar8,&local_328,0xffffffff);
  cv::Mat::~Mat(local_558);
  cv::Mat::~Mat(local_5b8);
  cv::Mat::~Mat(local_618);
  cv::Mat::~Mat(local_688);
  if (((int)uStack_320 != iVar3) || (uStack_320._4_4_ != iVar6)) {
    local_6f8 = 0;
    local_708._0_4_ = 0x2010000;
    local_700 = &local_328;
    local_720 = 0;
    local_730._0_4_ = 0x1010000;
    puStack_728 = &local_328;
    local_760 = 1;
    local_768 = 0;
    cv::resize(&local_730,&local_708,CONCAT44(iVar3,iVar6),0);
  }
  local_340[0] = 0;
  local_340[1] = 0;
  local_340[2] = 0;
  local_6f8 = 0;
  local_708._0_4_ = 0x8204000c;
  local_700 = local_340;
  local_720 = 0;
  local_730._0_4_ = 0x1010000;
  puStack_728 = &local_328;
  local_768 = 0;
  cv::findContours(&local_730,&local_708,0,2);
  local_758 = cv::noArray();
  local_6b0 = DAT_18017ebd0;
  local_6a0 = 0;
  uStack_698 = 0;
  local_6a8 = 0;
  local_6f8 = 0;
  local_708 = (double)CONCAT44(local_708._4_4_,0x8104000c);
  local_700 = local_340;
  local_720 = 0;
  local_730 = (undefined8 *)CONCAT44(local_730._4_4_,0x3010000);
  puStack_728 = &local_328;
  local_748 = 0;
  local_750 = 0x7fffffff;
  local_760 = 8;
  local_768 = CONCAT44(local_768._4_4_,0xffffffff);
  cv::drawContours(&local_730,&local_708,0xffffffff,&local_6b0);
  cv::Mat::operator=((Mat *)(local_6b8 + 0x18),(Mat *)&local_328);
  FUN_180043110(local_340);
  cv::Mat::~Mat((Mat *)&local_328);
  cv::Mat::~Mat((Mat *)&local_2c8);
  cv::Mat::~Mat((Mat *)&local_268);
  cv::Mat::~Mat((Mat *)&local_208);
  cv::Mat::~Mat((Mat *)&local_1a8);
  cv::Mat::~Mat((Mat *)&local_148);
  if (local_368 != (void *)0x0) {
    _Memory = local_368;
    if ((0xfff < ((longlong)local_358 - (longlong)local_368 & 0xfffffffffffffff8U)) &&
       (_Memory = *(void **)((longlong)local_368 + -8),
       0x1f < (ulonglong)((longlong)local_368 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(_Memory);
  }
  return;
}

