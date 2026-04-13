FUNCTION: GolfIn::Detection::ClubDetectionInput::ClubDetectionInput
ENTRY: 180085970
REASONS: name:club


/* public: __cdecl GolfIn::Detection::ClubDetectionInput::ClubDetectionInput(struct
   GolfIn::Detection::ClubDetectionInput && __ptr64) __ptr64 */

ClubDetectionInput * __thiscall
GolfIn::Detection::ClubDetectionInput::ClubDetectionInput
          (ClubDetectionInput *this,ClubDetectionInput *param_1)

{
  undefined8 uVar1;
  
                    /* 0x85970  35  ??0ClubDetectionInput@Detection@GolfIn@@QEAA@$$QEAU012@@Z */
  *(undefined8 *)this = 0;
  *(undefined8 *)(this + 8) = 0;
  *(undefined8 *)(this + 0x10) = 0;
  *(undefined8 *)(this + 0x18) = 0;
  uVar1 = *(undefined8 *)(param_1 + 8);
  *(undefined8 *)this = *(undefined8 *)param_1;
  *(undefined8 *)(this + 8) = uVar1;
  uVar1 = *(undefined8 *)(param_1 + 0x18);
  *(undefined8 *)(this + 0x10) = *(undefined8 *)(param_1 + 0x10);
  *(undefined8 *)(this + 0x18) = uVar1;
  *(undefined8 *)(param_1 + 0x10) = 0;
  *(undefined8 *)(param_1 + 0x18) = 0xf;
  *param_1 = (ClubDetectionInput)0x0;
  *(undefined4 *)(this + 0x20) = *(undefined4 *)(param_1 + 0x20);
  cv::Mat::Mat((Mat *)(this + 0x28),(Mat *)(param_1 + 0x28));
  cv::Mat::Mat((Mat *)(this + 0x88),(Mat *)(param_1 + 0x88));
  *(undefined8 *)(this + 0xe8) = *(undefined8 *)(param_1 + 0xe8);
  *(undefined4 *)(this + 0xf0) = *(undefined4 *)(param_1 + 0xf0);
  uVar1 = *(undefined8 *)(param_1 + 0xfc);
  *(undefined8 *)(this + 0xf4) = *(undefined8 *)(param_1 + 0xf4);
  *(undefined8 *)(this + 0xfc) = uVar1;
  *(undefined4 *)(this + 0x104) = *(undefined4 *)(param_1 + 0x104);
  this[0x108] = param_1[0x108];
  this[0x109] = param_1[0x109];
  *(undefined4 *)(this + 0x10c) = *(undefined4 *)(param_1 + 0x10c);
  return this;
}

