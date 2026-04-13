FUNCTION: Libraries::Core::canSaveShotData
ENTRY: 1800264d0
REASONS: name:saveShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* bool __cdecl Libraries::Core::canSaveShotData(class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > const & __ptr64) */

bool __cdecl
Libraries::Core::canSaveShotData
          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_1)

{
  longlong lVar1;
  undefined1 auStack_38 [32];
  longlong local_18;
  ulonglong local_10;
  
                    /* 0x264d0  437
                       ?canSaveShotData@Core@Libraries@@YA_NAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z
                        */
  local_10 = DAT_1801d1040 ^ (ulonglong)auStack_38;
  if (*(longlong *)(param_1 + 0x10) != 0) {
    FUN_180065d70(&local_18,(undefined8 *)param_1);
    lVar1 = local_18;
    if (local_18 != 0x7ffffffffffffffe) {
      FUN_1800633a0(&local_18);
      return local_18 <= lVar1;
    }
  }
  return false;
}

