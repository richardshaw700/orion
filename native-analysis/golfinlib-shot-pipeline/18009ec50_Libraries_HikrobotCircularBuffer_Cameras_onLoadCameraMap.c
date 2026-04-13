FUNCTION: Libraries::HikrobotCircularBuffer::Cameras::onLoadCameraMap
ENTRY: 18009ec50
REASONS: name:loadCamera


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl Libraries::HikrobotCircularBuffer::Cameras::onLoadCameraMap(class
   std::vector<class Hikrobot::CameraPtr,class std::allocator<class Hikrobot::CameraPtr> > &
   __ptr64,class Libraries::Core::Parameters & __ptr64) __ptr64 */

void __thiscall
Libraries::HikrobotCircularBuffer::Cameras::onLoadCameraMap
          (Cameras *this,
          vector<class_Hikrobot::CameraPtr,class_std::allocator<class_Hikrobot::CameraPtr>_>
          *param_1,Parameters *param_2)

{
  bool bVar1;
  code *pcVar2;
  Cameras *pCVar3;
  undefined8 ***_Size;
  ulonglong uVar4;
  undefined8 ***_Size_00;
  char cVar5;
  int iVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  int iVar9;
  int iVar10;
  Parameter *pPVar11;
  undefined8 *puVar12;
  undefined8 *puVar13;
  longlong *plVar14;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar15;
  undefined8 ****ppppuVar16;
  undefined8 ****ppppuVar17;
  undefined8 ****ppppuVar18;
  undefined8 ****ppppuVar19;
  undefined1 auStackY_198 [32];
  longlong local_150 [4];
  undefined8 *local_130;
  int local_128;
  Cameras *local_120 [2];
  bool local_110 [8];
  undefined8 ***local_108;
  undefined8 uStack_100;
  undefined8 ***local_f8;
  ulonglong local_f0;
  undefined8 ***local_e8;
  undefined8 uStack_e0;
  undefined8 ***local_d8;
  ulonglong local_d0;
  undefined8 ***local_c8;
  undefined8 uStack_c0;
  undefined8 ***local_b8;
  undefined8 ***local_b0;
  undefined8 ***local_a8;
  undefined8 uStack_a0;
  undefined8 ***local_98;
  undefined8 ***local_90;
  undefined8 ***local_88 [2];
  undefined8 ***local_78;
  ulonglong local_70;
  undefined8 ***local_68 [2];
  undefined8 ***local_58;
  ulonglong local_50;
  ulonglong local_48;
  
                    /* 0x9ec50  834
                       ?onLoadCameraMap@Cameras@HikrobotCircularBuffer@Libraries@@QEAAXAEAV?$vector@VCameraPtr@Hikrobot@@V?$allocator@VCameraPtr@Hikrobot@@@std@@@std@@AEAVParameters@Core@3@@Z
                        */
  local_48 = DAT_1801d1040 ^ (ulonglong)auStackY_198;
  local_108 = (undefined8 ***)0x0;
  uStack_100 = 0;
  local_f8 = (undefined8 ***)0x0;
  local_f0 = 0;
  local_120[0] = this;
  FUN_18000c1d0(&local_108,"ReverseMasterSlave",0x12);
  pPVar11 = Core::Parameters::find
                      (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_108);
  if (pPVar11 == (Parameter *)0x0) {
    cVar5 = false;
  }
  else {
    local_e8 = (undefined8 ***)0x0;
    uStack_e0 = 0;
    local_d8 = (undefined8 ***)0x0;
    local_d0 = 0;
    FUN_18000c1d0(&local_e8,"ReverseMasterSlave",0x12);
    pPVar11 = Core::Parameters::get
                        (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_e8);
    cVar5 = Core::Parameter::toBoolean(pPVar11);
    FUN_18000c8d0((longlong *)&local_e8);
  }
  FUN_18000c8d0((longlong *)&local_108);
  local_e8 = (undefined8 ****)0x0;
  uStack_e0 = 0;
  local_d8 = (undefined8 ****)0x0;
  local_d0 = 0;
  FUN_18000c1d0(&local_e8,"Camera1.ID",10);
  pPVar11 = Core::Parameters::get
                      (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_e8);
  iVar6 = _Mtx_lock(pPVar11 + 0x48);
  if (iVar6 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar2 = (code *)swi(3);
    (*pcVar2)();
    return;
  }
  if (*(int *)(pPVar11 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar11 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar2 = (code *)swi(3);
    (*pcVar2)();
    return;
  }
  FUN_18000cb00(local_88,(undefined8 *)(pPVar11 + 0x28));
  _Mtx_unlock(pPVar11 + 0x48);
  FUN_18000c8d0((longlong *)&local_e8);
  local_108 = (undefined8 ****)0x0;
  uStack_100 = 0;
  local_f8 = (undefined8 ****)0x0;
  local_f0 = 0;
  FUN_18000c1d0(&local_108,"Camera2.ID",10);
  pPVar11 = Core::Parameters::get
                      (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_108);
  iVar6 = _Mtx_lock(pPVar11 + 0x48);
  if (iVar6 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar2 = (code *)swi(3);
    (*pcVar2)();
    return;
  }
  if (*(int *)(pPVar11 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar11 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar2 = (code *)swi(3);
    (*pcVar2)();
    return;
  }
  FUN_18000cb00(local_68,(undefined8 *)(pPVar11 + 0x28));
  _Mtx_unlock(pPVar11 + 0x48);
  FUN_18000c8d0((longlong *)&local_108);
  FUN_18000cb00(&local_e8,(undefined8 *)(*(longlong *)param_1 + 0x18));
  FUN_18000cb00(&local_108,(undefined8 *)(*(longlong *)param_1 + 0x1b0));
  uVar7 = FUN_18009a6a0((void *)(*(longlong *)(*(longlong *)param_1 + 8) + 0xac));
  uVar8 = FUN_18009a6a0((void *)(*(longlong *)(*(longlong *)param_1 + 0x1a0) + 0xac));
  iVar6 = Core::ExtractNumberFromString
                    ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_e8,true);
  local_128 = Core::ExtractNumberFromString
                        ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_108,true);
  local_a8 = (undefined8 ****)0x0;
  uStack_a0 = 0;
  local_98 = (undefined8 ****)0x0;
  local_90 = (undefined8 ****)0x0;
  FUN_18000c1d0(&local_a8,&DAT_18016a0f8,0);
  local_c8 = (undefined8 ****)0x0;
  uStack_c0 = 0;
  local_b8 = (undefined8 ****)0x0;
  local_b0 = (undefined8 ****)0x0;
  FUN_18000c1d0(&local_c8,&DAT_18016a0f8,0);
  _Size_00 = local_d8;
  uVar4 = local_f0;
  _Size = local_f8;
  ppppuVar18 = (undefined8 ****)local_108;
  bVar1 = 0xf < local_d0;
  ppppuVar16 = &local_e8;
  if (0xf < local_d0) {
    ppppuVar16 = (undefined8 ****)local_e8;
  }
  local_110[0] = 0xf < local_70;
  ppppuVar17 = local_88;
  if (0xf < local_70) {
    ppppuVar17 = (undefined8 ****)local_88[0];
  }
  if ((local_78 != local_d8) || (iVar9 = memcmp(ppppuVar17,ppppuVar16,(size_t)local_78), iVar9 != 0)
     ) {
    ppppuVar16 = &local_108;
    if (0xf < uVar4) {
      ppppuVar16 = ppppuVar18;
    }
    ppppuVar17 = local_88;
    if (local_110[0] != false) {
      ppppuVar17 = (undefined8 ****)local_88[0];
    }
    ppppuVar19 = (undefined8 ****)local_88[0];
    if ((local_78 != _Size) ||
       (iVar9 = memcmp(ppppuVar17,ppppuVar16,(size_t)local_78),
       ppppuVar19 = (undefined8 ****)local_78, iVar9 != 0)) goto LAB_18009f06e;
  }
  ppppuVar18 = &local_e8;
  if (bVar1) {
    ppppuVar18 = (undefined8 ****)local_e8;
  }
  local_110[0] = 0xf < local_50;
  ppppuVar16 = local_68;
  if (0xf < local_50) {
    ppppuVar16 = (undefined8 ****)local_68[0];
  }
  if ((local_58 != _Size_00) ||
     (ppppuVar19 = (undefined8 ****)local_58, iVar9 = memcmp(ppppuVar16,ppppuVar18,(size_t)local_58)
     , iVar9 != 0)) {
    ppppuVar16 = &local_108;
    if (0xf < uVar4) {
      ppppuVar16 = (undefined8 ****)local_108;
    }
    ppppuVar17 = local_68;
    if (local_110[0] != false) {
      ppppuVar17 = (undefined8 ****)local_68[0];
    }
    ppppuVar18 = (undefined8 ****)local_108;
    ppppuVar19 = (undefined8 ****)local_68[0];
    if ((local_58 != _Size) ||
       (iVar9 = memcmp(ppppuVar17,ppppuVar16,(size_t)local_58),
       ppppuVar18 = (undefined8 ****)local_108, ppppuVar19 = (undefined8 ****)local_58, iVar9 != 0))
    goto LAB_18009f06e;
  }
  ppppuVar18 = (undefined8 ****)local_108;
  if ((bool)cVar5 == false) {
    iVar9 = Core::ExtractNumberFromString
                      ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)local_88,false);
    iVar10 = Core::ExtractNumberFromString
                       ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_68,false);
    local_110[0] = iVar10 < iVar9;
    local_150[0] = 0;
    local_150[1] = 0;
    local_150[2] = 0;
    local_150[3] = 0;
    ppppuVar19 = (undefined8 ****)0x12;
    FUN_18000c1d0(local_150,"ReverseMasterSlave",0x12);
    pPVar11 = Core::Parameters::get
                        (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)local_150);
    Core::Parameter::setValue(pPVar11,local_110);
    FUN_18000c8d0(local_150);
    ppppuVar18 = (undefined8 ****)local_108;
    cVar5 = local_110[0];
  }
