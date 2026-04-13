FUNCTION: GolfIn::Detection::ClubDetection::ClubDetection
ENTRY: 180085fa0
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: __cdecl GolfIn::Detection::ClubDetection::ClubDetection(class Libraries::Core::Parameters
   & __ptr64,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >
   const & __ptr64,class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const & __ptr64,class std::shared_ptr<class
   GolfIn::BaseDeepLearning>,struct GolfIn::Detection::ClubDetectionInput const & __ptr64,bool)
   __ptr64 */

ClubDetection * __thiscall
GolfIn::Detection::ClubDetection::ClubDetection
          (ClubDetection *this,undefined8 param_1,undefined8 *param_2,undefined8 *param_3,
          undefined8 *param_5,ClubDetectionInput *param_6,bool param_7)

{
  int *piVar1;
  longlong *plVar2;
  int iVar3;
  longlong *plVar4;
  longlong lVar5;
  undefined8 uVar6;
  
                    /* 0x85fa0  30
                       ??0ClubDetection@Detection@GolfIn@@QEAA@AEAVParameters@Core@Libraries@@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@1V?$shared_ptr@VBaseDeepLearning@GolfIn@@@7@AEBUClubDetectionInput@12@_N@Z
                        */
  *(undefined ***)this = vftable;
  cv::Mat::Mat((Mat *)(this + 8));
  *(undefined4 *)(this + 0x68) = DAT_1801d1160;
  *(undefined4 *)(this + 0x6c) = DAT_1801d1164;
  uVar6 = _DAT_1801d1170;
  *(undefined8 *)(this + 0x70) = _DAT_1801d1168;
  *(undefined8 *)(this + 0x78) = uVar6;
  *(undefined4 *)(this + 0x80) = 0xffffffff;
  *(undefined4 *)(this + 0x84) = 0;
  *(undefined4 *)(this + 0x88) = 0xffffffff;
  *(undefined4 *)(this + 0x8c) = 0xbf800000;
  this[0x90] = (ClubDetection)0x0;
  FUN_18000cb00((undefined8 *)(this + 0x98),param_3);
  *(undefined8 *)(this + 0xb8) = param_1;
  *(undefined8 *)(this + 0xc0) = 0;
  *(undefined8 *)(this + 200) = 0;
  if (param_5[1] != 0) {
    LOCK();
    piVar1 = (int *)(param_5[1] + 8);
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  *(undefined8 *)(this + 0xc0) = *param_5;
  *(undefined8 *)(this + 200) = param_5[1];
  this[0xd0] = (ClubDetection)0x0;
  FUN_18000cb00((undefined8 *)(this + 0xd8),param_2);
  ClubDetectionInput::ClubDetectionInput((ClubDetectionInput *)(this + 0xf8));
  *(undefined4 *)(this + 0x208) = 0x40000000;
  baseConstructor(this,param_6,param_7);
  plVar4 = (longlong *)param_5[1];
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

