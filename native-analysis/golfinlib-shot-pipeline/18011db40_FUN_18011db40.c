FUNCTION: FUN_18011db40
ENTRY: 18011db40
REASONS: string:Club.Detection


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */

ulonglong FUN_18011db40(longlong param_1)

{
  int *piVar1;
  undefined8 *puVar2;
  bool bVar3;
  int iVar4;
  Interface *pIVar5;
  Parameter *pPVar6;
  longlong *plVar7;
  ulonglong uVar8;
  undefined7 extraout_var;
  undefined7 extraout_var_00;
  undefined7 uVar9;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar10;
  undefined1 auStack_128 [32];
  bool local_108 [4];
  int local_104;
  longlong local_100;
  longlong local_f8 [4];
  undefined8 local_d8;
  undefined8 uStack_d0;
  undefined8 local_c8;
  undefined8 local_c0;
  undefined8 *local_b8;
  undefined1 local_b0;
  undefined8 *local_a8;
  undefined1 local_a0;
  longlong local_98;
  longlong local_90 [4];
  undefined8 local_70;
  undefined8 uStack_68;
  undefined8 local_60;
  undefined8 local_58;
  undefined8 *local_50;
  ulonglong uStack_48;
  ulonglong local_40;
  undefined8 *local_38;
  ulonglong uStack_30;
  ulonglong local_28;
  ulonglong local_20;
  
  local_20 = DAT_1801d1040 ^ (ulonglong)auStack_128;
  pIVar5 = FUN_180120640(param_1);
  local_104 = 0;
  local_f8[0] = 0;
  local_f8[1] = 0;
  local_f8[2] = 0;
  local_f8[3] = 0;
  FUN_18000c1d0(local_f8,"Configurations.Process.Club.DetectionMethodIndex",0x30);
  bVar3 = Libraries::Core::Parameters::exist
                    ((Parameters *)(pIVar5 + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )local_f8);
  if (bVar3) {
    pPVar6 = Libraries::Core::Parameters::get
                       ((Parameters *)(pIVar5 + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_f8);
    iVar4 = Libraries::Core::Parameter::toInt(pPVar6);
  }
  else {
    pPVar6 = Libraries::Core::Parameters::get
                       ((Parameters *)(pIVar5 + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_f8);
    Libraries::Core::Parameter::setValue(pPVar6,&local_104);
    pPVar6 = Libraries::Core::Parameters::get
                       ((Parameters *)(pIVar5 + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_f8);
    iVar4 = Libraries::Core::Parameter::toInt(pPVar6);
    GolfIn::Interface::saveParameters(pIVar5);
  }
  FUN_18000c8d0(local_f8);
  if (iVar4 == 2) {
    pIVar5 = FUN_180120640(param_1);
    bVar3 = GolfIn::Interface::loadHED(pIVar5);
    if (bVar3) goto LAB_18011ddc1;
    plVar7 = FUN_1800014c0();
    local_f8[0] = 0;
    local_f8[1] = 0;
    local_f8[2] = 0;
    local_f8[3] = 0;
    FUN_18000c1d0(local_f8,"Could not load HED dnn service",0x1e);
    pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              local_f8;
LAB_18011dc6a:
    FUN_180084c00(plVar7,pbVar10,3,'\x01');
    *(undefined4 *)(param_1 + 0x34) = 400;
    uVar8 = FUN_180120700(param_1);
    uVar8 = uVar8 & 0xffffffffffffff00;
  }
  else {
    *(undefined1 *)(param_1 + 0xc6) = 1;
    plVar7 = FUN_1800014c0();
    local_d8 = 0;
    uStack_d0 = 0;
    local_c8 = 0;
    local_c0 = 0;
    FUN_18000c1d0(&local_d8,"Loading REMBG service asynchronously...",0x27);
    FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_d8,1,'\x01');
    local_50 = (undefined8 *)0x0;
    uStack_48 = 0;
    local_40 = 0;
    local_98 = param_1;
    local_b8 = FUN_180120d40(plVar7,&local_98);
    uStack_48 = uStack_48 & 0xffffffffffffff00;
    local_40 = local_40 & 0xffffffffffffff00;
    local_50 = local_b8;
    if (local_b8 == (undefined8 *)0x0) {
                    /* WARNING: Subroutine does not return */
      FUN_180009ac0(4);
    }
    local_b0 = 1;
    LOCK();
    *(int *)(local_b8 + 1) = *(int *)(local_b8 + 1) + 1;
    UNLOCK();
    LOCK();
    piVar1 = (int *)(local_b8 + 1);
    iVar4 = *piVar1;
    *piVar1 = *piVar1 + -1;
    UNLOCK();
    if (iVar4 == 1) {
      puVar2 = (undefined8 *)local_b8[0x19];
      if (puVar2 == (undefined8 *)0x0) {
        (**(code **)*local_b8)(local_b8,1);
      }
      else {
        (**(code **)*puVar2)(puVar2,local_b8);
      }
    }
    FUN_1800f5eb0((longlong *)(param_1 + 200),(longlong *)&local_b8);
    if (local_b8 != (undefined8 *)0x0) {
      LOCK();
      piVar1 = (int *)(local_b8 + 1);
      iVar4 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar4 == 1) {
        puVar2 = (undefined8 *)local_b8[0x19];
        if (puVar2 == (undefined8 *)0x0) {
          (**(code **)*local_b8)(local_b8,1);
        }
        else {
          (**(code **)*puVar2)(puVar2,local_b8);
        }
      }
    }
LAB_18011ddc1:
    pIVar5 = FUN_180120640(param_1);
    local_108[0] = true;
    local_90[0] = 0;
    local_90[1] = 0;
    local_90[2] = 0;
    local_90[3] = 0;
    FUN_18000c1d0(local_90,"Configurations.Process.UseMLForClub",0x23);
    bVar3 = Libraries::Core::Parameters::exist
                      ((Parameters *)(pIVar5 + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_90);
    if (bVar3) {
      pPVar6 = Libraries::Core::Parameters::get
                         ((Parameters *)(pIVar5 + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)local_90);
      bVar3 = Libraries::Core::Parameter::toBoolean(pPVar6);
    }
    else {
      pPVar6 = Libraries::Core::Parameters::get
                         ((Parameters *)(pIVar5 + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)local_90);
      Libraries::Core::Parameter::setValue(pPVar6,local_108);
      pPVar6 = Libraries::Core::Parameters::get
                         ((Parameters *)(pIVar5 + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)local_90);
      bVar3 = Libraries::Core::Parameter::toBoolean(pPVar6);
      GolfIn::Interface::saveParameters(pIVar5);
    }
    *(bool *)(param_1 + 0xd8) = bVar3;
    FUN_18000c8d0(local_90);
    uVar9 = extraout_var;
    if (*(char *)(param_1 + 0xd8) != '\0') {
      plVar7 = FUN_1800014c0();
      local_70 = 0;
      uStack_68 = 0;
      local_60 = 0;
      local_58 = 0;
      FUN_18000c1d0(&local_70,"Loading YOLOv8 Club Segmentation service asynchronously...",0x3a);
      FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_70,1,'\x01');
      local_38 = (undefined8 *)0x0;
      uStack_30 = 0;
      local_28 = 0;
      local_100 = param_1;
      local_a8 = FUN_180120eb0(plVar7,&local_100);
      uStack_30 = uStack_30 & 0xffffffffffffff00;
      local_28 = local_28 & 0xffffffffffffff00;
      local_38 = local_a8;
      if (local_a8 == (undefined8 *)0x0) {
                    /* WARNING: Subroutine does not return */
        FUN_180009ac0(4);
      }
      local_a0 = 1;
      LOCK();
      *(int *)(local_a8 + 1) = *(int *)(local_a8 + 1) + 1;
      UNLOCK();
      LOCK();
      piVar1 = (int *)(local_a8 + 1);
      iVar4 = *piVar1;
      *piVar1 = *piVar1 + -1;
      UNLOCK();
      if (iVar4 == 1) {
        puVar2 = (undefined8 *)local_a8[0x19];
        if (puVar2 == (undefined8 *)0x0) {
          (**(code **)*local_a8)(local_a8,1);
        }
        else {
          (**(code **)*puVar2)(puVar2,local_a8);
        }
      }
      FUN_1800f5eb0((longlong *)(param_1 + 0xe0),(longlong *)&local_a8);
      if (local_a8 != (undefined8 *)0x0) {
        LOCK();
        piVar1 = (int *)(local_a8 + 1);
        iVar4 = *piVar1;
        *piVar1 = *piVar1 + -1;
        UNLOCK();
        if (iVar4 == 1) {
          puVar2 = (undefined8 *)local_a8[0x19];
          if (puVar2 == (undefined8 *)0x0) {
            (**(code **)*local_a8)(local_a8,1);
          }
          else {
            (**(code **)*puVar2)(puVar2,local_a8);
          }
        }
      }
      pIVar5 = FUN_180120640(param_1);
      bVar3 = GolfIn::Interface::loadClubClassificationMLModel(pIVar5);
      uVar9 = extraout_var_00;
      if (!bVar3) {
        plVar7 = FUN_1800014c0();
        local_d8 = 0;
        uStack_d0 = 0;
        local_c8 = 0;
        local_c0 = 0;
        FUN_18000c1d0(&local_d8,"Could not load club classification ML model service",0x33);
        pbVar10 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  &local_d8;
        goto LAB_18011dc6a;
      }
    }
    uVar8 = CONCAT71(uVar9,1);
  }
  return uVar8;
}

