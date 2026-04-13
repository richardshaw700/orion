FUNCTION: GolfIn::Interface::OnComputeClubFace
ENTRY: 1800a5080
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: double __cdecl GolfIn::Interface::OnComputeClubFace(class GICTS_NM::GICTSShotData)
   __ptr64 */

double __thiscall GolfIn::Interface::OnComputeClubFace(Interface *this,undefined4 *param_2)

{
  longlong *plVar1;
  code *pcVar2;
  undefined4 *puVar3;
  double dVar4;
  undefined1 auStack_f8 [40];
  undefined4 local_d0 [40];
  undefined4 *local_30;
  ulonglong local_28;
  
                    /* 0xa5080  320
                       ?OnComputeClubFace@Interface@GolfIn@@IEAANVGICTSShotData@GICTS_NM@@@Z */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStack_f8;
  plVar1 = *(longlong **)(this + 0x730);
  local_30 = param_2;
  if (plVar1 == (longlong *)0x0) {
    FUN_18000c8d0((longlong *)(param_2 + 0x20));
    FUN_18000c8d0((longlong *)(param_2 + 0x18));
    FUN_18000c8d0((longlong *)(param_2 + 8));
    dVar4 = 0.0;
  }
  else {
    pcVar2 = *(code **)(*plVar1 + 0x20);
    puVar3 = FUN_1800a5340(local_d0,param_2);
    dVar4 = (double)(*pcVar2)(plVar1,puVar3);
    FUN_18000c8d0((longlong *)(param_2 + 0x20));
    FUN_18000c8d0((longlong *)(param_2 + 0x18));
    FUN_18000c8d0((longlong *)(param_2 + 8));
  }
  return dVar4;
}

