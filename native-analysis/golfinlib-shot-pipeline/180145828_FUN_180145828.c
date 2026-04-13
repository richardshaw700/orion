FUNCTION: FUN_180145828
ENTRY: 180145828
REASONS: string:exportPostShot


undefined8 FUN_180145828(undefined8 param_1,longlong param_2)

{
  longlong *plVar1;
  longlong lVar2;
  char cVar3;
  
  plVar1 = FUN_1800014c0();
  *(undefined8 *)(param_2 + 0x48) = 0;
  *(undefined8 *)(param_2 + 0x50) = 0;
  *(undefined8 *)(param_2 + 0x58) = 0;
  *(undefined8 *)(param_2 + 0x60) = 0;
  FUN_18000c1d0((undefined8 *)(param_2 + 0x48),
                "[Save.ExportPostShotVideo] Waiting for the file to be unlocked...",0x41);
  FUN_180084c00(plVar1,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)(param_2 + 0x48),1,'\x01');
  FUN_1800090b0((longlong *)(param_2 + 0x90));
  lVar2 = *(longlong *)(param_2 + 0x90);
  if (lVar2 == 0x7ffffffffa0a1eff) {
    cVar3 = '\0';
  }
  else {
    cVar3 = '\x01';
    if (lVar2 < 0x7ffffffffa0a1eff) {
      cVar3 = -1;
    }
  }
  if (cVar3 < '\0') {
    lVar2 = lVar2 + 100000000;
  }
  else {
    lVar2 = 0x7fffffffffffffff;
  }
  *(longlong *)(param_2 + 0x120) = lVar2;
  FUN_180007780((longlong *)(param_2 + 0x120));
  return 0;
}

