FUNCTION: GolfIn::Interface::loadSpinPredictor
ENTRY: 1800bc890
REASONS: name:spin


/* public: void __cdecl GolfIn::Interface::loadSpinPredictor(void) __ptr64 */

void __thiscall GolfIn::Interface::loadSpinPredictor(Interface *this)

{
  void *pvVar1;
  bool bVar2;
  Parameter *pPVar3;
  longlong *plVar4;
  undefined8 *puVar5;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar6;
  undefined *puVar7;
  bool local_f0 [8];
  longlong local_e8 [8];
  undefined8 *local_a8;
  longlong local_a0;
  longlong lStack_98;
  longlong local_90;
  longlong lStack_88;
  error_code local_80 [32];
  error_code local_60 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_40 [40];
  
                    /* 0xbc890  787  ?loadSpinPredictor@Interface@GolfIn@@QEAAXXZ */
  local_f0[0] = false;
  local_e8[0] = 0;
  local_e8[1] = 0;
  local_e8[2] = 0;
  local_e8[3] = 0;
  FUN_18000c1d0(local_e8,"Configurations.Process.UseMLForBackSpinAndSideSpin",0x32);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )local_e8);
  if (bVar2) {
    pPVar3 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_e8);
    bVar2 = Libraries::Core::Parameter::toBoolean(pPVar3);
  }
  else {
    pPVar3 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_e8);
    Libraries::Core::Parameter::setValue(pPVar3,local_f0);
    pPVar3 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)local_e8);
    bVar2 = Libraries::Core::Parameter::toBoolean(pPVar3);
    saveParameters(this);
  }
  FUN_18000c8d0(local_e8);
  if (bVar2 != false) {
    plVar4 = FUN_1800014c0();
    local_e8[0] = 0;
    local_e8[1] = 0;
    local_e8[2] = 0;
    local_e8[3] = 0;
    FUN_18000c1d0(local_e8,"Loading ML Spin Predictor service...",0x24);
    FUN_180084c00(plVar4,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)local_e8,1,'\x01');
    puVar5 = (undefined8 *)FUN_1801327e0(0xa8);
    local_a8 = puVar5;
    memset(puVar5,0,0xa8);
    local_e8[4] = 0;
    local_e8[5] = 0;
    local_e8[6] = 0;
    local_e8[7] = 0;
    FUN_18000c1d0(local_e8 + 4,"IronBackSpinPredictor",0x15);
    local_e8[0] = 0;
    local_e8[1] = 0;
    local_e8[2] = 0;
    local_e8[3] = 0;
    FUN_18000c1d0(local_e8,"irons_backspin_predictor.onnx",0x1d);
    boost::filesystem::detail::current_path(local_80);
    pbVar6 = FUN_180068b10((wchar_t *)local_80,local_40);
    puVar7 = &DAT_18016a0b8;
    plVar4 = FUN_18000a490((longlong *)pbVar6,&DAT_18016a0b8,1);
    local_a0 = *plVar4;
    lStack_98 = plVar4[1];
    local_90 = plVar4[2];
    lStack_88 = plVar4[3];
    plVar4[2] = 0;
    plVar4[3] = 0xf;
    *(undefined1 *)plVar4 = 0;
    FUN_18000c8d0((longlong *)local_40);
    FUN_180025f40((longlong *)local_80);
    FUN_1800228c0((undefined8 *)local_60,puVar7,&local_a0,local_e8);
    FUN_180126180(puVar5,(char *)(local_e8 + 4),(char *)local_60,'\0');
    FUN_18000c8d0((longlong *)local_60);
    FUN_18000c8d0(&local_a0);
    FUN_18000c8d0(local_e8);
    *puVar5 = SpinPredictor::vftable;
    FUN_18000c8d0(local_e8 + 4);
    pvVar1 = *(void **)(this + 0x840);
    *(undefined8 **)(this + 0x840) = puVar5;
    if (pvVar1 != (void *)0x0) {
      FUN_1800a3af0((longlong)pvVar1);
      free(pvVar1);
    }
    puVar5 = (undefined8 *)FUN_1801327e0(0xa8);
    local_a8 = puVar5;
    memset(puVar5,0,0xa8);
    local_e8[0] = 0;
    local_e8[1] = 0;
    local_e8[2] = 0;
    local_e8[3] = 0;
    FUN_18000c1d0(local_e8,"IronSideSpinPredictor",0x15);
    local_e8[4] = 0;
    local_e8[5] = 0;
    local_e8[6] = 0;
    local_e8[7] = 0;
    FUN_18000c1d0(local_e8 + 4,"irons_sidespin_predictor.onnx",0x1d);
    boost::filesystem::detail::current_path(local_60);
    pbVar6 = FUN_180068b10((wchar_t *)local_60,local_40);
    puVar7 = &DAT_18016a0b8;
    plVar4 = FUN_18000a490((longlong *)pbVar6,&DAT_18016a0b8,1);
    local_a0 = *plVar4;
    lStack_98 = plVar4[1];
    local_90 = plVar4[2];
    lStack_88 = plVar4[3];
    plVar4[2] = 0;
    plVar4[3] = 0xf;
    *(undefined1 *)plVar4 = 0;
    FUN_18000c8d0((longlong *)local_40);
    FUN_180025f40((longlong *)local_60);
    FUN_1800228c0((undefined8 *)local_80,puVar7,&local_a0,local_e8 + 4);
    FUN_180126180(puVar5,(char *)local_e8,(char *)local_80,'\0');
    FUN_18000c8d0((longlong *)local_80);
    FUN_18000c8d0(&local_a0);
    FUN_18000c8d0(local_e8 + 4);
    *puVar5 = SpinPredictor::vftable;
    FUN_18000c8d0(local_e8);
    pvVar1 = *(void **)(this + 0x848);
    *(undefined8 **)(this + 0x848) = puVar5;
    if (pvVar1 != (void *)0x0) {
      FUN_1800a3af0((longlong)pvVar1);
      free(pvVar1);
    }
    puVar5 = (undefined8 *)FUN_1801327e0(0xa8);
    local_a8 = puVar5;
    memset(puVar5,0,0xa8);
    local_e8[0] = 0;
    local_e8[1] = 0;
    local_e8[2] = 0;
    local_e8[3] = 0;
    FUN_18000c1d0(local_e8,"WoodBackSpinPredictor",0x15);
    local_e8[4] = 0;
    local_e8[5] = 0;
    local_e8[6] = 0;
    local_e8[7] = 0;
    FUN_18000c1d0(local_e8 + 4,"woods_backspin_predictor.onnx",0x1d);
    boost::filesystem::detail::current_path(local_60);
    pbVar6 = FUN_180068b10((wchar_t *)local_60,local_40);
    puVar7 = &DAT_18016a0b8;
    plVar4 = FUN_18000a490((longlong *)pbVar6,&DAT_18016a0b8,1);
    local_a0 = *plVar4;
    lStack_98 = plVar4[1];
    local_90 = plVar4[2];
    lStack_88 = plVar4[3];
    plVar4[2] = 0;
    plVar4[3] = 0xf;
    *(undefined1 *)plVar4 = 0;
    FUN_18000c8d0((longlong *)local_40);
    FUN_180025f40((longlong *)local_60);
    FUN_1800228c0((undefined8 *)local_80,puVar7,&local_a0,local_e8 + 4);
    FUN_180126180(puVar5,(char *)local_e8,(char *)local_80,'\0');
    FUN_18000c8d0((longlong *)local_80);
    FUN_18000c8d0(&local_a0);
    FUN_18000c8d0(local_e8 + 4);
    *puVar5 = SpinPredictor::vftable;
    FUN_18000c8d0(local_e8);
    pvVar1 = *(void **)(this + 0x850);
    *(undefined8 **)(this + 0x850) = puVar5;
    if (pvVar1 != (void *)0x0) {
      FUN_1800a3af0((longlong)pvVar1);
      free(pvVar1);
    }
    puVar5 = (undefined8 *)FUN_1801327e0(0xa8);
    local_a8 = puVar5;
    memset(puVar5,0,0xa8);
    local_e8[0] = 0;
    local_e8[1] = 0;
    local_e8[2] = 0;
    local_e8[3] = 0;
    FUN_18000c1d0(local_e8,"WoodSideSpinPredictor",0x15);
    local_e8[4] = 0;
    local_e8[5] = 0;
    local_e8[6] = 0;
    local_e8[7] = 0;
    FUN_18000c1d0(local_e8 + 4,"woods_sidespin_predictor.onnx",0x1d);
    boost::filesystem::detail::current_path(local_60);
    pbVar6 = FUN_180068b10((wchar_t *)local_60,local_40);
    puVar7 = &DAT_18016a0b8;
    plVar4 = FUN_18000a490((longlong *)pbVar6,&DAT_18016a0b8,1);
    local_a0 = *plVar4;
    lStack_98 = plVar4[1];
    local_90 = plVar4[2];
    lStack_88 = plVar4[3];
    plVar4[2] = 0;
    plVar4[3] = 0xf;
    *(undefined1 *)plVar4 = 0;
    FUN_18000c8d0((longlong *)local_40);
    FUN_180025f40((longlong *)local_60);
    FUN_1800228c0((undefined8 *)local_80,puVar7,&local_a0,local_e8 + 4);
    FUN_180126180(puVar5,(char *)local_e8,(char *)local_80,'\0');
    FUN_18000c8d0((longlong *)local_80);
    FUN_18000c8d0(&local_a0);
    FUN_18000c8d0(local_e8 + 4);
    *puVar5 = SpinPredictor::vftable;
    FUN_18000c8d0(local_e8);
    pvVar1 = *(void **)(this + 0x858);
    *(undefined8 **)(this + 0x858) = puVar5;
    if (pvVar1 != (void *)0x0) {
      FUN_1800a3af0((longlong)pvVar1);
      free(pvVar1);
    }
  }
  return;
}

