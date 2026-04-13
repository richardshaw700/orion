FUNCTION: GolfIn::Club::clear_built
ENTRY: 1800a9cb0
REASONS: name:club


/* public: void __cdecl GolfIn::Club::clear_built(void) __ptr64 */

void __thiscall GolfIn::Club::clear_built(Club *this)

{
                    /* 0xa9cb0  449  ?clear_built@Club@GolfIn@@QEAAXXZ */
  *(undefined8 *)(this + 8) = 0;
  *(undefined4 *)(this + 0x10) = 0;
  if (*(longlong *)(this + 0x3e0) != *(longlong *)(this + 1000)) {
    *(longlong *)(this + 1000) = *(longlong *)(this + 0x3e0);
  }
  if (*(longlong *)(this + 0x3f8) != *(longlong *)(this + 0x400)) {
    *(longlong *)(this + 0x400) = *(longlong *)(this + 0x3f8);
  }
  ClubData::clear_built((ClubData *)(this + 0x38));
  ClubData::clear_built((ClubData *)(this + 0x1e8));
  return;
}

