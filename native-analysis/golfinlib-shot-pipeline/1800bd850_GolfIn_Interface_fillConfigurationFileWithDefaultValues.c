FUNCTION: GolfIn::Interface::fillConfigurationFileWithDefaultValues
ENTRY: 1800bd850
REASONS: string:Club.Detection; string:exportPostShot; string:saveShot


/* WARNING: Function: __security_check_cookie replaced with injection: security_check_cookie */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* public: void __cdecl GolfIn::Interface::fillConfigurationFileWithDefaultValues(void) __ptr64 */

void __thiscall GolfIn::Interface::fillConfigurationFileWithDefaultValues(Interface *this)

{
  code *pcVar1;
  bool bVar2;
  int iVar3;
  Parameter *pPVar4;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar5;
  longlong *plVar6;
  undefined8 *******pppppppuVar7;
  undefined8 *******pppppppuVar8;
  longlong lVar9;
  longlong lVar10;
  char *pcVar11;
  undefined8 ******ppppppuVar12;
  undefined8 ******ppppppuVar13;
  basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *pbVar14;
  undefined8 uVar15;
  longlong lVar16;
  undefined1 auStackY_2f8 [32];
  bool local_2b8 [8];
  longlong local_2b0;
  longlong lStack_2a8;
  longlong local_2a0;
  longlong lStack_298;
  float local_290;
  undefined4 uStack_28c;
  undefined4 local_288;
  longlong local_280;
  longlong lStack_278;
  longlong local_270;
  longlong lStack_268;
  longlong local_260 [4];
  longlong local_240;
  longlong lStack_238;
  longlong local_230;
  longlong lStack_228;
  longlong local_220 [4];
  longlong local_200;
  longlong lStack_1f8;
  longlong local_1f0;
  longlong lStack_1e8;
  longlong local_1e0;
  longlong lStack_1d8;
  longlong local_1d0;
  longlong lStack_1c8;
  longlong local_1c0;
  longlong lStack_1b8;
  longlong local_1b0;
  longlong lStack_1a8;
  longlong local_1a0 [4];
  longlong local_180 [4];
  longlong local_160 [4];
  longlong local_140 [4];
  longlong local_120 [4];
  longlong local_100 [4];
  longlong local_e0 [5];
  undefined8 ******local_b8;
  undefined8 uStack_b0;
  size_t local_a8;
  ulonglong uStack_a0;
  undefined8 ******local_98;
  undefined8 uStack_90;
  size_t local_88;
  ulonglong uStack_80;
  undefined8 *****local_78;
  undefined8 uStack_70;
  undefined8 local_68;
  undefined8 uStack_60;
  undefined8 local_58;
  undefined8 uStack_50;
  undefined8 local_48;
  undefined8 uStack_40;
  undefined8 ****local_38 [2];
  
                    /* 0xbd850  582
                       ?fillConfigurationFileWithDefaultValues@Interface@GolfIn@@QEAAXXZ */
  local_38[0] = (undefined8 ****)(DAT_1801d1040 ^ (ulonglong)auStackY_2f8);
  lVar16 = 0;
  local_288 = 0;
  local_240 = 0;
  lStack_238 = 0;
  local_230 = 0;
  lStack_228 = 0;
  FUN_18000c1d0(&local_240,&DAT_18016a0f8,0);
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.AutoGain.LastAutoGainTime",0x34);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (!bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue
              (pPVar4,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_240);
  }
  lStack_278 = 0;
  local_270 = _DAT_18017ef00;
  lStack_268 = _UNK_18017ef08;
  local_280 = 0;
  local_288 = 0x1000000;
  pPVar4 = Libraries::Core::Parameters::get
                     ((Parameters *)(this + 0x10),
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_2b0);
  iVar3 = _Mtx_lock(pPVar4 + 0x48);
  if (iVar3 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  if (*(int *)(pPVar4 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar4 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  FUN_18000cb00(local_260,(undefined8 *)(pPVar4 + 0x28));
  local_288 = 0x3000000;
  _Mtx_unlock(pPVar4 + 0x48);
  FUN_180009d70(&local_280,local_260);
  FUN_18000c8d0(local_260);
  if (!bVar2) {
    saveParameters(this);
  }
  local_288 = 0x2000000;
  FUN_18000c8d0(&local_280);
  FUN_18000c8d0(&local_2b0);
  FUN_18000c8d0(&local_240);
  local_290 = 1.54143e-44;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.AutoGain.MinGain",0x2b);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 2.8026e-44;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.AutoGain.MaxGain",0x2b);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.AutoGain.UseNewAutogainAlgo",0x36);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = true;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.UseCameras",0x1f);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.UseIdra25",0x1e);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  FUN_1800633a0((longlong *)&local_290);
  FUN_180067730(&local_240,CONCAT44(uStack_28c,local_290));
  local_288 = 0xe000000;
  local_280 = 0;
  lStack_278 = 0;
  local_270 = 0;
  lStack_268 = 0;
  FUN_18000c1d0(&local_280,"Configurations.Debug.AutoSaveShotUntilTimestamp",0x2f);
  FUN_1800f9c20(this,local_220,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_280,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_240);
  FUN_18000c8d0(local_220);
  FUN_18000c8d0(&local_280);
  local_288 = 0xa000000;
  FUN_18000c8d0(&local_240);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.AutoSaveBall",0x21);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 1.4013e-45;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.DebugLevel",0x1f);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_240 = 0;
  lStack_238 = 0;
  local_230 = 0;
  lStack_228 = 0;
  FUN_18000c1d0(&local_240,&DAT_18016a0f8,0);
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.ShotName",0x1d);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (!bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue
              (pPVar4,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_240);
  }
  lStack_278 = 0;
  local_270 = _DAT_18017ef00;
  lStack_268 = _UNK_18017ef08;
  local_280 = 0;
  local_288 = 0x1a000000;
  pPVar4 = Libraries::Core::Parameters::get
                     ((Parameters *)(this + 0x10),
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_2b0);
  iVar3 = _Mtx_lock(pPVar4 + 0x48);
  if (iVar3 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  if (*(int *)(pPVar4 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar4 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  FUN_18000cb00(local_260,(undefined8 *)(pPVar4 + 0x28));
  local_288 = 0x3a000000;
  _Mtx_unlock(pPVar4 + 0x48);
  FUN_180009d70(&local_280,local_260);
  FUN_18000c8d0(local_260);
  if (!bVar2) {
    saveParameters(this);
  }
  local_288 = 0x2a000000;
  FUN_18000c8d0(&local_280);
  FUN_18000c8d0(&local_2b0);
  FUN_18000c8d0(&local_240);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.LogLoadedDependencies",0x2a);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.ExtractGraph",0x21);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.DisableTurnOnLightWarning",0x30);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = true;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.ShowInterface",0x24);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.EraseDetectedMissingFrame",0x30);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 8.5;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.Club.Detection.MaxTrackingDistanceFromBallFactor"
                ,0x47);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = true;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Debug.ExportPostShotVideo",0x28);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Cameras.ReverseMasterSlave",0x29);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 2.52234e-44;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Cameras.OnLoadGain",0x21);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 3.0;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardCameras.gain",0x2c);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 600.0;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardCameras.exposure",0x30);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 1.4013e-43;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardFilter",0x26);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 0.075;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardSpaceX",0x26);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 0.075;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardSpaceY",0x26);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_240 = 0;
  lStack_238 = 0;
  local_230 = 0;
  lStack_228 = 0;
  FUN_18000c1d0(&local_240,"Circle",6);
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardType",0x24);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (!bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue
              (pPVar4,(basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_240);
  }
  lStack_278 = 0;
  local_270 = _DAT_18017ef00;
  lStack_268 = _UNK_18017ef08;
  local_280 = 0;
  local_288 = 0x2a400000;
  pPVar4 = Libraries::Core::Parameters::get
                     ((Parameters *)(this + 0x10),
                      (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                       *)&local_2b0);
  iVar3 = _Mtx_lock(pPVar4 + 0x48);
  if (iVar3 != 0) {
    std::_Throw_Cpp_error(5);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  if (*(int *)(pPVar4 + 0x94) == 0x7fffffff) {
    *(undefined4 *)(pPVar4 + 0x94) = 0x7ffffffe;
    std::_Throw_Cpp_error(6);
    pcVar1 = (code *)swi(3);
    (*pcVar1)();
    return;
  }
  FUN_18000cb00(local_260,(undefined8 *)(pPVar4 + 0x28));
  local_288 = 0x2ac00000;
  _Mtx_unlock(pPVar4 + 0x48);
  FUN_180009d70(&local_280,local_260);
  FUN_18000c8d0(local_260);
  if (!bVar2) {
    saveParameters(this);
  }
  FUN_18000c8d0(&local_280);
  FUN_18000c8d0(&local_2b0);
  FUN_18000c8d0(&local_240);
  local_290 = 1.54143e-44;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardX",0x21);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 9.80909e-45;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Calibration.BoardY",0x21);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  bVar2 = useDynamicConfig(this);
  if (bVar2) {
    local_290 = 1.21913e-42;
    local_2b0 = 0;
    lStack_2a8 = 0;
    local_2a0 = 0;
    lStack_298 = 0;
    FUN_18000c1d0(&local_2b0,"Configurations.Process.HittingZone.WidthMm",0x2a);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_2b0);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_2b0);
    local_290 = 6.40393e-43;
    local_2b0 = 0;
    lStack_2a8 = 0;
    local_2a0 = 0;
    lStack_298 = 0;
    FUN_18000c1d0(&local_2b0,"Configurations.Process.HittingZone.HeightMm",0x2b);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_2b0);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_2b0);
    local_290 = 6.474e-43;
    local_2b0 = 0;
    lStack_2a8 = 0;
    local_2a0 = 0;
    lStack_298 = 0;
    FUN_18000c1d0(&local_2b0,"Configurations.Process.HittingZone.CaptureZoneWidthMm",0x35);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_2b0);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_2b0);
    local_290 = 0.0;
    local_2b0 = 0;
    lStack_2a8 = 0;
    local_2a0 = 0;
    lStack_298 = 0;
    FUN_18000c1d0(&local_2b0,"Configurations.Process.HittingZone.HeightVerticalOffsetMm",0x39);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_2b0);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_2b0);
  }
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,
                "Configurations.Process.Ball.ModelSegmentation.Ball.EvaluateWhiteness.Evaluate",0x4d
               );
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 1.82169e-43;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,
                "Configurations.Process.Ball.ModelSegmentation.Ball.EvaluateWhiteness.WhiteThreshold"
                ,0x53);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 0.0;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.Club.DetectionMethodIndex",0x30);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = true;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.UseMLForClub",0x23);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 4.2039e-44;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.Club.Detection.REMBGMinMaskConsideredValue",0x41)
  ;
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_290 = 0.5;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.Club.Detection.REMBGStddevVariationFactor",0x40);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toFloat(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.Club.Use3DClubSpeed",0x2a);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_2b8[0] = false;
  local_2b0 = 0;
  lStack_2a8 = 0;
  local_2a0 = 0;
  lStack_298 = 0;
  FUN_18000c1d0(&local_2b0,"Configurations.Process.UseMLForBackSpinAndSideSpin",0x32);
  bVar2 = Libraries::Core::Parameters::exist
                    ((Parameters *)(this + 0x10),
                     (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *
                     )&local_2b0);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
    pPVar4 = Libraries::Core::Parameters::get
                       ((Parameters *)(this + 0x10),
                        (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                         *)&local_2b0);
    Libraries::Core::Parameter::toBoolean(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(&local_2b0);
  local_b8 = (undefined8 *******)0x0;
  uStack_b0 = 0;
  local_a8 = 0;
  uStack_a0 = 0;
  FUN_18000c1d0(&local_b8,"Camera1",7);
  local_98 = (undefined8 *******)0x0;
  uStack_90 = 0;
  local_88 = 0;
  uStack_80 = 0;
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x7;
  FUN_18000c1d0(&local_98,"Camera2",7);
  pppppppuVar8 = &local_b8;
  do {
    local_290 = 301.0;
    pbVar5 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             FUN_180116360(local_220,pppppppuVar8,pbVar14);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar5);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x3;
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_290 = -2.0;
    pbVar5 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             FUN_180116240(local_220,pppppppuVar8,pbVar14);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar5);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x3;
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_290 = 18.0;
    pbVar5 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
             FUN_180116120(local_220,pppppppuVar8,pbVar14);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar5);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)0x3;
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar5);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_290 = 0.0;
    if (0x7fffffffffffffffU - (longlong)pppppppuVar8[2] < 0x17) {
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    pppppppuVar7 = pppppppuVar8;
    if ((undefined8 ******)0xf < pppppppuVar8[3]) {
      pppppppuVar7 = (undefined8 *******)*pppppppuVar8;
    }
    FUN_18000bff0(local_140,pbVar5,pbVar14,"Configurations.Cameras.",0x17,pppppppuVar7,
                  (size_t)pppppppuVar8[2]);
    uVar15 = 0x18;
    plVar6 = FUN_18000a490(local_140,".Data.last_autogain_read",0x18);
    local_200 = *plVar6;
    lStack_1f8 = plVar6[1];
    local_1f0 = plVar6[2];
    lStack_1e8 = plVar6[3];
    plVar6[2] = 0;
    plVar6[3] = 0xf;
    *(undefined1 *)plVar6 = 0;
    FUN_18000c8d0(local_140);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_200);
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_200;
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      uVar15 = 3;
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_200;
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_200);
    local_2b8[0] = true;
    if (0x7fffffffffffffffU - (longlong)pppppppuVar8[2] < 0x17) {
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    pppppppuVar7 = pppppppuVar8;
    if ((undefined8 ******)0xf < pppppppuVar8[3]) {
      pppppppuVar7 = (undefined8 *******)*pppppppuVar8;
    }
    FUN_18000bff0(local_120,pbVar14,uVar15,"Configurations.Cameras.",0x17,pppppppuVar7,
                  (size_t)pppppppuVar8[2]);
    plVar6 = FUN_18000a490(local_120,".Data.",6);
    local_1e0 = *plVar6;
    lStack_1d8 = plVar6[1];
    local_1d0 = plVar6[2];
    lStack_1c8 = plVar6[3];
    plVar6[3] = 0xf;
    plVar6[2] = 0;
    *(undefined1 *)plVar6 = 0;
    uVar15 = 0x12;
    plVar6 = FUN_18000a490(&local_1e0,"balance_white_auto",0x12);
    local_2b0 = *plVar6;
    lStack_2a8 = plVar6[1];
    local_2a0 = plVar6[2];
    lStack_298 = plVar6[3];
    plVar6[2] = 0;
    plVar6[3] = 0xf;
    *(undefined1 *)plVar6 = 0;
    FUN_18000c8d0(&local_1e0);
    FUN_18000c8d0(local_120);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_2b0);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toBoolean(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::setValue(pPVar4,local_2b8);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_2b0);
      Libraries::Core::Parameter::toBoolean(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_2b0);
    local_290 = 0.0;
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              FUN_180116000(local_220,pppppppuVar8,uVar15);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar14);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_290 = 0.0;
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              FUN_180115ee0(local_220,pppppppuVar8,uVar15);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar14);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_290 = 0.0;
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              FUN_180115dc0(local_220,pppppppuVar8,uVar15);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar14);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_290 = 7.00649e-43;
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              FUN_180115ca0(local_220,pppppppuVar8,uVar15);
    bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar14);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
      pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
      Libraries::Core::Parameter::toInt(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(local_220);
    local_260[0] = 0;
    local_260[1] = 0;
    local_260[2] = 0;
    local_260[3] = 0;
    uVar15 = 0x16;
    pcVar11 = "HIKROBOT_MV_CA004_10UC";
    FUN_18000c1d0(local_260,"HIKROBOT_MV_CA004_10UC",0x16);
    if (0x7fffffffffffffffU - (longlong)pppppppuVar8[2] < 0x17) {
                    /* WARNING: Subroutine does not return */
      FUN_18000c940();
    }
    pppppppuVar7 = pppppppuVar8;
    if ((undefined8 ******)0xf < pppppppuVar8[3]) {
      pppppppuVar7 = (undefined8 *******)*pppppppuVar8;
    }
    FUN_18000bff0(local_100,pcVar11,uVar15,"Configurations.Cameras.",0x17,pppppppuVar7,
                  (size_t)pppppppuVar8[2]);
    plVar6 = FUN_18000a490(local_100,".Data.model",0xb);
    local_1c0 = *plVar6;
    lStack_1b8 = plVar6[1];
    local_1b0 = plVar6[2];
    lStack_1a8 = plVar6[3];
    plVar6[2] = 0;
    plVar6[3] = 0xf;
    *(undefined1 *)plVar6 = 0;
    FUN_18000c8d0(local_100);
    pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
              &local_1c0;
    FUN_1800f9c20(this,local_1a0,pbVar14,
                  (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                  local_260);
    FUN_18000c8d0(local_1a0);
    FUN_18000c8d0(&local_1c0);
    FUN_18000c8d0(local_260);
    pppppppuVar8 = pppppppuVar8 + 4;
  } while (pppppppuVar8 != (undefined8 *******)&local_78);
  local_280 = 0;
  lStack_278 = 0;
  local_270 = 0;
  lStack_268 = 0;
  uVar15 = 6;
  FUN_18000c1d0(&local_280,"MASTER",6);
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            FUN_180115b80(local_220,&local_b8,uVar15);
  FUN_1800f9c20(this,local_1a0,pbVar14,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_280);
  FUN_18000c8d0(local_1a0);
  FUN_18000c8d0(local_220);
  FUN_18000c8d0(&local_280);
  local_260[0] = 0;
  local_260[1] = 0;
  local_260[2] = 0;
  local_260[3] = 0;
  uVar15 = 9;
  pcVar11 = "MASTER_ID";
  FUN_18000c1d0(local_260,"MASTER_ID",9);
  if (0x7fffffffffffffff - local_a8 < 0x17) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  pppppppuVar8 = &local_b8;
  if (0xf < uStack_a0) {
    pppppppuVar8 = (undefined8 *******)local_b8;
  }
  FUN_18000bff0(local_e0,pcVar11,uVar15,"Configurations.Cameras.",0x17,pppppppuVar8,local_a8);
  plVar6 = FUN_18000a490(local_e0,&DAT_18017c428,3);
  local_240 = *plVar6;
  lStack_238 = plVar6[1];
  local_230 = plVar6[2];
  lStack_228 = plVar6[3];
  plVar6[2] = 0;
  plVar6[3] = 0xf;
  *(undefined1 *)plVar6 = 0;
  FUN_18000c8d0(local_e0);
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            &local_240;
  FUN_1800f9c20(this,local_180,pbVar14,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                local_260);
  FUN_18000c8d0(local_180);
  FUN_18000c8d0(&local_240);
  FUN_18000c8d0(local_260);
  local_290 = 1.26117e-43;
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            FUN_180115a60(local_180,&local_b8,pbVar14);
  bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar14);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(local_180);
  local_280 = 0;
  lStack_278 = 0;
  local_270 = 0;
  lStack_268 = 0;
  uVar15 = 5;
  FUN_18000c1d0(&local_280,"SLAVE",5);
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            FUN_180115b80(local_1a0,&local_98,uVar15);
  FUN_1800f9c20(this,local_180,pbVar14,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                &local_280);
  FUN_18000c8d0(local_180);
  FUN_18000c8d0(local_1a0);
  FUN_18000c8d0(&local_280);
  local_260[0] = 0;
  local_260[1] = 0;
  local_260[2] = 0;
  local_260[3] = 0;
  uVar15 = 8;
  pcVar11 = "SLAVE_ID";
  FUN_18000c1d0(local_260,"SLAVE_ID",8);
  if (0x7fffffffffffffff - local_88 < 0x17) {
                    /* WARNING: Subroutine does not return */
    FUN_18000c940();
  }
  pppppppuVar8 = &local_98;
  if (0xf < uStack_80) {
    pppppppuVar8 = (undefined8 *******)local_98;
  }
  FUN_18000bff0(local_220,pcVar11,uVar15,"Configurations.Cameras.",0x17,pppppppuVar8,local_88);
  plVar6 = FUN_18000a490(local_220,&DAT_18017c428,3);
  local_280 = *plVar6;
  lStack_278 = plVar6[1];
  local_270 = plVar6[2];
  lStack_268 = plVar6[3];
  plVar6[2] = 0;
  plVar6[3] = 0xf;
  *(undefined1 *)plVar6 = 0;
  FUN_18000c8d0(local_220);
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            &local_280;
  FUN_1800f9c20(this,local_160,pbVar14,
                (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
                local_260);
  FUN_18000c8d0(local_160);
  FUN_18000c8d0(&local_280);
  FUN_18000c8d0(local_260);
  local_290 = 3.78351e-43;
  pbVar14 = (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_> *)
            FUN_180115a60(local_160,&local_98,pbVar14);
  bVar2 = Libraries::Core::Parameters::exist((Parameters *)(this + 0x10),pbVar14);
  if (bVar2) {
    pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
    Libraries::Core::Parameter::toInt(pPVar4);
  }
  else {
    pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
    Libraries::Core::Parameter::setValue(pPVar4,(int *)&local_290);
    pPVar4 = Libraries::Core::Parameters::get((Parameters *)(this + 0x10),pbVar14);
    Libraries::Core::Parameter::toInt(pPVar4);
    saveParameters(this);
  }
  FUN_18000c8d0(local_160);
  local_78 = (undefined8 ******)0x0;
  uStack_70 = 0;
  local_68 = 0;
  uStack_60 = 0;
  FUN_18000c1d0(&local_78,&DAT_18017ccf4,4);
  local_58 = 0;
  uStack_50 = 0;
  local_48 = 0;
  uStack_40 = 0;
  FUN_18000c1d0(&local_58,&DAT_18017ccec,4);
  ppppppuVar13 = &local_78;
  do {
    local_290 = 0.15;
    ppppppuVar12 = ppppppuVar13;
    if ((undefined8 *****)0xf < ppppppuVar13[3]) {
      ppppppuVar12 = (undefined8 ******)*ppppppuVar13;
    }
    lVar10 = lVar16;
    if (ppppppuVar13[2] == (undefined8 *****)0x4) {
      do {
        lVar9 = lVar10 + 1;
        if (*(char *)((longlong)ppppppuVar12 + lVar10) != (&DAT_18017ccec)[lVar10]) break;
        lVar10 = lVar9;
      } while (lVar9 != 4);
    }
    cv::format((char *)&local_280);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_280);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_280);
    local_290 = 1.0;
    ppppppuVar12 = ppppppuVar13;
    if ((undefined8 *****)0xf < ppppppuVar13[3]) {
      ppppppuVar12 = (undefined8 ******)*ppppppuVar13;
    }
    lVar10 = lVar16;
    if (ppppppuVar13[2] == (undefined8 *****)0x4) {
      do {
        lVar9 = lVar10 + 1;
        if (*(char *)((longlong)ppppppuVar12 + lVar10) != (&DAT_18017ccec)[lVar10]) break;
        lVar10 = lVar9;
      } while (lVar9 != 4);
    }
    cv::format((char *)&local_280);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_280);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_280);
    local_290 = 1.0;
    ppppppuVar12 = ppppppuVar13;
    if ((undefined8 *****)0xf < ppppppuVar13[3]) {
      ppppppuVar12 = (undefined8 ******)*ppppppuVar13;
    }
    lVar10 = lVar16;
    if (ppppppuVar13[2] == (undefined8 *****)0x4) {
      do {
        lVar9 = lVar10 + 1;
        if (*(char *)((longlong)ppppppuVar12 + lVar10) != (&DAT_18017ccec)[lVar10]) break;
        lVar10 = lVar9;
      } while (lVar9 != 4);
    }
    cv::format((char *)&local_280);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_280);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_280);
    local_290 = 1.0;
    ppppppuVar12 = ppppppuVar13;
    if ((undefined8 *****)0xf < ppppppuVar13[3]) {
      ppppppuVar12 = (undefined8 ******)*ppppppuVar13;
    }
    lVar10 = lVar16;
    if (ppppppuVar13[2] == (undefined8 *****)0x4) {
      do {
        lVar9 = lVar10 + 1;
        if (*(char *)((longlong)ppppppuVar12 + lVar10) != (&DAT_18017ccec)[lVar10]) break;
        lVar10 = lVar9;
      } while (lVar9 != 4);
    }
    cv::format((char *)&local_280);
    bVar2 = Libraries::Core::Parameters::exist
                      ((Parameters *)(this + 0x10),
                       (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                        *)&local_280);
    if (bVar2) {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
    }
    else {
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
      pPVar4 = Libraries::Core::Parameters::get
                         ((Parameters *)(this + 0x10),
                          (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                           *)&local_280);
      Libraries::Core::Parameter::toFloat(pPVar4);
      saveParameters(this);
    }
    FUN_18000c8d0(&local_280);
    ppppppuVar13 = ppppppuVar13 + 4;
    if (ppppppuVar13 == (undefined8 ******)local_38) {
      local_290 = -1.5;
      cv::format((char *)&local_280);
      bVar2 = Libraries::Core::Parameters::exist
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_280);
      if (bVar2) {
        pPVar4 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_280);
        Libraries::Core::Parameter::toFloat(pPVar4);
      }
      else {
        pPVar4 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_280);
        Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
        pPVar4 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_280);
        Libraries::Core::Parameter::toFloat(pPVar4);
        saveParameters(this);
      }
      FUN_18000c8d0(&local_280);
      local_290 = -1.5;
      cv::format((char *)&local_280);
      bVar2 = Libraries::Core::Parameters::exist
                        ((Parameters *)(this + 0x10),
                         (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                          *)&local_280);
      if (bVar2) {
        pPVar4 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_280);
        Libraries::Core::Parameter::toFloat(pPVar4);
      }
      else {
        pPVar4 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_280);
        Libraries::Core::Parameter::setValue(pPVar4,&local_290,3);
        pPVar4 = Libraries::Core::Parameters::get
                           ((Parameters *)(this + 0x10),
                            (basic_string<char,struct_std::char_traits<char>,class_std::allocator<char>_>
                             *)&local_280);
        Libraries::Core::Parameter::toFloat(pPVar4);
        saveParameters(this);
      }
      FUN_18000c8d0(&local_280);
      _eh_vector_destructor_iterator_(&local_78,0x20,2,thunk_FUN_18000c8d0);
      _eh_vector_destructor_iterator_(&local_b8,0x20,2,thunk_FUN_18000c8d0);
      return;
    }
  } while( true );
}

