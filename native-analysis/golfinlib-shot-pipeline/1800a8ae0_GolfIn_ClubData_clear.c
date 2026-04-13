FUNCTION: GolfIn::ClubData::clear
ENTRY: 1800a8ae0
REASONS: name:club


/* public: void __cdecl GolfIn::ClubData::clear(void) __ptr64 */

void __thiscall GolfIn::ClubData::clear(ClubData *this)

{
                    /* 0xa8ae0  442  ?clear@ClubData@GolfIn@@QEAAXXZ */
  if (*(longlong *)(this + 8) != *(longlong *)(this + 0x10)) {
    *(longlong *)(this + 0x10) = *(longlong *)(this + 8);
  }
  if (*(longlong *)(this + 0x20) != *(longlong *)(this + 0x28)) {
    *(longlong *)(this + 0x28) = *(longlong *)(this + 0x20);
  }
  if (*(longlong *)(this + 0x58) != *(longlong *)(this + 0x60)) {
    *(longlong *)(this + 0x60) = *(longlong *)(this + 0x58);
  }
  if (*(longlong *)(this + 0x70) != *(longlong *)(this + 0x78)) {
    *(longlong *)(this + 0x78) = *(longlong *)(this + 0x70);
  }
  if (*(longlong *)(this + 0x150) != *(longlong *)(this + 0x158)) {
    *(longlong *)(this + 0x158) = *(longlong *)(this + 0x150);
  }
  if (*(longlong *)(this + 0x168) != *(longlong *)(this + 0x170)) {
    *(longlong *)(this + 0x170) = *(longlong *)(this + 0x168);
  }
  if (*(longlong *)(this + 0xe8) != *(longlong *)(this + 0xf0)) {
    *(longlong *)(this + 0xf0) = *(longlong *)(this + 0xe8);
  }
  if (*(longlong *)(this + 0xd0) != *(longlong *)(this + 0xd8)) {
    *(longlong *)(this + 0xd8) = *(longlong *)(this + 0xd0);
  }
  if (*(longlong *)(this + 0x100) != *(longlong *)(this + 0x108)) {
    *(longlong *)(this + 0x108) = *(longlong *)(this + 0x100);
  }
  return;
}

