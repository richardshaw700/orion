FUNCTION: GolfIn::Detection::MLClubDetection::computeClubType
ENTRY: 18008cd10
REASONS: name:club; string:Club.Detection


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: virtual bool __cdecl GolfIn::Detection::MLClubDetection::computeClubType(class
   GolfIn::Detection::ClubDetection const & __ptr64,float,bool) __ptr64 */

bool __thiscall
GolfIn::Detection::MLClubDetection::computeClubType
          (MLClubDetection *this,ClubDetection *param_1,float param_2,bool param_3)

{
  undefined8 *puVar1;
  bool bVar2;
  uint uVar3;
  undefined4 uVar4;
  int iVar5;
  int iVar6;
  longlong *plVar7;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar8;
  float *pfVar9;
  longlong lVar10;
  Mat **ppMVar11;
  longlong lVar12;
  code *pcVar13;
  float fVar14;
  float fVar15;
  float fVar16;
  undefined1 auStack_1c8 [32];
  undefined8 local_1a8;
  undefined8 ******local_188;
  MLClubDetection *pMStack_180;
  undefined8 local_178;
  ulonglong local_170;
  float local_168;
  MLClubDetection *local_160;
  ClubDetection *local_158;
  undefined8 local_150;
  undefined8 uStack_148;
  undefined8 local_140;
  undefined8 uStack_138;
  undefined8 local_130;
  Mat *pMStack_128;
  undefined **local_120;
  undefined8 uStack_118;
  char local_108 [32];
  Mat local_e8 [96];
  Mat *local_88;
  undefined8 local_80;
  undefined8 *local_78;
  undefined8 uStack_70;
  undefined8 local_68;
  ulonglong local_58;
  
                    /* 0x8cd10  465
                       ?computeClubType@MLClubDetection@Detection@GolfIn@@UEAA_NAEBVClubDetection@23@M_N@Z
                        */
  local_58 = DAT_1801d1040 ^ (ulonglong)auStack_1c8;
  if (param_3) {
    *(undefined4 *)(this + 0x84) = 6;
    return true;
  }
  local_168 = param_2;
  local_160 = this;
  local_158 = param_1;
  if (*(longlong *)(this + 0x210) == 0) {
    plVar7 = FUN_1800014c0();
    pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             cv::format((char *)&local_78,
                        "Error during club classification model has not been loaded. Falling into the old method."
                       );
    FUN_180084c00(plVar7,pbVar8,3,'\x01');
    bVar2 = ClubDetection::computeClubType((ClubDetection *)this,param_1,param_2,false);
    return bVar2;
  }
  FUN_1800090b0(&local_80);
  local_78 = (undefined8 *)0x0;
  uStack_70 = 0;
  local_68 = 0;
  puVar1 = *(undefined8 **)(this + 0x210);
  pcVar13 = *(code **)*puVar1;
  local_150 = 0;
  uStack_148 = 0;
  local_140 = 0;
  uStack_138 = 0;
  local_130 = 0;
  pMStack_128 = (Mat *)0x0;
  local_120 = (undefined **)0x0;
  uStack_118 = 0;
  local_88 = (Mat *)FUN_1801327e0(0x60);
  *(undefined8 *)local_88 = 0;
  *(undefined8 *)(local_88 + 8) = 0;
  *(undefined8 *)(local_88 + 0x10) = 0;
  *(undefined8 *)(local_88 + 0x18) = 0;
  *(undefined8 *)(local_88 + 0x20) = 0;
  *(undefined8 *)(local_88 + 0x28) = 0;
  *(undefined8 *)(local_88 + 0x30) = 0;
  *(undefined8 *)(local_88 + 0x38) = 0;
  *(undefined8 *)(local_88 + 0x40) = 0;
  *(undefined8 *)(local_88 + 0x48) = 0;
  *(undefined8 *)(local_88 + 0x50) = 0;
  *(undefined8 *)(local_88 + 0x58) = 0;
  pMStack_128 = (Mat *)cv::Mat::Mat(local_88,(Mat *)(this + 0x120));
  local_120 = &PTR_FUN_180171ba8;
  uStack_118 = 0x1801d3999;
  (*pcVar13)(puVar1,&local_78,&local_150);
  uVar3 = (uint)uStack_118 & 3;
  if (uVar3 == 1) {
    pcVar13 = (code *)*local_120;
    if (pcVar13 == FUN_18008df20) {
      FUN_18008df20(pMStack_128);
      goto LAB_18008cee5;
    }
  }
  else {
    if (uVar3 != 2) goto LAB_18008cee5;
    pcVar13 = (code *)*local_120;
    if (pcVar13 == FUN_18008df20) {
      FUN_18008df20((Mat *)&local_150);
      goto LAB_18008cee5;
    }
  }
  (*pcVar13)();
LAB_18008cee5:
  uStack_118 = 0;
  FUN_1800090b0((longlong *)&local_88);
  lVar12 = (longlong)local_88 - CONCAT44(local_80._4_4_,(float)local_80);
  pfVar9 = (float *)FUN_18008d7e0(local_78);
  local_1a8 = (undefined8 *******)((ulonglong)local_1a8._4_4_ << 0x20);
  lVar10 = __RTDynamicCast(*(undefined8 *)(this + 0x210),0,
                           &ResNet18Classification::RTTI_Type_Descriptor,
                           &MobileNetV2Classification::RTTI_Type_Descriptor);
  fVar16 = DAT_18017e97c;
  if (lVar10 == 0) {
    fVar16 = expf(*pfVar9);
    fVar14 = expf(pfVar9[1]);
    fVar15 = fVar16 / (fVar14 + fVar16);
    fVar14 = fVar14 / (fVar14 + fVar16);
    if (fVar15 <= fVar14) {
      *(undefined4 *)(this + 0x84) = 2;
    }
    else {
      *(undefined4 *)(this + 0x84) = 0;
      fVar14 = fVar15;
    }
  }
  else {
    uVar4 = 2;
    if (*pfVar9 < DAT_18017e97c) {
      uVar4 = 0;
    }
    *(undefined4 *)(this + 0x84) = uVar4;
    fVar14 = *pfVar9;
    if (fVar14 < fVar16) {
      fVar14 = DAT_18017e9d8 - fVar14;
    }
  }
  plVar7 = FUN_1800014c0();
  switch(*(undefined4 *)(this + 0x84)) {
  case 0:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"IRON UNKNOWN",0xc);
    break;
  case 1:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"WEDGE",5);
    break;
  case 2:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"WOOD UNKNOWN",0xc);
    break;
  case 3:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"SMALL FAIRWAY WOOD",0x12);
    break;
  case 4:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"BIG FAIRWAY WOOD",0x10);
    break;
  case 5:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"DRIVER",6);
    break;
  case 6:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"PUTTER",6);
    break;
  default:
    local_188 = (undefined8 *******)0x0;
    pMStack_180 = (MLClubDetection *)0x0;
    local_178 = 0;
    local_170 = 0;
    FUN_18000c1d0(&local_188,"[Unknown Club]",0xe);
  }
  local_1a8 = &local_188;
  if (0xf < local_170) {
    local_1a8 = (undefined8 *******)local_188;
  }
  pbVar8 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           cv::format(local_108,"[Club.Detection.ML] Time taken: %d ms. Confidence: %.2f%% for %s",
                      lVar12 / 1000000,(double)(fVar14 * DAT_18017ec84));
  FUN_180084c00(plVar7,pbVar8,1,'\x01');
  FUN_18000c8d0((longlong *)&local_188);
  if ((*(int *)(this + 0x84) == 0) && (DAT_18017ec3c <= param_2)) {
    *(undefined4 *)(this + 0x84) = 1;
  }
  local_178 = 0;
  local_188._0_4_ = 0x1010000;
  pMStack_180 = this + 8;
  iVar5 = cv::countNonZero((_InputArray *)&local_188);
  cv::Mat::Mat(local_e8,(Mat *)(param_1 + 8));
  local_178 = 0;
  local_188 = (undefined8 ******)CONCAT44(local_188._4_4_,0x1010000);
  pMStack_180 = (MLClubDetection *)local_e8;
  iVar6 = cv::countNonZero((_InputArray *)&local_188);
  cv::Mat::~Mat(local_e8);
  local_80._0_4_ = *(float *)(this + 0x1fc) * *(float *)(this + 0x1fc);
  fVar16 = (float)iVar5 / (float)local_80;
  local_88 = (Mat *)CONCAT44(local_88._4_4_,fVar16);
  local_80._0_4_ = (float)iVar6 / (float)local_80;
  ppMVar11 = (Mat **)&local_80;
  if ((float)local_80 <= fVar16) {
    ppMVar11 = &local_88;
  }
  *(int *)(this + 0x88) = (int)*(float *)ppMVar11;
  FUN_18008d6f0((longlong *)&local_78);
  return true;
}

