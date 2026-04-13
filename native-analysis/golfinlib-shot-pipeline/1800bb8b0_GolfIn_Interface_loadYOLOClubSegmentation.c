FUNCTION: GolfIn::Interface::loadYOLOClubSegmentation
ENTRY: 1800bb8b0
REASONS: name:club


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: bool __cdecl GolfIn::Interface::loadYOLOClubSegmentation(void) __ptr64 */

bool __thiscall GolfIn::Interface::loadYOLOClubSegmentation(Interface *this)

{
  YoloClubSegmentation *this_00;
  int *piVar1;
  int iVar2;
  longlong lVar3;
  char cVar4;
  bool bVar5;
  longlong *plVar6;
  longlong *plVar7;
  undefined8 *puVar8;
  Mat *this_01;
  undefined8 *puVar9;
  undefined1 auStack_488 [32];
  YoloClubSegmentation *local_468;
  longlong *plStack_460;
  YoloClubSegmentation *local_458;
  longlong *local_450;
  Interface *local_448;
  undefined8 *puStack_440;
  YoloClubSegmentation *local_438;
  longlong *plStack_430;
  Interface *local_418;
  undefined8 *puStack_410;
  Interface *local_408;
  undefined8 *puStack_400;
  undefined1 local_3f8 [16];
  Mat local_3e8 [96];
  Mat local_388 [96];
  Mat local_328 [144];
  undefined1 local_298 [16];
  Mat local_288 [96];
  Mat local_228 [96];
  Mat local_1c8 [144];
  longlong *local_138;
  undefined8 uStack_130;
  undefined8 *local_128;
  undefined8 uStack_120;
  undefined8 *local_118;
  ulonglong uStack_110;
  ulonglong local_108;
  longlong *local_100;
  ulonglong uStack_f8;
  ulonglong local_f0;
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
  undefined8 local_58;
  undefined8 uStack_50;
  undefined8 local_48;
  undefined8 uStack_40;
  undefined8 local_38;
  undefined8 uStack_30;
  ulonglong local_28;
  
                    /* 0xbb8b0  790  ?loadYOLOClubSegmentation@Interface@GolfIn@@QEAA_NXZ */
  local_28 = DAT_1801d1040 ^ (ulonglong)auStack_488;
  plVar6 = (longlong *)FUN_1801327e0(0x168);
  *(undefined4 *)(plVar6 + 1) = 1;
  *(undefined4 *)((longlong)plVar6 + 0xc) = 1;
  *plVar6 = (longlong)std::_Ref_count_obj2<class_GolfIn::YoloClubSegmentation>::vftable;
  this_00 = (YoloClubSegmentation *)(plVar6 + 2);
  local_138 = plVar6;
  YoloClubSegmentation::YoloClubSegmentation(this_00);
  local_438 = this_00;
  plStack_430 = plVar6;
  plVar7 = (longlong *)FUN_1801327e0(0x168);
  *(undefined4 *)(plVar7 + 1) = 1;
  *(undefined4 *)((longlong)plVar7 + 0xc) = 1;
  *plVar7 = (longlong)std::_Ref_count_obj2<class_GolfIn::YoloClubSegmentation>::vftable;
  local_138 = plVar7;
  YoloClubSegmentation::YoloClubSegmentation((YoloClubSegmentation *)(plVar7 + 2));
  local_468 = this_00;
  plStack_460 = plVar6;
  local_458 = (YoloClubSegmentation *)(plVar7 + 2);
  local_450 = plVar7;
  FUN_180084320((undefined8 *)(this + 0x8c0),&local_468);
  FUN_180084320((undefined8 *)(this + 0x8d0),&local_458);
  plVar6 = local_450;
  if (local_450 != (longlong *)0x0) {
    LOCK();
    plVar7 = local_450 + 1;
    lVar3 = *plVar7;
    *(int *)plVar7 = (int)*plVar7 + -1;
    UNLOCK();
    if ((int)lVar3 == 1) {
      (**(code **)*local_450)(local_450);
      LOCK();
      piVar1 = (int *)((longlong)plVar6 + 0xc);
      iVar2 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar2 == 1) {
        (**(code **)(*local_450 + 8))();
      }
    }
  }
  plVar6 = plStack_460;
  if (plStack_460 != (longlong *)0x0) {
    LOCK();
    plVar7 = plStack_460 + 1;
    lVar3 = *plVar7;
    *(int *)plVar7 = (int)*plVar7 + -1;
    UNLOCK();
    if ((int)lVar3 == 1) {
      (**(code **)*plStack_460)(plStack_460);
      LOCK();
      piVar1 = (int *)((longlong)plVar6 + 0xc);
      iVar2 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar2 == 1) {
        (**(code **)(*plStack_460 + 8))();
      }
    }
  }
  cVar4 = (**(code **)**(undefined8 **)(this + 0x8c0))();
  if (cVar4 == '\0') {
    plVar6 = FUN_1800014c0();
    local_468 = (YoloClubSegmentation *)0x0;
    plStack_460 = (longlong *)0x0;
    local_458 = (YoloClubSegmentation *)0x0;
    local_450 = (longlong *)0x0;
    FUN_18000c1d0(&local_468,"Failed to load yolo club segmentation model",0x2b);
    FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_468,3,'\x01');
    bVar5 = false;
  }
  else {
    cVar4 = (**(code **)**(undefined8 **)(this + 0x8d0))();
    if (cVar4 == '\0') {
      plVar6 = FUN_1800014c0();
      local_468 = (YoloClubSegmentation *)0x0;
      plStack_460 = (longlong *)0x0;
      local_458 = (YoloClubSegmentation *)0x0;
      local_450 = (longlong *)0x0;
      FUN_18000c1d0(&local_468,"Failed to  load yolo club segmentation model",0x2c);
      FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_468,3,'\x01');
      bVar5 = false;
    }
    else {
      local_e8 = 0;
      uStack_e0 = 0;
      local_d8 = 0;
      uStack_d0 = 0;
      local_c8 = 0;
      uStack_c0 = 0;
      local_b8 = 0;
      uStack_b0 = 0;
      local_a8 = 0;
      uStack_a0 = 0;
      local_98 = 0;
      uStack_90 = 0;
      puVar8 = (undefined8 *)cv::Mat::zeros(local_3f8,DAT_18016d1c0,0x10);
      FUN_18000bf80(puVar8,(Mat *)&local_e8);
      cv::Mat::~Mat(local_328);
      cv::Mat::~Mat(local_388);
      cv::Mat::~Mat(local_3e8);
      local_88 = 0;
      uStack_80 = 0;
      local_78 = 0;
      uStack_70 = 0;
      local_68 = 0;
      uStack_60 = 0;
      local_58 = 0;
      uStack_50 = 0;
      local_48 = 0;
      uStack_40 = 0;
      local_38 = 0;
      uStack_30 = 0;
      puVar8 = (undefined8 *)cv::Mat::zeros(local_298,DAT_18016d1c0,0x10);
      FUN_18000bf80(puVar8,(Mat *)&local_88);
      cv::Mat::~Mat(local_1c8);
      cv::Mat::~Mat(local_228);
      this_01 = local_288;
      cv::Mat::~Mat(this_01);
      local_128 = (undefined8 *)0x0;
      uStack_120 = 0;
      puStack_440 = &local_e8;
      local_118 = (undefined8 *)0x0;
      uStack_110 = 0;
      local_108 = 0;
      local_448 = this;
      local_418 = this;
      puStack_410 = puStack_440;
      puVar8 = FUN_1800fc630(this_01,&local_418);
      uStack_110 = uStack_110 & 0xffffffffffffff00;
      local_108 = local_108 & 0xffffffffffffff00;
      local_118 = puVar8;
      if (puVar8 == (undefined8 *)0x0) {
                    /* WARNING: Subroutine does not return */
        FUN_180009ac0(4);
      }
      uStack_120 = CONCAT71(uStack_120._1_7_,1);
      LOCK();
      *(int *)(puVar8 + 1) = *(int *)(puVar8 + 1) + 1;
      UNLOCK();
      LOCK();
      piVar1 = (int *)(puVar8 + 1);
      iVar2 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      local_128 = puVar8;
      if (iVar2 == 1) {
        puVar9 = (undefined8 *)puVar8[0x19];
        if (puVar9 == (undefined8 *)0x0) {
          (**(code **)*puVar8)(puVar8,1);
        }
        else {
          (**(code **)*puVar9)(puVar9,puVar8);
          puVar8 = puVar9;
        }
      }
      local_138 = (longlong *)0x0;
      uStack_130 = 0;
      puStack_440 = &local_e8;
      local_100 = (longlong *)0x0;
      uStack_f8 = 0;
      local_f0 = 0;
      local_448 = this;
      local_408 = this;
      puStack_400 = puStack_440;
      local_100 = FUN_1800fc7a0(puVar8,&local_408);
      uStack_f8 = uStack_f8 & 0xffffffffffffff00;
      local_f0 = local_f0 & 0xffffffffffffff00;
      if (local_100 == (longlong *)0x0) {
                    /* WARNING: Subroutine does not return */
        FUN_180009ac0(4);
      }
      uStack_130 = CONCAT71(uStack_130._1_7_,1);
      LOCK();
      *(int *)(local_100 + 1) = (int)local_100[1] + 1;
      UNLOCK();
      LOCK();
      plVar6 = local_100 + 1;
      lVar3 = *plVar6;
      *(int *)plVar6 = (int)*plVar6 + -1;
      UNLOCK();
      local_138 = local_100;
      if ((int)lVar3 == 1) {
        puVar8 = (undefined8 *)local_100[0x19];
        if (puVar8 == (undefined8 *)0x0) {
          (**(code **)*local_100)(local_100,1);
        }
        else {
          (**(code **)*puVar8)(puVar8,local_100);
        }
      }
      FUN_180084940((longlong *)&local_128);
      FUN_180084940((longlong *)&local_138);
      if (local_138 != (longlong *)0x0) {
        LOCK();
        plVar6 = local_138 + 1;
        lVar3 = *plVar6;
        *(int *)plVar6 = (int)*plVar6 + -1;
        UNLOCK();
        if ((int)lVar3 == 1) {
          puVar8 = (undefined8 *)local_138[0x19];
          if (puVar8 == (undefined8 *)0x0) {
            (**(code **)*local_138)(local_138,1);
          }
          else {
            (**(code **)*puVar8)(puVar8,local_138);
          }
        }
      }
      if (local_128 != (undefined8 *)0x0) {
        LOCK();
        piVar1 = (int *)(local_128 + 1);
        iVar2 = *piVar1;
        *piVar1 = *piVar1 + -1;
        UNLOCK();
        if (iVar2 == 1) {
          puVar8 = (undefined8 *)local_128[0x19];
          if (puVar8 == (undefined8 *)0x0) {
            (**(code **)*local_128)(local_128,1);
          }
          else {
            (**(code **)*puVar8)(puVar8,local_128);
          }
        }
      }
      cv::Mat::~Mat((Mat *)&local_88);
      cv::Mat::~Mat((Mat *)&local_e8);
      bVar5 = true;
    }
  }
  return bVar5;
}

