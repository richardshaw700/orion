FUNCTION: GolfIn::Detection::ClubDetection::extractMaskMOG2
ENTRY: 1800879b0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: void __cdecl GolfIn::Detection::ClubDetection::extractMaskMOG2(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,class cv::Mat & __ptr64) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::extractMaskMOG2
          (ClubDetection *this,ClubDetectionInput *param_1,Mat *param_2)

{
  longlong *plVar1;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar2;
  Mat *pMVar3;
  double in_XMM1_Qa;
  undefined1 auStack_188 [32];
  longlong local_168;
  longlong local_160;
  undefined8 local_158 [2];
  ClubDetectionInput *local_148;
  ClubDetection *local_140;
  Mat *local_138;
  undefined8 *local_130;
  undefined8 *local_128;
  Mat *local_120;
  undefined8 local_e8;
  undefined8 uStack_e0;
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  undefined8 uStack_c0;
  undefined8 local_b8;
  undefined8 uStack_b0;
  undefined8 local_a8;
  undefined8 uStack_a0;
  undefined8 local_98;
  undefined8 uStack_90;
  undefined8 local_88;
  undefined8 uStack_80;
  undefined8 local_78;
  undefined8 uStack_70;
  undefined8 local_68;
  undefined8 uStack_60;
  undefined8 local_58;
  undefined8 uStack_50;
  undefined8 local_48;
  undefined8 uStack_40;
  undefined8 local_38;
  undefined8 uStack_30;
  ulonglong local_28;
  
                    /* 0x879b0  570
                       ?extractMaskMOG2@ClubDetection@Detection@GolfIn@@IEAAXAEBUClubDetectionInput@23@AEAVMat@cv@@@Z
                        */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStack_188;
  local_88 = 0;
  uStack_80 = 0;
  local_78 = 0;
  uStack_70 = 0;
  local_68 = 0;
  uStack_60 = 0;
  local_58 = 0;
  uStack_50 = 0;
  local_48 = 0;
  uStack_40 = 0;
  local_38 = 0;
  uStack_30 = 0;
  cv::Mat::Mat((Mat *)&local_88);
  local_e8 = 0;
  uStack_e0 = 0;
  local_d8 = 0;
  uStack_d0 = 0;
  local_c8 = 0;
  uStack_c0 = 0;
  local_b8 = 0;
  uStack_b0 = 0;
  local_a8 = 0;
  uStack_a0 = 0;
  local_98 = 0;
  uStack_90 = 0;
  cv::Mat::Mat((Mat *)&local_e8);
  local_158[0] = DAT_18017eb28;
  local_130 = &local_e8;
  local_128 = local_158;
  local_148 = param_1;
  local_140 = this;
  local_138 = (Mat *)&local_88;
  local_120 = param_2;
  FUN_1800090b0(&local_168);
  FUN_180087b40(&local_148,in_XMM1_Qa);
  FUN_1800090b0(&local_160);
  plVar1 = FUN_1800014c0();
  pbVar2 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           cv::format((char *)&local_148,"[Club.Head] Time taken for %s : %f ms",
                      "ClubDetection::extractMaskMOG2",
                      (double)(local_160 - local_168) / DAT_18017ec30);
  FUN_180084c00(plVar1,pbVar2,1,'\x01');
  pMVar3 = (Mat *)cv::Mat::clone(param_2);
  cv::Mat::operator=((Mat *)(this + 8),pMVar3);
  cv::Mat::~Mat((Mat *)&local_148);
  cv::Mat::~Mat((Mat *)&local_e8);
  cv::Mat::~Mat((Mat *)&local_88);
  return;
}

