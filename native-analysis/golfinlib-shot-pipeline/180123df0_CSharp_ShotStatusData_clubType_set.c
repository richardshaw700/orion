FUNCTION: CSharp_ShotStatusData_clubType_set
ENTRY: 180123df0
REASONS: name:club


void CSharp_ShotStatusData_clubType_set(longlong param_1,undefined4 param_2)

{
                    /* 0x123df0  1185  CSharp_ShotStatusData_clubType_set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x1c) = param_2;
  }
  return;
}

