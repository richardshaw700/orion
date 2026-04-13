FUNCTION: GolfIn::ClubData::~ClubData
ENTRY: 1800a86b0
REASONS: name:club


/* public: virtual __cdecl GolfIn::ClubData::~ClubData(void) __ptr64 */

void __thiscall GolfIn::ClubData::~ClubData(ClubData *this)

{
  void *pvVar1;
  void *pvVar2;
  
                    /* 0xa86b0  82  ??1ClubData@GolfIn@@UEAA@XZ */
  *(undefined ***)this = vftable;
  FUN_18000c8d0((longlong *)(this + 400));
  pvVar1 = *(void **)(this + 0x168);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x178) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x168) = 0;
    *(undefined8 *)(this + 0x170) = 0;
    *(undefined8 *)(this + 0x178) = 0;
  }
  pvVar1 = *(void **)(this + 0x150);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x160) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x150) = 0;
    *(undefined8 *)(this + 0x158) = 0;
    *(undefined8 *)(this + 0x160) = 0;
  }
  pvVar1 = *(void **)(this + 0x138);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x148) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x138) = 0;
    *(undefined8 *)(this + 0x140) = 0;
    *(undefined8 *)(this + 0x148) = 0;
  }
  pvVar1 = *(void **)(this + 0x120);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x130) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x120) = 0;
    *(undefined8 *)(this + 0x128) = 0;
    *(undefined8 *)(this + 0x130) = 0;
  }
  pvVar1 = *(void **)(this + 0x100);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x110) - (longlong)pvVar1 & 0xfffffffffffffff8U)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x100) = 0;
    *(undefined8 *)(this + 0x108) = 0;
    *(undefined8 *)(this + 0x110) = 0;
  }
  pvVar1 = *(void **)(this + 0xe8);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0xf8) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0xe8) = 0;
    *(undefined8 *)(this + 0xf0) = 0;
    *(undefined8 *)(this + 0xf8) = 0;
  }
  pvVar1 = *(void **)(this + 0xd0);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0xe0) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0xd0) = 0;
    *(undefined8 *)(this + 0xd8) = 0;
    *(undefined8 *)(this + 0xe0) = 0;
  }
  FUN_18000c8d0((longlong *)(this + 0x88));
  pvVar1 = *(void **)(this + 0x70);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x80) - (longlong)pvVar1 & 0xfffffffffffffff8U)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x70) = 0;
    *(undefined8 *)(this + 0x78) = 0;
    *(undefined8 *)(this + 0x80) = 0;
  }
  pvVar1 = *(void **)(this + 0x58);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x68) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x58) = 0;
    *(undefined8 *)(this + 0x60) = 0;
    *(undefined8 *)(this + 0x68) = 0;
  }
  pvVar1 = *(void **)(this + 0x38);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x48) - (longlong)pvVar1 & 0xfffffffffffffff8U)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x38) = 0;
    *(undefined8 *)(this + 0x40) = 0;
    *(undefined8 *)(this + 0x48) = 0;
  }
  pvVar1 = *(void **)(this + 0x20);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x30) - (longlong)pvVar1 & 0xfffffffffffffff8U)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) goto LAB_1800a8acb;
    free(pvVar2);
    *(undefined8 *)(this + 0x20) = 0;
    *(undefined8 *)(this + 0x28) = 0;
    *(undefined8 *)(this + 0x30) = 0;
  }
  pvVar1 = *(void **)(this + 8);
  if (pvVar1 != (void *)0x0) {
    pvVar2 = pvVar1;
    if ((0xfff < (*(longlong *)(this + 0x18) - (longlong)pvVar1 & 0xfffffffffffffffcU)) &&
       (pvVar2 = *(void **)((longlong)pvVar1 + -8),
       0x1f < (ulonglong)((longlong)pvVar1 + (-8 - (longlong)pvVar2)))) {
LAB_1800a8acb:
                    /* WARNING: Subroutine does not return */
      _invalid_parameter_noinfo_noreturn();
    }
    free(pvVar2);
    *(undefined8 *)(this + 8) = 0;
    *(undefined8 *)(this + 0x10) = 0;
    *(undefined8 *)(this + 0x18) = 0;
  }
  return;
}

