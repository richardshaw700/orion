FUNCTION: GolfIn::ClubData::getDetectionIndex
ENTRY: 1800a8d70
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: class cv::Point_<float> __cdecl GolfIn::ClubData::getDetectionIndex(int const &
   __ptr64,bool const & __ptr64) __ptr64 */

int * __thiscall GolfIn::ClubData::getDetectionIndex(ClubData *this,int *param_1,bool *param_2)

{
  float fVar1;
  int iVar2;
  longlong lVar3;
  undefined1 (*pauVar4) [32];
  longlong lVar5;
  char *in_R9;
  undefined1 auStack_38 [32];
  ulonglong local_18;
  
                    /* 0xa8d70  650
                       ?getDetectionIndex@ClubData@GolfIn@@QEAA?AV?$Point_@M@cv@@AEBHAEB_N@Z */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_38;
  if ((*(undefined1 (**) [32])(this + 8) == *(undefined1 (**) [32])(this + 0x10)) ||
     (*(longlong *)(this + 0x20) == *(longlong *)(this + 0x28))) {
    *param_1 = DAT_1801d1200;
    param_1[1] = DAT_1801d1204;
  }
  else {
    pauVar4 = FUN_1801324f0(*(undefined1 (**) [32])(this + 8),*(undefined1 (**) [32])(this + 0x10),
                            *(uint *)param_2);
    if (pauVar4 == *(undefined1 (**) [32])(this + 0x10)) {
      *param_1 = DAT_1801d1200;
      param_1[1] = DAT_1801d1204;
    }
    else {
      lVar3 = *(longlong *)(this + 0x20);
      lVar5 = (longlong)pauVar4 - *(longlong *)(this + 8) >> 2;
      if (*in_R9 == '\0') {
        *(undefined8 *)param_1 = *(undefined8 *)(lVar3 + lVar5 * 8);
      }
      else {
        iVar2 = *(int *)(this + 0xb0);
        fVar1 = *(float *)(lVar3 + lVar5 * 8);
        param_1[1] = (int)((float)*(int *)(this + 0xb4) + *(float *)(lVar3 + 4 + lVar5 * 8));
        *param_1 = (int)((float)iVar2 + fVar1);
      }
    }
  }
  return param_1;
}

