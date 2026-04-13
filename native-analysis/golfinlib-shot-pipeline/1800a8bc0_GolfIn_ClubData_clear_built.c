FUNCTION: GolfIn::ClubData::clear_built
ENTRY: 1800a8bc0
REASONS: name:club


/* public: void __cdecl GolfIn::ClubData::clear_built(void) __ptr64 */

void __thiscall GolfIn::ClubData::clear_built(ClubData *this)

{
                    /* 0xa8bc0  450  ?clear_built@ClubData@GolfIn@@QEAAXXZ */
  *(undefined4 *)(this + 0x118) = 0;
  *(undefined4 *)(this + 0x180) = 0;
  if (*(longlong *)(this + 0x120) != *(longlong *)(this + 0x128)) {
    *(longlong *)(this + 0x128) = *(longlong *)(this + 0x120);
  }
  if (*(longlong *)(this + 0x138) != *(longlong *)(this + 0x140)) {
    *(longlong *)(this + 0x140) = *(longlong *)(this + 0x138);
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

