FUNCTION: GolfIn::Interface::getClubPathAngle
ENTRY: 1800e0f30
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: float __cdecl GolfIn::Interface::getClubPathAngle(class cv::Point_<float>,class
   cv::Point_<float>) __ptr64 */

float __thiscall
GolfIn::Interface::getClubPathAngle(undefined8 param_1,undefined8 param_2,undefined8 param_3)

{
  float fVar1;
  double dVar2;
  undefined4 local_res20;
  undefined4 uStackX_24;
  undefined4 local_28;
  undefined4 uStack_24;
  
                    /* 0xe0f30  642  ?getClubPathAngle@Interface@GolfIn@@QEAAMV?$Point_@M@cv@@0@Z */
  uStackX_24 = (float)((ulonglong)param_3 >> 0x20);
  local_res20 = (float)param_3;
  local_28 = (float)param_2;
  uStack_24 = (float)((ulonglong)param_2 >> 0x20);
  fVar1 = atan2f(uStackX_24 - uStack_24,local_res20 - local_28);
  dVar2 = ((double)fVar1 * DAT_18017ebc0) / DAT_18017eaf0;
  if (_DAT_18017eb98 < dVar2) {
    dVar2 = DAT_18017ebc0 - dVar2;
  }
  if (dVar2 < DAT_18017ed90) {
    dVar2 = dVar2 + DAT_18017ebc0;
  }
  if (uStackX_24 < uStack_24) {
    return (float)(double)CONCAT44((uint)((ulonglong)dVar2 >> 0x20) ^ DAT_18017f130._4_4_,
                                   SUB84(dVar2,0) ^ (uint)DAT_18017f130);
  }
  return (float)dVar2;
}

