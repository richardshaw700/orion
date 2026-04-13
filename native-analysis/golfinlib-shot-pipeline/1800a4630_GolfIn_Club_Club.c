FUNCTION: GolfIn::Club::Club
ENTRY: 1800a4630
REASONS: name:club


/* public: __cdecl GolfIn::Club::Club(class GolfIn::Club const & __ptr64) __ptr64 */

Club * __thiscall GolfIn::Club::Club(Club *this,Club *param_1)

{
                    /* 0xa4630  26  ??0Club@GolfIn@@QEAA@AEBV01@@Z */
  *(undefined ***)this = vftable;
  *(undefined4 *)(this + 8) = *(undefined4 *)(param_1 + 8);
  *(undefined4 *)(this + 0xc) = *(undefined4 *)(param_1 + 0xc);
  *(undefined4 *)(this + 0x10) = *(undefined4 *)(param_1 + 0x10);
  *(undefined4 *)(this + 0x14) = *(undefined4 *)(param_1 + 0x14);
  FUN_18000cb00((undefined8 *)(this + 0x18),(undefined8 *)(param_1 + 0x18));
  ClubData::ClubData((ClubData *)(this + 0x38),(ClubData *)(param_1 + 0x38));
  ClubData::ClubData((ClubData *)(this + 0x1e8),(ClubData *)(param_1 + 0x1e8));
  FUN_180063640((ulonglong *)(this + 0x398),(longlong *)(param_1 + 0x398));
  FUN_180063640((ulonglong *)(this + 0x3b0),(longlong *)(param_1 + 0x3b0));
  FUN_180063640((ulonglong *)(this + 0x3c8),(longlong *)(param_1 + 0x3c8));
  FUN_180063640((ulonglong *)(this + 0x3e0),(longlong *)(param_1 + 0x3e0));
  FUN_180047210((ulonglong *)(this + 0x3f8),(longlong *)(param_1 + 0x3f8));
  FUN_180047210((ulonglong *)(this + 0x410),(longlong *)(param_1 + 0x410));
  *(undefined8 *)(this + 0x428) = *(undefined8 *)(param_1 + 0x428);
  return this;
}

