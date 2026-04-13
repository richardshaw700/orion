FUNCTION: GolfIn::Club::Club
ENTRY: 1800a9820
REASONS: name:club


/* public: __cdecl GolfIn::Club::Club(class GolfIn::Shot & __ptr64) __ptr64 */

Club * __thiscall GolfIn::Club::Club(Club *this,Shot *param_1)

{
  Club *_Dst;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar1;
  longlong local_48 [4];
  
                    /* 0xa9820  25  ??0Club@GolfIn@@QEAA@AEAVShot@1@@Z */
  *(undefined ***)this = vftable;
  _Dst = this + 0x18;
  *(longlong *)_Dst = 0;
  *(undefined8 *)(this + 0x20) = 0;
  *(undefined8 *)(this + 0x28) = 0;
  *(undefined8 *)(this + 0x30) = 0xf;
  *_Dst = (Club)0x0;
  local_48[0] = 0;
  local_48[1] = 0;
  local_48[2] = 0;
  local_48[3] = 0;
  FUN_18000c1d0(local_48,"Camera1",7);
  ClubData::ClubData((ClubData *)(this + 0x38),param_1,
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )local_48);
  FUN_18000c8d0(local_48);
  local_48[0] = 0;
  local_48[1] = 0;
  local_48[2] = 0;
  local_48[3] = 0;
  FUN_18000c1d0(local_48,"Camera2",7);
  pbVar1 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)local_48;
  ClubData::ClubData((ClubData *)(this + 0x1e8),param_1,pbVar1);
  FUN_18000c8d0(local_48);
  *(undefined8 *)(this + 0x398) = 0;
  *(undefined8 *)(this + 0x3a0) = 0;
  *(undefined8 *)(this + 0x3a8) = 0;
  *(undefined8 *)(this + 0x3b0) = 0;
  *(undefined8 *)(this + 0x3b8) = 0;
  *(undefined8 *)(this + 0x3c0) = 0;
  *(undefined8 *)(this + 0x3c8) = 0;
  *(undefined8 *)(this + 0x3d0) = 0;
  *(undefined8 *)(this + 0x3d8) = 0;
  *(undefined8 *)(this + 0x3e0) = 0;
  *(undefined8 *)(this + 1000) = 0;
  *(undefined8 *)(this + 0x3f0) = 0;
  *(undefined8 *)(this + 0x3f8) = 0;
  *(undefined8 *)(this + 0x400) = 0;
  *(undefined8 *)(this + 0x408) = 0;
  *(undefined8 *)(this + 0x410) = 0;
  *(undefined8 *)(this + 0x418) = 0;
  *(undefined8 *)(this + 0x420) = 0;
  *(Shot **)(this + 0x428) = param_1;
  if (*(ulonglong *)(this + 0x30) < 7) {
    FUN_18000c490((longlong *)_Dst,7,pbVar1,"unknown");
  }
  else {
    if (0xf < *(ulonglong *)(this + 0x30)) {
      _Dst = *(Club **)_Dst;
    }
    *(undefined8 *)(this + 0x28) = 7;
    memmove(_Dst,"unknown",7);
    _Dst[7] = (Club)0x0;
  }
  *(undefined8 *)(this + 8) = 0;
  *(undefined4 *)(this + 0x10) = 0;
  if (*(longlong *)(this + 0x3e0) != *(longlong *)(this + 1000)) {
    *(longlong *)(this + 1000) = *(longlong *)(this + 0x3e0);
  }
  if (*(longlong *)(this + 0x3f8) != *(longlong *)(this + 0x400)) {
    *(longlong *)(this + 0x400) = *(longlong *)(this + 0x3f8);
  }
  ClubData::clear((ClubData *)(this + 0x38));
  ClubData::clear((ClubData *)(this + 0x1e8));
  return this;
}

