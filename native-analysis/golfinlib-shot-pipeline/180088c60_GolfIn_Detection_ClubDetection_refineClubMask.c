FUNCTION: GolfIn::Detection::ClubDetection::refineClubMask
ENTRY: 180088c60
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: void __cdecl GolfIn::Detection::ClubDetection::refineClubMask(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::refineClubMask(ClubDetection *this,ClubDetectionInput *param_1)

{
  bool bVar1;
  double dVar2;
  int iVar3;
  undefined8 *puVar4;
  int iVar5;
  uint uVar6;
  float fVar7;
  float fVar8;
  undefined1 auStack_358 [32];
  undefined8 local_338;
  undefined4 local_330;
  undefined4 local_328;
  undefined8 *local_320;
  uint local_318;
  int iStack_314;
  undefined8 local_310;
  undefined4 local_308 [2];
  undefined8 *local_300;
  undefined8 local_2f8;
  undefined4 local_2f0 [2];
  undefined8 *local_2e8;
  undefined8 local_2e0;
  undefined4 local_2d8 [2];
  undefined8 *local_2d0;
  undefined8 local_2c8;
  undefined8 local_2c0;
  undefined8 uStack_2b8;
  undefined8 local_2b0;
  undefined8 local_2a0;
  undefined8 uStack_298;
  undefined8 local_290;
  undefined8 uStack_288;
  undefined1 local_278 [16];
  Mat local_268 [96];
  Mat local_208 [96];
  Mat local_1a8 [144];
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
  ulonglong local_58;
  
                    /* 0x88c60  892
                       ?refineClubMask@ClubDetection@Detection@GolfIn@@IEAAXAEBUClubDetectionInput@23@@Z
                        */
  fVar8 = DAT_18017e964;
  local_58 = DAT_1801d1040 ^ (ulonglong)auStack_358;
  iVar5 = 0;
  local_318 = 0;
  fVar7 = (float)roundf((float)*(int *)(param_1 + 0xf0) * _DAT_18017ea58);
  Libraries::Core::morphology((Mat *)(this + 8),(Mat *)(this + 8),3,*(float *)(this + 0x208));
  local_2c0 = 0;
  uStack_2b8 = 0;
  local_2b0 = 0;
  iStack_314 = (int)ROUND(*(float *)(param_1 + 0xec) - *(float *)(this + 0x74));
  local_318 = (uint)ROUND(*(float *)(param_1 + 0xe8) - *(float *)(this + 0x70));
  Libraries::Core::extract_biggest_blob(this + 8,this + 8,&local_2c0,CONCAT44(iStack_314,local_318))
  ;
  Libraries::Core::connect_diagonal_masses((Mat *)(this + 8),(int)fVar7);
  local_118 = 0;
  uStack_110 = 0;
  local_108 = 0;
  uStack_100 = 0;
  local_f8 = 0;
  uStack_f0 = 0;
  local_e8 = 0;
  uStack_e0 = 0;
  local_d8 = 0;
  uStack_d0 = 0;
  local_c8 = 0;
  uStack_c0 = 0;
  iStack_314 = **(undefined4 **)(this + 0x48);
  local_318 = (*(undefined4 **)(this + 0x48))[1];
  puVar4 = (undefined8 *)cv::Mat::zeros(local_278,CONCAT44(iStack_314,local_318),0);
  local_118 = 0;
  uStack_110 = 0;
  local_108 = 0;
  uStack_100 = 0;
  local_f8 = 0;
  uStack_f0 = 0;
  local_e8 = 0;
  uStack_e0 = 0;
  local_d8 = 0;
  uStack_d0 = 0;
  local_c8 = 0;
  uStack_c0 = 0;
  cv::Mat::Mat((Mat *)&local_118);
  uVar6 = 2;
  local_318 = 2;
  (**(code **)(*(longlong *)*puVar4 + 0x10))((longlong *)*puVar4,puVar4,&local_118,0xffffffff);
  cv::Mat::~Mat(local_1a8);
  cv::Mat::~Mat(local_208);
  cv::Mat::~Mat(local_268);
  dVar2 = DAT_18017ea18;
  do {
    if (iVar5 < 5) {
      local_2f8 = 0;
      local_308[0] = 0x1010000;
      local_300 = &local_118;
      uVar6 = uVar6 | 1;
      local_318 = uVar6;
      iVar3 = cv::countNonZero((_InputArray *)local_308);
      if (0 < iVar3) goto LAB_180088e58;
      bVar1 = true;
    }
    else {
LAB_180088e58:
      bVar1 = false;
    }
    if ((uVar6 & 1) != 0) {
      uVar6 = uVar6 & 0xfffffffe;
      local_318 = uVar6;
    }
    if (!bVar1) {
      Libraries::Core::connect_diagonal_masses((Mat *)&local_118,(int)fVar7);
      local_b8 = 0;
      uStack_b0 = 0;
      local_a8 = 0;
      uStack_a0 = 0;
      local_98 = 0;
      uStack_90 = 0;
      local_88 = 0;
      uStack_80 = 0;
      local_78 = 0;
      uStack_70 = 0;
      local_68 = 0;
      uStack_60 = 0;
      local_310 = CONCAT44((int)ROUND(DAT_18017ec20),(int)ROUND(DAT_18017ec20));
      cv::getStructuringElement(&local_b8,2,local_310,0x300000003);
      local_2a0 = _DAT_18017f100;
      uStack_298 = _UNK_18017f108;
      local_290 = _DAT_18017f100;
      uStack_288 = _UNK_18017f108;
      local_2f8 = 0;
      local_308[0] = 0x1010000;
      local_300 = &local_b8;
      local_2e0 = 0;
      local_2f0[0] = 0x2010000;
      local_2e8 = &local_118;
      local_2c8 = 0;
      local_2d8[0] = 0x1010000;
      local_2d0 = &local_118;
      local_320 = &local_2a0;
      local_328 = 0;
      local_330 = 1;
      local_338 = 0xffffffffffffffff;
      cv::morphologyEx(local_2d8,local_2f0,3,local_308);
      cv::Mat::~Mat((Mat *)&local_b8);
      local_310 = 0xffffffffffffffff;
      Libraries::Core::extract_biggest_blob(&local_118,this + 8,&local_2c0,0xffffffffffffffff);
      cv::Mat::~Mat((Mat *)&local_118);
      return;
    }
    removeClubShaft(this,(Mat *)(this + 8),(Mat *)&local_118,fVar8);
    fVar8 = (float)((double)fVar8 - dVar2);
    iVar5 = iVar5 + 1;
  } while( true );
}

