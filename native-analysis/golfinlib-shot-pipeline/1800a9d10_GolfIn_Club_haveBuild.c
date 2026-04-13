FUNCTION: GolfIn::Club::haveBuild
ENTRY: 1800a9d10
REASONS: name:club


/* public: bool __cdecl GolfIn::Club::haveBuild(void) __ptr64 */

bool __thiscall GolfIn::Club::haveBuild(Club *this)

{
                    /* 0xa9d10  709  ?haveBuild@Club@GolfIn@@QEAA_NXZ */
  if ((((*(longlong *)(this + 0x188) != *(longlong *)(this + 400)) &&
       (*(longlong *)(this + 0x1a0) != *(longlong *)(this + 0x1a8))) &&
      (*(longlong *)(this + 0x338) != *(longlong *)(this + 0x340))) &&
     (*(longlong *)(this + 0x350) != *(longlong *)(this + 0x358))) {
    return true;
  }
  return false;
}

