FUNCTION: GolfIn::ClubData::ClubData
ENTRY: 1800a4400
REASONS: name:club


/* public: __cdecl GolfIn::ClubData::ClubData(class GolfIn::ClubData const & __ptr64) __ptr64 */

ClubData * __thiscall GolfIn::ClubData::ClubData(ClubData *this,ClubData *param_1)

{
  undefined8 uVar1;
  
                    /* 0xa4400  28  ??0ClubData@GolfIn@@QEAA@AEBV01@@Z */
  *(undefined ***)this = vftable;
  FUN_180063640((ulonglong *)(this + 8),(longlong *)(param_1 + 8));
  FUN_180042d20((ulonglong *)(this + 0x20),(longlong *)(param_1 + 0x20));
  FUN_180042d20((ulonglong *)(this + 0x38),(longlong *)(param_1 + 0x38));
  *(undefined4 *)(this + 0x50) = *(undefined4 *)(param_1 + 0x50);
  FUN_180063640((ulonglong *)(this + 0x58),(longlong *)(param_1 + 0x58));
  FUN_180042d20((ulonglong *)(this + 0x70),(longlong *)(param_1 + 0x70));
  FUN_18000cb00((undefined8 *)(this + 0x88),(undefined8 *)(param_1 + 0x88));
  *(undefined8 *)(this + 0xa8) = *(undefined8 *)(param_1 + 0xa8);
  uVar1 = *(undefined8 *)(param_1 + 0xb8);
  *(undefined8 *)(this + 0xb0) = *(undefined8 *)(param_1 + 0xb0);
  *(undefined8 *)(this + 0xb8) = uVar1;
  *(undefined4 *)(this + 0xc0) = *(undefined4 *)(param_1 + 0xc0);
  *(undefined4 *)(this + 0xc4) = *(undefined4 *)(param_1 + 0xc4);
  this[200] = param_1[200];
  FUN_180063640((ulonglong *)(this + 0xd0),(longlong *)(param_1 + 0xd0));
  FUN_180063640((ulonglong *)(this + 0xe8),(longlong *)(param_1 + 0xe8));
  FUN_180042d20((ulonglong *)(this + 0x100),(longlong *)(param_1 + 0x100));
  *(undefined4 *)(this + 0x118) = *(undefined4 *)(param_1 + 0x118);
  FUN_180063640((ulonglong *)(this + 0x120),(longlong *)(param_1 + 0x120));
  FUN_180063640((ulonglong *)(this + 0x138),(longlong *)(param_1 + 0x138));
  FUN_180063640((ulonglong *)(this + 0x150),(longlong *)(param_1 + 0x150));
  FUN_180063640((ulonglong *)(this + 0x168),(longlong *)(param_1 + 0x168));
  *(undefined4 *)(this + 0x180) = *(undefined4 *)(param_1 + 0x180);
  *(undefined8 *)(this + 0x188) = *(undefined8 *)(param_1 + 0x188);
  FUN_18000cb00((undefined8 *)(this + 400),(undefined8 *)(param_1 + 400));
  return this;
}

