FUNCTION: GolfIn::Interface::startBoardFrameCamera
ENTRY: 1800e3040
REASONS: string:StartBoardFrameCamera


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: class std::tuple<bool,int> __cdecl GolfIn::Interface::startBoardFrameCamera(void)
   __ptr64 */

void __thiscall GolfIn::Interface::startBoardFrameCamera(Interface *this)

{
  longlong *plVar1;
  undefined8 *puVar2;
  bool bVar3;
  int iVar4;
  Parameter *pPVar5;
  longlong *plVar6;
  longlong *plVar7;
  char cVar8;
  undefined8 *****pppppuVar9;
  undefined4 *in_RDX;
  undefined8 uVar10;
  undefined8 uVar11;
  code *pcVar12;
  undefined4 uVar13;
  undefined4 uVar14;
  double dVar15;
  undefined4 uVar16;
  undefined4 uVar17;
  undefined1 auStack_dc8 [32];
  longlong *local_da8;
  longlong *local_d98;
  undefined4 local_d90 [2];
  longlong *local_d88;
  longlong *local_d80;
  undefined4 local_d78;
  undefined4 local_d74;
  undefined4 local_d70;
  undefined4 local_d6c;
  undefined4 local_d68;
  undefined4 local_d64;
  undefined4 local_d60;
  undefined4 local_d5c;
  undefined4 local_d58;
  undefined4 local_d54;
  longlong *local_d50;
  longlong *local_d48;
  undefined4 local_d40 [2];
  longlong local_d38;
  longlong local_d30;
  undefined8 *local_d28;
  undefined8 *puStack_d20;
  undefined8 local_d18;
  double local_d10;
  undefined8 *local_d08;
  undefined8 *puStack_d00;
  undefined8 local_cf8;
  undefined8 *local_cf0;
  undefined8 *puStack_ce8;
  undefined8 local_ce0;
  undefined8 *local_cd8;
  undefined8 *puStack_cd0;
  undefined8 local_cc8;
  undefined8 *local_cc0;
  undefined8 *puStack_cb8;
  undefined8 local_cb0;
  undefined8 *local_ca8;
  undefined8 *puStack_ca0;
  undefined8 local_c98;
  undefined8 *local_c90;
  undefined8 *puStack_c88;
  undefined8 local_c80;
  undefined8 *local_c78;
  undefined8 *puStack_c70;
  undefined8 local_c68;
  undefined8 *local_c60;
  undefined8 *puStack_c58;
  undefined8 local_c50;
  undefined8 *local_c48;
  undefined8 *puStack_c40;
  undefined8 local_c38;
  longlong local_c30 [4];
  double local_c10;
  longlong local_c08;
  longlong local_c00;
  longlong local_bf8 [4];
  longlong local_bd8 [12];
  undefined8 ****local_b78 [3];
  ulonglong local_b60;
  undefined8 ****local_b58 [3];
  ulonglong local_b40;
  undefined8 local_b38;
  undefined8 uStack_b30;
  undefined8 local_b28;
  undefined8 local_b20;
  undefined8 ****local_b18 [3];
  ulonglong local_b00;
  undefined8 ****local_af8 [3];
  ulonglong local_ae0;
  undefined8 local_ad8;
  undefined8 uStack_ad0;
  undefined8 local_ac8;
  undefined8 uStack_ac0;
  undefined8 local_ab8;
  undefined8 uStack_ab0;
  undefined8 local_aa8;
  undefined8 uStack_aa0;
  undefined8 local_a98;
  undefined8 uStack_a90;
  undefined8 local_a88;
  undefined8 uStack_a80;
  longlong local_a78 [4];
  longlong local_a58 [4];
  longlong local_a38 [4];
  longlong local_a18 [8];
  longlong local_9d8 [4];
  longlong local_9b8 [8];
  undefined8 **local_978;
  undefined8 **local_970;
  undefined8 **local_968;
  undefined8 **local_960;
  undefined8 **local_958;
  undefined8 **local_950;
  undefined8 **local_948;
  undefined8 **local_940;
  undefined8 **local_938;
  undefined8 **local_930;
  undefined1 *local_928;
  longlong local_920 [7];
  longlong *local_8e8;
  longlong local_8e0 [7];
  longlong *local_8a8;
  longlong local_8a0 [7];
  longlong *local_868;
  longlong local_860 [7];
  longlong *local_828;
  longlong local_820 [7];
  longlong *local_7e8;
  longlong local_7e0 [7];
  longlong *local_7a8;
  longlong local_7a0 [7];
  undefined8 local_768;
  longlong local_760 [7];
  undefined8 local_728;
  longlong local_720 [7];
  undefined8 local_6e8;
  undefined1 local_6e0 [56];
  undefined8 local_6a8;
  longlong local_6a0 [7];
  undefined8 local_668;
  undefined1 local_660 [56];
  undefined8 local_628;
  longlong local_620 [4];
  longlong local_600 [4];
  undefined8 *local_5e0;
  undefined8 *puStack_5d8;
  undefined8 **local_5d0;
  longlong local_5c8 [3];
  undefined8 *local_5b0;
  undefined8 *puStack_5a8;
  undefined8 **local_5a0;
  longlong local_598 [3];
  undefined8 *local_580;
  undefined8 *puStack_578;
  undefined8 **local_570;
  longlong local_568 [9];
  undefined8 *local_520;
  undefined8 *puStack_518;
  undefined8 **local_510;
  longlong *local_508;
  undefined8 uStack_500;
  longlong *local_4f8;
  undefined8 uStack_4f0;
  longlong *local_4e8;
  undefined8 uStack_4e0;
  longlong *local_4d8;
  undefined8 uStack_4d0;
  longlong *local_4c8;
  undefined8 uStack_4c0;
  longlong *local_4b8;
  undefined8 uStack_4b0;
  longlong local_4a8 [6];
  undefined8 *local_478;
  undefined8 *puStack_470;
  undefined8 **local_468;
  longlong local_460 [3];
  undefined8 *local_448;
  undefined8 *puStack_440;
  undefined8 **local_438;
  longlong local_430 [3];
  undefined8 *local_418;
  undefined8 *puStack_410;
  undefined8 **local_408;
  longlong local_400 [6];
  longlong *local_3d0;
  undefined8 uStack_3c8;
  longlong *local_3c0;
  undefined8 uStack_3b8;
  longlong *local_3b0;
  undefined8 uStack_3a8;
  longlong *local_3a0;
  undefined8 uStack_398;
  longlong *local_390;
  undefined8 uStack_388;
  longlong *local_380;
  undefined8 uStack_378;
  undefined8 *local_370;
  undefined8 *puStack_368;
  undefined8 **local_360;
  longlong local_358 [3];
  undefined8 *local_340;
  undefined8 *puStack_338;
  undefined8 **local_330;
  longlong local_328 [3];
  undefined8 *local_310;
  undefined8 *puStack_308;
  undefined8 **local_300;
  longlong local_2f8 [4];
  undefined **local_2d8;
  longlong local_2d0 [2];
  undefined1 local_2c0 [80];
  undefined1 local_270 [88];
  undefined **local_218;
  longlong local_210 [2];
  undefined1 local_200 [80];
  undefined1 local_1b0 [88];
  undefined **local_158;
  longlong local_150 [2];
  undefined1 local_140 [80];
  undefined1 local_f0 [108];
  undefined1 local_84;
  undefined1 local_83 [23];
  undefined1 local_6c;
  undefined1 local_6b [3];
  ulonglong local_68;
  
                    /* 0xe3040  970
                       ?startBoardFrameCamera@Interface@GolfIn@@IEAA?AV?$tuple@_NH@std@@XZ */
  local_68 = DAT_1801d1040 ^ (ulonglong)auStack_dc8;
  this[0x31c] = (Interface)0x0;
  local_c30[0] = 0;
  local_c30[1] = 0;
  local_c30[2] = 0;
  local_c30[3] = 0;
  if (*(longlong *)(this + 0x298) == 0) {
    FUN_18000c1d0(local_c30,"Configurations.Debug.UseCameras",0x1f);
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_c30);
    bVar3 = Libraries::Core::Parameter::toBoolean(pPVar5);
    FUN_18000c8d0(local_c30);
    if (!bVar3) {
      *in_RDX = 0xffffffff;
      *(undefined1 *)(in_RDX + 1) = 1;
      return;
    }
    *in_RDX = 1;
    *(undefined1 *)(in_RDX + 1) = 0;
    return;
  }
  FUN_18000c1d0(local_c30,"Camera1",7);
  plVar6 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_c30);
  FUN_18000cb00(local_620,plVar6);
  FUN_18000c8d0(local_c30);
  local_a18[4] = 0;
  local_a18[5] = 0;
  local_a18[6] = 0;
  local_a18[7] = 0;
  FUN_18000c1d0(local_a18 + 4,"Camera2",7);
  plVar6 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_a18 + 4);
  FUN_18000cb00(local_600,plVar6);
  FUN_18000c8d0(local_a18 + 4);
  memset(&local_158,0,0xb8);
  Libraries::Core::Parameters::Parameters((Parameters *)&local_158);
  local_9b8[0] = 0;
  local_9b8[1] = 0;
  local_9b8[2] = 0;
  local_9b8[3] = 0;
  FUN_18000c1d0(local_9b8,"Action",6);
  pPVar5 = Libraries::Core::Parameters::get
                     ((Parameters *)&local_158,
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)local_9b8);
  local_9d8[0] = 0;
  local_9d8[1] = 0;
  local_9d8[2] = 0;
  local_9d8[3] = 0;
  FUN_18000c1d0(local_9d8,"StopAcquisition",0xf);
  Libraries::Core::Parameter::setValue
            (pPVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    local_9d8);
  FUN_18000c8d0(local_9d8);
  FUN_18000c8d0(local_9b8);
  local_8e8 = (longlong *)0x0;
  local_d88 = local_920;
  local_d50 = local_7a0;
  local_768 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_600,&local_158,local_7a0);
  if (local_8e8 != (longlong *)0x0) {
    (**(code **)(*local_8e8 + 0x20))
              (local_8e8,CONCAT71((int7)((ulonglong)local_920 >> 8),local_8e8 != local_920));
  }
  FUN_1800090b0(&local_c00);
  if (local_c00 == 0x7ffffffffd050f7f) {
LAB_1800e3323:
    local_d38 = 0x7fffffffffffffff;
  }
  else {
    cVar8 = '\x01';
    if (local_c00 < 0x7ffffffffd050f7f) {
      cVar8 = -1;
    }
    if (-1 < cVar8) goto LAB_1800e3323;
    local_d38 = local_c00 + 50000000;
  }
  FUN_180007780(&local_d38);
  local_8a8 = (longlong *)0x0;
  local_d88 = local_8e0;
  local_d50 = local_760;
  local_728 = 0;
  plVar6 = local_760;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_620,&local_158,plVar6);
  if (local_8a8 != (longlong *)0x0) {
    (**(code **)(*local_8a8 + 0x20))
              (local_8a8,CONCAT71((int7)((ulonglong)local_8e0 >> 8),local_8a8 != local_8e0));
  }
  LOCK();
  this[0x728] = (Interface)0x1;
  UNLOCK();
  plVar1 = *(longlong **)(this + 0x298);
  local_d40[0] = 3;
  plVar7 = plVar1 + 2;
  uStack_3c8 = 0;
  local_3d0 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar1 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar1 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_3c8 = CONCAT71(uStack_3c8._1_7_,1);
  if ((char)plVar1[1] != '\0') {
    local_568[3] = 0;
    local_568[4] = 0;
    local_568[5] = 0;
    local_568[6] = 0;
    local_568[7] = 0;
    local_568[8] = 0;
    local_da8 = local_568 + 6;
    plVar6 = local_568 + 3;
    (**(code **)(*plVar1 + 0x18))(plVar1,local_600,local_d40,plVar6);
    FUN_18000bd00(local_568 + 6);
    FUN_18000bd00(local_568 + 3);
  }
  _Mtx_unlock(plVar7);
  plVar1 = *(longlong **)(this + 0x298);
  local_d78 = 3;
  plVar7 = plVar1 + 2;
  uStack_3b8 = 0;
  local_3c0 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar1 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar1 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_3b8 = CONCAT71(uStack_3b8._1_7_,1);
  if ((char)plVar1[1] != '\0') {
    local_4a8[0] = 0;
    local_4a8[1] = 0;
    local_4a8[2] = 0;
    local_400[3] = 0;
    local_400[4] = 0;
    local_400[5] = 0;
    local_da8 = local_400 + 3;
    plVar6 = local_4a8;
    (**(code **)(*plVar1 + 0x18))(plVar1,local_620,&local_d78,plVar6);
    FUN_18000bd00(local_400 + 3);
    FUN_18000bd00(local_4a8);
  }
  _Mtx_unlock(plVar7);
  plVar7 = FUN_1800014c0();
  local_b38 = 0;
  uStack_b30 = 0;
  local_b28 = 0;
  local_b20 = 0;
  FUN_18000c1d0(&local_b38,"[StartBoardFrameCamera] set CaptureROI done on cam 2 and cam 1",0x3e);
  uVar11 = CONCAT71((int7)((ulonglong)plVar6 >> 8),1);
  FUN_180084c00(plVar7,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_b38,1,'\x01');
  local_c10 = DAT_18017e9a8;
  local_bd8[0] = 0;
  local_bd8[1] = 0;
  local_bd8[2] = 0;
  local_bd8[3] = 0;
  FUN_18000c1d0(local_bd8,"Configurations.Calibration.BoardCameras.exposure",0x30);
  bVar3 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )local_bd8);
  if (bVar3) {
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_bd8);
    dVar15 = Libraries::Core::Parameter::toDouble(pPVar5);
    uVar13 = SUB84(dVar15,0);
    uVar16 = (undefined4)((ulonglong)dVar15 >> 0x20);
  }
  else {
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_bd8);
    Libraries::Core::Parameter::setValue(pPVar5,&local_c10,3);
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_bd8);
    dVar15 = Libraries::Core::Parameter::toDouble(pPVar5);
    uVar13 = SUB84(dVar15,0);
    uVar16 = (undefined4)((ulonglong)dVar15 >> 0x20);
    saveParameters(this);
  }
  FUN_18000c8d0(local_bd8);
  local_d10 = DAT_18017eae8;
  local_bf8[0] = 0;
  local_bf8[1] = 0;
  local_bf8[2] = 0;
  local_bf8[3] = 0;
  uVar10 = 0x2c;
  FUN_18000c1d0(local_bf8,"Configurations.Calibration.BoardCameras.gain",0x2c);
  bVar3 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )local_bf8);
  if (bVar3) {
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_bf8);
    dVar15 = Libraries::Core::Parameter::toDouble(pPVar5);
    uVar14 = SUB84(dVar15,0);
    uVar17 = (undefined4)((ulonglong)dVar15 >> 0x20);
  }
  else {
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_bf8);
    uVar10 = 3;
    Libraries::Core::Parameter::setValue(pPVar5,&local_d10,3);
    pPVar5 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_bf8);
    dVar15 = Libraries::Core::Parameter::toDouble(pPVar5);
    uVar14 = SUB84(dVar15,0);
    uVar17 = (undefined4)((ulonglong)dVar15 >> 0x20);
    saveParameters(this);
  }
  FUN_18000c8d0(local_bf8);
  plVar6 = *(longlong **)(this + 0x298);
  iVar4 = FUN_180069fe0(&DAT_180170450,CONCAT44(uVar16,uVar13),uVar10,uVar11);
  FUN_180022b10(local_b58,(longlong)iVar4,'\0');
  pppppuVar9 = local_b58;
  if (0xf < local_b40) {
    pppppuVar9 = (undefined8 *****)local_b58[0];
  }
  FUN_18006a050(pppppuVar9,(longlong)iVar4 + 1,&DAT_180170450,CONCAT44(uVar16,uVar13));
  local_cf0 = (undefined8 *)0x0;
  puStack_ce8 = (undefined8 *)0x0;
  local_ce0 = 0;
  FUN_18000bc20((ulonglong *)&local_cf0,1);
  puVar2 = local_cf0;
  local_978 = &local_cf0;
  local_520 = local_cf0;
  puStack_518 = local_cf0;
  local_510 = &local_cf0;
  FUN_18000cb00(local_cf0,local_b58);
  puStack_ce8 = puVar2 + 4;
  local_d74 = 4;
  plVar7 = plVar6 + 2;
  uStack_3a8 = 0;
  puStack_518 = puStack_ce8;
  local_3b0 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_3a8 = CONCAT71(uStack_3a8._1_7_,1);
  if ((char)plVar6[1] != '\0') {
    local_4a8[3] = 0;
    local_4a8[4] = 0;
    local_4a8[5] = 0;
    local_da8 = local_4a8 + 3;
    (**(code **)(*plVar6 + 0x18))(plVar6,local_620,&local_d74,&local_cf0);
    FUN_18000bd00(local_4a8 + 3);
  }
  _Mtx_unlock(plVar7);
  FUN_18000bd00((longlong *)&local_cf0);
  pcVar12 = thunk_FUN_18000c8d0;
  uVar11 = 1;
  _eh_vector_destructor_iterator_(local_b58,0x20,1,thunk_FUN_18000c8d0);
  plVar6 = *(longlong **)(this + 0x298);
  iVar4 = FUN_180069fe0(&DAT_180170450,CONCAT44(uVar17,uVar14),uVar11,pcVar12);
  FUN_180022b10(local_b78,(longlong)iVar4,'\0');
  pppppuVar9 = local_b78;
  if (0xf < local_b60) {
    pppppuVar9 = (undefined8 *****)local_b78[0];
  }
  FUN_18006a050(pppppuVar9,(longlong)iVar4 + 1,&DAT_180170450,CONCAT44(uVar17,uVar14));
  local_cd8 = (undefined8 *)0x0;
  puStack_cd0 = (undefined8 *)0x0;
  local_cc8 = 0;
  FUN_18000bc20((ulonglong *)&local_cd8,1);
  puVar2 = local_cd8;
  local_970 = &local_cd8;
  local_478 = local_cd8;
  puStack_470 = local_cd8;
  local_468 = &local_cd8;
  FUN_18000cb00(local_cd8,local_b78);
  puStack_cd0 = puVar2 + 4;
  local_d70 = 6;
  plVar7 = plVar6 + 2;
  uStack_398 = 0;
  puStack_470 = puStack_cd0;
  local_3a0 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_398 = CONCAT71(uStack_398._1_7_,1);
  if ((char)plVar6[1] != '\0') {
    local_460[0] = 0;
    local_460[1] = 0;
    local_460[2] = 0;
    local_da8 = local_460;
    (**(code **)(*plVar6 + 0x18))(plVar6,local_620,&local_d70,&local_cd8);
    FUN_18000bd00(local_460);
  }
  _Mtx_unlock(plVar7);
  FUN_18000bd00((longlong *)&local_cd8);
  _eh_vector_destructor_iterator_(local_b78,0x20,1,thunk_FUN_18000c8d0);
  plVar7 = *(longlong **)(this + 0x298);
  local_9b8[4] = 0;
  local_9b8[5] = 0;
  local_9b8[6] = 0;
  local_9b8[7] = 0;
  FUN_18000c1d0(local_9b8 + 4,"BayerRG8",8);
  local_cc0 = (undefined8 *)0x0;
  puStack_cb8 = (undefined8 *)0x0;
  local_cb0 = 0;
  FUN_18000bc20((ulonglong *)&local_cc0,1);
  puVar2 = local_cc0;
  local_968 = &local_cc0;
  local_448 = local_cc0;
  puStack_440 = local_cc0;
  local_438 = &local_cc0;
  FUN_18000cb00(local_cc0,local_9b8 + 4);
  puStack_cb8 = puVar2 + 4;
  local_d6c = 5;
  plVar6 = plVar7 + 2;
  uStack_388 = 0;
  puStack_440 = puStack_cb8;
  local_390 = plVar6;
  iVar4 = _Mtx_lock(plVar6);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar7 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar7 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_388 = CONCAT71(uStack_388._1_7_,1);
  if ((char)plVar7[1] != '\0') {
    local_430[0] = 0;
    local_430[1] = 0;
    local_430[2] = 0;
    local_da8 = local_430;
    (**(code **)(*plVar7 + 0x18))(plVar7,local_620,&local_d6c,&local_cc0);
    FUN_18000bd00(local_430);
  }
  _Mtx_unlock(plVar6);
  FUN_18000bd00((longlong *)&local_cc0);
  _eh_vector_destructor_iterator_(local_9b8 + 4,0x20,1,thunk_FUN_18000c8d0);
  plVar6 = *(longlong **)(this + 0x298);
  local_6c = 0x30;
  local_bd8[4] = 0;
  local_bd8[5] = 0;
  local_bd8[6] = 0;
  local_bd8[7] = 0;
  if (&local_6c == local_6b) {
    local_bd8[6] = _DAT_18017ef00;
    local_bd8[7] = _UNK_18017ef08;
    local_bd8[4] = 0;
  }
  else {
    FUN_18000c1d0(local_bd8 + 4,&local_6c,(size_t)(local_6b + -(longlong)&local_6c));
  }
  local_ca8 = (undefined8 *)0x0;
  puStack_ca0 = (undefined8 *)0x0;
  local_c98 = 0;
  FUN_18000bc20((ulonglong *)&local_ca8,1);
  puVar2 = local_ca8;
  local_960 = &local_ca8;
  local_418 = local_ca8;
  puStack_410 = local_ca8;
  local_408 = &local_ca8;
  FUN_18000cb00(local_ca8,local_bd8 + 4);
  puStack_ca0 = puVar2 + 4;
  local_d68 = 10;
  plVar7 = plVar6 + 2;
  uStack_378 = 0;
  puStack_410 = puStack_ca0;
  local_380 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_378 = CONCAT71(uStack_378._1_7_,1);
  if ((char)plVar6[1] != '\0') {
    local_400[0] = 0;
    local_400[1] = 0;
    local_400[2] = 0;
    local_da8 = local_400;
    (**(code **)(*plVar6 + 0x18))(plVar6,local_620,&local_d68,&local_ca8);
    FUN_18000bd00(local_400);
  }
  _Mtx_unlock(plVar7);
  FUN_18000bd00((longlong *)&local_ca8);
  _eh_vector_destructor_iterator_(local_bd8 + 4,0x20,1,thunk_FUN_18000c8d0);
  plVar7 = *(longlong **)(this + 0x298);
  local_ad8 = 0;
  uStack_ad0 = 0;
  local_ac8 = 0;
  uStack_ac0 = 0;
  FUN_18000c1d0(&local_ad8,&DAT_18017c130,1);
  local_c90 = (undefined8 *)0x0;
  puStack_c88 = (undefined8 *)0x0;
  local_c80 = 0;
  FUN_18000bc20((ulonglong *)&local_c90,1);
  puVar2 = local_c90;
  local_958 = &local_c90;
  local_370 = local_c90;
  puStack_368 = local_c90;
  local_360 = &local_c90;
  FUN_18000cb00(local_c90,&local_ad8);
  puStack_c88 = puVar2 + 4;
  local_d64 = 0xb;
  plVar6 = plVar7 + 2;
  uStack_4b0 = 0;
  local_4b8 = plVar6;
  puStack_368 = puStack_c88;
  iVar4 = _Mtx_lock(plVar6);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar7 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar7 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_4b0 = CONCAT71(uStack_4b0._1_7_,1);
  if ((char)plVar7[1] != '\0') {
    local_358[0] = 0;
    local_358[1] = 0;
    local_358[2] = 0;
    local_da8 = local_358;
    (**(code **)(*plVar7 + 0x18))(plVar7,local_620,&local_d64,&local_c90);
    FUN_18000bd00(local_358);
  }
  _Mtx_unlock(plVar6);
  FUN_18000bd00((longlong *)&local_c90);
  pcVar12 = thunk_FUN_18000c8d0;
  uVar11 = 1;
  _eh_vector_destructor_iterator_(&local_ad8,0x20,1,thunk_FUN_18000c8d0);
  plVar6 = *(longlong **)(this + 0x298);
  iVar4 = FUN_180069fe0(&DAT_180170450,CONCAT44(uVar16,uVar13),uVar11,pcVar12);
  FUN_180022b10(local_af8,(longlong)iVar4,'\0');
  pppppuVar9 = local_af8;
  if (0xf < local_ae0) {
    pppppuVar9 = (undefined8 *****)local_af8[0];
  }
  FUN_18006a050(pppppuVar9,(longlong)iVar4 + 1,&DAT_180170450,CONCAT44(uVar16,uVar13));
  local_c78 = (undefined8 *)0x0;
  puStack_c70 = (undefined8 *)0x0;
  local_c68 = 0;
  FUN_18000bc20((ulonglong *)&local_c78,1);
  puVar2 = local_c78;
  local_950 = &local_c78;
  local_340 = local_c78;
  puStack_338 = local_c78;
  local_330 = &local_c78;
  FUN_18000cb00(local_c78,local_af8);
  puStack_c70 = puVar2 + 4;
  local_d60 = 4;
  plVar7 = plVar6 + 2;
  uStack_4c0 = 0;
  local_4c8 = plVar7;
  puStack_338 = puStack_c70;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_4c0 = CONCAT71(uStack_4c0._1_7_,1);
  if ((char)plVar6[1] != '\0') {
    local_328[0] = 0;
    local_328[1] = 0;
    local_328[2] = 0;
    local_da8 = local_328;
    (**(code **)(*plVar6 + 0x18))(plVar6,local_600,&local_d60,&local_c78);
    FUN_18000bd00(local_328);
  }
  _Mtx_unlock(plVar7);
  FUN_18000bd00((longlong *)&local_c78);
  pcVar12 = thunk_FUN_18000c8d0;
  uVar11 = 1;
  _eh_vector_destructor_iterator_(local_af8,0x20,1,thunk_FUN_18000c8d0);
  plVar6 = *(longlong **)(this + 0x298);
  iVar4 = FUN_180069fe0(&DAT_180170450,CONCAT44(uVar17,uVar14),uVar11,pcVar12);
  FUN_180022b10(local_b18,(longlong)iVar4,'\0');
  pppppuVar9 = local_b18;
  if (0xf < local_b00) {
    pppppuVar9 = (undefined8 *****)local_b18[0];
  }
  FUN_18006a050(pppppuVar9,(longlong)iVar4 + 1,&DAT_180170450,CONCAT44(uVar17,uVar14));
  local_c60 = (undefined8 *)0x0;
  puStack_c58 = (undefined8 *)0x0;
  local_c50 = 0;
  FUN_18000bc20((ulonglong *)&local_c60,1);
  puVar2 = local_c60;
  local_948 = &local_c60;
  local_310 = local_c60;
  puStack_308 = local_c60;
  local_300 = &local_c60;
  FUN_18000cb00(local_c60,local_b18);
  puStack_c58 = puVar2 + 4;
  local_d5c = 6;
  plVar7 = plVar6 + 2;
  uStack_4d0 = 0;
  local_4d8 = plVar7;
  puStack_308 = puStack_c58;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_4d0 = CONCAT71(uStack_4d0._1_7_,1);
  if ((char)plVar6[1] != '\0') {
    local_2f8[0] = 0;
    local_2f8[1] = 0;
    local_2f8[2] = 0;
    local_da8 = local_2f8;
    (**(code **)(*plVar6 + 0x18))(plVar6,local_600,&local_d5c,&local_c60);
    FUN_18000bd00(local_2f8);
  }
  _Mtx_unlock(plVar7);
  FUN_18000bd00((longlong *)&local_c60);
  _eh_vector_destructor_iterator_(local_b18,0x20,1,thunk_FUN_18000c8d0);
  plVar7 = *(longlong **)(this + 0x298);
  local_ab8 = 0;
  uStack_ab0 = 0;
  local_aa8 = 0;
  uStack_aa0 = 0;
  FUN_18000c1d0(&local_ab8,"BayerRG8",8);
  local_c48 = (undefined8 *)0x0;
  puStack_c40 = (undefined8 *)0x0;
  local_c38 = 0;
  FUN_18000bc20((ulonglong *)&local_c48,1);
  puVar2 = local_c48;
  local_940 = &local_c48;
  local_5e0 = local_c48;
  puStack_5d8 = local_c48;
  local_5d0 = &local_c48;
  FUN_18000cb00(local_c48,&local_ab8);
  puStack_c40 = puVar2 + 4;
  local_d58 = 5;
  plVar6 = plVar7 + 2;
  uStack_4e0 = 0;
  puStack_5d8 = puStack_c40;
  local_4e8 = plVar6;
  iVar4 = _Mtx_lock(plVar6);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar7 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar7 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_4e0 = CONCAT71(uStack_4e0._1_7_,1);
  if ((char)plVar7[1] != '\0') {
    local_5c8[0] = 0;
    local_5c8[1] = 0;
    local_5c8[2] = 0;
    local_da8 = local_5c8;
    (**(code **)(*plVar7 + 0x18))(plVar7,local_600,&local_d58,&local_c48);
    FUN_18000bd00(local_5c8);
  }
  _Mtx_unlock(plVar6);
  FUN_18000bd00((longlong *)&local_c48);
  _eh_vector_destructor_iterator_(&local_ab8,0x20,1,thunk_FUN_18000c8d0);
  plVar6 = *(longlong **)(this + 0x298);
  local_84 = 0x30;
  local_bd8[8] = 0;
  local_bd8[9] = 0;
  local_bd8[10] = 0;
  local_bd8[0xb] = 0;
  if (&local_84 == local_83) {
    local_bd8[10] = _DAT_18017ef00;
    local_bd8[0xb] = _UNK_18017ef08;
    local_bd8[8] = 0;
  }
  else {
    FUN_18000c1d0(local_bd8 + 8,&local_84,(size_t)(local_83 + -(longlong)&local_84));
  }
  local_d28 = (undefined8 *)0x0;
  puStack_d20 = (undefined8 *)0x0;
  local_d18 = 0;
  FUN_18000bc20((ulonglong *)&local_d28,1);
  puVar2 = local_d28;
  local_938 = &local_d28;
  local_5b0 = local_d28;
  puStack_5a8 = local_d28;
  local_5a0 = &local_d28;
  FUN_18000cb00(local_d28,local_bd8 + 8);
  puStack_d20 = puVar2 + 4;
  local_d54 = 10;
  plVar7 = plVar6 + 2;
  uStack_4f0 = 0;
  puStack_5a8 = puStack_d20;
  local_4f8 = plVar7;
  iVar4 = _Mtx_lock(plVar7);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar6 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar6 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_4f0 = CONCAT71(uStack_4f0._1_7_,1);
  if ((char)plVar6[1] != '\0') {
    local_598[0] = 0;
    local_598[1] = 0;
    local_598[2] = 0;
    local_da8 = local_598;
    (**(code **)(*plVar6 + 0x18))(plVar6,local_600,&local_d54,&local_d28);
    FUN_18000bd00(local_598);
  }
  _Mtx_unlock(plVar7);
  FUN_18000bd00((longlong *)&local_d28);
  _eh_vector_destructor_iterator_(local_bd8 + 8,0x20,1,thunk_FUN_18000c8d0);
  plVar7 = *(longlong **)(this + 0x298);
  local_a98 = 0;
  uStack_a90 = 0;
  local_a88 = 0;
  uStack_a80 = 0;
  FUN_18000c1d0(&local_a98,&DAT_18017c130,1);
  local_d08 = (undefined8 *)0x0;
  puStack_d00 = (undefined8 *)0x0;
  local_cf8 = 0;
  FUN_18000bc20((ulonglong *)&local_d08,1);
  puVar2 = local_d08;
  local_930 = &local_d08;
  local_580 = local_d08;
  puStack_578 = local_d08;
  local_570 = &local_d08;
  FUN_18000cb00(local_d08,&local_a98);
  puStack_d00 = puVar2 + 4;
  local_d90[0] = 0xb;
  plVar6 = plVar7 + 2;
  uStack_500 = 0;
  puStack_578 = puStack_d00;
  local_508 = plVar6;
  iVar4 = _Mtx_lock(plVar6);
  if (iVar4 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  if (*(int *)((longlong)plVar7 + 0x5c) == 0x7fffffff) {
    *(undefined4 *)((longlong)plVar7 + 0x5c) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar12 = (code *)swi(3);
    (*pcVar12)();
    return;
  }
  uStack_500 = CONCAT71(uStack_500._1_7_,1);
  if ((char)plVar7[1] != '\0') {
    local_568[0] = 0;
    local_568[1] = 0;
    local_568[2] = 0;
    local_da8 = local_568;
    (**(code **)(*plVar7 + 0x18))(plVar7,local_600,local_d90,&local_d08);
    FUN_18000bd00(local_568);
  }
  _Mtx_unlock(plVar6);
  FUN_18000bd00((longlong *)&local_d08);
  _eh_vector_destructor_iterator_(&local_a98,0x20,1,thunk_FUN_18000c8d0);
  setCamerasFPS(this,DAT_18017ec50,DAT_18017ec50);
  FUN_1800090b0(&local_c08);
  if (local_c08 == 0x7ffffffffa0a1eff) {
LAB_1800e47b4:
    local_d30 = 0x7fffffffffffffff;
  }
  else {
    cVar8 = '\x01';
    if (local_c08 < 0x7ffffffffa0a1eff) {
      cVar8 = -1;
    }
    if (-1 < cVar8) goto LAB_1800e47b4;
    local_d30 = local_c08 + 100000000;
  }
  FUN_180007780(&local_d30);
  memset(&local_218,0,0xb8);
  Libraries::Core::Parameters::Parameters((Parameters *)&local_218);
  local_a58[0] = 0;
  local_a58[1] = 0;
  local_a58[2] = 0;
  local_a58[3] = 0;
  FUN_18000c1d0(local_a58,"Action",6);
  pPVar5 = Libraries::Core::Parameters::get
                     ((Parameters *)&local_218,
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)local_a58);
  local_a78[0] = 0;
  local_a78[1] = 0;
  local_a78[2] = 0;
  local_a78[3] = 0;
  FUN_18000c1d0(local_a78,"SingleFrame",0xb);
  Libraries::Core::Parameter::setValue
            (pPVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    local_a78);
  FUN_18000c8d0(local_a78);
  FUN_18000c8d0(local_a58);
  local_868 = (longlong *)0x0;
  local_d98 = local_8a0;
  local_d48 = local_720;
  local_6e8 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_600,&local_218,local_720);
  if (local_868 != (longlong *)0x0) {
    (**(code **)(*local_868 + 0x20))
              (local_868,CONCAT71((int7)((ulonglong)local_8a0 >> 8),local_868 != local_8a0));
  }
  FUN_1800090b0((longlong *)&local_d50);
  if (local_d50 == (longlong *)0x7ffffffffd050f7f) {
LAB_1800e491f:
    local_d48 = (longlong *)0x7fffffffffffffff;
  }
  else {
    cVar8 = '\x01';
    if ((longlong)local_d50 < 0x7ffffffffd050f7f) {
      cVar8 = -1;
    }
    if (-1 < cVar8) goto LAB_1800e491f;
    local_d48 = local_d50 + 0x5f5e10;
  }
  FUN_180007780((longlong *)&local_d48);
  local_828 = (longlong *)0x0;
  local_d98 = local_860;
  local_d80 = (longlong *)local_6e0;
  local_6a8 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_620,&local_218,local_6e0);
  if (local_828 != (longlong *)0x0) {
    (**(code **)(*local_828 + 0x20))();
  }
  memset(&local_2d8,0,0xb8);
  Libraries::Core::Parameters::Parameters((Parameters *)&local_2d8);
  local_a18[0] = 0;
  local_a18[1] = 0;
  local_a18[2] = 0;
  local_a18[3] = 0;
  FUN_18000c1d0(local_a18,"Action",6);
  pPVar5 = Libraries::Core::Parameters::get
                     ((Parameters *)&local_2d8,
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)local_a18);
  local_a38[0] = 0;
  local_a38[1] = 0;
  local_a38[2] = 0;
  local_a38[3] = 0;
  FUN_18000c1d0(local_a38,"StartAcquisition",0x10);
  Libraries::Core::Parameter::setValue
            (pPVar5,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                    local_a38);
  FUN_18000c8d0(local_a38);
  FUN_18000c8d0(local_a18);
  local_7e8 = (longlong *)0x0;
  local_d80 = local_820;
  local_d98 = local_6a0;
  local_668 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_600,&local_2d8,local_6a0);
  if (local_7e8 != (longlong *)0x0) {
    (**(code **)(*local_7e8 + 0x20))
              (local_7e8,CONCAT71((int7)((ulonglong)local_820 >> 8),local_7e8 != local_820));
  }
  FUN_1800090b0((longlong *)&local_d88);
  if (local_d88 != (longlong *)0x7ffffffffd050f7f) {
    cVar8 = '\x01';
    if ((longlong)local_d88 < 0x7ffffffffd050f7f) {
      cVar8 = -1;
    }
    if (cVar8 < '\0') {
      local_d98 = local_d88 + 0x5f5e10;
      goto LAB_1800e4aee;
    }
  }
  local_d98 = (longlong *)0x7fffffffffffffff;
