FUNCTION: CSharp_GICTSShotData_ball_side_spin__set
ENTRY: 180123ec0
REASONS: name:spin


void CSharp_GICTSShotData_ball_side_spin__set(longlong param_1,undefined4 param_2)

{
                    /* 0x123ec0  1116  CSharp_GICTSShotData_ball_side_spin__set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x10) = param_2;
  }
  return;
}

