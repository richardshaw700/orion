FUNCTION: CSharp_LightInterface_setCameraCallback
ENTRY: 1801256d0
REASONS: name:setCameraCallback


void CSharp_LightInterface_setCameraCallback(longlong param_1,undefined8 param_2)

{
  undefined8 *puVar1;
  
                    /* 0x1256d0  1174  CSharp_LightInterface_setCameraCallback */
  puVar1 = *(undefined8 **)(param_1 + 0xb8);
  if (puVar1 != (undefined8 *)0x0) {
    (**(code **)*puVar1)(puVar1,1);
  }
  *(undefined8 *)(param_1 + 0xb8) = param_2;
  return;
}

