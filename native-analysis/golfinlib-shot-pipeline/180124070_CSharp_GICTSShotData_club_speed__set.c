FUNCTION: CSharp_GICTSShotData_club_speed__set
ENTRY: 180124070
REASONS: name:club


void CSharp_GICTSShotData_club_speed__set(longlong param_1,undefined4 param_2)

{
                    /* 0x124070  1134  CSharp_GICTSShotData_club_speed__set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x48) = param_2;
  }
  return;
}

