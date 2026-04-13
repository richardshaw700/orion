FUNCTION: GolfIn::YoloClubSegmentation::YoloClubSegmentation
ENTRY: 180085190
REASONS: name:club


/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: __cdecl GolfIn::YoloClubSegmentation::YoloClubSegmentation(void) __ptr64 */

YoloClubSegmentation * __thiscall
GolfIn::YoloClubSegmentation::YoloClubSegmentation(YoloClubSegmentation *this)

{
  longlong lVar1;
  ulonglong uVar2;
  longlong *plVar3;
  wchar_t ****ppppwVar4;
  wchar_t ****ppppwVar5;
  YoloClubSegmentation *pYVar6;
  YoloClubSegmentation *pYVar7;
  wchar_t ***local_58 [2];
  longlong local_48;
  ulonglong local_40;
  longlong local_38 [3];
  undefined8 uStack_20;
  YoloClubSegmentation *local_18;
  
  local_18 = this;
                    /* 0x85190  72  ??0YoloClubSegmentation@GolfIn@@QEAA@XZ */
  BaseDeepLearning::BaseDeepLearning((BaseDeepLearning *)this);
  *(undefined ***)this = vftable;
  pYVar7 = this + 0xc0;
  *(undefined8 *)pYVar7 = 0;
  *(undefined8 *)(this + 200) = 0;
  *(undefined8 *)(this + 0xd0) = 0;
  *(undefined8 *)(this + 0xd8) = 0;
  FUN_18000c1d0((undefined8 *)pYVar7,"asset_seg.dat",0xd);
  *(undefined4 *)(this + 0xe0) = 0x280;
  *(undefined4 *)(this + 0xe4) = 0x280;
  *(undefined4 *)(this + 0xe8) = 0x3e800000;
  *(undefined4 *)(this + 0xec) = 0x3ee66666;
  *(undefined4 *)(this + 0xf0) = 0x3f000000;
  boost::filesystem::detail::current_path((error_code *)local_58);
  local_38[1] = 0;
  local_38[2] = _DAT_18017ef00;
  uStack_20 = _UNK_18017ef08;
  local_38[0] = 0;
  if (local_48 != 0) {
    ppppwVar4 = local_58;
    if (7 < local_40) {
      ppppwVar4 = (wchar_t ****)local_58[0];
    }
    ppppwVar5 = local_58;
    if (7 < local_40) {
      ppppwVar5 = (wchar_t ****)local_58[0];
    }
    boost::filesystem::detail::path_traits::convert
              ((wchar_t *)ppppwVar5,(wchar_t *)((longlong)ppppwVar4 + local_48 * 2),
               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
               local_38,(codecvt<wchar_t,char,struct__Mbstatet> *)0x0);
  }
  pYVar6 = this + 0xf8;
  plVar3 = FUN_18000a490(local_38,&DAT_18016a0b8,1);
  *(longlong *)pYVar6 = 0;
  *(undefined8 *)(this + 0x100) = 0;
  *(undefined8 *)(this + 0x108) = 0;
  *(undefined8 *)(this + 0x110) = 0;
  lVar1 = plVar3[1];
  *(longlong *)pYVar6 = *plVar3;
  *(longlong *)(this + 0x100) = lVar1;
  lVar1 = plVar3[3];
  *(longlong *)(this + 0x108) = plVar3[2];
  *(longlong *)(this + 0x110) = lVar1;
  plVar3[2] = 0;
  plVar3[3] = 0xf;
  *(undefined1 *)plVar3 = 0;
  FUN_18000c8d0(local_38);
  FUN_180025f40((longlong *)local_58);
  lVar1 = *(longlong *)(this + 0x108);
  uVar2 = *(ulonglong *)(this + 0xd0);
  if (uVar2 <= 0x7fffffffffffffffU - lVar1) {
    if (0xf < *(ulonglong *)(this + 0x110)) {
      pYVar6 = *(YoloClubSegmentation **)pYVar6;
    }
    if (0xf < *(ulonglong *)(this + 0xd8)) {
      pYVar7 = *(YoloClubSegmentation **)pYVar7;
    }
    FUN_18000bff0((undefined8 *)(this + 0x118),lVar1,uVar2,pYVar6,lVar1,pYVar7,uVar2);
    *(undefined8 *)(this + 0x138) = 0;
    *(undefined8 *)(this + 0x140) = 0;
    *(undefined8 *)(this + 0x148) = 0;
    *(undefined8 *)(this + 0x150) = 0;
    return this;
  }
                    /* WARNING: Subroutine does not return */
  FUN_18000c940();
}

