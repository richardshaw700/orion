FUNCTION: CSharp_LightInterface_OnNewShot
ENTRY: 180125770
REASONS: name:onNewShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void CSharp_LightInterface_OnNewShot(longlong param_1,undefined8 *param_2,undefined8 param_3)

{
  longlong *plVar1;
  code *pcVar2;
  undefined4 *puVar3;
  undefined4 *puVar4;
  undefined1 auStack_228 [32];
  undefined4 local_208 [40];
  undefined4 local_168 [40];
  undefined8 local_c8;
  undefined8 uStack_c0;
  undefined4 local_b8;
  undefined4 local_b4;
  undefined4 local_b0;
  longlong local_a8 [3];
  undefined8 uStack_90;
  undefined8 local_88;
  undefined8 uStack_80;
  undefined1 local_78;
  undefined4 local_74;
  undefined4 local_70;
  undefined4 local_6c;
  longlong local_68 [3];
  undefined8 uStack_50;
  longlong local_48 [3];
  undefined8 uStack_30;
  ulonglong local_28;
  
                    /* 0x125770  1156  CSharp_LightInterface_OnNewShot */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStack_228;
  local_a8[2] = _DAT_18017ef00;
  uStack_90 = _UNK_18017ef08;
  local_68[2] = _DAT_18017ef00;
  uStack_50 = _UNK_18017ef08;
  local_48[2] = _DAT_18017ef00;
  uStack_30 = _UNK_18017ef08;
  local_a8[1] = 0;
  local_a8[0] = 0;
  local_68[1] = 0;
  local_68[0] = 0;
  local_48[1] = 0;
  local_48[0] = 0;
  if (param_2 == (undefined8 *)0x0) {
    (*DAT_1801d1418)("Attempt to dereference null GICTS_NM::GICTSShotData");
  }
  else {
    local_c8 = *param_2;
    uStack_c0 = param_2[1];
    local_b4 = *(undefined4 *)((longlong)param_2 + 0x14);
    local_b8 = *(undefined4 *)(param_2 + 2);
    local_b0 = *(undefined4 *)(param_2 + 3);
    FUN_18000c400(local_a8,param_2 + 4,param_3);
    local_88 = param_2[8];
    uStack_80 = param_2[9];
    local_78 = *(undefined1 *)(param_2 + 10);
    local_70 = *(undefined4 *)(param_2 + 0xb);
    local_74 = *(undefined4 *)((longlong)param_2 + 0x54);
    local_6c = *(undefined4 *)((longlong)param_2 + 0x5c);
    FUN_18000c400(local_68,param_2 + 0xc,param_3);
    FUN_18000c400(local_48,param_2 + 0x10,param_3);
    puVar3 = FUN_1800a5340(local_208,(undefined4 *)&local_c8);
    plVar1 = *(longlong **)(param_1 + 0xb8);
    if (plVar1 != (longlong *)0x0) {
      pcVar2 = *(code **)(*plVar1 + 0x18);
      puVar4 = FUN_1800a5340(local_168,puVar3);
      (*pcVar2)(plVar1,puVar4);
    }
    FUN_18000c8d0((longlong *)(puVar3 + 0x20));
    FUN_18000c8d0((longlong *)(puVar3 + 0x18));
    FUN_18000c8d0((longlong *)(puVar3 + 8));
  }
  FUN_18000c8d0(local_48);
  FUN_18000c8d0(local_68);
  FUN_18000c8d0(local_a8);
  return;
}

