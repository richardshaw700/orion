FUNCTION: GolfIn::Interface::updateCanSaveShotData
ENTRY: 1800c0260
REASONS: name:saveShot; string:saveShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl GolfIn::Interface::updateCanSaveShotData(void) __ptr64 */

void __thiscall GolfIn::Interface::updateCanSaveShotData(Interface *this)

{
  longlong lVar1;
  Interface IVar2;
  undefined1 auStack_a8 [32];
  undefined4 local_88;
  longlong local_80 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_60 [32];
  longlong local_40;
  longlong local_38 [2];
  longlong local_28;
  ulonglong local_18;
  
                    /* 0xc0260  1044  ?updateCanSaveShotData@Interface@GolfIn@@QEAAXXZ */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStack_a8;
  local_88 = 0;
  FUN_1800633a0(&local_40);
  FUN_180067730((undefined8 *)local_60,local_40);
  local_88 = 3;
  local_80[0] = 0;
  local_80[1] = 0;
  local_80[2] = 0;
  local_80[3] = 0;
  FUN_18000c1d0(local_80,"Configurations.Debug.AutoSaveShotUntilTimestamp",0x2f);
  FUN_1800f9c20(this,local_38,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                local_80,local_60);
  FUN_18000c8d0(local_80);
  FUN_18000c8d0((longlong *)local_60);
  if (local_28 != 0) {
    FUN_180065d70(&local_40,local_38);
    lVar1 = local_40;
    if (local_40 != 0x7ffffffffffffffe) {
      FUN_1800633a0(&local_40);
      IVar2 = (Interface)(local_40 <= lVar1);
      goto LAB_1800c0346;
    }
  }
  IVar2 = (Interface)0x0;
LAB_1800c0346:
  this[0x300] = IVar2;
  FUN_18000c8d0(local_38);
  return;
}

