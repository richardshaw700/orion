FUNCTION: GolfIn::Detection::ClubDetection::isDetectionValid
ENTRY: 1800864f0
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: bool __cdecl GolfIn::Detection::ClubDetection::isDetectionValid(void)const __ptr64 */

bool __thiscall GolfIn::Detection::ClubDetection::isDetectionValid(ClubDetection *this)

{
  bool bVar1;
  
                    /* 0x864f0  736  ?isDetectionValid@ClubDetection@Detection@GolfIn@@QEBA_NXZ */
  if ((((*(longlong *)(this + 0x18) != 0) && (bVar1 = cv::Mat::empty((Mat *)(this + 8)), !bVar1)) &&
      ((*(float *)(this + 0x68) != DAT_1801d1160 || (*(float *)(this + 0x6c) != DAT_1801d1164)))) &&
     ((((*(float *)(this + 0x70) != _DAT_1801d1168 || (*(float *)(this + 0x74) != _DAT_1801d116c))
       || (*(float *)(this + 0x78) != _DAT_1801d1170)) ||
      (*(float *)(this + 0x7c) != _DAT_1801d1174)))) {
    return true;
  }
  return false;
}

