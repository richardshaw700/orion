FUNCTION: GolfIn::Detection::ClubDetection::extractMaskREMBG
ENTRY: 180088380
REASONS: name:club; string:Club.Detection


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: void __cdecl GolfIn::Detection::ClubDetection::extractMaskREMBG(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,class cv::Mat & __ptr64) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::extractMaskREMBG
          (ClubDetection *this,ClubDetectionInput *param_1,Mat *param_2)

{
  Parameters *pPVar1;
  longlong lVar2;
  longlong lVar3;
  bool bVar4;
  Parameter *pPVar5;
  longlong *plVar6;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar7;
  Mat *pMVar8;
  undefined1 auStack_168 [32];
  float local_148;
  int iStack_144;
  int local_140;
  int local_13c;
  undefined8 local_130;
  Mat local_128 [96];
  Mat local_c8 [96];
  float local_68 [2];
  ClubDetectionInput *local_60;
  Mat *pMStack_58;
  ClubDetection *local_50;
  int *piStack_48;
  float *local_40;
  int local_38 [2];
  ulonglong local_30;
  
                    /* 0x88380  571
                       ?extractMaskREMBG@ClubDetection@Detection@GolfIn@@IEAAXAEBUClubDetectionInput@23@AEAVMat@cv@@@Z
                        */
  local_30 = DAT_1801d1040 ^ (ulonglong)auStack_168;
  if (*(longlong *)(this + 0xc0) != 0) {
    local_130._0_4_ = 0x1e;
    local_60 = (ClubDetectionInput *)0x0;
    pMStack_58 = (Mat *)0x0;
    local_50 = (ClubDetection *)0x0;
    piStack_48 = (int *)0x0;
    FUN_18000c1d0(&local_60,"Configurations.Process.Club.Detection.REMBGMinMaskConsideredValue",0x41
                 );
    pPVar1 = *(Parameters **)(this + 0xb8);
    bVar4 = Libraries::Core::Parameters::exist
                      (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_60);
    if (bVar4) {
      pPVar5 = Libraries::Core::Parameters::get
                         (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_60);
      local_38[0] = Libraries::Core::Parameter::toInt(pPVar5);
    }
    else {
      pPVar5 = Libraries::Core::Parameters::get
                         (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_60);
      Libraries::Core::Parameter::setValue(pPVar5,(int *)&local_130);
      pPVar5 = Libraries::Core::Parameters::get
                         (*(Parameters **)(this + 0xb8),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_60);
      local_38[0] = Libraries::Core::Parameter::toInt(pPVar5);
      local_148 = 1.4013e-45;
      Libraries::Core::Parameters::saveToFile
                (*(Parameters **)(this + 0xb8),
                 (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                 (this + 0xd8),(DataFormat *)&local_148);
    }
    FUN_18000c8d0((longlong *)&local_60);
    local_148 = 0.5;
    local_60 = (ClubDetectionInput *)0x0;
    pMStack_58 = (Mat *)0x0;
    local_50 = (ClubDetection *)0x0;
    piStack_48 = (int *)0x0;
    FUN_18000c1d0(&local_60,"Configurations.Process.Club.Detection.REMBGStddevVariationFactor",0x40)
    ;
    pPVar1 = *(Parameters **)(this + 0xb8);
    bVar4 = Libraries::Core::Parameters::exist
                      (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_60);
    if (bVar4) {
      pPVar5 = Libraries::Core::Parameters::get
                         (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_60);
      local_68[0] = Libraries::Core::Parameter::toFloat(pPVar5);
    }
    else {
      pPVar5 = Libraries::Core::Parameters::get
                         (pPVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_60);
      Libraries::Core::Parameter::setValue(pPVar5,&local_148,3);
      pPVar5 = Libraries::Core::Parameters::get
                         (*(Parameters **)(this + 0xb8),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_60);
      local_68[0] = Libraries::Core::Parameter::toFloat(pPVar5);
      local_148 = 1.4013e-45;
      Libraries::Core::Parameters::saveToFile
                (*(Parameters **)(this + 0xb8),
                 (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                 (this + 0xd8),(DataFormat *)&local_148);
    }
    FUN_18000c8d0((longlong *)&local_60);
    piStack_48 = local_38;
    local_60 = param_1;
    pMStack_58 = param_2;
    local_50 = this;
    local_40 = local_68;
    FUN_1800090b0(&local_130);
    FUN_180088680((longlong *)&local_60);
    FUN_1800090b0((longlong *)&local_148);
    lVar2 = CONCAT44(iStack_144,local_148);
    lVar3 = CONCAT44(local_130._4_4_,(int)local_130);
    plVar6 = FUN_1800014c0();
    pbVar7 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)&local_60,"[Club.Head] Time taken for %s : %f ms",
                        "ClubDetection::extractMaskREMBG",(double)(lVar2 - lVar3) / DAT_18017ec30);
    FUN_180084c00(plVar6,pbVar7,1,'\x01');
    local_13c = (int)ROUND(*(float *)(this + 0x7c));
    local_140 = (int)ROUND(*(float *)(this + 0x78));
    iStack_144 = (int)ROUND(*(float *)(this + 0x74));
    local_148 = (float)(int)ROUND(*(float *)(this + 0x70));
    cv::Mat::Mat(local_128,param_2,(Rect_<int> *)&local_148);
    pMVar8 = (Mat *)cv::Mat::clone(local_128);
    cv::Mat::operator=((Mat *)(this + 8),pMVar8);
    cv::Mat::~Mat(local_c8);
    cv::Mat::~Mat(local_128);
    return;
  }
  FUN_180009760((undefined8 *)&local_148,"DNN Service is not initialized.");
                    /* WARNING: Subroutine does not return */
  _CxxThrowException(&local_148,(ThrowInfo *)&DAT_1801a9018);
}

