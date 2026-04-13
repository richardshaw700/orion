FUNCTION: GolfIn::Detection::ClubDetection::baseConstructor
ENTRY: 180086110
REASONS: name:club; string:saveShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* public: void __cdecl GolfIn::Detection::ClubDetection::baseConstructor(struct
   GolfIn::Detection::ClubDetectionInput const & __ptr64,bool) __ptr64 */

void __thiscall
GolfIn::Detection::ClubDetection::baseConstructor
          (ClubDetection *this,ClubDetectionInput *param_1,bool param_2)

{
  Parameters *this_00;
  ClubDetection CVar1;
  code *pcVar2;
  longlong lVar3;
  bool bVar4;
  int iVar5;
  Parameter *pPVar6;
  ClubDetection *pCVar7;
  ClubDetection *pCVar8;
  undefined1 auStack_f8 [32];
  undefined4 local_d8;
  longlong local_d0 [4];
  longlong local_b0 [4];
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> local_90 [32];
  DataFormat local_70;
  undefined4 uStack_6c;
  longlong local_68 [6];
  
                    /* 0x86110  414
                       ?baseConstructor@ClubDetection@Detection@GolfIn@@QEAAXAEBUClubDetectionInput@23@_N@Z
                        */
  local_68[4] = DAT_1801d1040 ^ (ulonglong)auStack_f8;
  local_d8 = 0;
  if ((*(longlong *)(*(longlong *)(this + 0xb8) + 0x10) == 0) || (*(longlong *)(this + 0xe8) == 0))
  {
    FUN_180009760(local_d0,"Parameters are empty.");
                    /* WARNING: Subroutine does not return */
    _CxxThrowException(local_d0,(ThrowInfo *)&DAT_1801a9018);
  }
  FUN_1800633a0((longlong *)&local_70);
  FUN_180067730((undefined8 *)local_90,CONCAT44(uStack_6c,local_70));
  local_d8 = 3;
  local_b0[0] = 0;
  local_b0[1] = 0;
  local_b0[2] = 0;
  local_b0[3] = 0;
  FUN_18000c1d0(local_b0,"Configurations.Debug.AutoSaveShotUntilTimestamp",0x2f);
  this_00 = *(Parameters **)(this + 0xb8);
  bVar4 = Libraries::Core::Parameters::exist
                    (this_00,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                              *)local_b0);
  if (!bVar4) {
    pPVar6 = Libraries::Core::Parameters::get
                       (this_00,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                                 *)local_b0);
    Libraries::Core::Parameter::setValue(pPVar6,local_90);
  }
  local_68[1] = 0;
  local_68[2] = 0;
  local_68[3] = 0xf;
  local_68[0] = 0;
  local_d8 = 7;
  pPVar6 = Libraries::Core::Parameters::get
                     (*(Parameters **)(this + 0xb8),
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)local_b0);
  iVar5 = _Mtx_lock(pPVar6 + 0x48);
  if (iVar5 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar2 = (code *)swi(3);
    (*pcVar2)();
    return;
  }
  if (*(int *)(pPVar6 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar6 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar2 = (code *)swi(3);
    (*pcVar2)();
    return;
  }
  FUN_18000cb00(local_d0,(undefined8 *)(pPVar6 + 0x28));
  local_d8 = 0xf;
  _Mtx_unlock(pPVar6 + 0x48);
  FUN_180009d70(local_68,local_d0);
  FUN_18000c8d0(local_d0);
  if (!bVar4) {
    local_70 = 1;
    Libraries::Core::Parameters::saveToFile
              (*(Parameters **)(this + 0xb8),
               (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
               (this + 0xd8),&local_70);
  }
  FUN_18000c8d0(local_b0);
  local_d8 = 0xe;
  FUN_18000c8d0((longlong *)local_90);
  if (local_68[2] == 0) {
    this[0xd0] = (ClubDetection)0x0;
  }
  else {
    FUN_180065d70((longlong *)&local_70,local_68);
    lVar3 = CONCAT44(uStack_6c,local_70);
    if (lVar3 == 0x7ffffffffffffffe) {
      this[0xd0] = (ClubDetection)0x0;
    }
    else {
      FUN_1800633a0((longlong *)&local_70);
      CVar1 = (ClubDetection)(CONCAT44(uStack_6c,local_70) <= lVar3);
      this[0xd0] = CVar1;
      if ((bool)CVar1) {
        if (*(longlong *)(this + 0xa8) == 0) {
          FUN_180009760(local_d0,"Save folder path is empty.");
                    /* WARNING: Subroutine does not return */
          _CxxThrowException(local_d0,(ThrowInfo *)&DAT_1801a9018);
        }
        pCVar8 = this + 0x98;
        local_d0[1] = 0;
        local_d0[3] = 7;
        if (*(ulonglong *)(this + 0xb0) < 0x10) {
          pCVar7 = pCVar8 + *(longlong *)(this + 0xa8);
        }
        else {
          pCVar7 = (ClubDetection *)(*(longlong *)pCVar8 + *(longlong *)(this + 0xa8));
          pCVar8 = *(ClubDetection **)pCVar8;
        }
        local_d0[2] = 0;
        local_d0[0] = 0;
        boost::filesystem::detail::path_traits::convert
                  ((char *)pCVar8,(char *)pCVar7,
                   (basic_string<wchar_t,struct_std::char_traits<wchar_t>,class_std::allocator<wchar_t>_>
                    *)local_d0,(codecvt<wchar_t,char,struct__Mbstatet> *)0x0);
        boost::filesystem::detail::create_directories((path *)local_d0,(error_code *)0x0);
        FUN_180025f40(local_d0);
      }
    }
  }
  bVar4 = ClubDetectionInput::validateInput(param_1);
  if (bVar4) {
    ClubDetectionInput::operator=((ClubDetectionInput *)(this + 0xf8),param_1);
    if (param_2) {
      (**(code **)(*(longlong *)this + 0x10))(this,param_1);
    }
    FUN_18000c8d0(local_68);
    return;
  }
  FUN_180009760(local_d0,"Invalid input.");
                    /* WARNING: Subroutine does not return */
  _CxxThrowException(local_d0,(ThrowInfo *)&DAT_1801a9018);
}

