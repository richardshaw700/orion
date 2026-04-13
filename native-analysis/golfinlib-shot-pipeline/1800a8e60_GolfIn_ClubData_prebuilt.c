FUNCTION: GolfIn::ClubData::prebuilt
ENTRY: 1800a8e60
REASONS: name:club


/* public: bool __cdecl GolfIn::ClubData::prebuilt(class GolfIn::BallData const & __ptr64) __ptr64
    */

bool __thiscall GolfIn::ClubData::prebuilt(ClubData *this,BallData *param_1)

{
                    /* 0xa8e60  866  ?prebuilt@ClubData@GolfIn@@QEAA_NAEBVBallData@2@@Z */
  clear_built(this);
  if ((*(longlong *)(this + 8) != *(longlong *)(this + 0x10)) &&
     (*(double *)(param_1 + 0xb0) != DAT_18017ed58)) {
    *(double *)(this + 0xa8) = *(double *)(param_1 + 0xb0);
    *(undefined4 *)(this + 0x118) = *(undefined4 *)(*(longlong *)(this + 0x10) + -4);
    return true;
  }
  return false;
}

