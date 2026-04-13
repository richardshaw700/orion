FUNCTION: GolfIn::Club::projectionPolyfit
ENTRY: 1800ad010
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* private: bool __cdecl GolfIn::Club::projectionPolyfit(class std::vector<float,class
   std::allocator<float> > const & __ptr64,class std::vector<class cv::Point3_<float>,class
   std::allocator<class cv::Point3_<float> > > const & __ptr64,float const & __ptr64,class
   std::vector<float,class std::allocator<float> > & __ptr64,class std::vector<class
   cv::Point3_<float>,class std::allocator<class cv::Point3_<float> > > & __ptr64) __ptr64 */

bool __thiscall
GolfIn::Club::projectionPolyfit
          (Club *this,vector<float,class_std::allocator<float>_> *param_1,
          vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *param_2
          ,float *param_3,vector<float,class_std::allocator<float>_> *param_4,
          vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *param_5
          )

{
  longlong lVar1;
  longlong lVar2;
  bool bVar3;
  float *pfVar4;
  int iVar5;
  int iVar6;
  ulonglong uVar7;
  float fVar8;
  float fVar9;
  float fVar10;
  float fVar11;
  undefined1 auStackY_c8 [32];
  int local_88 [2];
  float *local_80;
  longlong lStack_78;
  longlong local_70;
  float *local_68;
  longlong lStack_60;
  longlong local_58;
  float *local_50;
  longlong lStack_48;
  longlong local_40;
  ulonglong local_38;
  
                    /* 0xad010  880
                       ?projectionPolyfit@Club@GolfIn@@AEAA_NAEBV?$vector@MV?$allocator@M@std@@@std@@AEBV?$vector@V?$Point3_@M@cv@@V?$allocator@V?$Point3_@M@cv@@@std@@@4@AEBMAEAV34@AEAV54@@Z
                        */
  local_38 = DAT_1801d1040 ^ (ulonglong)auStackY_c8;
  local_50 = (float *)0x0;
  lStack_48 = 0;
  iVar6 = 0;
  local_40 = 0;
  local_68 = (float *)0x0;
  lStack_60 = 0;
  local_58 = 0;
  local_80 = (float *)0x0;
  lStack_78 = 0;
  local_70 = 0;
  local_88[0] = 2;
  bVar3 = Libraries::Core::polyFit
                    (param_1,param_2,local_88,
                     (vector<float,class_std::allocator<float>_> *)&local_50,
                     (vector<float,class_std::allocator<float>_> *)&local_68,
                     (vector<float,class_std::allocator<float>_> *)&local_80);
  if (bVar3) {
    lVar1 = *(longlong *)param_5;
    lVar2 = *(longlong *)param_4;
    fVar10 = 0.0;
    fVar11 = 0.0;
    uVar7 = lStack_78 - (longlong)local_80 >> 2;
    if (uVar7 != 0) {
      pfVar4 = local_80;
      fVar8 = DAT_18017e9d8;
      iVar5 = iVar6;
      do {
        fVar11 = fVar11 + fVar8 * *pfVar4;
        fVar8 = fVar8 * *(float *)(lVar2 + 4);
        iVar5 = iVar5 + 1;
        pfVar4 = pfVar4 + 1;
      } while ((ulonglong)(longlong)iVar5 < uVar7);
    }
    fVar8 = 0.0;
    uVar7 = lStack_60 - (longlong)local_68 >> 2;
    if (uVar7 != 0) {
      pfVar4 = local_68;
      fVar9 = DAT_18017e9d8;
      iVar5 = iVar6;
      do {
        fVar8 = fVar8 + fVar9 * *pfVar4;
        fVar9 = fVar9 * *(float *)(lVar2 + 4);
        iVar5 = iVar5 + 1;
        pfVar4 = pfVar4 + 1;
      } while ((ulonglong)(longlong)iVar5 < uVar7);
    }
    uVar7 = lStack_48 - (longlong)local_50 >> 2;
    if (uVar7 != 0) {
      pfVar4 = local_50;
      fVar9 = DAT_18017e9d8;
      do {
        fVar10 = fVar10 + fVar9 * *pfVar4;
        fVar9 = fVar9 * *(float *)(lVar2 + 4);
        iVar6 = iVar6 + 1;
        pfVar4 = pfVar4 + 1;
      } while ((ulonglong)(longlong)iVar6 < uVar7);
    }
    *(float *)(lVar1 + 0xc) = fVar10;
    *(float *)(lVar1 + 0x10) = fVar8;
    *(float *)(lVar1 + 0x14) = fVar11;
    bVar3 = Libraries::Core::polyFitFindPoint
                      ((vector<float,class_std::allocator<float>_> *)&local_50,
                       (vector<float,class_std::allocator<float>_> *)&local_68,
                       (vector<float,class_std::allocator<float>_> *)&local_80,
                       *(float **)param_4 + 1,*(Point3_<float> **)param_5 + 0xc,param_3,
                       *(float **)param_4,*(Point3_<float> **)param_5);
    if (bVar3) {
      bVar3 = true;
      goto LAB_1800ad1cc;
    }
  }
  bVar3 = false;
LAB_1800ad1cc:
  if (local_80 != (float *)0x0) {
    pfVar4 = local_80;
    if ((0xfff < (ulonglong)((local_70 - (longlong)local_80 >> 2) * 4)) &&
       (pfVar4 = *(float **)(local_80 + -2),
       0x1f < (ulonglong)((longlong)local_80 + (-8 - (longlong)pfVar4)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar4);
    local_80 = (float *)0x0;
    lStack_78 = 0;
    local_70 = 0;
  }
  if (local_68 != (float *)0x0) {
    pfVar4 = local_68;
    if ((0xfff < (ulonglong)((local_58 - (longlong)local_68 >> 2) * 4)) &&
       (pfVar4 = *(float **)(local_68 + -2),
       0x1f < (ulonglong)((longlong)local_68 + (-8 - (longlong)pfVar4)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar4);
    local_68 = (float *)0x0;
    lStack_60 = 0;
    local_58 = 0;
  }
  if (local_50 != (float *)0x0) {
    pfVar4 = local_50;
    if ((0xfff < (local_40 - (longlong)local_50 & 0xfffffffffffffffcU)) &&
       (pfVar4 = *(float **)(local_50 + -2),
       0x1f < (ulonglong)((longlong)local_50 + (-8 - (longlong)pfVar4)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar4);
  }
  return bVar3;
}

