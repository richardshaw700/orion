FUNCTION: GolfIn::Interface::exportPostShot
ENTRY: 1800e00d0
REASONS: name:exportPostShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl GolfIn::Interface::exportPostShot(class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> >,class GolfIn::Shot,class std::map<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> >,class
   Libraries::CamerasCore::Frame,struct std::less<class std::basic_string<char,struct
   std::char_traits<char>,class std::allocator<char> > >,class std::allocator<struct std::pair<class
   std::basic_string<char,struct std::char_traits<char>,class std::allocator<char> > const ,class
   Libraries::CamerasCore::Frame> > >) __ptr64 */

void __thiscall
GolfIn::Interface::exportPostShot
          (Interface *this,longlong *param_2,Shot *param_3,
          map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
          *param_4)

{
  int iVar1;
  int iVar2;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar3;
  ulonglong uVar4;
  int *piVar5;
  undefined8 *puVar6;
  undefined8 uVar7;
  LPCWSTR **pppWVar8;
  undefined8 ***pppuVar9;
  undefined8 **ppuVar10;
  bool bVar11;
  undefined1 auStackY_1b8 [32];
  LPCWSTR *local_170;
  undefined8 uStack_168;
  undefined8 local_160;
  ulonglong uStack_158;
  int local_150;
  Interface *local_148;
  undefined8 **local_138;
  undefined **ppuStack_130;
  undefined8 local_120 [3];
  undefined8 **local_108;
  undefined8 local_100;
  undefined8 **local_f8;
  undefined8 local_f0;
  Shot *local_d0;
  map<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>,class_Libraries::CamerasCore::Frame,struct_std::less<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_>,class_std::allocator<struct_std::pair<class_std::basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>_const_,class_Libraries::CamerasCore::Frame>_>_>
  *local_c8;
  longlong *local_c0;
  undefined8 **local_b8 [2];
  undefined8 local_a8;
  ulonglong local_a0;
  longlong local_98;
  undefined **ppuStack_90;
  undefined8 **local_88 [2];
  size_t local_78;
  ulonglong local_70;
  undefined8 *local_68;
  undefined **ppuStack_60;
  undefined8 local_58;
  undefined8 uStack_50;
  ulonglong local_40;
  
                    /* 0xe00d0  555
                       ?exportPostShot@Interface@GolfIn@@QEAAXV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VShot@2@V?$map@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@U?$less@V?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@2@V?$allocator@U?$pair@$$CBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@VFrame@CamerasCore@Libraries@@@std@@@2@@4@@Z
                        */
  local_40 = DAT_1801d1040 ^ (ulonglong)auStackY_1b8;
  local_68 = (undefined8 *)0x0;
  ppuStack_60 = (undefined **)0x0;
  local_58 = 0;
  uStack_50 = 0;
  local_148 = this;
  local_d0 = param_3;
  local_c8 = param_4;
  local_c0 = param_2;
  FUN_18000c1d0(&local_68,&DAT_18016a0f8,0);
  local_170 = (LPCWSTR *)0x0;
  uStack_168 = 0;
  local_160 = 0;
  uStack_158 = 0;
  FUN_18000c1d0(&local_170,"PostShot",8);
  pbVar3 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
           getProcessImagesPath
                     (this,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                            *)&local_f8);
  ppuVar10 = &local_68;
  Libraries::Core::updatePath
            ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             local_88,pbVar3);
  FUN_18000c8d0((longlong *)&local_f8);
  FUN_18000c8d0((longlong *)&local_170);
  FUN_18000c8d0((longlong *)&local_68);
  if (0x7fffffffffffffff - local_78 < 0xd) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  pppuVar9 = local_88;
  if (0xf < local_70) {
    pppuVar9 = (undefined8 ***)local_88[0];
  }
  FUN_18000bff0(local_b8,pbVar3,ppuVar10,pppuVar9,local_78,"post-shot.avi",0xd);
  bVar11 = true;
  iVar1 = 10;
  while( true ) {
    uVar7 = local_a8;
    local_150 = iVar1;
    if ((!bVar11) && (0 < iVar1)) {
      pppuVar9 = local_88;
      if (0xf < local_70) {
        pppuVar9 = (undefined8 ***)local_88[0];
      }
      uVar4 = FUN_180130f54();
      ppuStack_130 = (undefined **)local_78;
      local_138 = pppuVar9;
      FUN_180025df0((LPWSTR)&local_170,(UINT)uVar4,&local_138);
      piVar5 = FUN_180024bf0((int *)local_120,(LPCWSTR)&local_170,3);
      local_148 = *(Interface **)piVar5;
      local_138 = (undefined8 **)CONCAT44(local_138._4_4_,piVar5[2]);
      ppuStack_130 = &PTR_vftable_1801d10b8;
      local_68 = local_138;
      ppuStack_60 = &PTR_vftable_1801d10b8;
      if ((int)local_148 == 0) {
        bVar11 = true;
        if (piVar5[2] != 0) {
                    /* WARNING: Subroutine does not return */
          FUN_180025990("exists",&local_68,&local_170);
        }
      }
      else {
        bVar11 = (int)local_148 == 1;
      }
      FUN_180025f40((longlong *)&local_170);
      if (bVar11) {
        Libraries::Core::createAllFolders
                  ((basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                   local_88);
      }
      local_170 = (LPCWSTR *)0x0;
      uStack_168 = 0;
      local_160 = 0;
      uStack_158 = 0;
      FUN_18000c1d0(&local_170,"Camera1",7);
      pbVar3 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
               FUN_1800f7eb0((longlong *)(this + 0x2c8),(longlong *)&local_170);
      iVar1 = Shot::exportPostShotVideoAndReturnImpactFrame
                        (param_3,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                  *)local_b8,param_4,pbVar3,true);
      FUN_18000c8d0((longlong *)&local_170);
      puVar6 = FUN_18000cb00(&local_170,local_c0);
      OnPostShotVideoAvailable(this,puVar6,iVar1);
      FUN_18000c8d0((longlong *)local_b8);
      FUN_18000c8d0((longlong *)local_88);
      FUN_18000c8d0(local_c0);
      *(undefined ***)param_3 = Shot::vftable;
      Club::~Club((Club *)(param_3 + 0x2a0));
      Ball::~Ball((Ball *)(param_3 + 8));
      FUN_180006c90(param_4,param_4,*(longlong **)(*(longlong *)param_4 + 8));
      free(*(void **)param_4);
      return;
    }
    pppuVar9 = local_b8;
    if (0xf < local_a0) {
      pppuVar9 = (undefined8 ***)local_b8[0];
    }
    uVar4 = FUN_180130f54();
    local_100 = uVar7;
    local_108 = pppuVar9;
    FUN_180025df0((LPWSTR)&local_170,(UINT)uVar4,&local_108);
    pppWVar8 = &local_170;
    if (7 < uStack_158) {
      pppWVar8 = (LPCWSTR **)local_170;
    }
    uVar7 = FUN_180131ad4((LPCWSTR)pppWVar8);
    iVar2 = (int)((ulonglong)uVar7 >> 0x20);
    if (iVar2 != 0) break;
    FUN_180025f40((longlong *)&local_170);
    uVar7 = local_a8;
    pppuVar9 = local_b8;
    if (0xf < local_a0) {
      pppuVar9 = (undefined8 ***)local_b8[0];
    }
    uVar4 = FUN_180130f54();
    local_f0 = uVar7;
    local_f8 = pppuVar9;
    FUN_180025df0((LPWSTR)&local_170,(UINT)uVar4,&local_f8);
    piVar5 = FUN_180024bf0((int *)&local_138,(LPCWSTR)&local_170,3);
    local_120[0] = *(undefined8 *)piVar5;
    local_68 = (undefined8 *)CONCAT44(local_68._4_4_,piVar5[2]);
    ppuStack_60 = &PTR_vftable_1801d10b8;
    local_98 = (longlong)local_68;
    ppuStack_90 = &PTR_vftable_1801d10b8;
    if ((int)local_120[0] == 0) {
      bVar11 = false;
      if (piVar5[2] != 0) {
                    /* WARNING: Subroutine does not return */
        FUN_180025990("exists",&local_98,&local_170);
      }
    }
    else {
      bVar11 = (int)local_120[0] != 1;
    }
    FUN_180025f40((longlong *)&local_170);
    iVar1 = iVar1 + -1;
  }
                    /* WARNING: Subroutine does not return */
  FUN_180069bc0("remove",iVar2,&local_170);
}

