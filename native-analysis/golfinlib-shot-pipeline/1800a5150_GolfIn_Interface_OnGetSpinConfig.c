FUNCTION: GolfIn::Interface::OnGetSpinConfig
ENTRY: 1800a5150
REASONS: name:spin


/* protected: class std::basic_string<char,struct std::char_traits<char>,class std::allocator<char>
   > __cdecl GolfIn::Interface::OnGetSpinConfig(int,double,double,float) __ptr64 */

undefined8 * __thiscall
GolfIn::Interface::OnGetSpinConfig
          (Interface *this,int param_1,double param_2,double param_3,float param_4)

{
  longlong *plVar1;
  undefined4 in_register_00000014;
  undefined8 *puVar2;
  undefined8 in_R8;
  undefined4 in_stack_0000002c;
  
                    /* 0xa5150  321
                       ?OnGetSpinConfig@Interface@GolfIn@@IEAA?AV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@HNNM@Z
                        */
  puVar2 = (undefined8 *)CONCAT44(in_register_00000014,param_1);
  plVar1 = *(longlong **)(this + 0x730);
  if (plVar1 != (longlong *)0x0) {
    (**(code **)(*plVar1 + 0x28))(plVar1,puVar2,in_R8,param_3,CONCAT44(in_stack_0000002c,param_4));
    return puVar2;
  }
  *puVar2 = 0;
  puVar2[1] = 0;
  puVar2[2] = 0;
  puVar2[3] = 0;
  FUN_18000c1d0(puVar2,"0.0,0.0",7);
  return puVar2;
}

