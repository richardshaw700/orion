FUNCTION: GolfIn::Detection::ClubDetection::extractMaskHED
ENTRY: 180087f70
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: void __cdecl GolfIn::Detection::ClubDetection::extractMaskHED(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,class cv::Mat & __ptr64) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::extractMaskHED
          (ClubDetection *this,ClubDetectionInput *param_1,Mat *param_2)

{
  longlong *plVar1;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar2;
  Mat *pMVar3;
  undefined1 auStackY_1d8 [32];
  undefined8 local_1a8;
  int local_1a0;
  int local_19c;
  longlong local_198;
  undefined4 local_190 [2];
  undefined8 *local_188;
  undefined8 local_180;
  Mat local_178 [96];
  Mat local_118 [96];
  ClubDetectionInput *local_b8;
  Mat *local_b0;
  ClubDetection *local_a8;
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
  ulonglong local_38;
  
                    /* 0x87f70  569
                       ?extractMaskHED@ClubDetection@Detection@GolfIn@@IEAAXAEBUClubDetectionInput@23@AEAVMat@cv@@@Z
                        */
  local_38 = DAT_1801d1040 ^ (ulonglong)auStackY_1d8;
  if (*(longlong *)(this + 0xc0) != 0) {
    local_b8 = param_1;
    local_b0 = param_2;
    local_a8 = this;
    FUN_1800090b0(&local_1a8);
    FUN_180088180((longlong *)&local_b8);
    FUN_1800090b0(&local_198);
    plVar1 = FUN_1800014c0();
    pbVar2 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)&local_b8,"[Club.Head] Time taken for %s : %f ms",
                        "ClubDetection::extractMaskHED",
                        (double)(local_198 - CONCAT44(local_1a8._4_4_,(int)local_1a8)) /
                        DAT_18017ec30);
    FUN_180084c00(plVar1,pbVar2,1,'\x01');
    local_98 = 0;
    uStack_90 = 0;
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
    local_19c = (int)ROUND(*(float *)(this + 0x7c));
    local_1a0 = (int)ROUND(*(float *)(this + 0x78));
    local_1a8._4_4_ = (int)ROUND(*(float *)(this + 0x74));
    local_1a8._0_4_ = (int)ROUND(*(float *)(this + 0x70));
    cv::Mat::Mat(local_178,param_2,(Rect_<int> *)&local_1a8);
    cv::Mat::clone(local_178);
    cv::Mat::~Mat(local_178);
    local_180 = 0;
    local_190[0] = 0x2010000;
    local_188 = &local_98;
    local_a8 = (ClubDetection *)0x0;
    local_b8 = (ClubDetectionInput *)CONCAT44(local_b8._4_4_,0x1010000);
    local_b0 = (Mat *)&local_98;
    cv::Canny((_InputArray *)&local_b8,(_OutputArray *)local_190,DAT_18017eb28,DAT_18017eba8,3,false
             );
    *(undefined4 *)(this + 0x208) = 0x40a00000;
    pMVar3 = (Mat *)cv::Mat::clone((Mat *)&local_98);
    cv::Mat::operator=((Mat *)(this + 8),pMVar3);
    cv::Mat::~Mat(local_118);
    cv::Mat::~Mat((Mat *)&local_98);
    return;
  }
  FUN_180009760(&local_b8,"DNN Service is not initialized.");
                    /* WARNING: Subroutine does not return */
  _CxxThrowException(&local_b8,(ThrowInfo *)&DAT_1801a9018);
}

