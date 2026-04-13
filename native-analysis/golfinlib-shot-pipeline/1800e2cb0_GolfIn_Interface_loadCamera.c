FUNCTION: GolfIn::Interface::loadCamera
ENTRY: 1800e2cb0
REASONS: name:loadCamera; string:loadCamera


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Removing unreachable block (ram,0x0001800e2e3e) */
/* protected: enum Libraries::CamerasCore::Error __cdecl GolfIn::Interface::loadCamera(class
   std::unique_ptr<class std::vector<class Hikrobot::CameraPtr,class std::allocator<class
   Hikrobot::CameraPtr> >,struct std::default_delete<class std::vector<class
   Hikrobot::CameraPtr,class std::allocator<class Hikrobot::CameraPtr> > > >) __ptr64 */

Error __thiscall GolfIn::Interface::loadCamera(Interface *this,undefined8 *param_2)

{
  longlong *plVar1;
  int *piVar2;
  undefined8 **ppuVar3;
  undefined4 uVar4;
  code *pcVar5;
  longlong lVar6;
  int iVar7;
  Error EVar8;
  longlong *plVar9;
  CamerasManager *pCVar10;
  undefined8 *puVar11;
  undefined1 auStack_128 [32];
  undefined8 **local_108;
  CamerasManager *local_f8;
  undefined8 *local_f0;
  undefined8 *puStack_e8;
  undefined8 local_e0;
  longlong local_d8 [8];
  undefined8 *local_98;
  undefined8 **local_90;
  undefined8 uStack_88;
  undefined8 *local_80;
  undefined8 *puStack_78;
  undefined8 **local_70;
  undefined8 local_68;
  longlong local_60 [4];
  ulonglong local_40;
  
                    /* 0xe2cb0  773
                       ?loadCamera@Interface@GolfIn@@IEAA?AW4Error@CamerasCore@Libraries@@V?$unique_ptr@V?$vector@VCameraPtr@Hikrobot@@V?$allocator@VCameraPtr@Hikrobot@@@std@@@std@@U?$default_delete@V?$vector@VCameraPtr@Hikrobot@@V?$allocator@VCameraPtr@Hikrobot@@@std@@@std@@@2@@std@@@Z
                        */
  local_40 = DAT_1801d1040 ^ (ulonglong)auStack_128;
  local_98 = param_2;
  if (*(longlong *)(this + 0x298) == 0) {
    plVar9 = FUN_1800014c0();
    local_80 = (undefined8 *)0x0;
    puStack_78 = (undefined8 *)0x0;
    local_70 = (undefined8 **)0x0;
    local_68 = 0;
    FUN_18000c1d0(&local_80,"loadCamera: instantiating CamerasManager()...",0x2d);
    FUN_180084c00(plVar9,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_80,0,'\x01');
    pCVar10 = (CamerasManager *)FUN_1801327e0(0xf8);
    local_f8 = pCVar10;
    memset(pCVar10,0,0xf8);
    uVar4 = *(undefined4 *)(this + 0x700);
    local_90 = (undefined8 **)*param_2;
    *param_2 = 0;
    pCVar10 = (CamerasManager *)Libraries::CamerasManager::CamerasManager(pCVar10,&local_90,uVar4);
    local_f0 = (undefined8 *)0x0;
    puStack_e8 = (undefined8 *)0x0;
    if (pCVar10 == (CamerasManager *)0x0) {
      puVar11 = (undefined8 *)0x0;
      pCVar10 = (CamerasManager *)0x0;
    }
    else {
      local_f8 = pCVar10;
      puVar11 = (undefined8 *)FUN_1801327e0(0x18);
      *puVar11 = 0;
      puVar11[1] = 0;
      *(undefined4 *)(puVar11 + 1) = 1;
      *(undefined4 *)((longlong)puVar11 + 0xc) = 1;
      *puVar11 = std::
                 _Ref_count_resource<class_Libraries::CamerasManager*___ptr64,struct_std::default_delete<class_Libraries::CamerasManager>_>
                 ::vftable;
      puVar11[2] = pCVar10;
    }
    local_f8 = (CamerasManager *)0x0;
    *(CamerasManager **)(this + 0x298) = pCVar10;
    plVar9 = *(longlong **)(this + 0x2a0);
    *(undefined8 **)(this + 0x2a0) = puVar11;
    if (plVar9 != (longlong *)0x0) {
      LOCK();
      plVar1 = plVar9 + 1;
      lVar6 = *plVar1;
      *(int *)plVar1 = (int)*plVar1 + -1;
      UNLOCK();
      if ((int)lVar6 == 1) {
        (**(code **)*plVar9)(plVar9);
        LOCK();
        piVar2 = (int *)((longlong)plVar9 + 0xc);
        iVar7 = *piVar2;
        *piVar2 = *piVar2 + -1;
        UNLOCK();
        if (iVar7 == 1) {
          (**(code **)(*plVar9 + 8))(plVar9);
        }
      }
    }
    local_d8[0] = 0;
    local_d8[1] = 0;
    local_d8[2] = 0;
    local_d8[3] = 0;
    FUN_18000c1d0(local_d8,"Camera1",7);
    plVar9 = FUN_1800f7eb0((longlong *)(this + 0x2c8),local_d8);
    FUN_18000cb00(local_60,plVar9);
    FUN_18000c8d0(local_d8);
    plVar9 = *(longlong **)(this + 0x298);
    local_d8[4] = 0;
    local_d8[5] = 0;
    local_d8[6] = 0;
    local_d8[7] = 0;
    FUN_18000c1d0(local_d8 + 4,&DAT_180175a18,1);
    local_f0 = (undefined8 *)0x0;
    puStack_e8 = (undefined8 *)0x0;
    local_e0 = 0;
    FUN_18000bc20((ulonglong *)&local_f0,1);
    puVar11 = local_f0;
    local_90 = &local_f0;
    local_80 = local_f0;
    puStack_78 = local_f0;
    local_70 = &local_f0;
    FUN_18000cb00(local_f0,local_d8 + 4);
    puStack_e8 = puVar11 + 4;
    local_f8 = (CamerasManager *)CONCAT44(local_f8._4_4_,2);
    ppuVar3 = (undefined8 **)(plVar9 + 2);
    uStack_88 = 0;
    local_90 = ppuVar3;
    iVar7 = _Mtx_lock(ppuVar3);
    if (iVar7 != 0) {
      std::_Throw_Cpp_error(5);
      pcVar5 = (code *)swi(3);
      EVar8 = (*pcVar5)();
      return EVar8;
    }
    if (*(int *)((longlong)plVar9 + 0x5c) == 0x7fffffff) {
      *(undefined4 *)((longlong)plVar9 + 0x5c) = 0x7ffffffe;
      std::_Throw_Cpp_error(6);
      pcVar5 = (code *)swi(3);
      EVar8 = (*pcVar5)();
      return EVar8;
    }
    uStack_88 = CONCAT71(uStack_88._1_7_,1);
    if ((char)plVar9[1] != '\0') {
      local_80 = (undefined8 *)0x0;
      puStack_78 = (undefined8 *)0x0;
      local_70 = (undefined8 **)0x0;
      local_108 = &local_80;
      (**(code **)(*plVar9 + 0x18))(plVar9,local_60,&local_f8,&local_f0);
      FUN_18000bd00((longlong *)&local_80);
    }
    _Mtx_unlock(ppuVar3);
    FUN_18000bd00((longlong *)&local_f0);
    _eh_vector_destructor_iterator_(local_d8 + 4,0x20,1,thunk_FUN_18000c8d0);
    FUN_18000c8d0(local_60);
  }
  EVar8 = commonLoadCamera(this);
  plVar9 = (longlong *)*param_2;
  if (plVar9 != (longlong *)0x0) {
    FUN_18000ded0(plVar9);
    free(plVar9);
  }
  return EVar8;
}

