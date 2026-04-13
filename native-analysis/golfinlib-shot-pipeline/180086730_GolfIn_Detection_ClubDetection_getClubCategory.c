FUNCTION: GolfIn::Detection::ClubDetection::getClubCategory
ENTRY: 180086730
REASONS: name:club


/* public: static enum GolfIn::Detection::ClubTypeCategory __cdecl
   GolfIn::Detection::ClubDetection::getClubCategory(enum GolfIn::Detection::ClubType const &
   __ptr64) */

ClubTypeCategory __cdecl GolfIn::Detection::ClubDetection::getClubCategory(ClubType *param_1)

{
                    /* 0x86730  637
                       ?getClubCategory@ClubDetection@Detection@GolfIn@@SA?AW4ClubTypeCategory@23@AEBW4ClubType@23@@Z
                        */
  switch(*param_1) {
  case 0:
  case 1:
    return 0;
  case 2:
  case 3:
  case 4:
  case 5:
    return 1;
  case 6:
    return 2;
  default:
    return 3;
  }
}

