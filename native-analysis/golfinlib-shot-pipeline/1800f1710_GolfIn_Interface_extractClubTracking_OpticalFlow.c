FUNCTION: GolfIn::Interface::extractClubTracking_OpticalFlow
ENTRY: 1800f1710
REASONS: name:club; string:Club.Detection


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: struct GolfIn::Interface::ExtractedClubTrackingResults __cdecl
   GolfIn::Interface::extractClubTracking_OpticalFlow(class cv::Mat const & __ptr64,class
   cv::Point_<float> const & __ptr64,class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > const & __ptr64,class cv::Rect_<double> const
   & __ptr64,int,class std::shared_ptr<class GolfIn::Detection::ClubDetection>) __ptr64 */

uint * __thiscall
GolfIn::Interface::extractClubTracking_OpticalFlow
          (Interface *this,uint *param_1,Mat *param_2,longlong param_3,undefined8 *param_4,
          double *param_5,uint param_7,longlong *param_8)

{
  longlong *plVar1;
  undefined1 auVar2 [12];
  float fVar3;
  float fVar4;
  float fVar5;
  float fVar6;
  double dVar7;
  double dVar8;
  bool bVar9;
  int iVar10;
  Parameter *pPVar11;
  int *piVar12;
  float *pfVar13;
  ulonglong uVar14;
  longlong *plVar15;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar16;
  longlong lVar17;
  void *pvVar18;
  int iVar19;
  undefined8 *puVar20;
  Tracker *this_00;
  char *******pppppppcVar21;
  undefined8 *******_Buf1;
  int iVar22;
  _InputArray *p_Var23;
  Interface *pIVar24;
  char *******pppppppcVar25;
  uint uVar26;
  size_t sVar27;
  int iVar28;
  float fVar29;
  float fVar30;
  double dVar31;
  undefined1 auVar32 [16];
  double dVar33;
  undefined1 auVar34 [16];
  undefined8 uVar36;
  undefined1 auVar35 [16];
  undefined1 auStackY_6a8 [32];
  bool local_657 [7];
  undefined8 local_650;
  uint local_648;
  uint local_644;
  int local_638;
  int iStack_634;
  int iStack_630;
  int iStack_62c;
  float local_628;
  uint local_624;
  float local_620;
  float local_61c;
  float local_618;
  float local_614;
  longlong local_610 [2];
  undefined1 local_600 [16];
  longlong local_5f0 [4];
  longlong local_5d0 [4];
  undefined4 local_5b0 [2];
  undefined8 *local_5a8;
  undefined8 local_5a0;
  void *local_598;
  undefined8 uStack_590;
  longlong local_588;
  undefined4 local_580 [2];
  undefined8 *local_578;
  undefined8 local_570;
  undefined4 local_568;
  Mat *local_560;
  undefined8 local_558;
  undefined4 local_550 [2];
  undefined8 *local_548;
  undefined8 local_540;
  undefined4 local_538 [2];
  undefined8 *local_530;
  undefined8 local_528;
  undefined4 local_520 [2];
  undefined8 *local_518;
  undefined8 local_510;
  undefined4 local_508 [2];
  undefined8 *local_500;
  undefined8 local_4f8;
  undefined4 local_4f0 [2];
  undefined8 *local_4e8;
  undefined8 local_4e0;
  undefined4 local_4d8 [2];
  undefined8 *local_4d0;
  undefined8 local_4c8;
  undefined4 local_4c0 [2];
  undefined8 *local_4b8;
  undefined8 local_4b0;
  undefined4 local_4a8 [2];
  undefined8 *local_4a0;
  undefined8 local_498;
  undefined4 local_490 [2];
  undefined8 *local_488;
  undefined8 local_480;
  longlong local_478 [12];
  longlong *local_418;
  undefined8 local_410;
  undefined8 uStack_408;
  longlong local_400;
  longlong lStack_3f8;
  longlong local_3f0;
  longlong lStack_3e8;
  undefined8 local_3e0;
  undefined8 uStack_3d8;
  undefined8 local_3d0;
  undefined8 uStack_3c8;
  undefined8 local_3c0;
  undefined8 uStack_3b8;
  undefined8 local_3b0;
  undefined8 uStack_3a8;
  undefined8 local_3a0;
  undefined8 uStack_398;
  undefined8 local_390;
  undefined8 uStack_388;
  undefined8 local_380;
  undefined8 uStack_378;
  undefined8 local_370;
  undefined8 uStack_368;
  _InputArray local_360 [16];
  undefined4 local_350;
  float fStack_34c;
  undefined4 uStack_348;
  undefined4 uStack_344;
  float local_340;
  undefined4 uStack_33c;
  undefined4 uStack_338;
  undefined4 uStack_334;
  char local_330 [32];
  char local_310 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_2f0 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_2d0 [32];
  char local_2b0 [40];
  Mat local_288 [96];
  double local_228;
  double dStack_220;
  double local_218;
  double dStack_210;
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
  int *local_168;
  undefined8 uStack_160;
  undefined8 local_158;
  undefined8 uStack_150;
  char ******local_148;
  longlong lStack_140;
  longlong local_138;
  ulonglong uStack_130;
  undefined8 ******local_128;
  undefined8 uStack_120;
  longlong local_118;
  ulonglong local_110;
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
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_a8 [32];
  ulonglong local_88;
  
                    /* 0xf1710  567
                       ?extractClubTracking_OpticalFlow@Interface@GolfIn@@IEAA?AUExtractedClubTrackingResults@12@AEBVMat@cv@@AEBV?$Point_@M@5@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$Rect_@N@5@HV?$shared_ptr@VClubDetection@Detection@GolfIn@@@8@@Z
                        */
  local_88 = DAT_1801d1040 ^ (ulonglong)auStackY_6a8;
  local_644 = param_7;
  local_418 = param_8;
  local_648 = 0;
  local_1a8 = 0;
  uStack_1a0 = 0;
  local_198 = 0;
  uStack_190 = 0;
  local_188 = 0;
  uStack_180 = 0;
  local_178 = 0;
  uStack_170 = 0;
  local_168 = (int *)0x0;
  uStack_160 = 0;
  local_158 = 0;
  uStack_150 = 0;
  local_650 = param_3;
  cv::Mat::clone(param_2);
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
  cv::Mat::clone(param_2);
  *param_1 = 0xffffffff;
  *(undefined2 *)(param_1 + 1) = 0;
  dVar8 = _DAT_1801d1220;
  *(double *)(param_1 + 2) = _DAT_1801d1218;
  *(double *)(param_1 + 4) = dVar8;
  dVar8 = _DAT_1801d1230;
  *(double *)(param_1 + 6) = _DAT_1801d1228;
  *(double *)(param_1 + 8) = dVar8;
  param_1[10] = DAT_1801d1200;
  param_1[0xb] = DAT_1801d1204;
  *param_1 = local_644;
  bVar9 = Detection::ClubDetection::isDetectionValid((ClubDetection *)*param_8);
  if (bVar9) {
    fVar29 = DAT_18017e95c;
    if (this[0x31d] != (Interface)0x0) {
      fVar29 = getCalibrationPPMM(this,false);
    }
    fVar29 = fVar29 * _DAT_18017ec60 * DAT_18017e97c;
    local_628 = 8.5;
    local_610[0] = 0;
    local_610[1] = 0;
    local_600._0_12_ = ZEXT812(0);
    local_600._12_4_ = 0;
    FUN_18000c1d0(local_610,
                  "Configurations.Process.Club.Detection.MaxTrackingDistanceFromBallFactor",0x47);
    bVar9 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_610);
    if (bVar9) {
      pPVar11 = Libraries::Core::Parameters::get
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_610);
      fVar30 = Libraries::Core::Parameter::toFloat(pPVar11);
    }
    else {
      pPVar11 = Libraries::Core::Parameters::get
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_610);
      Libraries::Core::Parameter::setValue(pPVar11,&local_628,3);
      pPVar11 = Libraries::Core::Parameters::get
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_610);
      fVar30 = Libraries::Core::Parameter::toFloat(pPVar11);
      saveParameters(this);
    }
    FUN_18000c8d0(local_610);
    local_657[0] = true;
    local_5f0[0] = 0;
    local_5f0[1] = 0;
    local_5f0[2] = 0;
    local_5f0[3] = 0;
    FUN_18000c1d0(local_5f0,"Configurations.Process.UseMLForClub",0x23);
    bVar9 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_5f0);
    if (bVar9) {
      pPVar11 = Libraries::Core::Parameters::get
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_5f0);
      bVar9 = Libraries::Core::Parameter::toBoolean(pPVar11);
    }
    else {
      pPVar11 = Libraries::Core::Parameters::get
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_5f0);
      Libraries::Core::Parameter::setValue(pPVar11,local_657);
      pPVar11 = Libraries::Core::Parameters::get
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_5f0);
      bVar9 = Libraries::Core::Parameter::toBoolean(pPVar11);
      saveParameters(this);
    }
    FUN_18000c8d0(local_5f0);
    if ((bVar9 == false) || (lVar17 = *param_8, *(char *)(lVar17 + 0x90) != '\0')) {
      bVar9 = false;
      cv::Mat::Mat(local_288,(Mat *)(*param_8 + 8));
      local_558 = 0;
      local_568 = 0x1010000;
      local_560 = local_288;
      uVar26 = 7;
      local_648 = 7;
      piVar12 = (int *)cv::boundingRect(local_360);
      local_620 = (float)*piVar12;
      local_61c = (float)piVar12[1];
      local_618 = (float)piVar12[2];
      local_614 = (float)piVar12[3];
      pfVar13 = &local_620;
    }
    else {
      bVar9 = true;
      local_410 = *(undefined8 *)(lVar17 + 0x70);
      uStack_408 = *(undefined8 *)(lVar17 + 0x78);
      pfVar13 = (float *)&local_410;
      uVar26 = local_648;
    }
    fVar3 = *pfVar13;
    fVar4 = pfVar13[1];
    fVar5 = pfVar13[2];
    fVar6 = pfVar13[3];
    if ((uVar26 & 2) != 0) {
      uVar26 = uVar26 & 0xfffffffd;
      local_648 = uVar26;
    }
    if ((uVar26 & 1) != 0) {
      cv::Mat::~Mat(local_288);
    }
    dStack_210 = (double)fVar6;
    local_218 = (double)fVar5;
    dStack_220 = (double)fVar4;
    uVar36 = 0;
    local_228 = (double)fVar3;
    if (!bVar9) {
      lVar17 = *param_8;
      local_340 = *(float *)(lVar17 + 0x70);
      uStack_33c = *(undefined4 *)(lVar17 + 0x74);
      uStack_338 = *(undefined4 *)(lVar17 + 0x78);
      uStack_334 = *(undefined4 *)(lVar17 + 0x7c);
      local_228 = (double)local_340 + local_228;
      local_350 = *(undefined4 *)(lVar17 + 0x70);
      fStack_34c = *(float *)(lVar17 + 0x74);
      uStack_348 = *(undefined4 *)(lVar17 + 0x78);
      uStack_344 = *(undefined4 *)(lVar17 + 0x7c);
      dStack_220 = (double)fStack_34c + dStack_220;
    }
    local_624 = (uint)(*(float *)(local_650 + 4) - fVar30 * (fVar29 + fVar29));
    local_650 = (ulonglong)local_624 << 0x20;
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
    local_b8 = 0;
    uStack_b0 = 0;
    cv::Mat::Mat((Mat *)&local_108);
    local_540 = 0;
    local_550[0] = 0x2010000;
    local_548 = &local_108;
    local_528 = 0;
    local_538[0] = 0x1010000;
    local_530 = &local_1a8;
    cv::bilateralFilter((_InputArray *)local_538,(_OutputArray *)local_550,5,DAT_18017eb80,
                        DAT_18017eb80,4);
    lVar17 = param_4[2];
    uVar14 = param_4[3];
    puVar20 = param_4;
    if (0xf < uVar14) {
      puVar20 = (undefined8 *)*param_4;
    }
    if (lVar17 == 7) {
      iVar10 = memcmp(puVar20,"Camera1",7);
      if (iVar10 != 0) {
        uVar14 = param_4[3];
        goto LAB_1800f1ca8;
      }
      if (this[0x580] == (Interface)0x0) {
        local_510 = 0;
        local_520[0] = 0x1010000;
        local_518 = &local_108;
        cv::legacy::tracking::Tracker::init
                  (*(Tracker **)(this + 0x560),(_InputArray *)local_520,(Rect_<double> *)&local_228)
        ;
        this[0x580] = (Interface)0x1;
      }
      local_4f8 = 0;
      local_508[0] = 0x1010000;
      local_500 = &local_108;
      p_Var23 = (_InputArray *)local_508;
      this_00 = *(Tracker **)(this + 0x560);
LAB_1800f1d47:
      bVar9 = cv::legacy::tracking::Tracker::update(this_00,p_Var23,(Rect_<double> *)&local_228);
      dVar8 = dStack_220;
      if (bVar9) {
        *(double *)(param_1 + 2) = local_228;
        *(double *)(param_1 + 4) = dStack_220;
        auVar32._8_8_ = dStack_210;
        auVar32._0_8_ = local_218;
        *(undefined1 (*) [16])(param_1 + 6) = auVar32;
        dVar7 = DAT_18017ea78;
        auVar2._4_8_ = uVar36;
        auVar2._0_4_ = (int)((ulonglong)local_218 >> 0x20);
        auVar35._0_8_ = auVar2._0_8_ << 0x20;
        auVar35._8_4_ = SUB84(dStack_210,0);
        auVar35._12_4_ = (int)((ulonglong)dStack_210 >> 0x20);
        dVar31 = auVar35._8_8_ * DAT_18017ea78;
        param_1[10] = (uint)(float)(local_218 * DAT_18017ea78 + local_228);
        param_1[0xb] = (uint)(float)(dVar31 + dStack_220);
        dVar31 = *param_5;
        if (((((dVar31 != _DAT_1801d1218) || (param_5[1] != _DAT_1801d1220)) ||
             (param_5[2] != _DAT_1801d1228)) || (dVar33 = param_5[3], dVar33 != _DAT_1801d1230)) &&
           (dVar33 = param_5[3], dVar33 * param_5[2] * DAT_18017eab0 < local_218 * auVar35._8_8_)) {
          plVar15 = FUN_1800014c0();
          if (0xf < (ulonglong)param_4[3]) {
            param_4 = (undefined8 *)*param_4;
          }
          pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    cv::format(local_330,
                               "[Club tracking] %s: Unable to track the club with the Median flow tracker. Area has expand more than %f. Track box area: %f, Previous track area x %f: %f, In percent: %f"
                               ,param_4,DAT_18017ebb0);
          FUN_180084c00(plVar15,pbVar16,2,'\x01');
          cv::Mat::~Mat((Mat *)&local_108);
          cv::Mat::~Mat((Mat *)&local_208);
          cv::Mat::~Mat((Mat *)&local_1a8);
          plVar15 = (longlong *)param_8[1];
          if (plVar15 == (longlong *)0x0) {
            return param_1;
          }
          LOCK();
          plVar1 = plVar15 + 1;
          lVar17 = *plVar1;
          *(int *)plVar1 = (int)*plVar1 + -1;
          UNLOCK();
          if ((int)lVar17 != 1) {
            return param_1;
          }
          (**(code **)*plVar15)(plVar15);
          LOCK();
          piVar12 = (int *)((longlong)plVar15 + 0xc);
          iVar10 = *piVar12;
          *piVar12 = *piVar12 + -1;
          UNLOCK();
          if (iVar10 != 1) {
            return param_1;
          }
          (**(code **)(*plVar15 + 8))(plVar15);
          return param_1;
        }
        if (((dVar31 != _DAT_1801d1218) || (param_5[1] != _DAT_1801d1220)) ||
           ((param_5[2] != _DAT_1801d1228 || (dVar33 != _DAT_1801d1230)))) {
          dVar33 = (double)((float)param_1[0xb] - (float)(dVar33 * dVar7 + param_5[1]));
          dVar31 = (double)((float)param_1[10] - (float)(param_5[2] * dVar7 + dVar31));
          auVar34._0_8_ = dVar31 * dVar31 + dVar33 * dVar33;
          auVar34._8_8_ = 0;
          if (auVar34._0_8_ < 0.0) {
            dVar31 = sqrt(auVar34._0_8_);
          }
          else {
            auVar32 = sqrtpd(ZEXT816(0),auVar34);
            dVar31 = auVar32._0_8_;
          }
          if (dVar31 < DAT_18017ead0) {
            plVar15 = FUN_1800014c0();
            if (0xf < (ulonglong)param_4[3]) {
              param_4 = (undefined8 *)*param_4;
            }
            pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)cv::format(local_310,
                                    "[Club tracking] %s: Unable to track the club with the Median flow tracker. Centroid has move backward. Current centroid: %f, Previous centroid: %f"
                                    ,param_4,(double)(float)param_1[0xb]);
            FUN_180084c00(plVar15,pbVar16,2,'\x01');
            cv::Mat::~Mat((Mat *)&local_108);
            cv::Mat::~Mat((Mat *)&local_208);
            cv::Mat::~Mat((Mat *)&local_1a8);
            plVar15 = (longlong *)param_8[1];
            if (plVar15 == (longlong *)0x0) {
              return param_1;
            }
            LOCK();
            plVar1 = plVar15 + 1;
            lVar17 = *plVar1;
            *(int *)plVar1 = (int)*plVar1 + -1;
            UNLOCK();
            if ((int)lVar17 != 1) {
              return param_1;
            }
            (**(code **)*plVar15)(plVar15);
            LOCK();
            piVar12 = (int *)((longlong)plVar15 + 0xc);
            iVar10 = *piVar12;
            *piVar12 = *piVar12 + -1;
            UNLOCK();
            if (iVar10 != 1) {
              return param_1;
            }
            (**(code **)(*plVar15 + 8))(plVar15);
            return param_1;
          }
        }
        uVar26 = local_624;
        if ((double)(int)local_624 <= dVar8) {
          if (this[0x300] != (Interface)0x0) {
            local_478[4] = 0;
            local_478[5] = 0;
            local_478[6] = 0;
            local_478[7] = 0;
            FUN_18000c1d0(local_478 + 4,&DAT_18016a0f8,0);
            local_478[0] = 0;
            local_478[1] = 0;
            local_478[2] = 0;
            local_478[3] = 0;
            FUN_18000c1d0(local_478,"Results",7);
            plVar15 = (longlong *)getProcessImagesPath(this,local_2d0);
            pIVar24 = this + 0x2e0;
            if (0xf < *(ulonglong *)(this + 0x2f8)) {
              pIVar24 = *(Interface **)pIVar24;
            }
            plVar15 = FUN_18000a490(plVar15,pIVar24,*(size_t *)(this + 0x2f0));
            local_400 = *plVar15;
            lStack_3f8 = plVar15[1];
            local_3f0 = plVar15[2];
            lStack_3e8 = plVar15[3];
            plVar15[3] = 0xf;
            plVar15[2] = 0;
            *(undefined1 *)plVar15 = 0;
            plVar15 = (longlong *)
                      Libraries::Core::updatePath
                                (local_2f0,
                                 (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_400);
            plVar15 = FUN_18000a490(plVar15,"club_img_detection",0x12);
            local_148 = (char ******)*plVar15;
            lStack_140 = plVar15[1];
            local_138 = plVar15[2];
            uStack_130 = plVar15[3];
            plVar15[2] = 0;
            plVar15[3] = 0xf;
            *(undefined1 *)plVar15 = 0;
            FUN_18000c8d0((longlong *)local_2f0);
            FUN_18000c8d0(&local_400);
            FUN_18000c8d0((longlong *)local_2d0);
            FUN_18000c8d0(local_478);
            FUN_18000c8d0(local_478 + 4);
            local_5d0[1] = 0;
            local_5d0[3] = 7;
            pppppppcVar25 = &local_148;
            if (0xf < uStack_130) {
              pppppppcVar25 = (char *******)local_148;
            }
            pppppppcVar21 = &local_148;
            if (0xf < uStack_130) {
              pppppppcVar21 = (char *******)local_148;
            }
            local_5d0[2] = 0;
            local_5d0[0] = 0;
            boost::filesystem::detail::path_traits::convert
                      ((char *)pppppppcVar21,(char *)((longlong)pppppppcVar25 + local_138),
                       (basic_string<wchar_t,struct_std::char_traits<wchar_t>,class_std::allocator<wchar_t>_>
                        *)local_5d0,(codecvt<wchar_t,char,struct__Mbstatet> *)0x0);
            boost::filesystem::detail::create_directories((path *)local_5d0,(error_code *)0x0);
            FUN_180025f40(local_5d0);
            iVar19 = (int)ROUND(dStack_210);
            iVar22 = (int)ROUND(local_218);
            iVar10 = (int)ROUND(dStack_220);
            if ((int)ROUND(dStack_220) < 0) {
              iVar10 = 0;
            }
            iVar28 = (int)ROUND(local_228);
            if ((int)ROUND(local_228) < 0) {
              iVar28 = 0;
            }
            if (local_168[1] < iVar22 + iVar28) {
              iVar22 = local_168[1] - iVar28;
            }
            if (*local_168 < iVar19 + iVar10) {
              iVar19 = *local_168 - iVar10;
            }
            dStack_210 = (double)iVar19;
            local_218 = (double)iVar22;
            dStack_220 = (double)iVar10;
            local_228 = (double)iVar28;
            local_3e0 = _DAT_18017eed0;
            uStack_3d8 = _UNK_18017eed8;
            local_3d0 = 0;
            uStack_3c8 = 0;
            _local_638 = CONCAT44((int)ROUND(dStack_220),(int)ROUND(local_228));
            _iStack_630 = CONCAT44((int)ROUND(dStack_210),(int)ROUND(local_218));
            local_4c8 = 0;
            local_4d8[0] = 0x3010000;
            local_4d0 = &local_208;
            cv::rectangle(local_4d8,&local_638,&local_3e0,2);
            local_3c0 = _DAT_18017f0d0;
            uStack_3b8 = _UNK_18017f0d8;
            local_3b0 = 0;
            uStack_3a8 = 0;
            local_4b0 = 0;
            local_4c0[0] = 0x3010000;
            local_4b8 = &local_208;
            cv::line(local_4c0,local_650,CONCAT44(uVar26,uStack_1a0._4_4_),&local_3c0);
            local_3a0 = _DAT_18017f0c0;
            uStack_398 = _UNK_18017f0c8;
            local_390 = 0;
            uStack_388 = 0;
            local_650 = CONCAT44((int)ROUND((float)param_1[0xb]),(int)ROUND((float)param_1[10]));
            local_498 = 0;
            local_4a8[0] = 0x3010000;
            local_4a0 = &local_208;
            cv::drawMarker(local_4a8,local_650,&local_3a0,0);
            lVar17 = __RTtypeid(*(undefined8 *)(this + 0x560));
            pvVar18 = (void *)__std_type_info_name(lVar17 + 8,&DAT_1801e9840);
            local_128 = (undefined8 *******)0x0;
            uStack_120 = 0;
            local_118 = 0;
            local_110 = 0;
            sVar27 = 0xffffffffffffffff;
            do {
              sVar27 = sVar27 + 1;
            } while (*(char *)((longlong)pvVar18 + sVar27) != '\0');
            FUN_18000c1d0(&local_128,pvVar18,sVar27);
            _Buf1 = &local_128;
            if (0xf < local_110) {
              _Buf1 = (undefined8 *******)local_128;
            }
            if ((local_118 == 0x31) &&
               (iVar10 = memcmp(_Buf1,"class cv::legacy::tracking::impl::TrackerCSRTImpl",0x31),
               iVar10 == 0)) {
              local_380 = 0;
              uStack_378 = 0;
              local_370 = _DAT_18017eed0;
              uStack_368 = _UNK_18017eed8;
              uVar26 = (int)uStack_200 - 5;
              local_478[8] = 0;
              local_478[9] = 0;
              local_478[10] = 0;
              local_478[0xb] = 0;
              FUN_18000c1d0(local_478 + 8,&DAT_180177e24,4);
              local_480 = 0;
              local_490[0] = 0x3010000;
              local_488 = &local_208;
              cv::putText(local_490,local_478 + 8,(ulonglong)uVar26 << 0x20 | 5,0);
              FUN_18000c8d0(local_478 + 8);
            }
            if (0xf < (ulonglong)param_4[3]) {
              param_4 = (undefined8 *)*param_4;
            }
            pppppppcVar25 = &local_148;
            if (0xf < uStack_130) {
              pppppppcVar25 = (char *******)local_148;
            }
            cv::format((char *)local_a8,"%s\\%s_TrackingFrame_%d.png",pppppppcVar25,param_4);
            local_598 = (void *)0x0;
            uStack_590 = 0;
            local_588 = 0;
            local_570 = 0;
            local_580[0] = 0x1010000;
            local_578 = &local_208;
            cv::imwrite(local_a8,(_InputArray *)local_580,
                        (vector<int,class_std::allocator<int>_> *)&local_598);
            if (local_598 != (void *)0x0) {
              pvVar18 = local_598;
              if ((0xfff < (ulonglong)((local_588 - (longlong)local_598 >> 2) * 4)) &&
                 (pvVar18 = *(void **)((longlong)local_598 + -8),
                 0x1f < (ulonglong)((longlong)local_598 + (-8 - (longlong)pvVar18)))) {
                    /* WARNING: Subroutine does not return */
                _invalid_parameter_noinfo_noreturn();
              }
              free(pvVar18);
            }
            FUN_18000c8d0((longlong *)local_a8);
            FUN_18000c8d0((longlong *)&local_128);
            FUN_18000c8d0((longlong *)&local_148);
          }
          *(undefined1 *)(param_1 + 1) = 1;
          cv::Mat::~Mat((Mat *)&local_108);
          cv::Mat::~Mat((Mat *)&local_208);
          cv::Mat::~Mat((Mat *)&local_1a8);
          plVar15 = (longlong *)param_8[1];
          if (plVar15 == (longlong *)0x0) {
            return param_1;
          }
          LOCK();
          plVar1 = plVar15 + 1;
          lVar17 = *plVar1;
          *(int *)plVar1 = (int)*plVar1 + -1;
          UNLOCK();
          if ((int)lVar17 != 1) {
            return param_1;
          }
          (**(code **)*plVar15)(plVar15);
          LOCK();
          piVar12 = (int *)((longlong)plVar15 + 0xc);
          iVar10 = *piVar12;
          *piVar12 = *piVar12 + -1;
          UNLOCK();
          if (iVar10 != 1) {
            return param_1;
          }
          (**(code **)(*plVar15 + 8))(plVar15);
          return param_1;
        }
        *(undefined2 *)(param_1 + 1) = 0x101;
        cv::Mat::~Mat((Mat *)&local_108);
        goto LAB_1800f20d7;
      }
    }
    else {
LAB_1800f1ca8:
      puVar20 = param_4;
      if (0xf < uVar14) {
        puVar20 = (undefined8 *)*param_4;
      }
      if ((lVar17 == 7) && (iVar10 = memcmp(puVar20,"Camera2",7), iVar10 == 0)) {
        if (this[0x581] == (Interface)0x0) {
          local_5a0 = 0;
          local_5b0[0] = 0x1010000;
          local_5a8 = &local_108;
          cv::legacy::tracking::Tracker::init
                    (*(Tracker **)(this + 0x570),(_InputArray *)local_5b0,
                     (Rect_<double> *)&local_228);
          this[0x581] = (Interface)0x1;
        }
        local_4e0 = 0;
        local_4f0[0] = 0x1010000;
        local_4e8 = &local_108;
        p_Var23 = (_InputArray *)local_4f0;
        this_00 = *(Tracker **)(this + 0x570);
        goto LAB_1800f1d47;
      }
    }
    plVar15 = FUN_1800014c0();
    pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(local_2b0,"Tracking failed detected at frame: %d.",(ulonglong)local_644);
    FUN_180084c00(plVar15,pbVar16,3,'\x01');
    cv::Mat::~Mat((Mat *)&local_108);
    cv::Mat::~Mat((Mat *)&local_208);
    cv::Mat::~Mat((Mat *)&local_1a8);
    plVar15 = (longlong *)param_8[1];
    if (plVar15 != (longlong *)0x0) {
      LOCK();
      plVar1 = plVar15 + 1;
      lVar17 = *plVar1;
      *(int *)plVar1 = (int)*plVar1 + -1;
      UNLOCK();
      if ((int)lVar17 == 1) {
        (**(code **)*plVar15)(plVar15);
        LOCK();
        piVar12 = (int *)((longlong)plVar15 + 0xc);
        iVar10 = *piVar12;
        *piVar12 = *piVar12 + -1;
        UNLOCK();
        if (iVar10 == 1) {
          (**(code **)(*plVar15 + 8))(plVar15);
        }
      }
    }
  }
  else {
LAB_1800f20d7:
    cv::Mat::~Mat((Mat *)&local_208);
    cv::Mat::~Mat((Mat *)&local_1a8);
    plVar15 = (longlong *)param_8[1];
    if (plVar15 != (longlong *)0x0) {
      LOCK();
      plVar1 = plVar15 + 1;
      lVar17 = *plVar1;
      *(int *)plVar1 = (int)*plVar1 + -1;
      UNLOCK();
      if ((int)lVar17 == 1) {
        (**(code **)*plVar15)(plVar15);
        LOCK();
        piVar12 = (int *)((longlong)plVar15 + 0xc);
        iVar10 = *piVar12;
        *piVar12 = *piVar12 + -1;
        UNLOCK();
        if (iVar10 == 1) {
          (**(code **)(*plVar15 + 8))(plVar15);
        }
      }
    }
  }
  return param_1;
}

