FUNCTION: CSharp_CameraCallback_OnGetSpinConfigSwigExplicitCameraCallback
ENTRY: 180124b10
REASONS: name:spin


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 CSharp_CameraCallback_OnGetSpinConfigSwigExplicitCameraCallback(void)

{
  undefined8 uVar1;
  undefined8 ***_Memory;
  undefined8 ****ppppuVar2;
  undefined1 auStack_78 [32];
  undefined8 ***local_58;
  undefined8 uStack_50;
  undefined8 local_48;
  ulonglong uStack_40;
  undefined8 ***local_38;
  undefined8 uStack_30;
  undefined8 local_28;
  ulonglong uStack_20;
  ulonglong local_18;
  
                    /* 0x124b10  1084
                       CSharp_CameraCallback_OnGetSpinConfigSwigExplicitCameraCallback */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_78;
  local_28 = _DAT_18017ef00;
  uStack_20 = _UNK_18017ef08;
  uStack_30 = 0;
  local_38 = (undefined8 ***)0x0;
  local_48 = 0;
  uStack_40 = 0;
  local_58 = (undefined8 ****)0x0;
  uStack_50 = 0;
  FUN_18000c1d0(&local_58,"0.0,0.0",7);
  if (0xf < uStack_20) {
    _Memory = local_38;
    if ((0xfff < uStack_20 + 1) &&
       (_Memory = (undefined8 ***)local_38[-1],
       0x1f < (ulonglong)((longlong)local_38 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(_Memory);
  }
  uStack_20 = uStack_40;
  local_28 = local_48;
  local_38 = local_58;
  local_58 = (undefined8 ***)((ulonglong)local_58 & 0xffffffffffffff00);
  uStack_30 = uStack_50;
  local_48 = _DAT_18017ef00;
  uStack_40 = _UNK_18017ef08;
  FUN_18000c8d0((longlong *)&local_58);
  ppppuVar2 = &local_38;
  if (0xf < uStack_20) {
    ppppuVar2 = (undefined8 ****)local_38;
  }
  uVar1 = (*DAT_1801ed938)(ppppuVar2);
  FUN_18000c8d0((longlong *)&local_38);
  return uVar1;
}

