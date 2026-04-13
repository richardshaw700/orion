FUNCTION: GolfIn::Interface::getAngleFromVector
ENTRY: 1800e09d0
REASONS: string:Ball.Build


/* public: float __cdecl GolfIn::Interface::getAngleFromVector(class std::vector<class
   cv::Point3_<float>,class std::allocator<class cv::Point3_<float> > > const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64) __ptr64 */

float __thiscall
GolfIn::Interface::getAngleFromVector
          (Interface *this,
          vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *param_1
          ,basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2)

{
  undefined8 uVar1;
  undefined8 uVar2;
  float fVar3;
  longlong lVar4;
  undefined1 auVar5 [16];
  double dVar6;
  double dVar7;
  double dVar8;
  double dVar9;
  int iVar10;
  longlong *plVar11;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar12;
  float fVar13;
  double dVar14;
  double dVar15;
  undefined1 in_XMM3 [16];
  uint uVar16;
  uint uVar17;
  undefined1 unaff_XMM8 [16];
  undefined1 auVar18 [16];
  float local_d8;
  float fStack_d4;
  float local_c8;
  float fStack_c4;
  char local_b8 [128];
  
                    /* 0xe09d0  619
                       ?getAngleFromVector@Interface@GolfIn@@QEAAMAEBV?$vector@V?$Point3_@M@cv@@V?$allocator@V?$Point3_@M@cv@@@std@@@std@@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@4@@Z
                        */
  lVar4 = *(longlong *)(param_2 + 0x10);
  uVar1 = **(undefined8 **)param_1;
  fVar13 = *(float *)(*(undefined8 **)param_1 + 1);
  uVar2 = *(undefined8 *)(*(longlong *)(param_1 + 8) + -0xc);
  fVar3 = *(float *)(*(longlong *)(param_1 + 8) + -4);
  pbVar12 = param_2;
  if (0xf < *(ulonglong *)(param_2 + 0x18)) {
    pbVar12 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
               param_2;
  }
  local_d8 = (float)uVar2;
  local_c8 = (float)uVar1;
  if ((lVar4 == 9) && (iVar10 = memcmp(pbVar12,"ELEVATION",9), iVar10 == 0)) {
    plVar11 = FUN_1800014c0();
    pbVar12 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format(local_b8);
    FUN_180084c00(plVar11,pbVar12,0,'\x01');
    fVar13 = atan2f(fVar3 - fVar13,local_d8 - local_c8);
    return (float)(((double)fVar13 * DAT_18017ebc0) / DAT_18017eaf0);
  }
  if (0xf < *(ulonglong *)(param_2 + 0x18)) {
    param_2 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
               param_2;
  }
  if ((lVar4 == 9) && (iVar10 = memcmp(param_2,"DIRECTION",9), iVar10 == 0)) {
    fStack_c4 = (float)((ulonglong)uVar1 >> 0x20);
    fStack_d4 = (float)((ulonglong)uVar2 >> 0x20);
    dVar9 = (double)(fStack_d4 - fStack_c4);
    dVar7 = (double)(local_d8 - local_c8);
    dVar8 = (double)(fVar13 - fVar13);
    dVar15 = dVar9 * dVar9 + dVar7 * dVar7 + dVar8 * dVar8;
    if (dVar15 < 0.0) {
      dVar15 = sqrt(dVar15);
    }
    else {
      auVar18._8_8_ = 0;
      auVar18._0_8_ = dVar15;
      auVar18 = sqrtpd(unaff_XMM8,auVar18);
      dVar15 = auVar18._0_8_;
    }
    dVar6 = (double)(fStack_c4 - fStack_c4);
    dVar14 = dVar6 * dVar6 + dVar7 * dVar7 + dVar8 * dVar8;
    if (dVar14 < 0.0) {
      dVar14 = sqrt(dVar14);
    }
    else {
      auVar5._8_8_ = 0;
      auVar5._0_8_ = dVar14;
      auVar18 = sqrtpd(in_XMM3,auVar5);
      dVar14 = auVar18._0_8_;
    }
    uVar16 = SUB84(DAT_18017f130,0);
    uVar17 = (uint)((ulonglong)DAT_18017f130 >> 0x20);
    dVar15 = (double)((float)(dVar7 / dVar14) * (float)(dVar7 / dVar15) +
                      (float)(dVar6 / dVar14) * (float)(dVar9 / dVar15) +
                     (float)(dVar8 / dVar14) * (float)(dVar8 / dVar15));
    if (DAT_18017eaa0 < dVar15) {
      return (float)DAT_18017f130;
    }
    if (dVar15 < DAT_18017ed58) {
      return (float)(double)CONCAT44((uint)((ulonglong)DAT_18017ebc0 >> 0x20) ^ uVar17,
                                     SUB84(DAT_18017ebc0,0) ^ uVar16);
    }
    dVar15 = acos(dVar15);
    if (fStack_d4 < fStack_c4) {
      dVar15 = (double)CONCAT44((uint)((ulonglong)dVar15 >> 0x20) ^ uVar17,SUB84(dVar15,0) ^ uVar16)
      ;
    }
    dVar15 = (dVar15 * DAT_18017ebc0) / DAT_18017eaf0;
    return (float)(double)CONCAT44((uint)((ulonglong)dVar15 >> 0x20) ^ uVar17,
                                   SUB84(dVar15,0) ^ uVar16);
  }
  return 0.0;
}

