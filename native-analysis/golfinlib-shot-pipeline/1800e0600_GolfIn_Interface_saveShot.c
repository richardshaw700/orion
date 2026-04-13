FUNCTION: GolfIn::Interface::saveShot
ENTRY: 1800e0600
REASONS: name:saveShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl GolfIn::Interface::saveShot(class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> >,class GolfIn::Shot,class std::map<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,class
   Libraries::CamerasCore::Frame,struct std::less<class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > >,class std::allocator<struct std::pair<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const ,class
   Libraries::CamerasCore::Frame> > >) __ptr64 */

void __thiscall
GolfIn::Interface::saveShot
          (Interface *this,
          basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *param_2,
          Shot *param_3,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_4)

{
  longlong lVar1;
  longlong *plVar2;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar3;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar4;
  undefined1 auStackY_1a8 [32];
  bool local_168 [8];
  int local_160 [2];
  int local_158 [2];
  longlong local_150;
  longlong lStack_148;
  longlong local_140;
  longlong lStack_138;
  longlong local_130 [9];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_e8 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_c8 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_a8 [32];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *local_88;
  Shot *local_80;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *local_78;
  longlong local_70 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_50 [16];
  longlong local_40;
  ulonglong local_30;
  
                    /* 0xe0600  923
                       ?saveShot@Interface@GolfIn@@QEAAXV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VShot@2@V?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@4@@Z
                        */
  local_30 = DAT_1801d1040 ^ (ulonglong)auStackY_1a8;
  local_130[0] = 0;
  local_130[1] = 0;
  local_130[2] = 0;
  local_130[3] = 0;
  local_88 = param_2;
  local_80 = param_3;
  local_78 = param_4;
  FUN_18000c1d0(local_130,&DAT_18016a0f8,0);
  local_70[0] = 0;
  local_70[1] = 0;
  local_70[2] = 0;
  local_70[3] = 0;
  FUN_18000c1d0(local_70,"Results",7);
  plVar2 = (longlong *)getProcessImagesPath(this,local_e8);
  pbVar4 = param_2;
  if (0xf < *(ulonglong *)(param_2 + 0x18)) {
    pbVar4 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
              param_2;
  }
  plVar2 = FUN_18000a490(plVar2,pbVar4,*(size_t *)(param_2 + 0x10));
  local_150 = *plVar2;
  lStack_148 = plVar2[1];
  local_140 = plVar2[2];
  lStack_138 = plVar2[3];
  plVar2[2] = 0;
  plVar2[3] = 0xf;
  *(undefined1 *)plVar2 = 0;
  pbVar4 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)local_130
  ;
  Libraries::Core::updatePath
            (local_50,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_150);
  FUN_18000c8d0(&local_150);
  FUN_18000c8d0((longlong *)local_e8);
  FUN_18000c8d0(local_70);
  FUN_18000c8d0(local_130);
  if (local_40 != 0) {
    local_168[0] = true;
    pbVar4 = param_2;
    Shot::save(param_3,local_50,param_2,local_168,param_4,
               (map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>_>_>
                *)(this + 0x2c8));
  }
  plVar2 = FUN_1800014c0();
  lVar1 = *(longlong *)(param_2 + 0x10);
  if (0x1a < 0x7fffffffffffffffU - lVar1) {
    pbVar3 = param_2;
    if (0xf < *(ulonglong *)(param_2 + 0x18)) {
      pbVar3 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                param_2;
    }
    FUN_18000bff0(&local_150,lVar1,pbVar4,"[Save.Shot] Save images >> ",0x1b,pbVar3,lVar1);
    FUN_180084c00(plVar2,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_150,1,'\x01');
    local_160[0] = *(int *)(this + 0x1d8);
    local_158[0] = 5;
    local_130[4] = 0;
    local_130[5] = 0;
    local_130[6] = 0;
    local_130[7] = 0;
    FUN_18000c1d0(local_130 + 4,&DAT_18016a0f8,0);
    local_70[0] = 0;
    local_70[1] = 0;
    local_70[2] = 0;
    local_70[3] = 0;
    FUN_18000c1d0(local_70,"Shots",5);
    plVar2 = (longlong *)getProcessImagesPath(this,local_a8);
    pbVar4 = param_2;
    if (0xf < *(ulonglong *)(param_2 + 0x18)) {
      pbVar4 = *(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> **)
                param_2;
    }
    plVar2 = FUN_18000a490(plVar2,pbVar4,*(size_t *)(param_2 + 0x10));
    local_150 = *plVar2;
    lStack_148 = plVar2[1];
    local_140 = plVar2[2];
    lStack_138 = plVar2[3];
    plVar2[2] = 0;
    plVar2[3] = 0xf;
    *(undefined1 *)plVar2 = 0;
    pbVar4 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             Libraries::Core::updatePath
                       (local_c8,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)&local_150);
    Libraries::CamerasCore::write(pbVar4,param_4,local_160,local_158);
    FUN_18000c8d0((longlong *)local_c8);
    FUN_18000c8d0(&local_150);
    FUN_18000c8d0((longlong *)local_a8);
    FUN_18000c8d0(local_70);
    FUN_18000c8d0(local_130 + 4);
    if (*(longlong **)(this + 0x730) != (longlong *)0x0) {
      (**(code **)(**(longlong **)(this + 0x730) + 0x48))();
    }
    FUN_18000c8d0((longlong *)local_50);
    FUN_18000c8d0((longlong *)param_2);
    *(undefined ***)param_3 = Shot::vftable;
    Club::~Club((Club *)(param_3 + 0x2a0));
    Ball::~Ball((Ball *)(param_3 + 8));
    FUN_180006c90(param_4,param_4,*(longlong **)(*(longlong *)param_4 + 8));
    free(*(void **)param_4);
    return;
  }
                    /* WARNING: Subroutine does not return */
  FUN_18000c940();
}

