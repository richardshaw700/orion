FUNCTION: GolfIn::Detection::ClubDetectionInput::validateInput
ENTRY: 180085760
REASONS: name:club


/* public: bool __cdecl GolfIn::Detection::ClubDetectionInput::validateInput(void)const __ptr64 */

bool __thiscall GolfIn::Detection::ClubDetectionInput::validateInput(ClubDetectionInput *this)

{
  bool bVar1;
  
                    /* 0x85760  1053  ?validateInput@ClubDetectionInput@Detection@GolfIn@@QEBA_NXZ
                        */
  bVar1 = cv::Mat::empty((Mat *)(this + 0x28));
  if ((((!bVar1) && (bVar1 = cv::Mat::empty((Mat *)(this + 0x88)), !bVar1)) &&
      ((*(float *)(this + 0xe8) != DAT_1801d1160 || (*(float *)(this + 0xec) != DAT_1801d1164)))) &&
     ((*(int *)(this + 0xf0) != -1 && (*(float *)(this + 0x104) != DAT_18017ed38)))) {
    return true;
  }
  return false;
}

