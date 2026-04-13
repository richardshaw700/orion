FUNCTION: GolfIn::Detection::ClubDetection::getClubType
ENTRY: 1800864a0
REASONS: name:club


/* public: enum GolfIn::Detection::ClubType __cdecl
   GolfIn::Detection::ClubDetection::getClubType(void)const __ptr64 */

ClubType __thiscall GolfIn::Detection::ClubDetection::getClubType(ClubDetection *this)

{
                    /* 0x864a0  643
                       ?getClubType@ClubDetection@Detection@GolfIn@@QEBA?AW4ClubType@23@XZ */
  return *(ClubType *)(this + 0x84);
}

