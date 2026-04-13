FUNCTION: GolfIn::Club::setPlayerHanded
ENTRY: 1800a9d60
REASONS: name:club


/* public: void __cdecl GolfIn::Club::setPlayerHanded(class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > const & __ptr64) __ptr64 */

void __thiscall
GolfIn::Club::setPlayerHanded
          (Club *this,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_1)

{
  int iVar1;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar2;
  Club *_Dst;
  longlong in_R8;
  longlong lVar3;
  
                    /* 0xa9d60  936
                       ?setPlayerHanded@Club@GolfIn@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z
                        */
  lVar3 = *(longlong *)(param_1 + 0x10);
  pbVar2 = param_1;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    pbVar2 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
              param_1;
  }
  if (lVar3 == 7) {
    in_R8 = lVar3;
    iVar1 = memcmp(pbVar2,"unknown",7);
    if (iVar1 == 0) goto LAB_1800a9deb;
  }
  pbVar2 = param_1;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    pbVar2 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
              param_1;
  }
  if (lVar3 == 5) {
    in_R8 = lVar3;
    iVar1 = memcmp(pbVar2,"right",5);
    if (iVar1 == 0) goto LAB_1800a9deb;
  }
  pbVar2 = param_1;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    pbVar2 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
              param_1;
  }
  if (lVar3 == 4) {
    iVar1 = memcmp(pbVar2,&DAT_180173b0c,4);
    in_R8 = lVar3;
    if (iVar1 == 0) {
LAB_1800a9deb:
      FUN_18000c400((longlong *)(this + 0x18),(longlong *)param_1,in_R8);
      FUN_18000c400((longlong *)(this + 0xc0),(longlong *)param_1,in_R8);
      FUN_18000c400((longlong *)(this + 0x270),(longlong *)param_1,in_R8);
      return;
    }
  }
  _Dst = this + 0x18;
  if (6 < *(ulonglong *)(this + 0x30)) {
    if (0xf < *(ulonglong *)(this + 0x30)) {
      _Dst = *(Club **)_Dst;
    }
    *(undefined8 *)(this + 0x28) = 7;
    memmove(_Dst,"unknown",7);
    _Dst[7] = (Club)0x0;
    return;
  }
  FUN_18000c490((longlong *)_Dst,7,in_R8,"unknown");
  return;
}

