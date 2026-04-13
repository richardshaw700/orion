FUNCTION: GolfIn::Detection::ClubDetectionInput::ClubDetectionInput
ENTRY: 1800857e0
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: __cdecl GolfIn::Detection::ClubDetectionInput::ClubDetectionInput(void) __ptr64 */

ClubDetectionInput * __thiscall
GolfIn::Detection::ClubDetectionInput::ClubDetectionInput(ClubDetectionInput *this)

{
  undefined8 uVar1;
  undefined8 uVar2;
  
                    /* 0x857e0  38  ??0ClubDetectionInput@Detection@GolfIn@@QEAA@XZ */
  *(undefined8 *)this = 0;
  *(undefined8 *)(this + 8) = 0;
  *(undefined8 *)(this + 0x10) = 0;
  *(undefined8 *)(this + 0x18) = 0;
  FUN_18000c1d0((undefined8 *)this,&DAT_18016a0f8,0);
  *(undefined4 *)(this + 0x20) = 0xffffffff;
  cv::Mat::Mat((Mat *)(this + 0x28));
  cv::Mat::Mat((Mat *)(this + 0x88));
  *(undefined4 *)(this + 0xe8) = DAT_1801d1160;
  *(undefined4 *)(this + 0xec) = DAT_1801d1164;
  *(undefined4 *)(this + 0xf0) = 0xffffffff;
  uVar2 = _UNK_18016d040;
  uVar1 = _DAT_18016d038;
  *(undefined4 *)(this + 0x104) = 0xbf800000;
  *(undefined2 *)(this + 0x108) = 0;
  *(undefined8 *)(this + 0xf4) = uVar1;
  *(undefined8 *)(this + 0xfc) = uVar2;
  *(undefined4 *)(this + 0x10c) = 1;
  return this;
}

