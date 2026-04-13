FUNCTION: GolfIn::Club::~Club
ENTRY: 1800a9a30
REASONS: name:club


/* public: virtual __cdecl GolfIn::Club::~Club(void) __ptr64 */

void __thiscall GolfIn::Club::~Club(Club *this)

{
  void *pvVar1;
  void *pvVar2;
  
                    /* 0xa9a30  81  ??1Club@GolfIn@@UEAA@XZ */
  *(undefined ***)this = vftable;
  FUN_180043090((longlong *)(this + 0x410));
  FUN_180043090((longlong *)(this + 0x3f8));
  pvVar1 = *(void **)(this + 0x3e0);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x3f0) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a9be9;
    free(pvVar2);
    *(undefined8 *)(this + 0x3e0) = 0;
    *(undefined8 *)(this + 1000) = 0;
    *(undefined8 *)(this + 0x3f0) = 0;
  }
  pvVar1 = *(void **)(this + 0x3c8);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x3d8) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a9be9;
    free(pvVar2);
    *(undefined8 *)(this + 0x3c8) = 0;
    *(undefined8 *)(this + 0x3d0) = 0;
    *(undefined8 *)(this + 0x3d8) = 0;
  }
  pvVar1 = *(void **)(this + 0x3b0);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x3c0) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a9be9;
    free(pvVar2);
    *(undefined8 *)(this + 0x3b0) = 0;
    *(undefined8 *)(this + 0x3b8) = 0;
    *(undefined8 *)(this + 0x3c0) = 0;
  }
  pvVar1 = *(void **)(this + 0x398);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x3a8) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) {
LAB_1800a9be9:
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar2);
    *(undefined8 *)(this + 0x398) = 0;
    *(undefined8 *)(this + 0x3a0) = 0;
    *(undefined8 *)(this + 0x3a8) = 0;
  }
  ClubData::~ClubData((ClubData *)(this + 0x1e8));
  ClubData::~ClubData((ClubData *)(this + 0x38));
  FUN_18000c8d0((longlong *)(this + 0x18));
  return;
}

