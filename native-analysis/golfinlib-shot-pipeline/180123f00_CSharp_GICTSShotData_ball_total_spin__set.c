FUNCTION: CSharp_GICTSShotData_ball_total_spin__set
ENTRY: 180123f00
REASONS: name:spin


void CSharp_GICTSShotData_ball_total_spin__set(longlong param_1,undefined4 param_2)

{
                    /* 0x123f00  1122  CSharp_GICTSShotData_ball_total_spin__set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x18) = param_2;
  }
  return;
}

