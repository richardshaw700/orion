FUNCTION: GolfIn::Detection::ClubDetection::saveImageMaskAreaSquareMM
ENTRY: 18008a8e0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: void __cdecl GolfIn::Detection::ClubDetection::saveImageMaskAreaSquareMM(class cv::Mat
   const & __ptr64,int)const __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::saveImageMaskAreaSquareMM
          (ClubDetection *this,Mat *param_1,int param_2)

{
  int iVar1;
  int iVar2;
  undefined8 *puVar3;
  longlong *plVar4;
  void *_Memory;
  longlong lVar5;
  undefined8 uVar6;
  ClubDetection *pCVar7;
  undefined1 auStackY_208 [32];
  undefined4 local_1b0 [2];
  undefined8 *local_1a8;
  undefined8 local_1a0;
  undefined4 local_198 [2];
  Mat *local_190;
  undefined8 local_188;
  void *local_180;
  undefined8 uStack_178;
  longlong local_170;
  longlong local_168;
  longlong lStack_160;
  longlong local_158;
  longlong lStack_150;
  longlong local_148;
  longlong lStack_140;
  longlong local_138;
  longlong lStack_130;
  undefined8 local_128;
  undefined8 uStack_120;
  undefined8 local_118;
  undefined8 uStack_110;
  longlong local_108 [4];
  longlong local_e8 [4];
  longlong local_c8 [4];
  longlong local_a8 [4];
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
  
                    /* 0x8a8e0  918
                       ?saveImageMaskAreaSquareMM@ClubDetection@Detection@GolfIn@@IEBAXAEBVMat@cv@@H@Z
                        */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStackY_208;
  iVar1 = **(int **)(param_1 + 0x40);
  iVar2 = (*(int **)(param_1 + 0x40))[1];
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
  local_1a0 = 0;
  local_1b0[0] = 0x2010000;
  local_1a8 = &local_88;
  local_188 = 0;
  local_198[0] = 0x1010000;
  local_190 = param_1;
  cv::cvtColor((_InputArray *)local_198,(_OutputArray *)local_1b0,8,0);
  local_128 = 0;
  uStack_120 = 0;
  local_118 = _DAT_18017eed0;
  uStack_110 = _UNK_18017eed8;
  puVar3 = FUN_18000c2d0(local_c8,param_2);
  plVar4 = FUN_180007680(puVar3,0,"Area square mm : ",0x11);
  local_168 = *plVar4;
  lStack_160 = plVar4[1];
  local_158 = plVar4[2];
  lStack_150 = plVar4[3];
  plVar4[2] = 0;
  plVar4[3] = 0xf;
  *(undefined1 *)plVar4 = 0;
  local_188 = 0;
  local_198[0] = 0x3010000;
  local_190 = (Mat *)&local_88;
  uVar6 = CONCAT44(iVar1 + -0x14,iVar2 / 2 + -0x28);
  cv::putText(local_198,&local_168,uVar6,0);
  FUN_18000c8d0(&local_168);
  FUN_18000c8d0(local_c8);
  local_180 = (void *)0x0;
  uStack_178 = 0;
  local_170 = 0;
  local_1a0 = 0;
  local_1b0[0] = 0x1010000;
  local_1a8 = &local_88;
  puVar3 = FUN_18000c2d0(local_a8,param_2);
  pCVar7 = this + 0x98;
  lVar5 = *(longlong *)(this + 0xa8);
  if (0x7fffffffffffffffU - lVar5 < 6) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  if (0xf < *(ulonglong *)(this + 0xb0)) {
    pCVar7 = *(ClubDetection **)pCVar7;
  }
  FUN_18000bff0(local_e8,lVar5,uVar6,pCVar7,lVar5,"\\Club_",6);
  FUN_1800228c0(local_108,lVar5,local_e8,puVar3);
  plVar4 = FUN_18000a490(local_108,&DAT_180169b38,4);
  local_148 = *plVar4;
  lStack_140 = plVar4[1];
  local_138 = plVar4[2];
  lStack_130 = plVar4[3];
  plVar4[2] = 0;
  plVar4[3] = 0xf;
  *(undefined1 *)plVar4 = 0;
  cv::imwrite((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_148,(_InputArray *)local_1b0,
              (vector<int,class_std::allocator<int>_> *)&local_180);
  FUN_18000c8d0(&local_148);
  FUN_18000c8d0(local_108);
  FUN_18000c8d0(local_e8);
  FUN_18000c8d0(local_a8);
  if (local_180 != (void *)0x0) {
    _Memory = local_180;
    if ((0xfff < (ulonglong)((local_170 - (longlong)local_180 >> 2) * 4)) &&
       (_Memory = *(void **)((longlong)local_180 + -8),
       0x1f < (ulonglong)((longlong)local_180 + (-8 - (longlong)_Memory)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(_Memory);
  }
  cv::Mat::~Mat((Mat *)&local_88);
  return;
}

