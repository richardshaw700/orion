FUNCTION: GolfIn::Shot::drawClubData
ENTRY: 1800b29f0
REASONS: name:club


/* private: void __cdecl GolfIn::Shot::drawClubData(class GolfIn::ClubData & __ptr64,class cv::Mat &
   __ptr64,int,bool const & __ptr64) __ptr64 */

void __thiscall
GolfIn::Shot::drawClubData(Shot *this,ClubData *param_1,Mat *param_2,int param_3,bool *param_4)

{
  uint uVar1;
  uint *puVar2;
  float fVar3;
  int iVar4;
  int iVar5;
  undefined1 (*pauVar6) [32];
  longlong lVar7;
  longlong lVar8;
  uint *puVar9;
  ulonglong uVar10;
  bool bVar11;
  undefined4 uVar12;
  undefined4 uVar13;
  undefined8 local_78;
  undefined4 local_70 [2];
  Mat *local_68;
  undefined8 local_60;
  int local_58;
  int iStack_54;
  int local_50;
  int iStack_4c;
  
                    /* 0xb29f0  523
                       ?drawClubData@Shot@GolfIn@@AEAAXAEAVClubData@2@AEAVMat@cv@@HAEB_N@Z */
  fVar3 = DAT_18017ed38;
  if ((*(longlong *)(param_1 + 0x150) != *(longlong *)(param_1 + 0x158)) &&
     (*(longlong *)(param_1 + 0x168) != *(longlong *)(param_1 + 0x170))) {
    puVar2 = *(uint **)(param_1 + 0x10);
    for (puVar9 = *(uint **)(param_1 + 8); puVar9 != puVar2; puVar9 = puVar9 + 1) {
      uVar1 = *puVar9;
      pauVar6 = *(undefined1 (**) [32])(param_1 + 8);
      if ((pauVar6 == *(undefined1 (**) [32])(param_1 + 0x10)) ||
         (*(undefined8 **)(param_1 + 0x20) == *(undefined8 **)(param_1 + 0x28))) {
LAB_1800b2a84:
        local_78 = CONCAT44(DAT_1801d1204,DAT_1801d1200);
      }
      else if ((int)uVar1 < *(int *)*pauVar6) {
        local_78 = **(undefined8 **)(param_1 + 0x20);
      }
      else {
        pauVar6 = FUN_1801324f0(pauVar6,*(undefined1 (**) [32])(param_1 + 0x10),uVar1);
        if (pauVar6 == *(undefined1 (**) [32])(param_1 + 0x10)) goto LAB_1800b2a84;
        lVar8 = *(longlong *)(param_1 + 0x20);
        lVar7 = (longlong)pauVar6 - *(longlong *)(param_1 + 8) >> 2;
        if (*param_4 == false) {
          local_78 = *(undefined8 *)(lVar8 + lVar7 * 8);
        }
        else {
          local_78 = CONCAT44((float)*(int *)(param_1 + 0xb4) + *(float *)(lVar8 + 4 + lVar7 * 8),
                              (float)*(int *)(param_1 + 0xb0) + *(float *)(lVar8 + lVar7 * 8));
        }
      }
      FUN_1800b2460(param_2,(float *)&local_78,fVar3,&DAT_1801d1288,param_3 == uVar1);
    }
    lVar8 = *(longlong *)(param_1 + 0xe8);
    uVar10 = 0;
    if (*(longlong *)(param_1 + 0xf0) - lVar8 >> 2 != 0) {
      do {
        iVar5 = *(int *)(lVar8 + uVar10 * 4);
        ClubData::getTrajectoryPoint
                  (param_1,(float *)&local_78,(bool *)(*(longlong *)(param_1 + 0xd0) + uVar10 * 4));
        if (((float)local_78 != DAT_1801d1200) || (local_78._4_4_ != DAT_1801d1204)) {
          local_60 = 0;
          local_70[0] = 0x3010000;
          iVar4 = (int)ROUND((float)local_78);
          bVar11 = param_3 == iVar5;
          if (bVar11) {
            iStack_4c = (int)ROUND(local_78._4_4_);
            uVar13 = 1;
            uVar12 = 0x1e;
            local_50 = iVar4;
            iVar5 = iStack_4c;
          }
          else {
            iStack_54 = (int)ROUND(local_78._4_4_);
            uVar13 = 2;
            uVar12 = 2;
            local_58 = iVar4;
            iVar5 = iStack_54;
          }
          local_68 = param_2;
          cv::drawMarker(local_70,CONCAT44(iVar5,iVar4),&DAT_1801d12a8,!bVar11,uVar12,uVar13,8);
        }
        lVar8 = *(longlong *)(param_1 + 0xe8);
        uVar10 = uVar10 + 1;
      } while (uVar10 < (ulonglong)(*(longlong *)(param_1 + 0xf0) - lVar8 >> 2));
    }
  }
  return;
}

