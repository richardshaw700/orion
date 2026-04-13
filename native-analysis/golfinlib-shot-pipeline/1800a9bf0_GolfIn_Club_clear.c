FUNCTION: GolfIn::Club::clear
ENTRY: 1800a9bf0
REASONS: name:club


/* public: void __cdecl GolfIn::Club::clear(void) __ptr64 */

void __thiscall GolfIn::Club::clear(Club *this)

{
  Club *_Dst;
  undefined8 in_R8;
  
                    /* 0xa9bf0  441  ?clear@Club@GolfIn@@QEAAXXZ */
  _Dst = this + 0x18;
  if (*(ulonglong *)(this + 0x30) < 7) {
    FUN_18000c490((longlong *)_Dst,7,in_R8,"unknown");
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
  return;
}

