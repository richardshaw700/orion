FUNCTION: GolfIn::Interface::_extractClubTracking
ENTRY: 1800f5f30
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* protected: bool __cdecl GolfIn::Interface::_extractClubTracking(class std::deque<struct
   GolfIn::Interface::ExtractedClubTrackingResults,class std::allocator<struct
   GolfIn::Interface::ExtractedClubTrackingResults> > * __ptr64,int,int,int,int,class
   cv::Point_<int> const & __ptr64,class std::vector<class cv::Mat,class std::allocator<class
   cv::Mat> > const & __ptr64,class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const & __ptr64,class std::shared_ptr<class
   GolfIn::Detection::ClubDetection>,enum GolfIn::TrackingMethod const & __ptr64) __ptr64 */

bool __thiscall
GolfIn::Interface::_extractClubTracking
          (Interface *this,longlong param_1,int param_2,float param_3,int param_4,int param_5,
          int *param_6,longlong *param_7,undefined8 *param_8,undefined8 *param_10,
          undefined4 *param_11)

{
  int *piVar1;
  longlong *plVar2;
  longlong lVar3;
  longlong *plVar4;
  int iVar5;
  undefined8 uVar6;
  undefined8 *puVar7;
  ulonglong uVar8;
  int iVar9;
  ulonglong uVar10;
  Interface *pIVar11;
  undefined8 *puVar12;
  undefined1 auStack_1a8 [32];
  undefined8 *local_188;
  undefined8 *local_180;
  int local_178;
  undefined4 **local_170;
  int local_168;
  undefined8 *local_160;
  undefined8 *local_158;
  float local_150;
  float local_14c;
  Interface *local_148;
  ulonglong local_140;
  undefined4 *local_138;
  undefined8 uStack_130;
  float local_128;
  float local_124;
  longlong *local_120;
  undefined4 *local_118;
  undefined8 uStack_110;
  undefined8 *local_108;
  undefined8 local_100 [4];
  undefined4 local_e0;
  char cStack_dc;
  char cStack_db;
  undefined2 uStack_da;
  undefined8 uStack_d8;
  undefined8 local_d0;
  undefined8 uStack_c8;
  undefined8 local_c0;
  undefined8 uStack_b8;
  undefined4 local_b0;
  undefined4 uStack_ac;
  undefined8 uStack_a8;
  undefined8 local_a0;
  undefined8 uStack_98;
  undefined8 local_90;
  undefined8 uStack_88;
  undefined8 local_80;
  undefined8 uStack_78;
  undefined8 local_70;
  undefined8 uStack_68;
  undefined8 local_60;
  undefined8 uStack_58;
  undefined8 local_50;
  undefined8 uStack_48;
  ulonglong local_40;
  
                    /* 0xf5f30  402
                       ?_extractClubTracking@Interface@GolfIn@@IEAA_NPEAV?$deque@UExtractedClubTrackingResults@Interface@GolfIn@@V?$allocator@UExtractedClubTrackingResults@Interface@GolfIn@@@std@@@std@@HHHHAEBV?$Point_@H@cv@@AEBV?$vector@VMat@cv@@V?$allocator@VMat@cv@@@std@@@4@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@4@V?$shared_ptr@VClubDetection@Detection@GolfIn@@@4@AEBW4TrackingMethod@2@@Z
                        */
  local_40 = DAT_1801d1040 ^ (ulonglong)auStack_1a8;
  local_120 = param_7;
  local_160 = param_8;
  local_158 = param_10;
  local_108 = param_10;
  local_138 = param_11;
  local_168 = param_2;
  local_150 = param_3;
  local_148 = this;
  if ((int)param_3 < param_2) {
    do {
      if (*(longlong *)(param_1 + 0x20) == 0) {
        puVar7 = (undefined8 *)&DAT_1801d1218;
      }
      else {
        puVar7 = (undefined8 *)
                 (*(longlong *)
                   (*(longlong *)(param_1 + 8) +
                   (*(longlong *)(param_1 + 0x10) - 1U &
                   *(longlong *)(param_1 + 0x20) + *(longlong *)(param_1 + 0x18) + -1) * 8) + 8);
      }
      local_80 = *puVar7;
      uStack_78 = puVar7[1];
      local_70 = puVar7[2];
      uStack_68 = puVar7[3];
      if (local_158[1] != 0) {
        LOCK();
        piVar1 = (int *)(local_158[1] + 8);
        *piVar1 = *piVar1 + 1;
        UNLOCK();
      }
      local_118 = (undefined4 *)*local_158;
      uStack_110 = local_158[1];
      local_124 = (float)param_6[1];
      local_128 = (float)*param_6;
      local_170 = &local_118;
      local_180 = &local_80;
      local_188 = local_160;
      local_178 = param_2;
      extractClubTracking_OpticalFlow
                (local_148,&local_e0,(longlong)param_2 * 0x60 + *local_120,&local_128);
      if (*(ulonglong *)(param_1 + 0x10) <= *(longlong *)(param_1 + 0x20) + 1U) {
        FUN_1800fba00(param_1);
      }
      uVar8 = *(longlong *)(param_1 + 0x10) - 1;
      local_140 = uVar8 & *(ulonglong *)(param_1 + 0x18);
      *(ulonglong *)(param_1 + 0x18) = local_140;
      local_140 = *(longlong *)(param_1 + 0x20) + local_140;
      uVar8 = local_140 & uVar8;
      if (*(longlong *)(*(longlong *)(param_1 + 8) + uVar8 * 8) == 0) {
        uVar6 = FUN_1801327e0(0x30);
        *(undefined8 *)(*(longlong *)(param_1 + 8) + uVar8 * 8) = uVar6;
      }
      puVar7 = *(undefined8 **)
                (*(longlong *)(param_1 + 8) + (*(longlong *)(param_1 + 0x10) - 1U & local_140) * 8);
      *puVar7 = CONCAT26(uStack_da,CONCAT15(cStack_db,CONCAT14(cStack_dc,local_e0)));
      puVar7[1] = uStack_d8;
      puVar7[2] = local_d0;
      puVar7[3] = uStack_c8;
      puVar7[4] = local_c0;
      puVar7[5] = uStack_b8;
      *(longlong *)(param_1 + 0x20) = *(longlong *)(param_1 + 0x20) + 1;
      if (cStack_db != '\0') break;
      if (cStack_dc == '\0') {
        plVar4 = (longlong *)local_158[1];
        if (plVar4 != (longlong *)0x0) {
          LOCK();
          plVar2 = plVar4 + 1;
          lVar3 = *plVar2;
          *(int *)plVar2 = (int)*plVar2 + -1;
          UNLOCK();
          if ((int)lVar3 == 1) {
            (**(code **)*plVar4)(plVar4);
            LOCK();
            piVar1 = (int *)((longlong)plVar4 + 0xc);
            iVar9 = *piVar1;
            *piVar1 = *piVar1 + -1;
            UNLOCK();
            if (iVar9 == 1) {
              (**(code **)(*plVar4 + 8))(plVar4);
            }
          }
        }
        return false;
      }
      param_2 = param_2 - param_4;
    } while ((int)local_150 < param_2);
  }
  puVar12 = local_158;
  iVar5 = local_168;
  puVar7 = FUN_18000cb00(local_100,local_160);
  pIVar11 = local_148;
  loadTracker(local_148,*local_138,puVar7);
  puVar7 = local_188;
  local_188 = local_160;
  for (iVar9 = iVar5; local_160 = local_188, iVar9 <= param_5 + iVar5; iVar9 = iVar9 + param_4) {
    lVar3 = *(longlong *)
             (*(longlong *)(param_1 + 8) +
             (*(longlong *)(param_1 + 0x10) - 1U & *(ulonglong *)(param_1 + 0x18)) * 8);
    local_60 = *(undefined8 *)(lVar3 + 8);
    uStack_58 = *(undefined8 *)(lVar3 + 0x10);
    local_50 = *(undefined8 *)(lVar3 + 0x18);
    uStack_48 = *(undefined8 *)(lVar3 + 0x20);
    if (puVar12[1] != 0) {
      LOCK();
      piVar1 = (int *)(puVar12[1] + 8);
      *piVar1 = *piVar1 + 1;
      UNLOCK();
    }
    local_138 = (undefined4 *)*puVar12;
    uStack_130 = puVar12[1];
    local_180 = &local_60;
    if (iVar9 == iVar5) {
      local_180 = (undefined8 *)&DAT_1801d1218;
    }
    local_14c = (float)param_6[1];
    local_150 = (float)*param_6;
    local_170 = &local_138;
    local_178 = iVar9;
    extractClubTracking_OpticalFlow
              (pIVar11,&local_b0,(longlong)iVar9 * 0x60 + *local_120,&local_150);
    if ((iVar9 != iVar5) && ((char)uStack_ac != '\0')) {
      if (*(ulonglong *)(param_1 + 0x10) <= *(longlong *)(param_1 + 0x20) + 1U) {
        FUN_1800fba00(param_1);
      }
      uVar8 = *(ulonglong *)(param_1 + 0x10) - 1;
      uVar10 = uVar8 & *(ulonglong *)(param_1 + 0x18);
      *(ulonglong *)(param_1 + 0x18) = uVar10;
      if (uVar10 == 0) {
        uVar10 = *(ulonglong *)(param_1 + 0x10);
      }
      uVar10 = uVar10 - 1;
      uVar8 = uVar8 & uVar10;
      if (*(longlong *)(*(longlong *)(param_1 + 8) + uVar8 * 8) == 0) {
        uVar6 = FUN_1801327e0(0x30);
        *(undefined8 *)(*(longlong *)(param_1 + 8) + uVar8 * 8) = uVar6;
      }
      puVar7 = *(undefined8 **)
                (*(longlong *)(param_1 + 8) + (*(longlong *)(param_1 + 0x10) - 1U & uVar10) * 8);
      *puVar7 = CONCAT44(uStack_ac,local_b0);
      puVar7[1] = uStack_a8;
      puVar7[2] = local_a0;
      puVar7[3] = uStack_98;
      puVar7[4] = local_90;
      puVar7[5] = uStack_88;
      *(ulonglong *)(param_1 + 0x18) = uVar10;
      *(longlong *)(param_1 + 0x20) = *(longlong *)(param_1 + 0x20) + 1;
      pIVar11 = local_148;
      puVar12 = local_158;
    }
    puVar7 = local_188;
    local_188 = local_160;
  }
  plVar4 = (longlong *)puVar12[1];
  if (plVar4 != (longlong *)0x0) {
    LOCK();
    plVar2 = plVar4 + 1;
    lVar3 = *plVar2;
    *(int *)plVar2 = (int)*plVar2 + -1;
    UNLOCK();
    if ((int)lVar3 == 1) {
      local_188 = puVar7;
      (**(code **)*plVar4)(plVar4);
      LOCK();
      piVar1 = (int *)((longlong)plVar4 + 0xc);
      iVar9 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar9 == 1) {
        (**(code **)(*plVar4 + 8))(plVar4);
      }
    }
  }
  return true;
}

