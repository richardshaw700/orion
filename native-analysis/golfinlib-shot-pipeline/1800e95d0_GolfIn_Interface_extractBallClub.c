FUNCTION: GolfIn::Interface::extractBallClub
ENTRY: 1800e95d0
REASONS: name:club; name:extractBallClub


/* public: bool __cdecl GolfIn::Interface::extractBallClub(class GolfIn::Shot & __ptr64,class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const &
   __ptr64,class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >
   const & __ptr64,class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > const & __ptr64) __ptr64 */

bool __thiscall
GolfIn::Interface::extractBallClub
          (Interface *this,Shot *param_1,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_3,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_4)

{
  bool bVar1;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *pmVar2;
  
                    /* 0xe95d0  561
                       ?extractBallClub@Interface@GolfIn@@QEAA_NAEAVShot@2@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@11@Z
                        */
  Shot::clear(param_1);
  pmVar2 = grabFrames(this,param_3,param_2);
  bVar1 = false;
  if (pmVar2 != (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
                 *)0x0) {
    bVar1 = extractBallClub(this,param_1,param_2,pmVar2,param_4);
  }
  return bVar1;
}

