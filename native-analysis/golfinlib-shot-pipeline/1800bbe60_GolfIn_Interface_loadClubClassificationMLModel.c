FUNCTION: GolfIn::Interface::loadClubClassificationMLModel
ENTRY: 1800bbe60
REASONS: name:club


/* public: bool __cdecl GolfIn::Interface::loadClubClassificationMLModel(void) __ptr64 */

bool __thiscall GolfIn::Interface::loadClubClassificationMLModel(Interface *this)

{
  longlong *plVar1;
  int *piVar2;
  int iVar3;
  longlong lVar4;
  longlong *plVar5;
  longlong *plVar6;
  longlong *local_a0;
  longlong *local_98;
  longlong *local_90;
  longlong *local_88;
  longlong *local_80;
  longlong *plStack_78;
  longlong local_70 [9];
  
                    /* 0xbbe60  775  ?loadClubClassificationMLModel@Interface@GolfIn@@QEAA_NXZ */
  plVar5 = (longlong *)FUN_1801327e0(0xb8);
  *plVar5 = 0;
  plVar5[1] = 0;
  *(undefined4 *)(plVar5 + 1) = 1;
  *(undefined4 *)((longlong)plVar5 + 0xc) = 1;
  *plVar5 = (longlong)std::_Ref_count_obj2<class_GolfIn::ResNet18Classification>::vftable;
  plVar1 = plVar5 + 2;
  local_70[0] = 0;
  local_70[1] = 0;
  local_70[2] = 0;
  local_70[3] = 0;
  FUN_18000c1d0(local_70,"ClubClassificationCamera1",0x19);
  FUN_1800a3d10(plVar1,(char *)local_70,'\0');
  FUN_18000c8d0(local_70);
  local_80 = plVar1;
  plStack_78 = plVar5;
  plVar6 = (longlong *)FUN_1801327e0(0xb8);
  *plVar6 = 0;
  plVar6[1] = 0;
  *(undefined4 *)(plVar6 + 1) = 1;
  *(undefined4 *)((longlong)plVar6 + 0xc) = 1;
  *plVar6 = (longlong)std::_Ref_count_obj2<class_GolfIn::ResNet18Classification>::vftable;
  local_70[4] = 0;
  local_70[5] = 0;
  local_70[6] = 0;
  local_70[7] = 0;
  FUN_18000c1d0(local_70 + 4,"ClubClassificationCamera2",0x19);
  FUN_1800a3d10(plVar6 + 2,(char *)(local_70 + 4),'\0');
  FUN_18000c8d0(local_70 + 4);
  local_a0 = plVar1;
  local_98 = plVar5;
  local_90 = plVar6 + 2;
  local_88 = plVar6;
  FUN_180084320((undefined8 *)(this + 0x8e0),&local_a0);
  FUN_180084320((undefined8 *)(this + 0x8f0),&local_90);
  plVar1 = local_88;
  if (local_88 != (longlong *)0x0) {
    LOCK();
    plVar5 = local_88 + 1;
    lVar4 = *plVar5;
    *(int *)plVar5 = (int)*plVar5 + -1;
    UNLOCK();
    if ((int)lVar4 == 1) {
      (**(code **)*local_88)(local_88);
      LOCK();
      piVar2 = (int *)((longlong)plVar1 + 0xc);
      iVar3 = *piVar2;
      *piVar2 = *piVar2 + -1;
      UNLOCK();
      if (iVar3 == 1) {
        (**(code **)(*local_88 + 8))();
      }
    }
  }
  plVar1 = local_98;
  if (local_98 != (longlong *)0x0) {
    LOCK();
    plVar5 = local_98 + 1;
    lVar4 = *plVar5;
    *(int *)plVar5 = (int)*plVar5 + -1;
    UNLOCK();
    if ((int)lVar4 == 1) {
      (**(code **)*local_98)(local_98);
      LOCK();
      piVar2 = (int *)((longlong)plVar1 + 0xc);
      iVar3 = *piVar2;
      *piVar2 = *piVar2 + -1;
      UNLOCK();
      if (iVar3 == 1) {
        (**(code **)(*local_98 + 8))();
      }
    }
  }
  return true;
}

