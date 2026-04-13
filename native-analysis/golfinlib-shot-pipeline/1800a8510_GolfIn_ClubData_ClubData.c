FUNCTION: GolfIn::ClubData::ClubData
ENTRY: 1800a8510
REASONS: name:club


/* public: __cdecl GolfIn::ClubData::ClubData(class GolfIn::Shot & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64) __ptr64 */

ClubData * __thiscall
GolfIn::ClubData::ClubData
          (ClubData *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2)

{
                    /* 0xa8510  27
                       ??0ClubData@GolfIn@@QEAA@AEAVShot@1@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z
                        */
  *(undefined ***)this = vftable;
  *(undefined8 *)(this + 8) = 0;
  *(undefined8 *)(this + 0x10) = 0;
  *(undefined8 *)(this + 0x18) = 0;
  *(undefined8 *)(this + 0x20) = 0;
  *(undefined8 *)(this + 0x28) = 0;
  *(undefined8 *)(this + 0x30) = 0;
  *(undefined8 *)(this + 0x38) = 0;
  *(undefined8 *)(this + 0x40) = 0;
  *(undefined8 *)(this + 0x48) = 0;
  *(undefined8 *)(this + 0x58) = 0;
  *(undefined8 *)(this + 0x60) = 0;
  *(undefined8 *)(this + 0x68) = 0;
  *(undefined8 *)(this + 0x70) = 0;
  *(undefined8 *)(this + 0x78) = 0;
  *(undefined8 *)(this + 0x80) = 0;
  *(undefined8 *)(this + 0x88) = 0;
  *(undefined8 *)(this + 0x90) = 0;
  *(undefined8 *)(this + 0x98) = 0;
  *(undefined8 *)(this + 0xa0) = 0;
  FUN_18000c1d0((undefined8 *)(this + 0x88),"unknown",7);
  *(undefined8 *)(this + 0xa8) = 0xbff0000000000000;
  *(undefined8 *)(this + 0xb0) = 0;
  *(undefined8 *)(this + 0xb8) = 0;
  *(undefined4 *)(this + 0xc0) = 0;
  *(undefined8 *)(this + 0xd0) = 0;
  *(undefined8 *)(this + 0xd8) = 0;
  *(undefined8 *)(this + 0xe0) = 0;
  *(undefined8 *)(this + 0xe8) = 0;
  *(undefined8 *)(this + 0xf0) = 0;
  *(undefined8 *)(this + 0xf8) = 0;
  *(undefined8 *)(this + 0x100) = 0;
  *(undefined8 *)(this + 0x108) = 0;
  *(undefined8 *)(this + 0x110) = 0;
  *(undefined4 *)(this + 0x118) = 0xffffffff;
  *(undefined8 *)(this + 0x120) = 0;
  *(undefined8 *)(this + 0x128) = 0;
  *(undefined8 *)(this + 0x130) = 0;
  *(undefined8 *)(this + 0x138) = 0;
  *(undefined8 *)(this + 0x140) = 0;
  *(undefined8 *)(this + 0x148) = 0;
  *(undefined8 *)(this + 0x150) = 0;
  *(undefined8 *)(this + 0x158) = 0;
  *(undefined8 *)(this + 0x160) = 0;
  *(undefined8 *)(this + 0x168) = 0;
  *(undefined8 *)(this + 0x170) = 0;
  *(undefined8 *)(this + 0x178) = 0;
  *(undefined4 *)(this + 0x180) = 0xffffffff;
  *(Shot **)(this + 0x188) = param_1;
  FUN_18000cb00((undefined8 *)(this + 400),(undefined8 *)param_2);
  clear(this);
  return this;
}

