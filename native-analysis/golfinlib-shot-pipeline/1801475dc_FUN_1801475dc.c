FUNCTION: FUN_1801475dc
ENTRY: 1801475dc
REASONS: string:BackSpinSideSpinInference


undefined8 FUN_1801475dc(undefined8 param_1,longlong param_2)

{
  longlong lVar1;
  longlong *plVar2;
  void *pvVar3;
  longlong *plVar4;
  size_t sVar5;
  
  plVar2 = FUN_1800014c0();
  *(undefined8 *)(param_2 + 0x138) = 0;
  *(undefined8 *)(param_2 + 0x140) = 0;
  *(undefined8 *)(param_2 + 0x148) = 0;
  *(undefined8 *)(param_2 + 0x150) = 0;
  FUN_18000c1d0((undefined8 *)(param_2 + 0x138)," Compute with default spin config.",0x22);
  pvVar3 = (void *)(**(code **)(**(longlong **)(param_2 + 0xf8) + 8))();
  *(undefined8 *)(param_2 + 0x118) = 0;
  *(undefined8 *)(param_2 + 0x120) = 0;
  *(undefined8 *)(param_2 + 0x128) = 0;
  *(undefined8 *)(param_2 + 0x130) = 0;
  FUN_18000c1d0((undefined8 *)(param_2 + 0x118),
                "[Ball.BackSpinSideSpinInference] Error parsing spin config: ",0x3c);
  sVar5 = 0xffffffffffffffff;
  do {
    sVar5 = sVar5 + 1;
  } while (*(char *)((longlong)pvVar3 + sVar5) != '\0');
  plVar4 = FUN_18000a490((longlong *)(param_2 + 0x118),pvVar3,sVar5);
  lVar1 = plVar4[1];
  *(longlong *)(param_2 + 0x88) = *plVar4;
  *(longlong *)(param_2 + 0x90) = lVar1;
  lVar1 = plVar4[3];
  *(longlong *)(param_2 + 0x98) = plVar4[2];
  *(longlong *)(param_2 + 0xa0) = lVar1;
  plVar4[2] = 0;
  plVar4[3] = 0xf;
  *(undefined1 *)plVar4 = 0;
  FUN_1800228c0((undefined8 *)(param_2 + 0x48),pvVar3,(undefined8 *)(param_2 + 0x88),
                (undefined8 *)(param_2 + 0x138));
  FUN_180084c00(plVar2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)(param_2 + 0x48),3,'\x01');
  FUN_18000c8d0((longlong *)(param_2 + 0x88));
  FUN_18000c8d0((longlong *)(param_2 + 0x118));
  FUN_18000c8d0((longlong *)(param_2 + 0x138));
  return 0;
}

