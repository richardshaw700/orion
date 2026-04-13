FUNCTION: CSharp_GICTSShotData_club_attack_angle__set
ENTRY: 180124030
REASONS: name:club


void CSharp_GICTSShotData_club_attack_angle__set(longlong param_1,undefined4 param_2)

{
                    /* 0x124030  1128  CSharp_GICTSShotData_club_attack_angle__set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x40) = param_2;
  }
  return;
}

