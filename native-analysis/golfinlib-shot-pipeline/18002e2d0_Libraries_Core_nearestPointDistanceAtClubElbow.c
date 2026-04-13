FUNCTION: Libraries::Core::nearestPointDistanceAtClubElbow
ENTRY: 18002e2d0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* class cv::Point_<int> __cdecl Libraries::Core::nearestPointDistanceAtClubElbow(class cv::Mat) */

undefined8 * __cdecl
Libraries::Core::nearestPointDistanceAtClubElbow(undefined8 *param_1,Mat *param_2)

{
  undefined8 *puVar1;
  bool bVar2;
  uint *puVar3;
  uint *puVar4;
  uint *puVar5;
  uint *puVar6;
  uint *puVar7;
  int iVar8;
  int iVar9;
  uint *puVar10;
  int iVar11;
  longlong lVar12;
  longlong *plVar13;
  ulonglong uVar14;
  longlong lVar15;
  longlong lVar16;
  undefined1 auStack_f8 [32];
  int local_d8;
  undefined8 *local_d0;
  ulonglong local_c8;
  uint *local_c0;
  Mat *local_b8;
  Mat *local_b0;
  undefined8 local_a8;
  uint *local_a0;
  uint *puStack_98;
  uint *local_90;
  undefined8 local_88;
  uint *local_78;
  uint *puStack_70;
  undefined8 local_68;
  longlong *local_60;
  longlong lStack_58;
  undefined8 local_50;
  ulonglong local_48;
  
                    /* 0x2e2d0  809
                       ?nearestPointDistanceAtClubElbow@Core@Libraries@@YA?AV?$Point_@H@cv@@VMat@4@@Z
                        */
  local_48 = DAT_1801d1040 ^ (ulonglong)auStack_f8;
  local_78 = (uint *)0x0;
  puStack_70 = (uint *)0x0;
  local_68 = 0;
  local_d0 = param_1;
  local_b8 = param_2;
  local_b0 = param_2;
  FUN_180044e00(&local_78,(longlong)*(int *)(param_2 + 8));
  iVar11 = 0;
  if (0 < *(int *)(param_2 + 8)) {
    lVar16 = 0;
    lVar15 = 0;
    do {
      iVar9 = 0;
      lVar12 = 0;
      if (0 < *(int *)(param_2 + 0xc)) {
        do {
          if (*(char *)(lVar16 * **(longlong **)(param_2 + 0x48) + lVar12 +
                       *(longlong *)(param_2 + 0x10)) == -1) {
            plVar13 = (longlong *)((longlong)local_78 + lVar15);
            local_a8 = CONCAT44(iVar11,iVar9);
            puVar1 = (undefined8 *)plVar13[1];
            if (puVar1 == (undefined8 *)plVar13[2]) {
              FUN_180046b60(plVar13,puVar1,&local_a8);
            }
            else {
              *puVar1 = CONCAT44(iVar11,iVar9);
              plVar13[1] = plVar13[1] + 8;
            }
          }
          iVar9 = iVar9 + 1;
          lVar12 = lVar12 + 1;
        } while (iVar9 < *(int *)(param_2 + 0xc));
      }
      iVar11 = iVar11 + 1;
      lVar16 = lVar16 + 1;
      lVar15 = lVar15 + 0x18;
      param_1 = local_d0;
    } while (iVar11 < *(int *)(param_2 + 8));
  }
  local_60 = (longlong *)0x0;
  lStack_58 = 0;
  local_50 = 0;
  local_c8 = 0x10;
  local_a0 = local_78;
  puStack_98 = puStack_70;
  local_90 = (uint *)CONCAT71(local_90._1_7_,1);
  local_88 = 0;
  FUN_1800450d0(&local_c8,(longlong *)&local_60,&local_a0);
  iVar11 = 0x7fffffff;
  *param_1 = 0;
  local_d8 = 0;
  lVar15 = (lStack_58 - (longlong)local_60) / 6 + (lStack_58 - (longlong)local_60 >> 0x3f);
  uVar14 = (lVar15 >> 2) - (lVar15 >> 0x3f);
  plVar13 = local_60;
  local_c8 = uVar14;
  if (uVar14 == 0) {
LAB_18002e63b:
    FUN_180043110((longlong *)&local_60);
    FUN_180043110((longlong *)&local_78);
    cv::Mat::~Mat(param_2);
    return local_d0;
  }
LAB_18002e440:
  puVar6 = (uint *)plVar13[1];
  local_c0 = (uint *)*plVar13;
  if (1 < (ulonglong)((longlong)puVar6 - (longlong)local_c0 >> 3)) {
    if (iVar11 != 0x7fffffff) {
      bVar2 = true;
      puVar10 = (uint *)0x0;
      local_a0 = (uint *)0x0;
      puStack_98 = (uint *)0x0;
      local_90 = (uint *)0x0;
      local_a8 = 0x10;
      FUN_180048a90((longlong *)&local_a0,&local_a8);
      puVar7 = local_c0;
LAB_18002e4a0:
      puVar5 = local_90;
      puVar4 = puStack_98;
      puVar3 = local_a0;
      if (bVar2) {
        bVar2 = false;
        puVar10 = puVar7;
      }
      else {
        if (puVar10 == puVar6) goto LAB_18002e4e8;
        puVar10 = puVar10 + 2;
      }
      if (puVar10 == puVar6) goto LAB_18002e4e8;
      local_a8 = CONCAT44(local_a8._4_4_,*puVar10);
      if (puStack_98 == local_90) {
        FUN_180046a00((longlong *)&local_a0,puStack_98,(undefined4 *)&local_a8);
      }
      else {
        *puStack_98 = *puVar10;
        puStack_98 = puStack_98 + 1;
      }
      goto LAB_18002e4a0;
    }
    goto LAB_18002e58e;
  }
  goto LAB_18002e5e4;
LAB_18002e4e8:
  puVar6 = thunk_FUN_180132030(local_a0,puStack_98,1);
  puVar7 = thunk_FUN_180131e10(puVar3,puVar4,1);
  param_2 = local_b8;
  if ((longlong)
      (int)((puVar3[(int)((longlong)puVar6 - (longlong)puVar3 >> 2)] -
            puVar3[(int)((longlong)puVar7 - (longlong)puVar3 >> 2)]) + 1) !=
      (longlong)puVar4 - (longlong)puVar3 >> 2) {
    param_1 = local_d0;
    uVar14 = local_c8;
    if (puVar3 != (uint *)0x0) {
      puVar6 = puVar3;
      if ((0xfff < (ulonglong)(((longlong)puVar5 - (longlong)puVar3 >> 2) * 4)) &&
         (puVar6 = *(uint **)(puVar3 + -2),
         0x1f < (ulonglong)((longlong)puVar3 + (-8 - (longlong)puVar6)))) goto LAB_18002e683;
      free(puVar6);
      param_1 = local_d0;
      uVar14 = local_c8;
    }
LAB_18002e58e:
    iVar9 = 0;
    lVar15 = *plVar13;
    if (plVar13[1] - lVar15 >> 3 != 0) {
      lVar16 = 0;
      do {
        if (((iVar9 != 0) &&
            (iVar8 = *(int *)(lVar15 + lVar16) - *(int *)(lVar15 + -8 + lVar16), 2 < iVar8)) &&
           (iVar8 < iVar11)) {
          *param_1 = *(undefined8 *)(lVar15 + -8 + lVar16);
          iVar11 = iVar8;
        }
        iVar9 = iVar9 + 1;
        lVar16 = lVar16 + 8;
        lVar15 = *plVar13;
      } while ((ulonglong)(longlong)iVar9 < (ulonglong)(plVar13[1] - lVar15 >> 3));
    }
LAB_18002e5e4:
    local_d8 = local_d8 + 1;
    plVar13 = plVar13 + 3;
    if (uVar14 <= (ulonglong)(longlong)local_d8) goto LAB_18002e63b;
    goto LAB_18002e440;
  }
  if (puVar3 == (uint *)0x0) goto LAB_18002e63b;
  puVar6 = puVar3;
  if (((ulonglong)(((longlong)puVar5 - (longlong)puVar3 >> 2) * 4) < 0x1000) ||
     (puVar6 = *(uint **)(puVar3 + -2),
     (ulonglong)((longlong)puVar3 + (-8 - (longlong)puVar6)) < 0x20)) {
    free(puVar6);
    goto LAB_18002e63b;
  }
LAB_18002e683:
                    /* WARNING: Subroutine does not return */
  _invalid_parameter_noinfo_noreturn();
}

