FUNCTION: GolfIn::Interface::startSingleFrameCamera
ENTRY: 1800e4c80
REASONS: string:StartSingleFrameCamera


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: class std::tuple<bool,int> __cdecl GolfIn::Interface::startSingleFrameCamera(void)
   __ptr64 */

void __thiscall GolfIn::Interface::startSingleFrameCamera(Interface *this)

{
  code *pcVar1;
  undefined8 *puVar2;
  bool bVar3;
  int iVar4;
  Parameter *pPVar5;
  longlong *plVar6;
  longlong *plVar7;
  undefined8 ******ppppppuVar8;
  char cVar9;
  undefined4 *in_RDX;
  char *pcVar10;
  undefined8 uVar11;
  float fVar12;
  float fVar13;
  undefined1 auStackY_b68 [32];
  longlong *local_b18;
  longlong *local_b10;
  longlong *local_b08;
  undefined4 local_b00 [2];
  undefined4 local_af8 [2];
  undefined1 *local_af0;
  undefined8 local_ae8;
  undefined8 uStack_ae0;
  undefined8 local_ad8;
  undefined8 local_ad0;
  undefined8 *local_ac8;
  undefined8 *puStack_ac0;
  undefined8 local_ab8;
  undefined8 *local_ab0;
  undefined8 *puStack_aa8;
  undefined8 local_aa0;
  longlong local_a98 [4];
  undefined8 *****local_a78;
  undefined8 uStack_a70;
  size_t local_a68;
  ulonglong local_a60;
  undefined8 *****local_a58;
  undefined8 uStack_a50;
  size_t local_a48;
  ulonglong local_a40;
  undefined8 *****local_a38;
  undefined8 uStack_a30;
  size_t local_a28;
  ulonglong local_a20;
  undefined8 *****local_a18;
  undefined8 uStack_a10;
  size_t local_a08;
  ulonglong local_a00;
  undefined8 **local_9f8;
  longlong local_9f0;
  longlong lStack_9e8;
  longlong local_9e0;
  longlong lStack_9d8;
  undefined8 local_9d0;
  undefined8 uStack_9c8;
  undefined8 local_9c0;
  undefined8 local_9b8;
  undefined8 local_9b0;
  undefined8 uStack_9a8;
  undefined8 local_9a0;
  undefined8 local_998;
  undefined8 local_990;
  undefined8 uStack_988;
  undefined8 local_980;
  undefined8 local_978;
  longlong local_970;
  longlong lStack_968;
  longlong local_960;
  longlong lStack_958;
  longlong local_950;
  longlong lStack_948;
  longlong local_940;
  longlong lStack_938;
  longlong local_930;
  longlong lStack_928;
  longlong local_920;
  longlong lStack_918;
  longlong local_910;
  longlong lStack_908;
  longlong local_900;
  longlong lStack_8f8;
  longlong local_8f0;
  longlong lStack_8e8;
  longlong local_8e0;
  longlong lStack_8d8;
  longlong local_8d0;
  longlong lStack_8c8;
  longlong local_8c0;
  longlong lStack_8b8;
  longlong local_8b0;
  longlong lStack_8a8;
  longlong local_8a0;
  longlong lStack_898;
  longlong local_890 [4];
  longlong local_870 [8];
  longlong local_830 [4];
  longlong local_810 [4];
  longlong local_7f0 [4];
  longlong local_7d0 [4];
  undefined8 **local_7b0;
  longlong local_7a8 [4];
  longlong local_788 [4];
  undefined8 local_768 [4];
  longlong local_748 [4];
  undefined8 local_728 [4];
  longlong local_708 [4];
  longlong local_6e8 [7];
  longlong *local_6b0;
  longlong local_6a8 [7];
  longlong *local_670;
  longlong local_668 [7];
  longlong *local_630;
  longlong local_628 [7];
  longlong *local_5f0;
  longlong local_5e8 [7];
  longlong *local_5b0;
  longlong local_5a8 [7];
  longlong *local_570;
  undefined1 local_568 [56];
  undefined8 local_530;
  undefined1 local_528 [56];
  undefined8 local_4f0;
  longlong local_4e8 [7];
  undefined8 local_4b0;
  undefined1 local_4a8 [56];
  undefined8 local_470;
  undefined1 local_468 [56];
  undefined8 local_430;
  undefined1 local_428 [56];
  undefined8 local_3f0;
  longlong *local_3e8;
  undefined8 uStack_3e0;
  undefined8 *local_3d8;
  undefined8 *puStack_3d0;
  undefined8 **local_3c8;
  longlong local_3c0 [9];
  longlong *local_378;
  undefined8 uStack_370;
  longlong *local_368;
  undefined8 uStack_360;
  longlong *local_358;
  undefined8 uStack_350;
  longlong local_348 [6];
  undefined8 *local_318;
  undefined8 *puStack_310;
  undefined8 **local_308;
  longlong local_300 [7];
  longlong local_2c8 [4];
  undefined **local_2a8;
  longlong local_2a0 [2];
  undefined1 local_290 [80];
  undefined1 local_240 [88];
  undefined **local_1e8;
  longlong local_1e0 [2];
  undefined1 local_1d0 [80];
  undefined1 local_180 [88];
  undefined **local_128;
  longlong local_120 [2];
  undefined1 local_110 [80];
  undefined1 local_c0 [88];
  ulonglong local_68;
  
                    /* 0xe4c80  973
                       ?startSingleFrameCamera@Interface@GolfIn@@QEAA?AV?$tuple@_NH@std@@XZ */
  local_68 = DAT_1801d1040 ^ (ulonglong)auStackY_b68;
  this[0x31c] = (Interface)0x0;
  local_a98[0] = 0;
  local_a98[1] = 0;
  local_a98[2] = 0;
  local_a98[3] = 0;
  if (*(longlong *)(this + 0x298) == 0) {
    FUN_18000c1d0(local_a98,"Configurations.Debug.UseCameras",0x1f);
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_a98);
    bVar3 = Libraries::Core::Parameter::toBoolean(pPVar5);
    FUN_18000c8d0(local_a98);
    if (!bVar3) {
      *in_RDX = 0xffffffff;
      *(undefined1 *)(in_RDX + 1) = 1;
      return;
    }
    *in_RDX = 1;
    *(undefined1 *)(in_RDX + 1) = 0;
    return;
  }
  FUN_18000c1d0(local_a98,"Camera1",7);
  plVar6 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_a98);
  FUN_18000cb00(local_2c8,plVar6);
  FUN_18000c8d0(local_a98);
  local_870[4] = 0;
  local_870[5] = 0;
  local_870[6] = 0;
  local_870[7] = 0;
  FUN_18000c1d0(local_870 + 4,"Camera2",7);
  plVar6 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_870 + 4);
  FUN_18000cb00(local_300 + 3,plVar6);
  FUN_18000c8d0(local_870 + 4);
  memset(&local_128,0,0xb8);
  Libraries::Core::Parameters::Parameters((Parameters *)&local_128);
  local_810[0] = 0;
  local_810[1] = 0;
  local_810[2] = 0;
  local_810[3] = 0;
  FUN_18000c1d0(local_810,"Action",6);
  pPVar5 = Libraries::Core::Parameters::get
                     ((Parameters *)&local_128,
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)local_810);
  local_830[0] = 0;
  local_830[1] = 0;
  local_830[2] = 0;
  local_830[3] = 0;
  FUN_18000c1d0(local_830,"StopAcquisition",0xf);
  Libraries::Core::Parameter::setValue
            (pPVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    local_830);
  FUN_18000c8d0(local_830);
  FUN_18000c8d0(local_810);
  local_570 = (longlong *)0x0;
  local_b08 = local_5a8;
  local_b10 = local_4e8;
  local_4b0 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_300 + 3,&local_128,local_4e8);
  if (local_570 != (longlong *)0x0) {
    (**(code **)(*local_570 + 0x20))
              (local_570,CONCAT71((int7)((ulonglong)local_5a8 >> 8),local_570 != local_5a8));
  }
  FUN_1800090b0((longlong *)&local_b08);
  if (local_b08 != (longlong *)0x7ffffffffd050f7f) {
    cVar9 = '\x01';
    if ((longlong)local_b08 < 0x7ffffffffd050f7f) {
      cVar9 = -1;
    }
    if (cVar9 < '\0') {
      local_b10 = local_b08 + 0x5f5e10;
      goto LAB_1800e4f4a;
    }
  }
  local_b10 = (longlong *)0x7fffffffffffffff;
