FUNCTION: GolfIn::Interface::getClubPathAngle
ENTRY: 1800e0fe0
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: float __cdecl GolfIn::Interface::getClubPathAngle(class cv::Point3_<float>,class
   cv::Point3_<float>) __ptr64 */

float __thiscall
GolfIn::Interface::getClubPathAngle(undefined8 param_1,float *param_2,float *param_3)

{
  float fVar1;
  float fVar2;
  float fVar3;
  double dVar4;
  
                    /* 0xe0fe0  641  ?getClubPathAngle@Interface@GolfIn@@QEAAMV?$Point3_@M@cv@@0@Z
                        */
  fVar1 = param_3[1];
  fVar2 = param_2[1];
  fVar3 = atan2f(fVar1 - fVar2,*param_3 - *param_2);
  dVar4 = ((double)fVar3 * DAT_18017ebc0) / DAT_18017eaf0;
  if (_DAT_18017eb98 < dVar4) {
    dVar4 = DAT_18017ebc0 - dVar4;
  }
  if (dVar4 < DAT_18017ed90) {
    dVar4 = dVar4 + DAT_18017ebc0;
  }
  if (fVar1 < fVar2) {
    return (float)(double)CONCAT44((uint)((ulonglong)dVar4 >> 0x20) ^ DAT_18017f130._4_4_,
                                   SUB84(dVar4,0) ^ (uint)DAT_18017f130);
  }
  return (float)dVar4;
}

