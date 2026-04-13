FUNCTION: GolfIn::Club::projection
ENTRY: 1800ad500
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* private: bool __cdecl GolfIn::Club::projection(class std::vector<float,class
   std::allocator<float> > const & __ptr64,class std::vector<class cv::Point3_<float>,class
   std::allocator<class cv::Point3_<float> > > const & __ptr64,float const & __ptr64,class
   std::vector<float,class std::allocator<float> > & __ptr64,class std::vector<class
   cv::Point3_<float>,class std::allocator<class cv::Point3_<float> > > & __ptr64) __ptr64 */

bool __thiscall
GolfIn::Club::projection
          (Club *this,vector<float,class_std::allocator<float>_> *param_1,
          vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *param_2
          ,float *param_3,vector<float,class_std::allocator<float>_> *param_4,
          vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_> *param_5
          )

{
  Point3_<float> *pPVar1;
  bool bVar2;
  float *pfVar3;
  undefined1 auStackY_a8 [32];
  float *local_68;
  undefined8 uStack_60;
  longlong local_58;
  float *local_50;
  undefined8 uStack_48;
  longlong local_40;
  float *local_38;
  undefined8 uStack_30;
  longlong local_28;
  ulonglong local_20;
  
                    /* 0xad500  878
                       ?projection@Club@GolfIn@@AEAA_NAEBV?$vector@MV?$allocator@M@std@@@std@@AEBV?$vector@V?$Point3_@M@cv@@V?$allocator@V?$Point3_@M@cv@@@std@@@4@AEBMAEAV34@AEAV54@@Z
                        */
  local_20 = DAT_1801d1040 ^ (ulonglong)auStackY_a8;
  local_38 = (float *)0x0;
  uStack_30 = 0;
  local_28 = 0;
  local_50 = (float *)0x0;
  uStack_48 = 0;
  local_40 = 0;
  local_68 = (float *)0x0;
  uStack_60 = 0;
  local_58 = 0;
  bVar2 = Libraries::Core::lineFit
                    (param_1,param_2,(vector<float,class_std::allocator<float>_> *)&local_38,
                     (vector<float,class_std::allocator<float>_> *)&local_50,
                     (vector<float,class_std::allocator<float>_> *)&local_68);
  if (bVar2) {
    pPVar1 = *(Point3_<float> **)param_5;
    pfVar3 = *(float **)param_4;
    *(float *)(pPVar1 + 0xc) = pfVar3[1] * *local_38 + local_38[1];
    *(float *)(pPVar1 + 0x10) = pfVar3[1] * *local_50 + local_50[1];
    *(float *)(pPVar1 + 0x14) = pfVar3[1] * *local_68 + local_68[1];
    bVar2 = Libraries::Core::lineFitFindPoint
                      ((vector<float,class_std::allocator<float>_> *)&local_38,
                       (vector<float,class_std::allocator<float>_> *)&local_50,
                       (vector<float,class_std::allocator<float>_> *)&local_68,pPVar1 + 0xc,param_3,
                       pfVar3,pPVar1);
    if (bVar2) {
      bVar2 = true;
      goto LAB_1800ad5f5;
    }
  }
  bVar2 = false;
LAB_1800ad5f5:
  if (local_68 != (float *)0x0) {
    pfVar3 = local_68;
    if ((0xfff < (ulonglong)((local_58 - (longlong)local_68 >> 2) * 4)) &&
       (pfVar3 = *(float **)(local_68 + -2),
       0x1f < (ulonglong)((longlong)local_68 + (-8 - (longlong)pfVar3)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar3);
    local_68 = (float *)0x0;
    uStack_60 = 0;
    local_58 = 0;
  }
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
    uStack_48 = 0;
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