LAB_1800e4f4a:
  FUN_180007780((longlong *)&local_b10);
  local_5b0 = (longlong *)0x0;
  local_b18 = local_5e8;
  local_af0 = local_4a8;
  local_470 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_2c8,&local_128,local_4a8);
  if (local_5b0 != (longlong *)0x0) {
    (**(code **)(*local_5b0 + 0x20))
              (local_5b0,CONCAT71((int7)((ulonglong)local_5e8 >> 8),local_5b0 != local_5e8));
  }
  LOCK();
  this[0x728] = (Interface)0x1;
  UNLOCK();
  plVar6 = FUN_1800014c0();
  local_9b0 = 0;
  uStack_9a8 = 0;
  local_9a0 = 0;
  local_998 = 0;
  FUN_18000c1d0(&local_9b0,"[StartSingleFrameCamera] apply StopAcquisition done on cam 2 and cam 1",
                0x46);
  FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_9b0,1,'\x01');
  plVar7 = *(longlong **)(this + 0x298);
  local_b00[0] = 3;
  plVar6 = plVar7 + 2;
  uStack_3e0 = 0;
  local_3e8 = plVar6;
  iVar4 = _Mtx_lock(plVar6);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  if (*(int *)((longlong)plVar7 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar7 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  uStack_3e0 = CONCAT71(uStack_3e0._1_7_,1);
  if ((char)plVar7[1] != '\0') {
    local_3c0[6] = 0;
    local_3c0[7] = 0;
    local_3c0[8] = 0;
    local_348[3] = 0;
    local_348[4] = 0;
    local_348[5] = 0;
    (**(code **)(*plVar7 + 0x18))(plVar7,local_300 + 3,local_b00,local_3c0 + 6);
    FUN_18000bd00(local_348 + 3);
    FUN_18000bd00(local_3c0 + 6);
  }
  _Mtx_unlock(plVar6);
  plVar7 = *(longlong **)(this + 0x298);
  local_af8[0] = 3;
  plVar6 = plVar7 + 2;
  uStack_350 = 0;
  local_358 = plVar6;
  iVar4 = _Mtx_lock(plVar6);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  if (*(int *)((longlong)plVar7 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar7 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  uStack_350 = CONCAT71(uStack_350._1_7_,1);
  if ((char)plVar7[1] != '\0') {
    local_3c0[0] = 0;
    local_3c0[1] = 0;
    local_3c0[2] = 0;
    local_3c0[3] = 0;
    local_3c0[4] = 0;
    local_3c0[5] = 0;
    (**(code **)(*plVar7 + 0x18))(plVar7,local_2c8,local_af8,local_3c0);
    FUN_18000bd00(local_3c0 + 3);
    FUN_18000bd00(local_3c0);
  }
  _Mtx_unlock(plVar6);
  plVar6 = FUN_1800014c0();
  local_990 = 0;
  uStack_988 = 0;
  local_980 = 0;
  local_978 = 0;
  FUN_18000c1d0(&local_990,"[StartSingleFrameCamera] set CaptureROI done on cam 2 and cam 1",0x3f);
  FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_990,1,'\x01');
  plVar6 = *(longlong **)(this + 0x298);
  local_a78 = (undefined8 ******)0x0;
  uStack_a70 = 0;
  local_a68 = 0;
  local_a60 = 0;
  uVar11 = 7;
  pcVar10 = "Camera1";
  FUN_18000c1d0(&local_a78,"Camera1",7);
  if (0x7fffffffffffffff - local_a68 < 0x17) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  ppppppuVar8 = &local_a78;
  if (0xf < local_a60) {
    ppppppuVar8 = (undefined8 ******)local_a78;
  }
  FUN_18000bff0(local_708,pcVar10,uVar11,"Configurations.Cameras.",0x17,ppppppuVar8,local_a68);
  plVar7 = FUN_18000a490(local_708,".Data.",6);
  local_970 = *plVar7;
  lStack_968 = plVar7[1];
  local_960 = plVar7[2];
  lStack_958 = plVar7[3];
  plVar7[3] = 0xf;
  plVar7[2] = 0;
  *(undefined1 *)plVar7 = 0;
  plVar7 = FUN_18000a490(&local_970,&DAT_1801735a8,4);
  local_950 = *plVar7;
  lStack_948 = plVar7[1];
  local_940 = plVar7[2];
  lStack_938 = plVar7[3];
  plVar7[2] = 0;
  plVar7[3] = 0xf;
  *(undefined1 *)plVar7 = 0;
  FUN_18000c8d0(&local_970);
  FUN_18000c8d0(local_708);
  pPVar5 = Libraries::Core::Parameters::get
                     ((Parameters *)(this + 0x10),
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_950);
  iVar4 = _Mtx_lock(pPVar5 + 0x48);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  if (*(int *)(pPVar5 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar5 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  FUN_18000cb00(local_728,(undefined8 *)(pPVar5 + 0x28));
  _Mtx_unlock(pPVar5 + 0x48);
  local_ac8 = (undefined8 *)0x0;
  puStack_ac0 = (undefined8 *)0x0;
  local_ab8 = 0;
  FUN_18000bc20((ulonglong *)&local_ac8,1);
  puVar2 = local_ac8;
  local_9f8 = &local_ac8;
  local_3d8 = local_ac8;
  puStack_3d0 = local_ac8;
  local_3c8 = &local_ac8;
  FUN_18000cb00(local_ac8,local_728);
  puStack_ac0 = puVar2 + 4;
  local_af0 = (undefined1 *)CONCAT44(local_af0._4_4_,6);
  plVar7 = plVar6 + 2;
  uStack_360 = 0;
  puStack_3d0 = puStack_ac0;
  local_368 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 == 0) {
    if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
      *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
      std::_Throw_Cpp_error(6);
      pcVar1 = (code *)swi(3);
      (*pcVar1)();
      return;
    }
    uStack_360 = CONCAT71(uStack_360._1_7_,1);
    if ((char)plVar6[1] != '\0') {
      local_300[0] = 0;
      local_300[1] = 0;
      local_300[2] = 0;
      (**(code **)(*plVar6 + 0x18))(plVar6,local_2c8,&local_af0,&local_ac8);
      FUN_18000bd00(local_300);
    }
    _Mtx_unlock(plVar7);
    FUN_18000bd00((longlong *)&local_ac8);
    _eh_vector_destructor_iterator_(local_728,0x20,1,thunk_FUN_18000c8d0);
    FUN_18000c8d0(&local_950);
    FUN_18000c8d0((longlong *)&local_a78);
    plVar6 = *(longlong **)(this + 0x298);
    local_a58 = (undefined8 ******)0x0;
    uStack_a50 = 0;
    local_a48 = 0;
    local_a40 = 0;
    uVar11 = 7;
    pcVar10 = "Camera2";
    FUN_18000c1d0(&local_a58,"Camera2",7);
    if (0x7fffffffffffffff - local_a48 < 0x17) {
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    ppppppuVar8 = &local_a58;
    if (0xf < local_a40) {
      ppppppuVar8 = (undefined8 ******)local_a58;
    }
    FUN_18000bff0(local_748,pcVar10,uVar11,"Configurations.Cameras.",0x17,ppppppuVar8,local_a48);
    plVar7 = FUN_18000a490(local_748,".Data.",6);
    local_930 = *plVar7;
    lStack_928 = plVar7[1];
    local_920 = plVar7[2];
    lStack_918 = plVar7[3];
    plVar7[3] = 0xf;
    plVar7[2] = 0;
    *(undefined1 *)plVar7 = 0;
    plVar7 = FUN_18000a490(&local_930,&DAT_1801735a8,4);
    local_910 = *plVar7;
    lStack_908 = plVar7[1];
    local_900 = plVar7[2];
    lStack_8f8 = plVar7[3];
    plVar7[2] = 0;
    plVar7[3] = 0xf;
    *(undefined1 *)plVar7 = 0;
    FUN_18000c8d0(&local_930);
    FUN_18000c8d0(local_748);
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_910);
    iVar4 = _Mtx_lock(pPVar5 + 0x48);
    if (iVar4 != 0) {
      std::_Throw_Cpp_error(5);
      pcVar1 = (code *)swi(3);
      (*pcVar1)();
      return;
    }
    if (*(int *)(pPVar5 + 0x94) == 0x7fffffff) {
      *(undefined4 *)(pPVar5 + 0x94) = 0x7ffffffe;
      std::_Throw_Cpp_error(6);
      pcVar1 = (code *)swi(3);
      (*pcVar1)();
      return;
    }
    FUN_18000cb00(local_768,(undefined8 *)(pPVar5 + 0x28));
    _Mtx_unlock(pPVar5 + 0x48);
    local_ab0 = (undefined8 *)0x0;
    puStack_aa8 = (undefined8 *)0x0;
    local_aa0 = 0;
    FUN_18000bc20((ulonglong *)&local_ab0,1);
    puVar2 = local_ab0;
    local_7b0 = &local_ab0;
    local_318 = local_ab0;
    puStack_310 = local_ab0;
    local_308 = &local_ab0;
    FUN_18000cb00(local_ab0,local_768);
    puStack_aa8 = puVar2 + 4;
    local_b18 = (longlong *)CONCAT44(local_b18._4_4_,6);
    plVar7 = plVar6 + 2;
    uStack_370 = 0;
    local_378 = plVar7;
    puStack_310 = puStack_aa8;
    iVar4 = _Mtx_lock(plVar7);
    if (iVar4 == 0) {
      if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
        *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
        std::_Throw_Cpp_error(6);
        pcVar1 = (code *)swi(3);
        (*pcVar1)();
        return;
      }
      uStack_370 = CONCAT71(uStack_370._1_7_,1);
      if ((char)plVar6[1] != '\0') {
        local_348[0] = 0;
        local_348[1] = 0;
        local_348[2] = 0;
        (**(code **)(*plVar6 + 0x18))(plVar6,local_300 + 3,&local_b18,&local_ab0);
        FUN_18000bd00(local_348);
      }
      _Mtx_unlock(plVar7);
      FUN_18000bd00((longlong *)&local_ab0);
      _eh_vector_destructor_iterator_(local_768,0x20,1,thunk_FUN_18000c8d0);
      FUN_18000c8d0(&local_910);
      FUN_18000c8d0((longlong *)&local_a58);
      local_a38 = (undefined8 ******)0x0;
      uStack_a30 = 0;
      local_a28 = 0;
      local_a20 = 0;
      uVar11 = 7;
      pcVar10 = "Camera1";
      FUN_18000c1d0(&local_a38,"Camera1",7);
      if (0x16 < 0x7fffffffffffffff - local_a28) {
        ppppppuVar8 = &local_a38;
        if (0xf < local_a20) {
          ppppppuVar8 = (undefined8 ******)local_a38;
        }
        FUN_18000bff0(local_788,pcVar10,uVar11,"Configurations.Cameras.",0x17,ppppppuVar8,local_a28)
        ;
        plVar6 = FUN_18000a490(local_788,".Data.",6);
        local_8f0 = *plVar6;
        lStack_8e8 = plVar6[1];
        local_8e0 = plVar6[2];
        lStack_8d8 = plVar6[3];
        plVar6[3] = 0xf;
        plVar6[2] = 0;
        *(undefined1 *)plVar6 = 0;
        plVar6 = FUN_18000a490(&local_8f0,&DAT_1801735a4,3);
        local_8d0 = *plVar6;
        lStack_8c8 = plVar6[1];
        local_8c0 = plVar6[2];
        lStack_8b8 = plVar6[3];
        plVar6[2] = 0;
        plVar6[3] = 0xf;
        *(undefined1 *)plVar6 = 0;
        FUN_18000c8d0(&local_8f0);
        FUN_18000c8d0(local_788);
        pPVar5 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_8d0);
        fVar12 = Libraries::Core::Parameter::toFloat(pPVar5);
        FUN_18000c8d0(&local_8d0);
        FUN_18000c8d0((longlong *)&local_a38);
        local_a18 = (undefined8 ******)0x0;
        uStack_a10 = 0;
        local_a08 = 0;
        local_a00 = 0;
        uVar11 = 7;
        pcVar10 = "Camera2";
        FUN_18000c1d0(&local_a18,"Camera2",7);
        if (0x16 < 0x7fffffffffffffff - local_a08) {
          ppppppuVar8 = &local_a18;
          if (0xf < local_a00) {
            ppppppuVar8 = (undefined8 ******)local_a18;
          }
          FUN_18000bff0(local_7a8,pcVar10,uVar11,"Configurations.Cameras.",0x17,ppppppuVar8,
                        local_a08);
          plVar6 = FUN_18000a490(local_7a8,".Data.",6);
          local_8b0 = *plVar6;
          lStack_8a8 = plVar6[1];
          local_8a0 = plVar6[2];
          lStack_898 = plVar6[3];
          plVar6[3] = 0xf;
          plVar6[2] = 0;
          *(undefined1 *)plVar6 = 0;
          plVar6 = FUN_18000a490(&local_8b0,&DAT_1801735a4,3);
          local_9f0 = *plVar6;
          lStack_9e8 = plVar6[1];
          local_9e0 = plVar6[2];
          lStack_9d8 = plVar6[3];
          plVar6[2] = 0;
          plVar6[3] = 0xf;
          *(undefined1 *)plVar6 = 0;
          FUN_18000c8d0(&local_8b0);
          FUN_18000c8d0(local_7a8);
          pPVar5 = Libraries::Core::Parameters::get
                             ((Parameters *)(this + 0x10),
                              (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_9f0);
          fVar13 = Libraries::Core::Parameter::toFloat(pPVar5);
          FUN_18000c8d0(&local_9f0);
          FUN_18000c8d0((longlong *)&local_a18);
          setCamerasFPS(this,fVar12,fVar13);
          memset(&local_1e8,0,0xb8);
          Libraries::Core::Parameters::Parameters((Parameters *)&local_1e8);
          local_7d0[0] = 0;
          local_7d0[1] = 0;
          local_7d0[2] = 0;
          local_7d0[3] = 0;
          FUN_18000c1d0(local_7d0,"Action",6);
          pPVar5 = Libraries::Core::Parameters::get
                             ((Parameters *)&local_1e8,
                              (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)local_7d0);
          local_7f0[0] = 0;
          local_7f0[1] = 0;
          local_7f0[2] = 0;
          local_7f0[3] = 0;
          FUN_18000c1d0(local_7f0,"SingleFrame",0xb);
          Libraries::Core::Parameter::setValue
                    (pPVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)local_7f0);
          FUN_18000c8d0(local_7f0);
          FUN_18000c8d0(local_7d0);
          local_5f0 = (longlong *)0x0;
          local_430 = 0;
          (**(code **)(**(longlong **)(this + 0x298) + 0x58))
                    (*(longlong **)(this + 0x298),local_300 + 3,&local_1e8,local_468);
          if (local_5f0 != (longlong *)0x0) {
            (**(code **)(*local_5f0 + 0x20))
                      (local_5f0,CONCAT71((int7)((ulonglong)local_628 >> 8),local_5f0 != local_628))
            ;
          }
          local_630 = (longlong *)0x0;
          local_4f0 = 0;
          (**(code **)(**(longlong **)(this + 0x298) + 0x58))
                    (*(longlong **)(this + 0x298),local_2c8,&local_1e8,local_528);
          if (local_630 != (longlong *)0x0) {
            (**(code **)(*local_630 + 0x20))
                      (local_630,CONCAT71((int7)((ulonglong)local_668 >> 8),local_630 != local_668))
            ;
          }
          plVar6 = FUN_1800014c0();
          local_9d0 = 0;
          uStack_9c8 = 0;
          local_9c0 = 0;
          local_9b8 = 0;
          FUN_18000c1d0(&local_9d0,
                        "[StartSingleFrameCamera] apply SingleFrame done on cam 2 and cam1",0x41);
          FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_9d0,1,'\x01');
          memset(&local_2a8,0,0xb8);
          Libraries::Core::Parameters::Parameters((Parameters *)&local_2a8);
          local_870[0] = 0;
          local_870[1] = 0;
          local_870[2] = 0;
          local_870[3] = 0;
          FUN_18000c1d0(local_870,"Action",6);
          pPVar5 = Libraries::Core::Parameters::get
                             ((Parameters *)&local_2a8,
                              (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)local_870);
          local_890[0] = 0;
          local_890[1] = 0;
          local_890[2] = 0;
          local_890[3] = 0;
          FUN_18000c1d0(local_890,"StartAcquisition",0x10);
          Libraries::Core::Parameter::setValue
                    (pPVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)local_890);
          FUN_18000c8d0(local_890);
          FUN_18000c8d0(local_870);
          local_670 = (longlong *)0x0;
          local_3f0 = 0;
          (**(code **)(**(longlong **)(this + 0x298) + 0x58))
                    (*(longlong **)(this + 0x298),local_300 + 3,&local_2a8,local_428);
          if (local_670 != (longlong *)0x0) {
            (**(code **)(*local_670 + 0x20))
                      (local_670,CONCAT71((int7)((ulonglong)local_6a8 >> 8),local_670 != local_6a8))
            ;
          }
          plVar6 = FUN_1800014c0();
          local_ae8 = 0;
          uStack_ae0 = 0;
          local_ad8 = 0;
          local_ad0 = 0;
          FUN_18000c1d0(&local_ae8,
                        "[StartSingleFrameCamera] apply StartAcquisition done on camera 2",0x40);
          FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_ae8,1,'\x01');
          local_6b0 = (longlong *)0x0;
          local_530 = 0;
          (**(code **)(**(longlong **)(this + 0x298) + 0x58))
                    (*(longlong **)(this + 0x298),local_2c8,&local_2a8,local_568);
          if (local_6b0 != (longlong *)0x0) {
            (**(code **)(*local_6b0 + 0x20))
                      (local_6b0,CONCAT71((int7)((ulonglong)local_6e8 >> 8),local_6b0 != local_6e8))
            ;
          }
          plVar6 = FUN_1800014c0();
          local_ae8 = 0;
          uStack_ae0 = 0;
          local_ad8 = 0;
          local_ad0 = 0;
          FUN_18000c1d0(&local_ae8,
                        "[StartSingleFrameCamera] apply StartAcquisition done on camera 1",0x40);
          FUN_180084c00(plVar6,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_ae8,1,'\x01');
          LOCK();
          this[0x728] = (Interface)0x0;
          UNLOCK();
          *in_RDX = 0xffffffff;
          *(undefined1 *)(in_RDX + 1) = 1;
          local_2a8 = Libraries::Core::Parameters::vftable;
          Libraries::Core::Parameters::clear((Parameters *)&local_2a8);
          _Mtx_destroy_in_situ(local_240);
          _Mtx_destroy_in_situ(local_290);
          FUN_18000de20(local_2a0);
          local_1e8 = Libraries::Core::Parameters::vftable;
          Libraries::Core::Parameters::clear((Parameters *)&local_1e8);
          _Mtx_destroy_in_situ(local_180);
          _Mtx_destroy_in_situ(local_1d0);
          FUN_18000de20(local_1e0);
          local_128 = Libraries::Core::Parameters::vftable;
          Libraries::Core::Parameters::clear((Parameters *)&local_128);
          _Mtx_destroy_in_situ(local_c0);
          _Mtx_destroy_in_situ(local_110);
          FUN_18000de20(local_120);
          FUN_18000c8d0(local_300 + 3);
          FUN_18000c8d0(local_2c8);
          return;
        }
                    /* WARNING: Subroutine does not return */
        FUN_18000c940();
      }
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  std::_Throw_Cpp_error(5);
  pcVar1 = (code *)swi(3);
  (*pcVar1)();
  return;
}

