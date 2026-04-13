FUNCTION: GolfIn::Interface::commonLoadCamera
ENTRY: 1800e1470
REASONS: name:loadCamera; string:loadCamera


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Type propagation algorithm not settling */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* protected: enum Libraries::CamerasCore::Error __cdecl GolfIn::Interface::commonLoadCamera(void)
   __ptr64 */

Error __thiscall GolfIn::Interface::commonLoadCamera(Interface *this)

{
  int *piVar1;
  Interface *pIVar2;
  char cVar3;
  longlong lVar4;
  double dVar5;
  undefined4 uVar6;
  undefined4 uVar7;
  undefined4 uVar8;
  bool bVar9;
  int iVar10;
  Error EVar11;
  int extraout_EAX;
  longlong *plVar12;
  Parameter *pPVar13;
  longlong *plVar14;
  undefined8 *******pppppppuVar15;
  Parameters *pPVar16;
  longlong *******ppppppplVar17;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar18;
  AutoCamerasSettingsController *pAVar19;
  undefined8 *puVar20;
  undefined8 *puVar21;
  undefined8 *puVar22;
  char *pcVar23;
  char *pcVar24;
  longlong *plVar25;
  undefined8 *******pppppppuVar26;
  undefined8 uVar27;
  undefined8 in_R9;
  code *pcVar28;
  uint uVar29;
  float fVar30;
  float fVar31;
  undefined1 auStackY_9a8 [32];
  bool local_968;
  bool local_967;
  bool local_966 [2];
  uint local_964;
  longlong *local_960;
  uint local_958;
  AutoCamerasSettingsController *local_950;
  int local_948 [4];
  undefined8 *local_938;
  undefined8 *puStack_930;
  undefined8 local_928;
  undefined8 *local_920;
  undefined8 *puStack_918;
  undefined8 local_910;
  undefined8 local_908;
  undefined8 uStack_900;
  undefined8 local_8f8;
  undefined8 uStack_8f0;
  undefined8 local_8e8;
  undefined8 uStack_8e0;
  undefined8 local_8d8;
  undefined8 uStack_8d0;
  longlong local_8c8 [4];
  longlong *******local_8a8;
  undefined8 uStack_8a0;
  size_t local_898;
  ulonglong local_890;
  undefined8 *******local_888;
  undefined8 uStack_880;
  size_t local_878;
  ulonglong local_870;
  longlong local_868 [4];
  longlong local_848 [4];
  longlong local_828 [4];
  longlong local_808 [4];
  longlong local_7e8;
  longlong lStack_7e0;
  longlong local_7d8;
  longlong lStack_7d0;
  longlong local_7c8;
  longlong lStack_7c0;
  longlong local_7b8;
  longlong lStack_7b0;
  longlong local_7a8 [4];
  longlong local_788 [4];
  undefined8 local_768;
  undefined8 uStack_760;
  undefined8 local_758;
  undefined8 local_750;
  undefined8 *******local_748 [3];
  ulonglong local_730;
  undefined8 local_728;
  undefined8 uStack_720;
  undefined8 local_718;
  undefined8 local_710;
  longlong local_708 [8];
  undefined8 local_6c8;
  undefined8 uStack_6c0;
  undefined8 local_6b8;
  undefined8 local_6b0;
  undefined8 local_6a8;
  undefined8 uStack_6a0;
  undefined8 local_698;
  undefined8 local_690;
  longlong local_688 [8];
  float local_648;
  undefined4 uStack_644;
  undefined4 uStack_640;
  undefined4 uStack_63c;
  undefined4 local_638;
  undefined4 uStack_634;
  undefined4 uStack_630;
  undefined4 uStack_62c;
  undefined8 local_628;
  undefined8 uStack_620;
  undefined8 local_618;
  undefined8 local_610;
  undefined8 local_608;
  undefined8 uStack_600;
  undefined8 local_5f8;
  undefined8 local_5f0;
  longlong local_5e8 [16];
  longlong local_568 [4];
  longlong local_548 [4];
  undefined8 **local_528;
  undefined8 **local_520;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_518 [32];
  longlong local_4f8 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_4d8 [32];
  undefined8 local_4b8 [4];
  longlong local_498 [4];
  longlong local_478 [4];
  char local_458 [32];
  longlong local_438 [4];
  longlong local_418 [4];
  undefined8 local_3f8 [4];
  undefined8 local_3d8 [4];
  undefined **local_3b8;
  longlong local_3b0 [2];
  undefined1 local_3a0 [80];
  undefined1 local_350 [88];
  Mat local_2f8 [96];
  Mat local_298 [96];
  undefined8 *local_238;
  longlong lStack_230;
  longlong *local_228;
  undefined8 uStack_220;
  longlong *local_218;
  undefined8 uStack_210;
  longlong *local_208;
  undefined8 uStack_200;
  undefined8 *local_1f8;
  undefined8 *puStack_1f0;
  undefined8 **local_1e8;
  longlong local_1e0 [3];
  undefined8 *local_1c8;
  undefined8 *puStack_1c0;
  undefined8 **local_1b8;
  longlong local_1b0 [3];
  undefined8 *******local_198 [2];
  undefined8 ******local_188;
  ulonglong local_180;
  undefined8 *******local_178 [2];
  undefined8 ******local_168;
  ulonglong local_160;
  longlong local_158 [4];
  undefined8 *******local_138 [3];
  ulonglong local_120;
  undefined **local_118;
  longlong local_110 [2];
  undefined1 local_100 [80];
  undefined1 local_b0 [88];
  ulonglong local_58;
  
                    /* 0xe1470  455
                       ?commonLoadCamera@Interface@GolfIn@@IEAA?AW4Error@CamerasCore@Libraries@@XZ
                        */
  local_58 = DAT_1801d1040 ^ (ulonglong)auStackY_9a8;
  uVar29 = 0;
  local_964 = 0;
  plVar12 = FUN_1800014c0();
  local_628 = 0;
  uStack_620 = 0;
  local_618 = 0;
  local_610 = 0;
  FUN_18000c1d0(&local_628,"[Interface::commonLoadCamera] initializing camera ->init()...",0x3d);
  uVar27 = CONCAT71((int7)((ulonglong)in_R9 >> 8),1);
  FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_628,0,'\x01');
  local_968 = false;
  local_8c8[0] = 0;
  local_8c8[1] = 0;
  local_8c8[2] = 0;
  local_8c8[3] = 0;
  FUN_18000c1d0(local_8c8,"Configurations.Cameras.ReverseMasterSlave",0x29);
  bVar9 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )local_8c8);
  if (bVar9) {
    pPVar13 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)local_8c8);
    Libraries::Core::Parameter::toBoolean(pPVar13);
  }
  else {
    pPVar13 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)local_8c8);
    Libraries::Core::Parameter::setValue(pPVar13,&local_968);
    pPVar13 = Libraries::Core::Parameters::get
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)local_8c8);
    Libraries::Core::Parameter::toBoolean(pPVar13);
    saveParameters(this);
  }
  FUN_18000c8d0(local_8c8);
  iVar10 = Libraries::CamerasCore::init(*(CamerasCore **)(this + 0x298));
  if (iVar10 == 0) {
    plVar12 = FUN_1800014c0();
    local_608 = 0;
    uStack_600 = 0;
    local_5f8 = 0;
    local_5f0 = 0;
    FUN_18000c1d0(&local_608,"loadCamera: adding camera ->add()...",0x24);
    pcVar23 = (char *)CONCAT71((int7)((ulonglong)uVar27 >> 8),1);
    FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_608,0,'\x01');
    memset(&local_118,0,0xb8);
    local_5e8[0] = 0;
    local_5e8[1] = 0;
    local_5e8[2] = 0;
    local_5e8[3] = 0;
    FUN_18000c1d0(local_5e8,"Configurations.Cameras.",0x17);
    Libraries::Core::Parameters::extract
              ((Parameters *)(this + 0x10),
               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
               &local_118);
    FUN_18000c8d0(local_5e8);
    EVar11 = Libraries::CamerasCore::add(*(CamerasCore **)(this + 0x298),(Parameters *)&local_118);
    if (EVar11 == 0) {
      local_238 = (undefined8 *)0x0;
      lStack_230 = 0;
      local_238 = (undefined8 *)FUN_1801327e0(0x48);
      *local_238 = local_238;
      local_238[1] = local_238;
      local_238[2] = local_238;
      *(undefined2 *)(local_238 + 3) = 0x101;
      plVar14 = *(longlong **)(this + 0x298);
      plVar12 = plVar14 + 2;
      uStack_220 = 0;
      local_228 = plVar12;
      iVar10 = _Mtx_lock(plVar12);
      if (iVar10 != 0) {
        std::_Throw_Cpp_error(5);
        pcVar28 = (code *)swi(3);
        EVar11 = (*pcVar28)();
        return EVar11;
      }
      if (*(int *)((longlong)plVar14 + 0x5c) == 0x7fffffff) {
        *(undefined4 *)((longlong)plVar14 + 0x5c) = 0x7ffffffe;
        std::_Throw_Cpp_error(6);
        pcVar28 = (code *)swi(3);
        EVar11 = (*pcVar28)();
        return EVar11;
      }
      uStack_220 = CONCAT71(uStack_220._1_7_,1);
      if ((char)plVar14[1] != '\0') {
        (**(code **)(*plVar14 + 0x68))(plVar14,&local_238);
      }
      _Mtx_unlock(plVar12);
      if (lStack_230 == 2) {
        cVar3 = *(char *)((longlong)local_238[1] + 0x19);
        puVar20 = (undefined8 *)local_238[1];
        puVar22 = local_238;
        while (puVar21 = puVar20, cVar3 == '\0') {
          if (*(int *)(puVar21 + 4) < 0) {
            puVar20 = (undefined8 *)puVar21[2];
            puVar21 = puVar22;
          }
          else {
            puVar20 = (undefined8 *)*puVar21;
          }
          cVar3 = *(char *)((longlong)puVar20 + 0x19);
          puVar22 = puVar21;
        }
        if ((*(char *)((longlong)puVar22 + 0x19) != '\0') || (0 < *(int *)(puVar22 + 4))) {
          puVar22 = local_238;
        }
        FUN_18000cb00(local_178,puVar22 + 5);
        cVar3 = *(char *)((longlong)local_238[1] + 0x19);
        puVar20 = (undefined8 *)local_238[1];
        puVar22 = local_238;
        while (puVar21 = puVar20, cVar3 == '\0') {
          if (*(int *)(puVar21 + 4) < 1) {
            puVar20 = (undefined8 *)puVar21[2];
            puVar21 = puVar22;
          }
          else {
            puVar20 = (undefined8 *)*puVar21;
          }
          cVar3 = *(char *)((longlong)puVar20 + 0x19);
          puVar22 = puVar21;
        }
        if ((*(char *)((longlong)puVar22 + 0x19) != '\0') || (1 < *(int *)(puVar22 + 4))) {
          puVar22 = local_238;
        }
        FUN_18000cb00(local_198,puVar22 + 5);
        pIVar2 = this + 0x2b8;
        lVar4 = *(longlong *)pIVar2;
        plVar12 = *(longlong **)(lVar4 + 8);
        FUN_180060450(pIVar2,pIVar2,plVar12);
        *(longlong *)(lVar4 + 8) = lVar4;
        *(longlong *)lVar4 = lVar4;
        *(longlong *)(lVar4 + 0x10) = lVar4;
        *(undefined8 *)(this + 0x2c0) = 0;
        plVar14 = FUN_1800f7d70((longlong *)pIVar2,local_178);
        if ((ulonglong)plVar14[3] < 7) {
          pcVar23 = "Camera1";
          FUN_18000c490(plVar14,7,plVar12,"Camera1");
        }
        else {
          plVar25 = plVar14;
          if (0xf < (ulonglong)plVar14[3]) {
            plVar25 = (longlong *)*plVar14;
          }
          plVar14[2] = 7;
          plVar12 = (longlong *)0x7;
          memmove(plVar25,"Camera1",7);
          *(undefined1 *)((longlong)plVar25 + 7) = 0;
        }
        plVar14 = FUN_1800f7d70((longlong *)pIVar2,local_198);
        if ((ulonglong)plVar14[3] < 7) {
          pcVar23 = "Camera2";
          FUN_18000c490(plVar14,7,plVar12,"Camera2");
        }
        else {
          plVar12 = plVar14;
          if (0xf < (ulonglong)plVar14[3]) {
            plVar12 = (longlong *)*plVar14;
          }
          plVar14[2] = 7;
          memmove(plVar12,"Camera2",7);
          *(undefined1 *)((longlong)plVar12 + 7) = 0;
        }
        pIVar2 = this + 0x2c8;
        lVar4 = *(longlong *)pIVar2;
        FUN_180060450(pIVar2,pIVar2,*(longlong **)(lVar4 + 8));
        *(longlong *)(lVar4 + 8) = lVar4;
        *(longlong *)lVar4 = lVar4;
        *(longlong *)(lVar4 + 0x10) = lVar4;
        *(undefined8 *)(this + 0x2d0) = 0;
        local_5e8[4] = 0;
        local_5e8[5] = 0;
        local_5e8[6] = 0;
        local_5e8[7] = 0;
        uVar27 = 7;
        FUN_18000c1d0(local_5e8 + 4,"Camera1",7);
        pppppppuVar15 = (undefined8 *******)FUN_1800f7eb0((longlong *)pIVar2,local_5e8 + 4);
        if ((undefined8 ********)pppppppuVar15 != local_178) {
          pcVar23 = (char *)local_178;
          if (0xf < local_160) {
            pcVar23 = (char *)local_178[0];
          }
          if (pppppppuVar15[3] < local_168) {
            FUN_18000c490((longlong *)pppppppuVar15,(ulonglong)local_168,uVar27,pcVar23);
          }
          else {
            pppppppuVar26 = pppppppuVar15;
            if ((undefined8 ******)0xf < pppppppuVar15[3]) {
              pppppppuVar26 = (undefined8 *******)*pppppppuVar15;
            }
            pppppppuVar15[2] = local_168;
            memmove(pppppppuVar26,pcVar23,(size_t)local_168);
            *(undefined1 *)((longlong)local_168 + (longlong)pppppppuVar26) = 0;
          }
        }
        FUN_18000c8d0(local_5e8 + 4);
        local_5e8[8] = 0;
        local_5e8[9] = 0;
        local_5e8[10] = 0;
        local_5e8[0xb] = 0;
        uVar27 = 7;
        FUN_18000c1d0(local_5e8 + 8,"Camera2",7);
        pppppppuVar15 = (undefined8 *******)FUN_1800f7eb0((longlong *)pIVar2,local_5e8 + 8);
        if ((undefined8 ********)pppppppuVar15 != local_198) {
          pcVar23 = (char *)local_198;
          if (0xf < local_180) {
            pcVar23 = (char *)local_198[0];
          }
          if (pppppppuVar15[3] < local_188) {
            FUN_18000c490((longlong *)pppppppuVar15,(ulonglong)local_188,uVar27,pcVar23);
          }
          else {
            pppppppuVar26 = pppppppuVar15;
            if ((undefined8 ******)0xf < pppppppuVar15[3]) {
              pppppppuVar26 = (undefined8 *******)*pppppppuVar15;
            }
            pppppppuVar15[2] = local_188;
            memmove(pppppppuVar26,pcVar23,(size_t)local_188);
            *(undefined1 *)((longlong)pppppppuVar26 + (longlong)local_188) = 0;
          }
        }
        FUN_18000c8d0(local_5e8 + 8);
        local_5e8[0xc] = 0;
        local_5e8[0xd] = 0;
        local_5e8[0xe] = 0;
        local_5e8[0xf] = 0;
        FUN_18000c1d0(local_5e8 + 0xc,"Configurations.Cameras.",0x17);
        pPVar16 = (Parameters *)
                  Libraries::Core::Parameters::extract
                            ((Parameters *)(this + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)&local_3b8);
        bVar9 = ::operator==(pPVar16,(Parameters *)&local_118);
        local_3b8 = Libraries::Core::Parameters::vftable;
        Libraries::Core::Parameters::clear((Parameters *)&local_3b8);
        _Mtx_destroy_in_situ(local_350);
        _Mtx_destroy_in_situ(local_3a0);
        FUN_18000de20(local_3b0);
        FUN_18000c8d0(local_5e8 + 0xc);
        local_960 = (longlong *)0x3;
        if (!bVar9) {
          local_568[0] = 0;
          local_568[1] = 0;
          local_568[2] = 0;
          local_568[3] = 0;
          FUN_18000c1d0(local_568,"Camera1.ID",10);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)&local_118,
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_568);
          iVar10 = _Mtx_lock(pPVar13 + 0x48);
          if (iVar10 != 0) {
            std::_Throw_Cpp_error(5);
            pcVar28 = (code *)swi(3);
            EVar11 = (*pcVar28)();
            return EVar11;
          }
          if (*(int *)(pPVar13 + 0x94) == 0x7fffffff) {
            *(undefined4 *)(pPVar13 + 0x94) = 0x7ffffffe;
            std::_Throw_Cpp_error(6);
            pcVar28 = (code *)swi(3);
            EVar11 = (*pcVar28)();
            return EVar11;
          }
          FUN_18000cb00((undefined8 *)local_518,(undefined8 *)(pPVar13 + 0x28));
          _Mtx_unlock(pPVar13 + 0x48);
          local_8a8 = (longlong *******)0x0;
          uStack_8a0 = 0;
          local_898 = 0;
          local_890 = 0;
          uVar27 = 7;
          pcVar23 = "Camera1";
          FUN_18000c1d0(&local_8a8,"Camera1",7);
          if (0x7fffffffffffffff - local_898 < 0x17) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          ppppppplVar17 = (longlong *******)&local_8a8;
          if (0xf < local_890) {
            ppppppplVar17 = local_8a8;
          }
          FUN_18000bff0(local_498,pcVar23,uVar27,"Configurations.Cameras.",0x17,ppppppplVar17,
                        local_898);
          plVar12 = FUN_18000a490(local_498,&DAT_18017c428,3);
          local_7e8 = *plVar12;
          lStack_7e0 = plVar12[1];
          local_7d8 = plVar12[2];
          lStack_7d0 = plVar12[3];
          plVar12[2] = 0;
          plVar12[3] = 0xf;
          *(undefined1 *)plVar12 = 0;
          FUN_18000c8d0(local_498);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_7e8);
          Libraries::Core::Parameter::setValue(pPVar13,local_518);
          FUN_18000c8d0(&local_7e8);
          FUN_18000c8d0((longlong *)&local_8a8);
          FUN_18000c8d0((longlong *)local_518);
          FUN_18000c8d0(local_568);
          local_548[0] = 0;
          local_548[1] = 0;
          local_548[2] = 0;
          local_548[3] = 0;
          FUN_18000c1d0(local_548,"Camera2.ID",10);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)&local_118,
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_548);
          iVar10 = _Mtx_lock(pPVar13 + 0x48);
          if (iVar10 != 0) {
            std::_Throw_Cpp_error(5);
            pcVar28 = (code *)swi(3);
            EVar11 = (*pcVar28)();
            return EVar11;
          }
          if (*(int *)(pPVar13 + 0x94) == 0x7fffffff) {
            *(undefined4 *)(pPVar13 + 0x94) = 0x7ffffffe;
            std::_Throw_Cpp_error(6);
            pcVar28 = (code *)swi(3);
            EVar11 = (*pcVar28)();
            return EVar11;
          }
          FUN_18000cb00((undefined8 *)local_4d8,(undefined8 *)(pPVar13 + 0x28));
          _Mtx_unlock(pPVar13 + 0x48);
          local_888 = (undefined8 *******)0x0;
          uStack_880 = 0;
          local_878 = 0;
          local_870 = 0;
          uVar27 = 7;
          pcVar24 = "Camera2";
          FUN_18000c1d0(&local_888,"Camera2",7);
          if (0x7fffffffffffffff - local_878 < 0x17) {
                    /* WARNING: Subroutine does not return */
            FUN_18000c940();
          }
          pppppppuVar15 = &local_888;
          if (0xf < local_870) {
            pppppppuVar15 = local_888;
          }
          pcVar23 = "Configurations.Cameras.";
          FUN_18000bff0(local_4f8,pcVar24,uVar27,"Configurations.Cameras.",0x17,pppppppuVar15,
                        local_878);
          plVar12 = FUN_18000a490(local_4f8,&DAT_18017c428,3);
          local_7c8 = *plVar12;
          lStack_7c0 = plVar12[1];
          local_7b8 = plVar12[2];
          lStack_7b0 = plVar12[3];
          plVar12[2] = 0;
          plVar12[3] = 0xf;
          *(undefined1 *)plVar12 = 0;
          uVar29 = 0x1fe0;
          local_964 = 0x1fe0;
          FUN_18000c8d0(local_4f8);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)&local_7c8);
          Libraries::Core::Parameter::setValue(pPVar13,local_4d8);
          FUN_18000c8d0(&local_7c8);
          FUN_18000c8d0((longlong *)&local_888);
          FUN_18000c8d0((longlong *)local_4d8);
          FUN_18000c8d0(local_548);
          local_788[0] = 0;
          local_788[1] = 0;
          local_788[2] = 0;
          local_788[3] = 0;
          FUN_18000c1d0(local_788,"ReverseMasterSlave",0x12);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)&local_118,
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_788);
          local_967 = Libraries::Core::Parameter::toBoolean(pPVar13);
          local_7a8[0] = 0;
          local_7a8[1] = 0;
          local_7a8[2] = 0;
          local_7a8[3] = 0;
          FUN_18000c1d0(local_7a8,"Configurations.Cameras.ReverseMasterSlave",0x29);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_7a8);
          Libraries::Core::Parameter::setValue(pPVar13,&local_967);
          FUN_18000c8d0(local_7a8);
          FUN_18000c8d0(local_788);
          saveParameters(this);
        }
        bVar9 = overwriteDefaultParameters(this);
        if (bVar9) {
          plVar12 = FUN_1800014c0();
          local_768 = 0;
          uStack_760 = 0;
          local_758 = 0;
          local_750 = 0;
          FUN_18000c1d0(&local_768,"[Load.Params] Overwrite default parameters!",0x2b);
          pcVar23 = (char *)CONCAT71((int7)((ulonglong)pcVar23 >> 8),1);
          FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                 *)&local_768,1,'\x01');
        }
        local_948[0] = 0x12;
        local_868[0] = 0;
        local_868[1] = 0;
        local_868[2] = 0;
        local_868[3] = 0;
        uVar27 = 0x21;
        FUN_18000c1d0(local_868,"Configurations.Cameras.OnLoadGain",0x21);
        bVar9 = Libraries::Core::Parameters::exist
                          ((Parameters *)(this + 0x10),
                           (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)local_868);
        if (bVar9) {
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_868);
          local_958 = Libraries::Core::Parameter::toInt(pPVar13);
        }
        else {
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_868);
          Libraries::Core::Parameter::setValue(pPVar13,local_948);
          pPVar13 = Libraries::Core::Parameters::get
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_868);
          local_958 = Libraries::Core::Parameter::toInt(pPVar13);
          saveParameters(this);
        }
        FUN_18000c8d0(local_868);
        plVar12 = (longlong *)**(longlong **)(this + 0x2c8);
        plVar14 = (longlong *)0x3;
        if (*(char *)((longlong)plVar12 + 0x19) == '\0') {
          local_520 = &local_938;
          do {
            FUN_18000cb00(local_158,plVar12 + 4);
            FUN_18000cb00(local_138,plVar12 + 8);
            plVar14 = *(longlong **)(this + 0x298);
            pbVar18 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)FUN_180116360(local_478,local_158,uVar27);
            pPVar13 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar18);
            dVar5 = Libraries::Core::Parameter::toDouble(pPVar13);
            iVar10 = FUN_180069fe0(&DAT_180170450,dVar5,uVar27,pcVar23);
            FUN_180022b10(local_748,(longlong)iVar10,'\0');
            uVar29 = uVar29 | 1;
            pppppppuVar15 = local_748;
            if (0xf < local_730) {
              pppppppuVar15 = local_748[0];
            }
            local_964 = uVar29;
            FUN_18006a050(pppppppuVar15,(longlong)iVar10 + 1,&DAT_180170450,dVar5);
            local_938 = (undefined8 *)0x0;
            puStack_930 = (undefined8 *)0x0;
            local_928 = 0;
            FUN_18000bc20((ulonglong *)&local_938,1);
            puVar20 = local_938;
            local_1f8 = local_938;
            puStack_1f0 = local_938;
            local_1e8 = &local_938;
            FUN_18000cb00(local_938,local_748);
            puStack_930 = puVar20 + 4;
            local_948[1] = 4;
            plVar25 = plVar14 + 2;
            uStack_210 = 0;
            local_218 = plVar25;
            puStack_1f0 = puStack_930;
            iVar10 = _Mtx_lock(plVar25);
            if (iVar10 != 0) {
              std::_Throw_Cpp_error(5);
              goto LAB_1800e2734;
            }
            iVar10 = *(int *)((longlong)plVar14 + 0x5c);
            if (iVar10 == 0x7fffffff) {
LAB_1800e2717:
              *(int *)((longlong)plVar25 + 0x4c) = iVar10 + -1;
              std::_Throw_Cpp_error(6);
              pcVar28 = (code *)swi(3);
              EVar11 = (*pcVar28)();
              return EVar11;
            }
            uStack_210 = CONCAT71(uStack_210._1_7_,1);
            if ((char)plVar14[1] != '\0') {
              local_1e0[0] = 0;
              local_1e0[1] = 0;
              local_1e0[2] = 0;
              (**(code **)(*plVar14 + 0x18))(plVar14,local_138,local_948 + 1,&local_938);
              FUN_18000bd00(local_1e0);
            }
            _Mtx_unlock(plVar25);
            FUN_18000bd00((longlong *)&local_938);
            _eh_vector_destructor_iterator_(local_748,0x20,1,thunk_FUN_18000c8d0);
            FUN_18000c8d0(local_478);
            plVar14 = *(longlong **)(this + 0x298);
            FUN_18000c2d0(local_4b8,local_958);
            local_920 = (undefined8 *)0x0;
            puStack_918 = (undefined8 *)0x0;
            local_910 = 0;
            FUN_18000bc20((ulonglong *)&local_920,1);
            puVar20 = local_920;
            local_528 = &local_920;
            local_1c8 = local_920;
            puStack_1c0 = local_920;
            local_1b8 = &local_920;
            FUN_18000cb00(local_920,local_4b8);
            puStack_918 = puVar20 + 4;
            local_948[2] = 6;
            plVar25 = plVar14 + 2;
            uStack_200 = 0;
            local_208 = plVar25;
            puStack_1c0 = puStack_918;
            iVar10 = _Mtx_lock(plVar25);
            if (iVar10 != 0) {
              std::_Throw_Cpp_error(5);
              iVar10 = extraout_EAX;
              goto LAB_1800e2717;
            }
            if (*(int *)((longlong)plVar14 + 0x5c) == 0x7fffffff) {
              *(undefined4 *)((longlong)plVar14 + 0x5c) = 0x7ffffffe;
              std::_Throw_Cpp_error(6);
              pcVar28 = (code *)swi(3);
              EVar11 = (*pcVar28)();
              return EVar11;
            }
            uStack_200 = CONCAT71(uStack_200._1_7_,1);
            if ((char)plVar14[1] != '\0') {
              local_1b0[0] = 0;
              local_1b0[1] = 0;
              local_1b0[2] = 0;
              (**(code **)(*plVar14 + 0x18))(plVar14,local_138,local_948 + 2,&local_920);
              FUN_18000bd00(local_1b0);
            }
            _Mtx_unlock(plVar25);
            FUN_18000bd00((longlong *)&local_920);
            pcVar28 = thunk_FUN_18000c8d0;
            _eh_vector_destructor_iterator_(local_4b8,0x20,1,thunk_FUN_18000c8d0);
            plVar14 = FUN_1800014c0();
            pppppppuVar15 = local_138;
            if (0xf < local_120) {
              pppppppuVar15 = local_138[0];
            }
            pbVar18 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)cv::format(local_458,"[LoadCamera] Set Exposure and Gain done on camera %s"
                                    ,pppppppuVar15);
            pcVar23 = (char *)CONCAT71((int7)((ulonglong)pcVar28 >> 8),1);
            uVar27 = 1;
            FUN_180084c00(plVar14,pbVar18,1,'\x01');
            FUN_18000c8d0((longlong *)local_138);
            FUN_18000c8d0(local_158);
            plVar14 = (longlong *)plVar12[2];
            if (*(char *)((longlong)plVar14 + 0x19) == '\0') {
              cVar3 = *(char *)(*plVar14 + 0x19);
              plVar12 = plVar14;
              plVar14 = (longlong *)*plVar14;
              while (cVar3 == '\0') {
                cVar3 = *(char *)(*plVar14 + 0x19);
                plVar12 = plVar14;
                plVar14 = (longlong *)*plVar14;
              }
            }
            else {
              cVar3 = *(char *)(plVar12[1] + 0x19);
              plVar25 = (longlong *)plVar12[1];
              plVar14 = plVar12;
              while ((plVar12 = plVar25, cVar3 == '\0' && (plVar14 == (longlong *)plVar12[2]))) {
                cVar3 = *(char *)(plVar12[1] + 0x19);
                plVar25 = (longlong *)plVar12[1];
                plVar14 = plVar12;
              }
            }
            plVar14 = local_960;
          } while (*(char *)((longlong)plVar12 + 0x19) == '\0');
        }
        plVar12 = FUN_1800014c0();
        local_728 = 0;
        uStack_720 = 0;
        local_718 = 0;
        local_710 = 0;
        FUN_18000c1d0(&local_728,"[LoadCamera] set Exposure, Gain and Format done on camera 2",0x3b)
        ;
        FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_728,1,'\x01');
        local_708[0] = 0;
        local_708[1] = 0;
        local_708[2] = 0;
        local_708[3] = 0;
        uVar27 = 7;
        FUN_18000c1d0(local_708,"Camera1",7);
        pbVar18 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_180115ca0(local_438,local_708,uVar27);
        pPVar13 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar18);
        fVar30 = Libraries::Core::Parameter::toFloat(pPVar13);
        FUN_18000c8d0(local_438);
        FUN_18000c8d0(local_708);
        local_708[4] = 0;
        local_708[5] = 0;
        local_708[6] = 0;
        local_708[7] = 0;
        uVar27 = 7;
        FUN_18000c1d0(local_708 + 4,"Camera2",7);
        pbVar18 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  FUN_180115ca0(local_418,local_708 + 4,uVar27);
        pPVar13 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar18);
        fVar31 = Libraries::Core::Parameter::toFloat(pPVar13);
        FUN_18000c8d0(local_418);
        FUN_18000c8d0(local_708 + 4);
        setCamerasFPS(this,fVar30,fVar31);
        *(undefined8 *)(this + 0x588) = 0x4054000000000000;
        this[0x590] = (Interface)0x1;
        plVar12 = FUN_1800014c0();
        local_6c8 = 0;
        uStack_6c0 = 0;
        local_6b8 = 0;
        local_6b0 = 0;
        FUN_18000c1d0(&local_6c8,"[Interface::commonLoadCamera] Starting camera ->start()...",0x3a);
        FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                               *)&local_6c8,0,'\x01');
        EVar11 = Libraries::CamerasCore::start(*(CamerasCore **)(this + 0x298));
        if (EVar11 == 0) {
LAB_1800e2734:
          local_966[0] = false;
          local_848[0] = 0;
          local_848[1] = 0;
          local_848[2] = 0;
          local_848[3] = 0;
          FUN_18000c1d0(local_848,"Configurations.Calibration.AutoGain.UseNewAutogainAlgo",0x36);
          bVar9 = Libraries::Core::Parameters::exist
                            ((Parameters *)(this + 0x10),
                             (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_848);
          if (bVar9) {
            pPVar13 = Libraries::Core::Parameters::get
                                ((Parameters *)(this + 0x10),
                                 (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)local_848);
            bVar9 = Libraries::Core::Parameter::toBoolean(pPVar13);
          }
          else {
            pPVar13 = Libraries::Core::Parameters::get
                                ((Parameters *)(this + 0x10),
                                 (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)local_848);
            Libraries::Core::Parameter::setValue(pPVar13,local_966);
            pPVar13 = Libraries::Core::Parameters::get
                                ((Parameters *)(this + 0x10),
                                 (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)local_848);
            bVar9 = Libraries::Core::Parameter::toBoolean(pPVar13);
            saveParameters(this);
          }
          FUN_18000c8d0(local_848);
          if (bVar9 != false) {
            local_908 = _DAT_18017f0f0;
            uStack_900 = _UNK_18017f0f8;
            local_8f8 = _DAT_18017f0e0;
            uStack_8f0 = _UNK_18017f0e8;
            local_828[0] = 0;
            local_828[1] = 0;
            local_828[2] = 0;
            local_828[3] = 0;
            FUN_18000c1d0(local_828,"Configurations.Calibration.AutoGain.MaxGain",0x2b);
            bVar9 = Libraries::Core::Parameters::exist
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_828);
            if (bVar9) {
              pPVar13 = Libraries::Core::Parameters::get
                                  ((Parameters *)(this + 0x10),
                                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)local_828);
              fVar30 = Libraries::Core::Parameter::toFloat(pPVar13);
            }
            else {
              pPVar13 = Libraries::Core::Parameters::get
                                  ((Parameters *)(this + 0x10),
                                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)local_828);
              Libraries::Core::Parameter::setValue
                        (pPVar13,(float *)((longlong)&local_908 + 4),(int)plVar14);
              pPVar13 = Libraries::Core::Parameters::get
                                  ((Parameters *)(this + 0x10),
                                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)local_828);
              fVar30 = Libraries::Core::Parameter::toFloat(pPVar13);
              saveParameters(this);
            }
            local_908 = CONCAT44(fVar30,(float)local_908);
            FUN_18000c8d0(local_828);
            local_808[0] = 0;
            local_808[1] = 0;
            local_808[2] = 0;
            local_808[3] = 0;
            FUN_18000c1d0(local_808,"Configurations.Calibration.AutoGain.MinGain",0x2b);
            bVar9 = Libraries::Core::Parameters::exist
                              ((Parameters *)(this + 0x10),
                               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                *)local_808);
            if (bVar9) {
              pPVar13 = Libraries::Core::Parameters::get
                                  ((Parameters *)(this + 0x10),
                                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)local_808);
              fVar30 = Libraries::Core::Parameter::toFloat(pPVar13);
            }
            else {
              pPVar13 = Libraries::Core::Parameters::get
                                  ((Parameters *)(this + 0x10),
                                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)local_808);
              Libraries::Core::Parameter::setValue(pPVar13,(float *)&local_908,(int)plVar14);
              pPVar13 = Libraries::Core::Parameters::get
                                  ((Parameters *)(this + 0x10),
                                   (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                    *)local_808);
              fVar30 = Libraries::Core::Parameter::toFloat(pPVar13);
              saveParameters(this);
            }
            local_908 = CONCAT44(local_908._4_4_,fVar30);
            FUN_18000c8d0(local_808);
            local_688[0] = 0;
            local_688[1] = 0;
            local_688[2] = 0;
            local_688[3] = 0;
            FUN_18000c1d0(local_688,"Camera1",7);
            plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_688);
            pAVar19 = (AutoCamerasSettingsController *)FUN_1801327e0(0xd8);
            local_950 = pAVar19;
            memset(pAVar19,0,0xd8);
            cv::Mat::Mat(local_2f8);
            local_964 = uVar29 | 8;
            puVar20 = FUN_18000cb00(local_3f8,plVar12);
            uVar29 = uVar29 | 8;
            if (*(longlong *)(this + 0x2a0) != 0) {
              LOCK();
              piVar1 = (int *)(*(longlong *)(this + 0x2a0) + 8);
              *piVar1 = *piVar1 + 1;
              UNLOCK();
              uVar29 = local_964;
            }
            local_8e8 = *(undefined8 *)(this + 0x298);
            uStack_8e0 = *(undefined8 *)(this + 0x2a0);
            fVar30 = (float)local_908;
            uVar6 = local_908._4_4_;
            uVar7 = (undefined4)uStack_900;
            uVar8 = uStack_900._4_4_;
            local_648 = (float)local_908;
            uStack_644 = local_908._4_4_;
            uStack_640 = (undefined4)uStack_900;
            uStack_63c = uStack_900._4_4_;
            local_638 = (undefined4)local_8f8;
            uStack_634 = local_8f8._4_4_;
            uStack_630 = (undefined4)uStack_8f0;
            uStack_62c = uStack_8f0._4_4_;
            uVar27 = AutoCamerasSettingsController::AutoCamerasSettingsController
                               (pAVar19,&local_8e8,puVar20,0x1e);
            if ((uVar29 & 8) != 0) {
              uVar29 = uVar29 & 0xfffffff7;
              cv::Mat::~Mat(local_2f8);
            }
            pAVar19 = *(AutoCamerasSettingsController **)(this + 0x810);
            *(undefined8 *)(this + 0x810) = uVar27;
            if (pAVar19 != (AutoCamerasSettingsController *)0x0) {
              AutoCamerasSettingsController::~AutoCamerasSettingsController(pAVar19);
              free(pAVar19);
            }
            FUN_18000c8d0(local_688);
            local_688[4] = 0;
            local_688[5] = 0;
            local_688[6] = 0;
            local_688[7] = 0;
            FUN_18000c1d0(local_688 + 4,"Camera2",7);
            plVar12 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_688 + 4);
            pAVar19 = (AutoCamerasSettingsController *)FUN_1801327e0(0xd8);
            local_950 = pAVar19;
            memset(pAVar19,0,0xd8);
            cv::Mat::Mat(local_298);
            local_964 = uVar29 | 0x12;
            puVar20 = FUN_18000cb00(local_3d8,plVar12);
            local_648 = fVar30;
            uStack_644 = uVar6;
            uStack_640 = uVar7;
            uStack_63c = uVar8;
            uVar29 = uVar29 | 0x12;
            if (*(longlong *)(this + 0x2a0) != 0) {
              LOCK();
              piVar1 = (int *)(*(longlong *)(this + 0x2a0) + 8);
              *piVar1 = *piVar1 + 1;
              UNLOCK();
              local_648 = (float)local_908;
              uStack_644 = local_908._4_4_;
              uStack_640 = (undefined4)uStack_900;
              uStack_63c = uStack_900._4_4_;
              uVar29 = local_964;
            }
            local_8d8 = *(undefined8 *)(this + 0x298);
            uStack_8d0 = *(undefined8 *)(this + 0x2a0);
            local_638 = (undefined4)local_8f8;
            uStack_634 = local_8f8._4_4_;
            uStack_630 = (undefined4)uStack_8f0;
            uStack_62c = uStack_8f0._4_4_;
            uVar27 = AutoCamerasSettingsController::AutoCamerasSettingsController
                               (pAVar19,&local_8d8,puVar20,0x1e);
            if ((uVar29 & 2) != 0) {
              cv::Mat::~Mat(local_298);
            }
            pAVar19 = *(AutoCamerasSettingsController **)(this + 0x818);
            *(undefined8 *)(this + 0x818) = uVar27;
            if (pAVar19 != (AutoCamerasSettingsController *)0x0) {
              AutoCamerasSettingsController::~AutoCamerasSettingsController(pAVar19);
              free(pAVar19);
            }
            FUN_18000c8d0(local_688 + 4);
          }
          bVar9 = loadCalibration(this);
          EVar11 = 0xb;
          if (bVar9) {
            EVar11 = 0;
          }
        }
        else {
          plVar12 = FUN_1800014c0();
          local_6a8 = 0;
          uStack_6a0 = 0;
          local_698 = 0;
          local_690 = 0;
          FUN_18000c1d0(&local_6a8,
                        "[Interface::commonLoadCamera] Error: Camera could not be started. Stopping cameras..."
                        ,0x55);
          FUN_180084c00(plVar12,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                 *)&local_6a8,(int)plVar14,'\x01');
          plVar12 = *(longlong **)(this + 0x298);
          if ((char)plVar12[0xc] != '\0') {
            (**(code **)(*plVar12 + 0x30))(plVar12);
            LOCK();
            *(undefined1 *)(plVar12 + 0xc) = 0;
            UNLOCK();
          }
        }
        FUN_18000c8d0((longlong *)local_198);
        FUN_18000c8d0((longlong *)local_178);
      }
      else {
        plVar12 = *(longlong **)(this + 0x298);
        if ((char)plVar12[0xc] != '\0') {
          (**(code **)(*plVar12 + 0x30))(plVar12);
          LOCK();
          *(undefined1 *)(plVar12 + 0xc) = 0;
          UNLOCK();
        }
        EVar11 = 3;
      }
      FUN_18005d000((longlong *)&local_238);
    }
    else {
      plVar12 = *(longlong **)(this + 0x298);
      if ((char)plVar12[0xc] != '\0') {
        (**(code **)(*plVar12 + 0x30))(plVar12);
        LOCK();
        *(undefined1 *)(plVar12 + 0xc) = 0;
        UNLOCK();
      }
    }
    local_118 = Libraries::Core::Parameters::vftable;
    Libraries::Core::Parameters::clear((Parameters *)&local_118);
    _Mtx_destroy_in_situ(local_b0);
    _Mtx_destroy_in_situ(local_100);
    FUN_18000de20(local_110);
  }
  else {
    plVar12 = *(longlong **)(this + 0x298);
    if ((char)plVar12[0xc] != '\0') {
      (**(code **)(*plVar12 + 0x30))(plVar12);
      LOCK();
      *(undefined1 *)(plVar12 + 0xc) = 0;
      UNLOCK();
    }
    EVar11 = 2;
  }
  return EVar11;
}

