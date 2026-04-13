FUNCTION: GolfIn::Interface::OnNewShot
ENTRY: 1800a4fe0
REASONS: name:onNewShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: void __cdecl GolfIn::Interface::OnNewShot(class GICTS_NM::GICTSShotData) __ptr64 */

void __thiscall GolfIn::Interface::OnNewShot(Interface *this,undefined4 *param_2)

{
  longlong *plVar1;
  code *pcVar2;
  undefined4 *puVar3;
  undefined1 auStack_e8 [40];
  undefined4 local_c0 [40];
  undefined4 *local_20;
  ulonglong local_18;
  
                    /* 0xa4fe0  323  ?OnNewShot@Interface@GolfIn@@IEAAXVGICTSShotData@GICTS_NM@@@Z
                        */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_e8;
  plVar1 = *(longlong **)(this + 0x730);
  local_20 = param_2;
  if (plVar1 != (longlong *)0x0) {
    pcVar2 = *(code **)(*plVar1 + 0x18);
    puVar3 = FUN_1800a5340(local_c0,param_2);
    (*pcVar2)(plVar1,puVar3);
  }
  FUN_18000c8d0((longlong *)(param_2 + 0x20));
  FUN_18000c8d0((longlong *)(param_2 + 0x18));
  FUN_18000c8d0((longlong *)(param_2 + 8));
  return;
}

