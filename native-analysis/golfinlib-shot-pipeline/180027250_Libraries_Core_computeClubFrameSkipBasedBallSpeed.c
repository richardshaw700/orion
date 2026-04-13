FUNCTION: Libraries::Core::computeClubFrameSkipBasedBallSpeed
ENTRY: 180027250
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* int __cdecl Libraries::Core::computeClubFrameSkipBasedBallSpeed(float,float,float) */

int __cdecl
Libraries::Core::computeClubFrameSkipBasedBallSpeed(float param_1,float param_2,float param_3)

{
  int iVar1;
  int iVar2;
  double dVar3;
  
                    /* 0x27250  463  ?computeClubFrameSkipBasedBallSpeed@Core@Libraries@@YAHMMM@Z */
  dVar3 = exp((double)param_2 * _DAT_18017ed40);
  dVar3 = floor(dVar3 * (double)(float)((double)param_1 / DAT_18017ec00) * _DAT_18017eb20);
  iVar1 = (int)param_3;
  if ((int)dVar3 < (int)param_3) {
    iVar1 = (int)dVar3;
  }
  iVar2 = 1;
  if (1 < iVar1) {
    iVar2 = iVar1;
  }
  return iVar2;
}

