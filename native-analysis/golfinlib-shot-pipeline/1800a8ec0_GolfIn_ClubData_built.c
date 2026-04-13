FUNCTION: GolfIn::ClubData::built
ENTRY: 1800a8ec0
REASONS: name:club; string:Club.Build


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: bool __cdecl GolfIn::ClubData::built(class GolfIn::BallData const & __ptr64) __ptr64 */

bool __thiscall GolfIn::ClubData::built(ClubData *this,BallData *param_1)

{
  vector<float,class_std::allocator<float>_> *pvVar1;
  vector<float,class_std::allocator<float>_> *pvVar2;
  undefined8 *puVar3;
  ulonglong uVar4;
  ulonglong uVar5;
  int *piVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  float fVar9;
  float fVar10;
  bool bVar11;
  int iVar12;
  float *pfVar13;
  longlong *plVar15;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar16;
  undefined8 ****ppppuVar17;
  void *pvVar18;
  float *pfVar19;
  void *pvVar20;
  char *pcVar21;
  longlong lVar22;
  undefined1 (*pauVar23) [32];
  ClubData *pCVar24;
  size_t sVar25;
  ClubData *pCVar26;
  float fVar27;
  float fVar28;
  float fVar29;
  undefined1 auStackY_158 [32];
  undefined8 local_118;
  undefined8 local_110;
  undefined8 local_108;
  undefined8 uStack_100;
  undefined8 local_f8;
  undefined8 local_f0;
  float *local_e8;
  float *pfStack_e0;
  float *local_d8;
  undefined4 local_d0;
  undefined4 uStack_cc;
  undefined1 (*pauStack_c8) [32];
  undefined1 (*local_c0) [32];
  void *local_b8;
  longlong lStack_b0;
  longlong local_a8;
  undefined8 ***local_a0;
  undefined8 uStack_98;
  longlong local_90;
  ulonglong local_88;
  ulonglong local_80;
  float *pfVar14;
  
                    /* 0xa8ec0  422  ?built@ClubData@GolfIn@@QEAA_NAEBVBallData@2@@Z */
  local_80 = DAT_1801d1040 ^ (ulonglong)auStackY_158;
  fVar27 = 0.0;
  local_d0 = 0;
  uStack_cc = 0;
  pauStack_c8 = (undefined1 (*) [32])0x0;
  local_c0 = (undefined1 (*) [32])0x0;
  local_e8 = (float *)0x0;
  pfStack_e0 = (float *)0x0;
  local_d8 = (float *)0x0;
  if (*(longlong *)(this + 0x38) != *(longlong *)(this + 0x40)) {
    *(longlong *)(this + 0x40) = *(longlong *)(this + 0x38);
  }
  iVar12 = (int)(*(longlong *)(this + 0x28) - *(longlong *)(this + 0x20) >> 3) + -1;
  lVar22 = (longlong)iVar12;
  if (-1 < iVar12) {
    do {
      fVar27 = (float)*(int *)(*(longlong *)(this + 8) + lVar22 * 4);
      local_110 = CONCAT44(local_110._4_4_,fVar27);
      if (pauStack_c8 == local_c0) {
        FUN_180046a00((longlong *)&local_d0,pauStack_c8,(undefined4 *)&local_110);
      }
      else {
        *(float *)*pauStack_c8 = fVar27;
        pauStack_c8 = (undefined1 (*) [32])((longlong)*pauStack_c8 + 4);
      }
      fVar27 = (float)*(int *)(this + 0xb4) +
               *(float *)(*(longlong *)(this + 0x20) + 4 + lVar22 * 8);
      fVar28 = (float)*(int *)(this + 0xb0) + *(float *)(*(longlong *)(this + 0x20) + lVar22 * 8);
      local_118 = CONCAT44(fVar27,fVar28);
      puVar3 = *(undefined8 **)(this + 0x40);
      if (puVar3 == *(undefined8 **)(this + 0x48)) {
        FUN_1800468a0((longlong *)(this + 0x38),puVar3,&local_118);
      }
      else {
        local_118 = CONCAT44(fVar27,fVar28);
        *puVar3 = local_118;
        *(longlong *)(this + 0x40) = *(longlong *)(this + 0x40) + 8;
      }
      lVar22 = lVar22 + -1;
    } while (-1 < lVar22);
  }
  pfVar19 = *(float **)(this + 0x38);
  pfVar13 = *(float **)(this + 0x40);
  if (pfVar19 != *(float **)(this + 0x40)) {
    do {
      pfVar14 = pfVar13 + -2;
      if (pfVar19 == pfVar14) break;
      fVar27 = *pfVar19;
      fVar28 = pfVar19[1];
      *(undefined8 *)pfVar19 = *(undefined8 *)pfVar14;
      *pfVar14 = fVar27;
      pfVar13[-1] = fVar28;
      pfVar19 = pfVar19 + 2;
      pfVar13 = pfVar14;
    } while (pfVar19 != pfVar14);
  }
  fVar10 = DAT_18017ed04;
  fVar9 = DAT_18017ed00;
  fVar28 = DAT_18017e9d8;
  pauVar23 = (undefined1 (*) [32])CONCAT44(uStack_cc,local_d0);
  if (pauVar23 == pauStack_c8) {
    plVar15 = FUN_1800014c0();
    sVar25 = 0x17;
    pcVar21 = "[Club.Build] No indexes";
  }
  else {
    if (*(longlong *)(this + 0x70) != *(longlong *)(this + 0x78)) {
      fVar29 = *(float *)(pauStack_c8[-1] + 0x1c);
      if (DAT_18017ed04 <= fVar29) {
        fVar29 = fVar29 - DAT_18017ed04;
      }
      uVar4 = *(ulonglong *)(*(longlong *)(this + 0x70) + (longlong)fVar29 * 8);
      do {
        fVar29 = *(float *)*pauVar23;
        if (fVar10 <= fVar29) {
          fVar29 = fVar29 - fVar10;
        }
        uVar5 = *(ulonglong *)(*(longlong *)(this + 0x70) + (longlong)fVar29 * 8);
        if (uVar5 < uVar4) {
          plVar15 = FUN_1800014c0();
          fVar29 = *(float *)*pauVar23;
          if (fVar10 <= fVar29) {
            fVar29 = fVar29 - fVar10;
          }
          pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    cv::format((char *)&local_108,"[Club.Build] Invalid timestamp detected: %llu",
                               *(undefined8 *)(*(longlong *)(this + 0x70) + (longlong)fVar29 * 8));
LAB_1800a91ed:
          FUN_180084c00(plVar15,pbVar16,3,'\x01');
        }
        else {
          fVar29 = (float)(uVar5 - uVar4) / fVar9;
          local_110 = CONCAT44(local_110._4_4_,fVar29);
          if ((fVar29 < 0.0) || (fVar28 < fVar29)) {
            plVar15 = FUN_1800014c0();
            pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)cv::format((char *)&local_108,
                                    "[Club.Build] Invalid delta time: %f. Less than 0 or higher than 1"
                                    ,(double)fVar29);
            goto LAB_1800a91ed;
          }
          if (pfStack_e0 == local_d8) {
            FUN_180046a00((longlong *)&local_e8,pfStack_e0,(undefined4 *)&local_110);
          }
          else {
            *pfStack_e0 = fVar29;
            pfStack_e0 = pfStack_e0 + 1;
          }
        }
        pauVar23 = (undefined1 (*) [32])((longlong)*pauVar23 + 4);
      } while (pauVar23 != pauStack_c8);
      FUN_1801325c0((undefined1 (*) [32])CONCAT44(uStack_cc,local_d0),pauStack_c8);
      local_a0 = (undefined8 ****)0x0;
      uStack_98 = 0;
      local_90 = 0;
      local_88 = 0;
      pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x0;
      FUN_18000c1d0(&local_a0,&DAT_18016a0f8,0);
      local_b8 = (void *)0x0;
      lStack_b0 = 0;
      local_a8 = 0;
      Libraries::Core::findAberrant
                ((vector<float,class_std::allocator<float>_> *)&local_b8,fVar27,pbVar16);
      ppppuVar17 = &local_a0;
      if (0xf < local_88) {
        ppppuVar17 = (undefined8 ****)local_a0;
      }
      lVar22 = local_90;
      if ((local_90 != 0) || (iVar12 = memcmp(ppppuVar17,&DAT_18016a0f8,0), iVar12 != 0)) {
        plVar15 = FUN_1800014c0();
        if (0x7fffffffffffffffU - local_90 < 0x23) {
                    /* WARNING: Subroutine does not return */
          FUN_18000c940();
        }
        ppppuVar17 = &local_a0;
        if (0xf < local_88) {
          ppppuVar17 = (undefined8 ****)local_a0;
        }
        FUN_18000bff0(&local_108,local_90,lVar22,"[Club.Build] Find aberrant errors: ",0x23,
                      ppppuVar17,local_90);
        FUN_180084c00(plVar15,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_108,3,'\x01');
      }
      iVar12 = (int)(lStack_b0 - (longlong)local_b8 >> 2) + -1;
      lVar22 = (longlong)iVar12;
      if (-1 < iVar12) {
        do {
          plVar15 = FUN_1800014c0();
          pCVar26 = this + 400;
          if (0xf < *(ulonglong *)(this + 0x1a8)) {
            pCVar26 = *(ClubData **)(this + 400);
          }
          pbVar16 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    cv::format((char *)&local_108,"[Club.Build] %s - Filtered out buffer_index %d",
                               pCVar26,(ulonglong)*(uint *)((longlong)local_b8 + lVar22 * 4));
          FUN_180084c00(plVar15,pbVar16,2,'\x01');
          pfVar19 = local_e8 + *(int *)((longlong)local_b8 + lVar22 * 4);
          memmove(pfVar19,pfVar19 + 1,(longlong)pfStack_e0 - (longlong)(pfVar19 + 1));
          pfStack_e0 = pfStack_e0 + -1;
          pvVar20 = (void *)(CONCAT44(uStack_cc,local_d0) +
                            (longlong)*(int *)((longlong)local_b8 + lVar22 * 4) * 4);
          pvVar18 = (void *)((longlong)pvVar20 + 4);
          memmove(pvVar20,pvVar18,(longlong)pauStack_c8 - (longlong)pvVar18);
          pauStack_c8 = (undefined1 (*) [32])(pauStack_c8[-1] + 0x1c);
          pvVar20 = (void *)(*(longlong *)(this + 0x38) +
                            (longlong)*(int *)((longlong)local_b8 + lVar22 * 4) * 8);
          pvVar18 = (void *)((longlong)pvVar20 + 8);
          memmove(pvVar20,pvVar18,*(longlong *)(this + 0x40) - (longlong)pvVar18);
          *(longlong *)(this + 0x40) = *(longlong *)(this + 0x40) + -8;
          lVar22 = lVar22 + -1;
        } while (-1 < lVar22);
      }
      if ((ulonglong)(*(longlong *)(this + 0x40) - *(longlong *)(this + 0x38) >> 3) < 3) {
        plVar15 = FUN_1800014c0();
        sVar25 = 0x52;
        pcVar21 = 
        "[Club.Build] After filtering, less than two detection for detections. No tendency!";
LAB_1800a9441:
        local_108 = 0;
        uStack_100 = 0;
        local_f8 = 0;
        local_f0 = 0;
        FUN_18000c1d0(&local_108,pcVar21,sVar25);
        FUN_180084c00(plVar15,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_108,3,'\x01');
        bVar11 = false;
      }
      else {
        pvVar1 = (vector<float,class_std::allocator<float>_> *)(this + 0x168);
        pvVar2 = (vector<float,class_std::allocator<float>_> *)(this + 0x150);
        bVar11 = Libraries::Core::polyFitTrajectory
                           ((vector<float,class_std::allocator<float>_> *)&local_e8,
                            (vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_>
                             *)(this + 0x38),(int *)&DAT_18016cd18,pvVar2,pvVar1);
        if (!bVar11) {
          plVar15 = FUN_1800014c0();
          sVar25 = 0x2b;
          pcVar21 = "[Club.Build] FAIL to built club on polyfit!";
          goto LAB_1800a9441;
        }
        lVar22 = *(longlong *)(this + 0xe8);
        if (lVar22 != *(longlong *)(this + 0xf0)) {
          *(longlong *)(this + 0xf0) = lVar22;
        }
        pCVar26 = this + 0xd0;
        if (*(ulonglong *)pCVar26 != *(ulonglong *)(this + 0xd8)) {
          *(ulonglong *)(this + 0xd8) = *(ulonglong *)pCVar26;
        }
        pCVar24 = this + 0x100;
        if (*(longlong *)pCVar24 != *(longlong *)(this + 0x108)) {
          *(longlong *)(this + 0x108) = *(longlong *)pCVar24;
        }
        pauVar23 = (undefined1 (*) [32])CONCAT44(uStack_cc,local_d0);
        if (pauVar23 != pauStack_c8) {
          do {
            local_110 = CONCAT44(local_110._4_4_,(int)*(float *)*pauVar23);
            piVar6 = *(int **)(this + 0xf0);
            if (piVar6 == *(int **)(this + 0xf8)) {
              FUN_180046a00((longlong *)(this + 0xe8),piVar6,(undefined4 *)&local_110);
            }
            else {
              *piVar6 = (int)*(float *)*pauVar23;
              *(longlong *)(this + 0xf0) = *(longlong *)(this + 0xf0) + 4;
            }
            pauVar23 = (undefined1 (*) [32])((longlong)*pauVar23 + 4);
          } while (pauVar23 != pauStack_c8);
        }
        pfVar19 = local_e8;
        if (local_e8 != pfStack_e0) {
          do {
            uVar7 = DAT_1801d1200;
            uVar8 = DAT_1801d1204;
            if ((*(longlong *)pvVar2 != *(longlong *)(this + 0x158)) &&
               (*(longlong *)pvVar1 != *(longlong *)(this + 0x170))) {
              local_118 = CONCAT44(DAT_1801d1204,DAT_1801d1200);
              bVar11 = Libraries::Core::polyFitFindPoint
                                 (pvVar2,pvVar1,pfVar19,(Point_<float> *)&local_118);
              uVar7 = DAT_1801d1200;
              uVar8 = DAT_1801d1204;
              if (bVar11) {
                uVar7 = (undefined4)local_118;
                uVar8 = local_118._4_4_;
              }
            }
            local_110 = CONCAT44(uVar8,uVar7);
            puVar3 = *(undefined8 **)(this + 0x108);
            if (puVar3 == *(undefined8 **)(this + 0x110)) {
              FUN_1800468a0((longlong *)pCVar24,puVar3,&local_110);
            }
            else {
              local_110 = CONCAT44(uVar8,uVar7);
              *puVar3 = local_110;
              *(longlong *)(this + 0x108) = *(longlong *)(this + 0x108) + 8;
            }
            pfVar19 = pfVar19 + 1;
          } while (pfVar19 != pfStack_e0);
        }
        if (pCVar26 != (ClubData *)&local_e8) {
          FUN_1800fb3b0((ulonglong *)pCVar26,local_e8,(longlong)pfStack_e0 - (longlong)local_e8 >> 2
                       );
        }
        bVar11 = *(longlong *)pCVar24 != *(longlong *)(this + 0x108);
      }
      if (local_b8 != (void *)0x0) {
        pvVar18 = local_b8;
        if ((0xfff < (ulonglong)((local_a8 - (longlong)local_b8 >> 2) * 4)) &&
           (pvVar18 = *(void **)((longlong)local_b8 + -8),
           0x1f < (ulonglong)((longlong)local_b8 + (-8 - (longlong)pvVar18)))) {
                    /* WARNING: Subroutine does not return */
          _invalid_parameter_noinfo_noreturn();
        }
        free(pvVar18);
        local_b8 = (void *)0x0;
        lStack_b0 = 0;
        local_a8 = 0;
      }
      FUN_18000c8d0((longlong *)&local_a0);
      goto LAB_1800a964c;
    }
    plVar15 = FUN_1800014c0();
    sVar25 = 0x20;
    pcVar21 = "[Club.Build] No frames timestamp";
  }
  local_108 = 0;
  uStack_100 = 0;
  local_f8 = 0;
  local_f0 = 0;
  FUN_18000c1d0(&local_108,pcVar21,sVar25);
  FUN_180084c00(plVar15,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_108,3,'\x01');
  bVar11 = false;
LAB_1800a964c:
  if (local_e8 != (float *)0x0) {
    pfVar19 = local_e8;
    if ((0xfff < (ulonglong)(((longlong)local_d8 - (longlong)local_e8 >> 2) * 4)) &&
       (pfVar19 = *(float **)(local_e8 + -2),
       0x1f < (ulonglong)((longlong)local_e8 + (-8 - (longlong)pfVar19)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pfVar19);
    local_e8 = (float *)0x0;
    pfStack_e0 = (float *)0x0;
    local_d8 = (float *)0x0;
  }
  pvVar18 = (void *)CONCAT44(uStack_cc,local_d0);
  if (pvVar18 != (void *)0x0) {
    pvVar20 = pvVar18;
    if ((0xfff < ((longlong)local_c0 - (longlong)pvVar18 & 0xfffffffffffffffcU)) &&
       (pvVar20 = *(void **)((longlong)pvVar18 + -8),
       0x1f < (ulonglong)((longlong)pvVar18 + (-8 - (longlong)pvVar20)))) {
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar20);
  }
  return bVar11;
}

