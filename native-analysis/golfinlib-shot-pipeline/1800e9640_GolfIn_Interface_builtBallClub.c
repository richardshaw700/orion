FUNCTION: GolfIn::Interface::builtBallClub
ENTRY: 1800e9640
REASONS: name:club


/* public: bool __cdecl GolfIn::Interface::builtBallClub(class GolfIn::Shot & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >
   const & __ptr64,class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const & __ptr64) __ptr64 */

bool __thiscall
GolfIn::Interface::builtBallClub
          (Interface *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_3,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_4)

{
  bool bVar1;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *pmVar2;
  longlong *plVar3;
  undefined8 local_30;
  undefined8 uStack_28;
  undefined8 local_20;
  undefined8 local_18;
  
                    /* 0xe9640  425
                       ?builtBallClub@Interface@GolfIn@@QEAA_NAEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@11@Z
                        */
  pmVar2 = grabFrames(this,param_3,param_2);
  if (pmVar2 == (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
                 *)0x0) {
    plVar3 = FUN_1800014c0();
    local_20 = 0;
    local_30 = 0;
    uStack_28 = 0;
    local_18 = 0;
    FUN_18000c1d0(&local_30,"No frame available to built the ball and club",0x2d);
    FUN_180084c00(plVar3,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_30,1,'\x01');
    return false;
  }
  bVar1 = builtBallClub(this,param_1,param_2,pmVar2,param_4);
  return bVar1;
}

