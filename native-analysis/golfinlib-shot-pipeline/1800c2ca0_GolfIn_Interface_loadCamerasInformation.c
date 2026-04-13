FUNCTION: GolfIn::Interface::loadCamerasInformation
ENTRY: 1800c2ca0
REASONS: name:loadCamera


/* public: class std::vector<struct GolfIn::Interface::CamerasInfoModel,class std::allocator<struct
   GolfIn::Interface::CamerasInfoModel> > __cdecl GolfIn::Interface::loadCamerasInformation(enum
   Libraries::CameraDeviceModelEnum,bool) __ptr64 */

undefined8 __thiscall
GolfIn::Interface::loadCamerasInformation
          (Interface *this,CameraDeviceModelEnum param_1,bool param_2)

{
  undefined4 in_register_00000014;
  
                    /* 0xc2ca0  774
                       ?loadCamerasInformation@Interface@GolfIn@@QEAA?AV?$vector@UCamerasInfoModel@Interface@GolfIn@@V?$allocator@UCamerasInfoModel@Interface@GolfIn@@@std@@@std@@W4CameraDeviceModelEnum@Libraries@@_N@Z
                        */
  initializeHikRobotCameras(this,param_1);
  return CONCAT44(in_register_00000014,param_1);
}

