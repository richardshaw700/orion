FUNCTION: GolfIn::Detection::ClubDetection::removeClubShaft
ENTRY: 180089070
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: void __cdecl GolfIn::Detection::ClubDetection::removeClubShaft(class cv::Mat const &
   __ptr64,class cv::Mat & __ptr64,float)const __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::removeClubShaft
          (ClubDetection *this,Mat *param_1,Mat *param_2,float param_3)

{
  int iVar1;
  int *piVar2;
  double dVar3;
  double _Y;
  undefined8 uVar4;
  void *pvVar5;
  bool bVar6;
  int iVar7;
  int iVar8;
  Mat *pMVar9;
  void *pvVar10;
  MatExpr *pMVar11;
  _InputOutputArray *p_Var12;
  double *pdVar13;
  longlong lVar14;
  undefined8 ***pppuVar15;
  int *piVar16;
  ulonglong uVar17;
  int iVar18;
  size_t _Size;
  ulonglong uVar19;
  uint uVar20;
  undefined8 ****ppppuVar21;
  undefined8 ****ppppuVar22;
  ulonglong uVar23;
  double dVar24;
  double dVar25;
  undefined1 auVar26 [16];
  undefined4 uVar27;
  undefined4 uVar28;
  uint uVar29;
  double dVar30;
  double dVar31;
  undefined1 auStackY_5d8 [32];
  void *local_588;
  Mat *pMStack_580;
  undefined8 local_578;
  undefined8 *local_570;
  Mat *local_568;
  undefined8 local_560;
  undefined4 local_558 [2];
  void ***local_550;
  undefined8 local_548;
  void **local_538;
  Mat *local_530;
  undefined8 local_528;
  int local_518;
  uint uStack_514;
  undefined8 local_510;
  undefined8 **local_508;
  undefined8 uStack_500;
  undefined8 local_4f8;
  undefined8 uStack_4f0;
  undefined4 local_4e8;
  undefined4 local_4e4;
  Mat local_4d8 [16];
  Mat local_4c8 [96];
  Mat local_468 [96];
  Mat local_408 [144];
  undefined8 ***local_378;
  undefined8 ***pppuStack_370;
  undefined8 local_368;
  undefined8 **local_360;
  longlong lStack_358;
  longlong local_350;
  undefined8 **local_348;
  undefined8 uStack_340;
  longlong local_338;
  undefined8 uStack_330;
  undefined8 local_328;
  undefined8 uStack_320;
  undefined8 local_318;
  undefined8 uStack_310;
  undefined8 local_308;
  undefined8 uStack_300;
  undefined8 local_2f8;
  undefined8 uStack_2f0;
  undefined8 **local_2e8;
  undefined8 uStack_2e0;
  undefined8 local_2d8;
  undefined8 uStack_2d0;
  undefined8 local_2c8;
  undefined8 uStack_2c0;
  undefined8 local_2b8;
  undefined8 uStack_2b0;
  undefined8 *local_2a8;
  undefined8 *puStack_2a0;
  undefined8 local_298;
  undefined8 uStack_290;
  undefined8 **local_288;
  undefined8 uStack_280;
  undefined1 local_278 [16];
  undefined8 local_268;
  undefined8 uStack_260;
  undefined1 local_258 [16];
  undefined8 *local_248;
  undefined8 *puStack_240;
  undefined8 local_238;
  undefined8 uStack_230;
  _InputArray local_228 [4];
  int local_224;
  int local_21c;
  void **local_218;
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
  _InputArray local_1b8 [16];
  float local_1a8;
  double local_198;
  double dStack_190;
  double local_188;
  double dStack_180;
  double local_178;
  double dStack_170;
  double local_168;
  double dStack_160;
  double local_158;
  double dStack_150;
  double local_148;
  double dStack_140;
  double local_138;
  double dStack_130;
  double local_128;
  double dStack_120;
  double local_118;
  double dStack_110;
  double local_108;
  double dStack_100;
  double local_f8;
  double dStack_f0;
  double local_e8;
  double dStack_e0;
  ulonglong local_d8;
  
                    /* 0x89070  895
                       ?removeClubShaft@ClubDetection@Detection@GolfIn@@IEBAXAEBVMat@cv@@AEAV45@M@Z
                        */
  local_d8 = DAT_1801d1040 ^ (ulonglong)auStackY_5d8;
  uVar19 = 0;
  pMVar9 = (Mat *)cv::Mat::clone(param_1);
  cv::Mat::operator=(param_2,pMVar9);
  cv::Mat::~Mat(local_4d8);
  bVar6 = cv::Mat::empty(param_2);
  if (!bVar6) {
    local_578 = 0;
    local_588._0_4_ = 0x1010000;
    pMStack_580 = param_2;
    iVar7 = cv::countNonZero((_InputArray *)&local_588);
    if (0 < iVar7) {
      local_378 = (undefined8 ****)0x0;
      pppuStack_370 = (undefined8 ****)0x0;
      local_368 = 0;
      local_578 = 0;
      local_588._0_4_ = 0x8204000c;
      pMStack_580 = (Mat *)&local_378;
      local_528 = 0;
      local_538._0_4_ = 0x1010000;
      local_530 = param_2;
      cv::findContours(&local_538,&local_588,0,2);
      local_578 = 0;
      local_588._0_4_ = 0x8103000c;
      pMStack_580 = (Mat *)local_378;
      cv::fitEllipse(local_1b8);
      uVar29 = SUB84((double)local_1a8 + _DAT_18017ebd8,0);
      iVar7 = *(int *)(param_2 + 8);
      iVar1 = *(int *)(param_2 + 0xc);
      local_578 = 0;
      local_588._0_4_ = 0x8103000c;
      pMStack_580 = (Mat *)local_378;
      cv::moments((_InputArray *)&local_198,SUB81(&local_588,0));
      local_288 = (undefined8 **)0x0;
      uStack_280 = 0;
      local_278 = ZEXT816(0);
      local_268 = 0;
      uStack_260 = 0;
      local_258 = ZEXT816(0);
      local_248 = (undefined8 *)0x0;
      puStack_240 = (undefined8 *)0x0;
      local_238 = 0;
      uStack_230 = 0;
      dVar30 = (double)iVar7 * DAT_18017ea78;
      dVar31 = (double)iVar1 * DAT_18017ea78;
      pvVar10 = (void *)cv::getRotationMatrix2D_
                                  (&local_348,CONCAT44((float)dVar30,(float)dVar31),uVar29,
                                   DAT_18017eaa0);
      local_288 = _DAT_18017ef10;
      uStack_280 = _UNK_18017ef18;
      auVar26 = ZEXT816(0);
      local_268 = 0;
      uStack_260 = 0;
      local_248 = &uStack_280;
      puStack_240 = &local_238;
      local_238 = 0;
      uStack_230 = 0;
      local_278 = auVar26;
      local_258 = auVar26;
      pMVar9 = (Mat *)cv::Mat::Mat(local_4d8,2,3,6,pvVar10,0);
      local_578 = 0;
      local_588._0_4_ = 0x2010000;
      pMStack_580 = (Mat *)&local_288;
      cv::Mat::copyTo(pMVar9,(_OutputArray *)&local_588);
      cv::Mat::~Mat(local_4d8);
      local_218 = (undefined8 **)0x0;
      uStack_210 = 0;
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
      cv::Mat::Mat((Mat *)&local_218);
      local_4f8 = 0;
      uStack_4f0 = 0;
      local_508 = (undefined8 ***)0x0;
      uStack_500 = 0;
      local_578 = 0;
      local_588._0_4_ = 0x1010000;
      pMStack_580 = (Mat *)&local_288;
      local_528 = 0;
      local_538 = (void **)CONCAT44(local_538._4_4_,0x2010000);
      local_530 = (Mat *)&local_218;
      local_560 = 0;
      local_570._0_4_ = 0x1010000;
      local_568 = param_2;
      cv::warpAffine(&local_570,&local_538,&local_588,
                     CONCAT44(**(undefined4 **)(param_2 + 0x40),
                              (*(undefined4 **)(param_2 + 0x40))[1]));
      uVar4 = DAT_18017ebd0;
      pMVar11 = (MatExpr *)cv::operator<(local_4d8,auVar26._0_8_);
      cv::_InputArray::_InputArray((_InputArray *)&local_570,pMVar11);
      local_538 = (void **)0x0;
      local_518 = 1;
      uStack_514 = 1;
      local_558[0] = 0xc1020006;
      local_550 = &local_538;
      local_548 = 0x100000001;
      cv::Mat::setTo((Mat *)&local_218,(_InputArray *)local_558,(_InputArray *)&local_570);
      cv::Mat::~Mat(local_408);
      cv::Mat::~Mat(local_468);
      cv::Mat::~Mat(local_4c8);
      local_560 = 0;
      local_570._0_4_ = 0x8204000c;
      local_568 = (Mat *)&local_378;
      local_578 = 0;
      local_588 = (void *)CONCAT44(local_588._4_4_,0x1010000);
      pMStack_580 = (Mat *)&local_218;
      cv::findContours(&local_588,&local_570,0,2);
      local_560 = 0;
      local_570._0_4_ = 0x8103000c;
      local_568 = (Mat *)local_378;
      cv::boundingRect(local_228);
      uVar23 = uVar19;
      if (0 < iVar1) {
        do {
          local_2e8 = (undefined8 ***)0x0;
          uStack_2e0 = 0;
          local_2d8 = 0;
          uStack_2d0 = 0;
          local_2c8 = 0;
          uStack_2c0 = 0;
          local_2b8 = 0;
          uStack_2b0 = 0;
          local_2a8 = (undefined8 *)0x0;
          puStack_2a0 = (undefined8 *)0x0;
          local_298 = 0;
          uStack_290 = 0;
          iVar18 = (int)uVar23;
          uVar20 = iVar18 + 1;
          local_4e8 = 0x80000000;
          local_4e4 = 0x7fffffff;
          local_518 = iVar18;
          uStack_514 = uVar20;
          cv::Mat::Mat((Mat *)&local_2e8,(Mat *)&local_218,(Range *)&local_4e8,(Range *)&local_518);
          local_560 = 0;
          local_570._0_4_ = 0x1010000;
          local_568 = (Mat *)&local_2e8;
          iVar8 = cv::countNonZero((_InputArray *)&local_570);
          if (iVar8 != 0) {
            local_348 = (undefined8 ***)0x0;
            uStack_340 = 0;
            local_338 = 0;
            uStack_330 = 0;
            local_328 = 0;
            uStack_320 = 0;
            local_318 = 0;
            uStack_310 = 0;
            local_308 = 0;
            uStack_300 = 0;
            local_2f8 = 0;
            uStack_2f0 = 0;
            cv::Mat::Mat((Mat *)&local_348);
            local_560 = 0;
            local_570._0_4_ = 0x2010000;
            local_568 = (Mat *)&local_348;
            local_578 = 0;
            local_588 = (void *)CONCAT44(local_588._4_4_,0x1010000);
            pMStack_580 = (Mat *)&local_2e8;
            cv::findNonZero((_InputArray *)&local_588,(_OutputArray *)&local_570);
            if ((float)local_21c * param_3 < (float)(*(int *)(local_338 + 4) - local_224)) {
              local_510 = CONCAT44(uVar20,iVar18);
              local_538 = (void **)0x7fffffff80000000;
              cv::Mat::Mat(local_4d8,(Mat *)&local_218,(Range *)&local_538,(Range *)&local_510);
              p_Var12 = cv::noArray();
              local_508 = (undefined8 ***)0x0;
              local_4f8 = 0;
              uStack_4f0 = 0;
              uStack_500 = 0;
              local_570._0_4_ = 0xc1020006;
              local_568 = (Mat *)&local_508;
              local_560 = 0x400000001;
              cv::Mat::setTo(local_4d8,(_InputArray *)&local_570,(_InputArray *)p_Var12);
              cv::Mat::~Mat(local_4d8);
            }
            cv::Mat::~Mat((Mat *)&local_348);
          }
          cv::Mat::~Mat((Mat *)&local_2e8);
          uVar23 = (ulonglong)uVar20;
        } while ((int)uVar20 < iVar1);
      }
      local_560 = 0;
      local_570._0_4_ = 0x8204000c;
      local_568 = (Mat *)&local_378;
      local_578 = 0;
      local_588 = (void *)CONCAT44(local_588._4_4_,0x1010000);
      pMStack_580 = (Mat *)&local_218;
      cv::findContours(&local_588,&local_570,0,2);
      pppuVar15 = pppuStack_370;
      _Y = DAT_18017ead0;
      uVar27 = 0;
      uVar28 = 0;
      local_360 = (undefined8 ***)0x0;
      lStack_358 = 0;
      local_350 = 0;
      if (local_378 != pppuStack_370) {
        ppppuVar21 = (undefined8 ****)local_378;
        dVar3 = DAT_18017ed18;
        do {
          local_560 = 0;
          local_570._0_4_ = 0x8103000c;
          local_568 = (Mat *)ppppuVar21;
          pdVar13 = (double *)cv::moments((_InputArray *)local_4d8,SUB81(&local_570,0));
          local_198 = *pdVar13;
          dStack_190 = pdVar13[1];
          local_188 = pdVar13[2];
          dStack_180 = pdVar13[3];
          local_178 = pdVar13[4];
          dStack_170 = pdVar13[5];
          local_168 = pdVar13[6];
          dStack_160 = pdVar13[7];
          local_158 = pdVar13[8];
          dStack_150 = pdVar13[9];
          local_148 = pdVar13[10];
          dStack_140 = pdVar13[0xb];
          local_138 = pdVar13[0xc];
          dStack_130 = pdVar13[0xd];
          local_128 = pdVar13[0xe];
          dStack_120 = pdVar13[0xf];
          local_118 = pdVar13[0x10];
          dStack_110 = pdVar13[0x11];
          local_108 = pdVar13[0x12];
          dStack_100 = pdVar13[0x13];
          local_f8 = pdVar13[0x14];
          dStack_f0 = pdVar13[0x15];
          local_e8 = pdVar13[0x16];
          dStack_e0 = pdVar13[0x17];
          dVar24 = local_188 / local_198;
          dVar25 = pow((double)((int)(dStack_190 / local_198) - iVar1 / 2),_Y);
          dVar24 = pow((double)((int)dVar24 - iVar7 / 2),_Y);
          dVar25 = dVar25 + dVar24;
          if (dVar25 < 0.0) {
            dVar25 = sqrt(dVar25);
          }
          else {
            dVar25 = SQRT(dVar25);
          }
          local_560 = 0;
          local_570._0_4_ = 0x8103000c;
          local_568 = (Mat *)ppppuVar21;
          dVar24 = cv::contourArea((_InputArray *)&local_570,false);
          if (((double)CONCAT44(uVar28,uVar27) <= dVar24 &&
               dVar24 != (double)CONCAT44(uVar28,uVar27)) ||
             ((dVar24 == (double)CONCAT44(uVar28,uVar27) && (dVar25 < dVar3)))) {
            uVar27 = SUB84(dVar24,0);
            uVar28 = (undefined4)((ulonglong)dVar24 >> 0x20);
            dVar3 = dVar25;
            if ((undefined8 ****)&local_360 != ppppuVar21) {
              FUN_180006f10((ulonglong *)&local_360,*ppppuVar21,
                            (longlong)ppppuVar21[1] - (longlong)*ppppuVar21 >> 3);
            }
          }
          ppppuVar21 = ppppuVar21 + 3;
        } while (ppppuVar21 != (undefined8 ****)pppuVar15);
      }
      lVar14 = (longlong)pppuStack_370 - (longlong)local_378 >> 0x3f;
      ppppuVar21 = (undefined8 ****)local_378;
      pppuVar15 = (undefined8 ***)local_360;
      ppppuVar22 = (undefined8 ****)pppuStack_370;
      uVar23 = uVar19;
      if (((longlong)pppuStack_370 - (longlong)local_378) / 0x18 + lVar14 != lVar14) {
        do {
          piVar2 = *(int **)((longlong)ppppuVar21 + uVar19 + 8);
          piVar16 = *(int **)((longlong)ppppuVar21 + uVar19);
          if ((longlong)piVar2 - (longlong)piVar16 >> 3 == lStack_358 - (longlong)pppuVar15 >> 3) {
            if (piVar16 != piVar2) {
              lVar14 = (longlong)pppuVar15 - (longlong)piVar16;
              do {
                if ((*piVar16 != *(int *)((longlong)piVar16 + lVar14)) ||
                   (piVar16[1] != *(int *)((longlong)piVar16 + lVar14 + 4))) {
                  bVar6 = false;
                  goto LAB_1800899d4;
                }
                piVar16 = piVar16 + 2;
              } while (piVar16 != piVar2);
            }
            bVar6 = true;
LAB_1800899d4:
            if (!bVar6) goto LAB_1800899dc;
          }
          else {
LAB_1800899dc:
            cv::noArray();
            pppuVar15 = local_378;
            local_348 = (undefined8 ***)0x0;
            local_338 = 0;
            uStack_330 = 0;
            uStack_340 = 0;
            local_588 = (void *)0x0;
            pMStack_580 = (Mat *)0x0;
            local_578 = 0;
            uVar17 = *(longlong *)((longlong)local_378 + uVar19 + 8) -
                     *(longlong *)((longlong)local_378 + uVar19) >> 3;
            if (uVar17 != 0) {
              if (0x1fffffffffffffff < uVar17) {
                    /* WARNING: Subroutine does not return */
                FUN_1800075d0();
              }
              FUN_180008fe0((ulonglong *)&local_588,uVar17);
              pvVar5 = local_588;
              pvVar10 = *(void **)((longlong)pppuVar15 + uVar19);
              _Size = *(longlong *)((longlong)pppuVar15 + uVar19 + 8) - (longlong)pvVar10;
              memmove(local_588,pvVar10,_Size);
              pMStack_580 = (Mat *)((longlong)pvVar5 + ((longlong)_Size >> 3) * 8);
            }
            local_538 = &local_588;
            local_530 = (Mat *)&local_570;
            local_568 = (Mat *)FUN_180042e00(&local_508,(longlong *)&local_538);
            local_560 = 0;
            local_570._0_4_ = 0x8104000c;
            local_548 = 0;
            local_558[0] = 0x3010000;
            local_550 = &local_218;
            cv::drawContours(local_558,&local_570,0xffffffff,&local_348);
            FUN_180043110((longlong *)&local_508);
            _eh_vector_destructor_iterator_
                      (&local_588,0x18,1,
                       FID_conflict__vector<struct_CHN*___ptr64,class_std::allocator<struct_CHN*___ptr64>_>
                      );
            ppppuVar21 = (undefined8 ****)local_378;
            pppuVar15 = (undefined8 ***)local_360;
            ppppuVar22 = (undefined8 ****)pppuStack_370;
          }
          uVar23 = uVar23 + 1;
          uVar19 = uVar19 + 0x18;
        } while (uVar23 < (ulonglong)(((longlong)ppppuVar22 - (longlong)ppppuVar21) / 0x18));
      }
      pvVar10 = (void *)cv::getRotationMatrix2D_
                                  (&local_348,CONCAT44((float)dVar30,(float)dVar31),
                                   uVar29 ^ (uint)DAT_18017f130,DAT_18017eaa0);
      local_2e8 = _DAT_18017ef10;
      uStack_2e0 = _UNK_18017ef18;
      dVar30 = 0.0;
      local_2d8 = 0;
      uStack_2d0 = 0;
      local_2c8 = 0;
      uStack_2c0 = 0;
      local_2b8 = 0;
      uStack_2b0 = 0;
      local_2a8 = &uStack_2e0;
      puStack_2a0 = &local_298;
      local_298 = 0;
      uStack_290 = 0;
      pMVar9 = (Mat *)cv::Mat::Mat(local_4d8,2,3,6,pvVar10,0);
      local_548 = 0;
      local_558[0] = 0x2010000;
      local_550 = &local_2e8;
      cv::Mat::copyTo(pMVar9,(_OutputArray *)local_558);
      cv::Mat::~Mat(local_4d8);
      cv::Mat::operator=((Mat *)&local_288,(Mat *)&local_2e8);
      cv::Mat::~Mat((Mat *)&local_2e8);
      local_338 = 0;
      uStack_330 = 0;
      local_348 = (undefined8 ***)0x0;
      uStack_340 = 0;
      local_548 = 0;
      local_558[0] = 0x1010000;
      local_550 = &local_288;
      local_560 = 0;
      local_570._0_4_ = 0x2010000;
      local_578 = 0;
      local_588 = (void *)CONCAT44(local_588._4_4_,0x1010000);
      pMStack_580 = (Mat *)&local_218;
      local_568 = param_2;
      cv::warpAffine(&local_588,&local_570,local_558,
                     CONCAT44(**(undefined4 **)(param_2 + 0x40),
                              (*(undefined4 **)(param_2 + 0x40))[1]));
      pMVar11 = (MatExpr *)cv::operator>(local_4d8,dVar30);
      cv::_InputArray::_InputArray((_InputArray *)&local_508,pMVar11);
      local_510 = uVar4;
      local_538 = (void **)0x100000001;
      local_558[0] = 0xc1020006;
      local_550 = (void ***)&local_510;
      local_548 = 0x100000001;
      cv::Mat::setTo(param_2,(_InputArray *)local_558,(_InputArray *)&local_508);
      cv::Mat::~Mat(local_408);
      cv::Mat::~Mat(local_468);
      cv::Mat::~Mat(local_4c8);
      if ((undefined8 ***)local_360 != (undefined8 ***)0x0) {
        pppuVar15 = (undefined8 ***)local_360;
        if ((0xfff < (ulonglong)((local_350 - (longlong)local_360 >> 3) * 8)) &&
           (pppuVar15 = (undefined8 ***)local_360[-1],
           0x1f < (ulonglong)((longlong)local_360 + (-8 - (longlong)pppuVar15)))) {
                    /* WARNING: Subroutine does not return */
          _invalid_parameter_noinfo_noreturn();
        }
        free(pppuVar15);
        local_360 = (undefined8 ***)0x0;
        lStack_358 = 0;
        local_350 = 0;
      }
      cv::Mat::~Mat((Mat *)&local_218);
      cv::Mat::~Mat((Mat *)&local_288);
      FUN_180043110((longlong *)&local_378);
    }
  }
  return;
}

