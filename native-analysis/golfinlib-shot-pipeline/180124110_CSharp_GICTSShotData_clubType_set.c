FUNCTION: CSharp_GICTSShotData_clubType_set
ENTRY: 180124110
REASONS: name:club


void CSharp_GICTSShotData_clubType_set(longlong param_1,undefined4 param_2)

{
                    /* 0x124110  1126  CSharp_GICTSShotData_clubType_set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x5c) = param_2;
  }
  return;
}

