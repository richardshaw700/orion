FUNCTION: GolfIn::YoloClubSegmentation::predict
ENTRY: 18008ff40
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: void __cdecl GolfIn::YoloClubSegmentation::predict(class cv::Mat const & __ptr64,class
   std::vector<struct GolfIn::ClubOutputParams,class std::allocator<struct GolfIn::ClubOutputParams>
   > & __ptr64) __ptr64 */

void __thiscall
GolfIn::YoloClubSegmentation::predict
          (YoloClubSegmentation *this,Mat *param_1,
          vector<struct_GolfIn::ClubOutputParams,class_std::allocator<struct_GolfIn::ClubOutputParams>_>
          *param_2)

{
  float fVar1;
  float fVar2;
  Net *this_00;
  double dVar3;
  double dVar4;
  double dVar5;
  ulonglong *puVar6;
  int *piVar7;
  double dVar8;
  double dVar9;
  int iVar10;
  int iVar11;
  Mat *this_01;
  undefined8 *puVar12;
  longlong lVar13;
  _InputOutputArray *p_Var14;
  int *piVar15;
  void *pvVar16;
  int iVar17;
  undefined8 *puVar18;
  longlong lVar19;
  ulonglong *puVar20;
  uint uVar21;
  ulonglong uVar22;
  float *pfVar23;
  int *piVar24;
  size_t _Size;
  undefined1 auStackY_688 [32];
  float local_638;
  uint local_634;
  int local_630;
  int local_62c;
  int local_628;
  int local_624;
  int local_620;
  uint local_61c;
  longlong local_618;
  undefined8 uStack_610;
  undefined8 local_608;
  undefined8 uStack_600;
  undefined4 local_5f8;
  undefined4 local_5f4;
  int local_5f0;
  undefined4 local_5ec;
  ulonglong local_5e8;
  ulonglong uStack_5e0;
  undefined1 local_5d8 [16];
  undefined8 local_5c8;
  undefined8 uStack_5c0;
  int *local_5b8;
  undefined8 *local_5b0;
  undefined8 local_5a8;
  undefined8 local_5a0;
  undefined8 local_598;
  undefined8 uStack_590;
  undefined8 local_588;
  undefined8 uStack_580;
  undefined8 local_578;
  undefined8 uStack_570;
  undefined8 local_568;
  undefined8 uStack_560;
  undefined8 local_558 [2];
  Mat local_548 [96];
  Mat local_4e8 [96];
  Mat local_488 [144];
  undefined8 local_3f8;
  undefined8 uStack_3f0;
  float *local_3e8;
  undefined8 uStack_3e0;
  undefined8 local_3d8;
  undefined8 uStack_3d0;
  undefined8 local_3c8;
  undefined8 uStack_3c0;
  undefined8 local_3b8;
  undefined8 uStack_3b0;
  undefined8 local_3a8;
  undefined8 uStack_3a0;
  undefined8 **local_398;
  undefined8 local_390;
  longlong *plStack_388;
  undefined8 local_380;
  undefined8 *local_378;
  undefined8 *puStack_370;
  undefined8 **local_368;
  undefined8 uStack_360;
  ulonglong *local_358;
  ulonglong *puStack_350;
  ulonglong *local_348;
  undefined8 local_340;
  void *local_338;
  int *piStack_330;
  int *local_328;
  void *local_320;
  float *pfStack_318;
  float *local_310;
  void *local_308;
  undefined4 *puStack_300;
  undefined4 *local_2f8;
  undefined8 local_2f0;
  undefined8 uStack_2e8;
  int *local_2e0;
  int *piStack_2d8;
  longlong local_2d0;
  undefined8 *local_2c8;
  undefined8 *puStack_2c0;
  undefined8 local_2b8;
  Mat *local_2b0;
  undefined4 local_2a8;
  undefined4 local_2a4;
  longlong local_2a0;
  undefined8 uStack_298;
  undefined8 local_290;
  undefined4 local_288;
  undefined4 uStack_284;
  undefined4 uStack_280;
  undefined4 uStack_27c;
  double local_278;
  double dStack_270;
  double local_268;
  double dStack_260;
  longlong local_258;
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
  undefined4 local_1f8;
  undefined4 local_1f4;
  undefined8 local_1f0;
  undefined8 uStack_1e8;
  Mat local_1e0 [104];
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
  undefined8 local_e8;
  undefined8 uStack_e0;
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  undefined8 uStack_c0;
  ulonglong local_b8;
  
                    /* 0x8ff40  870
                       ?predict@YoloClubSegmentation@GolfIn@@QEAAXAEBVMat@cv@@AEAV?$vector@UClubOutputParams@GolfIn@@V?$allocator@UClubOutputParams@GolfIn@@@std@@@std@@@Z
                        */
  local_b8 = DAT_1801d1040 ^ (ulonglong)auStackY_688;
  local_61c = 0;
  local_634 = 0;
  local_118 = 0;
  uStack_110 = 0;
  local_108 = 0;
  uStack_100 = 0;
  local_f8 = 0;
  uStack_f0 = 0;
  local_e8 = 0;
  uStack_e0 = 0;
  local_d8 = 0;
  uStack_d0 = 0;
  local_c8 = 0;
  uStack_c0 = 0;
  local_2f0 = this;
  local_2b0 = param_1;
  cv::Mat::Mat((Mat *)&local_118);
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
  local_128 = 0;
  uStack_120 = 0;
  cv::Mat::Mat((Mat *)&local_178);
  local_288 = 0;
  uStack_284 = 0;
  uStack_280 = 0;
  uStack_27c = 0;
  local_278 = 0.0;
  dStack_270 = 0.0;
  local_618 = _DAT_18017f040;
  uStack_610 = _UNK_18017f048;
  local_608 = _DAT_18017ee50;
  uStack_600 = _UNK_18017ee58;
  local_398 = *(undefined8 ***)(this + 0xe0);
  letter_box(this,param_1,(Mat *)&local_178,(Vec<double,4> *)&local_288,(Size_<int> *)&local_398,
             false,true,true,0x20,(Scalar_<double> *)&local_618);
  local_618 = 0;
  uStack_610 = 0;
  local_608 = 0;
  uStack_600 = 0;
  local_398 = *(undefined8 ***)(this + 0xe0);
  local_368 = (undefined8 **)0x0;
  local_378 = (undefined8 *)CONCAT44(local_378._4_4_,0x2010000);
  puStack_370 = &local_118;
  local_380 = 0;
  local_390._0_4_ = 0x1010000;
  plStack_388 = &local_178;
  cv::dnn::dnn4_v20240521::blobFromImage
            ((_InputArray *)&local_390,(_OutputArray *)&local_378,DAT_18017e9c8,
             (Size_<int> *)&local_398,(Scalar_<double> *)&local_618,true,false,5);
  this_00 = *(Net **)(this + 0x48);
  local_368 = (undefined8 **)0x0;
  uStack_360 = 0;
  local_378 = (undefined8 *)0x0;
  puStack_370 = (undefined8 *)0x0;
  local_618 = 0;
  uStack_610 = 0;
  local_608 = 0;
  uStack_600 = 0;
  FUN_18000c1d0(&local_618,&DAT_18016a0f8,0);
  local_380 = 0;
  local_390 = CONCAT44(local_390._4_4_,0x1010000);
  plStack_388 = &local_118;
  cv::dnn::dnn4_v20240521::Net::setInput
            (this_00,(_InputArray *)&local_390,
             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             &local_618,DAT_18017eaa0,(Scalar_<double> *)&local_378);
  FUN_18000c8d0(&local_618);
  local_2a0 = 0;
  uStack_298 = 0;
  local_290 = 0;
  local_2c8 = (undefined8 *)0x0;
  puStack_2c0 = (undefined8 *)0x0;
  local_2b8 = 0;
  local_598 = 0;
  uStack_590 = 0;
  local_588 = 0;
  uStack_580 = 0;
  FUN_18000c1d0(&local_598,"output0",7);
  local_578 = 0;
  uStack_570 = 0;
  local_568 = 0;
  uStack_560 = 0;
  FUN_18000c1d0(&local_578,"output1",7);
  local_2c8 = (undefined8 *)0x0;
  puStack_2c0 = (undefined8 *)0x0;
  local_2b8 = 0;
  FUN_18000bc20((ulonglong *)&local_2c8,2);
  local_398 = &local_2c8;
  puVar12 = &local_598;
  local_378 = local_2c8;
  local_368 = &local_2c8;
  puVar18 = local_2c8;
  do {
    puStack_370 = puVar18;
    FUN_18000cb00(puVar18,puVar12);
    puVar18 = puVar18 + 4;
    puVar12 = puVar12 + 4;
  } while (puVar12 != local_558);
  puStack_370 = puVar18;
  puStack_2c0 = puVar18;
  _eh_vector_destructor_iterator_(&local_598,0x20,2,thunk_FUN_18000c8d0);
  local_380 = 0;
  local_390 = CONCAT44(local_390._4_4_,0x2050000);
  plStack_388 = &local_2a0;
  cv::dnn::dnn4_v20240521::Net::forward
            (*(Net **)(this + 0x48),(_OutputArray *)&local_390,
             (vector<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_std::allocator<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>_>
              *)&local_2c8);
  local_308 = (void *)0x0;
  puStack_300 = (undefined4 *)0x0;
  local_2f8 = (undefined4 *)0x0;
  local_320 = (void *)0x0;
  pfStack_318 = (float *)0x0;
  local_310 = (float *)0x0;
  local_338 = (void *)0x0;
  piStack_330 = (int *)0x0;
  local_328 = (int *)0x0;
  local_358 = (ulonglong *)0x0;
  puStack_350 = (ulonglong *)0x0;
  local_348 = (ulonglong *)0x0;
  local_3f8 = 0;
  uStack_3f0 = 0;
  local_3e8 = (float *)0x0;
  uStack_3e0 = 0;
  local_3d8 = 0;
  uStack_3d0 = 0;
  local_3c8 = 0;
  uStack_3c0 = 0;
  local_3b8 = 0;
  uStack_3b0 = 0;
  local_3a8 = 0;
  uStack_3a0 = 0;
  this_01 = (Mat *)cv::Mat::Mat((Mat *)&local_5f8,
                                CONCAT44(*(undefined4 *)(*(longlong *)(local_2a0 + 0x40) + 4),
                                         *(undefined4 *)(*(longlong *)(local_2a0 + 0x40) + 8)),5,
                                *(undefined8 *)(local_2a0 + 0x10));
  puVar12 = (undefined8 *)cv::Mat::t(this_01);
  FUN_18000bf80(puVar12,(Mat *)&local_3f8);
  cv::Mat::~Mat(local_488);
  cv::Mat::~Mat(local_4e8);
  cv::Mat::~Mat(local_548);
  cv::Mat::~Mat((Mat *)&local_5f8);
  dVar9 = dStack_270;
  dVar8 = local_278;
  dVar5 = DAT_18017ea78;
  local_634 = (uint)uStack_3f0;
  lVar13 = (longlong)uStack_3f0._4_4_;
  iVar17 = (uStack_3f0._4_4_ - *(int *)(*(longlong *)(local_2a0 + 0xa0) + 4)) + -4;
  local_62c = 0;
  dVar3 = (double)CONCAT44(uStack_284,local_288);
  dVar4 = (double)CONCAT44(uStack_27c,uStack_280);
  uVar21 = 0;
  local_630 = iVar17;
  if (0 < (int)(uint)uStack_3f0) {
    pfVar23 = local_3e8;
    do {
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
      local_208 = 0;
      uStack_200 = 0;
      cv::Mat::Mat((Mat *)&local_258,1,iVar17,5,pfVar23 + 4,0);
      local_340 = 0;
      p_Var14 = cv::noArray();
      local_380 = 0;
      local_390 = CONCAT44(local_390._4_4_,0x1010000);
      plStack_388 = &local_258;
      cv::minMaxLoc((_InputArray *)&local_390,(double *)0x0,(double *)&local_398,(Point_<int> *)0x0,
                    (Point_<int> *)&local_340,(_InputArray *)p_Var14);
      local_398 = (undefined8 **)(double)(float)(double)local_398;
      if ((double)*(float *)(this + 0xe8) <= (double)local_398) {
        local_378 = (undefined8 *)0x0;
        puStack_370 = (undefined8 *)0x0;
        local_368 = (undefined8 **)0x0;
        _Size = (longlong)pfVar23 + (lVar13 * 4 - (longlong)(pfVar23 + (longlong)iVar17 + 4));
        uVar22 = (longlong)_Size >> 2;
        if (uVar22 != 0) {
          if (0x3fffffffffffffff < uVar22) {
                    /* WARNING: Subroutine does not return */
            FUN_1800075d0();
          }
          FUN_180008f50((ulonglong *)&local_378,uVar22);
          puVar12 = local_378;
          memmove(local_378,pfVar23 + (longlong)iVar17 + 4,_Size);
          puStack_370 = (undefined8 *)((longlong)puVar12 + uVar22 * 4);
        }
        if (puStack_350 == local_348) {
          FUN_180091230((ulonglong *)&local_358,puStack_350,(longlong *)&local_378);
        }
        else {
          FUN_180063640(puStack_350,(longlong *)&local_378);
          puStack_350 = puStack_350 + 3;
        }
        fVar1 = pfVar23[2];
        fVar2 = pfVar23[3];
        iVar10 = (int)(((double)(float)(((double)*pfVar23 - dVar8) / dVar3) -
                       (double)(float)((double)fVar1 / dVar3) * dVar5) + dVar5);
        iVar17 = 0;
        if (-1 < iVar10) {
          iVar17 = iVar10;
        }
        iVar11 = (int)(((double)(float)(((double)pfVar23[1] - dVar9) / dVar4) -
                       (double)(float)((double)fVar2 / dVar4) * dVar5) + dVar5);
        iVar10 = 0;
        if (-1 < iVar11) {
          iVar10 = iVar11;
        }
        local_624 = iVar10;
        local_620 = iVar17;
        if (puStack_300 == local_2f8) {
          FUN_180046a00((longlong *)&local_308,puStack_300,(undefined4 *)&local_340);
        }
        else {
          *puStack_300 = (undefined4)local_340;
          puStack_300 = puStack_300 + 1;
        }
        local_638 = (float)(double)local_398;
        if (pfStack_318 == local_310) {
          FUN_180046a00((longlong *)&local_320,pfStack_318,&local_638);
        }
        else {
          *pfStack_318 = local_638;
          pfStack_318 = pfStack_318 + 1;
        }
        local_638 = (float)(int)((double)(float)((double)fVar2 / dVar4) + dVar5);
        local_628 = (int)((double)(float)((double)fVar1 / dVar3) + dVar5);
        if (piStack_330 == local_328) {
          FUN_180091070((longlong *)&local_338,piStack_330,&local_620,&local_624,&local_628,
                        &local_638);
        }
        else {
          *piStack_330 = iVar17;
          piStack_330[1] = iVar10;
          piStack_330[2] = local_628;
          piStack_330[3] = (int)local_638;
          piStack_330 = piStack_330 + 4;
        }
        this = local_2f0;
        iVar17 = local_630;
        if (local_378 != (undefined8 *)0x0) {
          puVar12 = local_378;
          if ((0xfff < (ulonglong)(((longlong)local_368 - (longlong)local_378 >> 2) * 4)) &&
             (puVar12 = (undefined8 *)local_378[-1],
             0x1f < (ulonglong)((longlong)local_378 + (-8 - (longlong)puVar12)))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(puVar12);
          this = local_2f0;
          iVar17 = local_630;
        }
      }
      pfVar23 = pfVar23 + lVar13;
      cv::Mat::~Mat((Mat *)&local_258);
      local_62c = local_62c + 1;
      param_1 = local_2b0;
      uVar21 = local_61c;
    } while (local_62c < (int)local_634);
  }
  local_2e0 = (int *)0x0;
  piStack_2d8 = (int *)0x0;
  local_2d0 = 0;
  cv::dnn::dnn4_v20240521::NMSBoxes
            ((vector<class_cv::Rect_<int>,class_std::allocator<class_cv::Rect_<int>_>_> *)&local_338
             ,(vector<float,class_std::allocator<float>_> *)&local_320,*(float *)(this + 0xe8),
             *(float *)(this + 0xec),(vector<int,class_std::allocator<int>_> *)&local_2e0,
             DAT_18017e9d8,0);
  piVar7 = piStack_2d8;
  local_390 = 0;
  plStack_388 = (longlong *)0x0;
  local_380 = 0;
  local_2a4 = *(undefined4 *)(param_1 + 8);
  local_2a8 = *(undefined4 *)(param_1 + 0xc);
  local_2b0 = (Mat *)0x0;
  uStack_280 = **(undefined4 **)(param_1 + 0x40);
  uStack_284 = (*(undefined4 **)(param_1 + 0x40))[1];
  local_2f0 = (YoloClubSegmentation *)CONCAT44(uStack_280,uStack_284);
  local_288 = *(undefined4 *)(this + 0xf0);
  local_268 = dVar8;
  dStack_260 = dVar9;
  local_278 = dVar3;
  dStack_270 = dVar4;
  for (piVar24 = local_2e0; piVar24 != piVar7; piVar24 = piVar24 + 1) {
    lVar19 = (longlong)*piVar24;
    local_1f0 = 0;
    uStack_1e8 = 0;
    cv::Mat::Mat(local_1e0);
    local_1f8 = *(undefined4 *)((longlong)local_308 + lVar19 * 4);
    local_1f4 = *(undefined4 *)((longlong)local_320 + lVar19 * 4);
    puVar12 = (undefined8 *)(lVar19 * 0x10 + (longlong)local_338);
    local_2f0 = (YoloClubSegmentation *)*puVar12;
    uStack_2e8 = puVar12[1];
    piVar15 = FUN_180090f30((int *)&local_2f0,(int *)&local_2b0);
    lVar13 = local_2a0;
    local_1f0 = *(undefined8 *)piVar15;
    uStack_1e8 = *(undefined8 *)(piVar15 + 2);
    if (0 < piVar15[3] * piVar15[2]) {
      local_5f8 = 0x42ff4005;
      local_5f4 = 2;
      local_5f0 = (int)((longlong)(local_358[lVar19 * 3 + 1] - local_358[lVar19 * 3]) >> 2);
      local_5ec = 1;
      uStack_5e0 = 0;
      local_5d8 = ZEXT416(0);
      local_5c8 = 0;
      uStack_5c0 = 0;
      local_5b8 = &local_5f0;
      local_5b0 = &local_5a8;
      local_5a8 = 0;
      local_5a0 = 0;
      if (local_358[lVar19 * 3] != local_358[lVar19 * 3 + 1]) {
        local_5a0 = 4;
        local_5a8 = 4;
        uStack_5e0 = local_358[lVar19 * 3];
        local_5d8._8_8_ = uStack_5e0 + (longlong)local_5f0 * 4;
        local_5d8._0_8_ = local_5d8._8_8_;
      }
      local_5e8 = uStack_5e0;
      puVar12 = (undefined8 *)cv::Mat::t((Mat *)&local_5f8);
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
      local_208 = 0;
      uStack_200 = 0;
      cv::Mat::Mat((Mat *)&local_258);
      local_634 = uVar21 | 1;
      (**(code **)(*(longlong *)*puVar12 + 0x10))
                ((longlong *)*puVar12,puVar12,&local_258,0xffffffff);
      get_mask(this,(Mat *)&local_258,(Mat *)(lVar13 + 0x60),(ClubOutputParams *)&local_1f8,
               (ClubMaskParams *)&local_288);
      uVar21 = uVar21 & 0xfffffffe;
      cv::Mat::~Mat((Mat *)&local_258);
      cv::Mat::~Mat(local_488);
      cv::Mat::~Mat(local_4e8);
      cv::Mat::~Mat(local_548);
      cv::Mat::~Mat((Mat *)&local_5f8);
      puVar12 = *(undefined8 **)(param_2 + 8);
      if (puVar12 == *(undefined8 **)(param_2 + 0x10)) {
        FUN_18008dc50((longlong *)param_2,puVar12,&local_1f8);
      }
      else {
        *(undefined4 *)puVar12 = local_1f8;
        *(undefined4 *)((longlong)puVar12 + 4) = local_1f4;
        puVar12[1] = local_1f0;
        puVar12[2] = uStack_1e8;
        cv::Mat::Mat((Mat *)(puVar12 + 3),local_1e0);
        *(longlong *)(param_2 + 8) = *(longlong *)(param_2 + 8) + 0x78;
      }
    }
    cv::Mat::~Mat(local_1e0);
  }
  if (local_2e0 != (int *)0x0) {
    piVar24 = local_2e0;
    if ((0xfff < (ulonglong)((local_2d0 - (longlong)local_2e0 >> 2) * 4)) &&
       (piVar24 = *(int **)(local_2e0 + -2),
       0x1f < (ulonglong)((longlong)local_2e0 + (-8 - (longlong)piVar24)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(piVar24);
    local_2e0 = (int *)0x0;
    piStack_2d8 = (int *)0x0;
    local_2d0 = 0;
  }
  cv::Mat::~Mat((Mat *)&local_3f8);
  puVar6 = puStack_350;
  puVar20 = local_358;
  if (local_358 != (ulonglong *)0x0) {
    for (; puVar20 != puVar6; puVar20 = puVar20 + 3) {
      FUN_180091550((longlong *)puVar20);
    }
    puVar20 = local_358;
    if ((0xfff < (ulonglong)((((longlong)local_348 - (longlong)local_358) / 0x18) * 0x18)) &&
       (puVar20 = (ulonglong *)local_358[-1],
       0x1f < (ulonglong)((longlong)local_358 + (-8 - (longlong)puVar20)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(puVar20);
    local_358 = (ulonglong *)0x0;
    puStack_350 = (ulonglong *)0x0;
    local_348 = (ulonglong *)0x0;
  }
  if (local_338 != (void *)0x0) {
    pvVar16 = local_338;
    if ((0xfff < ((longlong)local_328 - (longlong)local_338 & 0xfffffffffffffff0U)) &&
       (pvVar16 = *(void **)((longlong)local_338 + -8),
       0x1f < (ulonglong)((longlong)local_338 + (-8 - (longlong)pvVar16)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar16);
    local_338 = (void *)0x0;
    piStack_330 = (int *)0x0;
    local_328 = (int *)0x0;
  }
  if (local_320 != (void *)0x0) {
    pvVar16 = local_320;
    if ((0xfff < (ulonglong)(((longlong)local_310 - (longlong)local_320 >> 2) * 4)) &&
       (pvVar16 = *(void **)((longlong)local_320 + -8),
       0x1f < (ulonglong)((longlong)local_320 + (-8 - (longlong)pvVar16)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar16);
    local_320 = (void *)0x0;
    pfStack_318 = (float *)0x0;
    local_310 = (float *)0x0;
  }
  if (local_308 != (void *)0x0) {
    pvVar16 = local_308;
    if ((0xfff < (ulonglong)(((longlong)local_2f8 - (longlong)local_308 >> 2) * 4)) &&
       (pvVar16 = *(void **)((longlong)local_308 + -8),
       0x1f < (ulonglong)((longlong)local_308 + (-8 - (longlong)pvVar16)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar16);
    local_308 = (void *)0x0;
    puStack_300 = (undefined4 *)0x0;
    local_2f8 = (undefined4 *)0x0;
  }
  FUN_18000bd00((longlong *)&local_2c8);
  FUN_18000c7a0(&local_2a0);
  cv::Mat::~Mat((Mat *)&local_178);
  cv::Mat::~Mat((Mat *)&local_118);
  return;
}

