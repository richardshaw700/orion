FUNCTION: GolfIn::Detection::MLClubDetection::~MLClubDetection
ENTRY: 180086b60
REASONS: name:club


/* public: virtual __cdecl GolfIn::Detection::MLClubDetection::~MLClubDetection(void) __ptr64 */

void __thiscall GolfIn::Detection::MLClubDetection::~MLClubDetection(MLClubDetection *this)

{
  longlong *plVar1;
  int *piVar2;
  int iVar3;
  longlong *plVar4;
  longlong lVar5;
  
                    /* 0x86b60  94  ??1MLClubDetection@Detection@GolfIn@@UEAA@XZ */
  plVar4 = *(longlong **)(this + 0x228);
  if (plVar4 != (longlong *)0x0) {
    LOCK();
    plVar1 = plVar4 + 1;
    lVar5 = *plVar1;
    *(int *)plVar1 = (int)*plVar1 + -1;
    UNLOCK();
    if ((int)lVar5 == 1) {
      (**(code **)*plVar4)(plVar4);
      LOCK();
      piVar2 = (int *)((longlong)plVar4 + 0xc);
      iVar3 = *piVar2;
      *piVar2 = *piVar2 + -1;
      UNLOCK();
      if (iVar3 == 1) {
        (**(code **)(*plVar4 + 8))(plVar4);
      }
    }
  }
  plVar4 = *(longlong **)(this + 0x218);
  if (plVar4 != (longlong *)0x0) {
    LOCK();
    plVar1 = plVar4 + 1;
    lVar5 = *plVar1;
    *(int *)plVar1 = (int)*plVar1 + -1;
    UNLOCK();
    if ((int)lVar5 == 1) {
      (**(code **)*plVar4)(plVar4);
      LOCK();
      piVar2 = (int *)((longlong)plVar4 + 0xc);
      iVar3 = *piVar2;
      *piVar2 = *piVar2 + -1;
      UNLOCK();
      if (iVar3 == 1) {
        (**(code **)(*plVar4 + 8))(plVar4);
      }
    }
  }
  ClubDetection::~ClubDetection((ClubDetection *)this);
  return;
}

