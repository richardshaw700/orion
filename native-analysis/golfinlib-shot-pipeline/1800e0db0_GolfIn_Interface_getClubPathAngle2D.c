FUNCTION: GolfIn::Interface::getClubPathAngle2D
ENTRY: 1800e0db0
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: float __cdecl GolfIn::Interface::getClubPathAngle2D(class cv::Point_<float>,class
   cv::Point_<float>,class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const & __ptr64) __ptr64 */

float __thiscall
GolfIn::Interface::getClubPathAngle2D
          (undefined8 param_1,undefined8 param_2,Interface *param_3,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_4)

{
  double dVar1;
  float fVar2;
  Interface *pIVar3;
  float fVar4;
  float fVar5;
  float local_68;
  float fStack_64;
  undefined8 local_60;
  longlong local_58 [10];
  
                    /* 0xe0db0  640
                       ?getClubPathAngle2D@Interface@GolfIn@@QEAAMV?$Point_@M@cv@@0AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z
                        */
  local_60._4_4_ = (float)((ulonglong)param_3 >> 0x20);
  fVar2 = local_60._4_4_;
  fStack_64 = (float)((ulonglong)param_2 >> 0x20);
  fVar5 = local_60._4_4_ - fStack_64;
  local_60._0_4_ = SUB84(param_3,0);
  local_68 = (float)param_2;
  local_68 = (float)local_60 - local_68;
  local_60 = param_3;
  if (instance_ == (Interface *)0x0) {
    pIVar3 = (Interface *)FUN_1801327e0(0x908);
    local_60 = pIVar3;
    memset(pIVar3,0,0x908);
    instance_ = (Interface *)Interface(pIVar3);
  }
  pIVar3 = instance_;
  local_58[0] = 0;
  local_58[1] = 0;
  local_58[2] = 0;
  local_58[3] = 0;
  FUN_18000c1d0(local_58,&DAT_180174494,2);
  getTarget2D(pIVar3,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_60,param_4);
  FUN_18000c8d0(local_58);
  fVar5 = atan2f(local_68,fVar5);
  fVar4 = atan2f((float)local_60,local_60._4_4_);
  dVar1 = (((double)fVar5 - (double)fVar4) * DAT_18017ebc0) / DAT_18017eaf0;
  if (_DAT_18017eb98 < dVar1) {
    dVar1 = DAT_18017ebc0 - dVar1;
  }
  if (dVar1 < DAT_18017ed90) {
    dVar1 = dVar1 + DAT_18017ebc0;
  }
  if (fStack_64 < fVar2) {
    dVar1 = (double)CONCAT44((uint)((ulonglong)dVar1 >> 0x20) ^ DAT_18017f130._4_4_,
                             SUB84(dVar1,0) ^ (uint)DAT_18017f130);
  }
  return (float)dVar1;
}

