FUNCTION: FUN_1800872b0
ENTRY: 1800872b0
REASONS: string:Club.Detection


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

void FUN_1800872b0(longlong *param_1)

{
  char cVar1;
  char cVar2;
  int iVar3;
  int *piVar4;
  int *piVar5;
  longlong lVar6;
  int iVar7;
  code *pcVar8;
  undefined8 uVar9;
  longlong *plVar10;
  longlong *plVar11;
  undefined4 *puVar12;
  longlong *plVar13;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar14;
  undefined8 *puVar15;
  undefined8 *puVar16;
  undefined8 *puVar17;
  int *piVar18;
  int *piVar19;
  undefined8 *puVar20;
  bool bVar21;
  bool bVar22;
  undefined1 auStack_3f8 [32];
  undefined4 local_3d8;
  undefined4 uStack_3d4;
  float fStack_3d0;
  float fStack_3cc;
  undefined4 local_3c8 [2];
  Mat *local_3c0;
  undefined8 local_3b8;
  undefined8 local_3b0;
  undefined8 *local_3a8;
  undefined8 local_3a0;
  undefined8 local_398;
  undefined8 local_390;
  undefined8 local_388;
  undefined8 uStack_380;
  Point_<float> local_378 [24];
  Mat local_360 [104];
  undefined1 local_2f8 [16];
  Mat local_2e8 [96];
  Mat local_288 [96];
  Mat local_228 [144];
  double local_198;
  double local_190;
  double local_188;
  undefined8 *local_d8;
  longlong lStack_d0;
  longlong *local_c8;
  undefined8 uStack_c0;
  undefined4 local_b8;
  undefined4 local_b4;
  undefined8 local_b0;
  undefined8 uStack_a8;
  Mat local_a0 [8];
  int local_98;
  int local_94;
  ulonglong local_38;
  
  local_38 = DAT_1801d1040 ^ (ulonglong)auStack_3f8;
  GolfIn::YoloClubSegmentation::predict
            (*(YoloClubSegmentation **)(*param_1 + 0x220),(Mat *)param_1[1],
             (vector<struct_GolfIn::ClubOutputParams,class_std::allocator<struct_GolfIn::ClubOutputParams>_>
              *)param_1[2]);
  local_c8 = (longlong *)0x0;
  uStack_c0 = 0;
  local_c8 = (longlong *)FUN_1801327e0(0x40);
  *local_c8 = (longlong)local_c8;
  local_c8[1] = (longlong)local_c8;
  local_c8[2] = (longlong)local_c8;
  *(undefined2 *)(local_c8 + 3) = 0x101;
  piVar4 = (int *)((longlong *)param_1[2])[1];
  piVar18 = *(int **)param_1[2];
  if (piVar18 != piVar4) {
    piVar19 = piVar18 + 2;
    do {
      plVar11 = FUN_18008d4c0((longlong *)&local_c8,piVar18);
      piVar5 = (int *)plVar11[1];
      if (piVar5 == (int *)plVar11[2]) {
        FUN_18008dc50(plVar11,(undefined8 *)piVar5,piVar18);
      }
      else {
        *piVar5 = *piVar18;
        piVar5[1] = piVar19[-1];
        uVar9 = *(undefined8 *)(piVar19 + 2);
        *(undefined8 *)(piVar5 + 2) = *(undefined8 *)piVar19;
        *(undefined8 *)(piVar5 + 4) = uVar9;
        cv::Mat::Mat((Mat *)(piVar5 + 6),(Mat *)(piVar19 + 4));
        plVar11[1] = plVar11[1] + 0x78;
      }
      piVar18 = piVar18 + 0x1e;
      piVar19 = piVar19 + 0x1e;
    } while (piVar18 != piVar4);
  }
  local_d8 = (undefined8 *)0x0;
  lStack_d0 = 0;
  local_d8 = (undefined8 *)FUN_1801327e0(0xa0);
  *local_d8 = local_d8;
  local_d8[1] = local_d8;
  local_d8[2] = local_d8;
  *(undefined2 *)(local_d8 + 3) = 0x101;
  plVar11 = (longlong *)*local_c8;
  cVar1 = *(char *)((longlong)plVar11 + 0x19);
  while (cVar1 == '\0') {
    puVar12 = (undefined4 *)
              GolfIn::Detection::MLClubDetection::club_best_candidate_near_ball
                        ((MLClubDetection *)*param_1,local_378,
                         (vector<struct_GolfIn::ClubOutputParams,class_std::allocator<struct_GolfIn::ClubOutputParams>_>
                          *)(param_1[3] + 0xe8));
    plVar13 = FUN_18008d310((longlong *)&local_d8,(int *)(plVar11 + 4));
    *(undefined4 *)plVar13 = *puVar12;
    *(undefined4 *)((longlong)plVar13 + 4) = puVar12[1];
    lVar6 = *(longlong *)(puVar12 + 4);
    plVar13[1] = *(longlong *)(puVar12 + 2);
    plVar13[2] = lVar6;
    cv::Mat::operator=((Mat *)(plVar13 + 3),(Mat *)(puVar12 + 6));
    cv::Mat::~Mat(local_360);
    plVar13 = (longlong *)plVar11[2];
    if (*(char *)((longlong)plVar13 + 0x19) == '\0') {
      cVar1 = *(char *)(*plVar13 + 0x19);
      plVar11 = plVar13;
      plVar13 = (longlong *)*plVar13;
      while (cVar1 == '\0') {
        cVar1 = *(char *)(*plVar13 + 0x19);
        plVar11 = plVar13;
        plVar13 = (longlong *)*plVar13;
      }
    }
    else {
      cVar1 = *(char *)(plVar11[1] + 0x19);
      plVar10 = (longlong *)plVar11[1];
      plVar13 = plVar11;
      while ((plVar11 = plVar10, cVar1 == '\0' && (plVar13 == (longlong *)plVar11[2]))) {
        cVar1 = *(char *)(plVar11[1] + 0x19);
        plVar10 = (longlong *)plVar11[1];
        plVar13 = plVar11;
      }
    }
    cVar1 = *(char *)((longlong)plVar11 + 0x19);
  }
  if (lStack_d0 == 0) {
    plVar11 = FUN_1800014c0();
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              cv::format((char *)&local_398,
                         "[ML.Club.Detection] No CLUB_HEAD or CLUB_FACE detected in frame.");
    FUN_180084c00(plVar11,pbVar14,2,'\x01');
    *(undefined1 *)(*param_1 + 0x90) = 1;
    GolfIn::Detection::ClubDetection::performDetectionPipeline
              ((ClubDetection *)*param_1,(ClubDetectionInput *)param_1[3]);
  }
  else {
    local_b0 = 0;
    uStack_a8 = 0;
    cv::Mat::Mat(local_a0);
    puVar16 = (undefined8 *)local_d8[1];
    cVar2 = *(char *)((longlong)puVar16 + 0x19);
    puVar15 = puVar16;
    puVar17 = local_d8;
    cVar1 = cVar2;
    while (puVar20 = puVar15, cVar1 == '\0') {
      if (*(int *)(puVar20 + 4) < 1) {
        puVar15 = (undefined8 *)puVar20[2];
        puVar20 = puVar17;
      }
      else {
        puVar15 = (undefined8 *)*puVar20;
      }
      cVar1 = *(char *)((longlong)puVar15 + 0x19);
      puVar17 = puVar20;
    }
    puVar15 = local_d8;
    if ((*(char *)((longlong)puVar17 + 0x19) == '\0') && (*(int *)(puVar17 + 4) < 2)) {
      while (puVar17 = puVar16, cVar2 == '\0') {
        if (*(int *)(puVar17 + 4) < 1) {
          puVar16 = (undefined8 *)puVar17[2];
          puVar17 = puVar15;
        }
        else {
          puVar16 = (undefined8 *)*puVar17;
        }
        cVar2 = *(char *)((longlong)puVar16 + 0x19);
        puVar15 = puVar17;
      }
      if (*(char *)((longlong)puVar15 + 0x19) != '\0') goto LAB_18008782f;
      iVar3 = *(int *)(puVar15 + 4);
      bVar22 = SBORROW4(iVar3,1);
      iVar7 = iVar3 + -1;
      bVar21 = iVar3 == 1;
    }
    else {
      while (puVar17 = puVar16, cVar2 == '\0') {
        if (*(int *)(puVar17 + 4) < 0) {
          puVar16 = (undefined8 *)puVar17[2];
          puVar17 = puVar15;
        }
        else {
          puVar16 = (undefined8 *)*puVar17;
        }
        cVar2 = *(char *)((longlong)puVar16 + 0x19);
        puVar15 = puVar17;
      }
      if (*(char *)((longlong)puVar15 + 0x19) != '\0') goto LAB_18008782f;
      iVar7 = *(int *)(puVar15 + 4);
      bVar22 = false;
      bVar21 = iVar7 == 0;
    }
    if (!bVar21 && bVar22 == iVar7 < 0) {
LAB_18008782f:
      std::_Xout_of_range("invalid map<K, T> key");
      pcVar8 = (code *)swi(3);
      (*pcVar8)();
      return;
    }
    local_b8 = *(undefined4 *)(puVar15 + 5);
    local_b4 = *(undefined4 *)((longlong)puVar15 + 0x2c);
    local_b0 = puVar15[6];
    uStack_a8 = puVar15[7];
    cv::Mat::operator=(local_a0,(Mat *)(puVar15 + 8));
    fStack_3cc = (float)uStack_a8._4_4_;
    fStack_3d0 = (float)(int)uStack_a8;
    lVar6 = *param_1;
    *(float *)(lVar6 + 0x70) = (float)(int)local_b0;
    *(float *)(lVar6 + 0x74) = (float)local_b0._4_4_;
    *(float *)(lVar6 + 0x78) = fStack_3d0;
    *(float *)(lVar6 + 0x7c) = fStack_3cc;
    uStack_3d4 = **(undefined4 **)(param_1[1] + 0x40);
    local_3d8 = (*(undefined4 **)(param_1[1] + 0x40))[1];
    puVar16 = (undefined8 *)cv::Mat::zeros(local_2f8,CONCAT44(uStack_3d4,local_3d8),0);
    (**(code **)(*(longlong *)*puVar16 + 0x10))
              ((longlong *)*puVar16,puVar16,*param_1 + 8,0xffffffff);
    cv::Mat::~Mat(local_228);
    cv::Mat::~Mat(local_288);
    cv::Mat::~Mat(local_2e8);
    if ((local_98 < 0) || (local_94 < 0)) {
      FUN_180009760(&local_3b0,"Result candidate found, but no mask has been extract.");
                    /* WARNING: Subroutine does not return */
      _CxxThrowException(&local_3b0,(ThrowInfo *)&DAT_1801a9018);
    }
    cv::Mat::Mat((Mat *)local_378,(Mat *)(*param_1 + 8),(Rect_<int> *)&local_b0);
    local_3b8 = 0;
    local_3c8[0] = 0x1010000;
    local_3c0 = local_a0;
    local_398 = DAT_18017ebd0;
    local_388 = 0;
    uStack_380 = 0;
    local_390 = 0;
    local_3d8 = 1;
    uStack_3d4 = 4;
    local_3b0._0_4_ = 0xc1020006;
    local_3a8 = &local_398;
    local_3a0 = 0x400000001;
    cv::Mat::setTo((Mat *)local_378,(_InputArray *)&local_3b0,(_InputArray *)local_3c8);
    cv::Mat::~Mat((Mat *)local_378);
    local_3c0 = (Mat *)(*param_1 + 8);
    local_3b8 = 0;
    local_3c8[0] = 0x1010000;
    cv::moments((_InputArray *)&local_198,SUB81(local_3c8,0));
    lVar6 = *param_1;
    *(float *)(lVar6 + 0x68) = (float)(local_190 / local_198);
    *(float *)(lVar6 + 0x6c) = (float)(local_188 / local_198);
    puVar16 = (undefined8 *)*param_1;
    if (*(char *)(puVar16 + 0x1a) != '\0') {
      (**(code **)*puVar16)(puVar16,param_1[3],puVar16 + 1);
    }
    cv::Mat::~Mat(local_a0);
  }
  FUN_18008d450((longlong *)&local_d8);
  FUN_18008d5c0((longlong *)&local_c8);
  return;
}

