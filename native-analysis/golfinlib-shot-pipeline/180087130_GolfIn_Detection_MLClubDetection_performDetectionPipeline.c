FUNCTION: GolfIn::Detection::MLClubDetection::performDetectionPipeline
ENTRY: 180087130
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: virtual void __cdecl GolfIn::Detection::MLClubDetection::performDetectionPipeline(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64) __ptr64 */

void __thiscall
GolfIn::Detection::MLClubDetection::performDetectionPipeline
          (MLClubDetection *this,ClubDetectionInput *param_1)

{
  double dVar1;
  longlong *plVar2;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar3;
  char *pcVar4;
  undefined1 auStack_118 [32];
  longlong local_f8;
  longlong local_f0;
  ClubDetectionInput *local_e8;
  MLClubDetection *local_e0;
  longlong local_d0 [4];
  MLClubDetection *local_b0;
  undefined8 *local_a8;
  longlong *local_a0;
  ClubDetectionInput *local_98;
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
  
                    /* 0x87130  850
                       ?performDetectionPipeline@MLClubDetection@Detection@GolfIn@@UEAAXAEBUClubDetectionInput@23@@Z
                        */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStack_118;
  *(undefined4 *)(this + 0x80) = *(undefined4 *)(param_1 + 0x20);
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
  local_e8 = param_1;
  local_e0 = this;
  cv::Mat::clone((Mat *)(param_1 + 0x28));
  local_d0[0] = 0;
  local_d0[1] = 0;
  local_d0[2] = 0;
  local_a8 = &local_88;
  local_a0 = local_d0;
  local_b0 = this;
  local_98 = param_1;
  FUN_1800090b0(&local_f8);
  FUN_1800872b0((longlong *)&local_b0);
  FUN_1800090b0(&local_f0);
  dVar1 = (double)(local_f0 - local_f8) / DAT_18017ec30;
  plVar2 = FUN_1800014c0();
  pcVar4 = "fallback previous algo";
  if (this[0x90] == (MLClubDetection)0x0) {
    pcVar4 = "Yolov8 club segmentation inference";
  }
  pbVar3 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           cv::format((char *)&local_b0,"[ML.Club.Head] Time taken for %s : %f ms",pcVar4,
                      SUB84(dVar1,0));
  FUN_180084c00(plVar2,pbVar3,1,'\x01');
  FUN_18008d630(local_d0);
  cv::Mat::~Mat((Mat *)&local_88);
  return;
}

