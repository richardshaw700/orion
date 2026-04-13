FUNCTION: GolfIn::Interface::builtBallClub
ENTRY: 1800e96e0
REASONS: name:club


/* public: bool __cdecl GolfIn::Interface::builtBallClub(class GolfIn::Shot & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::map<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> >,class Libraries::CamerasCore::Frame,struct std::less<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > >,class
   std::allocator<struct std::pair<class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const ,class Libraries::CamerasCore::Frame> > > const & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64) __ptr64 */

bool __thiscall
GolfIn::Interface::builtBallClub
          (Interface *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_3,basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                   *param_4)

{
  bool bVar1;
  bool local_res10 [8];
  
                    /* 0xe96e0  426
                       ?builtBallClub@Interface@GolfIn@@QEAA_NAEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEBV?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@5@1@Z
                        */
  Shot::clear_built(param_1);
  bVar1 = Ball::built((Ball *)(param_1 + 8));
  if (bVar1) {
    Club::built((Club *)(param_1 + 0x2a0));
    if ((*(longlong *)(param_4 + 0x10) != 0) && (this[0x300] != (Interface)0x0)) {
      local_res10[0] = true;
      Shot::save(param_1,param_4,param_2,local_res10,param_3,
                 (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>_>_>
                  *)(this + 0x2c8));
    }
    bVar1 = true;
  }
  else {
    bVar1 = false;
  }
  return bVar1;
}

