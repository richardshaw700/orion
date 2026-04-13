FUNCTION: CSharp_CameraCallback_OnGetSpinConfig
ENTRY: 1801249e0
REASONS: name:spin


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
CSharp_CameraCallback_OnGetSpinConfig
          (longlong *param_1,undefined4 param_2,undefined4 param_3,undefined8 param_4,
          undefined4 param_5)

{
  undefined8 ****ppppuVar1;
  undefined8 uVar2;
  undefined8 ****_Memory;
  undefined1 auStack_88 [32];
  undefined8 local_68;
  undefined4 local_60;
  longlong local_58 [4];
  undefined8 ***local_38;
  undefined8 **ppuStack_30;
  undefined8 **local_28;
  undefined8 **ppuStack_20;
  ulonglong local_18;
  
                    /* 0x1249e0  1083  CSharp_CameraCallback_OnGetSpinConfig */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_88;
  ppuStack_30 = (undefined8 ***)0x0;
  local_38 = (undefined8 ****)0x0;
  local_60 = param_5;
  local_28 = _DAT_18017ef00;
  ppuStack_20 = _UNK_18017ef08;
  local_68 = param_4;
  ppppuVar1 = (undefined8 ****)(**(code **)(*param_1 + 0x28))(param_1,local_58,param_2,param_3);
  if (&local_38 != ppppuVar1) {
    if ((undefined8 ***)0xf < ppuStack_20) {
      _Memory = (undefined8 ****)local_38;
      if ((0xfff < (longlong)ppuStack_20 + 1U) &&
         (_Memory = (undefined8 ****)local_38[-1],
         0x1f < (ulonglong)((longlong)local_38 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
        _invalid_parameter_noinfo_noreturn();
      }
      free(_Memory);
    }
    local_38 = *ppppuVar1;
    ppuStack_30 = ppppuVar1[1];
    local_28 = ppppuVar1[2];
    ppuStack_20 = ppppuVar1[3];
    ppppuVar1[2] = (undefined8 ***)0x0;
    ppppuVar1[3] = (undefined8 ***)0xf;
    *(undefined1 *)ppppuVar1 = 0;
  }
  FUN_18000c8d0(local_58);
  ppppuVar1 = &local_38;
  if ((undefined8 ***)0xf < ppuStack_20) {
    ppppuVar1 = (undefined8 ****)local_38;
  }
  uVar2 = (*DAT_1801ed938)(ppppuVar1);
  FUN_18000c8d0((longlong *)&local_38);
  return uVar2;
}

