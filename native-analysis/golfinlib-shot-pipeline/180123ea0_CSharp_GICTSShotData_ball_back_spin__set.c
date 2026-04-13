FUNCTION: CSharp_GICTSShotData_ball_back_spin__set
ENTRY: 180123ea0
REASONS: name:spin


void CSharp_GICTSShotData_ball_back_spin__set(longlong param_1,undefined4 param_2)

{
                    /* 0x123ea0  1110  CSharp_GICTSShotData_ball_back_spin__set */
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0xc) = param_2;
  }
  return;
}

