FUNCTION: GolfIn::Interface::findBall_geometric
ENTRY: 1800f06b0
REASONS: string:waitForShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: void __cdecl GolfIn::Interface::findBall_geometric(class cv::Mat const & __ptr64,class
   cv::Rect_<int> const & __ptr64,class cv::Point3_<float> const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >
   const & __ptr64,int,float,float,class cv::Point3_<float> & __ptr64,int & __ptr64) __ptr64 */

void __thiscall
GolfIn::Interface::findBall_geometric
          (Interface *this,Mat *param_1,Rect_<int> *param_2,Point3_<float> *param_3,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_4,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_5,
          int param_6,float param_7,float param_8,Point3_<float> *param_9,int *param_10)

{
  Interface IVar1;
  ulonglong uVar2;
  bool bVar3;
  bool bVar4;
  Point3_<float> *pPVar5;
  int *piVar6;
  float fVar7;
  longlong lVar8;
  bool bVar9;
  bool bVar10;
  int iVar11;
  double *pdVar12;
  Parameter *pPVar13;
  longlong *plVar14;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *_Buf1;
  Interface *pIVar15;
  float fVar16;
  longlong lVar17;
  float fVar18;
  float fVar19;
  float fVar20;
  float fVar21;
  float fVar22;
  undefined1 auStackY_338 [32];
  bool local_2f8 [8];
  longlong local_2f0;
  Mat *pMStack_2e8;
  undefined8 local_2e0;
  undefined8 uStack_2d8;
  undefined8 local_2d0;
  undefined8 uStack_2c8;
  undefined8 local_2c0;
  undefined8 uStack_2b8;
  longlong *local_2b0;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbStack_2a8;
  int *local_2a0;
  longlong lStack_298;
  _InputArray local_290 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_270 [40];
  Mat local_248 [96];
  float local_1e8 [4];
  undefined8 local_1d8;
  float local_1d0;
  longlong local_1c8;
  longlong lStack_1c0;
  longlong local_1b8;
  longlong lStack_1b0;
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
  longlong local_148;
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
  ulonglong local_c8;
  
  piVar6 = param_10;
  pPVar5 = param_9;
                    /* 0xf06b0  595
                       ?findBall_geometric@Interface@GolfIn@@IEAAXAEBVMat@cv@@AEBV?$Rect_@H@4@AEBV?$Point3_@M@4@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@3HMMAEAV64@AEAH@Z
                        */
  local_c8 = DAT_1801d1040 ^ (ulonglong)auStackY_338;
  local_128 = 0;
  uStack_120 = 0;
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
  cv::Mat::Mat((Mat *)&local_128,param_1,param_2);
  lVar17 = CONCAT44(DAT_1801d120c,DAT_1801d1208);
  if (((*(float *)param_3 != DAT_1801d1208) || (*(float *)(param_3 + 4) != DAT_1801d120c)) ||
     (local_2d0 = lVar17, local_1d0 = DAT_1801d1210, *(float *)(param_3 + 8) != DAT_1801d1210)) {
    local_1d0 = *(float *)(param_3 + 8);
    local_2d0 = CONCAT44(*(float *)(param_3 + 4) - (float)*(int *)(param_2 + 4),
                         *(float *)param_3 - (float)*(int *)param_2);
  }
  uStack_2c8 = CONCAT44(uStack_2c8._4_4_,local_1d0);
  local_1d8 = local_2d0;
  lVar8 = local_1d8;
  fVar18 = local_1d0;
  if (local_1d0 <= 0.0) {
    fVar18 = param_8;
  }
  local_1d8._0_4_ = (float)local_2d0;
  local_1d8 = lVar8;
  if ((DAT_18017ed34 < (float)local_1d8) &&
     (local_1d8._4_4_ = (float)((ulonglong)local_2d0 >> 0x20), DAT_18017ed34 < local_1d8._4_4_)) {
    bVar4 = true;
    bVar9 = fVar18 <= (float)local_1d8;
    bVar10 = (float)local_1d8 <= (float)*(int *)(param_2 + 8) - fVar18;
    bVar3 = local_1d8._4_4_ <= (float)*(int *)(param_2 + 0xc) - fVar18;
    if ((bVar9) && ((bVar10 && (bVar3)))) goto LAB_1800f0880;
LAB_1800f0925:
    *(longlong *)pPVar5 = lVar17;
    *(float *)(pPVar5 + 8) = DAT_1801d1210;
    goto LAB_1800f0f5f;
  }
  bVar4 = false;
LAB_1800f0880:
  local_1e8[0] = 0.0;
  local_1e8[1] = 0.0;
  local_1e8[2] = 0.0;
  bVar9 = find_circle_ransac(this,(Mat *)&local_128,(Point3_<float> *)&local_1d8,param_7,param_8,
                             *piVar6,(Vec<float,3> *)local_1e8);
  fVar7 = local_1e8[2];
  if (bVar9) {
    fVar22 = (float)*(int *)(param_2 + 4) + local_1e8[1];
    fVar21 = (float)*(int *)param_2 + local_1e8[0];
    if (bVar4) {
      fVar16 = DAT_18017e9d8;
      if (0.0 < fVar18) {
        fVar16 = local_1e8[2] / fVar18;
      }
      if (DAT_18017ea00 < fVar16) {
        lVar17 = CONCAT44(DAT_1801d120c,DAT_1801d1208);
        goto LAB_1800f0925;
      }
    }
    bVar10 = true;
    fVar20 = local_1e8[2] + local_1e8[2];
    fVar18 = local_1e8[2] * DAT_18017eac8;
    fVar19 = local_1e8[1] - local_1e8[2];
    fVar16 = local_1e8[0] - local_1e8[2];
    if (fVar16 < 0.0) {
      fVar18 = fVar16 + fVar18;
      fVar16 = 0.0;
    }
    if ((float)uStack_120._4_4_ < fVar16 + fVar18) {
      fVar18 = (float)uStack_120._4_4_ - fVar16;
    }
    bVar3 = true;
    if (((fVar18 <= 0.0) || (fVar19 < 0.0)) || ((float)(int)uStack_120 < fVar20 + fVar19)) {
      bVar3 = false;
    }
    if (bVar3) {
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
      cv::Mat::Mat((Mat *)&local_1a8);
      local_2a0 = (int *)0x0;
      local_2b0 = (longlong *)CONCAT44(local_2b0._4_4_,0x2010000);
      pbStack_2a8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    &local_1a8;
      local_2d0 = CONCAT44((int)ROUND(fVar19),(int)ROUND(fVar16));
      uStack_2c8 = CONCAT44((int)ROUND(fVar20),(int)ROUND(fVar18));
      cv::Mat::Mat(local_248,(Mat *)&local_128,(Rect_<int> *)&local_2d0);
      local_2e0 = 0;
      local_2f0._0_4_ = 0x1010000;
      pMStack_2e8 = local_248;
      cv::cvtColor((_InputArray *)&local_2f0,(_OutputArray *)&local_2b0,6,0);
      cv::Mat::~Mat(local_248);
      cv::noArray();
      local_2e0 = 0;
      local_2f0 = CONCAT44(local_2f0._4_4_,0x1010000);
      pMStack_2e8 = (Mat *)&local_1a8;
      pdVar12 = (double *)cv::mean(local_290,(_InputArray *)&local_2f0);
      if ((*piVar6 < 1) || ((float)*piVar6 * DAT_18017e980 <= (float)(int)*pdVar12)) {
        *piVar6 = (int)*pdVar12;
      }
      else {
        bVar10 = false;
      }
      cv::Mat::~Mat((Mat *)&local_1a8);
    }
    if (((bVar4) && (local_1e8[1] - local_1d8._4_4_ < DAT_18017ed68)) || (!bVar10)) {
      *piVar6 = 0;
      goto LAB_1800f0b30;
    }
    *(ulonglong *)pPVar5 = CONCAT44(fVar22,fVar21);
    *(float *)(pPVar5 + 8) = fVar7;
  }
  else {
LAB_1800f0b30:
    *(ulonglong *)pPVar5 = CONCAT44(DAT_1801d120c,DAT_1801d1208);
    *(float *)(pPVar5 + 8) = DAT_1801d1210;
  }
  IVar1 = this[0x300];
  local_2f8[0] = false;
  local_2f0 = 0;
  pMStack_2e8 = (Mat *)0x0;
  local_2e0 = 0;
  uStack_2d8 = 0;
  FUN_18000c1d0(&local_2f0,"Configurations.Debug.AutoSaveBall",0x21);
  bVar10 = Libraries::Core::Parameters::exist
                     ((Parameters *)(this + 0x10),
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_2f0);
  if (bVar10) {
    pPVar13 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_2f0);
    bVar10 = Libraries::Core::Parameter::toBoolean(pPVar13);
  }
  else {
    pPVar13 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_2f0);
    Libraries::Core::Parameter::setValue(pPVar13,local_2f8);
    pPVar13 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_2f0);
    bVar10 = Libraries::Core::Parameter::toBoolean(pPVar13);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2f0);
  if ((bVar9) && (((byte)IVar1 & bVar10) != 0)) {
    lVar17 = *(longlong *)(param_4 + 0x10);
    uVar2 = *(ulonglong *)(param_4 + 0x18);
    _Buf1 = param_4;
    if (0xf < uVar2) {
      _Buf1 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
               param_4;
    }
    if ((lVar17 != 0xb) || (iVar11 = memcmp(_Buf1,"waitForShot",0xb), iVar11 != 0)) {
      if (0xf < uVar2) {
        param_4 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                   param_4;
      }
      if ((lVar17 != 9) || (iVar11 = memcmp(param_4,"drawGreen",9), iVar11 != 0)) {
        bVar9 = *(float *)pPVar5 <= DAT_18017ed38;
        if (*(float *)pPVar5 <= DAT_18017ed38) {
          local_1c8 = 0;
          lStack_1c0 = 0;
          local_1b8 = _DAT_18017eed0;
          lStack_1b0 = _UNK_18017eed8;
        }
        else {
          local_1c8 = _DAT_18017f0c0;
          lStack_1c0 = _UNK_18017f0c8;
          local_1b8 = 0;
          lStack_1b0 = 0;
        }
        local_2d0 = 0;
        uStack_2c8 = 0;
        local_2c0 = 0;
        uStack_2b8 = 0;
        local_148 = local_1c8;
        uStack_140 = lStack_1c0;
        local_138 = local_1b8;
        uStack_130 = lStack_1b0;
        FUN_18000c1d0(&local_2d0,&DAT_18016a0f8,0);
        local_2f0 = 0;
        pMStack_2e8 = (Mat *)0x0;
        local_2e0 = 0;
        uStack_2d8 = 0;
        FUN_18000c1d0(&local_2f0,"Results",7);
        plVar14 = (longlong *)
                  getProcessImagesPath
                            (this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                   *)local_290);
        pIVar15 = this + 0x2e0;
        if (0xf < *(ulonglong *)(this + 0x2f8)) {
          pIVar15 = *(Interface **)pIVar15;
        }
        plVar14 = FUN_18000a490(plVar14,pIVar15,*(size_t *)(this + 0x2f0));
        local_2b0 = (longlong *)*plVar14;
        pbStack_2a8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)plVar14[1];
        local_2a0 = (int *)plVar14[2];
        lStack_298 = plVar14[3];
        plVar14[3] = 0xf;
        plVar14[2] = 0;
        *(undefined1 *)plVar14 = 0;
        plVar14 = (longlong *)
                  Libraries::Core::updatePath
                            (local_270,
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)&local_2b0);
        plVar14 = FUN_18000a490(plVar14,"ball_img_detection\\",0x13);
        local_1c8 = *plVar14;
        lStack_1c0 = plVar14[1];
        local_1b8 = plVar14[2];
        lStack_1b0 = plVar14[3];
        plVar14[2] = 0;
        plVar14[3] = 0xf;
        *(undefined1 *)plVar14 = 0;
        FUN_18000c8d0((longlong *)local_270);
        FUN_18000c8d0((longlong *)&local_2b0);
        FUN_18000c8d0((longlong *)local_290);
        FUN_18000c8d0(&local_2f0);
        FUN_18000c8d0(&local_2d0);
        local_2b0 = &local_1c8;
        pbStack_2a8 = param_5;
        local_2a0 = &param_6;
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
        cv::Mat::clone((Mat *)&local_128);
        fVar7 = local_1e8[1];
        fVar18 = local_1e8[0];
        local_2d0 = CONCAT44((int)ROUND(local_1e8[1]),(int)ROUND(local_1e8[0]));
        local_2e0 = 0;
        local_2f0._0_4_ = 0x3010000;
        pMStack_2e8 = (Mat *)&local_1a8;
        cv::circle(&local_2f0,local_2d0,(int)local_1e8[2],&local_148);
        local_2d0 = CONCAT44((int)ROUND(fVar7),(int)ROUND(fVar18));
        local_2e0 = 0;
        local_2f0 = CONCAT44(local_2f0._4_4_,0x3010000);
        pMStack_2e8 = (Mat *)&local_1a8;
        cv::drawMarker(&local_2f0,local_2d0,&local_148,bVar9);
        local_2f0 = 0;
        pMStack_2e8 = (Mat *)0x0;
        local_2e0 = 0;
        uStack_2d8 = 0;
        FUN_18000c1d0(&local_2f0,&DAT_18016a0f8,0);
        FUN_1800f0fc0((longlong *)&local_2b0,&local_1a8,&local_2f0);
        FUN_18000c8d0(&local_2f0);
        cv::Mat::~Mat((Mat *)&local_1a8);
        FUN_18000c8d0(&local_1c8);
      }
    }
  }
LAB_1800f0f5f:
  cv::Mat::~Mat((Mat *)&local_128);
  return;
}

