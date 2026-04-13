FUNCTION: GolfIn::Club::projectionPolyfit2D
ENTRY: 1800ad2f0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* private: bool __cdecl GolfIn::Club::projectionPolyfit2D(class std::vector<float,class
   std::allocator<float> > const & __ptr64,class std::vector<class cv::Point_<float>,class
   std::allocator<class cv::Point_<float> > > const & __ptr64,float const & __ptr64,class
   std::vector<float,class std::allocator<float> > & __ptr64,class std::vector<class
   cv::Point_<float>,class std::allocator<class cv::Point_<float> > > & __ptr64) __ptr64 */

bool __thiscall
GolfIn::Club::projectionPolyfit2D
          (Club *this,vector<float,class_std::allocator<float>_> *param_1,
          vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_> *param_2,
          float *param_3,vector<float,class_std::allocator<float>_> *param_4,
          vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_> *param_5)

{
  longlong lVar1;
  bool bVar2;
  float *pfVar3;
  int iVar4;
  ulonglong uVar5;
  float fVar6;
  float fVar7;
  float fVar8;
  undefined1 auStackY_98 [32];
  int local_58 [2];
  float *local_50;
  longlong lStack_48;
  longlong local_40;
  float *local_38;
  longlong lStack_30;
  longlong local_28;
  ulonglong local_20;
  
                    /* 0xad2f0  879
                       ?projectionPolyfit2D@Club@GolfIn@@AEAA_NAEBV?$vector@MV?$allocator@M@std@@@std@@AEBV?$vector@V?$Point_@M@cv@@V?$allocator@V?$Point_@M@cv@@@std@@@4@AEBMAEAV34@AEAV54@@Z
                        */
  local_20 = DAT_1801d1040 ^ (ulonglong)auStackY_98;
  local_38 = (float *)0x0;
  lStack_30 = 0;
  local_28 = 0;
  local_50 = (float *)0x0;
  lStack_48 = 0;
  local_40 = 0;
  local_58[0] = 2;
  bVar2 = Libraries::Core::polyFitTrajectory
                    (param_1,param_2,local_58,
                     (vector<float,class_std::allocator<float>_> *)&local_38,
                     (vector<float,class_std::allocator<float>_> *)&local_50);
  if (bVar2) {
    lVar1 = *(longlong *)param_5;
    fVar7 = 0.0;
    fVar8 = 0.0;
    iVar4 = 0;
    uVar5 = lStack_48 - (longlong)local_50 >> 2;
    if (uVar5 != 0) {
      pfVar3 = local_50;
      fVar6 = DAT_18017e9d8;
      do {
        fVar8 = fVar8 + fVar6 * *pfVar3;
        fVar6 = fVar6 * *(float *)(*(longlong *)param_4 + 4);
        iVar4 = iVar4 + 1;
        pfVar3 = pfVar3 + 1;
      } while ((ulonglong)(longlong)iVar4 < uVar5);
    }
    iVar4 = 0;
    uVar5 = lStack_30 - (longlong)local_38 >> 2;
    if (uVar5 != 0) {
      pfVar3 = local_38;
      fVar6 = DAT_18017e9d8;
      do {
        fVar7 = fVar7 + fVar6 * *pfVar3;
        fVar6 = fVar6 * *(float *)(*(longlong *)param_4 + 4);
        iVar4 = iVar4 + 1;
        pfVar3 = pfVar3 + 1;
      } while ((ulonglong)(longlong)iVar4 < uVar5);
    }
    *(float *)(lVar1 + 8) = fVar7;
    *(float *)(lVar1 + 0xc) = fVar8;
    bVar2 = Libraries::Core::polyFitFindPoint
                      ((vector<float,class_std::allocator<float>_> *)&local_38,
                       (vector<float,class_std::allocator<float>_> *)&local_50,
                       *(float **)param_4 + 1,*(Point_<float> **)param_5 + 8,param_3,
                       *(float **)param_4,*(Point_<float> **)param_5);
    if (bVar2) {
      bVar2 = true;
      goto LAB_1800ad43d;
    }
  }
  bVar2 = false;
LAB_1800ad43d:
  if (local_50 != (float *)0x0) {
    pfVar3 = local_50;
    if ((0xfff < (ulonglong)((local_40 - (longlong)local_50 >> 2) * 4)) &&
       (pfVar3 = *(float **)(local_50 + -2),
       0x1f < (ulonglong)((longlong)local_50 + (-8 - (longlong)pfVar3)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar3);
    local_50 = (float *)0x0;
    lStack_48 = 0;
    local_40 = 0;
  }
  if (local_38 != (float *)0x0) {
    pfVar3 = local_38;
    if ((0xfff < (local_28 - (longlong)local_38 & 0xfffffffffffffffcU)) &&
       (pfVar3 = *(float **)(local_38 + -2),
       0x1f < (ulonglong)((longlong)local_38 + (-8 - (longlong)pfVar3)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar3);
  }
  return bVar2;
}