LAB_18009f06e:
  if ((iVar6 < local_128) && (cVar5 == '\0')) {
    ppppuVar18 = &local_e8;
    if (bVar1) {
      ppppuVar18 = (undefined8 ****)local_e8;
    }
    if (local_90 < _Size_00) {
      FUN_18000c490((longlong *)&local_a8,(ulonglong)_Size_00,ppppuVar19,ppppuVar18);
    }
    else {
      ppppuVar16 = &local_a8;
      if ((undefined8 ****)0xf < local_90) {
        ppppuVar16 = (undefined8 ****)local_a8;
      }
      local_98 = _Size_00;
      ppppuVar19 = (undefined8 ****)_Size_00;
      memmove(ppppuVar16,ppppuVar18,(size_t)_Size_00);
      *(undefined1 *)((longlong)_Size_00 + (longlong)ppppuVar16) = 0;
    }
    ppppuVar18 = &local_108;
    if (0xf < uVar4) {
      ppppuVar18 = (undefined8 ****)local_108;
    }
    if (local_b0 < _Size) {
      FUN_18000c490((longlong *)&local_c8,(ulonglong)_Size,ppppuVar19,ppppuVar18);
    }
    else {
      ppppuVar16 = &local_c8;
      if ((undefined8 ****)0xf < local_b0) {
        ppppuVar16 = (undefined8 ****)local_c8;
      }
      local_b8 = _Size;
      memmove(ppppuVar16,ppppuVar18,(size_t)_Size);
      *(undefined1 *)((longlong)_Size + (longlong)ppppuVar16) = 0;
    }
    puVar12 = (undefined8 *)FUN_1801327e0(0x390);
    memset(puVar12,0,0x390);
    puVar12 = FUN_18009a8e0(puVar12,*(undefined8 *)param_1,0,&local_a8,uVar7);
    puVar13 = (undefined8 *)FUN_1801327e0(0x390);
    memset(puVar13,0,0x390);
    puVar13 = FUN_18009a8e0(puVar13,*(longlong *)param_1 + 0x198,1,&local_c8,uVar8);
  }
  else {
    ppppuVar16 = &local_108;
    if (0xf < uVar4) {
      ppppuVar16 = ppppuVar18;
    }
    if (local_90 < _Size) {
      FUN_18000c490((longlong *)&local_a8,(ulonglong)_Size,ppppuVar19,ppppuVar16);
    }
    else {
      ppppuVar18 = &local_a8;
      if ((undefined8 ****)0xf < local_90) {
        ppppuVar18 = (undefined8 ****)local_a8;
      }
      local_98 = _Size;
      ppppuVar19 = (undefined8 ****)_Size;
      memmove(ppppuVar18,ppppuVar16,(size_t)_Size);
      *(undefined1 *)((longlong)_Size + (longlong)ppppuVar18) = 0;
    }
    ppppuVar18 = &local_e8;
    if (bVar1) {
      ppppuVar18 = (undefined8 ****)local_e8;
    }
    if (local_b0 < _Size_00) {
      FUN_18000c490((longlong *)&local_c8,(ulonglong)_Size_00,ppppuVar19,ppppuVar18);
    }
    else {
      ppppuVar16 = &local_c8;
      if ((undefined8 ****)0xf < local_b0) {
        ppppuVar16 = (undefined8 ****)local_c8;
      }
      local_b8 = _Size_00;
      memmove(ppppuVar16,ppppuVar18,(size_t)_Size_00);
      *(undefined1 *)((longlong)_Size_00 + (longlong)ppppuVar16) = 0;
    }
    puVar12 = (undefined8 *)FUN_1801327e0(0x390);
    memset(puVar12,0,0x390);
    puVar12 = FUN_18009a8e0(puVar12,*(longlong *)param_1 + 0x198,0,&local_a8,uVar8);
    puVar13 = (undefined8 *)FUN_1801327e0(0x390);
    memset(puVar13,0,0x390);
    puVar13 = FUN_18009a8e0(puVar13,*(undefined8 *)param_1,1,&local_c8,uVar7);
  }
  local_150[0] = 0;
  local_150[1] = 0;
  local_150[2] = 0;
  local_150[3] = 0;
  FUN_18000c1d0(local_150,"Camera1.ID",10);
  pPVar11 = Core::Parameters::get
                      (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_150);
  Core::Parameter::setValue
            (pPVar11,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_a8);
  FUN_18000c8d0(local_150);
  local_150[0] = 0;
  local_150[1] = 0;
  local_150[2] = 0;
  local_150[3] = 0;
  FUN_18000c1d0(local_150,"Camera2.ID",10);
  pPVar11 = Core::Parameters::get
                      (param_2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_150);
  Core::Parameter::setValue
            (pPVar11,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_c8);
  FUN_18000c8d0(local_150);
  plVar14 = FUN_1800014c0();
  pbVar15 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format((char *)local_150);
  FUN_180084c00(plVar14,pbVar15,1,'\x01');
  plVar14 = FUN_1800014c0();
  pbVar15 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            cv::format((char *)local_150);
  FUN_180084c00(plVar14,pbVar15,1,'\x01');
  pCVar3 = local_120[0];
  FUN_18000cb00(local_150,&local_a8);
  local_130 = puVar12;
  FUN_1800a2320((longlong *)(pCVar3 + 0xd8),local_120,local_150);
  FUN_18000c8d0(local_150);
  FUN_18000cb00(local_150,&local_c8);
  local_130 = puVar13;
  FUN_1800a2320((longlong *)(pCVar3 + 0xd8),local_120,local_150);
  FUN_18000c8d0(local_150);
  FUN_18000c8d0((longlong *)&local_c8);
  FUN_18000c8d0((longlong *)&local_a8);
  FUN_18000c8d0((longlong *)&local_108);
  FUN_18000c8d0((longlong *)&local_e8);
  FUN_18000c8d0((longlong *)local_68);
  FUN_18000c8d0((longlong *)local_88);
  return;
}

