FUNCTION: GolfIn::Detection::ClubDetection::ClubTypeToString
ENTRY: 180086580
REASONS: name:club


/* public: static class std::basic_string<char,struct std::char_traits<char>,class
   std::allocator<char> > __cdecl GolfIn::Detection::ClubDetection::ClubTypeToString(enum
   GolfIn::Detection::ClubType) */

undefined8 * __cdecl GolfIn::Detection::ClubDetection::ClubTypeToString(ClubType param_1)

{
  undefined4 in_register_0000000c;
  undefined8 *puVar1;
  undefined4 in_EDX;
  
                    /* 0x86580  261
                       ?ClubTypeToString@ClubDetection@Detection@GolfIn@@SA?AV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@W4ClubType@23@@Z
                        */
  puVar1 = (undefined8 *)CONCAT44(in_register_0000000c,param_1);
  switch(in_EDX) {
  case 0:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"IRON UNKNOWN",0xc);
    return puVar1;
  case 1:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"WEDGE",5);
    return puVar1;
  case 2:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"WOOD UNKNOWN",0xc);
    return puVar1;
  case 3:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"SMALL FAIRWAY WOOD",0x12);
    return puVar1;
  case 4:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"BIG FAIRWAY WOOD",0x10);
    return puVar1;
  case 5:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"DRIVER",6);
    return puVar1;
  case 6:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"PUTTER",6);
    return puVar1;
  default:
    *puVar1 = 0;
    puVar1[1] = 0;
    puVar1[2] = 0;
    puVar1[3] = 0;
    FUN_18000c1d0(puVar1,"[Unknown Club]",0xe);
    return puVar1;
  }
}

