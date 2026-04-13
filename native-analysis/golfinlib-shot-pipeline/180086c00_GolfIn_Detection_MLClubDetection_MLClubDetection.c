FUNCTION: GolfIn::Detection::MLClubDetection::MLClubDetection
ENTRY: 180086c00
REASONS: name:club


/* public: __cdecl GolfIn::Detection::MLClubDetection::MLClubDetection(class
   GolfIn::Detection::MLClubDetection const & __ptr64) __ptr64 */

MLClubDetection * __thiscall
GolfIn::Detection::MLClubDetection::MLClubDetection(MLClubDetection *this,MLClubDetection *param_1)

{
  int *piVar1;
  
                    /* 0x86c00  59  ??0MLClubDetection@Detection@GolfIn@@QEAA@AEBV012@@Z */
  ClubDetection::ClubDetection((ClubDetection *)this,(ClubDetection *)param_1);
  *(undefined ***)this = vftable;
  *(undefined8 *)(this + 0x210) = 0;
  *(undefined8 *)(this + 0x218) = 0;
  if (*(longlong *)(param_1 + 0x218) != 0) {
    LOCK();
    piVar1 = (int *)(*(longlong *)(param_1 + 0x218) + 8);
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  *(undefined8 *)(this + 0x210) = *(undefined8 *)(param_1 + 0x210);
  *(undefined8 *)(this + 0x218) = *(undefined8 *)(param_1 + 0x218);
  *(undefined8 *)(this + 0x220) = 0;
  *(undefined8 *)(this + 0x228) = 0;
  if (*(longlong *)(param_1 + 0x228) != 0) {
    LOCK();
    piVar1 = (int *)(*(longlong *)(param_1 + 0x228) + 8);
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  *(undefined8 *)(this + 0x220) = *(undefined8 *)(param_1 + 0x220);
  *(undefined8 *)(this + 0x228) = *(undefined8 *)(param_1 + 0x228);
  return this;
}

