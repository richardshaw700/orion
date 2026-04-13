FUNCTION: GolfIn::Detection::MLClubDetection::saveMaskResults
ENTRY: 18008a4c0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: virtual void __cdecl GolfIn::Detection::MLClubDetection::saveMaskResults(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,class cv::Mat const & __ptr64)const __ptr64
    */

void __thiscall
GolfIn::Detection::MLClubDetection::saveMaskResults
          (MLClubDetection *this,ClubDetectionInput *param_1,Mat *param_2)

{
  undefined8 *puVar1;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar2;
  void *_Memory;
  MLClubDetection *pMVar3;
  MLClubDetection *pMVar4;
  undefined1 auStackY_2e8 [32];
  longlong local_2a0;
  undefined8 *puStack_298;
  undefined8 local_290;
  undefined8 local_288;
  undefined8 local_280;
  undefined8 uStack_278;
  longlong local_270;
  undefined8 uStack_268;
  longlong local_260;
  MLClubDetection *local_258;
  undefined8 local_250;
  undefined1 local_238 [16];
  Mat local_228 [96];
  Mat local_1c8 [96];
  Mat local_168 [144];
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  undefined8 uStack_c0;
  undefined8 local_b8;
  undefined8 uStack_b0;
  undefined8 local_a8;
  undefined8 uStack_a0;
  undefined4 *local_98;
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
  undefined8 local_28;
  undefined8 uStack_20;
  ulonglong local_18;
  
                    /* 0x8a4c0  920
                       ?saveMaskResults@MLClubDetection@Detection@GolfIn@@UEBAXAEBUClubDetectionInput@23@AEBVMat@cv@@@Z
                        */
  local_18 = DAT_1801d1040 ^ (ulonglong)auStackY_2e8;
  local_d8 = 0;
  uStack_d0 = 0;
  local_c8 = 0;
  uStack_c0 = 0;
  local_b8 = 0;
  uStack_b0 = 0;
  local_a8 = 0;
  uStack_a0 = 0;
  local_98 = (undefined4 *)0x0;
  uStack_90 = 0;
  local_88 = 0;
  uStack_80 = 0;
  cv::Mat::clone((Mat *)(param_1 + 0x28));
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
  local_28 = 0;
  uStack_20 = 0;
  puVar1 = (undefined8 *)cv::Mat::zeros(local_238,CONCAT44(*local_98,local_98[1]),0x10);
  FUN_18000bf80(puVar1,(Mat *)&local_78);
  cv::Mat::~Mat(local_168);
  cv::Mat::~Mat(local_1c8);
  cv::Mat::~Mat(local_228);
  local_250 = 0;
  local_260._0_4_ = 0x1010000;
  local_258 = this + 8;
  local_280 = (void *)0x0;
  uStack_278 = (undefined8 *)0x0;
  local_270 = CONCAT44(_UNK_18017eed4,_DAT_18017eed0);
  uStack_268 = CONCAT44(_UNK_18017eedc,_UNK_18017eed8);
  local_2a0._0_4_ = 0xc1020006;
  puStack_298 = &local_280;
  local_290 = 0x400000001;
  cv::Mat::setTo((Mat *)&local_78,(_InputArray *)&local_2a0,(_InputArray *)&local_260);
  local_250 = 0;
  local_260._0_4_ = 0x2010000;
  local_258 = (MLClubDetection *)&local_d8;
  local_270 = 0;
  local_280 = (void *)CONCAT44(local_280._4_4_,0x1010000);
  uStack_278 = &local_78;
  local_290 = 0;
  local_2a0._0_4_ = 0x1010000;
  puStack_298 = &local_d8;
  cv::addWeighted((_InputArray *)&local_2a0,DAT_18017eaa0,(_InputArray *)&local_280,DAT_18017ea78,
                  0.0,(_OutputArray *)&local_260,-1);
  local_280 = (void *)CONCAT44(_UNK_18017eed4,_DAT_18017eed0);
  uStack_278 = (undefined8 *)CONCAT44(_UNK_18017eedc,_UNK_18017eed8);
  local_270 = 0;
  uStack_268 = 0;
  local_290 = 0;
  local_2a0 = CONCAT44(local_2a0._4_4_,0x3010000);
  puStack_298 = &local_d8;
  cv::drawMarker(&local_2a0,
                 CONCAT44((int)ROUND(*(float *)(this + 0x6c)),(int)ROUND(*(float *)(this + 0x68))),
                 &local_280);
  pMVar4 = this + 0x98;
  puStack_298 = (undefined8 *)0x0;
  local_288 = 7;
  if (*(ulonglong *)(this + 0xb0) < 0x10) {
    pMVar3 = pMVar4 + *(longlong *)(this + 0xa8);
  }
  else {
    pMVar3 = (MLClubDetection *)(*(longlong *)pMVar4 + *(longlong *)(this + 0xa8));
    pMVar4 = *(MLClubDetection **)pMVar4;
  }
  local_290 = 0;
  local_2a0 = 0;
  boost::filesystem::detail::path_traits::convert
            ((char *)pMVar4,(char *)pMVar3,
             (basic_string<wchar_t,struct_std::char_traits<wchar_t>,class_std::allocator<wchar_t>_>
              *)&local_2a0,(codecvt<wchar_t,char,struct__Mbstatet> *)0x0);
  boost::filesystem::detail::create_directories((path *)&local_2a0,(error_code *)0x0);
  FUN_180025f40(&local_2a0);
  local_280 = (void *)0x0;
  uStack_278 = (undefined8 *)0x0;
  local_270 = 0;
  local_290 = 0;
  local_2a0 = CONCAT44(local_2a0._4_4_,0x1010000);
  puStack_298 = &local_d8;
  if (0xf < *(ulonglong *)(param_1 + 0x18)) {
    param_1 = *(ClubDetectionInput **)param_1;
  }
  pMVar4 = this + 0x98;
  if (0xf < *(ulonglong *)(this + 0xb0)) {
    pMVar4 = *(MLClubDetection **)pMVar4;
  }
  pbVar2 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           cv::format((char *)&local_260,"%s\\%s_%s_%d.png",pMVar4,param_1);
  cv::imwrite(pbVar2,(_InputArray *)&local_2a0,(vector<int,class_std::allocator<int>_> *)&local_280)
  ;
  FUN_18000c8d0(&local_260);
  if (local_280 != (void *)0x0) {
    _Memory = local_280;
    if ((0xfff < (ulonglong)((local_270 - (longlong)local_280 >> 2) * 4)) &&
       (_Memory = *(void **)((longlong)local_280 + -8),
       0x1f < (ulonglong)((longlong)local_280 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(_Memory);
  }
  cv::Mat::~Mat((Mat *)&local_78);
  cv::Mat::~Mat((Mat *)&local_d8);
  return;
}

