FUNCTION: GolfIn::Interface::builtBallClub
ENTRY: 1800e9780
REASONS: name:club


/* public: bool __cdecl GolfIn::Interface::builtBallClub(class GolfIn::Shot & __ptr64) __ptr64 */

bool __thiscall GolfIn::Interface::builtBallClub(Interface *this,Shot *param_1)

{
  bool bVar1;
  
                    /* 0xe9780  424  ?builtBallClub@Interface@GolfIn@@QEAA_NAEAVShot@2@@Z */
  Shot::clear_built(param_1);
  bVar1 = Ball::built((Ball *)(param_1 + 8));
  if (!bVar1) {
    return false;
  }
  Club::built((Club *)(param_1 + 0x2a0));
  return true;
}

