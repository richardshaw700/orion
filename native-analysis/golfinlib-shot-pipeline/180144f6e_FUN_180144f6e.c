FUNCTION: FUN_180144f6e
ENTRY: 180144f6e
REASONS: string:Wait.For.Shot


undefined8 FUN_180144f6e(undefined8 param_1,longlong param_2)

{
  stacktrace *this;
  undefined8 *puVar1;
  undefined8 uVar2;
  longlong *plVar3;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar4;
  HANDLE hEventLog;
  longlong lVar5;
  
  this = cpptrace::from_current_exception();
  puVar1 = (undefined8 *)cpptrace::stacktrace::to_string(this,(bool)((char)param_2 + 'X'));
  if (0xf < (ulonglong)puVar1[3]) {
    puVar1 = (undefined8 *)*puVar1;
  }
  uVar2 = (**(code **)(**(longlong **)(param_2 + 0x50) + 8))();
  cv::format((char *)(param_2 + 0xa8),
             "[Wait.For.Shot] Error when trying to extract the shot. Exception message: %s, Stacktrace: %s"
             ,uVar2,puVar1);
  FUN_18000c8d0((longlong *)(param_2 + 0x58));
  plVar3 = FUN_1800014c0();
  pbVar4 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           FUN_18000cb00((undefined8 *)(param_2 + 0x78),(undefined8 *)(param_2 + 0xa8));
  FUN_180084c00(plVar3,pbVar4,3,'\x01');
  hEventLog = RegisterEventSourceA((LPCSTR)0x0,"IDRA-GolfinLib");
  lVar5 = param_2 + 0xa8;
  if (0xf < *(ulonglong *)(param_2 + 0xc0)) {
    lVar5 = *(longlong *)(param_2 + 0xa8);
  }
  *(longlong *)(param_2 + 0x98) = lVar5;
  ReportEventA(hEventLog,1,0,0,(PSID)0x0,1,0,(LPCSTR *)(param_2 + 0x98),(LPVOID)0x0);
  FUN_18000c8d0((longlong *)(param_2 + 0xa8));
  return 0;
}

