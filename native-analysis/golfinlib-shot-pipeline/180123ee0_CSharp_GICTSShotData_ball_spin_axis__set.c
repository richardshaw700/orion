FUNCTION: CSharp_GICTSShotData_ball_spin_axis__set
ENTRY: 180123ee0
REASONS: name:spin


void CSharp_GICTSShotData_ball_spin_axis__set(longlong param_1,undefined4 param_2)

{
                    /* 0x123ee0  1120  CSharp_GICTSShotData_ball_spin_axis__set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x14) = param_2;
  }
  return;
}

