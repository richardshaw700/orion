FUNCTION: GolfIn::Club::tooglePlayerHanded
ENTRY: 1800a9e90
REASONS: name:club


/* public: void __cdecl GolfIn::Club::tooglePlayerHanded(void) __ptr64 */

void __thiscall GolfIn::Club::tooglePlayerHanded(Club *this)

{
  longlong lVar1;
  int iVar2;
  Club *_Buf1;
  Club *_Buf1_00;
  longlong local_28 [4];
  
                    /* 0xa9e90  1038  ?tooglePlayerHanded@Club@GolfIn@@QEAAXXZ */
  _Buf1_00 = this + 0x18;
  lVar1 = *(longlong *)(this + 0x28);
  _Buf1 = _Buf1_00;
  if (0xf < *(ulonglong *)(this + 0x30)) {
    _Buf1 = *(Club **)_Buf1_00;
  }
  if (lVar1 == 7) {
    iVar2 = memcmp(_Buf1,"unknown",7);
    if (iVar2 == 0) {
      local_28[0] = 0;
      local_28[1] = 0;
      local_28[2] = 0;
      local_28[3] = 0;
      FUN_18000c1d0(local_28,"right",5);
      setPlayerHanded(this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_28);
      goto LAB_1800a9f9e;
    }
  }
  if (0xf < *(ulonglong *)(this + 0x30)) {
    _Buf1_00 = *(Club **)_Buf1_00;
  }
  if (lVar1 == 5) {
    iVar2 = memcmp(_Buf1_00,"right",5);
    if (iVar2 == 0) {
      local_28[0] = 0;
      local_28[1] = 0;
      local_28[2] = 0;
      local_28[3] = 0;
      FUN_18000c1d0(local_28,&DAT_180173b0c,4);
      setPlayerHanded(this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_28);
      goto LAB_1800a9f9e;
    }
  }
  local_28[0] = 0;
  local_28[1] = 0;
  local_28[2] = 0;
  local_28[3] = 0;
  FUN_18000c1d0(local_28,"unknown",7);
  setPlayerHanded(this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_28);
LAB_1800a9f9e:
  FUN_18000c8d0(local_28);
  return;
}

