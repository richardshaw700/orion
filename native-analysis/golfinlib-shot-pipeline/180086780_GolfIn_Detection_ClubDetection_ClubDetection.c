FUNCTION: GolfIn::Detection::ClubDetection::~ClubDetection
ENTRY: 180086780
REASONS: name:club


/* public: virtual __cdecl GolfIn::Detection::ClubDetection::~ClubDetection(void) __ptr64 */

void __thiscall GolfIn::Detection::ClubDetection::~ClubDetection(ClubDetection *this)

{
  longlong *plVar1;
  int *piVar2;
  int iVar3;
  longlong *plVar4;
  longlong lVar5;
  
                    /* 0x86780  83  ??1ClubDetection@Detection@GolfIn@@UEAA@XZ */
  cv::Mat::~Mat((Mat *)(this + 0x180));
  cv::Mat::~Mat((Mat *)(this + 0x120));
  FUN_18000c8d0((longlong *)(this + 0xf8));
  FUN_18000c8d0((longlong *)(this + 0xd8));
  plVar4 = *(longlong **)(this + 200);
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
  FUN_18000c8d0((longlong *)(this + 0x98));
                    /* WARNING: Could not recover jumptable at 0x00018008681b. Too many branches */
                    /* WARNING: Treating indirect jump as call */
  cv::Mat::~Mat((Mat *)(this + 8));
  return;
}

