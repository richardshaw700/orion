FUNCTION: GolfIn::Interface::setCameraCallback
ENTRY: 1800a4af0
REASONS: name:setCameraCallback


/* public: void __cdecl GolfIn::Interface::setCameraCallback(class GICTS_NM::CameraCallback *
   __ptr64) __ptr64 */

void __thiscall GolfIn::Interface::setCameraCallback(Interface *this,CameraCallback *param_1)

{
  undefined8 *puVar1;
  
                    /* 0xa4af0  930
                       ?setCameraCallback@Interface@GolfIn@@QEAAXPEAVCameraCallback@GICTS_NM@@@Z */
  puVar1 = *(undefined8 **)(this + 0x730);
  if (puVar1 != (undefined8 *)0x0) {
    (**(code **)*puVar1)(puVar1,1);
  }
  *(CameraCallback **)(this + 0x730) = param_1;
  return;
}

