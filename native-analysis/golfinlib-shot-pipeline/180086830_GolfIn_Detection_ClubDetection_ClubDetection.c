FUNCTION: GolfIn::Detection::ClubDetection::ClubDetection
ENTRY: 180086830
REASONS: name:club


/* public: __cdecl GolfIn::Detection::ClubDetection::ClubDetection(class
   GolfIn::Detection::ClubDetection const & __ptr64) __ptr64 */

ClubDetection * __thiscall
GolfIn::Detection::ClubDetection::ClubDetection(ClubDetection *this,ClubDetection *param_1)

{
  int *piVar1;
  undefined8 uVar2;
  
                    /* 0x86830  31  ??0ClubDetection@Detection@GolfIn@@QEAA@AEBV012@@Z */
  *(undefined ***)this = vftable;
  cv::Mat::Mat((Mat *)(this + 8),(Mat *)(param_1 + 8));
  *(undefined8 *)(this + 0x68) = *(undefined8 *)(param_1 + 0x68);
  uVar2 = *(undefined8 *)(param_1 + 0x78);
  *(undefined8 *)(this + 0x70) = *(undefined8 *)(param_1 + 0x70);
  *(undefined8 *)(this + 0x78) = uVar2;
  *(undefined4 *)(this + 0x80) = *(undefined4 *)(param_1 + 0x80);
  *(undefined4 *)(this + 0x84) = *(undefined4 *)(param_1 + 0x84);
  *(undefined4 *)(this + 0x88) = *(undefined4 *)(param_1 + 0x88);
  *(undefined4 *)(this + 0x8c) = *(undefined4 *)(param_1 + 0x8c);
  this[0x90] = param_1[0x90];
  FUN_18000cb00((undefined8 *)(this + 0x98),(undefined8 *)(param_1 + 0x98));
  *(undefined8 *)(this + 0xb8) = *(undefined8 *)(param_1 + 0xb8);
  *(undefined8 *)(this + 0xc0) = 0;
  *(undefined8 *)(this + 200) = 0;
  if (*(longlong *)(param_1 + 200) != 0) {
    LOCK();
    piVar1 = (int *)(*(longlong *)(param_1 + 200) + 8);
    *piVar1 = *piVar1 + 1;
    UNLOCK();
  }
  *(undefined8 *)(this + 0xc0) = *(undefined8 *)(param_1 + 0xc0);
  *(undefined8 *)(this + 200) = *(undefined8 *)(param_1 + 200);
  this[0xd0] = param_1[0xd0];
  FUN_18000cb00((undefined8 *)(this + 0xd8),(undefined8 *)(param_1 + 0xd8));
  ClubDetectionInput::ClubDetectionInput
            ((ClubDetectionInput *)(this + 0xf8),(ClubDetectionInput *)(param_1 + 0xf8));
  *(undefined4 *)(this + 0x208) = *(undefined4 *)(param_1 + 0x208);
  return this;
}

