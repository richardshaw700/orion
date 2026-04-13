FUNCTION: FUN_18014591b
ENTRY: 18014591b
REASONS: string:exportPostShot


undefined8 FUN_18014591b(undefined8 param_1,longlong param_2)

{
  longlong lVar1;
  void *pvVar2;
  longlong *plVar3;
  size_t sVar4;
  
  pvVar2 = (void *)(**(code **)(**(longlong **)(param_2 + 0xe0) + 8))();
  *(undefined8 *)(param_2 + 0x100) = 0;
  *(undefined8 *)(param_2 + 0x108) = 0;
  *(undefined8 *)(param_2 + 0x110) = 0;
  *(undefined8 *)(param_2 + 0x118) = 0;
  sVar4 = 0xffffffffffffffff;
  do {
    sVar4 = sVar4 + 1;
  } while (*(char *)((longlong)pvVar2 + sVar4) != '\0');
  FUN_18000c1d0((undefined8 *)(param_2 + 0x100),pvVar2,sVar4);
  plVar3 = FUN_1800014c0();
  lVar1 = *(longlong *)(param_2 + 0x110);
  if (0x7fffffffffffffffU - lVar1 < 0x4c) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  pvVar2 = (void *)(param_2 + 0x100);
  if (0xf < *(ulonglong *)(param_2 + 0x118)) {
    pvVar2 = *(void **)(param_2 + 0x100);
  }
  FUN_18000bff0((undefined8 *)(param_2 + 0x48),lVar1,sVar4,
                "[Save.ExportPostShotVideo] Exception on export post-shot Video ! - Reason : ",0x4c,
                pvVar2,lVar1);
  FUN_180084c00(plVar3,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)(param_2 + 0x48),3,'\x01');
  FUN_18000c8d0((longlong *)(param_2 + 0x100));
  return 0;
}

