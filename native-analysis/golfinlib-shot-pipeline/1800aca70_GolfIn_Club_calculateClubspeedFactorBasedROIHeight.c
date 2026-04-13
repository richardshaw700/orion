FUNCTION: GolfIn::Club::calculateClubspeedFactorBasedROIHeight
ENTRY: 1800aca70
REASONS: name:club


/* public: double __cdecl GolfIn::Club::calculateClubspeedFactorBasedROIHeight(double,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class cv::Point_<float> const & __ptr64) __ptr64 */

double __thiscall
GolfIn::Club::calculateClubspeedFactorBasedROIHeight
          (Club *this,double param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          Point_<float> *param_3)

{
  Parameters *pPVar1;
  bool bVar2;
  bool bVar3;
  Interface *pIVar4;
  longlong *plVar5;
  Parameter *pPVar6;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar7;
  longlong lVar8;
  undefined8 in_RDX;
  uint uVar9;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar10;
  undefined8 uVar11;
  double dVar12;
  double dVar13;
  undefined8 local_d8;
  longlong local_d0;
  longlong lStack_c8;
  longlong local_c0;
  longlong lStack_b8;
  longlong local_b0;
  longlong lStack_a8;
  longlong local_a0;
  longlong lStack_98;
  Size_<int> local_90 [32];
  Size_<int> local_70 [32];
  Interface *local_50;
  
                    /* 0xaca70  430
                       ?calculateClubspeedFactorBasedROIHeight@Club@GolfIn@@QEAANNAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$Point_@M@cv@@@Z
                        */
  local_d8 = (Interface *)((ulonglong)local_d8 & 0xffffffff00000000);
  pbVar10 = param_2;
  dVar12 = floor(param_1);
  if (Interface::instance_ == (Interface *)0x0) {
    pIVar4 = (Interface *)FUN_1801327e0(0x908);
    in_RDX = 0;
    pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x908;
    local_d8 = pIVar4;
    memset(pIVar4,0,0x908);
    Interface::instance_ = (Interface *)Interface::Interface(pIVar4);
  }
  pPVar1 = (Parameters *)(Interface::instance_ + 0x10);
  if (0x7fffffffffffffff - *(size_t *)(param_2 + 0x10) < 0x1e) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  pbVar7 = param_2;
  if (0xf < *(ulonglong *)(param_2 + 0x18)) {
    pbVar7 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
              param_2;
  }
  FUN_18000bff0((undefined8 *)local_70,in_RDX,pbVar10,"Configurations.Process.Player.",0x1e,pbVar7,
                *(size_t *)(param_2 + 0x10));
  uVar11 = 0x1c;
  plVar5 = FUN_18000a490((longlong *)local_70,"ClubSpeedTopCorrectionFactor",0x1c);
  local_b0 = *plVar5;
  lStack_a8 = plVar5[1];
  local_a0 = plVar5[2];
  lStack_98 = plVar5[3];
  plVar5[2] = 0;
  plVar5[3] = 0xf;
  *(undefined1 *)plVar5 = 0;
  uVar9 = 0x30;
  pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            &local_b0;
  pPVar6 = Libraries::Core::Parameters::find(pPVar1,pbVar10);
  if (pPVar6 == (Parameter *)0x0) {
    dVar12 = (param_1 - dVar12) + param_1;
  }
  else {
    if (Interface::instance_ == (Interface *)0x0) {
      pIVar4 = (Interface *)FUN_1801327e0(0x908);
      pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0;
      uVar11 = 0x908;
      local_d8 = pIVar4;
      memset(pIVar4,0,0x908);
      Interface::instance_ = (Interface *)Interface::Interface(pIVar4);
    }
    pPVar1 = (Parameters *)(Interface::instance_ + 0x10);
    if (0x7fffffffffffffff - *(size_t *)(param_2 + 0x10) < 0x1e) {
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    pbVar7 = param_2;
    if (0xf < *(ulonglong *)(param_2 + 0x18)) {
      pbVar7 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                param_2;
    }
    FUN_18000bff0((undefined8 *)local_90,pbVar10,uVar11,"Configurations.Process.Player.",0x1e,pbVar7
                  ,*(size_t *)(param_2 + 0x10));
    local_d8._0_4_ = 0x131;
    uVar11 = 0x1c;
    plVar5 = FUN_18000a490((longlong *)local_90,"ClubSpeedTopCorrectionFactor",0x1c);
    local_d0 = *plVar5;
    lStack_c8 = plVar5[1];
    local_c0 = plVar5[2];
    lStack_b8 = plVar5[3];
    plVar5[2] = 0;
    plVar5[3] = 0xf;
    *(undefined1 *)plVar5 = 0;
    uVar9 = 0x333;
    local_d8 = (Interface *)CONCAT44(local_d8._4_4_,0x333);
    pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_d0;
    pPVar6 = Libraries::Core::Parameters::get(pPVar1,pbVar10);
    dVar12 = Libraries::Core::Parameter::toDouble(pPVar6);
  }
  if ((uVar9 & 2) != 0) {
    uVar9 = uVar9 & 0xfffffffd;
    FUN_18000c8d0(&local_d0);
  }
  if ((uVar9 & 1) != 0) {
    uVar9 = uVar9 & 0xfffffffe;
    FUN_18000c8d0((longlong *)local_90);
  }
  FUN_18000c8d0(&local_b0);
  FUN_18000c8d0((longlong *)local_70);
  if (Interface::instance_ == (Interface *)0x0) {
    pIVar4 = (Interface *)FUN_1801327e0(0x908);
    pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0;
    uVar11 = 0x908;
    local_d8 = pIVar4;
    memset(pIVar4,0,0x908);
    Interface::instance_ = (Interface *)Interface::Interface(pIVar4);
  }
  pPVar1 = (Parameters *)(Interface::instance_ + 0x10);
  if (0x1d < 0x7fffffffffffffff - *(size_t *)(param_2 + 0x10)) {
    pbVar7 = param_2;
    if (0xf < *(ulonglong *)(param_2 + 0x18)) {
      pbVar7 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                param_2;
    }
    FUN_18000bff0((undefined8 *)local_90,pbVar10,uVar11,"Configurations.Process.Player.",0x1e,pbVar7
                  ,*(size_t *)(param_2 + 0x10));
    uVar11 = 0x1f;
    plVar5 = FUN_18000a490((longlong *)local_90,"ClubSpeedBottomCorrectionFactor",0x1f);
    local_b0 = *plVar5;
    lStack_a8 = plVar5[1];
    local_a0 = plVar5[2];
    lStack_98 = plVar5[3];
    plVar5[2] = 0;
    plVar5[3] = 0xf;
    *(undefined1 *)plVar5 = 0;
    bVar2 = false;
    bVar3 = false;
    pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_b0;
    pPVar6 = Libraries::Core::Parameters::find(pPVar1,pbVar10);
    if (pPVar6 != (Parameter *)0x0) {
      if (Interface::instance_ == (Interface *)0x0) {
        pIVar4 = (Interface *)FUN_1801327e0(0x908);
        pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  0x0;
        uVar11 = 0x908;
        local_d8 = pIVar4;
        memset(pIVar4,0,0x908);
        Interface::instance_ = (Interface *)Interface::Interface(pIVar4);
      }
      pPVar1 = (Parameters *)(Interface::instance_ + 0x10);
      pbVar7 = param_2 + 0x10;
      if (0x7fffffffffffffff - *(size_t *)pbVar7 < 0x1e) {
                    /* WARNING: Subroutine does not return */
        FUN_18000c940();
      }
      if (0xf < *(ulonglong *)(param_2 + 0x18)) {
        param_2 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                   param_2;
      }
      FUN_18000bff0((undefined8 *)local_70,pbVar10,uVar11,"Configurations.Process.Player.",0x1e,
                    param_2,*(size_t *)pbVar7);
      local_d8 = (Interface *)(CONCAT44(local_d8._4_4_,uVar9) | 0x4c4);
      plVar5 = FUN_18000a490((longlong *)local_70,"ClubSpeedBottomCorrectionFactor",0x1f);
      local_d0 = *plVar5;
      lStack_c8 = plVar5[1];
      local_c0 = plVar5[2];
      lStack_b8 = plVar5[3];
      plVar5[2] = 0;
      plVar5[3] = 0xf;
      *(undefined1 *)plVar5 = 0;
      bVar2 = true;
      bVar3 = true;
      local_d8 = (Interface *)(CONCAT44(local_d8._4_4_,uVar9) | 0xccc);
      pPVar6 = Libraries::Core::Parameters::get
                         (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_d0);
      Libraries::Core::Parameter::toDouble(pPVar6);
    }
    if (bVar3) {
      FUN_18000c8d0(&local_d0);
    }
    if (bVar2) {
      FUN_18000c8d0((longlong *)local_70);
    }
    FUN_18000c8d0(&local_b0);
    FUN_18000c8d0((longlong *)local_90);
    local_d8 = (Interface *)0x2d00000021c;
    if (Interface::instance_ == (Interface *)0x0) {
      pIVar4 = (Interface *)FUN_1801327e0(0x908);
      local_50 = pIVar4;
      memset(pIVar4,0,0x908);
      Interface::instance_ = (Interface *)Interface::Interface(pIVar4);
    }
    pIVar4 = Interface::instance_;
    bVar3 = Interface::useDynamicConfig(Interface::instance_);
    if (bVar3) {
      Interface::getCaptureRegionDynamic(pIVar4,local_70,(Point_<float> *)&local_d8);
    }
    else {
      Interface::getCaptureRegion(pIVar4,local_90,(Point_<float> *)&local_d8);
    }
    bVar3 = Interface::useDynamicConfig(pIVar4);
    if (bVar3) {
      lVar8 = Interface::getCaptureRegionDynamic(pIVar4,local_70,(Point_<float> *)&local_d8);
    }
    else {
      lVar8 = Interface::getCaptureRegion(pIVar4,local_90,(Point_<float> *)&local_d8);
    }
    dVar13 = (double)*(int *)(lVar8 + 0x1c) * DAT_18017ea78;
    dVar12 = (param_1 - dVar12) / (dVar13 - 0.0);
    return (double)(*(float *)(param_3 + 4) - (float)*(int *)(lVar8 + 0x14)) * dVar12 +
           (param_1 - dVar13 * dVar12);
  }
                    /* WARNING: Subroutine does not return */
  FUN_18000c940();
}

