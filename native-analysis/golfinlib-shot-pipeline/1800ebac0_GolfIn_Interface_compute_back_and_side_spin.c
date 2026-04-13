FUNCTION: GolfIn::Interface::compute_back_and_side_spin
ENTRY: 1800ebac0
REASONS: name:spin; string:BackSpinSideSpinInference


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: void __cdecl GolfIn::Interface::compute_back_and_side_spin(class GolfIn::Shot &
   __ptr64) __ptr64 */

void __thiscall GolfIn::Interface::compute_back_and_side_spin(Interface *this,Shot *param_1)

{
  Shot *pSVar1;
  Shot *pSVar2;
  Shot *pSVar3;
  float fVar4;
  code *pcVar5;
  float fVar6;
  PlayerHandedness PVar7;
  uint uVar8;
  longlong *plVar9;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar10;
  undefined4 *puVar11;
  float *pfVar12;
  undefined8 *puVar13;
  longlong *plVar14;
  int iVar15;
  ulonglong *puVar16;
  undefined8 **ppuVar17;
  longlong lVar18;
  void *pvVar19;
  float fVar20;
  float fVar21;
  float fVar22;
  undefined1 auStack_228 [32];
  double local_208;
  double local_200;
  double local_1f8;
  float local_1e8;
  float local_1e4;
  ulonglong local_1e0 [5];
  ulonglong *puStack_1b8;
  undefined **local_1b0;
  undefined8 uStack_1a8;
  ulonglong local_1a0 [5];
  ulonglong *puStack_178;
  undefined **local_170;
  undefined8 uStack_168;
  float local_160;
  float local_15c;
  Interface *local_158;
  undefined8 local_150;
  float local_148;
  undefined4 local_144;
  Shot *local_140;
  Shot *local_138;
  undefined8 local_128;
  undefined8 uStack_120;
  undefined8 local_118;
  undefined8 *local_110;
  longlong lStack_108;
  longlong local_100;
  longlong lStack_f8;
  undefined8 *local_f0;
  longlong lStack_e8;
  undefined8 local_e0;
  undefined8 uStack_d8;
  void *local_d0;
  longlong lStack_c8;
  longlong local_c0;
  void *local_b8;
  longlong lStack_b0;
  longlong local_a8;
  longlong local_a0 [15];
  
                    /* 0xebac0  468
                       ?compute_back_and_side_spin@Interface@GolfIn@@IEAAXAEAVShot@2@@Z */
  local_a0[4] = DAT_1801d1040 ^ (ulonglong)auStack_228;
  pSVar1 = param_1 + 0x10;
  pSVar2 = param_1 + 0x18;
  pSVar3 = param_1 + 0x398;
  plVar9 = *(longlong **)(this + 0x730);
  local_158 = this;
  local_150 = param_1;
  local_140 = pSVar3;
  local_138 = pSVar2;
  local_128 = pSVar1;
  if (plVar9 == (longlong *)0x0) {
    local_a0[0] = 0;
    local_a0[1] = 0;
    local_a0[2] = 0;
    local_a0[3] = 0;
    FUN_18000c1d0(local_a0,"0.0,0.0",7);
  }
  else {
    local_200 = (double)CONCAT44(local_200._4_4_,*(undefined4 *)(param_1 + 0x39c));
    local_208 = (double)*(float *)pSVar1;
    (**(code **)(*plVar9 + 0x28))
              (plVar9,local_a0,*(undefined4 *)pSVar3,SUB84((double)*(float *)pSVar2,0));
  }
  fVar6 = DAT_18017ec84;
  local_1e4 = 100.0;
  local_1e8 = 0.0;
  FUN_1800eb880(&local_160,local_a0);
  fVar21 = local_160;
  if (local_160 <= 0.0) {
    fVar21 = fVar6;
  }
  fVar20 = 0.0;
  if (0.0 <= local_15c) {
    fVar20 = local_15c;
  }
  local_1e8 = fVar20;
  local_1e4 = fVar21;
  PVar7 = Shot::getPlayerHanded(param_1);
  iVar15 = 1;
  if (PVar7 == 2) {
    iVar15 = -1;
  }
  fVar20 = fVar20 * (float)iVar15;
  local_1e8 = fVar20;
  plVar9 = FUN_1800014c0();
  pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format((char *)local_1e0,
                       "[Ball.BackSpinSideSpinInference] Successfully get spin config. Backspin boost (percent)= %.2f%%, Club face offset= %.2f degrees"
                       ,(double)fVar21,(double)fVar20);
  FUN_180084c00(plVar9,pbVar10,1,'\x01');
  switch(*(undefined4 *)pSVar3) {
  case 0:
  case 1:
    iVar15 = 0;
    break;
  case 2:
  case 3:
  case 4:
  case 5:
    iVar15 = 1;
    break;
  case 6:
    iVar15 = 2;
    break;
  default:
    iVar15 = 3;
  }
  local_128 = (Shot *)CONCAT44(*(float *)pSVar1,*(float *)pSVar2);
  uStack_120 = CONCAT44(*(undefined4 *)(param_1 + 0x2ac),*(undefined4 *)(param_1 + 0x2b4));
  local_d0 = (void *)0x0;
  lStack_c8 = 0;
  local_c0 = 0;
  FUN_180008f50((ulonglong *)&local_d0,4);
  pvVar19 = local_d0;
  memmove(local_d0,&local_128,0x10);
  lStack_c8 = (longlong)pvVar19 + 0x10;
  local_150 = (Shot *)CONCAT44(*(float *)pSVar1,*(float *)pSVar2);
  local_148 = fVar20 + *(float *)(param_1 + 0x2b4);
  local_144 = *(undefined4 *)(param_1 + 0x2ac);
  local_b8 = (void *)0x0;
  lStack_b0 = 0;
  local_a8 = 0;
  FUN_180008f50((ulonglong *)&local_b8,4);
  pvVar19 = local_b8;
  memmove(local_b8,&local_150,0x10);
  lStack_b0 = (longlong)pvVar19 + 0x10;
  FUN_1800090b0((longlong *)&local_158);
  if (iVar15 != 1) {
    local_128 = (Shot *)0x0;
    uStack_120 = 0;
    local_118 = 0;
    puVar13 = *(undefined8 **)(this + 0x840);
    pcVar5 = *(code **)*puVar13;
    local_1e0[0] = 0;
    local_1e0[1] = 0;
    local_1e0[2] = 0;
    local_1e0[3] = 0;
    local_1e0[4] = 0;
    puStack_1b8 = (ulonglong *)0x0;
    local_1b0 = (undefined **)0x0;
    uStack_1a8 = 0;
    FUN_180063640(local_1e0,(longlong *)&local_d0);
    local_1b0 = &PTR_FUN_18017bff8;
    uStack_1a8 = 0x1801d7b8a;
    (*pcVar5)(puVar13,&local_128,local_1e0);
    uVar8 = (uint)uStack_1a8 & 3;
    puVar16 = puStack_1b8;
    if (uVar8 == 1) {
LAB_1800ec1c2:
      if ((code *)*local_1b0 == FUN_18000c650) {
        FUN_180091550((longlong *)puVar16);
      }
      else {
        (*(code *)*local_1b0)();
      }
    }
    else if (uVar8 == 2) {
      puVar16 = local_1e0;
      goto LAB_1800ec1c2;
    }
    uStack_1a8 = 0;
    local_f0 = (undefined8 *)0x0;
    lStack_e8 = 0;
    local_e0 = 0;
    puVar13 = *(undefined8 **)(this + 0x848);
    pcVar5 = *(code **)*puVar13;
    local_1a0[0] = 0;
    local_1a0[1] = 0;
    local_1a0[2] = 0;
    local_1a0[3] = 0;
    local_1a0[4] = 0;
    puStack_178 = (ulonglong *)0x0;
    local_170 = (undefined **)0x0;
    uStack_168 = 0;
    FUN_180063640(local_1a0,(longlong *)&local_b8);
    local_170 = &PTR_FUN_18017bff8;
    uStack_168 = 0x1801d7b8a;
    (*pcVar5)(puVar13,&local_f0,local_1a0);
    uVar8 = (uint)uStack_168 & 3;
    puVar16 = puStack_178;
    if (uVar8 == 1) {
LAB_1800ec28f:
      (*(code *)*local_170)(puVar16);
    }
    else if (uVar8 == 2) {
      puVar16 = local_1a0;
      goto LAB_1800ec28f;
    }
    uStack_168 = 0;
    local_110 = (undefined8 *)0x0;
    lStack_108 = 0;
    local_100 = 0;
    puVar13 = *(undefined8 **)(this + 0x848);
    pcVar5 = *(code **)*puVar13;
    local_1e0[0] = 0;
    local_1e0[1] = 0;
    local_1e0[2] = 0;
    local_1e0[3] = 0;
    local_1e0[4] = 0;
    puStack_1b8 = (ulonglong *)0x0;
    local_1b0 = (undefined **)0x0;
    uStack_1a8 = 0;
    FUN_180063640(local_1e0,(longlong *)&local_d0);
    local_1b0 = &PTR_FUN_18017bff8;
    uStack_1a8 = 0x1801d7b8a;
    (*pcVar5)(puVar13,&local_110,local_1e0);
    uVar8 = (uint)uStack_1a8 & 3;
    puVar16 = puStack_1b8;
    if (uVar8 == 1) {
LAB_1800ec336:
      if ((code *)*local_1b0 == FUN_18000c650) {
        FUN_180091550((longlong *)puVar16);
      }
      else {
        (*(code *)*local_1b0)();
      }
    }
    else if (uVar8 == 2) {
      puVar16 = local_1e0;
      goto LAB_1800ec336;
    }
    uStack_1a8 = 0;
    if (uStack_120 - (longlong)local_128 >> 3 == 0) {
LAB_1800ec726:
                    /* WARNING: Subroutine does not return */
      FUN_180006690();
    }
    puVar11 = (undefined4 *)FUN_18008d7e0((undefined8 *)local_128);
    *(undefined4 *)(param_1 + 0x1c) = *puVar11;
    if (lStack_e8 - (longlong)local_f0 >> 3 == 0) goto LAB_1800ec726;
    puVar11 = (undefined4 *)FUN_18008d7e0(local_f0);
    *(undefined4 *)(param_1 + 0x20) = *puVar11;
    if (lStack_108 - (longlong)local_110 >> 3 == 0) goto LAB_1800ec726;
    pfVar12 = (float *)FUN_18008d7e0(local_110);
    fVar22 = *pfVar12;
    FUN_18008d6f0((longlong *)&local_110);
    FUN_18008d6f0((longlong *)&local_f0);
    ppuVar17 = (undefined8 **)&local_128;
    goto LAB_1800ec3fa;
  }
  local_110 = (undefined8 *)0x0;
  lStack_108 = 0;
  local_100 = 0;
  puVar13 = *(undefined8 **)(this + 0x850);
  pcVar5 = *(code **)*puVar13;
  local_1a0[0] = 0;
  local_1a0[1] = 0;
  local_1a0[2] = 0;
  local_1a0[3] = 0;
  local_1a0[4] = 0;
  puStack_178 = (ulonglong *)0x0;
  local_170 = (undefined **)0x0;
  uStack_168 = 0;
  FUN_180063640(local_1a0,(longlong *)&local_d0);
  local_170 = &PTR_FUN_18017bff8;
  uStack_168 = 0x1801d7b8a;
  (*pcVar5)(puVar13,&local_110,local_1a0);
  uVar8 = (uint)uStack_168 & 3;
  puVar16 = puStack_178;
  if (uVar8 == 1) {
LAB_1800ebeeb:
    (*(code *)*local_170)(puVar16);
  }
  else if (uVar8 == 2) {
    puVar16 = local_1a0;
    goto LAB_1800ebeeb;
  }
  uStack_168 = 0;
  local_f0 = (undefined8 *)0x0;
  lStack_e8 = 0;
  local_e0 = 0;
  puVar13 = *(undefined8 **)(this + 0x858);
  pcVar5 = *(code **)*puVar13;
  local_1e0[0] = 0;
  local_1e0[1] = 0;
  local_1e0[2] = 0;
  local_1e0[3] = 0;
  local_1e0[4] = 0;
  puStack_1b8 = (ulonglong *)0x0;
  local_1b0 = (undefined **)0x0;
  uStack_1a8 = 0;
  FUN_180063640(local_1e0,(longlong *)&local_b8);
  local_1b0 = &PTR_FUN_18017bff8;
  uStack_1a8 = 0x1801d7b8a;
  (*pcVar5)(puVar13,&local_f0,local_1e0);
  uVar8 = (uint)uStack_1a8 & 3;
  puVar16 = puStack_1b8;
  if (uVar8 == 1) {
LAB_1800ebf92:
    if ((code *)*local_1b0 == FUN_18000c650) {
      FUN_180091550((longlong *)puVar16);
    }
    else {
      (*(code *)*local_1b0)();
    }
  }
  else if (uVar8 == 2) {
    puVar16 = local_1e0;
    goto LAB_1800ebf92;
  }
  uStack_1a8 = 0;
  local_128 = (Shot *)0x0;
  uStack_120 = 0;
  local_118 = 0;
  puVar13 = *(undefined8 **)(this + 0x858);
  pcVar5 = *(code **)*puVar13;
  local_1a0[0] = 0;
  local_1a0[1] = 0;
  local_1a0[2] = 0;
  local_1a0[3] = 0;
  local_1a0[4] = 0;
  puStack_178 = (ulonglong *)0x0;
  local_170 = (undefined **)0x0;
  uStack_168 = 0;
  FUN_180063640(local_1a0,(longlong *)&local_d0);
  local_170 = &PTR_FUN_18017bff8;
  uStack_168 = 0x1801d7b8a;
  (*pcVar5)(puVar13,&local_128,local_1a0);
  uVar8 = (uint)uStack_168 & 3;
  puVar16 = puStack_178;
  if (uVar8 == 1) {
LAB_1800ec05f:
    if ((code *)*local_170 == FUN_18000c650) {
      FUN_180091550((longlong *)puVar16);
    }
    else {
      (*(code *)*local_170)();
    }
  }
  else if (uVar8 == 2) {
    puVar16 = local_1a0;
    goto LAB_1800ec05f;
  }
  uStack_168 = 0;
  if (lStack_108 - (longlong)local_110 >> 3 != 0) {
    puVar11 = (undefined4 *)FUN_18008d7e0(local_110);
    *(undefined4 *)(param_1 + 0x1c) = *puVar11;
    if (lStack_e8 - (longlong)local_f0 >> 3 != 0) {
      puVar11 = (undefined4 *)FUN_18008d7e0(local_f0);
      *(undefined4 *)(param_1 + 0x20) = *puVar11;
      if (uStack_120 - (longlong)local_128 >> 3 != 0) {
        pfVar12 = (float *)FUN_18008d7e0((undefined8 *)local_128);
        fVar22 = *pfVar12;
        FUN_18008d6f0(&local_128);
        FUN_18008d6f0((longlong *)&local_f0);
        ppuVar17 = &local_110;
LAB_1800ec3fa:
        FUN_18008d6f0((longlong *)ppuVar17);
        fVar4 = *(float *)(param_1 + 0x1c);
        *(float *)(param_1 + 0x1c) = (fVar21 / fVar6) * fVar4;
        plVar9 = FUN_1800014c0();
        local_208 = (double)fVar21;
        pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  cv::format((char *)local_1e0,
                             "[Ball.BackSpinSideSpinInference] BackSpin =  Original: %.2f RPM / Used: %.2f RPM / Boost factor = %.2f%%"
                             ,(double)fVar4,(double)*(float *)(param_1 + 0x1c));
        FUN_180084c00(plVar9,pbVar10,1,'\x01');
        plVar9 = FUN_1800014c0();
        local_1f8 = (double)fVar20;
        local_200 = (double)(*(float *)(param_1 + 0x2b4) + fVar20);
        local_208 = (double)*(float *)(param_1 + 0x2b4);
        pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  cv::format((char *)local_1e0,
                             "[Ball.BackSpinSideSpinInference] Side Spin = Original: %.2f RPM / Used: %.2f RPM / Club Face = Original: %.2f degrees / Used: %.2f degrees, offset: %.2f degrees"
                             ,(double)fVar22,(double)*(float *)(param_1 + 0x20));
        FUN_180084c00(plVar9,pbVar10,1,'\x01');
        FUN_1800090b0(&local_128);
        lVar18 = (longlong)local_128 - (longlong)local_158;
        plVar9 = FUN_1800014c0();
        puVar13 = FUN_180084840(local_1e0,lVar18 / 1000);
        puVar13 = FUN_180007680(puVar13,0,
                                "[Ball.BackSpinSideSpinInference] Time to inference back spin and side spin: "
                                ,0x4c);
        local_f0 = (undefined8 *)*puVar13;
        lStack_e8 = puVar13[1];
        local_e0 = puVar13[2];
        uStack_d8 = puVar13[3];
        puVar13[3] = 0xf;
        puVar13[2] = 0;
        *(undefined1 *)puVar13 = 0;
        plVar14 = FUN_18000a490((longlong *)&local_f0,&DAT_180177694,4);
        local_110 = (undefined8 *)*plVar14;
        lStack_108 = plVar14[1];
        local_100 = plVar14[2];
        lStack_f8 = plVar14[3];
        plVar14[2] = 0;
        plVar14[3] = 0xf;
        *(undefined1 *)plVar14 = 0;
        FUN_180084c00(plVar9,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)&local_110,1,'\x01');
        FUN_18000c8d0((longlong *)&local_f0);
        FUN_18000c8d0((longlong *)local_1e0);
        if (local_b8 != (void *)0x0) {
          pvVar19 = local_b8;
          if ((0xfff < (ulonglong)((local_a8 - (longlong)local_b8 >> 2) * 4)) &&
             (pvVar19 = *(void **)((longlong)local_b8 + -8),
             0x1f < (ulonglong)((longlong)local_b8 + (-8 - (longlong)pvVar19)))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(pvVar19);
          local_b8 = (void *)0x0;
          lStack_b0 = 0;
          local_a8 = 0;
        }
        if (local_d0 != (void *)0x0) {
          pvVar19 = local_d0;
          if ((0xfff < (ulonglong)((local_c0 - (longlong)local_d0 >> 2) * 4)) &&
             (pvVar19 = *(void **)((longlong)local_d0 + -8),
             0x1f < (ulonglong)((longlong)local_d0 + (-8 - (longlong)pvVar19)))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(pvVar19);
          local_d0 = (void *)0x0;
          lStack_c8 = 0;
          local_c0 = 0;
        }
        FUN_18000c8d0(local_a0);
        return;
      }
    }
  }
                    /* WARNING: Subroutine does not return */
  FUN_180006690();
}

