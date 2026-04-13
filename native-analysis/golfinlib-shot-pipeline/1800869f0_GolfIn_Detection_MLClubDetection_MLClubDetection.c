FUNCTION: GolfIn::Detection::MLClubDetection::MLClubDetection
ENTRY: 1800869f0
REASONS: name:club


/* public: __cdecl GolfIn::Detection::MLClubDetection::MLClubDetection(class
   Libraries::Core::Parameters & __ptr64,class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::shared_ptr<class GolfIn::BaseDeepLearning> const & __ptr64,struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,class std::shared_ptr<class
   GolfIn::ResNet18Classification>,class std::shared_ptr<class GolfIn::YoloClubSegmentation>)
   __ptr64 */

MLClubDetection * __thiscall
GolfIn::Detection::MLClubDetection::MLClubDetection(MLClubDetection *this)

{
  int *piVar1;
  longlong *plVar2;
  int iVar3;
  longlong *plVar4;
  longlong lVar5;
  longlong param_4;
  ClubDetectionInput *param_5;
  undefined8 *in_stack_00000038;
  undefined8 *in_stack_00000040;
  
                    /* 0x869f0  58
                       ??0MLClubDetection@Detection@GolfIn@@QEAA@AEAVParameters@Core@Libraries@@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@1AEBV?$shared_ptr@VBaseDeepLearning@GolfIn@@@7@AEBUClubDetectionInput@12@V?$shared_ptr@VResNet18Classification@GolfIn@@@7@V?$shared_ptr@VYoloClubSegmentation@GolfIn@@@7@@Z
                        */
  if (*(longlong *)(param_4 + 8) != 0) {
    LOCK();
    piVar1 = (int *)(*(longlong *)(param_4 + 8) + 8);
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  ClubDetection::ClubDetection();
  *(undefined ***)this = vftable;
  *(undefined8 *)(this + 0x210) = 0;
  *(undefined8 *)(this + 0x218) = 0;
  *(undefined8 *)(this + 0x210) = *in_stack_00000038;
  *(undefined8 *)(this + 0x218) = in_stack_00000038[1];
  *in_stack_00000038 = 0;
  in_stack_00000038[1] = 0;
  *(undefined8 *)(this + 0x220) = 0;
  *(undefined8 *)(this + 0x228) = 0;
  *(undefined8 *)(this + 0x220) = *in_stack_00000040;
  *(undefined8 *)(this + 0x228) = in_stack_00000040[1];
  *in_stack_00000040 = 0;
  in_stack_00000040[1] = 0;
  performDetectionPipeline(this,param_5);
  plVar4 = (longlong *)in_stack_00000038[1];
  if (plVar4 != (longlong *)0x0) {
    LOCK();
    plVar2 = plVar4 + 1;
    lVar5 = *plVar2;
    *(int *)plVar2 = (int)*plVar2 + -1;
    UNLOCK();
    if ((int)lVar5 == 1) {
      (**(code **)*plVar4)(plVar4);
      LOCK();
      piVar1 = (int *)((longlong)plVar4 + 0xc);
      iVar3 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar3 == 1) {
        (**(code **)(*plVar4 + 8))(plVar4);
      }
    }
  }
  plVar4 = (longlong *)in_stack_00000040[1];
  if (plVar4 != (longlong *)0x0) {
    LOCK();
    plVar2 = plVar4 + 1;
    lVar5 = *plVar2;
    *(int *)plVar2 = (int)*plVar2 + -1;
    UNLOCK();
    if ((int)lVar5 == 1) {
      (**(code **)*plVar4)(plVar4);
      LOCK();
      piVar1 = (int *)((longlong)plVar4 + 0xc);
      iVar3 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar3 == 1) {
        (**(code **)(*plVar4 + 8))(plVar4);
      }
    }
  }
  return this;
}

