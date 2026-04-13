FUNCTION: GolfIn::Detection::ClubDetection::saveMaskResults
ENTRY: 180089e70
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: virtual void __cdecl GolfIn::Detection::ClubDetection::saveMaskResults(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,class cv::Mat const & __ptr64)const __ptr64
    */

void __thiscall
GolfIn::Detection::ClubDetection::saveMaskResults
          (ClubDetection *this,ClubDetectionInput *param_1,Mat *param_2)

{
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar1;
  char ****ppppcVar2;
  char ****ppppcVar3;
  void *pvVar4;
  longlong *plVar5;
  undefined8 uVar6;
  ClubDetection *pCVar7;
  ClubDetectionInput *pCVar8;
  undefined1 auStackY_278 [32];
  void *local_238;
  undefined8 *puStack_230;
  longlong local_228;
  longlong local_220;
  Mat *pMStack_218;
  undefined8 local_210;
  undefined8 local_208;
  longlong local_200;
  undefined8 *local_1f8;
  undefined8 local_1f0;
  int local_1e0;
  int local_1dc;
  int local_1d8;
  int local_1d4;
  char ***local_1c8 [2];
  longlong local_1b8;
  ulonglong local_1b0;
  undefined8 local_1a8;
  undefined8 uStack_1a0;
  undefined8 local_198;
  undefined8 uStack_190;
  undefined8 local_188;
  undefined8 uStack_180;
  undefined8 local_178;
  undefined8 uStack_170;
  undefined8 local_168;
  undefined8 uStack_160;
  undefined8 local_158;
  undefined8 uStack_150;
  undefined8 local_148;
  undefined8 uStack_140;
  undefined8 local_138;
  undefined8 uStack_130;
  undefined8 local_128;
  undefined8 uStack_120;
  undefined8 local_118;
  undefined8 uStack_110;
  undefined8 local_108;
  undefined8 uStack_100;
  undefined8 local_f8;
  undefined8 uStack_f0;
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
  
                    /* 0x89e70  919
                       ?saveMaskResults@ClubDetection@Detection@GolfIn@@MEBAXAEBUClubDetectionInput@23@AEBVMat@cv@@@Z
                        */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStackY_278;
  local_1a8 = 0;
  uStack_1a0 = 0;
  local_198 = 0;
  uStack_190 = 0;
  local_188 = 0;
  uStack_180 = 0;
  local_178 = 0;
  uStack_170 = 0;
  local_168 = 0;
  uStack_160 = 0;
  local_158 = 0;
  uStack_150 = 0;
  cv::Mat::Mat((Mat *)&local_1a8);
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
  local_148 = 0;
  uStack_140 = 0;
  local_138 = 0;
  uStack_130 = 0;
  local_128 = 0;
  uStack_120 = 0;
  local_118 = 0;
  uStack_110 = 0;
  local_108 = 0;
  uStack_100 = 0;
  local_f8 = 0;
  uStack_f0 = 0;
  cv::Mat::clone((Mat *)(this + 8));
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
  local_1d4 = (int)ROUND(*(float *)(this + 0x7c));
  local_1d8 = (int)ROUND(*(float *)(this + 0x78));
  local_1dc = (int)ROUND(*(float *)(this + 0x74));
  local_1e0 = (int)ROUND(*(float *)(this + 0x70));
  cv::Mat::Mat((Mat *)&local_e8,(Mat *)(param_1 + 0x28),(Rect_<int> *)&local_1e0);
  local_1f0 = 0;
  local_200._0_4_ = 0x1010000;
  local_1f8 = &local_148;
  local_228 = 0;
  local_238._0_4_ = 0x2010000;
  puStack_230 = &local_88;
  cv::Mat::copyTo((Mat *)&local_e8,(_OutputArray *)&local_238,(_InputArray *)&local_200);
  local_228 = 0;
  local_238._0_4_ = 0x2010000;
  puStack_230 = &local_148;
  local_1f0 = 0;
  local_200._0_4_ = 0x1010000;
  local_1f8 = &local_148;
  cv::cvtColor((_InputArray *)&local_200,(_OutputArray *)&local_238,8,0);
  local_228 = 0;
  local_238._0_4_ = 0x2010000;
  puStack_230 = &local_1a8;
  local_1f0 = 0;
  local_200._0_4_ = 0x1010000;
  local_1f8 = &local_88;
  local_210 = 0;
  local_220._0_4_ = 0x1010000;
  pMStack_218 = (Mat *)&local_e8;
  cv::hconcat((_InputArray *)&local_220,(_InputArray *)&local_200,(_OutputArray *)&local_238);
  local_210 = 0;
  local_220._0_4_ = 0x2010000;
  pMStack_218 = (Mat *)&local_1a8;
  local_228 = 0;
  local_238._0_4_ = 0x1010000;
  puStack_230 = &local_148;
  local_1f0 = 0;
  local_200._0_4_ = 0x1010000;
  local_1f8 = &local_1a8;
  cv::hconcat((_InputArray *)&local_200,(_InputArray *)&local_238,(_OutputArray *)&local_220);
  local_210 = 0;
  local_220 = CONCAT44(local_220._4_4_,0x2010000);
  pMStack_218 = (Mat *)&local_1a8;
  local_228 = 0;
  local_238 = (void *)CONCAT44(local_238._4_4_,0x1010000);
  puStack_230 = &local_1a8;
  uVar6 = 0;
  plVar5 = &local_220;
  cv::resize(&local_238);
  pCVar7 = this + 0x98;
  if (0x7fffffffffffffff - *(size_t *)(this + 0xa8) < 10) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  if (0xf < *(ulonglong *)(this + 0xb0)) {
    pCVar7 = *(ClubDetection **)pCVar7;
  }
  FUN_18000bff0(local_1c8,plVar5,uVar6,pCVar7,*(size_t *)(this + 0xa8),"\\detection",10);
  pMStack_218 = (Mat *)0x0;
  local_208 = 7;
  ppppcVar2 = local_1c8;
  if (0xf < local_1b0) {
    ppppcVar2 = (char ****)local_1c8[0];
  }
  ppppcVar3 = local_1c8;
  if (0xf < local_1b0) {
    ppppcVar3 = (char ****)local_1c8[0];
  }
  local_210 = 0;
  local_220 = 0;
  boost::filesystem::detail::path_traits::convert
            ((char *)ppppcVar3,(char *)((longlong)ppppcVar2 + local_1b8),
             (basic_string<wchar_t,struct_std::char_traits<wchar_t>,class_std::allocator<wchar_t>_>
              *)&local_220,(codecvt<wchar_t,char,struct__Mbstatet> *)0x0);
  boost::filesystem::detail::create_directories((path *)&local_220,(error_code *)0x0);
  FUN_180025f40(&local_220);
  local_238 = (void *)0x0;
  puStack_230 = (undefined8 *)0x0;
  local_228 = 0;
  local_210 = 0;
  local_220 = CONCAT44(local_220._4_4_,0x1010000);
  pCVar8 = param_1;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    pCVar8 = *(ClubDetectionInput **)param_1;
  }
  ppppcVar2 = local_1c8;
  if (0xf < local_1b0) {
    ppppcVar2 = (char ****)local_1c8[0];
  }
  pMStack_218 = param_2;
  pbVar1 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           cv::format((char *)&local_200,"%s\\%s_%s_%d.png",ppppcVar2,pCVar8);
  cv::imwrite(pbVar1,(_InputArray *)&local_220,(vector<int,class_std::allocator<int>_> *)&local_238)
  ;
  FUN_18000c8d0(&local_200);
  if (local_238 != (void *)0x0) {
    pvVar4 = local_238;
    if ((0xfff < (ulonglong)((local_228 - (longlong)local_238 >> 2) * 4)) &&
       (pvVar4 = *(void **)((longlong)local_238 + -8),
       0x1f < (ulonglong)((longlong)local_238 + (-8 - (longlong)pvVar4)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar4);
  }
  local_238 = (void *)0x0;
  puStack_230 = (undefined8 *)0x0;
  local_228 = 0;
  local_210 = 0;
  local_220 = CONCAT44(local_220._4_4_,0x1010000);
  pMStack_218 = (Mat *)&local_1a8;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    param_1 = *(ClubDetectionInput **)param_1;
  }
  ppppcVar2 = local_1c8;
  if (0xf < local_1b0) {
    ppppcVar2 = (char ****)local_1c8[0];
  }
  pbVar1 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           cv::format((char *)&local_200,"%s\\%s_%s_%d.png",ppppcVar2,param_1);
  cv::imwrite(pbVar1,(_InputArray *)&local_220,(vector<int,class_std::allocator<int>_> *)&local_238)
  ;
  FUN_18000c8d0(&local_200);
  if (local_238 != (void *)0x0) {
    pvVar4 = local_238;
    if ((0xfff < (ulonglong)((local_228 - (longlong)local_238 >> 2) * 4)) &&
       (pvVar4 = *(void **)((longlong)local_238 + -8),
       0x1f < (ulonglong)((longlong)local_238 + (-8 - (longlong)pvVar4)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar4);
  }
  FUN_18000c8d0((longlong *)local_1c8);
  cv::Mat::~Mat((Mat *)&local_e8);
  cv::Mat::~Mat((Mat *)&local_148);
  cv::Mat::~Mat((Mat *)&local_88);
  cv::Mat::~Mat((Mat *)&local_1a8);
  return;
}

