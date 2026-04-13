FUNCTION: CSharp_CameraCallback_OnNewShot
ENTRY: 180124490
REASONS: name:onNewShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void CSharp_CameraCallback_OnNewShot(longlong *param_1,undefined8 *param_2,undefined8 param_3)

{
  code *pcVar1;
  undefined4 *puVar2;
  undefined1 auStack_178 [32];
  undefined4 local_158 [40];
  undefined8 local_b8;
  undefined8 uStack_b0;
  undefined4 local_a8;
  undefined4 local_a4;
  undefined4 local_a0;
  longlong local_98 [3];
  undefined8 uStack_80;
  undefined8 local_78;
  undefined8 uStack_70;
  undefined1 local_68;
  undefined4 local_64;
  undefined4 local_60;
  undefined4 local_5c;
  longlong local_58 [3];
  undefined8 uStack_40;
  longlong local_38 [3];
  undefined8 uStack_20;
  ulonglong local_18;
  
                    /* 0x124490  1091  CSharp_CameraCallback_OnNewShot */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_178;
  local_98[2] = _DAT_18017ef00;
  uStack_80 = _UNK_18017ef08;
  local_58[2] = _DAT_18017ef00;
  uStack_40 = _UNK_18017ef08;
  local_38[2] = _DAT_18017ef00;
  uStack_20 = _UNK_18017ef08;
  local_98[1] = 0;
  local_98[0] = 0;
  local_58[1] = 0;
  local_58[0] = 0;
  local_38[1] = 0;
  local_38[0] = 0;
  if (param_2 == (undefined8 *)0x0) {
    (*DAT_1801d1418)("Attempt to dereference null GICTS_NM::GICTSShotData");
  }
  else {
    local_b8 = *param_2;
    uStack_b0 = param_2[1];
    local_a4 = *(undefined4 *)((longlong)param_2 + 0x14);
    local_a8 = *(undefined4 *)(param_2 + 2);
    local_a0 = *(undefined4 *)(param_2 + 3);
    FUN_18000c400(local_98,param_2 + 4,param_3);
    local_78 = param_2[8];
    uStack_70 = param_2[9];
    local_68 = *(undefined1 *)(param_2 + 10);
    local_60 = *(undefined4 *)(param_2 + 0xb);
    local_64 = *(undefined4 *)((longlong)param_2 + 0x54);
    local_5c = *(undefined4 *)((longlong)param_2 + 0x5c);
    FUN_18000c400(local_58,param_2 + 0xc,param_3);
    FUN_18000c400(local_38,param_2 + 0x10,param_3);
    pcVar1 = *(code **)(*param_1 + 0x18);
    puVar2 = FUN_1800a5340(local_158,(undefined4 *)&local_b8);
    (*pcVar1)(param_1,puVar2);
  }
  FUN_18000c8d0(local_38);
  FUN_18000c8d0(local_58);
  FUN_18000c8d0(local_98);
  return;
}

