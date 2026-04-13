FUNCTION: GolfIn::ClubData::haveBuild
ENTRY: 1800a8b90
REASONS: name:club


/* public: bool __cdecl GolfIn::ClubData::haveBuild(void)const __ptr64 */

bool __thiscall GolfIn::ClubData::haveBuild(ClubData *this)

{
                    /* 0xa8b90  710  ?haveBuild@ClubData@GolfIn@@QEBA_NXZ */
  if ((*(longlong *)(this + 0x150) != *(longlong *)(this + 0x158)) &&
     (*(longlong *)(this + 0x168) != *(longlong *)(this + 0x170))) {
    return true;
  }
  return false;
}