LAB_1800e4aee:
  FUN_180007780((longlong *)&local_d98);
  local_7a8 = (longlong *)0x0;
  local_d80 = local_7e0;
  local_928 = local_660;
  local_628 = 0;
  (**(code **)(**(longlong **)(this + 0x298) + 0x58))
            (*(longlong **)(this + 0x298),local_620,&local_2d8,local_660);
  if (local_7a8 != (longlong *)0x0) {
    (**(code **)(*local_7a8 + 0x20))
              (local_7a8,CONCAT71((int7)((ulonglong)local_7e0 >> 8),local_7a8 != local_7e0));
  }
  LOCK();
  this[0x728] = (Interface)0x0;
  UNLOCK();
  *in_RDX = 0xffffffff;
  *(undefined1 *)(in_RDX + 1) = 1;
  local_2d8 = Libraries::Core::Parameters::vftable;
  Libraries::Core::Parameters::clear((Parameters *)&local_2d8);
  _Mtx_destroy_in_situ(local_270);
  _Mtx_destroy_in_situ(local_2c0);
  FUN_18000de20(local_2d0);
  local_218 = Libraries::Core::Parameters::vftable;
  Libraries::Core::Parameters::clear((Parameters *)&local_218);
  _Mtx_destroy_in_situ(local_1b0);
  _Mtx_destroy_in_situ(local_200);
  FUN_18000de20(local_210);
  local_158 = Libraries::Core::Parameters::vftable;
  Libraries::Core::Parameters::clear((Parameters *)&local_158);
  _Mtx_destroy_in_situ(local_f0);
  _Mtx_destroy_in_situ(local_140);
  FUN_18000de20(local_150);
  FUN_18000c8d0(local_600);
  FUN_18000c8d0(local_620);
  return;
}

