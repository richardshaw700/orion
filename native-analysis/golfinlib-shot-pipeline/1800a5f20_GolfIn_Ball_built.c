FUNCTION: GolfIn::Ball::built
ENTRY: 1800a5f20
REASONS: string:Ball.Build


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Type propagation algorithm not settling */
/* public: bool __cdecl GolfIn::Ball::built(void) __ptr64 */

bool __thiscall GolfIn::Ball::built(Ball *this)

{
  Ball *pBVar1;
  Parameters *this_00;
  vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_> *pvVar2;
  int *piVar3;
  int *piVar4;
  longlong lVar5;
  longlong lVar6;
  undefined4 *puVar7;
  undefined8 *puVar8;
  Interface *pIVar9;
  void *pvVar10;
  bool bVar11;
  Interface *pIVar12;
  float *pfVar13;
  longlong lVar14;
  Parameter *pPVar15;
  Interface *pIVar16;
  longlong *plVar17;
  ulonglong uVar18;
  float *pfVar19;
  char *******pppppppcVar20;
  void *pvVar21;
  uint uVar22;
  ulonglong uVar23;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar24;
  undefined *puVar25;
  char *pcVar26;
  int *piVar27;
  undefined1 *puVar28;
  undefined4 *puVar29;
  int iVar30;
  ulonglong uVar31;
  int *piVar32;
  float *pfVar33;
  undefined4 *puVar34;
  undefined8 uVar35;
  undefined8 uVar36;
  undefined8 *******pppppppuVar37;
  size_t sVar38;
  longlong lVar39;
  float fVar40;
  double dVar41;
  double dVar42;
  undefined4 uVar43;
  float fVar44;
  float fVar45;
  float fVar46;
  float fVar47;
  float fVar48;
  undefined4 uVar49;
  undefined4 uVar50;
  undefined4 uVar51;
  undefined4 uVar52;
  undefined1 auStackY_418 [32];
  bool local_3d8 [8];
  undefined8 local_3d0;
  float local_3c8;
  longlong local_3c0;
  longlong lStack_3b8;
  longlong local_3b0;
  longlong lStack_3a8;
  float local_3a0 [2];
  undefined8 local_398;
  longlong local_390;
  undefined8 uStack_388;
  undefined8 local_380;
  undefined8 local_378;
  longlong local_370;
  longlong lStack_368;
  longlong local_360;
  longlong lStack_358;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_350 [40];
  undefined **local_328;
  longlong local_320 [4];
  undefined2 local_300 [4];
  undefined8 local_2f8 [3];
  undefined1 local_2e0 [8];
  undefined8 local_2d8 [4];
  undefined4 local_2b8;
  undefined2 local_2b4;
  undefined4 local_2b0;
  undefined8 local_2ac;
  char *******local_288;
  void *pvStack_280;
  longlong local_278;
  ulonglong local_270;
  void *local_268;
  void *pvStack_260;
  undefined8 local_258;
  undefined8 local_250;
  undefined8 *******local_248;
  undefined8 uStack_240;
  size_t local_238;
  ulonglong local_230;
  void *local_228;
  undefined4 *puStack_220;
  undefined4 *local_218;
  void *local_210;
  undefined4 *puStack_208;
  undefined4 *local_200;
  void *local_1f8;
  undefined4 *puStack_1f0;
  undefined4 *local_1e8;
  void *local_1e0;
  undefined4 *puStack_1d8;
  undefined4 *local_1d0;
  void *local_1c8;
  undefined4 *puStack_1c0;
  undefined4 *local_1b8;
  void *local_1b0;
  undefined4 *puStack_1a8;
  undefined4 *local_1a0;
  void *local_198;
  undefined4 *puStack_190;
  undefined4 *local_188;
  void *local_180;
  undefined4 *puStack_178;
  undefined4 *local_170;
  void *local_168;
  undefined4 *puStack_160;
  undefined4 *local_158;
  float *local_150;
  float *pfStack_148;
  longlong local_140;
  float *local_138;
  longlong lStack_130;
  longlong local_128;
  float *local_120;
  longlong lStack_118;
  longlong local_110;
  float *local_108;
  longlong lStack_100;
  longlong local_f8;
  float *local_f0;
  longlong lStack_e8;
  longlong local_e0;
  void *local_d8;
  longlong lStack_d0;
  longlong local_c8;
  void *local_c0;
  longlong lStack_b8;
  longlong local_b0;
  longlong local_a8;
  undefined8 uStack_a0;
  undefined8 local_98;
  ulonglong local_90;
  
                    /* 0xa5f20  420  ?built@Ball@GolfIn@@QEAA_NXZ */
  local_90 = DAT_1801d1040 ^ (ulonglong)auStackY_418;
  lVar14 = 0;
  clear_built(this);
  bVar11 = BallData::prebuilt((BallData *)(this + 0x20));
  if ((bVar11) &&
     (bVar11 = BallData::prebuilt((BallData *)(this + 0x140)), fVar48 = DAT_18017ed00,
     fVar40 = DAT_18017e9d8, bVar11)) {
    piVar32 = *(int **)(this + 0xb8);
    piVar27 = *(int **)(this + 0x1d8);
    piVar3 = *(int **)(this + 0xc0);
    piVar4 = *(int **)(this + 0x1e0);
    if ((piVar32 != piVar3) && (piVar27 != piVar4)) {
      fVar47 = 0.0;
      lVar39 = lVar14;
      do {
        if (piVar27 == piVar4) break;
        iVar30 = *piVar32;
        uVar18 = (ulonglong)iVar30;
        if (iVar30 < *piVar27) {
          piVar32 = piVar32 + 6;
        }
        else {
          if (iVar30 <= *piVar27) {
            lVar5 = *(longlong *)(this + 0xa8);
            lVar6 = *(longlong *)(this + 0xa0);
            if ((char)lVar14 == '\0') {
              if (lVar6 == lVar5) {
                return false;
              }
              if ((ulonglong)(lVar5 - lVar6 >> 3) <= uVar18) {
LAB_1800a826d:
                    /* WARNING: Subroutine does not return */
                FUN_180006690();
              }
              lVar39 = *(longlong *)(lVar6 + uVar18 * 8);
              lVar14 = 1;
            }
            else if ((ulonglong)(lVar5 - lVar6 >> 3) <= uVar18) goto LAB_1800a826d;
            fVar44 = (float)(ulonglong)(*(longlong *)(lVar6 + uVar18 * 8) - lVar39) / fVar48;
            local_3a0[0] = fVar44;
            if ((0.0 <= fVar44) && (fVar44 <= fVar40)) {
              pfVar13 = *(float **)(this + 0xf0);
              if (pfVar13 == *(float **)(this + 0xf8)) {
                FUN_180046a00((longlong *)(this + 0xe8),pfVar13,local_3a0);
              }
              else {
                *pfVar13 = fVar44;
                *(float **)(this + 0xf0) = pfVar13 + 1;
              }
              pfVar13 = *(float **)(this + 0x210);
              if (pfVar13 == *(float **)(this + 0x218)) {
                FUN_180046a00((longlong *)(this + 0x208),pfVar13,local_3a0);
              }
              else {
                *pfVar13 = fVar44;
                *(float **)(this + 0x210) = pfVar13 + 1;
              }
              local_398 = (char *******)
                          CONCAT44((float)*(int *)(this + 0xdc) + (float)piVar32[3],
                                   (float)*(int *)(this + 0xd8) + (float)piVar32[2]);
              plVar17 = *(longlong **)(this + 0x78);
              if (plVar17 == *(longlong **)(this + 0x80)) {
                FUN_1800468a0((longlong *)(this + 0x70),plVar17,&local_398);
              }
              else {
                local_398 = (char *******)
                            CONCAT44((float)*(int *)(this + 0xdc) + (float)piVar32[3],
                                     (float)*(int *)(this + 0xd8) + (float)piVar32[2]);
                *plVar17 = (longlong)local_398;
                *(longlong *)(this + 0x78) = *(longlong *)(this + 0x78) + 8;
              }
              local_3d0 = (Interface *)
                          CONCAT44((float)*(int *)(this + 0x1fc) + (float)piVar27[3],
                                   (float)*(int *)(this + 0x1f8) + (float)piVar27[2]);
              plVar17 = *(longlong **)(this + 0x198);
              if (plVar17 == *(longlong **)(this + 0x1a0)) {
                FUN_1800468a0((longlong *)(this + 400),plVar17,&local_3d0);
              }
              else {
                local_3d0 = (Interface *)
                            CONCAT44((float)*(int *)(this + 0x1fc) + (float)piVar27[3],
                                     (float)*(int *)(this + 0x1f8) + (float)piVar27[2]);
                *plVar17 = (longlong)local_3d0;
                *(longlong *)(this + 0x198) = *(longlong *)(this + 0x198) + 8;
              }
            }
            piVar32 = piVar32 + 6;
          }
          piVar27 = piVar27 + 6;
        }
      } while (piVar32 != piVar3);
      lVar14 = *(longlong *)(this + 0xe8);
      uVar18 = *(longlong *)(this + 0xf0) - lVar14 >> 2;
      if (uVar18 < 5) {
        return false;
      }
      uVar23 = 1;
      if (1 < uVar18 / 5) {
        uVar23 = uVar18 / 5;
      }
      uVar31 = uVar18 - uVar23;
      if ((uVar23 < uVar31) && (uVar31 <= uVar18)) {
        pvVar21 = (void *)(lVar14 + uVar23 * 4);
        local_228 = (void *)0x0;
        puStack_220 = (undefined4 *)0x0;
        local_218 = (undefined4 *)0x0;
        sVar38 = (lVar14 + uVar31 * 4) - (longlong)pvVar21;
        uVar18 = (longlong)sVar38 >> 2;
        if (uVar18 != 0) {
          if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
            FUN_1800075d0();
          }
          FUN_180008f50((ulonglong *)&local_228,uVar18);
          pvVar10 = local_228;
          memmove(local_228,pvVar21,sVar38);
          puStack_220 = (undefined4 *)((longlong)pvVar10 + uVar18 * 4);
        }
        local_288 = (char *******)0x0;
        pvStack_280 = (void *)0x0;
        local_278 = 0;
        FUN_1800f9600((ulonglong *)&local_288,(void *)(*(longlong *)(this + 0x70) + uVar23 * 8),
                      *(longlong *)(this + 0x70) + uVar31 * 8);
        FUN_1800f8000((ulonglong *)(this + 0xe8),(ulonglong *)&local_228);
        FUN_1800f7ca0((ulonglong *)(this + 0x70),(ulonglong *)&local_288);
        pvVar21 = (void *)(*(longlong *)(this + 0x208) + uVar23 * 4);
        local_210 = (void *)0x0;
        puStack_208 = (undefined4 *)0x0;
        local_200 = (undefined4 *)0x0;
        sVar38 = (*(longlong *)(this + 0x208) + uVar31 * 4) - (longlong)pvVar21;
        uVar18 = (longlong)sVar38 >> 2;
        if (uVar18 != 0) {
          if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
            FUN_1800075d0();
          }
          FUN_180008f50((ulonglong *)&local_210,uVar18);
          pvVar10 = local_210;
          memmove(local_210,pvVar21,sVar38);
          puStack_208 = (undefined4 *)((longlong)pvVar10 + uVar18 * 4);
        }
        FUN_18000bee0(&local_268);
        FUN_1800f9600((ulonglong *)&local_268,(void *)(*(longlong *)(this + 400) + uVar23 * 8),
                      *(longlong *)(this + 400) + uVar31 * 8);
        FUN_1800f8000((ulonglong *)(this + 0x208),(ulonglong *)&local_210);
        FUN_1800f7ca0((ulonglong *)(this + 400),(ulonglong *)&local_268);
        FID_conflict__vector<struct_CHN*___ptr64,class_std::allocator<struct_CHN*___ptr64>_>
                  ((longlong *)&local_268);
        FUN_18000c650((longlong *)&local_210);
        FID_conflict__vector<struct_CHN*___ptr64,class_std::allocator<struct_CHN*___ptr64>_>
                  ((longlong *)&local_288);
        FUN_18000c650((longlong *)&local_228);
      }
      pBVar1 = this + 0x70;
      if ((ulonglong)((longlong)(*(longlong *)(this + 0x78) - *(ulonglong *)pBVar1) >> 3) < 3) {
        return false;
      }
      if (Interface::instance_ == (Interface *)0x0) {
        pIVar12 = (Interface *)FUN_1801327e0(0x908);
        local_3d0 = pIVar12;
        memset(pIVar12,0,0x908);
        Interface::instance_ = (Interface *)Interface::Interface(pIVar12);
      }
      *(undefined4 *)(this + 0x1c) = *(undefined4 *)(Interface::instance_ + 0x5c0);
      if (this + 0x260 != this + 0xe8) {
        pvVar21 = *(void **)(this + 0xe8);
        FUN_1800fb3b0((ulonglong *)(this + 0x260),pvVar21,
                      *(longlong *)(this + 0xf0) - (longlong)pvVar21 >> 2);
      }
      if (this + 0x100 != pBVar1) {
        FUN_180006f10((ulonglong *)(this + 0x100),*(void **)pBVar1,
                      *(longlong *)(this + 0x78) - (longlong)*(void **)pBVar1 >> 3);
      }
      pvVar2 = (vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_> *)
               (this + 400);
      if ((vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_> *)
          (this + 0x220) != pvVar2) {
        FUN_180006f10((ulonglong *)(this + 0x220),*(void **)pvVar2,
                      *(longlong *)(this + 0x198) - (longlong)*(void **)pvVar2 >> 3);
      }
      local_a8 = 0;
      uStack_a0 = 0;
      uVar18 = 0;
      local_98 = 0;
      if (Interface::instance_ == (Interface *)0x0) {
        pIVar12 = (Interface *)FUN_1801327e0(0x908);
        local_3d0 = pIVar12;
        memset(pIVar12,0,0x908);
        Interface::instance_ = (Interface *)Interface::Interface(pIVar12);
      }
      Interface::get3DRectify
                (Interface::instance_,
                 (vector<class_cv::Point_<float>,class_std::allocator<class_cv::Point_<float>_>_> *)
                 (this + 0x70),pvVar2,
                 (vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_>
                  *)&local_a8);
      local_150 = (float *)0x0;
      pfStack_148 = (float *)0x0;
      local_140 = 0;
      uVar23 = *(longlong *)(this + 0x268) - *(longlong *)(this + 0x260) >> 2;
      if (uVar23 != 0) {
        if (0x3fffffffffffffff < uVar23) {
                    /* WARNING: Subroutine does not return */
          FUN_1800075d0();
        }
        FUN_180008f50((ulonglong *)&local_150,uVar23);
        pfVar13 = local_150;
        sVar38 = *(longlong *)(this + 0x268) - (longlong)*(void **)(this + 0x260);
        memmove(local_150,*(void **)(this + 0x260),sVar38);
        pfStack_148 = pfVar13 + ((longlong)sVar38 >> 2);
      }
      if (*(float **)(this + 0x260) != *(float **)(this + 0x268)) {
        fVar48 = **(float **)(this + 0x260);
        uVar23 = (ulonglong)((longlong)pfStack_148 + (3 - (longlong)local_150)) >> 2;
        if (pfStack_148 < local_150) {
          uVar23 = uVar18;
        }
        pfVar13 = local_150;
        if ((uVar23 != 0) && (0xf < uVar23)) {
          uVar31 = uVar18;
          do {
            *pfVar13 = *pfVar13 - fVar48;
            pfVar13[1] = pfVar13[1] - fVar48;
            pfVar13[2] = pfVar13[2] - fVar48;
            pfVar13[3] = pfVar13[3] - fVar48;
            pfVar13[4] = pfVar13[4] - fVar48;
            pfVar13[5] = pfVar13[5] - fVar48;
            pfVar13[6] = pfVar13[6] - fVar48;
            pfVar13[7] = pfVar13[7] - fVar48;
            pfVar13[8] = pfVar13[8] - fVar48;
            pfVar13[9] = pfVar13[9] - fVar48;
            pfVar13[10] = pfVar13[10] - fVar48;
            pfVar13[0xb] = pfVar13[0xb] - fVar48;
            pfVar13[0xc] = pfVar13[0xc] - fVar48;
            pfVar13[0xd] = pfVar13[0xd] - fVar48;
            pfVar13[0xe] = pfVar13[0xe] - fVar48;
            pfVar13[0xf] = pfVar13[0xf] - fVar48;
            pfVar13 = pfVar13 + 0x10;
            uVar31 = uVar31 + 0x10;
          } while (uVar31 != (uVar23 & 0xfffffffffffffff0));
        }
        for (; pfVar13 != pfStack_148; pfVar13 = pfVar13 + 1) {
          *pfVar13 = *pfVar13 - fVar48;
        }
      }
      local_108 = (float *)0x0;
      lStack_100 = 0;
      local_f8 = 0;
      local_120 = (float *)0x0;
      lStack_118 = 0;
      local_110 = 0;
      local_138 = (float *)0x0;
      lStack_130 = 0;
      local_128 = 0;
      bVar11 = Libraries::Core::polyFitTrajectory3D
                         ((vector<float,class_std::allocator<float>_> *)&local_150,
                          (vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_>
                           *)&local_a8,2,1,(vector<float,class_std::allocator<float>_> *)&local_108,
                          (vector<float,class_std::allocator<float>_> *)&local_120,
                          (vector<float,class_std::allocator<float>_> *)&local_138);
      pfVar13 = pfStack_148;
      if (bVar11) {
        lVar14 = *(longlong *)(this + 0x278);
        if (lVar14 != *(longlong *)(this + 0x280)) {
          *(longlong *)(this + 0x280) = lVar14;
        }
        for (pfVar33 = local_150; pfVar33 != pfVar13; pfVar33 = pfVar33 + 1) {
          fVar48 = *pfVar33;
          local_3c8 = 0.0;
          uVar31 = lStack_130 - (longlong)local_138 >> 2;
          pfVar19 = local_138;
          uVar23 = uVar18;
          fVar44 = fVar40;
          if (uVar31 != 0) {
            do {
              local_3c8 = local_3c8 + fVar44 * *pfVar19;
              uVar22 = (int)uVar23 + 1;
              pfVar19 = pfVar19 + 1;
              uVar23 = (ulonglong)uVar22;
              fVar44 = fVar44 * fVar48;
            } while ((ulonglong)(longlong)(int)uVar22 < uVar31);
          }
          fVar46 = 0.0;
          uVar31 = lStack_118 - (longlong)local_120 >> 2;
          pfVar19 = local_120;
          uVar23 = uVar18;
          fVar44 = fVar40;
          if (uVar31 != 0) {
            do {
              fVar46 = fVar46 + fVar44 * *pfVar19;
              fVar44 = fVar44 * fVar48;
              uVar22 = (int)uVar23 + 1;
              uVar23 = (ulonglong)uVar22;
              pfVar19 = pfVar19 + 1;
            } while ((ulonglong)(longlong)(int)uVar22 < uVar31);
          }
          fVar45 = 0.0;
          uVar31 = lStack_100 - (longlong)local_108 >> 2;
          pfVar19 = local_108;
          uVar23 = uVar18;
          fVar44 = fVar40;
          if (uVar31 != 0) {
            do {
              fVar45 = fVar45 + fVar44 * *pfVar19;
              uVar22 = (int)uVar23 + 1;
              pfVar19 = pfVar19 + 1;
              uVar23 = (ulonglong)uVar22;
              fVar44 = fVar44 * fVar48;
            } while ((ulonglong)(longlong)(int)uVar22 < uVar31);
          }
          local_3d0 = (Interface *)CONCAT44(fVar46,fVar45);
          plVar17 = *(longlong **)(this + 0x280);
          if (plVar17 == *(longlong **)(this + 0x288)) {
            FUN_1800466d0((longlong *)(this + 0x278),plVar17,&local_3d0);
          }
          else {
            local_3d0 = (Interface *)CONCAT44(fVar46,fVar45);
            *plVar17 = (longlong)local_3d0;
            *(float *)(plVar17 + 1) = local_3c8;
            *(longlong *)(this + 0x280) = *(longlong *)(this + 0x280) + 0xc;
          }
        }
        local_c0 = (void *)0x0;
        lStack_b8 = 0;
        local_b0 = 0;
        local_d8 = (void *)0x0;
        lStack_d0 = 0;
        local_c8 = 0;
        local_f0 = (float *)0x0;
        lStack_e8 = 0;
        local_e0 = 0;
        bVar11 = Libraries::Core::polyFitTrajectory3D
                           ((vector<float,class_std::allocator<float>_> *)&local_150,
                            (vector<class_cv::Point3_<float>,class_std::allocator<class_cv::Point3_<float>_>_>
                             *)&local_a8,1,1,(vector<float,class_std::allocator<float>_> *)&local_c0
                            ,(vector<float,class_std::allocator<float>_> *)&local_d8,
                            (vector<float,class_std::allocator<float>_> *)&local_f0);
        if (bVar11) {
          if ((ulonglong)(lStack_b8 - (longlong)local_c0 >> 2) < 2) {
            fVar40 = 0.0;
          }
          else {
            fVar40 = *(float *)((longlong)local_c0 + 4);
          }
          lVar14 = lStack_e8;
          pfVar13 = local_f0;
          if ((ulonglong)(lStack_d0 - (longlong)local_d8 >> 2) < 2) {
            fVar48 = 0.0;
          }
          else {
            fVar48 = *(float *)((longlong)local_d8 + 4);
          }
        }
        else {
          if ((ulonglong)(lStack_100 - (longlong)local_108 >> 2) < 2) {
            fVar40 = 0.0;
          }
          else {
            fVar40 = local_108[1];
          }
          lVar14 = lStack_130;
          pfVar13 = local_138;
          if ((ulonglong)(lStack_118 - (longlong)local_120 >> 2) < 2) {
            fVar48 = 0.0;
          }
          else {
            fVar48 = local_120[1];
          }
        }
        if (1 < (ulonglong)(lVar14 - (longlong)pfVar13 >> 2)) {
          fVar47 = pfVar13[1];
        }
        iVar30 = 2;
        switch(*(undefined4 *)(*(longlong *)(this + 0x290) + 0x398)) {
        case 0:
        case 1:
          iVar30 = 0;
          break;
        case 2:
        case 3:
        case 4:
        case 5:
          iVar30 = 1;
          break;
        case 6:
          break;
        default:
          iVar30 = 3;
        }
        if (Interface::instance_ == (Interface *)0x0) {
          pIVar12 = (Interface *)FUN_1801327e0(0x908);
          local_3d0 = pIVar12;
          memset(pIVar12,0,0x908);
          Interface::instance_ = (Interface *)Interface::Interface(pIVar12);
        }
        this_00 = (Parameters *)(Interface::instance_ + 0x10);
        puVar28 = &DAT_18017ccf4;
        if (iVar30 == 1) {
          puVar28 = &DAT_18017ccec;
        }
        cv::format((char *)&local_370,
                   "Configurations.Process.Player.%s.BallLaunchAngleCorrectionFactor",puVar28);
        pPVar15 = (Parameter *)
                  Libraries::Core::Parameters::operator[]
                            (this_00,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                      *)&local_328);
        dVar41 = Libraries::Core::Parameter::toDouble(pPVar15);
        local_328 = Libraries::Core::Parameter::vftable;
        _Mtx_destroy_in_situ(local_2e0);
        FUN_18000c8d0((longlong *)local_300);
        FUN_18000c8d0(local_320);
        FUN_18000c8d0(&local_370);
        cv::format((char *)&local_370,"Configurations.Process.Player.%s.BallSpeedCorrectionFactor",
                   puVar28);
        pPVar15 = (Parameter *)
                  Libraries::Core::Parameters::operator[]
                            (this_00,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                      *)&local_328);
        dVar42 = Libraries::Core::Parameter::toDouble(pPVar15);
        local_328 = Libraries::Core::Parameter::vftable;
        _Mtx_destroy_in_situ(local_2e0);
        FUN_18000c8d0((longlong *)local_300);
        FUN_18000c8d0(local_320);
        FUN_18000c8d0(&local_370);
        uVar43 = (undefined4)((ulonglong)DAT_18017eaa0 >> 0x20);
        uVar51 = SUB84(dVar41,0);
        uVar52 = (int)((ulonglong)dVar41 >> 0x20);
        if (dVar41 == 0.0) {
          uVar51 = (int)DAT_18017eaa0;
          uVar52 = uVar43;
        }
        uVar49 = SUB84(dVar42,0);
        uVar50 = (int)((ulonglong)dVar42 >> 0x20);
        if (dVar42 == 0.0) {
          uVar49 = (int)DAT_18017eaa0;
          uVar50 = uVar43;
        }
        fVar46 = fVar48 * fVar48 + fVar40 * fVar40;
        fVar44 = fVar47 * fVar47 + fVar46;
        if (fVar44 < 0.0) {
          fVar44 = sqrtf(fVar44);
        }
        else {
          fVar44 = SQRT(fVar44);
        }
        *(float *)(this + 0x10) = (float)((double)fVar44 * (double)CONCAT44(uVar50,uVar49));
        if (fVar46 < 0.0) {
          fVar46 = sqrtf(fVar46);
        }
        else {
          fVar46 = SQRT(fVar46);
        }
        dVar41 = atan2((double)fVar47,(double)fVar46);
        dVar41 = (dVar41 * DAT_18017ebc0) / DAT_18017eaf0;
        *(float *)(this + 8) =
             (float)((double)CONCAT44(uVar52,uVar51) *
                    (double)CONCAT44((uint)((ulonglong)dVar41 >> 0x20) & DAT_18017f120._4_4_,
                                     SUB84(dVar41,0) & (uint)DAT_18017f120));
        fVar40 = atan2f(fVar48,fVar40);
        dVar41 = ((double)fVar40 * DAT_18017ebc0) / DAT_18017eaf0;
        *(float *)(this + 0xc) =
             (float)(double)CONCAT44((uint)((ulonglong)dVar41 >> 0x20) ^ DAT_18017f130._4_4_,
                                     SUB84(dVar41,0) ^ (uint)DAT_18017f130);
        if (Interface::instance_ == (Interface *)0x0) {
          pIVar12 = (Interface *)FUN_1801327e0(0x908);
          local_3d0 = pIVar12;
          memset(pIVar12,0,0x908);
          Interface::instance_ = (Interface *)Interface::Interface(pIVar12);
        }
        pIVar12 = Interface::instance_;
        local_3d8[0] = false;
        local_248 = (undefined8 *******)0x0;
        uStack_240 = 0;
        local_238 = 0;
        local_230 = 0;
        FUN_18000c1d0(&local_248,"Configurations.Debug.ExtractGraph",0x21);
        bVar11 = Libraries::Core::Parameters::exist
                           ((Parameters *)(pIVar12 + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_248);
        if (bVar11) {
          pPVar15 = Libraries::Core::Parameters::get
                              ((Parameters *)(pIVar12 + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_248);
          bVar11 = Libraries::Core::Parameter::toBoolean(pPVar15);
        }
        else {
          pPVar15 = Libraries::Core::Parameters::get
                              ((Parameters *)(pIVar12 + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_248);
          Libraries::Core::Parameter::setValue(pPVar15,local_3d8);
          pPVar15 = Libraries::Core::Parameters::get
                              ((Parameters *)(pIVar12 + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_248);
          bVar11 = Libraries::Core::Parameter::toBoolean(pPVar15);
          Interface::saveParameters(pIVar12);
        }
        FUN_18000c8d0((longlong *)&local_248);
        if (bVar11 != false) {
          local_390 = 0;
          uStack_388 = 0;
          local_380 = 0;
          local_378 = 0;
          FUN_18000c1d0(&local_390,&DAT_18016a0f8,0);
          if (Interface::instance_ == (Interface *)0x0) {
            pIVar12 = (Interface *)FUN_1801327e0(0x908);
            local_3d0 = pIVar12;
            memset(pIVar12,0,0x908);
            Interface::instance_ = (Interface *)Interface::Interface(pIVar12);
          }
          pIVar9 = Interface::instance_;
          pIVar12 = Interface::instance_ + 0x2e0;
          if (Interface::instance_ == (Interface *)0x0) {
            pIVar16 = (Interface *)FUN_1801327e0(0x908);
            local_3d0 = pIVar16;
            memset(pIVar16,0,0x908);
            Interface::instance_ = (Interface *)Interface::Interface(pIVar16);
          }
          pIVar16 = Interface::instance_;
          local_288 = (char *******)0x0;
          pvStack_280 = (void *)0x0;
          local_278 = 0;
          local_270 = 0;
          FUN_18000c1d0(&local_288,"Results",7);
          plVar17 = (longlong *)Interface::getProcessImagesPath(pIVar16,local_350);
          if (0xf < *(ulonglong *)(pIVar9 + 0x2f8)) {
            pIVar12 = *(Interface **)pIVar12;
          }
          plVar17 = FUN_18000a490(plVar17,pIVar12,*(size_t *)(pIVar9 + 0x2f0));
          local_3c0 = *plVar17;
          lStack_3b8 = plVar17[1];
          local_3b0 = plVar17[2];
          lStack_3a8 = plVar17[3];
          plVar17[2] = 0;
          plVar17[3] = 0xf;
          *(undefined1 *)plVar17 = 0;
          plVar17 = &local_390;
          pbVar24 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    &local_3c0;
          Libraries::Core::updatePath
                    ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_248,pbVar24);
          FUN_18000c8d0(&local_3c0);
          FUN_18000c8d0((longlong *)local_350);
          FUN_18000c8d0((longlong *)&local_288);
          FUN_18000c8d0(&local_390);
          Libraries::Core::createAllFolders
                    ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_248);
          if (0x7fffffffffffffff - local_238 < 6) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          pppppppuVar37 = &local_248;
          if (0xf < local_230) {
            pppppppuVar37 = local_248;
          }
          FUN_18000bff0(&local_288,pbVar24,plVar17,pppppppuVar37,local_238,"\\graph",6);
          pvStack_260 = (void *)0x0;
          local_250 = 7;
          pppppppcVar20 = (char *******)&local_288;
          if (0xf < local_270) {
            pppppppcVar20 = local_288;
          }
          local_258 = 0;
          local_268 = (void *)0x0;
          boost::filesystem::detail::path_traits::convert
                    ((char *)pppppppcVar20,(char *)((longlong)pppppppcVar20 + local_278),
                     (basic_string<wchar_t,struct_std::char_traits<wchar_t>,class_std::allocator<wchar_t>_>
                      *)&local_268,(codecvt<wchar_t,char,struct__Mbstatet> *)0x0);
          boost::filesystem::detail::create_directory
                    ((path *)&local_268,(path *)0x0,(error_code *)0x0);
          FUN_180025f40((longlong *)&local_268);
          FUN_18000c8d0((longlong *)&local_288);
          local_210 = (void *)0x0;
          puStack_208 = (undefined4 *)0x0;
          local_200 = (undefined4 *)0x0;
          local_228 = (void *)0x0;
          puStack_220 = (undefined4 *)0x0;
          local_218 = (undefined4 *)0x0;
          local_168 = (void *)0x0;
          puStack_160 = (undefined4 *)0x0;
          local_158 = (undefined4 *)0x0;
          local_180 = (void *)0x0;
          puStack_178 = (undefined4 *)0x0;
          local_170 = (undefined4 *)0x0;
          local_198 = (void *)0x0;
          puStack_190 = (undefined4 *)0x0;
          local_188 = (undefined4 *)0x0;
          local_1b0 = (void *)0x0;
          puStack_1a8 = (undefined4 *)0x0;
          local_1a0 = (undefined4 *)0x0;
          local_1f8 = (void *)0x0;
          puStack_1f0 = (undefined4 *)0x0;
          local_1e8 = (undefined4 *)0x0;
          local_1c8 = (void *)0x0;
          puStack_1c0 = (undefined4 *)0x0;
          local_1b8 = (undefined4 *)0x0;
          local_1e0 = (void *)0x0;
          puStack_1d8 = (undefined4 *)0x0;
          local_1d0 = (undefined4 *)0x0;
          puVar7 = *(undefined4 **)(this + 0x280);
          puVar29 = *(undefined4 **)(this + 0x278);
          if (puVar29 != puVar7) {
            puVar34 = puVar29 + 2;
            do {
              if (puStack_208 == local_200) {
                FUN_180046a00((longlong *)&local_210,puStack_208,puVar29);
              }
              else {
                *puStack_208 = *puVar29;
                puStack_208 = puStack_208 + 1;
              }
              if (puStack_220 == local_218) {
                FUN_180046a00((longlong *)&local_228,puStack_220,puVar34);
              }
              else {
                *puStack_220 = *puVar34;
                puStack_220 = puStack_220 + 1;
              }
              if (puStack_1f0 == local_1e8) {
                FUN_180046a00((longlong *)&local_1f8,puStack_1f0,puVar29);
              }
              else {
                *puStack_1f0 = *puVar29;
                puStack_1f0 = puStack_1f0 + 1;
              }
              if (puStack_1c0 == local_1b8) {
                FUN_180046a00((longlong *)&local_1c8,puStack_1c0,puVar34 + -1);
              }
              else {
                *puStack_1c0 = puVar34[-1];
                puStack_1c0 = puStack_1c0 + 1;
              }
              if (puStack_1d8 == local_1d0) {
                FUN_180046a00((longlong *)&local_1e0,puStack_1d8,puVar34);
              }
              else {
                *puStack_1d8 = *puVar34;
                puStack_1d8 = puStack_1d8 + 1;
              }
              puVar29 = puVar29 + 3;
              puVar34 = puVar34 + 3;
            } while (puVar29 != puVar7);
          }
          puVar7 = *(undefined4 **)(this + 0x108);
          for (puVar29 = *(undefined4 **)(this + 0x100); puVar29 != puVar7; puVar29 = puVar29 + 2) {
            if (puStack_160 == local_158) {
              FUN_180046a00((longlong *)&local_168,puStack_160,puVar29);
            }
            else {
              *puStack_160 = *puVar29;
              puStack_160 = puStack_160 + 1;
            }
            if (puStack_178 == local_170) {
              FUN_180046a00((longlong *)&local_180,puStack_178,puVar29 + 1);
            }
            else {
              *puStack_178 = puVar29[1];
              puStack_178 = puStack_178 + 1;
            }
          }
          puVar7 = *(undefined4 **)(this + 0x228);
          for (puVar29 = *(undefined4 **)(this + 0x220); puVar29 != puVar7; puVar29 = puVar29 + 2) {
            if (puStack_190 == local_188) {
              FUN_180046a00((longlong *)&local_198,puStack_190,puVar29);
            }
            else {
              *puStack_190 = *puVar29;
              puStack_190 = puStack_190 + 1;
            }
            if (puStack_1a8 == local_1a0) {
              FUN_180046a00((longlong *)&local_1b0,puStack_1a8,puVar29 + 1);
            }
            else {
              *puStack_1a8 = puVar29[1];
              puStack_1a8 = puStack_1a8 + 1;
            }
          }
          local_3d0 = (Interface *)&local_328;
          puVar8 = *(undefined8 **)(this + 0x100);
          local_3c0 = 0;
          lStack_3b8 = 0;
          local_3b0 = 0;
          lStack_3a8 = 0;
          FUN_18000c1d0(&local_3c0,&DAT_18017045c,1);
          local_390 = 0;
          uStack_388 = 0;
          local_380 = 0;
          local_378 = 0;
          uVar35 = 1;
          puVar25 = &DAT_180170460;
          FUN_18000c1d0(&local_390,&DAT_180170460,1);
          if (0x7fffffffffffffff - local_238 < 7) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          pppppppuVar37 = &local_248;
          if (0xf < local_230) {
            pppppppuVar37 = local_248;
          }
          FUN_18000bff0((undefined8 *)local_350,puVar25,uVar35,pppppppuVar37,local_238,"\\graph\\",7
                       );
          plVar17 = FUN_18000a490((longlong *)local_350,"Ball_Trajectory_Camera1.png",0x1b);
          local_370 = *plVar17;
          lStack_368 = plVar17[1];
          local_360 = plVar17[2];
          lStack_358 = plVar17[3];
          plVar17[2] = 0;
          plVar17[3] = 0xf;
          *(undefined1 *)plVar17 = 0;
          local_328 = (undefined **)((ulonglong)local_328 & 0xffffffffffff0000);
          FUN_18000cb00(local_320,&local_370);
          local_300[0] = 0x100;
          FUN_18000cb00(local_2f8,&local_390);
          FUN_18000cb00(local_2d8,&local_3c0);
          local_2b8 = 0x3f800000;
          local_2b4 = 0;
          local_2b0 = 0xffffffff;
          local_2ac = *puVar8;
          local_398 = &local_268;
          local_268 = (void *)0x0;
          pvStack_260 = (void *)0x0;
          local_258 = 0;
          uVar18 = (longlong)puStack_178 - (longlong)local_180 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_268,uVar18);
            puVar7 = puStack_178;
            pvVar10 = local_180;
            pvVar21 = local_268;
            memmove(local_268,local_180,(longlong)puStack_178 - (longlong)local_180);
            pvStack_260 = (void *)((longlong)pvVar21 +
                                  ((longlong)puVar7 - (longlong)pvVar10 >> 2) * 4);
          }
          local_288 = (char *******)0x0;
          pvStack_280 = (void *)0x0;
          local_278 = 0;
          uVar18 = (longlong)puStack_160 - (longlong)local_168 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_288,uVar18);
            puVar7 = puStack_160;
            pvVar21 = local_168;
            pppppppcVar20 = local_288;
            memmove(local_288,local_168,(longlong)puStack_160 - (longlong)local_168);
            pvStack_280 = (void *)((longlong)pppppppcVar20 +
                                  ((longlong)puVar7 - (longlong)pvVar21 >> 2) * 4);
          }
          Libraries::Core::drawCartesianGraph(&local_288,&local_268,&local_328);
          FUN_18000c8d0(&local_370);
          FUN_18000c8d0((longlong *)local_350);
          FUN_18000c8d0(&local_390);
          FUN_18000c8d0(&local_3c0);
          local_3d0 = (Interface *)&local_328;
          puVar8 = *(undefined8 **)(this + 0x220);
          local_390 = 0;
          uStack_388 = 0;
          local_380 = 0;
          local_378 = 0;
          FUN_18000c1d0(&local_390,&DAT_18017045c,1);
          local_3c0 = 0;
          lStack_3b8 = 0;
          local_3b0 = 0;
          lStack_3a8 = 0;
          uVar35 = 1;
          puVar25 = &DAT_180170460;
          FUN_18000c1d0(&local_3c0,&DAT_180170460,1);
          if (0x7fffffffffffffff - local_238 < 7) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          pppppppuVar37 = &local_248;
          if (0xf < local_230) {
            pppppppuVar37 = local_248;
          }
          FUN_18000bff0((undefined8 *)local_350,puVar25,uVar35,pppppppuVar37,local_238,"\\graph\\",7
                       );
          plVar17 = FUN_18000a490((longlong *)local_350,"Ball_Trajectory_Camera2.png",0x1b);
          local_370 = *plVar17;
          lStack_368 = plVar17[1];
          local_360 = plVar17[2];
          lStack_358 = plVar17[3];
          plVar17[2] = 0;
          plVar17[3] = 0xf;
          *(undefined1 *)plVar17 = 0;
          local_328 = (undefined **)((ulonglong)local_328 & 0xffffffffffff0000);
          FUN_18000cb00(local_320,&local_370);
          local_300[0] = 0x100;
          FUN_18000cb00(local_2f8,&local_3c0);
          FUN_18000cb00(local_2d8,&local_390);
          local_2b8 = 0x3f800000;
          local_2b4 = 0;
          local_2b0 = 0xffffffff;
          local_2ac = *puVar8;
          local_398 = (char *******)&local_288;
          local_288 = (char *******)0x0;
          pvStack_280 = (void *)0x0;
          local_278 = 0;
          uVar18 = (longlong)puStack_1a8 - (longlong)local_1b0 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_288,uVar18);
            puVar7 = puStack_1a8;
            pvVar21 = local_1b0;
            pppppppcVar20 = local_288;
            memmove(local_288,local_1b0,(longlong)puStack_1a8 - (longlong)local_1b0);
            pvStack_280 = (void *)((longlong)pppppppcVar20 +
                                  ((longlong)puVar7 - (longlong)pvVar21 >> 2) * 4);
          }
          local_268 = (void *)0x0;
          pvStack_260 = (void *)0x0;
          local_258 = 0;
          uVar18 = (longlong)puStack_190 - (longlong)local_198 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_268,uVar18);
            puVar7 = puStack_190;
            pvVar10 = local_198;
            pvVar21 = local_268;
            memmove(local_268,local_198,(longlong)puStack_190 - (longlong)local_198);
            pvStack_260 = (void *)((longlong)pvVar21 +
                                  ((longlong)puVar7 - (longlong)pvVar10 >> 2) * 4);
          }
          Libraries::Core::drawCartesianGraph(&local_268,&local_288,&local_328);
          FUN_18000c8d0(&local_370);
          FUN_18000c8d0((longlong *)local_350);
          FUN_18000c8d0(&local_3c0);
          FUN_18000c8d0(&local_390);
          local_3d0 = (Interface *)&local_328;
          uVar35 = **(undefined8 **)(this + 0x278);
          local_390 = 0;
          uStack_388 = 0;
          local_380 = 0;
          local_378 = 0;
          FUN_18000c1d0(&local_390,&DAT_18017045c,1);
          local_3c0 = 0;
          lStack_3b8 = 0;
          local_3b0 = 0;
          lStack_3a8 = 0;
          uVar36 = 1;
          puVar25 = &DAT_180170460;
          FUN_18000c1d0(&local_3c0,&DAT_180170460,1);
          if (0x7fffffffffffffff - local_238 < 7) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          pppppppuVar37 = &local_248;
          if (0xf < local_230) {
            pppppppuVar37 = local_248;
          }
          FUN_18000bff0((undefined8 *)local_350,puVar25,uVar36,pppppppuVar37,local_238,"\\graph\\",7
                       );
          plVar17 = FUN_18000a490((longlong *)local_350,"Ball_Trajectory_3D.png",0x16);
          local_370 = *plVar17;
          lStack_368 = plVar17[1];
          local_360 = plVar17[2];
          lStack_358 = plVar17[3];
          plVar17[2] = 0;
          plVar17[3] = 0xf;
          *(undefined1 *)plVar17 = 0;
          local_328 = (undefined **)((ulonglong)local_328 & 0xffffffffffff0000);
          FUN_18000cb00(local_320,&local_370);
          local_300[0] = 0x100;
          FUN_18000cb00(local_2f8,&local_3c0);
          FUN_18000cb00(local_2d8,&local_390);
          local_2b8 = 0x3f000000;
          local_2b4 = 0;
          local_2b0 = 0xffffffff;
          local_398 = (char *******)&local_288;
          local_288 = (char *******)0x0;
          pvStack_280 = (void *)0x0;
          local_278 = 0;
          uVar18 = (longlong)puStack_1c0 - (longlong)local_1c8 >> 2;
          local_2ac = uVar35;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_288,uVar18);
            puVar7 = puStack_1c0;
            pvVar21 = local_1c8;
            pppppppcVar20 = local_288;
            memmove(local_288,local_1c8,(longlong)puStack_1c0 - (longlong)local_1c8);
            pvStack_280 = (void *)((longlong)pppppppcVar20 +
                                  ((longlong)puVar7 - (longlong)pvVar21 >> 2) * 4);
          }
          local_268 = (void *)0x0;
          pvStack_260 = (void *)0x0;
          local_258 = 0;
          uVar18 = (longlong)puStack_1f0 - (longlong)local_1f8 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_268,uVar18);
            puVar7 = puStack_1f0;
            pvVar10 = local_1f8;
            pvVar21 = local_268;
            memmove(local_268,local_1f8,(longlong)puStack_1f0 - (longlong)local_1f8);
            pvStack_260 = (void *)((longlong)pvVar21 +
                                  ((longlong)puVar7 - (longlong)pvVar10 >> 2) * 4);
          }
          Libraries::Core::drawCartesianGraph(&local_268,&local_288,&local_328);
          FUN_18000c8d0(&local_370);
          FUN_18000c8d0((longlong *)local_350);
          FUN_18000c8d0(&local_3c0);
          FUN_18000c8d0(&local_390);
          local_3d0 = (Interface *)&local_328;
          uVar51 = (*(undefined4 **)(this + 0x278))[2];
          uVar52 = **(undefined4 **)(this + 0x278);
          local_390 = 0;
          uStack_388 = 0;
          local_380 = 0;
          local_378 = 0;
          FUN_18000c1d0(&local_390,&DAT_18017045c,1);
          local_3c0 = 0;
          lStack_3b8 = 0;
          local_3b0 = 0;
          lStack_3a8 = 0;
          uVar35 = 1;
          puVar25 = &DAT_18016efe8;
          FUN_18000c1d0(&local_3c0,&DAT_18016efe8,1);
          if (0x7fffffffffffffff - local_238 < 7) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          pppppppuVar37 = &local_248;
          if (0xf < local_230) {
            pppppppuVar37 = local_248;
          }
          FUN_18000bff0((undefined8 *)local_350,puVar25,uVar35,pppppppuVar37,local_238,"\\graph\\",7
                       );
          plVar17 = FUN_18000a490((longlong *)local_350,"All_Trajectory_Ball_Launch_Angle.png",0x24)
          ;
          local_370 = *plVar17;
          lStack_368 = plVar17[1];
          local_360 = plVar17[2];
          lStack_358 = plVar17[3];
          plVar17[2] = 0;
          plVar17[3] = 0xf;
          *(undefined1 *)plVar17 = 0;
          local_328 = (undefined **)CONCAT62(local_328._2_6_,0x101);
          FUN_18000cb00(local_320,&local_370);
          local_300[0] = 0x100;
          FUN_18000cb00(local_2f8,&local_3c0);
          FUN_18000cb00(local_2d8,&local_390);
          local_2b8 = 0x3f800000;
          local_2b4 = 0;
          local_2b0 = 0xffffffff;
          local_2ac = CONCAT44(uVar51,uVar52);
          local_398 = (char *******)&local_288;
          local_288 = (char *******)0x0;
          pvStack_280 = (void *)0x0;
          local_278 = 0;
          uVar18 = (longlong)puStack_1d8 - (longlong)local_1e0 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_288,uVar18);
            puVar7 = puStack_1d8;
            pvVar21 = local_1e0;
            pppppppcVar20 = local_288;
            memmove(local_288,local_1e0,(longlong)puStack_1d8 - (longlong)local_1e0);
            pvStack_280 = (void *)((longlong)pppppppcVar20 +
                                  ((longlong)puVar7 - (longlong)pvVar21 >> 2) * 4);
          }
          local_268 = (void *)0x0;
          pvStack_260 = (void *)0x0;
          local_258 = 0;
          uVar18 = (longlong)puStack_1f0 - (longlong)local_1f8 >> 2;
          if (uVar18 != 0) {
            if (0x3fffffffffffffff < uVar18) {
                    /* WARNING: Subroutine does not return */
              FUN_1800075d0();
            }
            FUN_180008f50((ulonglong *)&local_268,uVar18);
            puVar7 = puStack_1f0;
            pvVar10 = local_1f8;
            pvVar21 = local_268;
            memmove(local_268,local_1f8,(longlong)puStack_1f0 - (longlong)local_1f8);
            pvStack_260 = (void *)((longlong)pvVar21 +
                                  ((longlong)puVar7 - (longlong)pvVar10 >> 2) * 4);
          }
          Libraries::Core::drawCartesianGraph(&local_268,&local_288,&local_328);
          FUN_18000c8d0(&local_370);
          FUN_18000c8d0((longlong *)local_350);
          FUN_18000c8d0(&local_3c0);
          FUN_18000c8d0(&local_390);
          if (local_1e0 != (void *)0x0) {
            pvVar21 = local_1e0;
            if ((0xfff < (ulonglong)(((longlong)local_1d0 - (longlong)local_1e0 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_1e0 + -8),
               0x1f < (ulonglong)((longlong)local_1e0 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_1e0 = (void *)0x0;
            puStack_1d8 = (undefined4 *)0x0;
            local_1d0 = (undefined4 *)0x0;
          }
          if (local_1c8 != (void *)0x0) {
            pvVar21 = local_1c8;
            if ((0xfff < (ulonglong)(((longlong)local_1b8 - (longlong)local_1c8 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_1c8 + -8),
               0x1f < (ulonglong)((longlong)local_1c8 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_1c8 = (void *)0x0;
            puStack_1c0 = (undefined4 *)0x0;
            local_1b8 = (undefined4 *)0x0;
          }
          if (local_1f8 != (void *)0x0) {
            pvVar21 = local_1f8;
            if ((0xfff < (ulonglong)(((longlong)local_1e8 - (longlong)local_1f8 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_1f8 + -8),
               0x1f < (ulonglong)((longlong)local_1f8 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_1f8 = (void *)0x0;
            puStack_1f0 = (undefined4 *)0x0;
            local_1e8 = (undefined4 *)0x0;
          }
          if (local_1b0 != (void *)0x0) {
            pvVar21 = local_1b0;
            if ((0xfff < (ulonglong)(((longlong)local_1a0 - (longlong)local_1b0 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_1b0 + -8),
               0x1f < (ulonglong)((longlong)local_1b0 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_1b0 = (void *)0x0;
            puStack_1a8 = (undefined4 *)0x0;
            local_1a0 = (undefined4 *)0x0;
          }
          if (local_198 != (void *)0x0) {
            pvVar21 = local_198;
            if ((0xfff < (ulonglong)(((longlong)local_188 - (longlong)local_198 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_198 + -8),
               0x1f < (ulonglong)((longlong)local_198 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_198 = (void *)0x0;
            puStack_190 = (undefined4 *)0x0;
            local_188 = (undefined4 *)0x0;
          }
          if (local_180 != (void *)0x0) {
            pvVar21 = local_180;
            if ((0xfff < (ulonglong)(((longlong)local_170 - (longlong)local_180 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_180 + -8),
               0x1f < (ulonglong)((longlong)local_180 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_180 = (void *)0x0;
            puStack_178 = (undefined4 *)0x0;
            local_170 = (undefined4 *)0x0;
          }
          if (local_168 != (void *)0x0) {
            pvVar21 = local_168;
            if ((0xfff < (ulonglong)(((longlong)local_158 - (longlong)local_168 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_168 + -8),
               0x1f < (ulonglong)((longlong)local_168 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_168 = (void *)0x0;
            puStack_160 = (undefined4 *)0x0;
            local_158 = (undefined4 *)0x0;
          }
          if (local_228 != (void *)0x0) {
            pvVar21 = local_228;
            if ((0xfff < (ulonglong)(((longlong)local_218 - (longlong)local_228 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_228 + -8),
               0x1f < (ulonglong)((longlong)local_228 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_228 = (void *)0x0;
            puStack_220 = (undefined4 *)0x0;
            local_218 = (undefined4 *)0x0;
          }
          if (local_210 != (void *)0x0) {
            pvVar21 = local_210;
            if ((0xfff < (ulonglong)(((longlong)local_200 - (longlong)local_210 >> 2) * 4)) &&
               (pvVar21 = *(void **)((longlong)local_210 + -8),
               0x1f < (ulonglong)((longlong)local_210 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
              _invalid_parameter_noinfo_noreturn();
            }
            free(pvVar21);
            local_210 = (void *)0x0;
            puStack_208 = (undefined4 *)0x0;
            local_200 = (undefined4 *)0x0;
          }
          FUN_18000c8d0((longlong *)&local_248);
        }
        bVar11 = true;
        if (local_f0 != (float *)0x0) {
          pfVar13 = local_f0;
          if ((0xfff < (ulonglong)((local_e0 - (longlong)local_f0 >> 2) * 4)) &&
             (pfVar13 = *(float **)(local_f0 + -2),
             0x1f < (ulonglong)((longlong)local_f0 + (-8 - (longlong)pfVar13)))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(pfVar13);
          local_f0 = (float *)0x0;
          lStack_e8 = 0;
          local_e0 = 0;
        }
        if (local_d8 != (void *)0x0) {
          pvVar21 = local_d8;
          if ((0xfff < (ulonglong)((local_c8 - (longlong)local_d8 >> 2) * 4)) &&
             (pvVar21 = *(void **)((longlong)local_d8 + -8),
             0x1f < (ulonglong)((longlong)local_d8 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(pvVar21);
          local_d8 = (void *)0x0;
          lStack_d0 = 0;
          local_c8 = 0;
        }
        if (local_c0 != (void *)0x0) {
          pvVar21 = local_c0;
          if ((0xfff < (ulonglong)((local_b0 - (longlong)local_c0 >> 2) * 4)) &&
             (pvVar21 = *(void **)((longlong)local_c0 + -8),
             0x1f < (ulonglong)((longlong)local_c0 + (-8 - (longlong)pvVar21)))) {
                    /* WARNING: Subroutine does not return */
            _invalid_parameter_noinfo_noreturn();
          }
          free(pvVar21);
          local_c0 = (void *)0x0;
          lStack_b8 = 0;
          local_b0 = 0;
        }
      }
      else {
        bVar11 = false;
      }
      if (local_138 != (float *)0x0) {
        pfVar13 = local_138;
        if ((0xfff < (ulonglong)((local_128 - (longlong)local_138 >> 2) * 4)) &&
           (pfVar13 = *(float **)(local_138 + -2),
           0x1f < (ulonglong)((longlong)local_138 + (-8 - (longlong)pfVar13)))) {
                    /* WARNING: Subroutine does not return */
          _invalid_parameter_noinfo_noreturn();
        }
        free(pfVar13);
        local_138 = (float *)0x0;
        lStack_130 = 0;
        local_128 = 0;
      }
      if (local_120 != (float *)0x0) {
        pfVar13 = local_120;
        if ((0xfff < (ulonglong)((local_110 - (longlong)local_120 >> 2) * 4)) &&
           (pfVar13 = *(float **)(local_120 + -2),
           0x1f < (ulonglong)((longlong)local_120 + (-8 - (longlong)pfVar13)))) {
                    /* WARNING: Subroutine does not return */
          _invalid_parameter_noinfo_noreturn();
        }
        free(pfVar13);
        local_120 = (float *)0x0;
        lStack_118 = 0;
        local_110 = 0;
      }
      if (local_108 != (float *)0x0) {
        pfVar13 = local_108;
        if ((0xfff < (ulonglong)((local_f8 - (longlong)local_108 >> 2) * 4)) &&
           (pfVar13 = *(float **)(local_108 + -2),
           0x1f < (ulonglong)((longlong)local_108 + (-8 - (longlong)pfVar13)))) {
                    /* WARNING: Subroutine does not return */
          _invalid_parameter_noinfo_noreturn();
        }
        free(pfVar13);
        local_108 = (float *)0x0;
        lStack_100 = 0;
        local_f8 = 0;
      }
      if (local_150 != (float *)0x0) {
        pfVar13 = local_150;
        if ((0xfff < (ulonglong)((local_140 - (longlong)local_150 >> 2) * 4)) &&
           (pfVar13 = *(float **)(local_150 + -2),
           0x1f < (ulonglong)((longlong)local_150 + (-8 - (longlong)pfVar13)))) {
                    /* WARNING: Subroutine does not return */
          _invalid_parameter_noinfo_noreturn();
        }
        free(pfVar13);
        local_150 = (float *)0x0;
        pfStack_148 = (float *)0x0;
        local_140 = 0;
      }
      FUN_180043090(&local_a8);
      return bVar11;
    }
    plVar17 = FUN_1800014c0();
    sVar38 = 0x27;
    pcVar26 = "[Ball.Build] No detections after impact";
  }
  else {
    plVar17 = FUN_1800014c0();
    sVar38 = 0x22;
    pcVar26 = "[Ball.Build] Fail on ball prebuilt";
  }
  lStack_3a8 = 0;
  local_3b0 = 0;
  local_3c0 = 0;
  lStack_3b8 = 0;
  FUN_18000c1d0(&local_3c0,pcVar26,sVar38);
  FUN_180084c00(plVar17,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_3c0,3,'\x01');
  return false;
}

